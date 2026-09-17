package com.kwad.components.ad.fullscreen.c;

import android.os.SystemClock;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import com.kwad.components.ad.reward.RewardRenderResult;
import com.kwad.components.ad.reward.e.g;
import com.kwad.components.ad.reward.page.BackPressHandleResult;
import com.kwad.components.ad.reward.presenter.d;
import com.kwad.components.ad.reward.presenter.j;
import com.kwad.components.ad.reward.presenter.k;
import com.kwad.components.ad.reward.presenter.l;
import com.kwad.components.ad.reward.presenter.m;
import com.kwad.components.ad.reward.presenter.r;
import com.kwad.components.ad.reward.presenter.v;
import com.kwad.components.core.e.e.f;
import com.kwad.components.core.innerEc.a.h;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.sdk.R;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.as;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.reward.presenter.b implements g, f, com.kwad.components.core.innerEc.a.g {
    private com.kwad.components.ad.fullscreen.b ka;
    private com.kwad.components.core.n.b kb;
    private r kc;
    private FrameLayout kd;
    private com.kwad.components.ad.reward.presenter.f.b ke;
    private com.kwad.components.core.webview.tachikoma.f.g kf;
    private com.kwad.components.ad.reward.presenter.e.a kg;
    private com.kwad.components.ad.reward.presenter.f.f kh;
    private boolean ki = false;
    private ViewGroup mRootContainer;

    @Override // com.kwad.components.ad.reward.e.g
    public final int getPriority() {
        return 0;
    }

    public b(com.kwad.components.core.n.b bVar, ViewGroup viewGroup, com.kwad.components.ad.fullscreen.b bVar2, com.kwad.components.ad.reward.g gVar) {
        this.kb = bVar;
        this.ka = bVar2;
        this.mRootContainer = viewGroup;
        this.ub = gVar;
        dd();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.kd = (FrameLayout) this.mRootContainer.findViewById(R.id.ksad_reward_play_layout);
    }

    private static boolean a(com.kwad.components.ad.reward.g gVar) {
        if (!e.JX()) {
            com.kwad.components.ad.reward.monitor.c.a(gVar.mAdTemplate, TKRenderFailReason.SWITCH_CLOSE);
            return false;
        }
        if (com.kwad.sdk.core.response.helper.a.bj(com.kwad.sdk.core.response.helper.e.eM(gVar.mAdTemplate))) {
            return false;
        }
        AdMatrixInfo.FullScreenInfo fullScreenInfoDQ = com.kwad.sdk.core.response.helper.b.dQ(gVar.mAdTemplate);
        if (fullScreenInfoDQ != null && fullScreenInfoDQ.renderType == 1) {
            return true;
        }
        com.kwad.components.ad.reward.monitor.c.a(gVar.mAdTemplate, TKRenderFailReason.TK_FILE_LOAD_ERROR);
        return false;
    }

    private void dd() {
        if (this.ka == null) {
            return;
        }
        di();
        AdInfo adInfoCW = this.ka.cW();
        boolean zDj = com.kwad.sdk.core.response.helper.a.dj(adInfoCW);
        boolean zEM = com.kwad.sdk.core.response.helper.b.eM(adInfoCW);
        if (zDj) {
            this.ub.a(RewardRenderResult.LIVE_TK);
            com.kwad.components.core.webview.tachikoma.e.c.zS().a(dj());
            df();
        } else if (zEM) {
            com.kwad.components.core.webview.tachikoma.e.c.zS().a(dj());
            this.ub.a(RewardRenderResult.TK_IMAGE);
            dg();
        } else if (a(this.ub)) {
            this.ub.a(RewardRenderResult.FULLSCREEN_TK);
            dh();
            com.kwad.components.core.webview.tachikoma.e.c.zS().a(dj());
        } else {
            this.ub.a(RewardRenderResult.DEFAULT);
            de();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void de() {
        com.kwad.components.core.webview.tachikoma.e.c.zS().b(this.kf);
        com.kwad.components.core.e.e.g.qJ().a(this);
        h.rw().a(this);
        AdTemplate adTemplate = this.ka.getAdTemplate();
        AdInfo adInfoCW = this.ka.cW();
        boolean z = this.ka.cX() && !as.isOrientationPortrait();
        if (this.ka.jE) {
            a(this);
        }
        a(new v(), true);
        if (com.kwad.sdk.core.response.helper.a.aV(adInfoCW)) {
            a(new d(), true);
        }
        a(new m(), true);
        a(new com.kwad.components.ad.reward.presenter.platdetail.c(), true);
        if (com.kwad.sdk.core.response.helper.b.dN(adInfoCW)) {
            a(new com.kwad.components.ad.reward.presenter.f.h(), true);
        }
        if (!z) {
            a(new com.kwad.components.ad.reward.presenter.platdetail.actionbar.c(), true);
        }
        a(new com.kwad.components.ad.reward.presenter.c.a(), true);
        if (com.kwad.sdk.core.response.helper.b.dV(adTemplate)) {
            a(new com.kwad.components.ad.fullscreen.c.a.f(), true);
        }
        if (com.kwad.sdk.core.response.helper.a.bj(adInfoCW)) {
            a(new com.kwad.components.ad.reward.presenter.platdetail.b(), true);
        }
        a(new l(), true);
        if (com.kwad.sdk.core.response.helper.a.cY(adInfoCW)) {
            a(new com.kwad.components.ad.reward.presenter.b.c(), true);
            a(new com.kwad.components.ad.reward.presenter.b.b(), true);
            a(new k(), true);
            a(new com.kwad.components.ad.reward.presenter.b.a(), true);
        }
        r rVar = new r(adTemplate, false, false);
        this.kc = rVar;
        a((Presenter) rVar, true);
        a(new c(), true);
        a(new a(), true);
        a(new com.kwad.components.ad.reward.presenter.d.b(adTemplate, false), true);
        a(new com.kwad.components.ad.reward.presenter.e(adInfoCW, this.mRootContainer), true);
        a(new j(), true);
        try {
            if (this.ub.mStartRenderTime > 0) {
                com.kwad.sdk.commercial.convert.d.b(com.kwad.sdk.core.response.helper.e.eG(this.ub.mAdTemplate), 1, SystemClock.elapsedRealtime() - this.ub.mStartRenderTime);
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private void df() {
        com.kwad.components.ad.fullscreen.c.c.c cVar = new com.kwad.components.ad.fullscreen.c.c.c();
        this.ke = cVar;
        a(cVar);
    }

    private void dg() {
        com.kwad.components.ad.fullscreen.c.c.a aVar = new com.kwad.components.ad.fullscreen.c.c.a();
        this.kh = aVar;
        a(aVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(b bVar) {
        if (this.ki) {
            return;
        }
        bVar.a((Presenter) new com.kwad.components.ad.reward.presenter.a(this.ub), true);
        this.ki = true;
    }

    private void dh() {
        a((Presenter) new com.kwad.components.ad.fullscreen.c.c.b(), true);
    }

    private void di() {
        AdInfo adInfoCW = this.ka.cW();
        if (!this.ka.jE) {
            a(this);
        }
        if (com.kwad.sdk.core.response.helper.b.eJ(adInfoCW) && as.isOrientationPortrait()) {
            com.kwad.components.ad.reward.presenter.e.a aVar = new com.kwad.components.ad.reward.presenter.e.a();
            this.kg = aVar;
            a((Presenter) aVar, true);
        }
    }

    private com.kwad.components.core.webview.tachikoma.f.g dj() {
        if (this.kf == null) {
            this.kf = new com.kwad.components.core.webview.tachikoma.f.g() { // from class: com.kwad.components.ad.fullscreen.c.b.1
                @Override // com.kwad.components.core.webview.tachikoma.f.g
                public final void a(String str, long j, long j2, long j3) {
                    try {
                        if (b.this.ub.mStartRenderTime > 0) {
                            com.kwad.sdk.commercial.convert.d.b(com.kwad.sdk.core.response.helper.e.eG(b.this.ub.mAdTemplate), 2, SystemClock.elapsedRealtime() - b.this.ub.mStartRenderTime);
                        }
                    } catch (Throwable th) {
                        ServiceProvider.reportSdkCaughtException(th);
                    }
                    b.this.ub.mS = true;
                }

                @Override // com.kwad.components.core.webview.tachikoma.f.b
                public final void v(String str) {
                    if ("tk_fullscreen".equals(str) || "tk_live_video".equals(str)) {
                        b bVar = b.this;
                        bVar.a(bVar);
                        com.kwad.components.ad.reward.g.a(b.this.getContext(), b.this.ub, b.this.dk());
                        b.this.de();
                        return;
                    }
                    if ("tk_image_video".equals(str)) {
                        b bVar2 = b.this;
                        bVar2.a(bVar2);
                        b.this.ub.a(RewardRenderResult.DEFAULT);
                        b.this.de();
                    }
                }
            };
        }
        return this.kf;
    }

    public final boolean onBackPressed() {
        r rVar = this.kc;
        if (rVar != null && rVar.onBackPressed()) {
            return true;
        }
        com.kwad.components.ad.reward.presenter.e.a aVar = this.kg;
        if (aVar != null && aVar.hH() == BackPressHandleResult.HANDLED) {
            return true;
        }
        com.kwad.components.ad.reward.presenter.f.b bVar = this.ke;
        return bVar != null && bVar.hH() == BackPressHandleResult.HANDLED;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public FrameLayout dk() {
        if (this.kd == null) {
            this.kd = (FrameLayout) this.mRootContainer.findViewById(R.id.ksad_reward_play_layout);
        }
        return this.kd;
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ub.b(this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.c(this);
        com.kwad.components.core.e.e.g.qJ().b(this);
        h.rw().b(this);
        com.kwad.components.core.webview.tachikoma.e.c.zS().b(this.kf);
    }

    @Override // com.kwad.components.ad.reward.e.g
    public final void cZ() {
        this.ub.D(true);
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // java.lang.Comparable
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public int compareTo(g gVar) {
        return getPriority() - gVar.getPriority();
    }

    @Override // com.kwad.components.core.e.e.f
    public final void show() {
        this.ub.gO();
        this.ub.E(true);
    }

    @Override // com.kwad.components.core.e.e.f
    public final void dismiss() {
        this.ub.E(false);
        this.ub.gN();
    }

    @Override // com.kwad.components.core.innerEc.a.g
    public final void dl() {
        this.ub.gO();
        this.ub.E(true);
    }

    @Override // com.kwad.components.core.innerEc.a.g
    public final void dm() {
        this.ub.E(false);
        this.ub.gN();
    }
}
