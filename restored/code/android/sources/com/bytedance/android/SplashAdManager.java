package com.bytedance.android;

import android.app.Activity;
import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import com.bytedance.sdk.openadsdk.CSJSplashAd;

/* JADX INFO: loaded from: classes2.dex */
public class SplashAdManager {
    private static volatile SplashAdManager sManager;
    private Context mContext;
    private Handler mHandler;
    private FrameLayout mSplashView;

    private SplashAdManager() {
        if (this.mHandler == null) {
            this.mHandler = new Handler(Looper.getMainLooper());
        }
    }

    public static SplashAdManager getSplashAdManager() {
        if (sManager == null) {
            synchronized (SplashAdManager.class) {
                if (sManager == null) {
                    sManager = new SplashAdManager();
                }
            }
        }
        return sManager;
    }

    public ViewGroup getRootLayout(Activity activity) {
        if (activity == null) {
            return null;
        }
        return (ViewGroup) activity.findViewById(android.R.id.content);
    }

    public void addAdView(Activity activity, View view, ViewGroup.LayoutParams layoutParams) {
        ViewGroup rootLayout;
        if (activity == null || view == null || layoutParams == null || (rootLayout = getRootLayout(activity)) == null) {
            return;
        }
        rootLayout.addView(view, layoutParams);
    }

    public void removeAdView(Activity activity, View view) {
        ViewGroup rootLayout;
        if (activity == null || view == null || (rootLayout = getRootLayout(activity)) == null) {
            return;
        }
        rootLayout.removeView(view);
    }

    public void showSplashAd(final Context context, final CSJSplashAd cSJSplashAd) {
        if (context == null || cSJSplashAd == null) {
            return;
        }
        this.mContext = context;
        this.mHandler.post(new Runnable() { // from class: com.bytedance.android.SplashAdManager.1
            @Override // java.lang.Runnable
            public void run() {
                SplashAdManager splashAdManager = SplashAdManager.this;
                splashAdManager.mSplashView = splashAdManager.attachSplashView(context, cSJSplashAd);
                if (SplashAdManager.this.mSplashView == null) {
                    return;
                }
                SplashAdManager splashAdManager2 = SplashAdManager.this;
                splashAdManager2.removeAdView((Activity) context, splashAdManager2.mSplashView);
                FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
                layoutParams.gravity = 17;
                SplashAdManager splashAdManager3 = SplashAdManager.this;
                splashAdManager3.addAdView((Activity) context, splashAdManager3.mSplashView, layoutParams);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public FrameLayout attachSplashView(Context context, CSJSplashAd cSJSplashAd) {
        View splashView = cSJSplashAd.getSplashView();
        if (splashView == null) {
            return null;
        }
        if (this.mSplashView == null) {
            this.mSplashView = new FrameLayout(context);
        }
        this.mSplashView.setOnClickListener(new View.OnClickListener() { // from class: com.bytedance.android.SplashAdManager.2
            @Override // android.view.View.OnClickListener
            public void onClick(View view) {
            }
        });
        this.mSplashView.removeAllViews();
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
        layoutParams.gravity = 17;
        this.mSplashView.addView(splashView, layoutParams);
        return this.mSplashView;
    }

    public void destorySplashView(final Activity activity) {
        Handler handler;
        if (activity == null || (handler = this.mHandler) == null) {
            return;
        }
        handler.post(new Runnable() { // from class: com.bytedance.android.SplashAdManager.3
            @Override // java.lang.Runnable
            public void run() {
                if (SplashAdManager.this.mSplashView != null) {
                    SplashAdManager splashAdManager = SplashAdManager.this;
                    splashAdManager.removeAdView(activity, splashAdManager.mSplashView);
                    SplashAdManager.this.mSplashView = null;
                }
            }
        });
    }
}
