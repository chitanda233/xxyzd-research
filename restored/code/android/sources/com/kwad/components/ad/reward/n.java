package com.kwad.components.ad.reward;

import android.content.Context;
import android.os.SystemClock;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import com.kwad.components.ad.reward.page.BackPressHandleResult;
import com.kwad.components.ad.reward.presenter.r;
import com.kwad.components.ad.reward.presenter.t;
import com.kwad.components.ad.reward.presenter.u;
import com.kwad.components.ad.reward.presenter.v;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdGlobalConfigInfo;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.as;

/* JADX INFO: loaded from: classes3.dex */
public final class n extends com.kwad.components.ad.reward.presenter.b implements com.kwad.components.ad.reward.e.g, com.kwad.components.core.e.e.f, com.kwad.components.core.innerEc.a.g {
    private com.kwad.components.core.n.b kb;
    private r kc;
    private FrameLayout kd;
    private com.kwad.components.ad.reward.presenter.f.b ke;
    private com.kwad.components.ad.reward.presenter.e.a kg;
    private com.kwad.components.ad.reward.presenter.f.f kh;
    private Context mContext;
    private com.kwad.components.ad.reward.model.c mModel;
    private ViewGroup mRootContainer;
    private g ub;
    private a uc;
    private boolean ki = false;
    private com.kwad.components.core.webview.tachikoma.f.g mM = new com.kwad.components.core.webview.tachikoma.f.g() { // from class: com.kwad.components.ad.reward.n.1
        @Override // com.kwad.components.core.webview.tachikoma.f.g
        public final void a(String str, long j, long j2, long j3) {
            try {
                if (n.this.ub.mStartRenderTime > 0) {
                    com.kwad.sdk.commercial.convert.d.b(com.kwad.sdk.core.response.helper.e.eG(n.this.ub.mAdTemplate), 2, SystemClock.elapsedRealtime() - n.this.ub.mStartRenderTime);
                }
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
            n.this.ub.mS = true;
        }

        @Override // com.kwad.components.core.webview.tachikoma.f.b
        public final void v(String str) {
            if ("tk_reward".equals(str) || "tk_live_video".equals(str)) {
                n nVar = n.this;
                nVar.a(nVar);
                g.a(n.this.getContext(), n.this.ub, n.this.dk());
                n.this.ub.a(RewardRenderResult.DEFAULT);
                n nVar2 = n.this;
                nVar2.a(nVar2.kb, n.this.mModel);
                return;
            }
            if ("tk_image_video".equals(str)) {
                n nVar3 = n.this;
                nVar3.a(nVar3);
                n.this.ub.a(RewardRenderResult.DEFAULT);
                n nVar4 = n.this;
                nVar4.a(nVar4.kb, n.this.mModel);
            }
        }
    };

    public interface a {
        void onUnbind();
    }

    @Override // com.kwad.components.ad.reward.e.g
    public final int getPriority() {
        return 0;
    }

    public n(com.kwad.components.core.n.b bVar, Context context, ViewGroup viewGroup, com.kwad.components.ad.reward.model.c cVar, g gVar) {
        boolean z = false;
        this.mContext = context;
        this.mRootContainer = viewGroup;
        this.mModel = cVar;
        this.ub = gVar;
        this.kb = bVar;
        a(cVar);
        AdInfo adInfoCW = cVar.cW();
        boolean zEM = com.kwad.sdk.core.response.helper.b.eM(adInfoCW);
        boolean z2 = (com.kwad.sdk.core.response.helper.a.cY(adInfoCW) && a(this.ub.mAdResultData.adGlobalConfigInfo)) || com.kwad.sdk.core.response.helper.a.bj(adInfoCW) || g.P(cVar.getAdTemplate());
        if (com.kwad.sdk.core.response.helper.a.dj(adInfoCW) && a(this.ub.mAdResultData.adGlobalConfigInfo)) {
            z = true;
        }
        com.kwad.sdk.core.d.c.d("RewardPresenter", "notFullTk: " + z2 + ", mLoadStrategy: " + this.ub.tl);
        if (z) {
            com.kwad.components.core.webview.tachikoma.e.c.zS().a(this.mM);
            gVar.a(RewardRenderResult.LIVE_TK);
            df();
        } else if (zEM) {
            com.kwad.components.core.webview.tachikoma.e.c.zS().a(this.mM);
            gVar.a(RewardRenderResult.TK_IMAGE);
            dg();
        } else if (!z2 && this.ub.tl.equals(LoadStrategy.FULL_TK)) {
            com.kwad.components.core.webview.tachikoma.e.c.zS().a(this.mM);
            gVar.a(RewardRenderResult.NEO_TK);
            hG();
        } else {
            gVar.a(RewardRenderResult.DEFAULT);
            a(bVar, cVar);
        }
    }

    private static boolean a(AdGlobalConfigInfo adGlobalConfigInfo) {
        return adGlobalConfigInfo == null || adGlobalConfigInfo.neoPageType != 1;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.kd = (FrameLayout) this.mRootContainer.findViewById(R.id.ksad_reward_play_layout);
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
        com.kwad.components.ad.reward.c.a.m175if().setCallerContext(this.ub);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.c(this);
        a aVar = this.uc;
        if (aVar != null) {
            aVar.onUnbind();
        }
        com.kwad.components.core.e.e.g.qJ().b(this);
        com.kwad.components.core.innerEc.a.h.rw().b(this);
        com.kwad.components.ad.reward.c.a.m175if().reset();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        this.kb = null;
        com.kwad.components.core.webview.tachikoma.e.c.zS().b(this.mM);
    }

    private void hG() {
        com.kwad.components.ad.reward.presenter.f.f fVar = new com.kwad.components.ad.reward.presenter.f.f();
        this.kh = fVar;
        a(fVar);
    }

    private void dg() {
        com.kwad.components.ad.reward.presenter.f.c cVar = new com.kwad.components.ad.reward.presenter.f.c();
        this.kh = cVar;
        a(cVar);
    }

    private void df() {
        com.kwad.components.ad.reward.presenter.f.b bVar = new com.kwad.components.ad.reward.presenter.f.b();
        this.ke = bVar;
        a(bVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(n nVar) {
        if (this.ki) {
            return;
        }
        nVar.a((Presenter) new com.kwad.components.ad.reward.presenter.a(this.ub), true);
        this.ki = true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(com.kwad.components.core.n.b bVar, com.kwad.components.ad.reward.model.c cVar) {
        if (this.mModel == null) {
            return;
        }
        com.kwad.components.core.e.e.g.qJ().a(this);
        com.kwad.components.core.innerEc.a.h.rw().a(this);
        AdInfo adInfoCW = this.mModel.cW();
        AdTemplate adTemplate = this.mModel.getAdTemplate();
        if (cVar.jE) {
            a(this);
        }
        a(new v(), true);
        if (com.kwad.sdk.core.response.helper.a.aV(adInfoCW)) {
            a(new com.kwad.components.ad.reward.presenter.d(), true);
        }
        a(new com.kwad.components.ad.reward.presenter.m(), true);
        a(new com.kwad.components.ad.reward.presenter.h(), true);
        a(new com.kwad.components.ad.reward.presenter.platdetail.c(), true);
        a(new com.kwad.components.ad.reward.presenter.platdetail.a.e(), true);
        boolean zIC = cVar.iC();
        boolean zIE = cVar.iE();
        boolean z = cVar.cX() && !as.isOrientationPortrait();
        if (!zIC && !zIE && !z) {
            a(new com.kwad.components.ad.reward.presenter.platdetail.actionbar.c(), true);
        }
        a(new com.kwad.components.ad.reward.presenter.n(), true);
        a(new com.kwad.components.ad.reward.presenter.c(adInfoCW), true);
        a(new com.kwad.components.ad.reward.presenter.d.b(adTemplate, true), true);
        a(new com.kwad.components.ad.reward.presenter.c.a(), true);
        a(new u(), true);
        a(new com.kwad.components.ad.reward.presenter.e(adInfoCW, this.mRootContainer), true);
        r rVar = new r(adTemplate);
        this.kc = rVar;
        a((Presenter) rVar, true);
        a(new com.kwad.components.ad.reward.presenter.l(), true);
        if (this.ub.sG && com.kwad.components.ad.reward.d.a.b(this.ub.mContext, com.kwad.sdk.core.response.helper.e.eM(adTemplate))) {
            a(new com.kwad.components.ad.reward.presenter.a.a(), true);
        }
        if (com.kwad.sdk.core.response.helper.b.dW(adTemplate)) {
            a(new t(), true);
        }
        if (com.kwad.sdk.core.response.helper.a.bj(adInfoCW)) {
            a(new com.kwad.components.ad.reward.presenter.platdetail.b(), true);
        }
        if (com.kwad.sdk.core.response.helper.a.cY(adInfoCW)) {
            a(new com.kwad.components.ad.reward.presenter.b.c(), true);
            a(new com.kwad.components.ad.reward.presenter.b.a(), true);
            a(new com.kwad.components.ad.reward.presenter.b.b(), true);
            a(new com.kwad.components.ad.reward.presenter.k(), true);
        }
        a(new com.kwad.components.ad.reward.presenter.j(), true);
        try {
            if (this.ub.mStartRenderTime > 0) {
                com.kwad.sdk.commercial.convert.d.b(com.kwad.sdk.core.response.helper.e.eG(this.ub.mAdTemplate), 1, SystemClock.elapsedRealtime() - this.ub.mStartRenderTime);
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private void a(com.kwad.components.ad.reward.model.c cVar) {
        AdInfo adInfoCW = cVar.cW();
        if (!cVar.jE) {
            a(this);
        }
        if (g.g(adInfoCW)) {
            a(new com.kwad.components.ad.reward.presenter.g());
        }
        if (com.kwad.sdk.core.response.helper.a.aU(adInfoCW) && as.VV()) {
            a(new com.kwad.components.ad.reward.presenter.h.a());
        }
        if (com.kwad.sdk.core.response.helper.b.dN(adInfoCW)) {
            a(new com.kwad.components.ad.reward.presenter.f.h());
        }
        if (com.kwad.sdk.core.response.helper.b.eJ(adInfoCW) && as.isOrientationPortrait()) {
            com.kwad.components.ad.reward.presenter.e.a aVar = new com.kwad.components.ad.reward.presenter.e.a();
            this.kg = aVar;
            a(aVar);
        }
    }

    public final void a(a aVar) {
        this.uc = aVar;
    }

    public final BackPressHandleResult hH() {
        r rVar = this.kc;
        if (rVar != null && rVar.onBackPressed()) {
            return BackPressHandleResult.HANDLED;
        }
        com.kwad.components.ad.reward.presenter.e.a aVar = this.kg;
        if (aVar != null && aVar.hH() == BackPressHandleResult.HANDLED) {
            return BackPressHandleResult.HANDLED;
        }
        com.kwad.components.ad.reward.presenter.f.b bVar = this.ke;
        if (bVar != null) {
            return bVar.hH();
        }
        com.kwad.components.ad.reward.presenter.f.f fVar = this.kh;
        if (fVar != null) {
            return fVar.hH();
        }
        return BackPressHandleResult.NOT_HANDLED;
    }

    @Override // com.kwad.components.ad.reward.e.g
    public final void cZ() {
        this.ub.D(true);
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // java.lang.Comparable
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public int compareTo(com.kwad.components.ad.reward.e.g gVar) {
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
