package com.kwad.components.ad.splashscreen.presenter;

import android.graphics.Bitmap;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.SystemClock;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.kwad.components.ad.splashscreen.SplashPreloadManager;
import com.kwad.components.ad.splashscreen.presenter.playcard.SplashPlayDefaultInfoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.imageloader.core.assist.FailReason;
import com.kwad.sdk.core.imageloader.core.decode.DecodedResult;
import com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener;
import com.kwad.sdk.core.imageloader.utils.BlurUtils;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.io.File;
import java.io.InputStream;

/* JADX INFO: loaded from: classes3.dex */
public final class h extends e {
    private int HA;
    private long HC;
    private View HD;
    private ViewGroup HE;
    private SplashPlayDefaultInfoView HF;
    private ImageView Hw;
    private ImageView Hx;
    private AdInfo mAdInfo;
    private boolean Hy = false;
    private boolean Hz = false;
    private int HB = 1;
    Runnable HG = new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.h.5
        @Override // java.lang.Runnable
        public final void run() {
            h.this.mF();
        }
    };

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.HD = findViewById(R.id.ksad_splash_root_container);
        this.Hx = (ImageView) findViewById(R.id.ksad_splash_background);
        this.Hw = (ImageView) findViewById(R.id.ksad_splash_foreground);
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate);
        this.HE = (ViewGroup) findViewById(R.id.ksad_splash_default_image_view_container);
        this.HF = (SplashPlayDefaultInfoView) findViewById(R.id.ksad_splash_default_image_view);
        this.HA = com.kwad.components.ad.splashscreen.h.af(this.Hu.mAdTemplate) ? 2 : 1;
        String string = com.kwad.sdk.core.response.helper.a.ba(this.mAdInfo).materialUrl;
        this.Hx.setVisibility(0);
        int i = com.kwad.sdk.core.response.helper.a.ba(this.mAdInfo).source;
        mE();
        if (getContext() != null) {
            SplashPreloadManager.lX();
            File fileAc = SplashPreloadManager.ac(this.mAdInfo.adPreloadInfo.preloadId);
            if (fileAc != null && fileAc.exists() && fileAc.length() > 0) {
                this.HB = 2;
                string = Uri.fromFile(fileAc).toString();
            }
            l(string, i);
        }
    }

    private void l(String str, int i) {
        if (i == 0) {
            this.Hw.setScaleType(ImageView.ScaleType.CENTER_CROP);
            this.Hw.setVisibility(0);
            KSImageLoader.loadImage(this.Hw, str, this.Hu.mAdTemplate, new AnonymousClass1());
        } else {
            this.Hx.setVisibility(0);
            if (com.kwad.sdk.core.config.e.a(com.kwad.components.ad.splashscreen.b.a.He)) {
                a(this.Hx, this.mAdInfo);
            } else {
                a(this.Hx);
            }
            KSImageLoader.loadImage(this.Hx, str, this.Hu.mAdTemplate, new ImageLoadingListener() { // from class: com.kwad.components.ad.splashscreen.presenter.h.2
                @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
                public final boolean onDecode(String str2, InputStream inputStream, DecodedResult decodedResult) {
                    return false;
                }

                @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
                public final void onLoadingCancelled(String str2, View view) {
                }

                @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
                public final void onLoadingStarted(String str2, View view) {
                }

                @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
                public final void onLoadingFailed(String str2, View view, FailReason failReason) {
                    h.this.mF();
                }

                @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
                public final void onLoadingComplete(String str2, View view, DecodedResult decodedResult) {
                    if (com.kwad.sdk.core.config.e.a(com.kwad.components.ad.splashscreen.b.a.Hf)) {
                        long jElapsedRealtime = SystemClock.elapsedRealtime();
                        com.kwad.components.ad.splashscreen.monitor.b.mt();
                        com.kwad.components.ad.splashscreen.monitor.b.a(h.this.Hu.mAdTemplate, 2, h.this.HA, h.this.HB, jElapsedRealtime - h.this.HC, jElapsedRealtime - h.this.Hu.mAdTemplate.showTime);
                    }
                    h.this.mG();
                }
            });
        }
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.splashscreen.presenter.h$1, reason: invalid class name */
    final class AnonymousClass1 implements ImageLoadingListener {
        @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
        public final boolean onDecode(String str, InputStream inputStream, DecodedResult decodedResult) {
            return false;
        }

        @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
        public final void onLoadingCancelled(String str, View view) {
        }

        @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
        public final void onLoadingStarted(String str, View view) {
        }

        AnonymousClass1() {
        }

        @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
        public final void onLoadingFailed(String str, View view, FailReason failReason) {
            h.this.mF();
        }

        @Override // com.kwad.sdk.core.imageloader.core.listener.ImageLoadingListener
        public final void onLoadingComplete(String str, View view, final DecodedResult decodedResult) {
            if (com.kwad.sdk.core.config.e.a(com.kwad.components.ad.splashscreen.b.a.Hf)) {
                long jElapsedRealtime = SystemClock.elapsedRealtime();
                com.kwad.components.ad.splashscreen.monitor.b.mt();
                com.kwad.components.ad.splashscreen.monitor.b.a(h.this.Hu.mAdTemplate, 2, h.this.HA, h.this.HB, jElapsedRealtime - h.this.HC, jElapsedRealtime - h.this.Hu.mAdTemplate.showTime);
            }
            h.this.mG();
            h.this.Hx.setVisibility(0);
            GlobalThreadPools.Oh().submit(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.h.1.1
                @Override // java.lang.Runnable
                public final void run() {
                    final Bitmap bitmapStackBlur = BlurUtils.stackBlur(decodedResult.mBitmap, 20, false);
                    h.this.Hx.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.h.1.1.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            h.this.Hx.setImageDrawable(new BitmapDrawable(h.this.getContext().getResources(), bitmapStackBlur));
                        }
                    });
                }
            });
        }
    }

    private void a(final ImageView imageView, final AdInfo adInfo) {
        ((FrameLayout) this.Hu.mRootContainer.findViewById(R.id.splash_play_card_view)).setClipChildren(false);
        final AdInfo.CutRuleInfo cutRuleInfoCA = com.kwad.sdk.core.response.helper.a.cA(adInfo);
        imageView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.h.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                int height = imageView.getHeight();
                int width = imageView.getWidth();
                double d = com.kwad.sdk.core.response.helper.a.ba(adInfo).width;
                double d2 = cutRuleInfoCA.picHeight;
                double d3 = cutRuleInfoCA.viewTopMargin;
                double d4 = cutRuleInfoCA.safeAreaHeight;
                if (d2 <= 0.0d || d4 <= 0.0d) {
                    return;
                }
                double d5 = ((double) width) / d;
                double d6 = d3 / (d2 - d4);
                double d7 = d3 * d5;
                double d8 = (d2 * d5) - ((double) height);
                ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) imageView.getLayoutParams();
                marginLayoutParams.topMargin = (int) (((d8 / 2.0d) - (d7 - (d7 - (d6 * d8)))) * 2.0d);
                imageView.setLayoutParams(marginLayoutParams);
            }
        });
    }

    private void a(final ImageView imageView) {
        ((FrameLayout) this.Hu.mRootContainer.findViewById(R.id.splash_play_card_view)).setClipChildren(false);
        imageView.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.h.4
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                int height = imageView.getHeight();
                float width = imageView.getWidth() / 1080.0f;
                float f = ((width * 880.0f) * 1152.0f) / 880.0f;
                float f2 = width * 2340.0f;
                float f3 = height;
                float f4 = (f2 - f3) / 2.0f;
                float f5 = f2 - f;
                float f6 = (0.44107744f * f5) - f4;
                ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) imageView.getLayoutParams();
                marginLayoutParams.topMargin = (int) (((((f5 * 0.5589225f) - f4) - f6) / 2.0f) - (f3 * 0.03f));
                imageView.setLayoutParams(marginLayoutParams);
            }
        });
    }

    private void mE() {
        if (com.kwad.sdk.core.config.e.a(com.kwad.components.ad.splashscreen.b.a.Hf)) {
            this.HC = SystemClock.elapsedRealtime();
            com.kwad.components.ad.splashscreen.monitor.b.mt();
            com.kwad.components.ad.splashscreen.monitor.b.e(this.Hu.mAdTemplate, 2, this.HA);
            by.runOnUiThreadDelay(this.HG, com.kwad.sdk.core.config.e.a(com.kwad.components.ad.splashscreen.b.a.Hg));
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void mF() {
        if (this.Hy) {
            return;
        }
        if (com.kwad.sdk.core.config.e.a(com.kwad.components.ad.splashscreen.b.a.Hf)) {
            long jElapsedRealtime = SystemClock.elapsedRealtime();
            com.kwad.components.ad.splashscreen.monitor.b.mt();
            com.kwad.components.ad.splashscreen.monitor.b.b(this.Hu.mAdTemplate, 2, this.HA, this.HB, jElapsedRealtime - this.HC, jElapsedRealtime - this.Hu.mAdTemplate.showTime);
        }
        this.Hy = true;
        this.HD.post(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.h.6
            @Override // java.lang.Runnable
            public final void run() {
                float fPx2dip = com.kwad.sdk.c.a.a.px2dip(h.this.getContext(), h.this.HD.getHeight()) / 414.0f;
                h.this.HE.setVisibility(0);
                h.this.HF.a(h.this.Hu.mAdTemplate, fPx2dip);
            }
        });
        this.Hw.setVisibility(8);
        this.Hx.setVisibility(8);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        mG();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void mG() {
        if (this.Hz) {
            return;
        }
        this.Hz = true;
        if (com.kwad.sdk.core.config.e.a(com.kwad.components.ad.splashscreen.b.a.Hf)) {
            by.b(this.HG);
        }
    }
}
