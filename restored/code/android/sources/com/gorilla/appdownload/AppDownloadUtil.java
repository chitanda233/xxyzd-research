package com.gorilla.appdownload;

import android.app.Activity;
import android.app.FragmentManager;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.os.Build;
import android.text.TextUtils;
import android.widget.Toast;
import androidx.core.app.NotificationCompat;
import androidx.core.content.ContextCompat;
import com.bykv.vk.component.ttvideo.player.C;
import com.gorilla.base.log.ILogger;
import com.gorilla.base.log.LogFactory;
import com.gorilla.base.util.GorillaFileProviderUtils;
import java.io.File;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
public final class AppDownloadUtil {
    private static final String APK_MIME_TYPE = "application/vnd.android.package-archive";
    private static final String CHANNEL_ID = "gorilla_app_download";
    private static final long MIN_NOTIFICATION_UPDATE_INTERVAL_MS = 500;
    private static final int NOTIFICATION_ID = 4669764;
    private static final String TAG = "GorillaAppDownload";
    private static AppDownloadDialog currentDialog;
    private static ApkDownloadTask currentTask;
    private static boolean installing;
    private static WeakReference<Activity> lastActivityRef;
    private static File lastApkFile;
    private static long lastNotificationUpdateTimeMs;
    private static final ILogger logger = LogFactory.getLogger();

    private AppDownloadUtil() {
    }

    public static synchronized void StartDownload(final Activity activity, final String str, boolean z, final boolean z2, final IDownloadResult iDownloadResult, final IDownloadProgress iDownloadProgress) {
        logger.log(TAG, "StartDownload url:" + str + ", showUI:" + z);
        if (activity == null) {
            notifyResult(iDownloadResult, -1, "Unity activity is null.");
            return;
        }
        if (TextUtils.isEmpty(str)) {
            notifyResult(iDownloadResult, -1, "downloadUrl is empty.");
            return;
        }
        ApkDownloadTask apkDownloadTask = currentTask;
        if (apkDownloadTask != null && apkDownloadTask.isRunning()) {
            notifyResult(iDownloadResult, -1, "Download is already running.");
            return;
        }
        installing = false;
        lastNotificationUpdateTimeMs = 0L;
        lastActivityRef = new WeakReference<>(activity);
        createNotificationChannel(activity);
        ApkDownloadTask apkDownloadTask2 = new ApkDownloadTask(activity, str, new ApkDownloadTask.Listener() { // from class: com.gorilla.appdownload.AppDownloadUtil.1
            @Override // com.gorilla.appdownload.ApkDownloadTask.Listener
            public void onProgress(int i) {
                AppDownloadUtil.notifyProgress(iDownloadProgress, i);
                AppDownloadUtil.updateNotification(activity, i, null);
                if (AppDownloadUtil.currentDialog != null) {
                    AppDownloadUtil.currentDialog.onProgress(i);
                }
            }

            @Override // com.gorilla.appdownload.ApkDownloadTask.Listener
            public void onComplete(File file) {
                AppDownloadUtil.lastApkFile = file;
                AppDownloadUtil.notifyResult(iDownloadResult, 0, "download complete");
                AppDownloadUtil.updateNotification(activity, 100, file);
                if (AppDownloadUtil.currentDialog != null) {
                    AppDownloadUtil.currentDialog.onComplete();
                }
                AppDownloadUtil.installProcess(activity, file, z2, iDownloadResult);
            }

            @Override // com.gorilla.appdownload.ApkDownloadTask.Listener
            public void onCancelled() {
                AppDownloadUtil.cancelNotification(activity);
                if (AppDownloadUtil.currentDialog != null) {
                    AppDownloadUtil.currentDialog.onFailed();
                }
                AppDownloadUtil.notifyResult(iDownloadResult, -1, "download cancelled");
            }

            @Override // com.gorilla.appdownload.ApkDownloadTask.Listener
            public void onFailure(Exception exc) {
                AppDownloadUtil.cancelNotification(activity);
                if (AppDownloadUtil.currentDialog != null) {
                    AppDownloadUtil.currentDialog.onFailed();
                }
                AppDownloadUtil.notifyResult(iDownloadResult, -1, exc == null ? "download failed" : exc.toString());
            }
        });
        currentTask = apkDownloadTask2;
        updateNotification(activity, 0, null);
        if (z) {
            activity.runOnUiThread(new Runnable() { // from class: com.gorilla.appdownload.AppDownloadUtil$$ExternalSyntheticLambda5
                @Override // java.lang.Runnable
                public final void run() {
                    AppDownloadUtil.lambda$StartDownload$3(activity, str, z2, iDownloadResult, iDownloadProgress);
                }
            });
        }
        apkDownloadTask2.start();
    }

