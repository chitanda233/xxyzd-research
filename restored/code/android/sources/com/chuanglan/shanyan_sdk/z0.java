package com.chuanglan.shanyan_sdk;

import android.app.Activity;
import android.os.Build;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.view.WindowManager;
import com.bykv.vk.component.ttvideo.mediakit.medialoader.AVMDLDataLoader;
import com.chuanglan.shanyan_sdk.tool.ShanYanUIConfig;

/* JADX INFO: loaded from: classes2.dex */
public abstract class z0 {
    private static int a() {
        return 7942;
    }

    public static void a(Activity activity, boolean z) {
        if (activity != null) {
            try {
                if (!activity.isFinishing()) {
                    Window window = activity.getWindow();
                    if (window == null) {
                        return;
                    }
                    boolean z2 = (window.getAttributes().flags & 8192) != 0;
                    if (z && !z2) {
                        window.addFlags(8192);
                    } else if (!z && z2) {
                        window.clearFlags(8192);
                    }
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    public static void b(Activity activity, ShanYanUIConfig shanYanUIConfig) {
        if (activity == null || activity.isFinishing()) {
            return;
        }
        Window window = activity.getWindow();
        try {
            if (shanYanUIConfig == null) {
                a(window);
            } else {
                a(window, shanYanUIConfig);
            }
        } catch (Exception e) {
            a(window, e, "setSystemStatusBar with config");
        }
    }

    public static void c(Activity activity, ShanYanUIConfig shanYanUIConfig) {
        if (activity == null || activity.isFinishing()) {
            return;
        }
        Window window = activity.getWindow();
        try {
            if (shanYanUIConfig == null) {
                a(window);
            } else {
                b(window, shanYanUIConfig);
            }
        } catch (Exception e) {
            a(window, e, "setSystemStatusBar with config");
        }
    }

    private static void b(Window window, ShanYanUIConfig shanYanUIConfig) {
        b(window, shanYanUIConfig.isStatusBarHidden());
        if (shanYanUIConfig.getStatusBarColor() == -1) {
            a(window, shanYanUIConfig.isLightColor());
        } else {
            a(window, shanYanUIConfig.getStatusBarColor(), shanYanUIConfig.isLightColor());
        }
        if (shanYanUIConfig.isVirtualKeyTransparent()) {
            b(window);
        }
    }

    public static void a(Activity activity, float f) {
        Window window;
        if (activity == null || activity.isFinishing() || (window = activity.getWindow()) == null || f == -1.0f) {
            return;
        }
        window.setDimAmount(f);
    }

    private static void a(Window window, ShanYanUIConfig shanYanUIConfig) {
        b(window, shanYanUIConfig.isPrivacyStatusBarHidden());
        if (shanYanUIConfig.getStatusBarColor() == -1) {
            a(window, shanYanUIConfig.isPrivacyLightColor());
        } else {
            a(window, shanYanUIConfig.getPrivacyStatusBarColor(), shanYanUIConfig.isPrivacyLightColor());
        }
        if (shanYanUIConfig.isVirtualKeyTransparent()) {
            b(window);
        }
    }

    private static void b(Window window, boolean z) {
        if (z) {
            window.addFlags(1024);
        } else {
            window.clearFlags(1024);
        }
    }

    private static void b(Window window) {
        window.clearFlags(134217728);
        window.setNavigationBarColor(0);
        window.getDecorView().setSystemUiVisibility(window.getDecorView().getSystemUiVisibility() | 512);
    }

    public static void b(Activity activity, boolean z) {
        if (z) {
            a(activity);
        } else {
            b(activity);
        }
    }

    private static void a(Window window) {
        window.clearFlags(67108864);
        window.getDecorView().setSystemUiVisibility(AVMDLDataLoader.KeyIsLoaderCacheSize);
        window.addFlags(Integer.MIN_VALUE);
        window.setStatusBarColor(0);
    }

    public static void b(Activity activity) {
        if (activity == null || activity.isFinishing()) {
            return;
        }
        Window window = activity.getWindow();
        try {
            window.getDecorView().setSystemUiVisibility(0);
        } catch (Exception e) {
            a(window, e, "showSystemUI");
        }
    }

    private static void a(Window window, boolean z) {
        window.clearFlags(201326592);
        window.getDecorView().setSystemUiVisibility(z ? 1024 : AVMDLDataLoader.KeyIsLoaderCacheSize);
        window.addFlags(Integer.MIN_VALUE);
        window.setStatusBarColor(0);
    }

    private static void a(Window window, int i, boolean z) {
        window.setStatusBarColor(i);
        window.setNavigationBarColor(i);
        int systemUiVisibility = window.getDecorView().getSystemUiVisibility();
        window.getDecorView().setSystemUiVisibility(z ? systemUiVisibility & (-8193) : systemUiVisibility | 8192);
    }

    private static void a(Window window, Exception exc, String str) {
        exc.printStackTrace();
        Q.d("ExceptionShanYanLogger", str + " Exception: ", exc);
        if ("setSystemStatusBar with config".equals(str)) {
            try {
                a(window);
            } catch (Exception e) {
                Q.d("ExceptionShanYanLogger", "Fallback to default config failed: ", e);
            }
        }
    }

    public static void a(Activity activity) {
        if (activity == null || activity.isFinishing()) {
            return;
        }
        Window window = activity.getWindow();
        try {
            View decorView = window.getDecorView();
            int iA = a();
            decorView.setSystemUiVisibility(iA);
            Q.a("UIShanYanLogger", "setSystemUiVisibility", Integer.valueOf(iA));
            if (Build.VERSION.SDK_INT >= 28) {
                WindowManager.LayoutParams attributes = window.getAttributes();
                attributes.layoutInDisplayCutoutMode = 1;
                window.setAttributes(attributes);
            }
        } catch (Exception e) {
            a(window, e, "hideSystemUI");
        }
    }

    public static void a(Activity activity, ShanYanUIConfig shanYanUIConfig) {
        if (activity == null || activity.isFinishing()) {
            return;
        }
        Window window = activity.getWindow();
        try {
            a(window, shanYanUIConfig.getDialogDimAmount());
            WindowManager.LayoutParams attributes = window.getAttributes();
            attributes.width = AbstractC0597c.a(activity.getApplicationContext(), shanYanUIConfig.getDialogWidth());
            attributes.height = AbstractC0597c.a(activity.getApplicationContext(), shanYanUIConfig.getDialogHeight());
            attributes.x = shanYanUIConfig.getDialogX();
            if (shanYanUIConfig.isDialogBottom()) {
                attributes.gravity = 80;
            } else {
                attributes.y = shanYanUIConfig.getDialogY();
            }
            window.setAttributes(attributes);
        } catch (Exception e) {
            a(window, e, "configureDialogTheme");
        }
    }

    private static void a(Window window, float f) {
        if (f != -1.0f) {
            window.setDimAmount(f);
        } else {
            window.setDimAmount(0.6f);
        }
        window.addFlags(2);
        window.clearFlags(1024);
    }

    public static void a(ViewGroup viewGroup, boolean z) {
        if (viewGroup != null) {
            Q.a("UIShanYanLogger", "fitSystemWindows", Boolean.valueOf(z));
            viewGroup.setFitsSystemWindows(z);
        }
    }
}
