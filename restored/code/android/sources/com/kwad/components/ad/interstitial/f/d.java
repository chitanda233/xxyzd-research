package com.kwad.components.ad.interstitial.f;

import android.graphics.Color;
import android.text.TextUtils;
import android.view.ViewGroup;
import android.view.ViewParent;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.widget.KsAutoCloseView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.widget.KSFrameLayout;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends b {
    public static float nl = 1.3333334f;
    private static float nm = 0.749f;
    private static float nn = 0.8f;
    private static float no = 1.0f;
    private com.kwad.sdk.core.video.videoview.a cB;
    private com.kwad.components.core.widget.a.c fs;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private KsAutoCloseView mC;
    private c mF;
    private boolean nj;
    private KSFrameLayout nk;
    private c.b np;
    private com.kwad.sdk.core.j.d nq = new com.kwad.sdk.core.j.d() { // from class: com.kwad.components.ad.interstitial.f.d.5
        @Override // com.kwad.sdk.core.j.d, com.kwad.sdk.core.j.c
        public final void bv() {
            if (!d.this.mAdTemplate.mPvReported && !d.this.mF.mJ && d.this.mF.lk != null) {
                d.this.mF.lk.onAdShow();
                d.this.mF.lp.getTimerHelper().startTiming();
                com.kwad.components.ad.interstitial.report.c.eX().a(d.this.mF.mAdTemplate, 1);
            }
            com.kwad.sdk.core.adlog.c.b bVarEe = new com.kwad.sdk.core.adlog.c.b().ee(d.this.mF.mT);
            if (!d.this.mAdTemplate.mPvReported) {
                com.kwad.components.ad.interstitial.report.c.eX().D(d.this.mAdTemplate);
            }
            com.kwad.components.core.t.b.wR().a(d.this.mAdTemplate, null, bVarEe);
            d.this.mC.setCountDownPaused(false);
        }

        @Override // com.kwad.sdk.core.j.d, com.kwad.sdk.core.j.c
        public final void bw() {
            d.this.mC.setCountDownPaused(true);
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        KsAutoCloseView ksAutoCloseView = (KsAutoCloseView) findViewById(R.id.ksad_interstitial_auto_close);
        this.mC = ksAutoCloseView;
        ksAutoCloseView.setViewListener(new KsAutoCloseView.a() { // from class: com.kwad.components.ad.interstitial.f.d.1
            @Override // com.kwad.components.core.widget.KsAutoCloseView.a
            public final void el() {
                d.this.o(true);
            }

            @Override // com.kwad.components.core.widget.KsAutoCloseView.a
            public final void em() {
                d.this.o(false);
            }
        });
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.mF.b(this.np);
        com.kwad.components.core.widget.a.c cVar = this.fs;
        if (cVar != null) {
            cVar.b(this.nq);
            this.fs.An();
        }
    }

    @Override // com.kwad.components.ad.interstitial.f.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        c cVar = (c) SK();
        this.mF = cVar;
        this.mAdTemplate = cVar.mAdTemplate;
        com.kwad.components.ad.interstitial.report.c.eX().C(this.mF.mAdTemplate);
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.mF.mAdTemplate);
        this.mAdInfo = adInfoEM;
        AdInfo.AdMaterialInfo.MaterialFeature materialFeatureBd = com.kwad.sdk.core.response.helper.a.bd(adInfoEM);
        if (materialFeatureBd.width > 0) {
            nl = materialFeatureBd.height / materialFeatureBd.width;
        }
        this.mF.gh.setBackgroundColor(Color.parseColor("#99000000"));
        this.mF.mG.setVisibility(0);
        this.mF.mG.H(this.mAdTemplate);
        this.mF.a(ei());
        ej();
        this.mF.mG.setViewListener(new com.kwad.components.ad.interstitial.h.e() { // from class: com.kwad.components.ad.interstitial.f.d.2
            @Override // com.kwad.components.ad.interstitial.h.e
            public final void en() {
                d.this.e(3, d.this.mF.mG.fo() ? 53 : 85);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void p(boolean z) {
                if (d.this.cB != null) {
                    d.this.cB.setVideoSoundEnable(z);
                }
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void em() {
                d.this.o(false);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void eo() {
                d.this.e(1, 39);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void ep() {
                d.this.e(1, 29);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void eq() {
                d.this.e(3, 85);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void er() {
                d.this.e(3, 85);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void es() {
                d.this.e(2, 53);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void q(boolean z) {
                d.this.nj = z;
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void a(KSFrameLayout kSFrameLayout) {
                d.this.nk = kSFrameLayout;
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void et() {
                d.this.e(2, 30);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void eu() {
                d.this.e(2, 31);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void ev() {
                d.this.e(2, 32);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void ew() {
                d.this.e(3, 15);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void ex() {
                d.this.e(3, 16);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void ey() {
                d.this.e(3, 17);
            }

            @Override // com.kwad.components.ad.interstitial.h.e
            public final void ez() {
                d.this.e(3, 35);
            }
        });
        com.kwad.components.core.widget.a.c cVar2 = new com.kwad.components.core.widget.a.c(this.mF.mG, 100);
        this.fs = cVar2;
        cVar2.a(this.nq);
        this.fs.Am();
        final boolean zBc = com.kwad.sdk.core.response.helper.a.bc(this.mAdInfo);
        getContext();
        final boolean zVV = as.VV();
        this.mF.mG.setRatio(c(zVV, zBc));
        final ViewGroup viewGroup = (ViewGroup) findViewById(R.id.ksad_interstitial_native);
        viewGroup.setVisibility(0);
        viewGroup.post(new bi() { // from class: com.kwad.components.ad.interstitial.f.d.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                ViewGroup.LayoutParams layoutParamsA = zVV ? d.a(d.this.getRootView().getWidth(), zBc) : d.N(d.this.getRootView().getHeight());
                ViewParent parent = d.this.mF.mG.getParent();
                if (parent instanceof ViewGroup) {
                    ((ViewGroup) parent).removeView(d.this.mF.mG);
                }
                viewGroup.addView(d.this.mF.mG);
                d.this.mF.mG.f(layoutParamsA.width, layoutParamsA.height);
                viewGroup.requestLayout();
                viewGroup.post(new bi() { // from class: com.kwad.components.ad.interstitial.f.d.3.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        if (d.this.cB != null) {
                            d.this.cB.requestLayout();
                        }
                    }
                });
            }
        });
    }

    private c.b ei() {
        c.b bVar = new c.b() { // from class: com.kwad.components.ad.interstitial.f.d.4
            @Override // com.kwad.components.ad.interstitial.f.c.b
            public final void c(long j, long j2) {
                com.kwad.components.ad.interstitial.report.a.eT().b(d.this.mAdTemplate, j, j2);
            }
        };
        this.np = bVar;
        return bVar;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static ViewGroup.LayoutParams a(int i, boolean z) {
        float f;
        if (z) {
            f = nn;
        } else {
            f = no;
        }
        int i2 = (int) (i * f);
        return new ViewGroup.LayoutParams(i2, (int) (i2 * (z ? nl : 0.749f)));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static ViewGroup.LayoutParams N(int i) {
        int i2 = (int) (i * nm);
        return new ViewGroup.LayoutParams((int) (i2 / 0.749f), i2);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void e(int i, int i2) {
        if (this.mF.a(new c.C0377c(getContext()).l(this.nj).a(this.nk.getTouchCoords()).L(i).M(i2)) && com.kwad.components.ad.interstitial.d.b.t(this.mAdTemplate) && this.mF.lp != null) {
            c cVar = this.mF;
            cVar.a(false, -1, cVar.cB);
            this.mF.lp.dismiss();
            this.mF.ac();
        }
    }

    private void ej() {
        final com.kwad.components.ad.interstitial.h.d dVar = this.mF.mG;
        dVar.setAdTemplate(this.mAdTemplate);
        if (com.kwad.sdk.core.response.helper.a.bj(this.mAdInfo)) {
            dVar.c(com.kwad.sdk.core.response.helper.a.ba(this.mAdInfo).materialUrl, this.mAdTemplate);
            dVar.d(true, true);
            dVar.u(false);
        } else {
            dVar.u(true);
            String url = com.kwad.sdk.core.response.helper.a.bA(this.mAdInfo).getUrl();
            if (!TextUtils.isEmpty(url)) {
                dVar.c(url, this.mAdTemplate);
                dVar.d(true, false);
            } else {
                dVar.d(false, false);
            }
            com.kwad.sdk.core.video.videoview.a aVar = this.mF.cB;
            this.cB = aVar;
            if (aVar.getParent() != null) {
                ((ViewGroup) this.cB.getParent()).removeView(this.cB);
            }
            if (com.kwad.sdk.core.response.helper.a.bi(this.mAdInfo)) {
                dVar.a(com.kwad.sdk.core.response.helper.a.bb(this.mAdInfo).height / com.kwad.sdk.core.response.helper.a.bb(this.mAdInfo).width, this.cB);
            }
            dVar.v(this.mF.ce.isVideoSoundEnable());
            final int iN = com.kwad.sdk.core.response.helper.a.N(this.mAdInfo);
            this.mF.a(new com.kwad.components.core.video.a.c() { // from class: com.kwad.components.ad.interstitial.f.d.6
                @Override // com.kwad.components.core.video.a.c
                public final void d(long j) {
                    int i = iN - ((int) (j / 1000));
                    if (i >= 0) {
                        dVar.A(String.valueOf(i));
                    } else {
                        dVar.fk();
                    }
                }

                @Override // com.kwad.components.core.video.a.c
                public final void onVideoPlayStart() {
                    dVar.u(true);
                }

                @Override // com.kwad.components.core.video.a.c
                public final void as() {
                    dVar.d(false, false);
                }

                @Override // com.kwad.components.core.video.a.c
                public final void at() {
                    d.this.cB.setVisibility(8);
                    if (d.this.mF.M(d.this.getContext())) {
                        return;
                    }
                    dVar.fm();
                }
            });
            dVar.a(this.mAdTemplate, this.mAdInfo);
            dVar.u(true);
            this.mF.mO.add(new c.d() { // from class: com.kwad.components.ad.interstitial.f.d.7
                @Override // com.kwad.components.ad.interstitial.f.c.d
                public final void eg() {
                    dVar.fn();
                    d.this.cB.setVisibility(0);
                }
            });
        }
        this.mF.a(getContext(), this.mAdInfo, this.mAdTemplate, dVar.getBlurBgView());
        String strQ = com.kwad.sdk.core.response.helper.a.Q(this.mAdInfo);
        if (TextUtils.isEmpty(strQ)) {
            strQ = com.kwad.sdk.core.response.helper.a.aa(this.mAdInfo);
        }
        KSImageLoader.loadImage(dVar.getTailFrameView(), strQ, this.mAdTemplate);
        if (c(this.mAdInfo)) {
            this.mC.bq(true);
            ek();
        } else {
            this.mC.bq(false);
        }
    }

    private static float c(boolean z, boolean z2) {
        if (z && z2) {
            return nl;
        }
        return 0.749f;
    }

    private void ek() {
        int iMin = this.mAdInfo.adInsertScreenInfo.autoCloseTime;
        if (com.kwad.sdk.core.response.helper.a.bi(this.mAdInfo)) {
            iMin = Math.min(iMin, com.kwad.sdk.core.response.helper.a.N(this.mAdInfo));
            this.mF.mG.fk();
            this.mF.mG.fl();
        }
        this.mC.ak(iMin);
        com.kwad.sdk.core.adlog.c.b(this.mAdTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_SUPER_RES_OPTION, (JSONObject) null);
    }

    private static boolean c(AdInfo adInfo) {
        return adInfo.adInsertScreenInfo.autoCloseTime > 0 && !com.kwad.sdk.core.response.helper.a.bQ(adInfo);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void o(boolean z) {
        if (!this.mF.mJ && !z && !this.mF.mH && !this.mF.mI && com.kwad.components.ad.interstitial.g.a.e(this.mF)) {
            this.mF.mI = true;
            com.kwad.components.ad.interstitial.c.b.K(getContext());
            return;
        }
        this.mF.a(z, -1, this.cB);
        this.mF.lp.dismiss();
        com.kwad.sdk.core.video.videoview.a aVar = this.cB;
        if (aVar != null) {
            aVar.release();
        }
        this.mF.ac();
    }
}