    static /* synthetic */ void lambda$StartDownload$3(final Activity activity, final String str, final boolean z, final IDownloadResult iDownloadResult, final IDownloadProgress iDownloadProgress) {
        dismissDialog();
        AppDownloadDialog appDownloadDialog = new AppDownloadDialog(activity, new Runnable() { // from class: com.gorilla.appdownload.AppDownloadUtil$$ExternalSyntheticLambda2
            @Override // java.lang.Runnable
            public final void run() {
                AppDownloadUtil.cancelCurrentDownload();
            }
        }, new Runnable() { // from class: com.gorilla.appdownload.AppDownloadUtil$$ExternalSyntheticLambda3
            @Override // java.lang.Runnable
            public final void run() {
                AppDownloadUtil.StartDownload(activity, str, true, z, iDownloadResult, iDownloadProgress);
            }
        }, new Runnable() { // from class: com.gorilla.appdownload.AppDownloadUtil$$ExternalSyntheticLambda4
            @Override // java.lang.Runnable
            public final void run() {
                AppDownloadUtil.installLastApk(z, iDownloadResult);
            }
        });
        currentDialog = appDownloadDialog;
        appDownloadDialog.show();
    }

    public static synchronized boolean IsRunning() {
        ApkDownloadTask apkDownloadTask;
        apkDownloadTask = currentTask;
        return apkDownloadTask != null && apkDownloadTask.isRunning();
    }

