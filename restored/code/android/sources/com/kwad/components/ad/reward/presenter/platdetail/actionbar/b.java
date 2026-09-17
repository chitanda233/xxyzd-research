package com.kwad.components.ad.reward.presenter.platdetail.actionbar;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.ValueAnimator;
import android.content.res.Resources;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewStub;
import android.view.animation.DecelerateInterpolator;
import android.view.animation.Interpolator;
import androidx.core.view.animation.PathInterpolatorCompat;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.reward.e.g;
import com.kwad.components.ad.reward.n.h;
import com.kwad.components.ad.reward.n.r;
import com.kwad.components.ad.reward.widget.actionbar.ActionBarAppLandscape;
import com.kwad.components.ad.reward.widget.actionbar.ActionBarAppPortrait;
import com.kwad.components.ad.reward.widget.actionbar.ActionBarH5;
import com.kwad.components.core.t.x;
import com.kwad.components.core.video.m;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.as;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.reward.presenter.b {
    private ValueAnimator fk;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private RewardActionBarControl st;
    private KsLogoView wD;
    private ActionBarAppLandscape yE;
    private ActionBarAppPortrait yF;
    private ActionBarH5 yG;
    private boolean yI;
    private ViewGroup yJ;
    private ViewGroup yK;
    private ViewGroup yL;
    private h yM;
    private boolean yN;
    private boolean yH = false;
    private final m wH = new m() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.h
        public final void onLivePlayEnd() {
            super.onLivePlayEnd();
            b.this.yN = true;
            if (!com.kwad.sdk.core.response.helper.a.cY(b.this.mAdInfo) || b.this.yL == null) {
                return;
            }
            b.this.yL.setVisibility(8);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            super.onMediaPlayStart();
            b.this.yN = false;
            if (!com.kwad.sdk.core.response.helper.a.cY(b.this.mAdInfo) || b.this.yL == null) {
                return;
            }
            b.this.yL.setVisibility(0);
        }
    };
    private RewardActionBarControl.b yO = new RewardActionBarControl.b() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.4
        @Override // com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl.b
        public final void a(boolean z, a aVar) {
            b.this.yI = true;
            b.this.a(z, aVar);
        }
    };
    private g yP = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.5
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            b.this.yI = false;
            b.this.N(false);
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.wD = (KsLogoView) findViewById(R.id.ksad_ad_label_play_bar);
        this.yG = (ActionBarH5) findViewById(R.id.ksad_video_play_bar_h5);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdTemplate adTemplate = this.ub.mAdTemplate;
        this.mAdTemplate = adTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.ub.sr.a(this.wH);
        dq();
    }

    private void dq() {
        if (com.kwad.sdk.core.response.helper.a.cS(this.mAdInfo)) {
            this.yJ = (ViewGroup) findViewById(R.id.ksad_reward_jinniu_root);
        }
        this.wD.bh(this.mAdTemplate);
        this.mApkDownloadHelper = this.ub.mApkDownloadHelper;
        RewardActionBarControl rewardActionBarControl = this.ub.st;
        this.st = rewardActionBarControl;
        rewardActionBarControl.a(this.yO);
        this.ub.b(this.yP);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        RewardActionBarControl rewardActionBarControl = this.st;
        if (rewardActionBarControl != null) {
            rewardActionBarControl.a((RewardActionBarControl.b) null);
        }
        this.ub.sr.b(this.wH);
        this.ub.c(this.yP);
        bn();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(boolean z, a aVar) {
        ViewGroup viewGroup;
        if (this.yH) {
            return;
        }
        this.yH = true;
        this.wD.setVisibility(com.kwad.sdk.core.response.helper.a.cY(this.mAdInfo) ? 8 : 0);
        getContext();
        final boolean z2 = !as.VV();
        if (com.kwad.sdk.core.response.helper.a.bj(this.mAdInfo)) {
            if (this.yM == null) {
                h hVar = new h() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.6
                    @Override // com.kwad.components.ad.reward.n.h
                    public final int jt() {
                        if (z2) {
                            return R.id.ksad_common_app_card_land_stub;
                        }
                        return super.jt();
                    }
                };
                this.yM = hVar;
                hVar.a(new h.a() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.7
                    @Override // com.kwad.components.ad.reward.n.h.a
                    public final void ju() {
                        b.this.ub.a(1, b.this.getContext(), 29, 1);
                    }

                    @Override // com.kwad.components.ad.reward.n.h.a
                    public final void jv() {
                        b.this.ub.a(1, b.this.getContext(), 30, 2);
                    }

                    @Override // com.kwad.components.ad.reward.n.h.a
                    public final void jw() {
                        b.this.ub.a(1, b.this.getContext(), 31, 2);
                    }

                    @Override // com.kwad.components.ad.reward.n.h.a
                    public final void jx() {
                        b.this.ub.a(1, b.this.getContext(), 32, 2);
                    }

                    @Override // com.kwad.components.ad.reward.n.h.a
                    public final void jy() {
                        b.this.ub.a(1, b.this.getContext(), 84, 2);
                    }

                    @Override // com.kwad.components.ad.reward.n.h.a
                    public final void jz() {
                        b.this.ub.a(1, b.this.getContext(), 53, 2);
                    }
                });
                this.yM.h((ViewGroup) getRootView());
                this.yM.b(r.a(this.mAdTemplate, this.mApkDownloadHelper));
            }
            this.yM.show();
            RewardActionBarControl.a(aVar, this.yM.hZ(), RewardActionBarControl.ShowActionBarResult.SHOW_NATIVE_PLAYABLE_PORTRAIT);
            return;
        }
        if (com.kwad.sdk.core.response.helper.a.co(this.mAdInfo) == 1 && (viewGroup = this.yJ) != null) {
            viewGroup.setVisibility(0);
            RewardActionBarControl.a(aVar, this.yJ, RewardActionBarControl.ShowActionBarResult.SHOW_NATIVE_JINNIU);
            return;
        }
        if (com.kwad.sdk.core.response.helper.a.cY(this.mAdInfo)) {
            ViewGroup viewGroup2 = (ViewGroup) findViewById(R.id.ksad_reward_origin_live_root);
            this.yL = viewGroup2;
            if (viewGroup2 != null) {
                if (!this.yN) {
                    viewGroup2.setVisibility(0);
                }
                RewardActionBarControl.a(aVar, this.yL, RewardActionBarControl.ShowActionBarResult.SHOW_NATIVE_ORIGIN_LIVE);
                return;
            }
        }
        if (com.kwad.sdk.core.response.helper.a.cI(this.mAdTemplate)) {
            ViewGroup viewGroup3 = (ViewGroup) findViewById(R.id.ksad_reward_live_subscribe_root);
            this.yK = viewGroup3;
            if (viewGroup3 != null) {
                Resources resources = viewGroup3.getResources();
                f(this.yK, (int) (resources.getDimension(R.dimen.ksad_live_subscribe_card_full_height) + resources.getDimension(R.dimen.ksad_live_subscribe_card_margin)));
                RewardActionBarControl.a(aVar, this.yK, RewardActionBarControl.ShowActionBarResult.SHOW_NATIVE_LIVE_SUBSCRIBE);
                return;
            }
        }
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            if (this.ub.mScreenOrientation == 1) {
                b(z, aVar);
                return;
            } else {
                c(z, aVar);
                return;
            }
        }
        d(z, aVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void N(boolean z) {
        if (this.yH) {
            this.yH = false;
            this.wD.setVisibility(8);
            ViewGroup viewGroup = this.yJ;
            if (viewGroup != null) {
                viewGroup.setVisibility(8);
            }
            ViewGroup viewGroup2 = this.yL;
            if (viewGroup2 != null) {
                viewGroup2.setVisibility(8);
            }
            if (!com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
                if (z) {
                    h(this.yG, com.kwad.sdk.c.a.a.a(getContext(), 90.0f));
                    return;
                } else {
                    this.yG.setVisibility(8);
                    return;
                }
            }
            if (this.ub.mScreenOrientation == 1) {
                if (z) {
                    jr();
                    return;
                } else {
                    js();
                    return;
                }
            }
            if (z) {
                ActionBarAppPortrait actionBarAppPortrait = this.yF;
                if (actionBarAppPortrait != null) {
                    h(actionBarAppPortrait, com.kwad.sdk.c.a.a.a(getContext(), 90.0f));
                    return;
                }
                return;
            }
            ActionBarAppPortrait actionBarAppPortrait2 = this.yF;
            if (actionBarAppPortrait2 != null) {
                actionBarAppPortrait2.setVisibility(8);
            }
        }
    }

    private void b(boolean z, a aVar) {
        jp();
        this.yE.a(this.mAdTemplate, this.mApkDownloadHelper, new ActionBarAppLandscape.a() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.8
            @Override // com.kwad.components.ad.reward.widget.actionbar.ActionBarAppLandscape.a
            public final void P(boolean z2) {
                b.this.O(z2);
            }
        });
        if (z) {
            g(this.yE, com.kwad.sdk.c.a.a.a(getContext(), 90.0f));
        } else {
            this.yE.setVisibility(0);
        }
        RewardActionBarControl.a(aVar, this.yE, RewardActionBarControl.ShowActionBarResult.SHOW_NATIVE_DEFAULT);
    }

    private void c(boolean z, a aVar) {
        jq();
        this.yF.a(this.mAdTemplate, this.mApkDownloadHelper, new ActionBarAppPortrait.a() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.9
            @Override // com.kwad.components.ad.reward.widget.actionbar.ActionBarAppPortrait.a
            public final void P(boolean z2) {
                b.this.O(z2);
            }
        });
        if (z) {
            g(this.yF, com.kwad.sdk.c.a.a.a(getContext(), 90.0f));
        } else {
            this.yF.setVisibility(0);
        }
        RewardActionBarControl.a(aVar, this.yF, RewardActionBarControl.ShowActionBarResult.SHOW_NATIVE_DEFAULT);
    }

    private void jp() {
        ViewStub viewStub = (ViewStub) findViewById(R.id.view_stub_action_bar_landscape);
        if (viewStub != null) {
            this.yE = (ActionBarAppLandscape) viewStub.inflate();
        } else {
            this.yE = (ActionBarAppLandscape) findViewById(R.id.ksad_video_play_bar_app_landscape);
        }
    }

    private void jq() {
        ViewStub viewStub = (ViewStub) findViewById(R.id.view_stub_action_bar);
        if (viewStub != null) {
            this.yF = (ActionBarAppPortrait) viewStub.inflate();
        } else {
            this.yF = (ActionBarAppPortrait) findViewById(R.id.ksad_video_play_bar_app_portrait);
        }
    }

    private void d(boolean z, a aVar) {
        this.yG.a(this.mAdTemplate, new ActionBarH5.a() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.10
            @Override // com.kwad.components.ad.reward.widget.actionbar.ActionBarH5.a
            public final void P(boolean z2) {
                b.this.O(z2);
            }
        });
        if (z) {
            g(this.yG, com.kwad.sdk.c.a.a.a(getContext(), 90.0f));
        } else {
            this.yG.setVisibility(0);
        }
        RewardActionBarControl.a(aVar, this.yG, RewardActionBarControl.ShowActionBarResult.SHOW_NATIVE_DEFAULT);
    }

    private void f(final View view, int i) {
        bn();
        view.setVisibility(0);
        Interpolator interpolatorCreate = PathInterpolatorCompat.create(0.0f, 0.0f, 0.58f, 1.0f);
        ValueAnimator valueAnimatorC = x.c(view, i, 0);
        this.fk = valueAnimatorC;
        valueAnimatorC.setInterpolator(interpolatorCreate);
        this.fk.setDuration(500L);
        this.fk.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.11
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                view.setVisibility(0);
            }
        });
        this.fk.start();
    }

    @Deprecated
    private void g(final View view, int i) {
        bn();
        view.setVisibility(0);
        ValueAnimator valueAnimatorB = x.b(view, 0, i);
        this.fk = valueAnimatorB;
        valueAnimatorB.setInterpolator(new DecelerateInterpolator(2.0f));
        this.fk.setDuration(500L);
        this.fk.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.2
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                view.setVisibility(0);
            }
        });
        this.fk.start();
    }

    private void h(final View view, int i) {
        bn();
        view.setVisibility(0);
        ValueAnimator valueAnimatorB = x.b(view, i, 0);
        this.fk = valueAnimatorB;
        valueAnimatorB.setInterpolator(new DecelerateInterpolator(2.0f));
        this.fk.setDuration(300L);
        this.fk.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.b.3
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                view.setVisibility(8);
            }
        });
        this.fk.start();
    }

    private void jr() {
        jq();
        g(this.yF, com.kwad.sdk.c.a.a.a(getContext(), 90.0f));
    }

    private void js() {
        ActionBarAppPortrait actionBarAppPortrait = this.yF;
        if (actionBarAppPortrait != null) {
            actionBarAppPortrait.setVisibility(8);
        }
    }

    private void bn() {
        ValueAnimator valueAnimator = this.fk;
        if (valueAnimator != null) {
            valueAnimator.removeAllListeners();
            this.fk.cancel();
        }
    }

    protected final void O(boolean z) {
        com.kwad.components.ad.reward.j.b.a(this.ub.mAdTemplate, "native_id", (String) null, new com.kwad.sdk.core.adlog.c.b().f(this.ub.mRootContainer.getTouchCoords()).dS(z ? 1 : MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT), this.ub.mReportExtData);
        this.ub.sq.cY();
    }
}
