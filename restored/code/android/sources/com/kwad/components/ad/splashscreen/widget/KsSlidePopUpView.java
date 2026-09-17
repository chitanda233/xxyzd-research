package com.kwad.components.ad.splashscreen.widget;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.content.Context;
import android.content.res.TypedArray;
import android.util.AttributeSet;
import android.view.View;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.bi;

/* JADX INFO: loaded from: classes3.dex */
public class KsSlidePopUpView extends c {
    private ImageView LX;
    private int LY;

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected int getAnimationDelayTime() {
        return 500;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected View getInteractionView() {
        return this;
    }

    public KsSlidePopUpView(Context context) {
        super(context);
    }

    public KsSlidePopUpView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
    }

    public KsSlidePopUpView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void a(Context context, AttributeSet attributeSet, int i) {
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_KsShakeView, i, 0);
        this.LY = typedArrayObtainStyledAttributes.getResourceId(R.styleable.ksad_KsShakeView_ksad_shakeIcon, R.drawable.ksad_splash_slide_square_bg);
        typedArrayObtainStyledAttributes.recycle();
        this.LX = new ImageView(context);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
        this.LX.setScaleType(ImageView.ScaleType.FIT_XY);
        addView(this.LX, layoutParams);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void nX() {
        ImageView imageView = this.LX;
        if (imageView != null) {
            imageView.setImageResource(this.LY);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final Animator fX() {
        View interactionView = getInteractionView();
        if (interactionView == null) {
            return null;
        }
        AnimatorSet animatorSet = new AnimatorSet();
        float fA = com.kwad.sdk.c.a.a.a(getContext(), -60.0f);
        float fA2 = com.kwad.sdk.c.a.a.a(getContext(), -68.0f);
        animatorSet.playSequentially(ObjectAnimator.ofFloat(interactionView, "translationY", fA, fA2).setDuration(200L), ObjectAnimator.ofFloat(interactionView, "translationY", fA2, fA).setDuration(200L), ObjectAnimator.ofFloat(interactionView, "translationY", fA, fA2).setDuration(200L), ObjectAnimator.ofFloat(interactionView, "translationY", fA2, fA).setDuration(200L));
        return animatorSet;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void nY() {
        getInteractionView().setTranslationY(0.0f);
    }

    public final void oc() {
        View interactionView = getInteractionView();
        if (interactionView == null) {
            return;
        }
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.playTogether(ObjectAnimator.ofFloat(interactionView, "translationY", 0.0f, com.kwad.sdk.c.a.a.a(getContext(), -60.0f)).setDuration(300L), ObjectAnimator.ofFloat(interactionView, "alpha", 0.0f, 1.0f).setDuration(300L));
        animatorSet.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.splashscreen.widget.KsSlidePopUpView.1
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                KsSlidePopUpView.this.getInteractionView().postDelayed(new bi() { // from class: com.kwad.components.ad.splashscreen.widget.KsSlidePopUpView.1.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        KsSlidePopUpView.this.fW();
                    }
                }, KsSlidePopUpView.this.getAnimationDelayTime());
            }

            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationCancel(Animator animator) {
                super.onAnimationCancel(animator);
                KsSlidePopUpView.this.nY();
            }
        });
        animatorSet.start();
    }
}
