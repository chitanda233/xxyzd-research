package com.kwad.components.ad.reward.presenter;

import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class r extends b implements com.kwad.components.ad.reward.e.g, com.kwad.components.ad.reward.e.j, as.b {
    private com.kwad.components.core.webview.tachikoma.f.g kf;
    private float wO;
    private boolean xd;
    private a xe;
    private q xf;
    private o xg;
    private p xh;
    private int xi;
    private boolean xj;
    private boolean xk;
    private boolean xl;

    @Override // com.kwad.components.ad.reward.e.j
    public final void dp() {
    }

    @Override // com.kwad.components.ad.reward.e.g
    public final int getPriority() {
        return 0;
    }

    public r(AdTemplate adTemplate, boolean z, boolean z2) {
        this.xi = 0;
        this.xj = false;
        this.xk = z;
        this.xl = z2;
        if (com.kwad.sdk.core.response.helper.a.bQ(com.kwad.sdk.core.response.helper.e.eM(adTemplate))) {
            p pVar = new p();
            this.xh = pVar;
            a(pVar);
        }
    }

    public r(AdTemplate adTemplate) {
        this(adTemplate, true, true);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate);
        if (com.kwad.sdk.core.response.helper.a.bQ(adInfoEM)) {
            if (!this.ub.sH) {
                by.runOnUiThreadDelay(new bi() { // from class: com.kwad.components.ad.reward.presenter.r.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        r.this.iZ();
                    }
                }, 100L);
            } else {
                com.kwad.components.core.webview.tachikoma.e.c.zS().a(dj());
            }
        } else if (!com.kwad.sdk.core.response.helper.a.bU(adInfoEM)) {
            com.kwad.components.core.p.a.vX().ba(this.ub.mAdTemplate);
        }
        this.ub.b(this);
        if (this.ub.ss != null) {
            this.ub.ss.a(this);
        }
        boolean zHQ = com.kwad.components.ad.reward.a.b.hQ();
        this.wO = com.kwad.components.ad.reward.a.b.hP();
        if (zHQ) {
            this.xe = new a(this, (byte) 0);
            if (this.ub.sr != null) {
                this.ub.sr.a(this.xe);
            }
        }
        com.kwad.components.ad.reward.a.gq().a(this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.c(this);
        if (this.ub.ss != null) {
            this.ub.ss.b(this);
        }
        if (this.xe != null && this.ub.sr != null) {
            this.ub.sr.b(this.xe);
        }
        com.kwad.components.ad.reward.a.gq().b(this);
        com.kwad.components.core.webview.tachikoma.e.c.zS().b(this.kf);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void iZ() {
        if (this.xl) {
            q qVar = new q(this);
            this.xf = qVar;
            a((Presenter) qVar, true);
        }
        if (this.xk) {
            o oVar = new o(this);
            this.xg = oVar;
            a((Presenter) oVar, true);
        }
    }

    public final boolean onBackPressed() {
        boolean zHe = this.ub.he();
        if (!this.ub.gQ() || zHe) {
            return false;
        }
        com.kwad.components.ad.reward.a.gq().gr();
        this.ub.A(false);
        return true;
    }

    @Override // com.kwad.components.core.webview.jshandler.as.b
    public final void a(as.a aVar) {
        a aVar2;
        boolean zIsSuccess = aVar.isSuccess();
        this.xd = zIsSuccess;
        if (!zIsSuccess || (aVar2 = this.xe) == null) {
            return;
        }
        b(aVar2.videoDuration, this.xe.xn, false);
    }

    private com.kwad.components.core.webview.tachikoma.f.g dj() {
        if (this.kf == null) {
            this.kf = new com.kwad.components.core.webview.tachikoma.f.g() { // from class: com.kwad.components.ad.reward.presenter.r.2
                @Override // com.kwad.components.core.webview.tachikoma.f.b
                public final void v(String str) {
                    r.this.iZ();
                }
            };
        }
        return this.kf;
    }

    private boolean ja() {
        return this.xd;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void b(long j, long j2, boolean z) {
        q qVar;
        if (ja() && j2 >= ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT && ((float) j2) >= ((float) j) * this.wO) {
            if (com.kwad.components.ad.reward.a.b.hR()) {
                if (this.xj || (qVar = this.xf) == null) {
                    return;
                }
                qVar.iV();
                this.xi = 1;
                this.xj = true;
                return;
            }
            o oVar = this.xg;
            if (oVar != null) {
                oVar.J(!z);
                this.xi = 2;
            }
        }
    }

    @Override // com.kwad.components.ad.reward.e.g
    public final void cZ() {
        RewardActionBarControl.ShowActionBarResult showActionBarResultJB = this.ub.st.jB();
        if (showActionBarResultJB != null) {
            showActionBarResultJB.equals(RewardActionBarControl.ShowActionBarResult.SHOW_NATIVE_PLAYABLE_PORTRAIT);
        }
        if (this.xh == null || this.ub.ha()) {
            return;
        }
        if (ja()) {
            this.xh.e(PlayableSource.PLAY_FINISHED_NORMAL);
        } else {
            this.xh.iU();
        }
    }

    @Override // com.kwad.components.ad.reward.e.j
    public final void a(PlayableSource playableSource, com.kwad.components.ad.reward.e.n nVar) {
        o oVar;
        q qVar;
        this.ub.A(true);
        int i = this.xi;
        if (i == 1 && (qVar = this.xf) != null) {
            qVar.iW();
        } else {
            if (i != 2 || (oVar = this.xg) == null) {
                return;
            }
            oVar.hide();
        }
    }

    @Override // com.kwad.components.ad.reward.e.j
    /* JADX INFO: renamed from: do */
    public final void mo174do() {
        this.ub.A(false);
        a aVar = this.xe;
        if (aVar == null || this.xi != 2) {
            return;
        }
        b(aVar.videoDuration, this.xe.xn, true);
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // java.lang.Comparable
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public int compareTo(com.kwad.components.ad.reward.e.g gVar) {
        return getPriority() - gVar.getPriority();
    }

    class a extends com.kwad.components.core.video.m {
        private long videoDuration;
        private long xn;

        private a() {
        }

        /* synthetic */ a(r rVar, byte b) {
            this();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            this.xn = j2;
            this.videoDuration = j;
            if (r.this.ub.gQ()) {
                return;
            }
            r.this.b(j, j2, false);
        }
    }
}
