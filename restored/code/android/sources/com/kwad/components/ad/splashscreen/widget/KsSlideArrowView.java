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
public class KsSlideArrowView extends c {
    private ImageView LO;
    private int LP;
    private int LQ;

    public KsSlideArrowView(Context context) {
        super(context);
        this.LQ = 0;
    }

    public KsSlideArrowView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.LQ = 0;
    }

    public KsSlideArrowView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.LQ = 0;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void a(Context context, AttributeSet attributeSet, int i) {
        TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeSet, R.styleable.ksad_KsShakeView, i, 0);
        this.LP = typedArrayObtainStyledAttributes.getResourceId(R.styleable.ksad_KsShakeView_ksad_shakeIcon, R.drawable.ksad_splash_slide_tag);
        typedArrayObtainStyledAttributes.recycle();
        this.LO = new ImageView(context);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, -1);
        this.LO.setScaleType(ImageView.ScaleType.FIT_XY);
        this.LO.setAlpha(0.0f);
        addView(this.LO, layoutParams);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void nX() {
        ImageView imageView = this.LO;
        if (imageView != null) {
            imageView.setImageResource(this.LP);
        }
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final Animator fX() {
        View interactionView = getInteractionView();
        if (interactionView == null) {
            return null;
        }
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.playSequentially(ObjectAnimator.ofFloat(interactionView, "alpha", 0.0f, 1.0f).setDuration(200L), ObjectAnimator.ofFloat(interactionView, "alpha", 1.0f, 1.0f).setDuration(200L), ObjectAnimator.ofFloat(interactionView, "alpha", 1.0f, 0.0f).setDuration(200L), ObjectAnimator.ofFloat(interactionView, "alpha", 0.0f, 0.0f).setDuration(200L));
        return animatorSet;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void nY() {
        getInteractionView().setAlpha(1.0f);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected View getInteractionView() {
        return this.LO;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected int getAnimationDelayTime() {
        return this.LQ;
    }

    public void setAnimationDelayTime(int i) {
        this.LQ = i;
    }
}
