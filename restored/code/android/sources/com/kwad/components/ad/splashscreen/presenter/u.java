package com.kwad.components.ad.splashscreen.presenter;

import android.os.SystemClock;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.kwad.components.ad.splashscreen.widget.SkipView;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.utils.bi;

/* JADX INFO: loaded from: classes3.dex */
public final class u extends e implements com.kwad.sdk.core.j.c {
    private SkipView Jo;
    private ImageView kw;
    private AdInfo mAdInfo;
    private volatile boolean Jl = false;
    private boolean Jm = false;
    private boolean Jn = false;
    private com.kwad.sdk.utils.j.a kx = new com.kwad.sdk.utils.j.a() { // from class: com.kwad.components.ad.splashscreen.presenter.u.1
        @Override // com.kwad.sdk.utils.j.a
        public final void onAudioBeReleased() {
        }

        @Override // com.kwad.sdk.utils.j.a
        public final void onAudioBeOccupied() {
            u.this.Jl = false;
            if (u.this.kw != null) {
                u.this.kw.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.u.1.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        if (u.this.Hu.GF != null) {
                            u.this.Hu.GF.setAudioEnabled(u.this.Jl, false);
                        }
                        if (u.this.Hu != null) {
                            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(u.this.Hu.mAdTemplate);
                            String str = u.this.Jl ? adInfoEM.adSplashInfo.speakerIconUrl : adInfoEM.adSplashInfo.speakerMuteIconUrl;
                            if (!TextUtils.isEmpty(str)) {
                                KSImageLoader.loadImage(u.this.kw, str, u.this.Hu.mAdTemplate);
                            } else {
                                u.this.kw.setImageDrawable(u.this.getContext().getResources().getDrawable(R.drawable.ksad_splash_sound_selector));
                            }
                            u.this.kw.setSelected(false);
                        }
                    }
                });
            }
        }
    };
    private com.kwad.components.core.video.l Jp = new com.kwad.components.core.video.m() { // from class: com.kwad.components.ad.splashscreen.presenter.u.2
        private boolean Js = false;
        private String Jt = com.kwad.sdk.core.config.e.a(com.kwad.components.ad.splashscreen.b.a.Hc);

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayPaused() {
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.l
        public final void onVideoPlayBufferingPaused() {
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.l
        public final void onVideoPlayBufferingPlaying() {
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, final long j2) {
            u.this.Hu.an(((int) j2) / 1000);
            final int iMin = Math.min(u.this.mAdInfo.adSplashInfo.videoDisplaySecond, ((int) j) / 1000);
            final String str = this.Jt;
            u uVar = u.this;
            if (u.a(uVar, uVar.mAdInfo)) {
                u.this.Jo.post(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.u.2.1
                    @Override // java.lang.Runnable
                    public final void run() {
                        int i = (int) ((((long) (iMin * 1000)) - j2) / 1000);
                        if (i <= 0) {
                            i = 1;
                        }
                        u.this.Jo.ae(str + i);
                    }
                });
            }
            float f = j2 / 1000.0f;
            if (iMin <= 0 || ((double) f) + 0.5d <= iMin - 1 || this.Js) {
                return;
            }
            u uVar2 = u.this;
            if (u.a(uVar2, uVar2.mAdInfo)) {
                u.this.Hu.mk();
                this.Js = true;
            }
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            if (u.this.Hu.GF != null) {
                u.this.Hu.GF.setAudioEnabled(u.this.Jl, false);
            }
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlaying() {
            if (u.this.Jm) {
                return;
            }
            u.this.Hu.ag(false);
            if (u.this.Hu.GF != null) {
                u.this.Hu.GF.ah(true);
                u.this.Hu.GF.setAudioEnabled(u.this.Jl, true);
            }
            u.b(u.this, true);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            if (this.Js) {
                return;
            }
            u.this.Hu.mk();
            this.Js = true;
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayError(int i, int i2) {
            if (u.this.Hu != null && u.this.Hu.GF != null) {
                long jElapsedRealtime = SystemClock.elapsedRealtime();
                com.kwad.components.ad.splashscreen.monitor.b.mt();
                com.kwad.components.ad.splashscreen.monitor.b.b(u.this.Hu.mAdTemplate, 1, u.this.Hu.GF.HA, 2, jElapsedRealtime - u.this.Hu.GF.KG, jElapsedRealtime - u.this.Hu.mAdTemplate.showTime);
            }
            if (u.this.Jn || u.this.Hu == null) {
                return;
            }
            u.this.Hu.c(0, "onMediaPlayError");
        }
    };

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
    }

    static /* synthetic */ boolean a(u uVar, AdInfo adInfo) {
        return v(adInfo);
    }

    static /* synthetic */ boolean b(u uVar, boolean z) {
        uVar.Jm = true;
        return true;
    }

    private void a(final DetailVideoView detailVideoView) {
        final View viewFindViewById = findViewById(R.id.splash_play_card_view);
        viewFindViewById.post(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.u.3
            @Override // java.lang.Runnable
            public final void run() {
                float width = viewFindViewById.getWidth();
                float height = viewFindViewById.getHeight();
                if (width <= 0.0f || height <= 0.0f) {
                    return;
                }
                AdInfo.AdMaterialInfo.MaterialFeature materialFeatureBb = com.kwad.sdk.core.response.helper.a.bb(u.this.mAdInfo);
                if (materialFeatureBb.videoWidth > 0) {
                    com.kwad.sdk.c.a.a.b(detailVideoView, materialFeatureBb.width, materialFeatureBb.height);
                }
            }
        });
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        int i;
        super.av();
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate);
        DetailVideoView detailVideoView = (DetailVideoView) this.Hu.mRootContainer.findViewById(R.id.ksad_splash_video_player);
        detailVideoView.setVisibility(0);
        if (com.kwad.sdk.core.response.helper.a.dv(this.mAdInfo)) {
            a(detailVideoView);
        }
        if (this.Hu.GF != null) {
            this.Hu.GF.b(this.Jp);
        }
        this.Hu.GH.a(this);
        AdBaseFrameLayout adBaseFrameLayout = this.Hu.mRootContainer;
        if (com.kwad.components.ad.splashscreen.e.c.A(this.mAdInfo)) {
            i = R.id.ksad_splash_skip_right_view;
        } else {
            i = R.id.ksad_splash_skip_left_view;
        }
        this.Jo = (SkipView) adBaseFrameLayout.findViewById(i);
        if (v(this.mAdInfo)) {
            a(this.Jo, this.mAdInfo);
        }
        int i2 = this.mAdInfo.adSplashInfo.mute;
        if (i2 == 2) {
            this.Jl = true;
        } else if (i2 == 3) {
            this.Jl = com.kwad.sdk.utils.n.db(this.Hu.mRootContainer.getContext()) > 0;
        } else {
            this.Jl = false;
        }
        if (com.kwad.components.core.t.a.aN(getContext()).wP()) {
            this.Jl = false;
        }
        if (this.Hu.GF != null) {
            this.Hu.GF.setAudioEnabled(this.Jl, false);
            this.Hu.GF.a(this.kx);
        }
        this.kw = (ImageView) this.Hu.mRootContainer.findViewById(R.id.ksad_splash_sound);
        if (com.kwad.components.ad.splashscreen.e.c.A(this.mAdInfo)) {
            FrameLayout.LayoutParams layoutParams = (FrameLayout.LayoutParams) this.kw.getLayoutParams();
            layoutParams.gravity = 51;
            this.kw.setLayoutParams(layoutParams);
            ViewGroup.LayoutParams layoutParams2 = this.kw.getLayoutParams();
            if (layoutParams2 instanceof ViewGroup.MarginLayoutParams) {
                ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) layoutParams2;
                marginLayoutParams.topMargin = com.kwad.sdk.c.a.a.a(this.kw.getContext(), 32.0f);
                marginLayoutParams.leftMargin = com.kwad.sdk.c.a.a.a(this.kw.getContext(), 16.0f);
            }
        }
        this.kw.setVisibility(0);
        String str = this.Jl ? this.mAdInfo.adSplashInfo.speakerIconUrl : this.mAdInfo.adSplashInfo.speakerMuteIconUrl;
        if (!TextUtils.isEmpty(str)) {
            KSImageLoader.loadImage(this.kw, str, this.Hu.mAdTemplate);
        } else {
            this.kw.setImageDrawable(getContext().getResources().getDrawable(R.drawable.ksad_splash_sound_selector));
        }
        this.kw.setSelected(this.Jl);
        this.kw.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.splashscreen.presenter.u.4
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                u uVar = u.this;
                uVar.Jl = !uVar.Jl;
                String str2 = u.this.Jl ? u.this.mAdInfo.adSplashInfo.speakerIconUrl : u.this.mAdInfo.adSplashInfo.speakerMuteIconUrl;
                if (!TextUtils.isEmpty(str2)) {
                    KSImageLoader.loadImage(u.this.kw, str2, u.this.Hu.mAdTemplate);
                } else {
                    u.this.kw.setImageDrawable(u.this.getContext().getResources().getDrawable(R.drawable.ksad_splash_sound_selector));
                }
                u.this.kw.setSelected(u.this.Jl);
                u.this.Hu.GF.setAudioEnabled(u.this.Jl, true);
            }
        });
    }

    private static boolean v(AdInfo adInfo) {
        return !com.kwad.sdk.core.response.helper.a.cI(adInfo);
    }

    private static void a(SkipView skipView, AdInfo adInfo) {
        skipView.setTimerBtnVisible(com.kwad.sdk.core.response.helper.a.cL(adInfo));
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        if (this.Hu.GF != null) {
            this.Hu.GF.a(this.Jp);
            this.Hu.GF.b(this.kx);
        }
        if (this.Jo.getHandler() != null) {
            this.Jo.getHandler().removeCallbacksAndMessages(null);
        }
        this.Hu.GH.b(this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        this.Jn = true;
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        if (this.Hu.GF != null) {
            this.Hu.GF.pause();
        }
    }
}
