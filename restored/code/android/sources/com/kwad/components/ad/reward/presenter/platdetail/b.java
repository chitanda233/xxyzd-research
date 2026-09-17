package com.kwad.components.ad.reward.presenter.platdetail;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.graphics.Color;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Interpolator;
import android.widget.FrameLayout;
import android.widget.ImageView;
import androidx.core.view.animation.PathInterpolatorCompat;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.bo;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.reward.presenter.b {
    private View ym;
    private View yn;
    private View yo;
    private View yp;
    private Animator ys;
    private Animator yt;
    private Animator yu;
    private bo yx;
    private bo yy;
    private final long yj = 1600;
    private final long yk = com.alipay.sdk.m.y.c.f378a;
    private final long yl = 5000;
    private boolean yq = false;
    private boolean yr = false;
    private Animator yv = null;
    private long yw = com.alipay.sdk.m.y.c.f378a;
    private Interpolator yz = PathInterpolatorCompat.create(0.0f, 0.0f, 0.58f, 1.0f);
    private m jX = new m() { // from class: com.kwad.components.ad.reward.presenter.platdetail.b.1
        private boolean yA = false;

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            super.onMediaPlayStart();
            b.this.yq = false;
            com.kwad.sdk.core.d.c.d("RewardImagePlayerPresenter", "onMediaPlayStart : ");
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            if (j2 < b.this.yw || this.yA) {
                return;
            }
            this.yA = true;
            b.this.jo();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayPaused() {
            super.onMediaPlayPaused();
            b.this.yq = true;
            com.kwad.sdk.core.d.c.d("RewardImagePlayerPresenter", "onMediaPlayPaused : ");
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlaying() {
            super.onMediaPlaying();
            b.this.yq = false;
            com.kwad.sdk.core.d.c.d("RewardImagePlayerPresenter", "onMediaPlaying : ");
            if (b.this.yv == null || b.this.yv.isRunning()) {
                return;
            }
            b.this.yv.start();
            b.a(b.this, (Animator) null);
        }
    };

    static /* synthetic */ Animator a(b bVar, Animator animator) {
        bVar.yv = null;
        return null;
    }

    static /* synthetic */ View b(b bVar, View view) {
        bVar.yn = null;
        return null;
    }

    static /* synthetic */ boolean b(b bVar, boolean z) {
        bVar.yr = true;
        return true;
    }

    static /* synthetic */ View c(b bVar, View view) {
        bVar.yo = null;
        return null;
    }

    static /* synthetic */ View d(b bVar, View view) {
        bVar.yp = null;
        return null;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        jm();
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ub.sr.a(this.jX);
        FrameLayout frameLayoutT = this.ub.sr.ls().T(getContext());
        this.ym = frameLayoutT;
        if (frameLayoutT.getParent() != null) {
            return;
        }
        ((FrameLayout) findViewById(R.id.ksad_reward_play_layout)).addView(this.ym, -1, -1);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -2);
        layoutParams.gravity = 81;
        layoutParams.bottomMargin = -this.yx.getHeight();
        FrameLayout frameLayout = (FrameLayout) findViewById(R.id.ksad_root_container);
        View viewJn = jn();
        this.yn = viewJn;
        frameLayout.addView(viewJn, -1, -1);
        View viewA = a(R.drawable.ksad_image_player_sweep1, frameLayout);
        this.yo = viewA;
        frameLayout.addView(viewA, layoutParams);
        View viewA2 = a(R.drawable.ksad_image_player_sweep2, frameLayout);
        this.yp = viewA2;
        frameLayout.addView(viewA2, layoutParams);
    }

    private void jm() {
        this.yx = new bo(getContext().getResources().getDimensionPixelSize(R.dimen.ksad_image_player_sweep_wave_width_start), getContext().getResources().getDimensionPixelSize(R.dimen.ksad_image_player_sweep_wave_height_start));
        this.yy = new bo(getContext().getResources().getDimensionPixelSize(R.dimen.ksad_image_player_sweep_wave_width_end), getContext().getResources().getDimensionPixelSize(R.dimen.ksad_image_player_sweep_wave_height_end));
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.yq = true;
        Animator animator = this.yt;
        if (animator != null) {
            animator.cancel();
        }
        Animator animator2 = this.ys;
        if (animator2 != null) {
            animator2.cancel();
        }
        Animator animator3 = this.yu;
        if (animator3 != null) {
            animator3.cancel();
        }
        this.ub.sr.b(this.jX);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        this.ym = null;
        com.kwad.components.ad.reward.m.b bVarLs = this.ub.sr.ls();
        if (bVarLs != null) {
            bVarLs.release();
        }
    }

    private View jn() {
        ImageView imageView = new ImageView(getContext());
        imageView.setClickable(false);
        imageView.setFocusable(false);
        imageView.setFocusableInTouchMode(false);
        imageView.setLongClickable(false);
        imageView.setBackgroundColor(Color.parseColor("#222222"));
        imageView.setAlpha(0.2f);
        return imageView;
    }

    private View a(int i, ViewGroup viewGroup) {
        ImageView imageView = (ImageView) LayoutInflater.from(getContext()).inflate(R.layout.ksad_image_player_sweep, viewGroup, false);
        imageView.setImageDrawable(getContext().getResources().getDrawable(i));
        return imageView;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void jo() {
        this.ys = b(this.ym, 1600L);
        this.yt = a(this.yo, this.yp);
        this.yu = c(this.ym, 1600L);
        this.ys.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.platdetail.b.2
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                b.q(b.this.yn);
                b.b(b.this, (View) null);
                if (b.this.yr) {
                    return;
                }
                b bVar = b.this;
                bVar.a(bVar.yt);
            }
        });
        this.yt.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.platdetail.b.3
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationStart(Animator animator) {
                super.onAnimationStart(animator);
                b.b(b.this, true);
            }

            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                b bVar = b.this;
                bVar.a(bVar.yu);
                b.q(b.this.yo);
                b.q(b.this.yp);
                b.c(b.this, (View) null);
                b.d(b.this, null);
            }
        });
        this.yu.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.platdetail.b.4
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                b bVar = b.this;
                bVar.a(bVar.yu);
            }
        });
        a(this.ys);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(Animator animator) {
        if (!this.yq) {
            animator.start();
        } else {
            this.yv = animator;
        }
    }

    private Animator a(View view, View view2) {
        Animator animatorP = p(view);
        Animator animatorP2 = p(view2);
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(view2, "scaleX", 1.0f);
        objectAnimatorOfFloat.setDuration(300L);
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.playSequentially(objectAnimatorOfFloat, animatorP2);
        AnimatorSet animatorSet2 = new AnimatorSet();
        animatorSet2.playTogether(animatorP, animatorSet);
        return animatorSet2;
    }

    private Animator p(View view) {
        if (this.yx == null || this.yy == null) {
            jm();
        }
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(view, "translationY", -(com.kwad.sdk.c.a.a.getScreenHeight(getContext()) + ((this.yy.getHeight() + this.yx.getHeight()) / 2)));
        float fWF = this.yy.WF() / this.yx.WF();
        float fWG = this.yy.WG() / this.yx.WG();
        ObjectAnimator objectAnimatorOfFloat2 = ObjectAnimator.ofFloat(view, "scaleX", 1.0f, fWF);
        ObjectAnimator objectAnimatorOfFloat3 = ObjectAnimator.ofFloat(view, "scaleY", 1.0f, fWG);
        ObjectAnimator objectAnimatorOfFloat4 = ObjectAnimator.ofFloat(view, "alpha", 1.0f, 0.8f);
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.setDuration(com.alipay.sdk.m.y.c.f378a);
        animatorSet.playTogether(objectAnimatorOfFloat2, objectAnimatorOfFloat3, objectAnimatorOfFloat, objectAnimatorOfFloat4);
        animatorSet.setInterpolator(this.yz);
        return animatorSet;
    }

    private Animator b(View view, long j) {
        float[] fArr = {1.0f, 1.106f, 1.0f, 1.106f, 1.0f};
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(view, "scaleX", fArr);
        ObjectAnimator objectAnimatorOfFloat2 = ObjectAnimator.ofFloat(view, "scaleY", fArr);
        AnimatorSet animatorSet = new AnimatorSet();
        View view2 = this.yn;
        if (view2 != null) {
            animatorSet.playTogether(objectAnimatorOfFloat, objectAnimatorOfFloat2, ObjectAnimator.ofFloat(view2, "alpha", 0.2f, 0.0f));
        } else {
            animatorSet.playTogether(objectAnimatorOfFloat, objectAnimatorOfFloat2);
        }
        animatorSet.setDuration(j);
        animatorSet.setInterpolator(this.yz);
        return animatorSet;
    }

    private Animator c(View view, long j) {
        Animator animatorB = b(view, 1600L);
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(view, "alpha", 1.0f);
        objectAnimatorOfFloat.setDuration(5000L);
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.playSequentially(animatorB, objectAnimatorOfFloat);
        animatorSet.setDuration(1600L);
        return animatorSet;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void q(View view) {
        if (view != null) {
            try {
                if (view.getParent() != null) {
                    ((ViewGroup) view.getParent()).removeView(view);
                }
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            }
        }
    }
}