    public static synchronized void CleanApk(Activity activity) {
        if (activity == null) {
            return;
        }
        File[] fileArrListFiles = ApkDownloadTask.getDownloadDir(activity).listFiles();
        if (fileArrListFiles == null) {
            return;
        }
        for (File file : fileArrListFiles) {
            if (file.isFile() && file.getName().toLowerCase().endsWith(".apk") && !file.delete()) {
                logger.warning(TAG, "Delete apk failed: " + file.getAbsolutePath());
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    public static synchronized void cancelCurrentDownload() {
        ApkDownloadTask apkDownloadTask = currentTask;
        if (apkDownloadTask != null) {
            apkDownloadTask.cancel();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static synchronized void installLastApk(boolean z, IDownloadResult iDownloadResult) {
        Activity currentActivity = getCurrentActivity();
        if (currentActivity == null) {
            notifyResult(iDownloadResult, -1, "Activity is not available.");
            return;
        }
        File file = lastApkFile;
        if (file != null && file.exists()) {
            installProcess(currentActivity, lastApkFile, z, iDownloadResult);
            return;
        }
        notifyResult(iDownloadResult, -1, "APK file does not exist.");
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void installProcess(final Activity activity, final File file, final boolean z, final IDownloadResult iDownloadResult) {
        if (installing) {
            return;
        }
        if (file == null || !file.exists()) {
            notifyResult(iDownloadResult, -1, "APK file does not exist.");
            return;
        }
        if (!activity.getPackageManager().canRequestPackageInstalls()) {
            requestInstallPermission(activity, new IPermissionResult() { // from class: com.gorilla.appdownload.AppDownloadUtil$$ExternalSyntheticLambda0
                @Override // com.gorilla.appdownload.IPermissionResult
                public final void onPermissionResult(boolean z2) {
                    AppDownloadUtil.lambda$installProcess$4(activity, file, z, iDownloadResult, z2);
                }
            });
            return;
        }
        installing = true;
        try {
            try {
                Uri uriForFile = GorillaFileProviderUtils.getUriForFile(activity, file);
                if (uriForFile == null) {
                    notifyResult(iDownloadResult, -1, "Create APK uri failed.");
                    return;
                }
                Intent intent = new Intent("android.intent.action.VIEW");
                intent.setDataAndType(uriForFile, "application/vnd.android.package-archive");
                intent.addFlags(C.ENCODING_PCM_MU_LAW);
                intent.addFlags(1);
                activity.startActivity(intent);
                notifyResult(iDownloadResult, 1, "start install apk");
            } catch (Exception e) {
                notifyResult(iDownloadResult, -1, e.toString());
            }
        } finally {
            installing = false;
        }
    }

    static /* synthetic */ void lambda$installProcess$4(Activity activity, File file, boolean z, IDownloadResult iDownloadResult, boolean z2) {
        if (z2) {
            installProcess(activity, file, z, iDownloadResult);
        } else if (z) {
            installProcess(activity, file, true, iDownloadResult);
        } else {
            Toast.makeText(activity, activity.getString(R.string.gorilla_app_download_install_permission_denied), 1).show();
            notifyResult(iDownloadResult, -1, "install permission denied");
        }
    }

    private static void requestInstallPermission(final Activity activity, final IPermissionResult iPermissionResult) {
        activity.runOnUiThread(new Runnable() { // from class: com.gorilla.appdownload.AppDownloadUtil$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                AppDownloadUtil.lambda$requestInstallPermission$5(activity, iPermissionResult);
            }
        });
    }

    static /* synthetic */ void lambda$requestInstallPermission$5(Activity activity, IPermissionResult iPermissionResult) {
        try {
            FragmentManager fragmentManager = activity.getFragmentManager();
            AppDownloadPermissionFragment appDownloadPermissionFragment = (AppDownloadPermissionFragment) fragmentManager.findFragmentByTag("AppDownloadPermissionFragment");
            if (appDownloadPermissionFragment == null) {
                appDownloadPermissionFragment = new AppDownloadPermissionFragment();
                fragmentManager.beginTransaction().add(appDownloadPermissionFragment, "AppDownloadPermissionFragment").commitAllowingStateLoss();
                fragmentManager.executePendingTransactions();
            }
            appDownloadPermissionFragment.requestInstallPermission(iPermissionResult);
        } catch (Exception unused) {
            iPermissionResult.onPermissionResult(false);
        }
    }

    private static void createNotificationChannel(Context context) {
        NotificationManager notificationManager = (NotificationManager) context.getSystemService("notification");
        if (notificationManager == null) {
            return;
        }
        notificationManager.createNotificationChannel(new NotificationChannel(CHANNEL_ID, context.getString(R.string.gorilla_app_download_notification_channel), 2));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void updateNotification(Context context, int i, File file) {
        NotificationManager notificationManager;
        Uri uriForFile;
        long jCurrentTimeMillis = System.currentTimeMillis();
        if (!(i >= 100 || file != null)) {
            long j = lastNotificationUpdateTimeMs;
            if (j > 0 && jCurrentTimeMillis - j < MIN_NOTIFICATION_UPDATE_INTERVAL_MS) {
                return;
            }
        }
        lastNotificationUpdateTimeMs = jCurrentTimeMillis;
        if ((Build.VERSION.SDK_INT < 33 || ContextCompat.checkSelfPermission(context, "android.permission.POST_NOTIFICATIONS") == 0) && (notificationManager = (NotificationManager) context.getSystemService("notification")) != null) {
            NotificationCompat.Builder progress = new NotificationCompat.Builder(context, CHANNEL_ID).setSmallIcon(android.R.drawable.stat_sys_download).setContentTitle(context.getString(R.string.gorilla_app_download_title)).setContentText(context.getString(R.string.gorilla_app_download_downloading) + " " + i + "%").setOnlyAlertOnce(true).setOngoing(i < 100).setAutoCancel(i >= 100).setProgress(100, i, false);
            if (file != null && file.exists() && (uriForFile = GorillaFileProviderUtils.getUriForFile(context, file)) != null) {
                Intent intent = new Intent("android.intent.action.VIEW");
                intent.setDataAndType(uriForFile, "application/vnd.android.package-archive");
                intent.addFlags(1);
                intent.addFlags(C.ENCODING_PCM_MU_LAW);
                progress.setContentIntent(PendingIntent.getActivity(context, 0, intent, 201326592));
                progress.setSmallIcon(android.R.drawable.stat_sys_download_done);
                progress.setContentText(context.getString(R.string.gorilla_app_download_complete));
            }
            try {
                notificationManager.notify(NOTIFICATION_ID, progress.build());
            } catch (SecurityException unused) {
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void cancelNotification(Context context) {
        NotificationManager notificationManager = (NotificationManager) context.getSystemService("notification");
        if (notificationManager != null) {
            notificationManager.cancel(NOTIFICATION_ID);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void notifyResult(IDownloadResult iDownloadResult, int i, String str) {
        if (iDownloadResult != null) {
            iDownloadResult.OnResult(i, str);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void notifyProgress(IDownloadProgress iDownloadProgress, int i) {
        if (iDownloadProgress != null) {
            iDownloadProgress.OnProgress(i);
        }
    }

    private static Activity getCurrentActivity() {
        WeakReference<Activity> weakReference = lastActivityRef;
        Activity activity = weakReference == null ? null : weakReference.get();
        if (activity == null || activity.isFinishing() || activity.isDestroyed()) {
            return null;
        }
        return activity;
    }

    private static void dismissDialog() {
        AppDownloadDialog appDownloadDialog = currentDialog;
        if (appDownloadDialog == null) {
            return;
        }
        try {
            appDownloadDialog.dismiss();
        } catch (Exception unused) {
        }
        currentDialog = null;
    }
}
