package com.kwad.components.ad.interstitial;

import android.app.Activity;
import android.os.SystemClock;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.components.core.e.a.h;
import com.kwad.components.core.proxy.g;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.api.KsInterstitialAd;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bx;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends g {
    private com.kwad.components.ad.interstitial.h.a lg;
    private boolean lh;
    private com.kwad.components.ad.interstitial.g.b li;
    private final KsAdVideoPlayConfig lj;
    private KsInterstitialAd.AdInteractionListener lk;
    private final com.kwad.components.core.widget.g ll;
    private final AdResultData mAdResultData;
    private final AdTemplate mAdTemplate;
    public long mStartRenderTime;
    private bx mTimerHelper;

    @Override // com.kwad.components.core.proxy.g
    public final float dz() {
        return 0.0f;
    }

    @Override // com.kwad.components.core.proxy.g
    public final int getLayoutId() {
        return 0;
    }

    public final void setAdInteractionListener(KsInterstitialAd.AdInteractionListener adInteractionListener) {
        this.lk = adInteractionListener;
        com.kwad.components.ad.interstitial.h.a aVar = this.lg;
        if (aVar != null) {
            aVar.setAdInteractionListener(adInteractionListener);
        }
    }

    public final bx getTimerHelper() {
        if (this.mTimerHelper == null) {
            this.mTimerHelper = new bx();
        }
        return this.mTimerHelper;
    }

    public d(Activity activity, AdResultData adResultData, KsVideoPlayConfig ksVideoPlayConfig, KsInterstitialAd.AdInteractionListener adInteractionListener) {
        super(activity);
        this.mStartRenderTime = -1L;
        this.ll = new com.kwad.components.core.widget.g() { // from class: com.kwad.components.ad.interstitial.d.1
            @Override // com.kwad.components.core.widget.g
            public final void k(boolean z) {
                if (d.this.lh) {
                    Activity activity2 = d.this.mActivity;
                    com.kwad.sdk.core.c.b.Mh();
                    if (activity2 == com.kwad.sdk.core.c.b.getCurrentActivity()) {
                        com.kwad.sdk.core.adlog.c.l(d.this.mAdTemplate, z ? 2 : 1);
                        d.this.dC();
                    }
                }
            }
        };
        this.mStartRenderTime = SystemClock.elapsedRealtime();
        this.lk = adInteractionListener;
        this.lj = new KsAdVideoPlayConfig.Builder().videoSoundEnable(ksVideoPlayConfig != null && ksVideoPlayConfig.isVideoSoundEnable()).dataFlowAutoStart(com.kwad.components.ad.interstitial.b.b.dM()).build();
        this.mAdResultData = adResultData;
        this.mAdTemplate = com.kwad.sdk.core.response.helper.c.r(adResultData);
    }

    @Override // com.kwad.components.core.proxy.g
    public final ViewGroup dA() {
        com.kwad.components.core.widget.f fVar = new com.kwad.components.core.widget.f(this.mContext);
        fVar.setOrientationChangeListener(this.ll);
        return fVar;
    }

    @Override // com.kwad.components.core.proxy.g
    public final void g(View view) {
        h.a(getWindow());
        dC();
        com.kwad.components.ad.interstitial.report.c.eX().A(this.mAdTemplate);
        com.kwad.sdk.commercial.convert.c.cd(this.mAdTemplate);
    }

    private static boolean e(AdResultData adResultData) {
        return com.kwad.sdk.core.response.helper.c.u(adResultData);
    }

    private static boolean dB() {
        return com.kwad.sdk.core.config.e.Ll();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void dC() {
        if (dB()) {
            this.lg = new com.kwad.components.ad.interstitial.aggregate.c(this.mContext);
        } else if (e(this.mAdResultData)) {
            this.lg = new com.kwad.components.ad.interstitial.aggregate.b(this.mContext);
        } else {
            this.lg = new com.kwad.components.ad.interstitial.h.c(this.mContext);
        }
        this.lg.a(this.mAdResultData, this, this.lj, this.lk, 0);
        this.DQ.removeAllViews();
        this.DQ.addView(this.lg);
        dD();
    }

    private void dD() {
        com.kwad.components.ad.interstitial.g.b bVar = new com.kwad.components.ad.interstitial.g.b(this.lg, 100);
        this.li = bVar;
        bVar.a(new com.kwad.sdk.core.j.c() { // from class: com.kwad.components.ad.interstitial.d.2
            @Override // com.kwad.sdk.core.j.c
            public final void bv() {
                d.this.getTimerHelper().Xn();
            }

            @Override // com.kwad.sdk.core.j.c
            public final void bw() {
                d.this.getTimerHelper().Xo();
            }
        });
        this.li.Am();
    }

    @Override // android.app.Dialog, android.view.Window.Callback
    public final void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        com.kwad.components.ad.interstitial.g.b bVar = this.li;
        if (bVar != null) {
            bVar.release();
        }
    }

    @Override // android.app.Dialog, android.view.Window.Callback
    public final void onWindowFocusChanged(boolean z) {
        super.onWindowFocusChanged(z);
        this.lh = z;
        com.kwad.components.ad.interstitial.h.a aVar = this.lg;
        if (aVar != null) {
            if (z) {
                aVar.dF();
            } else {
                aVar.dG();
            }
        }
    }

    @Override // com.kwad.components.core.proxy.g, android.app.Dialog, android.content.DialogInterface
    public final void dismiss() {
        try {
            super.dismiss();
            com.kwad.sdk.a.a.c.Hx().HA();
            KsInterstitialAd.AdInteractionListener adInteractionListener = this.lk;
            if (adInteractionListener != null) {
                adInteractionListener.onPageDismiss();
            }
            com.kwad.components.ad.interstitial.h.a aVar = this.lg;
            if ((aVar instanceof com.kwad.components.ad.interstitial.h.c) && !((com.kwad.components.ad.interstitial.h.c) aVar).fi() && com.kwad.sdk.core.response.helper.a.cZ(com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate))) {
                com.kwad.sdk.core.adlog.c.p(this.mAdTemplate, (int) Math.ceil(getTimerHelper().getTime() / 1000.0f));
            }
            h.pA();
            com.kwad.components.core.g.a.a(com.kwad.sdk.commercial.e.bw(this.mAdTemplate));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    @Override // android.app.Dialog
    public final void onBackPressed() {
        if (com.kwad.components.ad.interstitial.b.b.dQ()) {
            super.onBackPressed();
        }
    }
}
