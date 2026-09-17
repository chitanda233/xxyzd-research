package com.kwad.components.ad.reward.presenter;

import android.animation.Animator;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.animation.ValueAnimator;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Interpolator;
import android.widget.FrameLayout;
import android.widget.ImageView;
import androidx.core.view.animation.PathInterpolatorCompat;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.components.core.webview.jshandler.y;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class s extends b implements com.kwad.components.ad.reward.e.g, com.kwad.components.core.j.a.InterfaceC0443a, y.b {
    private List<com.kwad.components.core.j.c> bT;
    private com.kwad.components.ad.reward.d sw;
    private ImageView wo;
    private boolean xG;
    private View xp;
    private KsLogoView xq;
    private DetailVideoView xr;
    private int xs;
    private View xt;
    private FrameLayout xu;
    private Animator xv;
    private Animator xw;
    private Animator xx;
    private AdTemplate xy;
    private int xo = 1;
    private long xz = 500;
    private long xA = 50;
    private float xB = 1.2254902f;
    private float xC = 0.80472106f;
    private float xD = 0.0f;
    private boolean xE = false;
    private long showTime = -1;
    private long xF = -1;
    private com.kwad.components.core.video.m jX = new com.kwad.components.core.video.m() { // from class: com.kwad.components.ad.reward.presenter.s.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            s.this.k(j2);
        }
    };
    private com.kwad.sdk.core.webview.d.a.a fg = new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.reward.presenter.s.5
        @Override // com.kwad.sdk.core.webview.d.a.a
        public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
            if (aVar != null && !com.kwad.sdk.core.response.helper.e.b(s.this.mAdTemplate, aVar.creativeId, aVar.adStyle)) {
                com.kwad.components.core.j.c cVarA = com.kwad.components.ad.reward.g.a((List<com.kwad.components.core.j.c>) s.this.bT, aVar.creativeId);
                if (cVarA != null) {
                    s.this.ub.a(cVarA);
                    return;
                }
                return;
            }
            s.this.ub.sq.cY();
        }
    };

    @Override // com.kwad.components.ad.reward.e.g
    public final int getPriority() {
        return 0;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void k(long j) {
        AdTemplate adTemplate = this.xy;
        if (adTemplate == null || this.xG) {
            return;
        }
        if (this.showTime <= 0) {
            this.showTime = com.kwad.sdk.core.response.helper.b.cW(adTemplate);
            this.xF = com.kwad.sdk.core.response.helper.b.cV(this.xy) + this.showTime;
        }
        long j2 = this.showTime;
        if (j2 > 0 && !this.xE && j > j2) {
            this.xG = !K(true);
            com.kwad.sdk.core.d.c.d("RewardPreEndCardPresenter", "showError: " + this.xG);
            if (this.xG) {
                return;
            } else {
                this.xE = true;
            }
        }
        boolean z = this.xo == 3;
        long j3 = this.xF;
        if (j3 <= 0 || z || j <= j3) {
            return;
        }
        L(true);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.xp = findViewById(R.id.ksad_middle_end_card);
        this.xr = (DetailVideoView) findViewById(R.id.ksad_video_player);
        this.xq = (KsLogoView) findViewById(R.id.ksad_splash_logo_container);
        this.wo = (ImageView) findViewById(R.id.ksad_blur_video_cover);
        this.xt = findViewById(R.id.ksad_play_web_card_webView);
        this.xu = (FrameLayout) findViewById(R.id.ksad_middle_end_card_webview_container);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ub.sr.a(this.jX);
        this.ub.b((com.kwad.components.ad.reward.e.g) this);
        this.ub.a(this);
        this.xs = com.kwad.sdk.c.a.a.M(this.xr);
        com.kwad.sdk.c.a.a.q(this.xr, 49);
        this.xq.bh(this.mAdTemplate);
    }

    private void f(List<AdTemplate> list) {
        this.sw = new com.kwad.components.ad.reward.d(list, this.ub.mReportExtData, this);
        this.ub.sw = this.sw;
        this.sw.setShowLandingPage(com.kwad.sdk.core.response.helper.b.cZ(this.mAdTemplate));
        this.sw.a(this.fg);
        this.sw.a(this.xu, this.ub.mRootContainer, this.mAdTemplate, this.ub.mApkDownloadHelper, this.ub.mScreenOrientation);
        com.kwad.sdk.core.d.c.d("RewardPreEndCardPresenter", "startPreloadWebView");
        this.sw.a(new com.kwad.components.ad.l.b.InterfaceC0383b() { // from class: com.kwad.components.ad.reward.presenter.s.2
            @Override // com.kwad.components.ad.l.b.InterfaceC0383b
            public final void je() {
                com.kwad.sdk.core.d.c.d("RewardPreEndCardPresenter", "onPreloadSuccess");
                s.this.ub.sZ = true;
            }
        });
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sZ = false;
        this.ub.sr.b(this.jX);
        this.ub.c(this);
        this.ub.b((com.kwad.components.core.j.a.InterfaceC0443a) this);
        com.kwad.components.ad.reward.d dVar = this.sw;
        if (dVar != null) {
            dVar.ob();
        }
        Animator animator = this.xx;
        if (animator != null) {
            animator.cancel();
        }
        DetailVideoView detailVideoView = this.xr;
        if (detailVideoView != null) {
            com.kwad.sdk.c.a.a.q(detailVideoView, this.xs);
        }
        Animator animator2 = this.xv;
        if (animator2 != null) {
            animator2.cancel();
        }
        this.xx = null;
        this.xv = null;
    }

    private boolean K(boolean z) {
        int iB = b(jc());
        ab(iB);
        com.kwad.components.ad.reward.d dVar = this.sw;
        boolean zAY = dVar != null ? dVar.aY() : false;
        com.kwad.sdk.core.d.c.d("RewardPreEndCardPresenter", "webLoadSuccess: " + zAY);
        if (!zAY) {
            return false;
        }
        int iA = a(jc());
        float f = -iB;
        this.xD = f;
        Animator animatorA = a(true, f, iA, true, z);
        this.xv = animatorA;
        animatorA.start();
        Animator animatorJb = jb();
        this.xx = animatorJb;
        animatorJb.start();
        this.xo = 2;
        return true;
    }

    private void ab(int i) {
        ViewGroup.LayoutParams layoutParams = this.xp.getLayoutParams();
        if (layoutParams instanceof FrameLayout.LayoutParams) {
            FrameLayout.LayoutParams layoutParams2 = (FrameLayout.LayoutParams) layoutParams;
            layoutParams2.height = i;
            layoutParams2.bottomMargin = -i;
        } else {
            FrameLayout.LayoutParams layoutParams3 = new FrameLayout.LayoutParams(-1, i);
            layoutParams3.height = i;
            layoutParams3.bottomMargin = -i;
            this.xp.setLayoutParams(layoutParams3);
        }
    }

    private void L(boolean z) {
        Animator animatorA = a(false, (jc() - jd()) + this.xD, a(jd()), false, z);
        this.xw = animatorA;
        animatorA.start();
        com.kwad.sdk.core.local.a.Mj();
        com.kwad.sdk.core.local.a.cB(this.xy);
        this.xo = 3;
        com.kwad.components.ad.reward.d dVar = this.sw;
        if (dVar != null) {
            dVar.gE();
        }
    }

    private Animator jb() {
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(this.xt, "alpha", 255.0f, 0.0f);
        objectAnimatorOfFloat.setInterpolator(PathInterpolatorCompat.create(0.25f, 0.1f, 0.25f, 1.0f));
        objectAnimatorOfFloat.setDuration(200L);
        return objectAnimatorOfFloat;
    }

    private Animator a(boolean z, float f, int i, boolean z2, boolean z3) {
        ValueAnimator valueAnimatorOfFloat;
        com.kwad.sdk.core.d.c.d("RewardPreEndCardPresenter", "getUpAnimator: translationY0: " + f + ", videoTargetHeight: " + i);
        if (z) {
            valueAnimatorOfFloat = ObjectAnimator.ofFloat(this.xp, "translationY", f);
        } else {
            int height = this.xp.getHeight();
            final ViewGroup.LayoutParams layoutParams = this.xp.getLayoutParams();
            valueAnimatorOfFloat = ValueAnimator.ofFloat(height, Math.abs(f));
            valueAnimatorOfFloat.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.reward.presenter.s.3
                @Override // android.animation.ValueAnimator.AnimatorUpdateListener
                public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                    layoutParams.height = (int) ((Float) valueAnimator.getAnimatedValue()).floatValue();
                    s.this.xp.setLayoutParams(layoutParams);
                }
            });
        }
        ObjectAnimator objectAnimatorOfFloat = z2 ? ObjectAnimator.ofFloat(this.xq, "alpha", 0.0f, 255.0f) : null;
        final ViewGroup.LayoutParams layoutParams2 = this.wo.getLayoutParams();
        ValueAnimator valueAnimatorA = this.xr.a(this.mAdTemplate, i, new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.reward.presenter.s.4
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                int iIntValue = ((Integer) valueAnimator.getAnimatedValue()).intValue();
                ViewGroup.LayoutParams layoutParams3 = layoutParams2;
                if (layoutParams3 != null) {
                    layoutParams3.height = iIntValue;
                    s.this.wo.setLayoutParams(layoutParams2);
                }
            }
        });
        long j = z3 ? this.xz : this.xA;
        Interpolator interpolatorCreate = PathInterpolatorCompat.create(0.0f, 0.0f, 0.58f, 1.0f);
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.setDuration(j);
        animatorSet.setInterpolator(interpolatorCreate);
        if (objectAnimatorOfFloat != null) {
            if (z3) {
                animatorSet.playTogether(valueAnimatorOfFloat, objectAnimatorOfFloat, valueAnimatorA);
            } else {
                animatorSet.playTogether(valueAnimatorOfFloat, objectAnimatorOfFloat);
            }
        } else if (z3) {
            animatorSet.playTogether(valueAnimatorOfFloat, valueAnimatorA);
        } else {
            animatorSet.playTogether(valueAnimatorOfFloat);
        }
        return animatorSet;
    }

    private int a(float f) {
        return (int) (com.kwad.sdk.c.a.a.k(getActivity()) - f);
    }

    private int b(float f) {
        return (int) (f + getContext().getResources().getDimensionPixelSize(R.dimen.ksad_reward_middle_end_card_logo_view_height) + getContext().getResources().getDimensionPixelSize(R.dimen.ksad_reward_middle_end_card_logo_view_margin_bottom));
    }

    private float jc() {
        return com.kwad.sdk.c.a.a.j(getActivity()) / this.xB;
    }

    private float jd() {
        return com.kwad.sdk.c.a.a.j(getActivity()) / this.xC;
    }

    @Override // com.kwad.components.core.j.a.InterfaceC0443a
    public final void onError(int i, String str) {
        com.kwad.sdk.core.d.c.w("RewardPreEndCardPresenter", "onError : msg " + str);
    }

    @Override // com.kwad.components.core.j.a.InterfaceC0443a
    public final void onRequestResult(int i) {
        com.kwad.sdk.core.d.c.w("RewardPreEndCardPresenter", "onRequestResult : adNumber " + i);
    }

    @Override // com.kwad.components.core.j.a.InterfaceC0443a
    public final void e(List<com.kwad.components.core.j.c> list) {
        com.kwad.sdk.core.d.c.d("RewardPreEndCardPresenter", "onInnerAdLoad: " + list);
        if (list == null || list.size() == 0) {
            return;
        }
        this.xy = list.get(0).getAdTemplate();
        this.bT = list;
        ArrayList arrayList = new ArrayList();
        arrayList.add(this.mAdTemplate);
        arrayList.addAll(com.kwad.components.core.j.c.q(list));
        f(arrayList);
    }

    @Override // com.kwad.components.core.webview.jshandler.y.b
    public final void W(AdTemplate adTemplate) {
        com.kwad.components.core.j.c cVar = new com.kwad.components.core.j.c(adTemplate, com.kwad.components.core.j.e.AGGREGATION);
        if (this.ub != null) {
            this.ub.b(cVar);
        }
    }

    @Override // com.kwad.components.ad.reward.e.g
    public final void cZ() {
        int i;
        if (this.xy == null || (i = this.xo) == 3) {
            return;
        }
        if (i == 1) {
            K(false);
            L(false);
        } else if (i == 2) {
            L(true);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // java.lang.Comparable
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public int compareTo(com.kwad.components.ad.reward.e.g gVar) {
        return getPriority() - gVar.getPriority();
    }
}
