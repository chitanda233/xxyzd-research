package com.sigmob.sdk.base.utils;

import android.app.Activity;
import android.app.ActivityOptions;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.graphics.Rect;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.view.View;
import android.view.WindowInsets;
import com.byazt.bv.BaseConstants;
import com.bykv.vk.component.ttvideo.player.C;
import com.czhj.sdk.common.exceptions.IntentNotResolvableException;
import com.czhj.sdk.common.utils.AppPackageUtil;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.sdk.logger.SigmobLogger;
import java.io.File;
import java.lang.reflect.Field;
import java.lang.reflect.Method;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class h {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3255a = "h";

    private h() {
    }

    public static Intent a(Context context, Class<?> clazz, Bundle extras) {
        Intent intent = new Intent(context, clazz);
        intent.addFlags(C.ENCODING_PCM_MU_LAW);
        if (v.b(extras)) {
            intent.putExtras(extras);
        }
        return intent;
    }

    private static Uri a(Intent intent) {
        Preconditions.NoThrow.checkNotNull(intent);
        return Uri.parse(BaseConstants.MARKET_PREFIX + intent.getPackage());
    }

    public static String a(Context context, Uri uri, List<String> packageNames) {
        if (uri == null || uri.getScheme() == null || !uri.getScheme().equalsIgnoreCase(BaseConstants.SCHEME_MARKET)) {
            return null;
        }
        for (String str : packageNames) {
            if (AppPackageUtil.getPackageVersionCode(context, str) != -1) {
                return str;
            }
        }
        return null;
    }

    public static void a(Context context, BroadcastReceiver receiver, IntentFilter intentFilter) {
        a(context, receiver, intentFilter, true);
    }

    public static void a(Context context, BroadcastReceiver receiver, IntentFilter intentFilter, boolean isExported) {
        if (Build.VERSION.SDK_INT < 34 || context.getApplicationInfo().targetSdkVersion < 34) {
            context.registerReceiver(receiver, intentFilter);
        } else {
            context.registerReceiver(receiver, intentFilter, isExported ? 2 : 4);
        }
    }

    public static void a(Context context, Intent intent, String errMsg) throws IntentNotResolvableException {
        Preconditions.NoThrow.checkNotNull(context);
        Preconditions.NoThrow.checkNotNull(intent);
        try {
            c(context, intent);
        } catch (Throwable th) {
            throw new IntentNotResolvableException(errMsg + "\n" + th.getMessage());
        }
    }

    public static void a(Context context, Uri uri) throws IntentNotResolvableException {
        a(context, uri, (String) null);
    }

    public static void a(Context context, Uri uri, String packageName) throws IntentNotResolvableException {
        Intent intent = new Intent("android.intent.action.VIEW", uri);
        if (s.b(packageName)) {
            intent.setPackage(packageName);
        }
        b(context, intent);
    }

    public static void a(Context context, Uri uri, String packageName, boolean enableSmallWindow) throws Exception {
        Intent launchIntentForPackage;
        String str = f3255a;
        SigmobLogger.d(str, "launchApp: uri = " + uri + ", packageName = " + packageName + ", enableSmallWindow = " + enableSmallWindow, new Object[0]);
        boolean zB = v.b(uri);
        boolean zB2 = s.b(packageName);
        Activity activityI = com.sigmob.sdk.b.i();
        if (activityI == null) {
            activityI = com.sigmob.sdk.b.c();
        }
        if (activityI == null || v.b(Boolean.valueOf(enableSmallWindow))) {
            SigmobLogger.e(str, "launchApp: error = activity is null.", new Object[0]);
            if (zB && zB2) {
                a(context, uri, packageName);
                return;
            } else if (zB) {
                a(context, uri);
                return;
            } else {
                c(context, packageName);
                return;
            }
        }
        Bundle bundle = null;
        if (zB) {
            launchIntentForPackage = new Intent("android.intent.action.VIEW", uri);
        } else {
            launchIntentForPackage = zB2 ? context.getPackageManager().getLaunchIntentForPackage(packageName) : null;
        }
        if (!v.b(launchIntentForPackage) || !a(context, launchIntentForPackage)) {
            throw new IntentNotResolvableException("Could not handle application specific action: " + uri + "\n\tYou may be running in the emulator or another device which does not have the required application.");
        }
        SigmobLogger.d(str, "launchApp: intent = " + launchIntentForPackage, new Object[0]);
        launchIntentForPackage.setFlags(270532608);
        ActivityOptions activityOptionsMakeCustomAnimation = ActivityOptions.makeCustomAnimation(context, 0, 0);
        if (activityOptionsMakeCustomAnimation == null) {
            SigmobLogger.d(str, "launchApp: options is unavailable.", new Object[0]);
        } else {
            try {
                if (Build.VERSION.SDK_INT >= 33) {
                    activityOptionsMakeCustomAnimation.getClass().getMethod("setPendingIntentBackgroundActivityLaunchAllowed", Boolean.TYPE).invoke(activityOptionsMakeCustomAnimation, true);
                }
                activityOptionsMakeCustomAnimation.getClass().getMethod("setLaunchWindowingMode", Integer.TYPE).invoke(activityOptionsMakeCustomAnimation, 6);
            } catch (Exception e) {
                SigmobLogger.e(f3255a, "launchApp: error = " + e.getMessage(), new Object[0]);
            }
            View decorView = activityI.getWindow().getDecorView();
            WindowInsets rootWindowInsets = decorView.getRootWindowInsets();
            Rect rect = new Rect(0, 0, decorView.getWidth() / 2, decorView.getHeight() / 2);
            rect.offsetTo(rootWindowInsets.getSystemWindowInsetLeft() + 50, rootWindowInsets.getSystemWindowInsetTop() + 50);
            activityOptionsMakeCustomAnimation.setLaunchBounds(rect);
        }
        if (activityOptionsMakeCustomAnimation != null) {
            try {
                bundle = activityOptionsMakeCustomAnimation.toBundle();
            } catch (Throwable th) {
                throw new IntentNotResolvableException(("Unable to open intent: " + launchIntentForPackage) + "\n" + th.getMessage());
            }
        }
        activityI.startActivity(launchIntentForPackage, bundle);
        if (enableSmallWindow) {
            com.sigmob.sdk.b.j();
        }
    }

    public static void a(Context context, String wxAppId, String wxAppUsername, String wxAppPath, int wxBusinessType, String wxExtMsg) throws IntentNotResolvableException {
        String str = "wechat mini program error: wxAppId = " + wxAppId + ", wxAppUsername = " + wxAppUsername + ", wxAppPath = " + wxAppPath + ", wxBusinessType = " + wxBusinessType + ", wxExtMsg = " + wxExtMsg;
        try {
            if (wxBusinessType != 0) {
                if (wxBusinessType == 1) {
                    if (s.a((CharSequence) wxExtMsg)) {
                        throw new IntentNotResolvableException(str);
                    }
                    Class<?> cls = Class.forName("com.tencent.mm.opensdk.openapi.WXAPIFactory");
                    Method method = cls.getMethod("createWXAPI", Context.class, String.class);
                    method.setAccessible(true);
                    Object objInvoke = method.invoke(cls, context, wxAppId);
                    Class<?> cls2 = Class.forName("com.tencent.mm.opensdk.modelbiz.WXOpenBusinessView$Req");
                    Object objNewInstance = cls2.newInstance();
                    Field declaredField = cls2.getDeclaredField("businessType");
                    declaredField.setAccessible(true);
                    declaredField.set(objNewInstance, "nativeOpenAdCanvas");
                    Field declaredField2 = cls2.getDeclaredField(com.alipay.sdk.m.w.a.A);
                    declaredField2.setAccessible(true);
                    declaredField2.set(objNewInstance, wxExtMsg);
                    Method method2 = objInvoke.getClass().getMethod("sendReq", objNewInstance.getClass().getSuperclass());
                    method2.setAccessible(true);
                    boolean zBooleanValue = ((Boolean) method2.invoke(objInvoke, objNewInstance)).booleanValue();
                    SigmobLog.d("openB:isSendReq " + zBooleanValue);
                    if (!zBooleanValue) {
                        throw new IntentNotResolvableException(str);
                    }
                    return;
                }
                return;
            }
            if (s.a((CharSequence) wxAppId) || s.a((CharSequence) wxAppUsername) || s.a((CharSequence) wxAppPath)) {
                throw new IntentNotResolvableException(str);
            }
            Class<?> cls3 = Class.forName("com.tencent.mm.opensdk.openapi.WXAPIFactory");
            Method method3 = cls3.getMethod("createWXAPI", Context.class, String.class);
            method3.setAccessible(true);
            Object objInvoke2 = method3.invoke(cls3, context, wxAppId);
            Class<?> cls4 = Class.forName("com.tencent.mm.opensdk.modelbiz.WXLaunchMiniProgram$Req");
            Object objNewInstance2 = cls4.newInstance();
            Field declaredField3 = cls4.getDeclaredField("userName");
            declaredField3.setAccessible(true);
            declaredField3.set(objNewInstance2, wxAppUsername);
            Field declaredField4 = cls4.getDeclaredField("path");
            declaredField4.setAccessible(true);
            declaredField4.set(objNewInstance2, wxAppPath);
            if (s.b(wxExtMsg)) {
                Field declaredField5 = cls4.getDeclaredField("extData");
                declaredField5.setAccessible(true);
                declaredField5.set(objNewInstance2, wxExtMsg);
            }
            Field declaredField6 = cls4.getDeclaredField("miniprogramType");
            declaredField6.setAccessible(true);
            declaredField6.set(objNewInstance2, 0);
            Method method4 = objInvoke2.getClass().getMethod("sendReq", objNewInstance2.getClass().getSuperclass());
            method4.setAccessible(true);
            boolean zBooleanValue2 = ((Boolean) method4.invoke(objInvoke2, objNewInstance2)).booleanValue();
            SigmobLog.d("openB:isSendReq " + zBooleanValue2);
            if (!zBooleanValue2) {
                throw new IntentNotResolvableException(str);
            }
        } catch (Throwable th) {
            throw new IntentNotResolvableException(th.getMessage());
        }
    }

    public static boolean a(Context context, Intent intent) {
        try {
            return !context.getPackageManager().queryIntentActivities(intent, 0).isEmpty();
        } catch (NullPointerException unused) {
            return false;
        }
    }

    public static boolean a(Context context, String packageName) {
        return com.sigmob.sdk.base.o.a().m() == 0 ? e(context, packageName) : d(context, packageName);
    }

    public static void b(Context context, Intent intent) throws IntentNotResolvableException {
        Preconditions.NoThrow.checkNotNull(context);
        Preconditions.NoThrow.checkNotNull(intent);
        String str = "Unable to open intent: " + intent;
        if (com.sigmob.sdk.base.o.a().m() == 0 && !a(context, intent)) {
            throw new IntentNotResolvableException("Could not handle application specific action: " + intent.toString() + "\n\tYou may be running in the emulator or another device which does not have the required application.");
        }
        a(context, intent, str);
    }

    public static void b(Context context, Uri uri, String errorMessage) throws IntentNotResolvableException {
        Preconditions.NoThrow.checkNotNull(context);
        Preconditions.NoThrow.checkNotNull(uri);
        a(context, new Intent("android.intent.action.VIEW", uri), errorMessage);
    }

    public static boolean b(Context context, String packageName) {
        File parentFile;
        File parentFile2;
        try {
            File file = new File("/data/data", packageName);
            String absolutePath = file.getAbsolutePath();
            boolean zExists = file.exists();
            SigmobLogger.d(f3255a, "handlePackageNameDir: cacheDir = " + absolutePath + ", exists = " + zExists, new Object[0]);
            if (zExists) {
                return true;
            }
        } catch (Exception unused) {
        }
        try {
            File externalCacheDir = context.getExternalCacheDir();
            if (externalCacheDir == null || (parentFile = externalCacheDir.getParentFile()) == null || (parentFile2 = parentFile.getParentFile()) == null) {
                return false;
            }
            File file2 = new File(parentFile2, packageName);
            String absolutePath2 = file2.getAbsolutePath();
            boolean zExists2 = file2.exists();
            SigmobLogger.d(f3255a, "handlePackageNameDir: packagePath = " + absolutePath2 + ", exists = " + zExists2, new Object[0]);
            if (zExists2) {
                return true;
            }
        } catch (Exception unused2) {
        }
        return false;
    }

    private static void c(Context context, Intent intent) throws IntentNotResolvableException {
        Preconditions.NoThrow.checkNotNull(context);
        Preconditions.NoThrow.checkNotNull(intent);
        try {
            intent.addFlags(872415232);
            Activity activityI = com.sigmob.sdk.b.i();
            if (activityI == null) {
                activityI = com.sigmob.sdk.b.c();
            }
            if (activityI == null) {
                context.startActivity(intent);
            } else {
                activityI.startActivity(intent);
            }
        } catch (Throwable th) {
            SigmobLog.e("error ", th);
            throw new IntentNotResolvableException(th);
        }
    }

    public static boolean c(Context context, String packageName) throws IntentNotResolvableException {
        Intent launchIntentForPackage = context.getPackageManager().getLaunchIntentForPackage(packageName);
        if (launchIntentForPackage == null) {
            throw new IntentNotResolvableException("Could not handle application specific action: " + packageName + "\n\tYou may be running in the emulator or another.");
        }
        c(context, launchIntentForPackage);
        return true;
    }

    public static boolean d(Context context, String packageName) {
        if (context != null && !s.a((CharSequence) packageName)) {
            try {
                boolean zB = v.b(context.getPackageManager().getApplicationInfo(packageName, 0));
                SigmobLogger.d(f3255a, "installedWithAInfo: enable = " + zB, new Object[0]);
                return zB;
            } catch (Exception e) {
                SigmobLogger.e(f3255a, "installedWithAInfo: error = " + e.getMessage(), new Object[0]);
            }
        }
        return false;
    }

    public static boolean e(Context context, String packageName) {
        if (context != null && !s.a((CharSequence) packageName)) {
            try {
                boolean zB = v.b(context.getPackageManager().getLaunchIntentForPackage(packageName));
                SigmobLogger.d(f3255a, "installedWithLInfo: enable = " + zB, new Object[0]);
                return zB;
            } catch (Exception e) {
                SigmobLogger.e(f3255a, "installedWithLInfo: error = " + e.getMessage(), new Object[0]);
            }
        }
        return false;
    }

    public static boolean f(Context context, String packageName) {
        if (context != null && !s.a((CharSequence) packageName)) {
            try {
                boolean zB = v.b(context.getPackageManager().getPackageInfo(packageName, 0));
                SigmobLogger.d(f3255a, "installedWithPInfo: enable = " + zB, new Object[0]);
                return zB;
            } catch (Exception e) {
                SigmobLogger.e(f3255a, "installedWithPInfo: error = " + e.getMessage(), new Object[0]);
            }
        }
        return false;
    }
}
