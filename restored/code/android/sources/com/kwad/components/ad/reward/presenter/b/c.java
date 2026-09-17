package com.kwad.components.ad.reward.presenter.b;

import android.view.View;
import com.kwad.components.ad.reward.n.o;
import com.kwad.components.ad.reward.n.r;
import com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.ad.reward.presenter.b implements com.kwad.components.ad.reward.presenter.platdetail.actionbar.a {
    private RewardActionBarControl st;
    private m wH = new m() { // from class: com.kwad.components.ad.reward.presenter.b.c.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            if (c.this.ub != null && c.this.ub.mAdTemplate != null && c.this.ub.mAdTemplate.mLiveDetailRewardFromAdLive != null) {
                c.this.ub.mAdTemplate.mLiveDetailRewardFromAdLive.hasRewardTime = j2 / 1000;
            }
            c.this.iP();
        }
    };
    private o yd;

    @Override // com.kwad.components.ad.reward.presenter.platdetail.actionbar.a
    public final void a(RewardActionBarControl.ShowActionBarResult showActionBarResult, View view) {
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void iP() {
        this.st.Q(false);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.st = this.ub.st;
        this.ub.sr.a(this.wH);
        AdTemplate adTemplate = this.ub.mAdTemplate;
        AdInfo adInfoEM = e.eM(adTemplate);
        if (com.kwad.sdk.core.response.helper.a.cY(adInfoEM)) {
            if (this.yd == null) {
                this.yd = new o(this.ub);
            }
            this.yd.b(this.ub.mRootContainer, com.kwad.sdk.core.response.helper.a.bl(adInfoEM));
            this.yd.b(r.ad(adTemplate));
            findViewById(R.id.ksad_reward_origin_live_root).setVisibility(8);
        }
        this.ub.st.a(this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sr.b(this.wH);
        this.ub.st.b(this);
        o oVar = this.yd;
        if (oVar != null) {
            oVar.onUnbind();
        }
    }
}
