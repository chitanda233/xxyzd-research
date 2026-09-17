package com.kwad.sdk.utils;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.graphics.Insets;
import android.graphics.Rect;
import android.media.AudioManager;
import android.os.Build;
import android.text.TextUtils;
import android.util.DisplayMetrics;
import android.view.WindowInsets;
import android.view.WindowManager;
import android.view.WindowMetrics;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import java.util.Locale;

/* JADX INFO: loaded from: classes3.dex */
public final class n {
    public static String boG = null;
    private static int boH = -1;
    public static String boI;

    public static String cY(Context context) {
        if (!TextUtils.isEmpty(boG)) {
            return boG;
        }
        try {
            PackageInfo packageInfo = aa.getPackageInfo(context.getApplicationContext(), context.getPackageName(), 64);
            if (packageInfo == null) {
                return "";
            }
            String str = packageInfo.versionName;
            boG = str;
            return str;
        } catch (Exception unused) {
            return "";
        }
    }

    public static String cZ(Context context) {
        if (!TextUtils.isEmpty(boI)) {
            return boI;
        }
        try {
            PackageInfo packageInfo = aa.getPackageInfo(context, context.getPackageName(), 0);
            if (packageInfo == null) {
                return null;
            }
            String string = context.getResources().getString(packageInfo.applicationInfo.labelRes);
            boI = string;
            return string;
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    public static String S(Context context, String str) {
        if (!TextUtils.isEmpty(str) && context != null) {
            try {
                PackageInfo packageInfo = aa.getPackageInfo(context.getApplicationContext(), str, 64);
                if (packageInfo != null) {
                    return packageInfo.versionName;
                }
            } catch (Exception unused) {
            }
        }
        return "";
    }

    public static int da(Context context) {
        int i = boH;
        if (i > 0) {
            return i;
        }
        try {
            PackageInfo packageInfo = aa.getPackageInfo(context.getApplicationContext(), context.getPackageName(), 64);
            if (packageInfo == null) {
                return 0;
            }
            int i2 = packageInfo.versionCode;
            boH = i2;
            return i2;
        } catch (Throwable unused) {
            return 0;
        }
    }

    public static String getLanguage() {
        return Locale.getDefault().getLanguage();
    }

    public static int getScreenWidth(Context context) {
        try {
            DisplayMetrics displayMetrics = new DisplayMetrics();
            WindowManager windowManager = (WindowManager) context.getSystemService("window");
            if (Build.VERSION.SDK_INT >= 35) {
                WindowMetrics currentWindowMetrics = windowManager.getCurrentWindowMetrics();
                Rect bounds = currentWindowMetrics.getBounds();
                Insets insets = currentWindowMetrics.getWindowInsets().getInsets(WindowInsets.Type.systemBars());
                return (bounds.width() - insets.left) - insets.right;
            }
            windowManager.getDefaultDisplay().getMetrics(displayMetrics);
            return displayMetrics.widthPixels;
        } catch (Exception unused) {
            return 0;
        }
    }

    public static int getScreenHeight(Context context) {
        try {
            DisplayMetrics displayMetrics = new DisplayMetrics();
            WindowManager windowManager = (WindowManager) context.getSystemService("window");
            if (Build.VERSION.SDK_INT >= 35) {
                WindowMetrics currentWindowMetrics = windowManager.getCurrentWindowMetrics();
                Rect bounds = currentWindowMetrics.getBounds();
                Insets insets = currentWindowMetrics.getWindowInsets().getInsets(WindowInsets.Type.systemBars());
                return (bounds.height() - insets.top) - insets.bottom;
            }
            windowManager.getDefaultDisplay().getMetrics(displayMetrics);
            return displayMetrics.heightPixels;
        } catch (Exception unused) {
            return 0;
        }
    }

    public static int db(Context context) {
        AudioManager audioManager = (AudioManager) context.getSystemService(MediaFormat.KEY_AUDIO);
        if (audioManager != null) {
            return audioManager.getStreamVolume(3);
        }
        return 0;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v0 */
    /* JADX WARN: Type inference failed for: r0v1, types: [int] */
    /* JADX WARN: Type inference failed for: r0v3 */
    /* JADX WARN: Type inference failed for: r0v6 */
    /* JADX WARN: Type inference failed for: r0v7 */
    public static int dc(Context context) {
        float fWidth;
        ?? r0 = 0;
        if (context == null) {
            return 0;
        }
        try {
            DisplayMetrics displayMetrics = new DisplayMetrics();
            WindowManager windowManager = (WindowManager) context.getSystemService("window");
            windowManager.getDefaultDisplay().getMetrics(displayMetrics);
            if (Build.VERSION.SDK_INT >= 35) {
                WindowMetrics currentWindowMetrics = windowManager.getCurrentWindowMetrics();
                Rect bounds = currentWindowMetrics.getBounds();
                Insets insets = currentWindowMetrics.getWindowInsets().getInsets(WindowInsets.Type.systemBars());
                fWidth = (bounds.width() - insets.left) - insets.right;
                r0 = displayMetrics.density;
            } else {
                fWidth = displayMetrics.widthPixels;
                r0 = displayMetrics.density;
            }
            return (int) (fWidth / (r0 == true ? 1.0f : 0.0f));
        } catch (Exception unused) {
            return r0;
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v0 */
    /* JADX WARN: Type inference failed for: r0v1, types: [int] */
    /* JADX WARN: Type inference failed for: r0v3 */
    /* JADX WARN: Type inference failed for: r0v6 */
    /* JADX WARN: Type inference failed for: r0v7 */
    public static int dd(Context context) {
        float fHeight;
        ?? r0 = 0;
        if (context == null) {
            return 0;
        }
        try {
            DisplayMetrics displayMetrics = new DisplayMetrics();
            WindowManager windowManager = (WindowManager) context.getSystemService("window");
            windowManager.getDefaultDisplay().getMetrics(displayMetrics);
            if (Build.VERSION.SDK_INT >= 35) {
                WindowMetrics currentWindowMetrics = windowManager.getCurrentWindowMetrics();
                Rect bounds = currentWindowMetrics.getBounds();
                Insets insets = currentWindowMetrics.getWindowInsets().getInsets(WindowInsets.Type.systemBars());
                fHeight = (bounds.height() - insets.top) - insets.bottom;
                r0 = displayMetrics.density;
            } else {
                fHeight = displayMetrics.heightPixels;
                r0 = displayMetrics.density;
            }
            return (int) (fHeight / (r0 == true ? 1.0f : 0.0f));
        } catch (Exception unused) {
            return r0;
        }
    }

    public static float de(Context context) {
        if (context == null) {
            return 0.0f;
        }
        try {
            DisplayMetrics displayMetrics = new DisplayMetrics();
            ((WindowManager) context.getSystemService("window")).getDefaultDisplay().getMetrics(displayMetrics);
            return displayMetrics.density;
        } catch (Exception unused) {
            return 0.0f;
        }
    }
}
