package com.kwad.components.ad.reward.presenter.a;

import com.kwad.components.ad.reward.k.q;
import com.kwad.components.ad.reward.presenter.f.g;
import com.kwad.components.core.video.m;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.i;
import com.kwad.components.core.webview.tachikoma.j;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.helper.b;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.bt;
import com.kwad.sdk.utils.cb;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends g implements j {
    private i gg;
    private AdInfo mAdInfo;
    private long xS;
    private long xT;
    private boolean xU;
    private boolean xV;
    private com.kwad.components.ad.reward.g.b xW = new com.kwad.components.ad.reward.g.b() { // from class: com.kwad.components.ad.reward.presenter.a.a.1
        @Override // com.kwad.components.ad.reward.g.b
        public final boolean interceptPlayCardResume() {
            return a.this.AS != null && a.this.AS.getVisibility() == 0;
        }
    };
    private final m jX = new m() { // from class: com.kwad.components.ad.reward.presenter.a.a.2
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            long jH = com.kwad.components.ad.reward.g.h(a.this.mAdInfo);
            if (j2 <= a.this.xS || jH - j2 <= a.this.xT || a.this.xU) {
                return;
            }
            a.a(a.this, true);
            a.this.gg.a(a.this.ub.getActivity(), a.this.ub.mAdResultData, a.this);
        }
    };

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(o oVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(p pVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(n nVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(u uVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void aC() {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_reward_interact_card";
    }

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.xU = true;
        return true;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.gg == null) {
            this.gg = ji();
        }
        AdInfo adInfoEM = e.eM(this.ub.mAdTemplate);
        this.mAdInfo = adInfoEM;
        this.xS = ((long) com.kwad.sdk.core.response.helper.a.aP(adInfoEM)) * 1000;
        this.xT = ((long) com.kwad.sdk.core.response.helper.a.aQ(this.mAdInfo)) * 1000;
        this.ub.sr.a(this.jX);
        this.ub.a(this.xW);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sr.b(this.jX);
        this.ub.b(this.xW);
        this.gg.kT();
        this.gg = null;
        this.AS.setVisibility(8);
        this.xU = false;
        this.xV = false;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return b.eo(this.ub.mAdTemplate);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final com.kwad.sdk.widget.g getTouchCoordsView() {
        return this.ub.mRootContainer;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.g
    public final int jh() {
        return R.id.ksad_js_interact;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        c.d("TkRewardInteractPresenter", "onTkLoadFailed: ");
        this.AS.setVisibility(8);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        c.d("TkRewardInteractPresenter", "onTkLoadSuccess: ");
        getContext();
        if (as.VV()) {
            this.AS.setVisibility(0);
            com.kwad.components.ad.reward.d.a.S(this.ub.mContext);
            this.ub.sr.pause();
            this.xV = true;
        }
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        tVar.c(new q(bVar, this.ub.mApkDownloadHelper, this.ub, -1L, new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.reward.presenter.a.a.3
            @Override // com.kwad.sdk.core.webview.d.a.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                if (a.this.ub.sq != null) {
                    a.this.ub.sq.cY();
                }
            }
        }, null));
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        aVar.width = (int) ((bt.getScreenWidth(getContext()) / fBA) + 0.5f);
        aVar.height = (int) ((bt.getScreenHeight(getContext()) / fBA) + 0.5f);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(WebCloseStatus webCloseStatus) {
        this.ub.sJ = webCloseStatus != null && webCloseStatus.interactSuccess;
        if (this.ub.sJ) {
            this.ub.sr.ln();
        }
        if (this.xV && cb.r(this.AS, 30)) {
            this.ub.sr.resume();
        }
        this.AS.setVisibility(8);
    }

    private i ji() {
        return new i(-1L, getContext());
    }
}
