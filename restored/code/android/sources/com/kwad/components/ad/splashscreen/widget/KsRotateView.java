package com.kwad.components.ad.splashscreen.widget;

import android.animation.Animator;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.content.Context;
import android.content.res.TypedArray;
import android.util.AttributeSet;
import android.view.View;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public class KsRotateView extends c {
    private static int LA = -25;
    private static int LB = 12;
    private static int LC = 25;
    private static int Ly = 50;
    private static int Lz = -12;
    private int Lx;
    private ImageView ix;
    private ImageView qQ;

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected int getAnimationDelayTime() {
        return 500;
    }

    public KsRotateView(Context context) {
        super(context);
    }

    public KsRotateView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
    }

    public KsRotateView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void a(Context context, AttributeSet attributeSet, int i) {
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_KsShakeView, i, 0);
        this.Lx = typedArrayObtainStyledAttributes.getResourceId(R.styleable.ksad_KsShakeView_ksad_shakeIcon, R.drawable.ksad_ic_rotate_phone);
        typedArrayObtainStyledAttributes.recycle();
        ImageView imageView = new ImageView(getContext());
        this.qQ = imageView;
        imageView.setImageResource(R.drawable.ksad_ic_rotate_line);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-2, -2);
        layoutParams.gravity = 49;
        addView(this.qQ, layoutParams);
        this.ix = new ImageView(getContext());
        FrameLayout.LayoutParams layoutParams2 = new FrameLayout.LayoutParams(-2, -2);
        layoutParams2.topMargin = com.kwad.sdk.c.a.a.a(context, 22.0f);
        layoutParams2.gravity = 1;
        addView(this.ix, layoutParams2);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void nX() {
        this.ix.setImageResource(this.Lx);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final Animator fX() {
        View interactionView = getInteractionView();
        if (interactionView == null) {
            return null;
        }
        AnimatorSet animatorSet = new AnimatorSet();
        interactionView.setPivotX(interactionView.getWidth() / 2.0f);
        interactionView.setPivotY(interactionView.getHeight() / 2.0f);
        ObjectAnimator duration = ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, 0.0f, LA).setDuration(500L);
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(interactionView, "alpha", 1.0f, 1.0f);
        objectAnimatorOfFloat.setDuration(340L);
        ObjectAnimator duration2 = ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, LA, 0.0f).setDuration(Ly);
        ObjectAnimator duration3 = ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, 0.0f, LB).setDuration(Ly);
        ObjectAnimator duration4 = ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, LB, 0.0f).setDuration(Ly);
        ObjectAnimator duration5 = ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, 0.0f, Lz).setDuration(Ly);
        ObjectAnimator duration6 = ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, Lz, 0.0f).setDuration(Ly);
        ObjectAnimator objectAnimatorOfFloat2 = ObjectAnimator.ofFloat(interactionView, "alpha", 1.0f, 1.0f);
        objectAnimatorOfFloat2.setDuration(500L);
        ObjectAnimator duration7 = ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, 0.0f, LC).setDuration(500L);
        ObjectAnimator objectAnimatorOfFloat3 = ObjectAnimator.ofFloat(interactionView, "alpha", 1.0f, 1.0f);
        objectAnimatorOfFloat.setDuration(340L);
        animatorSet.playSequentially(duration, objectAnimatorOfFloat, duration2, duration3, duration4, duration5, duration6, objectAnimatorOfFloat2, duration7, objectAnimatorOfFloat3, ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, LC, 0.0f).setDuration(Ly), ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, 0.0f, Lz).setDuration(Ly), ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, Lz, 0.0f).setDuration(Ly), ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, 0.0f, LB).setDuration(Ly), ObjectAnimator.ofFloat(interactionView, com.sigmob.sdk.base.common.a.B, LB, 0.0f).setDuration(Ly));
        return animatorSet;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void nY() {
        getInteractionView().setRotation(0.0f);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected View getInteractionView() {
        return this.ix;
    }
}
