package com.gorilla.base.service;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.Application;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.ClipData;
import android.content.ComponentName;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.pm.ActivityInfo;
import android.content.pm.PackageManager;
import android.content.pm.ResolveInfo;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.text.TextUtils;
import android.webkit.MimeTypeMap;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.baidu.mobads.sdk.internal.an;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.gorilla.base.GorillaContext;
import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import com.gorilla.base.log.ILogger;
import com.gorilla.base.log.LogFactory;
import com.gorilla.base.model.SystemShareArgs;
import com.gorilla.base.util.GorillaFileProviderUtils;
import java.io.BufferedReader;
import java.io.File;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;
import java.util.List;
import java.util.Locale;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicInteger;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class SystemShareService {
    public static final int SHARE_TYPE_IMAGE = 1;
    public static final int SHARE_TYPE_LINK = 3;
    public static final int SHARE_TYPE_VIDEO = 2;
    private static final String TAG = "[SystemShareService]";
    private static final ILogger logger = LogFactory.getLogger();
    private static final AtomicInteger REQUEST_CODE = new AtomicInteger(1000);
    private static int isXiaomiOrMiui = 0;

    private static String safeString(String str) {
        return str == null ? "" : str;
    }

    public static void share(final JSONObject jSONObject, final ISuccessCallback iSuccessCallback, final IFailureCallback iFailureCallback, final ICancelCallback iCancelCallback) {
        ILogger iLogger = logger;
        iLogger.log(TAG, "share: " + jSONObject);
        Activity activity = GorillaContext.getInstance() != null ? GorillaContext.getInstance().getActivity() : null;
        if (activity == null) {
            iLogger.error(TAG, "Activity not initialized. Call Api.init first.");
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "Activity not initialized. Call Api.init first.");
                return;
            }
            return;
        }
        if (jSONObject == null) {
            iLogger.error(TAG, "Share args cannot be null.");
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "Share args cannot be null.");
                return;
            }
            return;
        }
        final Activity activity2 = activity;
        activity.runOnUiThread(new Runnable() { // from class: com.gorilla.base.service.SystemShareService$$ExternalSyntheticLambda2
            @Override // java.lang.Runnable
            public final void run() {
                SystemShareService.lambda$share$0(activity2, iFailureCallback, jSONObject, iSuccessCallback, iCancelCallback);
            }
        });
    }

    static /* synthetic */ void lambda$share$0(Activity activity, IFailureCallback iFailureCallback, JSONObject jSONObject, ISuccessCallback iSuccessCallback, ICancelCallback iCancelCallback) {
        try {
            if (!isActivityReady(activity)) {
                if (iFailureCallback != null) {
                    iFailureCallback.onFailure(-1, "Activity is not ready to launch share.");
                    return;
                }
                return;
            }
            SharePayload sharePayloadBuildSharePayload = buildSharePayload(activity, jSONObject);
            if (sharePayloadBuildSharePayload == null) {
                if (iFailureCallback != null) {
                    iFailureCallback.onFailure(-1, "Invalid share parameters.");
                    return;
                }
                return;
            }
            boolean z = false;
            if (((iSuccessCallback == null && iCancelCallback == null) ? false : true) && shouldUseCustomDialog(activity)) {
                z = true;
            }
            if (z) {
                showCustomShareDialog(activity, sharePayloadBuildSharePayload, iSuccessCallback, iFailureCallback, iCancelCallback);
            } else {
                launchSystemChooser(activity, sharePayloadBuildSharePayload, iSuccessCallback, iFailureCallback, iCancelCallback);
            }
        } catch (Exception e) {
            logger.error(TAG, "Share failed: " + e.getMessage());
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "Share failed: " + e.getMessage());
            }
        }
    }

    private static SharePayload buildSharePayload(Activity activity, JSONObject jSONObject) {
        Uri uriResolveFileUri;
        SystemShareArgs systemShareArgsFromJson = SystemShareArgs.fromJson(jSONObject);
        if (systemShareArgsFromJson == null) {
            return null;
        }
        int iResolveShareType = resolveShareType(systemShareArgsFromJson);
        if (iResolveShareType == 0) {
            iResolveShareType = inferShareType(activity, systemShareArgsFromJson);
        }
        if (iResolveShareType == 0) {
            logger.error(TAG, "Unknown share type.");
            return null;
        }
        Intent intent = new Intent("android.intent.action.SEND");
        String strSafeString = safeString(systemShareArgsFromJson.getTitle());
        if (!TextUtils.isEmpty(strSafeString)) {
            intent.putExtra("android.intent.extra.SUBJECT", strSafeString);
        }
        String strBuildShareText = buildShareText(systemShareArgsFromJson);
        if (iResolveShareType == 3) {
            if (TextUtils.isEmpty(strBuildShareText)) {
                logger.error(TAG, "Missing url/title for link share.");
                return null;
            }
            intent.setType(an.e);
            intent.putExtra("android.intent.extra.TEXT", strBuildShareText);
            uriResolveFileUri = null;
        } else {
            String fileLocation = systemShareArgsFromJson.getFileLocation();
            if (TextUtils.isEmpty(fileLocation)) {
                logger.error(TAG, "Missing file path for share.");
                return null;
            }
            if (!fileLocation.startsWith("content://")) {
                if (!new File(fileLocation.startsWith("file://") ? Uri.parse(fileLocation).getPath() : fileLocation).exists()) {
                    logger.error(TAG, "Share file does not exist.");
                    return null;
                }
            }
            uriResolveFileUri = resolveFileUri(activity, fileLocation);
            if (uriResolveFileUri == null) {
                logger.error(TAG, "Invalid file path for share.");
                return null;
            }
            String mimeType = systemShareArgsFromJson.getMimeType();
            String str = iResolveShareType == 1 ? "image/*" : "video/*";
            if (TextUtils.isEmpty(mimeType)) {
                mimeType = getMimeType(activity, uriResolveFileUri, fileLocation, str);
            }
            if (TextUtils.isEmpty(mimeType)) {
                str = "*/*";
            } else if ((iResolveShareType != 1 || mimeType.startsWith("image/")) && (iResolveShareType != 2 || mimeType.startsWith("video/"))) {
                str = mimeType;
            }
            intent.setType(str);
            intent.setDataAndType(uriResolveFileUri, str);
            intent.putExtra("android.intent.extra.STREAM", uriResolveFileUri);
            if (!TextUtils.isEmpty(strBuildShareText)) {
                intent.putExtra("android.intent.extra.TEXT", strBuildShareText);
            }
            intent.addFlags(1);
            attachClipData(activity, intent, uriResolveFileUri);
        }
        return new SharePayload(intent, uriResolveFileUri, safeString(systemShareArgsFromJson.getChooserTitle("Share")));
    }

    private static int resolveShareType(SystemShareArgs systemShareArgs) {
        int shareType = systemShareArgs.getShareType();
        if (shareType != 0) {
            return shareType;
        }
        return 0;
    }

    /* JADX WARN: Multi-variable type inference failed */
    private static void launchSystemChooser(Activity activity, SharePayload sharePayload, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        if (!hasShareTargets(activity, sharePayload.intent)) {
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "No apps can perform this action.");
                return;
            }
            return;
        }
        grantUriPermissions(activity, sharePayload.intent, sharePayload.fileUri);
        Intent intentCreateChooser = Intent.createChooser(sharePayload.intent, sharePayload.chooserTitle);
        ShareSession shareSession = null;
        Object[] objArr = 0;
        if (iSuccessCallback != null || iCancelCallback != null) {
            ShareSession shareSession2 = new ShareSession(activity, iSuccessCallback, iCancelCallback);
            shareSession2.registerLifecycleCallbacks();
            String strBuildChooserAction = buildChooserAction(activity);
            shareSession2.registerChooserReceiver(strBuildChooserAction);
            shareSession = shareSession2;
            intentCreateChooser = Intent.createChooser(sharePayload.intent, sharePayload.chooserTitle, createChooserPendingIntent(activity, strBuildChooserAction).getIntentSender());
        }
        try {
            activity.startActivity(intentCreateChooser);
        } catch (Exception e) {
            if (shareSession != null) {
                shareSession.finishSession();
            }
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "Share failed: " + e.getMessage());
            }
        }
    }

    private static void showCustomShareDialog(final Activity activity, final SharePayload sharePayload, final ISuccessCallback iSuccessCallback, final IFailureCallback iFailureCallback, final ICancelCallback iCancelCallback) {
        PackageManager packageManager = activity.getPackageManager();
        List<ResolveInfo> listQueryIntentActivities = packageManager.queryIntentActivities(sharePayload.intent, 65536);
        removeUnexportedActivities(listQueryIntentActivities);
        if (listQueryIntentActivities.isEmpty()) {
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "No apps can perform this action.");
                return;
            }
            return;
        }
        final ArrayList arrayList = new ArrayList(listQueryIntentActivities);
        Collections.sort(arrayList, new ResolveInfo.DisplayNameComparator(packageManager));
        CharSequence[] charSequenceArr = new CharSequence[arrayList.size()];
        for (int i = 0; i < arrayList.size(); i++) {
            charSequenceArr[i] = ((ResolveInfo) arrayList.get(i)).loadLabel(packageManager);
        }
        new AlertDialog.Builder(activity).setTitle(sharePayload.chooserTitle).setItems(charSequenceArr, new DialogInterface.OnClickListener() { // from class: com.gorilla.base.service.SystemShareService$$ExternalSyntheticLambda0
            @Override // android.content.DialogInterface.OnClickListener
            public final void onClick(DialogInterface dialogInterface, int i2) {
                SystemShareService.lambda$showCustomShareDialog$1(arrayList, sharePayload, activity, iSuccessCallback, iFailureCallback, dialogInterface, i2);
            }
        }).setOnCancelListener(new DialogInterface.OnCancelListener() { // from class: com.gorilla.base.service.SystemShareService$$ExternalSyntheticLambda1
            @Override // android.content.DialogInterface.OnCancelListener
            public final void onCancel(DialogInterface dialogInterface) {
                SystemShareService.lambda$showCustomShareDialog$2(iCancelCallback, dialogInterface);
            }
        }).create().show();
    }

    static /* synthetic */ void lambda$showCustomShareDialog$1(List list, SharePayload sharePayload, Activity activity, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, DialogInterface dialogInterface, int i) {
        ResolveInfo resolveInfo = (ResolveInfo) list.get(i);
        String str = resolveInfo.activityInfo.packageName;
        String str2 = resolveInfo.activityInfo.name;
        Intent intent = new Intent(sharePayload.intent);
        intent.setComponent(new ComponentName(str, str2));
        grantUriPermission(activity, str, sharePayload.fileUri);
        attachClipData(activity, intent, sharePayload.fileUri);
        try {
            activity.startActivity(intent);
            if (iSuccessCallback != null) {
                iSuccessCallback.onSuccess(str + "/" + str2);
            }
        } catch (Exception e) {
            if (iFailureCallback != null) {
                iFailureCallback.onFailure(-1, "Share failed: " + e.getMessage());
            }
        }
    }

    static /* synthetic */ void lambda$showCustomShareDialog$2(ICancelCallback iCancelCallback, DialogInterface dialogInterface) {
        if (iCancelCallback != null) {
            iCancelCallback.onCancel();
        }
    }

    private static boolean shouldUseCustomDialog(Activity activity) {
        if (isHuawei()) {
            return true;
        }
        if (isXiaomiOrMiui()) {
            return Build.VERSION.SDK_INT == 30 || isLandscape(activity);
        }
        return false;
    }

    private static boolean isHuawei() {
        return "huawei".equalsIgnoreCase(Build.MANUFACTURER);
    }

    private static boolean isXiaomiOrMiui() throws Throwable {
        BufferedReader bufferedReader;
        Throwable th;
        int i = isXiaomiOrMiui;
        if (i > 0) {
            return true;
        }
        if (i < 0) {
            return false;
        }
        if (MediationConstant.ADN_XIAOMI.equalsIgnoreCase(Build.MANUFACTURER)) {
            isXiaomiOrMiui = 1;
            return true;
        }
        BufferedReader bufferedReader2 = null;
        try {
            try {
                bufferedReader = new BufferedReader(new InputStreamReader(Runtime.getRuntime().exec("getprop ro.miui.ui.version.name").getInputStream()), 1024);
                try {
                    if (!TextUtils.isEmpty(bufferedReader.readLine())) {
                        isXiaomiOrMiui = 1;
                        try {
                            bufferedReader.close();
                        } catch (Exception unused) {
                        }
                        return true;
                    }
                    bufferedReader.close();
                } catch (Exception unused2) {
                    bufferedReader2 = bufferedReader;
                    if (bufferedReader2 != null) {
                        bufferedReader2.close();
                    }
                    isXiaomiOrMiui = -1;
                    return false;
                } catch (Throwable th2) {
                    th = th2;
                    if (bufferedReader != null) {
                        try {
                            bufferedReader.close();
                        } catch (Exception unused3) {
                        }
                    }
                    throw th;
                }
            } catch (Exception unused4) {
            }
        } catch (Exception unused5) {
        } catch (Throwable th3) {
            bufferedReader = null;
            th = th3;
        }
        isXiaomiOrMiui = -1;
        return false;
    }

    private static boolean isLandscape(Activity activity) {
        return activity.getResources().getConfiguration().orientation == 2;
    }

    private static boolean isActivityReady(Activity activity) {
        if (activity == null) {
            logger.error(TAG, "Activity is null.");
            return false;
        }
        if (activity.isFinishing()) {
            logger.error(TAG, "Activity is finishing.");
            return false;
        }
        if (!activity.isDestroyed()) {
            return true;
        }
        logger.error(TAG, "Activity is destroyed.");
        return false;
    }

    private static int inferShareType(Activity activity, SystemShareArgs systemShareArgs) {
        String fileLocation = systemShareArgs.getFileLocation();
        if (TextUtils.isEmpty(fileLocation)) {
            return (TextUtils.isEmpty(systemShareArgs.getUrl()) && TextUtils.isEmpty(systemShareArgs.getTitle())) ? 0 : 3;
        }
        String mimeType = systemShareArgs.getMimeType();
        if (TextUtils.isEmpty(mimeType)) {
            mimeType = getMimeType(activity, fileLocation.startsWith("content://") ? Uri.parse(fileLocation) : null, fileLocation, "");
        }
        if (!TextUtils.isEmpty(mimeType)) {
            if (mimeType.startsWith("video/")) {
                return 2;
            }
            if (mimeType.startsWith("image/")) {
                return 1;
            }
        }
        return 0;
    }

    private static Uri resolveFileUri(Activity activity, String str) {
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        if (str.startsWith("content://")) {
            return Uri.parse(str);
        }
        if (str.startsWith("file://")) {
            str = Uri.parse(str).getPath();
        }
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        File file = new File(str);
        if (!file.exists()) {
            return null;
        }
        Uri uriForFile = GorillaFileProviderUtils.getUriForFile(activity, file);
        if (uriForFile == null) {
            logger.error(TAG, "FileProvider failed for path: " + str);
        }
        return uriForFile;
    }

    private static String getMimeType(Activity activity, Uri uri, String str, String str2) {
        if (activity != null && uri != null && IAdInterListener.AdProdType.PRODUCT_CONTENT.equalsIgnoreCase(uri.getScheme())) {
            try {
                String type = activity.getContentResolver().getType(uri);
                if (!TextUtils.isEmpty(type)) {
                    return type;
                }
            } catch (Exception e) {
                logger.error(TAG, "Failed to resolve mime type from content uri: " + e.getMessage());
            }
        }
        if (TextUtils.isEmpty(str)) {
            return str2;
        }
        String fileExtensionFromUrl = MimeTypeMap.getFileExtensionFromUrl(str);
        if (TextUtils.isEmpty(fileExtensionFromUrl)) {
            return str2;
        }
        String mimeTypeFromExtension = MimeTypeMap.getSingleton().getMimeTypeFromExtension(fileExtensionFromUrl.toLowerCase(Locale.ENGLISH));
        return TextUtils.isEmpty(mimeTypeFromExtension) ? str2 : mimeTypeFromExtension;
    }

    private static String buildShareText(SystemShareArgs systemShareArgs) {
        String url = systemShareArgs.getUrl();
        String title = systemShareArgs.getTitle();
        if (TextUtils.isEmpty(url)) {
            return title;
        }
        if (TextUtils.isEmpty(title)) {
            return url;
        }
        String strTrim = url.trim();
        String strTrim2 = title.trim();
        if (TextUtils.isEmpty(strTrim)) {
            return title;
        }
        if (TextUtils.isEmpty(strTrim2)) {
            return url;
        }
        return strTrim2.contains(strTrim) ? title : title + "\n" + url;
    }

    private static void grantUriPermissions(Activity activity, Intent intent, Uri uri) {
        if (uri == null) {
            return;
        }
        List<ResolveInfo> listQueryIntentActivities = activity.getPackageManager().queryIntentActivities(intent, 65536);
        removeUnexportedActivities(listQueryIntentActivities);
        Iterator<ResolveInfo> it = listQueryIntentActivities.iterator();
        while (it.hasNext()) {
            grantUriPermission(activity, it.next().activityInfo.packageName, uri);
        }
    }

    private static void grantUriPermission(Activity activity, String str, Uri uri) {
        if (uri == null) {
            return;
        }
        try {
            activity.grantUriPermission(str, uri, 1);
        } catch (Exception e) {
            logger.error(TAG, "grantUriPermission failed for " + str + ": " + e.getMessage());
        }
    }

    private static void attachClipData(Context context, Intent intent, Uri uri) {
        if (context == null || intent == null || uri == null || intent.getClipData() != null) {
            return;
        }
        try {
            intent.setClipData(ClipData.newUri(context.getContentResolver(), "gorilla_share", uri));
        } catch (Exception e) {
            logger.error(TAG, "attachClipData failed: " + e.getMessage());
        }
    }

    private static String buildChooserAction(Activity activity) {
        return activity.getPackageName() + ".gorilla.share.CHOSEN." + System.nanoTime();
    }

    private static PendingIntent createChooserPendingIntent(Activity activity, String str) {
        Intent intent = new Intent(str);
        intent.setPackage(activity.getPackageName());
        return PendingIntent.getBroadcast(activity, REQUEST_CODE.incrementAndGet(), intent, Build.VERSION.SDK_INT >= 31 ? 201326592 : 134217728);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void unregisterReceiverSafely(Activity activity, BroadcastReceiver broadcastReceiver) {
        try {
            activity.unregisterReceiver(broadcastReceiver);
        } catch (IllegalArgumentException unused) {
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    static class SharePayload {
        private final String chooserTitle;
        private final Uri fileUri;
        private final Intent intent;

        private SharePayload(Intent intent, Uri uri, String str) {
            this.intent = intent;
            this.fileUri = uri;
            this.chooserTitle = str;
        }
    }

    private static class ShareSession implements Application.ActivityLifecycleCallbacks {
        private final Activity activity;
        private final ICancelCallback cancelCallback;
        private final AtomicBoolean completed;
        private BroadcastReceiver receiver;
        private final ISuccessCallback successCallback;
        private final AtomicBoolean targetSelected;

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityCreated(Activity activity, Bundle bundle) {
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityPaused(Activity activity) {
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivitySaveInstanceState(Activity activity, Bundle bundle) {
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityStarted(Activity activity) {
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityStopped(Activity activity) {
        }

        private ShareSession(Activity activity, ISuccessCallback iSuccessCallback, ICancelCallback iCancelCallback) {
            this.targetSelected = new AtomicBoolean(false);
            this.completed = new AtomicBoolean(false);
            this.activity = activity;
            this.successCallback = iSuccessCallback;
            this.cancelCallback = iCancelCallback;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void registerLifecycleCallbacks() {
            this.activity.getApplication().registerActivityLifecycleCallbacks(this);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void registerChooserReceiver(String str) {
            this.receiver = new BroadcastReceiver() { // from class: com.gorilla.base.service.SystemShareService.ShareSession.1
                @Override // android.content.BroadcastReceiver
                public void onReceive(Context context, Intent intent) {
                    ShareSession.this.targetSelected.set(true);
                    if (ShareSession.this.successCallback != null) {
                        ComponentName componentName = (ComponentName) intent.getParcelableExtra("android.intent.extra.CHOSEN_COMPONENT");
                        ShareSession.this.successCallback.onSuccess(componentName == null ? "" : componentName.flattenToString());
                    }
                    ShareSession.this.finishSession();
                }
            };
            IntentFilter intentFilter = new IntentFilter(str);
            if (Build.VERSION.SDK_INT >= 33) {
                this.activity.registerReceiver(this.receiver, intentFilter, 4);
            } else {
                this.activity.registerReceiver(this.receiver, intentFilter);
            }
        }

        /* JADX INFO: Access modifiers changed from: private */
        public void finishSession() {
            if (this.completed.compareAndSet(false, true)) {
                BroadcastReceiver broadcastReceiver = this.receiver;
                if (broadcastReceiver != null) {
                    SystemShareService.unregisterReceiverSafely(this.activity, broadcastReceiver);
                }
                this.activity.getApplication().unregisterActivityLifecycleCallbacks(this);
            }
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityResumed(Activity activity) {
            if (activity != this.activity || this.targetSelected.get()) {
                return;
            }
            ICancelCallback iCancelCallback = this.cancelCallback;
            if (iCancelCallback != null) {
                iCancelCallback.onCancel();
            }
            finishSession();
        }

        @Override // android.app.Application.ActivityLifecycleCallbacks
        public void onActivityDestroyed(Activity activity) {
            if (activity != this.activity || this.targetSelected.get()) {
                return;
            }
            ICancelCallback iCancelCallback = this.cancelCallback;
            if (iCancelCallback != null) {
                iCancelCallback.onCancel();
            }
            finishSession();
        }
    }

    private static void removeUnexportedActivities(List<ResolveInfo> list) {
        for (int size = list.size() - 1; size >= 0; size--) {
            ActivityInfo activityInfo = list.get(size).activityInfo;
            if (activityInfo == null || !activityInfo.exported) {
                list.remove(size);
            }
        }
    }

    private static boolean hasShareTargets(Activity activity, Intent intent) {
        List<ResolveInfo> listQueryIntentActivities = activity.getPackageManager().queryIntentActivities(intent, 65536);
        removeUnexportedActivities(listQueryIntentActivities);
        return !listQueryIntentActivities.isEmpty();
    }
}
