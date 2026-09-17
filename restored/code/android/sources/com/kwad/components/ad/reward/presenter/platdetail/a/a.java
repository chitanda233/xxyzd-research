package com.kwad.components.ad.reward.presenter.platdetail.a;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.ValueAnimator;
import android.os.Message;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.reward.e.l;
import com.kwad.components.ad.reward.g;
import com.kwad.components.ad.reward.k;
import com.kwad.components.core.innerEc.live.base.f;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.LiveDetailReward;
import com.kwad.sdk.utils.cc;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.reward.presenter.b implements View.OnClickListener, cc.a {
    private static final String[] zr = {"%ss后获得奖励1", "已获得奖励1/2", "已获得全部奖励"};
    private cc ca;
    private TextView kn;
    private boolean kp;
    private long kq;
    private AdInfo mAdInfo;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private TextView zn;
    private ImageView zo;
    private View zp;
    private boolean zq = false;
    private boolean zs = false;
    private boolean zt = false;
    private long zu = 0;
    private boolean zv = false;
    private f zw = new f() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.a.1
        @Override // com.kwad.components.core.innerEc.live.base.f
        public final void b(LiveDetailReward liveDetailReward) {
            a.this.zv = liveDetailReward.success;
            long j = (long) (liveDetailReward.hasRewardTime * 1000.0d);
            a aVar = a.this;
            aVar.zu = j - aVar.kq;
            a.this.G((int) liveDetailReward.countDownSecond);
        }
    };
    private final m jX = new m() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.a.2
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            long jH = g.h(a.this.mAdInfo);
            a.this.kq = j2;
            a.this.a(jH, j2);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.h
        public final void onLivePlayEnd() {
            super.onLivePlayEnd();
            if (a.this.kp) {
                return;
            }
            a.this.ca.sendEmptyMessageDelayed(1, 500L);
        }
    };
    private final l mRewardVerifyListener = new l() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.a.3
        @Override // com.kwad.components.ad.reward.e.l
        public final void onRewardVerify() {
            a.b(a.this, true);
            a.this.zn.setText(a.zr[2]);
        }
    };

    static /* synthetic */ boolean b(a aVar, boolean z) {
        aVar.zs = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.kn = (TextView) findViewById(R.id.ksad_video_count_down);
        this.zo = (ImageView) findViewById(R.id.ksad_detail_reward_icon);
        this.zn = (TextView) findViewById(R.id.ksad_reward_deep_task_count_down);
        this.zp = findViewById(R.id.ksad_detail_reward_deep_task_view);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ca = new cc(this);
        this.ub.a(this.zw);
        dq();
        if (this.ub.sr.lq()) {
            G((int) (com.kwad.sdk.core.response.helper.a.ak(this.mAdInfo) / 1000.0f));
        }
    }

    private void dq() {
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate);
        this.mApkDownloadHelper = this.ub.mApkDownloadHelper;
        com.kwad.sdk.core.response.helper.a.O(this.mAdInfo);
        long jH = g.h(this.mAdInfo) / 1000;
        if (g.P(this.mAdTemplate)) {
            this.zp.setVisibility(0);
            this.zp.setOnClickListener(this);
            this.zn.setText(String.format(zr[0], Long.valueOf(jH)));
            this.kn.setVisibility(8);
        } else {
            this.zp.setVisibility(8);
            this.kn.setText(String.valueOf(jH));
            this.kn.setVisibility(0);
            this.kn.setAlpha(1.0f);
        }
        com.kwad.components.ad.reward.b.gu().a(this.mRewardVerifyListener);
        this.ub.sr.a(this.jX);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.components.ad.reward.b.gu().b(this.mRewardVerifyListener);
        this.ub.sr.b(this.jX);
        this.zo.setVisibility(8);
        this.zp.setVisibility(8);
        this.zq = false;
        this.zs = false;
        this.kp = false;
        this.ub.b(this.zw);
    }

    public final void a(long j, long j2) {
        int iAQ;
        if (com.kwad.sdk.core.response.helper.a.aU(this.mAdInfo) && com.kwad.components.core.r.a.wy().wz() == 0) {
            iAQ = com.kwad.sdk.core.response.helper.a.aS(this.mAdInfo);
        } else {
            iAQ = com.kwad.sdk.core.response.helper.a.aQ(this.mAdInfo);
        }
        long j3 = iAQ * (this.ub.sJ ? 1000 : 0);
        com.kwad.components.ad.reward.m.b(this.ub, j2, j, j3);
        if (!this.zt) {
            this.zt = k.a(this.ub, j2, j, j3);
        }
        a(j2, j, j3);
    }

    private void a(long j, long j2, long j3) {
        if (!this.zv) {
            long j4 = this.zu;
            if (j + j4 < (j2 - 800) - j3) {
                int iFloor = (int) Math.floor(((j2 - j) - j4) / 1000.0f);
                int i = iFloor > 0 ? iFloor : 1;
                G(i);
                if (this.ub.sS != null) {
                    this.ub.sS.aj(i);
                    return;
                }
                return;
            }
        }
        this.ub.sM = true;
        if (g.P(this.mAdTemplate)) {
            if (g.N(this.mAdTemplate) && this.ub.ta != null) {
                if (!this.ub.ta.lf()) {
                    this.ub.ta.le();
                }
            } else if (g.O(this.mAdTemplate) && this.ub.tb != null && !this.ub.tb.lf()) {
                this.ub.tb.le();
            }
            if (this.zs) {
                return;
            }
            this.zn.setText(zr[1]);
            jG();
            return;
        }
        notifyRewardVerify();
        jF();
        if (this.ub.sS != null) {
            this.ub.sS.aj(0);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void G(int i) {
        this.ub.tc = i;
        if (g.P(this.mAdTemplate)) {
            if (!this.zs) {
                this.zn.setText(String.format(zr[0], Integer.valueOf(i)));
            }
        } else {
            this.kn.setText(String.valueOf(i));
        }
        if (this.ub == null || this.ub.mAdTemplate == null || this.ub.mAdTemplate.mLiveDetailRewardFromAdLive == null) {
            return;
        }
        this.ub.mAdTemplate.mLiveDetailRewardFromAdLive.countDownSecond = i;
    }

    private void jF() {
        if (this.zq) {
            return;
        }
        this.zq = true;
        this.zo.setAlpha(0.0f);
        this.zo.setVisibility(0);
        this.zo.setOnClickListener(this);
        ValueAnimator valueAnimatorOfFloat = ValueAnimator.ofFloat(0.0f, 1.0f);
        valueAnimatorOfFloat.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.a.4
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                a.this.kn.setVisibility(8);
            }
        });
        valueAnimatorOfFloat.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.a.5
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                float fFloatValue = ((Float) valueAnimator.getAnimatedValue()).floatValue();
                a.this.kn.setAlpha(1.0f - fFloatValue);
                a.this.zo.setAlpha(fFloatValue);
            }
        });
        valueAnimatorOfFloat.start();
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.zo || view == this.zp) {
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(view.getContext()).aF(this.mAdTemplate).b(this.mApkDownloadHelper).aD(2).A(this.ub.sr.getPlayDuration()).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.reward.presenter.platdetail.a.a.6
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    a.this.notifyAdClick();
                }
            }));
        }
    }

    private void notifyRewardVerify() {
        this.ub.sq.onRewardVerify();
        if (this.ub == null || this.ub.mAdTemplate == null || this.ub.mAdTemplate.mLiveDetailRewardFromAdLive == null) {
            return;
        }
        this.ub.mAdTemplate.mLiveDetailRewardFromAdLive.success = true;
    }

    private void jG() {
        if (this.ub.mAdRewardStepListener != null) {
            this.ub.mAdRewardStepListener.gz();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void notifyAdClick() {
        com.kwad.components.ad.reward.j.b.a(this.mAdTemplate, "native_id", "playTopBar-style1", new com.kwad.sdk.core.adlog.c.b().f(this.ub.mRootContainer.getTouchCoords()).dS(41), this.ub.mReportExtData);
        this.ub.sq.cY();
    }

    @Override // com.kwad.sdk.utils.cc.a
    public final void a(Message message) {
        if (message.what == 1) {
            if (this.ub.hf() || this.ub.he()) {
                this.ca.sendEmptyMessageDelayed(1, 500L);
                return;
            }
            this.kq += 500;
            a(com.kwad.sdk.core.response.helper.a.ak(this.mAdInfo), this.kq);
            this.ca.sendEmptyMessageDelayed(1, 500L);
        }
    }
}
