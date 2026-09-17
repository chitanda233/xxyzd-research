package com.kwad.components.ad.reward.presenter.platdetail.actionbar;

import android.view.ViewGroup;
import android.widget.FrameLayout;
import com.kwad.components.ad.reward.n.n;
import com.kwad.components.ad.reward.n.r;
import com.kwad.components.core.t.m;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends com.kwad.components.ad.reward.presenter.b implements RewardActionBarControl.c {
    private ViewGroup mRootContainer;
    private KsLogoView wD;
    private n zf;
    private int zg;
    private FrameLayout.LayoutParams zh;
    private n.a zi;

    public e(ViewGroup viewGroup, n.a aVar) {
        this.mRootContainer = viewGroup;
        this.zi = aVar;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.wD = (KsLogoView) findViewById(R.id.ksad_ad_label_play_bar);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ub.st.a(this);
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate);
        this.zg = this.wD.getVisibility();
        this.zh = d.a(getContext(), adInfoEM, this.wD, R.dimen.ksad_reward_order_logo_margin_bottom, !this.ub.sr.lq());
        n nVar = new n(this.mRootContainer, new com.kwad.components.ad.reward.n.a(getContext(), this.ub) { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.e.1
            @Override // com.kwad.components.ad.reward.n.a, com.kwad.components.ad.reward.n.b
            public final void jC() {
                e.this.ub.a(1, e.this.getContext(), 10, 2);
            }

            @Override // com.kwad.components.ad.reward.n.a, com.kwad.components.ad.reward.n.b
            public final void jD() {
                e.this.ub.a(1, e.this.getContext(), 10, 2);
            }
        });
        this.zf = nVar;
        nVar.a(this.zi);
        this.zf.b(r.ad(this.ub.mAdTemplate));
        m.a(new com.kwad.components.core.widget.e(), this.zf.hZ());
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.wD.setVisibility(this.zg);
        FrameLayout.LayoutParams layoutParams = this.zh;
        if (layoutParams != null) {
            this.wD.setLayoutParams(layoutParams);
        }
    }

    @Override // com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl.c
    public final void e(a aVar) {
        this.mRootContainer.setVisibility(0);
        RewardActionBarControl.a(aVar, this.mRootContainer, RewardActionBarControl.ShowActionBarResult.SHOW_NATIVE_ORDER);
    }
}
