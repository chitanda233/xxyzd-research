package com.kwad.components.ad.interstitial.f;

import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends b implements com.kwad.components.core.video.a.c {
    private static long nx = 1000;
    private AdTemplate mAdTemplate;
    private c mF;
    private a ny;
    private int nz;

    @Override // com.kwad.components.core.video.a.c
    public final void as() {
    }

    @Override // com.kwad.components.core.video.a.c
    public final void onVideoPlayStart() {
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.ad.interstitial.f.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.sdk.core.d.c.d("InterstitialPlayablePresenter", this + " onBind");
        c cVar = (c) SK();
        this.mF = cVar;
        AdTemplate adTemplate = cVar.mAdTemplate;
        this.mAdTemplate = adTemplate;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        long j = adInfoEM.adInsertScreenInfo.autoCloseTime;
        if (j > 0) {
            this.nz = (int) Math.min(com.kwad.components.ad.interstitial.b.b.b(adInfoEM), j);
        } else {
            this.nz = com.kwad.components.ad.interstitial.b.b.b(adInfoEM);
        }
        if (this.mF.mG != null) {
            this.mF.mG.b(true, this.nz);
        }
        if (com.kwad.sdk.core.response.helper.a.bi(adInfoEM)) {
            this.ny = null;
            this.mF.a(this);
        } else {
            a aVar = new a(this, (byte) 0);
            this.ny = aVar;
            by.a(aVar, null, 1000L);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.sdk.core.d.c.d("InterstitialPlayablePresenter", this + " onUnbind");
        this.mF.b(this);
        a aVar = this.ny;
        if (aVar != null) {
            aVar.r(true);
            by.b(this.ny);
            this.ny = null;
        }
    }

    @Override // com.kwad.components.ad.interstitial.f.b
    public final void dW() {
        super.dW();
        a aVar = this.ny;
        if (aVar != null) {
            aVar.s(false);
        }
    }

    @Override // com.kwad.components.ad.interstitial.f.b
    public final void dX() {
        super.dX();
        a aVar = this.ny;
        if (aVar != null) {
            aVar.s(true);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void P(int i) {
        if (this.mF.mG == null) {
            return;
        }
        if (i == 0) {
            if (this.mF.ea()) {
                return;
            }
            this.mF.c(getContext(), this.mAdTemplate);
            eA();
            c cVar = this.mF;
            cVar.a(true, -1, cVar.cB);
            return;
        }
        this.mF.mG.b(true, i);
    }

    private void eA() {
        if (this.mF.cB != null) {
            this.mF.cB.release();
        }
        this.mF.lp.dismiss();
        this.mF.ac();
    }

    @Override // com.kwad.components.core.video.a.c
    public final void d(long j) {
        P(this.nz - ((int) (j / 1000)));
    }

    @Override // com.kwad.components.core.video.a.c
    public final void at() {
        if (this.mF.ea()) {
            return;
        }
        this.mF.c(getContext(), this.mAdTemplate);
        eA();
    }

    class a implements Runnable {
        private int nA;
        private boolean nB;
        private boolean nC;

        private a() {
            this.nA = Integer.MIN_VALUE;
            this.nB = false;
            this.nC = false;
        }

        /* synthetic */ a(e eVar, byte b) {
            this();
        }

        public final void r(boolean z) {
            this.nC = true;
        }

        @Override // java.lang.Runnable
        public final void run() {
            if (this.nC) {
                return;
            }
            if (this.nB) {
                by.a(this, null, e.nx);
                return;
            }
            if (this.nA == Integer.MIN_VALUE) {
                this.nA = e.this.nz;
            }
            if (this.nA < 0) {
                return;
            }
            com.kwad.sdk.core.d.c.d("InterstitialPlayablePresenter", e.this.toString() + ", this: " + toString() + " PlayableTimerRunnable run : " + this.nA);
            e.this.P(this.nA);
            this.nA--;
            by.a(this, null, e.nx);
        }

        public final void s(boolean z) {
            this.nB = z;
        }
    }
}
