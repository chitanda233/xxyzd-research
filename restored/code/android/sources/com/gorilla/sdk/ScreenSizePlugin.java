package com.gorilla.sdk;

import android.app.Activity;
import android.content.ComponentCallbacks2;
import android.content.res.Configuration;
import android.graphics.Insets;
import android.hardware.display.DisplayManager;
import android.os.Build;
import android.util.DisplayMetrics;
import android.util.Log;
import android.view.Display;
import android.view.View;
import android.view.WindowInsets;
import android.view.WindowMetrics;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.unity3d.player.UnityPlayer;

/* JADX INFO: loaded from: classes3.dex */
public class ScreenSizePlugin {
    private static boolean isStarted = false;
    private static Activity mActivity;
    private static ScreenSizeCallback mCallback;
    private static final ComponentCallbacks2 componentCallbacks = new ComponentCallbacks2() { // from class: com.gorilla.sdk.ScreenSizePlugin.1
        @Override // android.content.ComponentCallbacks
        public void onLowMemory() {
        }

        @Override // android.content.ComponentCallbacks2
        public void onTrimMemory(int i) {
        }

        @Override // android.content.ComponentCallbacks
        public void onConfigurationChanged(Configuration configuration) {
            ScreenSizePlugin.dispatchSize("onConfigurationChanged");
        }
    };
    private static final DisplayManager.DisplayListener displayListener = new DisplayManager.DisplayListener() { // from class: com.gorilla.sdk.ScreenSizePlugin.2
        @Override // android.hardware.display.DisplayManager.DisplayListener
        public void onDisplayAdded(int i) {
        }

        @Override // android.hardware.display.DisplayManager.DisplayListener
        public void onDisplayRemoved(int i) {
        }

        @Override // android.hardware.display.DisplayManager.DisplayListener
        public void onDisplayChanged(int i) {
            ScreenSizePlugin.dispatchSize("onDisplayChanged");
        }
    };
    private static final View.OnLayoutChangeListener layoutChangeListener = new View.OnLayoutChangeListener() { // from class: com.gorilla.sdk.ScreenSizePlugin.3
        @Override // android.view.View.OnLayoutChangeListener
        public void onLayoutChange(View view, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
            if (i == i5 && i2 == i6 && i3 == i7 && i4 == i8) {
                return;
            }
            ScreenSizePlugin.dispatchSize("onLayoutChange");
        }
    };

    public static void start(Activity activity, ScreenSizeCallback screenSizeCallback) {
        if (isStarted) {
            Log.e("ScreenSizePlugin", "already started");
            return;
        }
        if (activity == null) {
            Log.e("ScreenSizePlugin", "activity is null");
            return;
        }
        mActivity = activity;
        mCallback = screenSizeCallback;
        activity.registerComponentCallbacks(componentCallbacks);
        DisplayManager displayManager = (DisplayManager) activity.getSystemService("display");
        if (displayManager != null) {
            displayManager.registerDisplayListener(displayListener, null);
        } else {
            Log.e("ScreenSizePlugin", "DisplayManager is null");
        }
        activity.getWindow().getDecorView().addOnLayoutChangeListener(layoutChangeListener);
        isStarted = true;
        dispatchSize("start");
    }

    public static void stop(Activity activity) {
        if (!isStarted || activity == null) {
            return;
        }
        activity.getApplication().unregisterComponentCallbacks(componentCallbacks);
        DisplayManager displayManager = (DisplayManager) activity.getSystemService("display");
        if (displayManager != null) {
            displayManager.unregisterDisplayListener(displayListener);
        }
        activity.getWindow().getDecorView().removeOnLayoutChangeListener(layoutChangeListener);
        isStarted = false;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void dispatchSize(String str) {
        Size currentWindowSize = getCurrentWindowSize(mActivity);
        ScreenSizeCallback screenSizeCallback = mCallback;
        if (screenSizeCallback != null) {
            screenSizeCallback.onScreenSizeChanged(currentWindowSize.width, currentWindowSize.height, currentWindowSize.density, currentWindowSize.rotation, currentWindowSize.left, currentWindowSize.top, currentWindowSize.right, currentWindowSize.bottom);
        }
    }

    private static class Size {
        public int bottom;
        public float density;
        public int height;
        public int left;
        public int right;
        public int rotation;
        public int top;
        public int width;

        private Size() {
        }
    }

    private static Size getCurrentWindowSize(Activity activity) {
        Size size = new Size();
        if (activity == null) {
            activity = UnityPlayer.currentActivity;
        }
        if (activity == null) {
            size.height = 0;
            size.width = 0;
            size.density = 1.0f;
            size.rotation = 0;
            return size;
        }
        if (Build.VERSION.SDK_INT >= 30) {
            WindowMetrics currentWindowMetrics = activity.getWindowManager().getCurrentWindowMetrics();
            Insets insetsIgnoringVisibility = currentWindowMetrics.getWindowInsets().getInsetsIgnoringVisibility(WindowInsets.Type.systemBars() | WindowInsets.Type.displayCutout());
            int iWidth = currentWindowMetrics.getBounds().width();
            int iHeight = currentWindowMetrics.getBounds().height();
            size.width = iWidth;
            size.height = iHeight;
            size.density = activity.getResources().getDisplayMetrics().density;
            size.rotation = rotationToDeg(activity.getDisplay());
            size.left = insetsIgnoringVisibility.left;
            size.top = insetsIgnoringVisibility.top;
            size.right = insetsIgnoringVisibility.right;
            size.bottom = insetsIgnoringVisibility.bottom;
        } else {
            Display defaultDisplay = activity.getWindowManager().getDefaultDisplay();
            DisplayMetrics displayMetrics = new DisplayMetrics();
            defaultDisplay.getMetrics(displayMetrics);
            size.width = displayMetrics.widthPixels;
            size.height = displayMetrics.heightPixels;
            size.density = displayMetrics.density;
            size.rotation = rotationToDeg(defaultDisplay);
            size.left = 0;
            size.right = 0;
            size.top = getStatusBarHeight(activity);
            size.bottom = getNavigationBarHeight(activity);
        }
        return size;
    }

    private static int getStatusBarHeight(Activity activity) {
        try {
            int identifier = activity.getResources().getIdentifier("status_bar_height", "dimen", "android");
            if (identifier > 0) {
                return activity.getResources().getDimensionPixelSize(identifier);
            }
            return (int) (activity.getResources().getDisplayMetrics().density * 24.0f);
        } catch (Exception unused) {
            return 0;
        }
    }

    private static int getNavigationBarHeight(Activity activity) {
        try {
            int identifier = activity.getResources().getIdentifier("navigation_bar_height", "dimen", "android");
            if (identifier > 0) {
                return activity.getResources().getDimensionPixelSize(identifier);
            }
            return (int) (activity.getResources().getDisplayMetrics().density * 48.0f);
        } catch (Exception unused) {
            return 0;
        }
    }

    private static int rotationToDeg(Display display) {
        if (display == null) {
            return 0;
        }
        int rotation = display.getRotation();
        if (rotation == 1) {
            return 90;
        }
        if (rotation == 2) {
            return 180;
        }
        if (rotation != 3) {
            return 0;
        }
        return MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_SWITCH_CACHE_TIME;
    }
}
