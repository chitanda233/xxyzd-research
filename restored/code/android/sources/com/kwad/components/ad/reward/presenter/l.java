package com.kwad.components.ad.reward.presenter;

import android.view.View;
import com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public final class l extends b implements com.kwad.components.ad.reward.presenter.platdetail.actionbar.a {
    private RewardActionBarControl st;
    private com.kwad.components.ad.reward.n.g wB;
    private KsLogoView wD;
    private com.kwad.components.ad.reward.n.l wE;
    private boolean wC = false;
    private com.kwad.components.core.video.m jX = new com.kwad.components.core.video.m() { // from class: com.kwad.components.ad.reward.presenter.l.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            l.this.iP();
        }
    };

    /* JADX INFO: Access modifiers changed from: private */
    public void iP() {
        if (this.wC) {
            return;
        }
        com.kwad.components.ad.reward.n.g gVar = this.wB;
        if (gVar == null) {
            this.st.Q(false);
        } else {
            gVar.a(new com.kwad.components.ad.reward.n.g.a() { // from class: com.kwad.components.ad.reward.presenter.l.2
                @Override // com.kwad.components.ad.reward.n.g.a
                public final void iQ() {
                    l.this.st.Q(true);
                }
            }, 500L);
        }
        this.wC = true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.wD = (KsLogoView) findViewById(R.id.ksad_ad_label_play_bar);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.st = this.ub.st;
        this.ub.sr.a(this.jX);
        AdTemplate adTemplate = this.ub.mAdTemplate;
        boolean z = com.kwad.sdk.core.response.helper.b.dP(adTemplate).displayWeakCard;
        this.ub.B(z);
        if (z) {
            if (this.wB == null) {
                this.wB = new com.kwad.components.ad.reward.n.g(this.ub);
            }
            this.wB.h((AdBaseFrameLayout) findViewById(R.id.ksad_root_container));
            this.wB.b(com.kwad.components.ad.reward.n.r.ad(adTemplate));
        }
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if (com.kwad.sdk.core.response.helper.a.cI(adTemplate)) {
            if (this.wE == null) {
                this.wE = new com.kwad.components.ad.reward.n.l(this.ub);
            }
            this.wE.j(this.ub.mRootContainer);
            this.wE.b(com.kwad.components.ad.reward.n.r.ad(adTemplate));
            com.kwad.components.ad.reward.presenter.platdetail.actionbar.d.a(getContext(), adInfoEM, this.wD, R.dimen.ksad_live_subscribe_card_logo_margin_bottom, false);
        }
        this.ub.st.a(this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sr.b(this.jX);
        this.ub.st.b(this);
        com.kwad.components.ad.reward.n.l lVar = this.wE;
        if (lVar != null) {
            lVar.onUnbind();
        }
    }

    @Override // com.kwad.components.ad.reward.presenter.platdetail.actionbar.a
    public final void a(RewardActionBarControl.ShowActionBarResult showActionBarResult, View view) {
        com.kwad.components.ad.reward.n.l lVar = this.wE;
        if (lVar != null) {
            lVar.lD();
        }
    }
}
