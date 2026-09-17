package com.kwad.components.ad.reward.presenter.f;

import android.text.TextUtils;
import android.widget.FrameLayout;
import com.kwad.components.ad.reward.e.j;
import com.kwad.components.ad.reward.e.n;
import com.kwad.components.ad.reward.k.l;
import com.kwad.components.ad.reward.k.u;
import com.kwad.components.ad.reward.page.BackPressHandleResult;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.p;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.LiveDetailReward;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class f extends a implements j, com.kwad.components.core.innerEc.live.base.f, com.kwad.components.core.j.a.InterfaceC0443a {
    protected FrameLayout Au;
    private u Aw;
    private List<com.kwad.components.core.j.c> bT;
    private com.kwad.components.core.webview.tachikoma.e nZ;
    private boolean Av = false;
    private com.kwad.components.core.innerEc.live.base.f zw = new com.kwad.components.core.innerEc.live.base.f() { // from class: com.kwad.components.ad.reward.presenter.f.f.1
        @Override // com.kwad.components.core.innerEc.live.base.f
        public final void b(LiveDetailReward liveDetailReward) {
            com.kwad.sdk.core.d.c.w("TkRewardPagePresenter", "jky TKLivePresenter onUpdateLiveDetailReward: " + liveDetailReward);
            if (f.this.Aw != null) {
                f.this.Aw.a(liveDetailReward);
            }
        }
    };
    private final com.kwad.components.core.webview.tachikoma.f.a sC = new com.kwad.components.core.webview.tachikoma.f.a() { // from class: com.kwad.components.ad.reward.presenter.f.f.2
        @Override // com.kwad.components.core.webview.tachikoma.f.a
        public final void ku() {
            if (f.this.nZ != null) {
                com.kwad.components.core.webview.tachikoma.c.a aVar = new com.kwad.components.core.webview.tachikoma.c.a();
                aVar.auj = f.this.ub.iZ ? 1 : 0;
                f.this.nZ.b(aVar);
            }
        }
    };

    @Override // com.kwad.components.ad.reward.e.j
    public final void dp() {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    public String getTKReaderScene() {
        return "tk_reward";
    }

    @Override // com.kwad.components.core.j.a.InterfaceC0443a
    public final void onError(int i, String str) {
    }

    @Override // com.kwad.components.core.j.a.InterfaceC0443a
    public final void onRequestResult(int i) {
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.Au = (FrameLayout) findViewById(dy());
    }

    protected int dy() {
        return R.id.ksad_js_reward_card;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (!this.Av) {
            X(true);
        }
        this.ub.sH = true ^ this.Av;
        this.ub.a((com.kwad.components.core.j.a.InterfaceC0443a) this);
        com.kwad.components.ad.reward.a.gq().a(this);
        this.ub.a(this.zw);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.b((com.kwad.components.core.j.a.InterfaceC0443a) this);
        com.kwad.components.ad.reward.a.gq().b(this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        this.ub.b(this.zw);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
        if (aVar == null || com.kwad.sdk.core.response.helper.e.b(this.ub.mAdResultData.getProceedTemplateList(), aVar.creativeId, aVar.adStyle)) {
            this.ub.sq.cY();
            return;
        }
        if (aVar.adTemplate != null && !aVar.bdj) {
            this.ub.sq.cY();
            return;
        }
        com.kwad.components.core.j.c cVarA = com.kwad.components.ad.reward.g.a(this.bT, aVar.creativeId);
        if (cVarA != null) {
            this.ub.a(cVarA);
        }
    }

    public final BackPressHandleResult hH() {
        if (this.Az == null) {
            return BackPressHandleResult.NOT_HANDLED;
        }
        return this.Az.hH();
    }

    private void X(boolean z) {
        com.kwad.sdk.core.d.c.d("TkRewardPagePresenter", "fullTK: " + z);
        FrameLayout frameLayout = this.Au;
        if (frameLayout == null) {
            return;
        }
        frameLayout.setVisibility(z ? 0 : 8);
    }

    public String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.eb(this.ub.mAdTemplate);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public FrameLayout getTKContainer() {
        return this.Au;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        super.a(tKRenderFailReason);
        com.kwad.components.ad.reward.monitor.c.a(this.mAdTemplate, tKRenderFailReason);
        com.kwad.sdk.core.d.c.d("TkRewardPagePresenter", "onTkLoadFailed");
        this.Av = true;
        this.ub.sH = false;
        X(false);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.a, com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        super.a(tVar, bVar);
        tVar.c(new com.kwad.components.ad.reward.c.f(new com.kwad.components.ad.reward.c.d() { // from class: com.kwad.components.ad.reward.presenter.f.f.3
            @Override // com.kwad.components.ad.reward.c.d
            public final void a(com.kwad.components.ad.reward.c.b bVar2) {
                com.kwad.sdk.core.d.c.d("TkRewardPagePresenter", "onUpdateExtraReward : " + bVar2.ii());
                f.this.a(bVar2);
            }
        }));
        this.nZ = eJ();
        this.ub.a(this.sC);
        tVar.c(this.nZ);
        tVar.c(new com.kwad.components.core.webview.tachikoma.b(new com.kwad.components.core.webview.tachikoma.b.a() { // from class: com.kwad.components.ad.reward.presenter.f.f.4
            @Override // com.kwad.components.core.webview.tachikoma.b.a
            public final void eS() {
                com.kwad.components.ad.reward.model.b.L(f.this.ub.mContext);
            }
        }));
        tVar.c(eI());
        tVar.c(new com.kwad.components.core.webview.jshandler.j(new p() { // from class: com.kwad.components.ad.reward.presenter.f.f.5
            @Override // com.kwad.components.core.webview.jshandler.p
            public final void a(com.kwad.components.core.webview.jshandler.j jVar, String str) {
                if (TextUtils.equals(str, "autoCallApp")) {
                    jVar.bk(com.kwad.components.ad.reward.g.g(com.kwad.sdk.core.response.helper.e.eM(f.this.ub.mAdTemplate)) && com.kwad.sdk.core.local.a.Mk() && f.this.ub.mScreenOrientation == 0);
                }
            }
        }));
        tVar.c(new com.kwad.components.core.innerEc.live.a.j(this));
        u uVar = new u();
        this.Aw = uVar;
        tVar.c(uVar);
    }

    private com.kwad.components.core.webview.tachikoma.e eJ() {
        return new com.kwad.components.core.webview.tachikoma.e() { // from class: com.kwad.components.ad.reward.presenter.f.f.6
            @Override // com.kwad.components.core.webview.tachikoma.e, com.kwad.sdk.core.webview.c.a
            public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
                super.a(str, cVar);
                com.kwad.components.core.webview.tachikoma.c.a aVar = new com.kwad.components.core.webview.tachikoma.c.a();
                aVar.auj = f.this.ub.iZ ? 1 : 0;
                cVar.b(aVar);
            }
        };
    }

    private com.kwad.components.core.webview.tachikoma.c eI() {
        return new com.kwad.components.core.webview.tachikoma.c() { // from class: com.kwad.components.ad.reward.presenter.f.f.7
            @Override // com.kwad.components.core.webview.tachikoma.c, com.kwad.sdk.core.webview.c.a
            public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
                super.a(str, cVar);
                com.kwad.components.core.webview.tachikoma.c.c cVar2 = new com.kwad.components.core.webview.tachikoma.c.c();
                cVar2.aul = com.kwad.components.ad.reward.model.b.dV();
                cVar.b(cVar2);
            }
        };
    }

    @Override // com.kwad.components.core.j.a.InterfaceC0443a
    public final void e(List<com.kwad.components.core.j.c> list) {
        if (list == null || list.size() == 0 || this.Az == null) {
            return;
        }
        this.bT = list;
        List<AdTemplate> listA = a(list, this.ub.mAdTemplate);
        com.kwad.sdk.core.webview.b bVarYY = this.Az.yY();
        if (bVarYY != null) {
            bVarYY.setAdTemplateList(listA);
        }
        l lVarKS = this.Az.kS();
        if (lVarKS != null) {
            lVarKS.g(listA);
        } else {
            this.Az.h(listA);
        }
    }

    private static List<AdTemplate> a(List<com.kwad.components.core.j.c> list, AdTemplate adTemplate) {
        ArrayList arrayList = new ArrayList();
        arrayList.add(adTemplate);
        arrayList.addAll(com.kwad.components.core.j.c.q(list));
        return arrayList;
    }

    @Override // com.kwad.components.ad.reward.e.j
    public final void a(PlayableSource playableSource, n nVar) {
        FrameLayout frameLayout;
        if (this.Av || (frameLayout = this.Au) == null) {
            return;
        }
        frameLayout.setVisibility(8);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.tachikoma.c.u uVar) {
        com.kwad.sdk.core.d.c.d("TkRewardPagePresenter", "onSkipClick: " + uVar.apx);
        if (this.ub != null && this.ub.sq != null) {
            this.ub.sq.onVideoSkipToEnd(uVar.apx * 1000);
        }
        com.kwad.components.ad.reward.presenter.f.u(this.ub);
        com.kwad.components.ad.reward.g.a(this.ub.sy, new com.kwad.sdk.g.a<com.kwad.components.ad.reward.k.a>() { // from class: com.kwad.components.ad.reward.presenter.f.f.8
            @Override // com.kwad.sdk.g.a
            public final /* synthetic */ void accept(com.kwad.components.ad.reward.k.a aVar) {
                c(aVar);
            }

            private static void c(com.kwad.components.ad.reward.k.a aVar) {
                aVar.kf();
            }
        });
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(WebCloseStatus webCloseStatus) {
        super.a(webCloseStatus);
    }

    @Override // com.kwad.components.ad.reward.e.j
    /* JADX INFO: renamed from: do */
    public final void mo174do() {
        FrameLayout frameLayout;
        if (this.Av || (frameLayout = this.Au) == null) {
            return;
        }
        frameLayout.setVisibility(0);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.a, com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float height;
        float width;
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        FrameLayout frameLayout = this.Au;
        if (frameLayout != null) {
            height = frameLayout.getHeight();
            width = this.Au.getWidth();
        } else {
            height = 0.0f;
            width = 0.0f;
        }
        if (height == 0.0f || width == 0.0f) {
            super.a(aVar);
        } else {
            aVar.width = (int) ((width / fBA) + 0.5f);
            aVar.height = (int) ((height / fBA) + 0.5f);
        }
    }

    @Override // com.kwad.components.core.innerEc.live.base.f
    public final void b(LiveDetailReward liveDetailReward) {
        com.kwad.sdk.core.d.c.w("TkRewardPagePresenter", "jky neo TK onUpdateLiveDetailReward: " + liveDetailReward);
        if (this.mAdTemplate.mLiveDetailRewardFromAdLive != null) {
            this.mAdTemplate.updateLiveDetailRewardFromAdLive(liveDetailReward);
        }
    }
}
