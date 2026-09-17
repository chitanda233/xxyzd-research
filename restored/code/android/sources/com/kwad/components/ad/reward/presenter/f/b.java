package com.kwad.components.ad.reward.presenter.f;

import android.widget.FrameLayout;
import com.kwad.components.ad.reward.k.u;
import com.kwad.components.ad.reward.page.BackPressHandleResult;
import com.kwad.components.core.innerEc.live.a.j;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.x;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.c.y;
import com.kwad.sdk.R;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.LiveDetailReward;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public class b extends d implements com.kwad.components.core.innerEc.live.base.f {
    private FrameLayout Au;
    private u Aw;
    private boolean Av = false;
    private com.kwad.components.core.innerEc.live.base.f zw = new com.kwad.components.core.innerEc.live.base.f() { // from class: com.kwad.components.ad.reward.presenter.f.b.1
        @Override // com.kwad.components.core.innerEc.live.base.f
        public final void b(LiveDetailReward liveDetailReward) {
            com.kwad.sdk.core.d.c.w("TKLivePresenter", "jky TKLivePresenter onUpdateLiveDetailReward: " + liveDetailReward);
            if (b.this.Aw != null) {
                b.this.Aw.a(liveDetailReward);
            }
        }
    };

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public String getTKReaderScene() {
        return "tk_live_video";
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d
    protected final boolean kg() {
        return true;
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
        this.ub.a(this.zw);
        if (this.Av) {
            return;
        }
        V(true);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        this.ub.b(this.zw);
    }

    public final BackPressHandleResult hH() {
        if (this.Az == null) {
            return BackPressHandleResult.NOT_HANDLED;
        }
        return this.Az.hH();
    }

    private com.kwad.components.core.webview.tachikoma.c eI() {
        return new com.kwad.components.core.webview.tachikoma.c() { // from class: com.kwad.components.ad.reward.presenter.f.b.2
            @Override // com.kwad.components.core.webview.tachikoma.c, com.kwad.sdk.core.webview.c.a
            public final void a(String str, com.kwad.sdk.core.webview.c.c cVar) {
                super.a(str, cVar);
                com.kwad.components.core.webview.tachikoma.c.c cVar2 = new com.kwad.components.core.webview.tachikoma.c.c();
                cVar2.aul = com.kwad.components.ad.reward.model.b.dV();
                cVar.b(cVar2);
            }
        };
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        super.a(tVar, bVar);
        tVar.c(eI());
        tVar.c(new com.kwad.components.core.webview.tachikoma.b(new com.kwad.components.core.webview.tachikoma.b.a() { // from class: com.kwad.components.ad.reward.presenter.f.b.3
            @Override // com.kwad.components.core.webview.tachikoma.b.a
            public final void eS() {
                com.kwad.components.ad.reward.model.b.L(b.this.ub.mContext);
            }
        }));
        tVar.c(new x() { // from class: com.kwad.components.ad.reward.presenter.f.b.4
            @Override // com.kwad.components.core.webview.jshandler.x
            public final void b(y yVar) {
                super.b(yVar);
                b.this.ub.sq.onVideoPlayStart();
                com.kwad.components.ad.reward.monitor.d.b(b.this.ub.sG, b.this.ub.mAdTemplate, b.this.ub.mPageEnterTime);
            }

            @Override // com.kwad.components.core.webview.jshandler.x
            public final void c(y yVar) {
                super.c(yVar);
                b.this.ub.sq.onVideoPlayEnd();
                b.this.ub.mAdTemplate.setmCurPlayTime(-1L);
                com.kwad.components.ad.reward.presenter.f.u(b.this.ub);
            }

            @Override // com.kwad.components.core.webview.jshandler.x
            public final void d(y yVar) {
                super.d(yVar);
                b.this.ub.mAdTemplate.setmCurPlayTime(yVar.ri);
            }

            @Override // com.kwad.components.core.webview.jshandler.x
            public final void a(y yVar) {
                super.a(yVar);
                long jZI = yVar.zI();
                b.this.ub.sq.onVideoPlayError(yVar.errorCode, (int) jZI);
                com.kwad.components.ad.reward.monitor.d.a(b.this.ub.sG, b.this.ub.mAdTemplate, b.this.ub.tf, yVar.errorCode, jZI);
                com.kwad.components.ad.reward.monitor.c.c(b.this.ub.sG, b.this.mAdTemplate);
            }
        });
        tVar.c(new j(this));
        u uVar = new u();
        this.Aw = uVar;
        tVar.c(uVar);
    }

    private void V(boolean z) {
        this.Au.setVisibility(z ? 0 : 8);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.ec(this.ub.mAdTemplate);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(final com.kwad.components.core.webview.tachikoma.c.u uVar) {
        com.kwad.sdk.core.d.c.d("TKLivePresenter", "onSkipClick: " + uVar.apx);
        by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.reward.presenter.f.b.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (b.this.ub != null && b.this.ub.sq != null) {
                    b.this.ub.sq.onVideoSkipToEnd(uVar.apx * 1000);
                }
                com.kwad.components.ad.reward.presenter.f.u(b.this.ub);
            }
        });
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public FrameLayout getTKContainer() {
        return this.Au;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        super.a(tKRenderFailReason);
        com.kwad.components.ad.reward.monitor.c.a(this.mAdTemplate, tKRenderFailReason);
        this.Av = true;
        V(false);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float screenHeight;
        float screenWidth;
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        FrameLayout frameLayout = this.Au;
        if (frameLayout != null) {
            screenHeight = frameLayout.getHeight();
            screenWidth = this.Au.getWidth();
        } else {
            screenHeight = 0.0f;
            screenWidth = 0.0f;
        }
        if (screenHeight == 0.0f || screenWidth == 0.0f) {
            screenHeight = com.kwad.sdk.c.a.a.getScreenHeight(getContext());
            screenWidth = com.kwad.sdk.c.a.a.getScreenWidth(getContext());
        }
        aVar.width = (int) ((screenWidth / fBA) + 0.5f);
        aVar.height = (int) ((screenHeight / fBA) + 0.5f);
    }

    @Override // com.kwad.components.core.innerEc.live.base.f
    public final void b(LiveDetailReward liveDetailReward) {
        if (this.mAdTemplate.mLiveDetailRewardFromAdLive != null) {
            this.mAdTemplate.updateLiveDetailRewardFromAdLive(liveDetailReward);
        }
    }
}
