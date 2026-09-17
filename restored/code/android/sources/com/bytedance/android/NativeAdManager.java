package com.bytedance.android;

import android.app.Activity;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Handler;
import android.os.Looper;
import android.util.Log;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.bytedance.sdk.openadsdk.TTAdDislike;
import com.bytedance.sdk.openadsdk.TTAppDownloadListener;
import com.bytedance.sdk.openadsdk.TTFeedAd;
import com.bytedance.sdk.openadsdk.TTImage;
import com.bytedance.sdk.openadsdk.TTNativeAd;
import com.bytedance.sdk.openadsdk.TTNativeExpressAd;
import com.bytedance.sdk.openadsdk.mediation.ad.MediationExpressRenderListener;
import com.bytedance.sdk.openadsdk.mediation.manager.MediationNativeManager;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;

/* JADX INFO: loaded from: classes2.dex */
public class NativeAdManager {
    public static final String TAG = "CSJM_Unity_";
    private static volatile NativeAdManager sManager;
    private BannerView mBannerView;
    private View mExpressBannerView;
    private View mExpressView;
    private View mFeedView;
    private Handler mHandler;

    private NativeAdManager() {
        if (this.mHandler == null) {
            this.mHandler = new Handler(Looper.getMainLooper());
        }
    }

    public static NativeAdManager getNativeAdManager() {
        if (sManager == null) {
            synchronized (NativeAdManager.class) {
                if (sManager == null) {
                    sManager = new NativeAdManager();
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

    public void showNativeBannerAd(final Context context, final TTNativeAd tTNativeAd, final TTNativeAd.AdInteractionListener adInteractionListener, final TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback, final int i, final int i2) {
        if (context == null || tTNativeAd == null) {
            return;
        }
        this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.1
            @Override // java.lang.Runnable
            public void run() {
                NativeAdManager nativeAdManager = NativeAdManager.this;
                nativeAdManager.removeAdView((Activity) context, nativeAdManager.mBannerView);
                NativeAdManager.this.mBannerView = new BannerView(context);
                FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams((int) NativeAdManager.this.dip2Px(context, 320.0f), (int) NativeAdManager.this.dip2Px(context, 150.0f));
                layoutParams.gravity = 51;
                layoutParams.leftMargin = i;
                layoutParams.topMargin = i2;
                NativeAdManager nativeAdManager2 = NativeAdManager.this;
                nativeAdManager2.addAdView((Activity) context, nativeAdManager2.mBannerView, layoutParams);
                NativeAdManager nativeAdManager3 = NativeAdManager.this;
                nativeAdManager3.setBannerAdData(context, nativeAdManager3.mBannerView, tTNativeAd, dislikeInteractionCallback, adInteractionListener);
            }
        });
    }

    public void showExpressFeedAd(final Context context, final TTNativeExpressAd tTNativeExpressAd, final TTNativeExpressAd.AdInteractionListener adInteractionListener, TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback, final int i, final int i2) {
        if (context == null || tTNativeExpressAd == null) {
            return;
        }
        tTNativeExpressAd.setExpressInteractionListener(new TTNativeExpressAd.AdInteractionListener() { // from class: com.bytedance.android.NativeAdManager.2
            @Override // com.bytedance.sdk.openadsdk.TTNativeExpressAd.AdInteractionListener
            public void onAdDismiss() {
                TTNativeExpressAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onAdDismiss();
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTNativeExpressAd.ExpressAdInteractionListener
            public void onAdClicked(View view, int i3) {
                TTNativeExpressAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onAdClicked(view, i3);
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTNativeExpressAd.ExpressAdInteractionListener
            public void onAdShow(View view, int i3) {
                TTNativeExpressAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onAdShow(view, i3);
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTNativeExpressAd.ExpressAdInteractionListener
            public void onRenderFail(View view, String str, int i3) {
                TTNativeExpressAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onRenderFail(view, str, i3);
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTNativeExpressAd.ExpressAdInteractionListener
            public void onRenderSuccess(final View view, final float f, final float f2) {
                TTNativeExpressAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onRenderSuccess(view, f, f2);
                }
                NativeAdManager.this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.2.1
                    @Override // java.lang.Runnable
                    public void run() {
                        NativeAdManager.this.removeAdView((Activity) context, NativeAdManager.this.mExpressView);
                        NativeAdManager.this.mExpressView = view;
                        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams((int) NativeAdManager.this.dip2Px(context, f), (int) NativeAdManager.this.dip2Px(context, f2));
                        layoutParams.gravity = 51;
                        layoutParams.leftMargin = i;
                        layoutParams.topMargin = i2;
                        NativeAdManager.this.addAdView((Activity) context, NativeAdManager.this.mExpressView, layoutParams);
                    }
                });
            }
        });
        this.mHandler.post(new AnonymousClass3(tTNativeExpressAd, context, dislikeInteractionCallback));
        this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.4
            @Override // java.lang.Runnable
            public void run() {
                tTNativeExpressAd.render();
            }
        });
    }

    /* JADX INFO: renamed from: com.bytedance.android.NativeAdManager$3, reason: invalid class name */
    class AnonymousClass3 implements Runnable {
        final /* synthetic */ Context val$context;
        final /* synthetic */ TTAdDislike.DislikeInteractionCallback val$dislikeCallback;
        final /* synthetic */ TTNativeExpressAd val$nativeExpressAd;

        AnonymousClass3(TTNativeExpressAd tTNativeExpressAd, Context context, TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback) {
            this.val$nativeExpressAd = tTNativeExpressAd;
            this.val$context = context;
            this.val$dislikeCallback = dislikeInteractionCallback;
        }

        @Override // java.lang.Runnable
        public void run() {
            this.val$nativeExpressAd.setDislikeCallback((Activity) this.val$context, new TTAdDislike.DislikeInteractionCallback() { // from class: com.bytedance.android.NativeAdManager.3.1
                @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
                public void onSelected(int i, String str, boolean z) {
                    Log.e(NativeAdManager.TAG, "express feed dislike onSelected");
                    if (AnonymousClass3.this.val$dislikeCallback != null) {
                        AnonymousClass3.this.val$dislikeCallback.onSelected(i, str, z);
                    }
                    NativeAdManager.this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.3.1.1
                        @Override // java.lang.Runnable
                        public void run() {
                            NativeAdManager.this.removeExpressView(AnonymousClass3.this.val$context);
                        }
                    });
                }

                @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
                public void onCancel() {
                    Log.e(NativeAdManager.TAG, "express feed dislike onCancel");
                    if (AnonymousClass3.this.val$dislikeCallback != null) {
                        AnonymousClass3.this.val$dislikeCallback.onCancel();
                    }
                }

                @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
                public void onShow() {
                    Log.e(NativeAdManager.TAG, "express feed dislike onShow");
                    if (AnonymousClass3.this.val$dislikeCallback != null) {
                        AnonymousClass3.this.val$dislikeCallback.onShow();
                    }
                }
            });
        }
    }

    public void showExpressBannerAd(final Context context, final TTNativeExpressAd tTNativeExpressAd, final TTNativeExpressAd.AdInteractionListener adInteractionListener, TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback, final int i, final int i2) {
        if (context == null || tTNativeExpressAd == null) {
            return;
        }
        tTNativeExpressAd.setExpressInteractionListener(new TTNativeExpressAd.AdInteractionListener() { // from class: com.bytedance.android.NativeAdManager.5
            @Override // com.bytedance.sdk.openadsdk.TTNativeExpressAd.AdInteractionListener
            public void onAdDismiss() {
                Log.e(NativeAdManager.TAG, "Express Banner onAdDismiss");
                TTNativeExpressAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onAdDismiss();
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTNativeExpressAd.ExpressAdInteractionListener
            public void onAdClicked(View view, int i3) {
                Log.e(NativeAdManager.TAG, "Express Banner onAdClicked");
                TTNativeExpressAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onAdClicked(view, i3);
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTNativeExpressAd.ExpressAdInteractionListener
            public void onAdShow(View view, int i3) {
                Log.e(NativeAdManager.TAG, "Express Banner onAdShow");
                TTNativeExpressAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onAdShow(view, i3);
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTNativeExpressAd.ExpressAdInteractionListener
            public void onRenderFail(View view, String str, int i3) {
                Log.e(NativeAdManager.TAG, "Express Banner onRenderFail");
                TTNativeExpressAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onRenderFail(view, str, i3);
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTNativeExpressAd.ExpressAdInteractionListener
            public void onRenderSuccess(View view, float f, float f2) {
                Log.e(NativeAdManager.TAG, "Express Banner onRenderSuccess");
                TTNativeExpressAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onRenderSuccess(view, f, f2);
                }
                NativeAdManager.this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.5.1
                    @Override // java.lang.Runnable
                    public void run() {
                        NativeAdManager.this.removeAdView((Activity) context, NativeAdManager.this.mExpressBannerView);
                        NativeAdManager.this.mExpressBannerView = tTNativeExpressAd.getExpressAdView();
                        Log.e(NativeAdManager.TAG, "Express Banner getExpressAdView: " + NativeAdManager.this.mExpressBannerView);
                        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-2, -2);
                        layoutParams.gravity = 51;
                        layoutParams.leftMargin = i;
                        layoutParams.topMargin = i2;
                        NativeAdManager.this.addAdView((Activity) context, NativeAdManager.this.mExpressBannerView, layoutParams);
                    }
                });
            }
        });
        this.mHandler.post(new AnonymousClass6(tTNativeExpressAd, context, dislikeInteractionCallback));
        this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.7
            @Override // java.lang.Runnable
            public void run() {
                tTNativeExpressAd.render();
            }
        });
    }

    /* JADX INFO: renamed from: com.bytedance.android.NativeAdManager$6, reason: invalid class name */
    class AnonymousClass6 implements Runnable {
        final /* synthetic */ Context val$context;
        final /* synthetic */ TTAdDislike.DislikeInteractionCallback val$dislikeCallback;
        final /* synthetic */ TTNativeExpressAd val$nativeExpressAd;

        AnonymousClass6(TTNativeExpressAd tTNativeExpressAd, Context context, TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback) {
            this.val$nativeExpressAd = tTNativeExpressAd;
            this.val$context = context;
            this.val$dislikeCallback = dislikeInteractionCallback;
        }

        @Override // java.lang.Runnable
        public void run() {
            this.val$nativeExpressAd.setDislikeCallback((Activity) this.val$context, new TTAdDislike.DislikeInteractionCallback() { // from class: com.bytedance.android.NativeAdManager.6.1
                @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
                public void onSelected(int i, String str, boolean z) {
                    Log.e(NativeAdManager.TAG, "express banner dislike onSelected");
                    if (AnonymousClass6.this.val$dislikeCallback != null) {
                        AnonymousClass6.this.val$dislikeCallback.onSelected(i, str, z);
                    }
                    NativeAdManager.this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.6.1.1
                        @Override // java.lang.Runnable
                        public void run() {
                            NativeAdManager.this.removeExpressBannerView(AnonymousClass6.this.val$context);
                        }
                    });
                }

                @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
                public void onCancel() {
                    Log.e(NativeAdManager.TAG, "express banner dislike onCancel");
                    if (AnonymousClass6.this.val$dislikeCallback != null) {
                        AnonymousClass6.this.val$dislikeCallback.onCancel();
                    }
                }

                @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
                public void onShow() {
                    Log.e(NativeAdManager.TAG, "express banner dislike onShow");
                    if (AnonymousClass6.this.val$dislikeCallback != null) {
                        AnonymousClass6.this.val$dislikeCallback.onShow();
                    }
                }
            });
        }
    }

    public void showFeedAd(final Context context, final TTFeedAd tTFeedAd, final TTNativeAd.AdInteractionListener adInteractionListener, TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback, final int i, final int i2) {
        final MyDislikeCallback myDislikeCallback = new MyDislikeCallback(dislikeInteractionCallback, new Runnable() { // from class: com.bytedance.android.NativeAdManager.8
            @Override // java.lang.Runnable
            public void run() {
                NativeAdManager.this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.8.1
                    @Override // java.lang.Runnable
                    public void run() {
                        NativeAdManager.this.removeFeedView(context);
                    }
                });
            }
        });
        MediationNativeManager mediationManager = tTFeedAd.getMediationManager();
        if (mediationManager != null) {
            if (mediationManager.isExpress()) {
                Log.d(TAG, "show feed express");
                this.mHandler.post(new AnonymousClass9(tTFeedAd, context, myDislikeCallback, adInteractionListener, i, i2));
                return;
            } else {
                Log.d(TAG, "show feed native");
                this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.10
                    @Override // java.lang.Runnable
                    public void run() {
                        View feedViewFromFeedAd = FeedAdUtils.getFeedViewFromFeedAd(tTFeedAd, (Activity) context, adInteractionListener, myDislikeCallback);
                        Log.d(NativeAdManager.TAG, "getFeedViewFromFeedAd");
                        if (feedViewFromFeedAd != null) {
                            NativeAdManager.this.removeFeedView(context);
                            NativeAdManager.this.mFeedView = feedViewFromFeedAd;
                            FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-2, -2);
                            layoutParams.gravity = 51;
                            layoutParams.leftMargin = i;
                            layoutParams.topMargin = i2;
                            NativeAdManager nativeAdManager = NativeAdManager.this;
                            nativeAdManager.addAdView((Activity) context, nativeAdManager.mFeedView, layoutParams);
                            return;
                        }
                        Log.d(NativeAdManager.TAG, "feedView is null");
                    }
                });
                return;
            }
        }
        Log.d(TAG, "feed mediationManager is null");
    }

    /* JADX INFO: renamed from: com.bytedance.android.NativeAdManager$9, reason: invalid class name */
    class AnonymousClass9 implements Runnable {
        final /* synthetic */ Context val$context;
        final /* synthetic */ TTFeedAd val$feedAd;
        final /* synthetic */ MyDislikeCallback val$innerDislikeCallback;
        final /* synthetic */ int val$left;
        final /* synthetic */ TTNativeAd.AdInteractionListener val$listener;
        final /* synthetic */ int val$top;

        AnonymousClass9(TTFeedAd tTFeedAd, Context context, MyDislikeCallback myDislikeCallback, TTNativeAd.AdInteractionListener adInteractionListener, int i, int i2) {
            this.val$feedAd = tTFeedAd;
            this.val$context = context;
            this.val$innerDislikeCallback = myDislikeCallback;
            this.val$listener = adInteractionListener;
            this.val$left = i;
            this.val$top = i2;
        }

        @Override // java.lang.Runnable
        public void run() {
            this.val$feedAd.setDislikeCallback((Activity) this.val$context, this.val$innerDislikeCallback);
            this.val$feedAd.setExpressRenderListener(new MediationExpressRenderListener() { // from class: com.bytedance.android.NativeAdManager.9.1
                @Override // com.bytedance.sdk.openadsdk.mediation.ad.MediationExpressRenderListener
                public void onRenderFail(View view, String str, int i) {
                    Log.d(NativeAdManager.TAG, "feed express render fail, errCode: " + i + ", errMsg: " + str);
                }

                @Override // com.bytedance.sdk.openadsdk.mediation.ad.MediationExpressRenderListener
                public void onAdClick() {
                    Log.d(NativeAdManager.TAG, "feed express click");
                    if (AnonymousClass9.this.val$listener != null) {
                        AnonymousClass9.this.val$listener.onAdClicked(null, AnonymousClass9.this.val$feedAd);
                    }
                }

                @Override // com.bytedance.sdk.openadsdk.mediation.ad.MediationExpressRenderListener
                public void onAdShow() {
                    Log.d(NativeAdManager.TAG, "feed express show");
                    if (AnonymousClass9.this.val$listener != null) {
                        AnonymousClass9.this.val$listener.onAdShow(AnonymousClass9.this.val$feedAd);
                    }
                }

                @Override // com.bytedance.sdk.openadsdk.TTNativeAd.ExpressRenderListener
                public void onRenderSuccess(View view, float f, float f2, boolean z) {
                    Log.d(NativeAdManager.TAG, "feed express render success");
                    final View adView = AnonymousClass9.this.val$feedAd.getAdView();
                    if (adView != null) {
                        NativeAdManager.this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.9.1.1
                            @Override // java.lang.Runnable
                            public void run() {
                                NativeAdManager.this.removeFeedView(AnonymousClass9.this.val$context);
                                NativeAdManager.this.mFeedView = adView;
                                FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, 600);
                                layoutParams.gravity = 51;
                                layoutParams.leftMargin = AnonymousClass9.this.val$left;
                                layoutParams.topMargin = AnonymousClass9.this.val$top;
                                NativeAdManager.this.addAdView((Activity) AnonymousClass9.this.val$context, NativeAdManager.this.mFeedView, layoutParams);
                            }
                        });
                    }
                }
            });
            this.val$feedAd.render();
        }
    }

    public void destroyExpressBannerAd(Activity activity, TTNativeExpressAd tTNativeExpressAd) {
        destoryExpressAd(activity, tTNativeExpressAd, this.mExpressBannerView);
    }

    public void destroyExpressFeedAd(Activity activity, TTNativeExpressAd tTNativeExpressAd) {
        destoryExpressAd(activity, tTNativeExpressAd, this.mExpressView);
    }

    public void destroyBannerAd(final Activity activity, final TTNativeAd tTNativeAd) {
        this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.11
            @Override // java.lang.Runnable
            public void run() {
                NativeAdManager.this.removeBannerView(activity);
                TTNativeAd tTNativeAd2 = tTNativeAd;
                if (tTNativeAd2 != null) {
                    tTNativeAd2.destroy();
                }
            }
        });
    }

    public void destroyFeedAd(final Activity activity, final TTFeedAd tTFeedAd) {
        this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.12
            @Override // java.lang.Runnable
            public void run() {
                NativeAdManager.this.removeFeedView(activity);
                TTFeedAd tTFeedAd2 = tTFeedAd;
                if (tTFeedAd2 != null) {
                    tTFeedAd2.destroy();
                }
            }
        });
    }

    private void destoryExpressAd(final Activity activity, final TTNativeExpressAd tTNativeExpressAd, final View view) {
        this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.13
            @Override // java.lang.Runnable
            public void run() {
                NativeAdManager.this.removeAdView(activity, view);
                TTNativeExpressAd tTNativeExpressAd2 = tTNativeExpressAd;
                if (tTNativeExpressAd2 != null) {
                    tTNativeExpressAd2.destroy();
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void removeFeedView(Context context) {
        removeAdView((Activity) context, this.mFeedView);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void removeBannerView(Context context) {
        removeAdView((Activity) context, this.mBannerView);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void removeExpressView(Context context) {
        removeAdView((Activity) context, this.mExpressView);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void removeExpressBannerView(Context context) {
        removeAdView((Activity) context, this.mExpressBannerView);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public float dip2Px(Context context, float f) {
        return (f * context.getResources().getDisplayMetrics().density) + 0.5f;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void setBannerAdData(final Context context, BannerView bannerView, TTNativeAd tTNativeAd, final TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback, final TTNativeAd.AdInteractionListener adInteractionListener) {
        TTImage tTImage;
        bannerView.setTitle(tTNativeAd.getTitle());
        View disLikeView = bannerView.getDisLikeView();
        Button createButton = bannerView.getCreateButton();
        bindDislikeAction(context, tTNativeAd, disLikeView, new TTAdDislike.DislikeInteractionCallback() { // from class: com.bytedance.android.NativeAdManager.14
            @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
            public void onSelected(int i, String str, boolean z) {
                TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback2 = dislikeInteractionCallback;
                if (dislikeInteractionCallback2 != null) {
                    dislikeInteractionCallback2.onSelected(i, str, z);
                }
                NativeAdManager.this.removeBannerView(context);
            }

            @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
            public void onCancel() {
                TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback2 = dislikeInteractionCallback;
                if (dislikeInteractionCallback2 != null) {
                    dislikeInteractionCallback2.onCancel();
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
            public void onShow() {
                TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback2 = dislikeInteractionCallback;
                if (dislikeInteractionCallback2 != null) {
                    dislikeInteractionCallback2.onShow();
                }
            }
        });
        if (tTNativeAd.getImageList() != null && !tTNativeAd.getImageList().isEmpty() && (tTImage = tTNativeAd.getImageList().get(0)) != null && tTImage.isValid()) {
            loadImgByVolley(tTImage.getImageUrl(), bannerView.getImageView());
        }
        int interactionType = tTNativeAd.getInteractionType();
        if (interactionType == 2 || interactionType == 3) {
            createButton.setVisibility(0);
            createButton.setText("查看详情");
        } else if (interactionType == 4) {
            tTNativeAd.setActivityForDownloadApp((Activity) context);
            createButton.setVisibility(0);
            tTNativeAd.setDownloadListener(new MyDownloadListener(createButton));
        } else if (interactionType == 5) {
            createButton.setVisibility(0);
            createButton.setText("立即拨打");
        } else {
            createButton.setVisibility(8);
        }
        ArrayList arrayList = new ArrayList();
        arrayList.add(bannerView);
        ArrayList arrayList2 = new ArrayList();
        arrayList2.add(createButton);
        tTNativeAd.registerViewForInteraction(bannerView, arrayList, arrayList2, disLikeView, new TTNativeAd.AdInteractionListener() { // from class: com.bytedance.android.NativeAdManager.15
            @Override // com.bytedance.sdk.openadsdk.TTNativeAd.AdInteractionListener
            public void onAdClicked(View view, TTNativeAd tTNativeAd2) {
                TTNativeAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onAdClicked(view, tTNativeAd2);
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTNativeAd.AdInteractionListener
            public void onAdCreativeClick(View view, TTNativeAd tTNativeAd2) {
                TTNativeAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onAdCreativeClick(view, tTNativeAd2);
                }
            }

            @Override // com.bytedance.sdk.openadsdk.TTNativeAd.AdInteractionListener
            public void onAdShow(TTNativeAd tTNativeAd2) {
                TTNativeAd.AdInteractionListener adInteractionListener2 = adInteractionListener;
                if (adInteractionListener2 != null) {
                    adInteractionListener2.onAdShow(tTNativeAd2);
                }
            }
        });
    }

    private void bindDislikeAction(Context context, TTNativeAd tTNativeAd, View view, TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback) {
        final TTAdDislike dislikeDialog = tTNativeAd.getDislikeDialog((Activity) context);
        if (dislikeDialog != null) {
            dislikeDialog.setDislikeInteractionCallback(dislikeInteractionCallback);
        }
        view.setOnClickListener(new View.OnClickListener() { // from class: com.bytedance.android.NativeAdManager.16
            @Override // android.view.View.OnClickListener
            public void onClick(View view2) {
                Log.e(NativeAdManager.TAG, "dislikeView onClick");
                TTAdDislike tTAdDislike = dislikeDialog;
                if (tTAdDislike != null) {
                    tTAdDislike.showDislikeDialog();
                }
            }
        });
    }

    static class MyDownloadListener implements TTAppDownloadListener {
        Button mDownloadButton;
        Handler mHandler = new Handler(Looper.getMainLooper());

        public MyDownloadListener(Button button) {
            this.mDownloadButton = button;
        }

        @Override // com.bytedance.sdk.openadsdk.TTAppDownloadListener
        public void onIdle() {
            this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.MyDownloadListener.1
                @Override // java.lang.Runnable
                public void run() {
                    if (MyDownloadListener.this.mDownloadButton != null) {
                        MyDownloadListener.this.mDownloadButton.setText("开始下载");
                    }
                }
            });
        }

        @Override // com.bytedance.sdk.openadsdk.TTAppDownloadListener
        public void onDownloadActive(final long j, final long j2, String str, String str2) {
            this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.MyDownloadListener.2
                @Override // java.lang.Runnable
                public void run() {
                    if (MyDownloadListener.this.mDownloadButton != null) {
                        long j3 = j;
                        if (j3 <= 0) {
                            MyDownloadListener.this.mDownloadButton.setText("下载中 percent: 0");
                        } else if (j3 > 0) {
                            MyDownloadListener.this.mDownloadButton.setText("下载中 percent: " + ((j2 * 100) / j));
                        }
                    }
                }
            });
        }

        @Override // com.bytedance.sdk.openadsdk.TTAppDownloadListener
        public void onDownloadPaused(final long j, final long j2, String str, String str2) {
            this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.MyDownloadListener.3
                @Override // java.lang.Runnable
                public void run() {
                    if (MyDownloadListener.this.mDownloadButton == null || j <= 0) {
                        return;
                    }
                    MyDownloadListener.this.mDownloadButton.setText("下载暂停 percent: " + ((j2 * 100) / j));
                }
            });
        }

        @Override // com.bytedance.sdk.openadsdk.TTAppDownloadListener
        public void onDownloadFailed(long j, long j2, String str, String str2) {
            this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.MyDownloadListener.4
                @Override // java.lang.Runnable
                public void run() {
                    if (MyDownloadListener.this.mDownloadButton != null) {
                        MyDownloadListener.this.mDownloadButton.setText("重新下载");
                    }
                }
            });
        }

        @Override // com.bytedance.sdk.openadsdk.TTAppDownloadListener
        public void onInstalled(String str, String str2) {
            this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.MyDownloadListener.5
                @Override // java.lang.Runnable
                public void run() {
                    if (MyDownloadListener.this.mDownloadButton != null) {
                        MyDownloadListener.this.mDownloadButton.setText("点击打开");
                    }
                }
            });
        }

        @Override // com.bytedance.sdk.openadsdk.TTAppDownloadListener
        public void onDownloadFinished(long j, String str, String str2) {
            this.mHandler.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.MyDownloadListener.6
                @Override // java.lang.Runnable
                public void run() {
                    if (MyDownloadListener.this.mDownloadButton != null) {
                        MyDownloadListener.this.mDownloadButton.setText("点击安装");
                    }
                }
            });
        }
    }

    static class MyDislikeCallback implements TTAdDislike.DislikeInteractionCallback {
        private TTAdDislike.DislikeInteractionCallback mCallback;
        private Runnable mRunnable;

        MyDislikeCallback(TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback, Runnable runnable) {
            this.mCallback = dislikeInteractionCallback;
            this.mRunnable = runnable;
        }

        @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
        public void onShow() {
            TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback = this.mCallback;
            if (dislikeInteractionCallback != null) {
                dislikeInteractionCallback.onShow();
            }
        }

        @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
        public void onSelected(int i, String str, boolean z) {
            TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback = this.mCallback;
            if (dislikeInteractionCallback != null) {
                dislikeInteractionCallback.onSelected(i, str, z);
            }
            Runnable runnable = this.mRunnable;
            if (runnable != null) {
                runnable.run();
            }
        }

        @Override // com.bytedance.sdk.openadsdk.TTAdDislike.DislikeInteractionCallback
        public void onCancel() {
            TTAdDislike.DislikeInteractionCallback dislikeInteractionCallback = this.mCallback;
            if (dislikeInteractionCallback != null) {
                dislikeInteractionCallback.onCancel();
            }
        }
    }

    public static void loadImgByVolley(final String str, final ImageView imageView) {
        if (imageView == null || str == null) {
            return;
        }
        new Thread(new Runnable() { // from class: com.bytedance.android.NativeAdManager.17
            @Override // java.lang.Runnable
            public void run() {
                try {
                    HttpURLConnection httpURLConnection = (HttpURLConnection) new URL(str).openConnection();
                    httpURLConnection.setRequestMethod("GET");
                    httpURLConnection.setReadTimeout(5000);
                    httpURLConnection.setConnectTimeout(5000);
                    if (httpURLConnection.getResponseCode() == 200) {
                        final Bitmap bitmapDecodeStream = BitmapFactory.decodeStream(httpURLConnection.getInputStream());
                        imageView.post(new Runnable() { // from class: com.bytedance.android.NativeAdManager.17.1
                            @Override // java.lang.Runnable
                            public void run() {
                                imageView.setImageBitmap(bitmapDecodeStream);
                            }
                        });
                    }
                } catch (Throwable unused) {
                }
            }
        }).start();
    }
}
