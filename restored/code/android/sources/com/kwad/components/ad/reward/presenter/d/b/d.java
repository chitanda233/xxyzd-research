package com.kwad.components.ad.reward.presenter.d.b;

import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.reward.e.l;
import com.kwad.components.ad.reward.g;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.ad.reward.presenter.b implements View.OnClickListener, c {
    private static final String[] Ak = {"未获得奖励", "已获得奖励1/2", "已获得全部奖励"};
    private ViewGroup Ag;
    private ImageView Ah;
    private ViewGroup Ai;
    private TextView Aj;
    private final l mRewardVerifyListener = new l() { // from class: com.kwad.components.ad.reward.presenter.d.b.d.1
        @Override // com.kwad.components.ad.reward.e.l
        public final void onRewardVerify() {
            if (g.P(d.this.ub.mAdTemplate)) {
                d.this.kb();
            }
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.Ag = (ViewGroup) findViewById(R.id.ksad_end_reward_icon_layout);
        this.Ah = (ImageView) findViewById(R.id.ksad_end_reward_icon);
        this.Ai = (ViewGroup) findViewById(R.id.ksad_detail_reward_deep_task_view_playend);
        this.Aj = (TextView) findViewById(R.id.ksad_reward_deep_task_count_down_playend);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        dq();
    }

    private void dq() {
        com.kwad.components.ad.reward.b.gu().a(this.mRewardVerifyListener);
        this.Ag.setVisibility(0);
        this.Ai.setVisibility(g.P(this.ub.mAdTemplate) ? 0 : 8);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.components.ad.reward.b.gu().b(this.mRewardVerifyListener);
        this.Ag.setVisibility(8);
        this.Ah.setVisibility(8);
        this.Ai.setVisibility(8);
    }

    private void ka() {
        ImageView imageView = this.Ah;
        if (imageView != null) {
            imageView.setVisibility(0);
            this.Ah.setOnClickListener(this);
        }
        ViewGroup viewGroup = this.Ag;
        if (viewGroup != null) {
            viewGroup.setOnClickListener(this);
            this.Ag.setVisibility(0);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void kb() {
        this.Aj.setText(Ak[2]);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.Ah || view == this.Ag) {
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(view.getContext()).aF(this.ub.mAdTemplate).b(this.ub.mApkDownloadHelper).as(false).aD(2).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.reward.presenter.d.b.d.2
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    d.this.notifyAdClick();
                }
            }));
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void notifyAdClick() {
        com.kwad.components.ad.reward.j.b.a(this.ub.mAdTemplate, (String) null, (String) null, new com.kwad.sdk.core.adlog.c.b().f(this.ub.mRootContainer.getTouchCoords()).dS(41), this.ub.mReportExtData);
        this.ub.sq.cY();
    }

    @Override // com.kwad.components.ad.reward.presenter.d.b.c
    public final void jY() {
        if (this.ub.sT) {
            if (com.kwad.sdk.core.response.helper.a.ay(e.eM(this.ub.mAdTemplate))) {
                this.Ai.setVisibility(8);
            }
        } else if (g.N(this.ub.mAdTemplate) || g.O(this.ub.mAdTemplate)) {
            if (this.ub.hg()) {
                return;
            }
            this.Aj.setText(this.ub.sM ? Ak[1] : Ak[0]);
        } else if (this.ub.hg()) {
            ka();
        }
    }
}
