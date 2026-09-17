package com.kwad.components.ad.reward.presenter.f;

import android.view.View;
import android.view.ViewGroup;
import com.kwad.components.ad.reward.e.j;
import com.kwad.components.ad.reward.e.n;
import com.kwad.components.ad.reward.e.o;
import com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.sdk.R;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class h extends g implements j, com.kwad.components.ad.reward.presenter.platdetail.actionbar.a {
    private boolean AP;
    private boolean AQ;
    private View AT;
    private az di;
    private boolean AU = false;
    private com.kwad.components.ad.reward.e.g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.f.h.1
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            h.this.AS.setVisibility(8);
        }
    };
    private com.kwad.components.ad.reward.g.a AV = new com.kwad.components.ad.reward.g.a() { // from class: com.kwad.components.ad.reward.presenter.f.h.2
        @Override // com.kwad.components.ad.reward.g.a
        public final void hn() {
            h.this.AQ = true;
        }

        @Override // com.kwad.components.ad.reward.g.a
        public final void ho() {
            h.this.AQ = true;
            h.this.ks();
        }

        @Override // com.kwad.components.ad.reward.g.a
        public final void hp() {
            h.this.AQ = false;
            if (h.this.di != null) {
                h.this.di.yO();
            }
        }

        @Override // com.kwad.components.ad.reward.g.a
        public final void hq() {
            h.this.AQ = false;
        }
    };

    @Override // com.kwad.components.ad.reward.e.j
    public final void a(PlayableSource playableSource, n nVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_top_floor_bar";
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ub.a(this.AV);
        this.ub.st.a(this);
        this.ub.b(this.mPlayEndPageListener);
        com.kwad.components.ad.reward.a.gq().a(this);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        super.onUnbind();
        this.ub.b(this.AV);
        this.ub.st.b(this);
        this.ub.c(this.mPlayEndPageListener);
        com.kwad.components.ad.reward.a.gq().b(this);
        this.ub.a((com.kwad.components.core.webview.tachikoma.f.a) null);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.ea(this.ub.mAdTemplate);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        super.aB();
        ks();
        this.AU = true;
        this.AS.setVisibility(0);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        this.AU = false;
        this.AS.setVisibility(8);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ks() {
        az azVar = this.di;
        if (azVar == null || !this.AQ) {
            return;
        }
        if (!this.AP) {
            azVar.yJ();
            this.di.yK();
            this.AP = true;
            return;
        }
        azVar.yN();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        float screenHeight = com.kwad.sdk.c.a.a.getScreenHeight(getContext());
        aVar.width = (int) ((com.kwad.sdk.c.a.a.getScreenWidth(getContext()) / fBA) + 0.5f);
        aVar.height = (int) ((screenHeight / fBA) + 0.5f);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.g
    protected final int jh() {
        return R.id.ksad_js_topfloor;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        super.a(tVar, bVar);
        tVar.c(new com.kwad.components.core.webview.tachikoma.b.e(kv()));
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        super.a(azVar);
        this.di = azVar;
    }

    private com.kwad.components.core.webview.tachikoma.b.e.b kv() {
        return new com.kwad.components.core.webview.tachikoma.b.e.b() { // from class: com.kwad.components.ad.reward.presenter.f.h.3
            @Override // com.kwad.components.core.webview.tachikoma.b.e.b
            public final int kw() {
                o oVar = h.this.ub.sY;
                if (oVar != null) {
                    return com.kwad.sdk.c.a.a.px2dip(h.this.getContext(), oVar.dv());
                }
                if (h.this.AT == null) {
                    return 0;
                }
                ViewGroup.LayoutParams layoutParams = h.this.AT.getLayoutParams();
                if (!(layoutParams instanceof ViewGroup.MarginLayoutParams)) {
                    return com.kwad.sdk.c.a.a.px2dip(h.this.getContext(), h.this.AT.getHeight());
                }
                return com.kwad.sdk.c.a.a.px2dip(h.this.getContext(), h.this.AT.getHeight() + ((ViewGroup.MarginLayoutParams) layoutParams).bottomMargin);
            }
        };
    }

    @Override // com.kwad.components.ad.reward.presenter.platdetail.actionbar.a
    public final void a(RewardActionBarControl.ShowActionBarResult showActionBarResult, View view) {
        this.AT = view;
    }

    @Override // com.kwad.components.ad.reward.e.j
    /* JADX INFO: renamed from: do */
    public final void mo174do() {
        if (this.AU) {
            this.AS.setVisibility(0);
        }
    }

    @Override // com.kwad.components.ad.reward.e.j
    public final void dp() {
        if (this.AU) {
            this.AS.setVisibility(8);
        }
    }
}
