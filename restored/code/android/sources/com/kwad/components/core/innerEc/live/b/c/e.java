package com.kwad.components.core.innerEc.live.b.c;

import android.content.Intent;
import android.widget.FrameLayout;
import com.kwad.components.core.innerEc.live.a.k;
import com.kwad.components.core.innerEc.live.a.l;
import com.kwad.components.core.innerEc.live.a.m;
import com.kwad.components.core.innerEc.live.a.n;
import com.kwad.components.core.innerEc.live.a.o;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PbSCActivityLiveInfo;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PbSCFeedPush;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PbSCShopEntranceControl;
import com.kwad.components.offline.api.core.adInnerEc.longconnection.listener.SCMessageListener;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.LiveDetailReward;
import com.kwad.sdk.core.response.model.LiveInfo;
import com.kwad.sdk.utils.af;
import java.util.Iterator;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends com.kwad.components.core.innerEc.live.b.a.a implements com.kwad.components.core.innerEc.live.base.f, com.kwad.components.core.webview.tachikoma.j {
    private LiveInfo TM;
    private com.kwad.components.core.webview.tachikoma.i VO;
    private com.kwad.components.core.innerEc.live.a.c VP;
    private com.kwad.components.core.innerEc.live.a.i VQ;
    private com.kwad.components.core.innerEc.live.a.g VR;
    private com.kwad.components.core.innerEc.live.a.f VS;
    private com.kwad.components.core.innerEc.live.a.h VT;
    private l VU;
    private com.kwad.components.core.innerEc.live.base.d VV;
    private com.kwad.components.core.innerEc.live.base.c VW;
    private com.kwad.components.core.innerEc.live.base.e VX;
    private com.kwad.components.core.innerEc.live.f.a VY;
    private com.kwad.components.core.innerEc.live.a.d VZ;
    private com.kwad.components.core.innerEc.live.config.b Vd;
    private com.kwad.components.core.innerEc.live.a.b Wa;
    private n Wb;
    private k Wc;
    private com.kwad.components.core.innerEc.live.a.a Wd;
    private o We;
    private m Wf;
    private com.kwad.components.core.innerEc.live.g.d Wk;
    private az di;
    private FrameLayout dz;
    private AdInfo mAdInfo;
    private boolean Ky = false;
    private final com.kwad.components.core.innerEc.live.base.a UI = new com.kwad.components.core.innerEc.live.base.a() { // from class: com.kwad.components.core.innerEc.live.b.c.e.1
        @Override // com.kwad.components.core.innerEc.live.base.a
        public final void c(float f, float f2) {
            if (e.this.Wf != null) {
                e.this.Wf.a(m.a(e.this.getContext(), f, f2));
            }
        }
    };
    private final SCMessageListener Wg = new com.kwad.components.core.innerEc.live.g.c() { // from class: com.kwad.components.core.innerEc.live.b.c.e.3
        /* JADX INFO: Access modifiers changed from: private */
        @Override // com.kwad.components.core.innerEc.live.g.a
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public void g(PbSCFeedPush pbSCFeedPush) {
            if (e.this.VR != null) {
                com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "displayLikeCount:" + pbSCFeedPush.getDisplayLikeCount() + ", displayWatchingCount:" + pbSCFeedPush.getDisplayWatchingCount());
                e.this.VV = new com.kwad.components.core.innerEc.live.base.d();
                e.this.VV.TF = pbSCFeedPush.getDisplayLikeCount();
                e.this.VV.TG = pbSCFeedPush.getDisplayWatchingCount();
                e.this.Uj.TF = pbSCFeedPush.getDisplayLikeCount();
                e.this.Uj.TG = pbSCFeedPush.getDisplayWatchingCount();
                e.this.VR.a(e.this.VV);
            }
        }
    };
    private final com.kwad.components.core.innerEc.live.g.b Wh = new com.kwad.components.core.innerEc.live.g.b() { // from class: com.kwad.components.core.innerEc.live.b.c.e.4
        /* JADX INFO: Access modifiers changed from: private */
        @Override // com.kwad.components.core.innerEc.live.g.a
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public void g(PbSCActivityLiveInfo pbSCActivityLiveInfo) {
            if (e.this.VS != null) {
                e.this.VW = new com.kwad.components.core.innerEc.live.base.c();
                e.this.VW.TD = pbSCActivityLiveInfo.getAccumulatedWatchCount();
                e.this.VW.TE = pbSCActivityLiveInfo.getLiteAccumulatedWatchCount();
                e.this.VS.a(e.this.VW);
            }
        }
    };
    private final com.kwad.components.core.innerEc.live.g.e Wi = new com.kwad.components.core.innerEc.live.g.e() { // from class: com.kwad.components.core.innerEc.live.b.c.e.5
        @Override // com.kwad.components.core.innerEc.live.g.e, com.kwad.components.core.innerEc.live.g.a
        /* JADX INFO: renamed from: a */
        public final void g(PbSCShopEntranceControl pbSCShopEntranceControl) {
            if (e.this.VT != null) {
                e.this.VX = new com.kwad.components.core.innerEc.live.base.e();
                e.this.VX.TI = pbSCShopEntranceControl.getOnSaleCount();
                e.this.VX.TH = pbSCShopEntranceControl.isShowYellowCart();
                e.this.VT.a(e.this.VX);
            }
        }
    };
    private final com.kwad.components.core.innerEc.live.config.a Vg = new com.kwad.components.core.innerEc.live.config.a() { // from class: com.kwad.components.core.innerEc.live.b.c.e.6
        @Override // com.kwad.components.core.innerEc.live.config.a
        public final void a(com.kwad.components.core.innerEc.live.config.net.g gVar) {
            com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "onAfterConfigUpdatedLiveFail call JsHandlerLiveStartPlay");
            if (e.this.VQ != null) {
                e.this.VQ.a(gVar);
            }
        }

        @Override // com.kwad.components.core.innerEc.live.config.a
        public final void b(com.kwad.components.core.innerEc.live.config.net.g gVar) {
            com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "onAfterConfigUpdated call JsHandlerLiveStartPlay");
            if (e.this.VQ != null) {
                e.this.VQ.a(gVar);
            }
        }
    };
    private final com.kwad.components.core.innerEc.live.end.c Wj = new com.kwad.components.core.innerEc.live.end.c() { // from class: com.kwad.components.core.innerEc.live.b.c.e.7
        @Override // com.kwad.components.core.innerEc.live.end.c
        public final void ss() {
            com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "onLiveStop");
            if (e.this.VZ != null) {
                e.this.VZ.a(com.kwad.components.core.innerEc.live.a.d.a.rI().aK(true));
            }
        }
    };
    private final com.kwad.sdk.core.j.c Wl = new com.kwad.sdk.core.j.c() { // from class: com.kwad.components.core.innerEc.live.b.c.e.9
        @Override // com.kwad.sdk.core.j.c
        public final void bv() {
            if (e.this.di != null) {
                e.this.di.yN();
            } else {
                e.a(e.this, true);
            }
        }

        @Override // com.kwad.sdk.core.j.c
        public final void bw() {
            if (e.this.di != null) {
                e.this.di.yO();
            }
        }
    };

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.tachikoma.b.o oVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(p pVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.tachikoma.c.n nVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(u uVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aC() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aD() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getRegisterViewKey() {
        return "";
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_adinnerec_full_live_card";
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final com.kwad.sdk.widget.g getTouchCoordsView() {
        return null;
    }

    static /* synthetic */ boolean a(e eVar, boolean z) {
        eVar.Ky = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        FrameLayout frameLayout = (FrameLayout) findViewById(R.id.ksad_live_ad_container);
        this.dz = frameLayout;
        frameLayout.setVisibility(0);
    }

    private static LiveInfo aH(AdTemplate adTemplate) {
        boolean z = com.kwad.sdk.core.response.helper.e.eG(adTemplate) == 2;
        LiveInfo liveInfo = adTemplate.liveInfo;
        if (z && liveInfo != null) {
            liveInfo.rewardInfo.rewardTimeSecond = adTemplate.mLiveDetailRewardFromAdLive.countDownSecond;
            liveInfo.rewardInfo.rewardVerified = adTemplate.mLiveDetailRewardFromAdLive.success;
            com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "initLiveDetailInfo rewardTimeSecond = " + liveInfo.rewardInfo.rewardTimeSecond + ", rewardVerified:" + liveInfo.rewardInfo.rewardVerified);
        }
        return liveInfo;
    }

    @Override // com.kwad.components.core.innerEc.live.b.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Vd = this.Uj.UN;
        AdTemplate adTemplate = this.Uj.mAdTemplate;
        this.TM = aH(adTemplate);
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.Uj.UI = this.UI;
        this.Uj.UM.a(this.Wl);
        this.Uj.UM.Am();
        sr();
        this.Vd.a(this.Vg);
        this.Uj.UQ.registerSCMessageListener(this.Wg);
        this.Uj.UQ.registerSCMessageListener(sq());
        this.Uj.UQ.registerSCMessageListener(this.Wh);
        this.Uj.UQ.registerSCMessageListener(this.Wi);
        this.Uj.UT.a(this.Wj);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        this.Uj.UM.b(this.Wl);
        com.kwad.components.core.webview.tachikoma.i iVar = this.VO;
        if (iVar != null) {
            iVar.kT();
        }
        this.Vd.b(this.Vg);
        this.Uj.UQ.unregisterSCMessageListener(this.Wg);
        this.Uj.UQ.registerSCMessageListener(this.Wk);
        this.Uj.UQ.unregisterSCMessageListener(this.Wh);
        this.Uj.UQ.unregisterSCMessageListener(this.Wi);
        this.Uj.UT.b(this.Wj);
        this.VV = null;
        this.VY = null;
        this.Uj.UX.clear();
    }

    private com.kwad.components.core.innerEc.live.g.d sq() {
        com.kwad.components.core.innerEc.live.g.d dVar = this.Wk;
        if (dVar != null) {
            return dVar;
        }
        com.kwad.components.core.innerEc.live.g.d dVar2 = new com.kwad.components.core.innerEc.live.g.d(this.Uj) { // from class: com.kwad.components.core.innerEc.live.b.c.e.8
            @Override // com.kwad.components.core.innerEc.live.g.d
            public final void a(com.kwad.components.core.innerEc.live.f.a aVar) {
                com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "call JsHandlerProductIntroduction");
                if (e.this.VU != null) {
                    e.this.VY = aVar;
                    e.this.VU.a(e.this.VY);
                }
            }
        };
        this.Wk = dVar2;
        return dVar2;
    }

    private void sr() {
        this.VO = new com.kwad.components.core.webview.tachikoma.i(getContext());
        com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "initTKLiveAdPage LiveDetailFragment mLiveDetailInfo: " + this.TM);
        this.Wd = new com.kwad.components.core.innerEc.live.a.a();
        this.We = new o();
        this.VP = new com.kwad.components.core.innerEc.live.a.c(this.TM);
        this.VQ = new com.kwad.components.core.innerEc.live.a.i();
        this.VR = new com.kwad.components.core.innerEc.live.a.g();
        this.VZ = new com.kwad.components.core.innerEc.live.a.d();
        this.VU = new l();
        this.VS = new com.kwad.components.core.innerEc.live.a.f();
        this.VT = new com.kwad.components.core.innerEc.live.a.h();
        this.Uj.Va = new com.kwad.components.core.innerEc.live.a.p();
        this.Wb = new n(new n.a() { // from class: com.kwad.components.core.innerEc.live.b.c.e.10
            @Override // com.kwad.components.core.innerEc.live.a.n.a
            public final void rJ() {
                com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "onCallShowSoftInput: ");
                e.this.Uj.UW.apply(null);
            }
        });
        this.Wa = new com.kwad.components.core.innerEc.live.a.b(new com.kwad.components.core.innerEc.live.a.b.a() { // from class: com.kwad.components.core.innerEc.live.b.c.e.2
            @Override // com.kwad.components.core.innerEc.live.a.b.a
            public final void aJ(boolean z) {
                com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "onExplainCardHide: " + z);
                e.this.Uj.UY.apply(Boolean.valueOf(z));
            }
        });
        this.Wc = new k(getActivity());
        this.Wf = new m();
        this.VO.a("cardMarginBottom", (Object) 0);
        com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "initTKLiveAdPage mAdResultData: " + this.Uj.mAdResultData);
        com.kwad.components.core.innerEc.logger.a.aR(this.Uj.mAdTemplate);
        this.VO.a(getActivity(), this.Uj.mAdResultData, this);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.ed(this.Uj.mAdTemplate);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final FrameLayout getTKContainer() {
        return this.dz;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "onTkLoadFailed: " + tKRenderFailReason.name());
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        this.dz.setVisibility(8);
        this.Uj.UZ.b(tKRenderFailReason);
        if (com.kwad.components.core.innerEc.live.b.Tz != null) {
            com.kwad.components.core.innerEc.live.b.Tz.rF();
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        az azVar;
        com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "onTkLoadSuccess: ");
        az azVar2 = this.di;
        if (azVar2 != null) {
            azVar2.yJ();
            this.di.yK();
        }
        if (this.Ky && (azVar = this.di) != null) {
            azVar.yN();
        }
        this.dz.setVisibility(0);
        this.Uj.UZ.sV();
        Iterator<com.kwad.sdk.g.b<Object, Object>> it = this.Uj.UX.iterator();
        while (it.hasNext()) {
            it.next().apply(null);
        }
        if (com.kwad.components.core.innerEc.live.b.Tz != null) {
            com.kwad.components.core.innerEc.live.b.Tz.rE();
        }
        com.kwad.components.core.innerEc.logger.a.aS(this.Uj.mAdTemplate);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        tVar.c(this.VP);
        tVar.c(this.VQ);
        this.VQ.a(this.Uj.UV);
        com.kwad.components.core.innerEc.live.a.g gVar = new com.kwad.components.core.innerEc.live.a.g();
        this.VR = gVar;
        tVar.c(gVar);
        com.kwad.components.core.innerEc.live.base.d dVar = this.VV;
        if (dVar != null) {
            this.VR.a(dVar);
        }
        this.Uj.Vb = new com.kwad.components.core.innerEc.live.a.e();
        tVar.c(this.Uj.Vb);
        tVar.c(this.VS);
        com.kwad.components.core.innerEc.live.base.c cVar = this.VW;
        if (cVar != null) {
            this.VS.a(cVar);
        }
        tVar.c(this.VT);
        com.kwad.components.core.innerEc.live.base.e eVar = this.VX;
        if (eVar != null) {
            this.VT.a(eVar);
        }
        l lVar = new l();
        this.VU = lVar;
        tVar.c(lVar);
        com.kwad.components.core.innerEc.live.f.a aVar = this.VY;
        if (aVar != null) {
            this.VU.a(aVar);
        }
        tVar.c(this.VZ);
        if (this.Uj.UT.sP()) {
            this.VZ.a(com.kwad.components.core.innerEc.live.a.d.a.rI().aK(true));
        }
        tVar.c(this.Wb);
        tVar.c(this.Wa);
        tVar.c(this.Wc);
        tVar.c(this.Wd);
        tVar.c(this.We);
        tVar.c(this.Wf);
        tVar.c(this.Uj.Va);
        tVar.c(new com.kwad.components.core.innerEc.live.a.j(this));
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        aVar.width = (int) (getTKContainer().getWidth() / fBA);
        aVar.height = (int) (getTKContainer().getHeight() / fBA);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(WebCloseStatus webCloseStatus) {
        getActivity().onBackPressed();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        this.di = azVar;
        azVar.bm(true);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        if (this.Uj.UR != null) {
            this.Uj.UR.destroy();
        }
    }

    @Override // com.kwad.components.core.innerEc.live.base.f
    public final void b(LiveDetailReward liveDetailReward) {
        if (liveDetailReward == null) {
            return;
        }
        com.kwad.sdk.core.d.c.d("LiveDetailTKPresenter", "onUpdateLiveDetailReward: " + liveDetailReward);
        if (liveDetailReward.success) {
            af.di(getContext()).i(new Intent("REWARD_LIVE_ACTION_VERIFY"));
        } else {
            Intent intent = new Intent("REWARD_LIVE_ACTION_PROGRESS");
            intent.putExtra("countDownSecond", liveDetailReward.countDownSecond);
            intent.putExtra("hasRewardTime", liveDetailReward.hasRewardTime);
            af.di(getContext()).i(intent);
        }
    }
}
