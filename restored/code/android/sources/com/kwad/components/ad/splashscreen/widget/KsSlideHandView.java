package com.kwad.components.ad.splashscreen.widget;

import android.animation.Animator;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public class KsSlideHandView extends c {
    private ImageView LR;
    private ImageView LS;
    private ImageView LT;
    private ImageView LU;
    private ImageView LV;
    private ImageView LW;

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected int getAnimationDelayTime() {
        return 0;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected View getInteractionView() {
        return this;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void nX() {
    }

    public KsSlideHandView(Context context) {
        super(context);
    }

    public KsSlideHandView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
    }

    public KsSlideHandView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void a(Context context, AttributeSet attributeSet, int i) {
        this.LS = new ImageView(context);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(com.kwad.sdk.c.a.a.a(context, 206.0f), com.kwad.sdk.c.a.a.a(context, 120.0f));
        this.LS.setImageResource(R.drawable.ksad_splash_base_arrows);
        layoutParams.gravity = 17;
        addView(this.LS, layoutParams);
        this.LV = new ImageView(context);
        FrameLayout.LayoutParams layoutParams2 = new FrameLayout.LayoutParams(com.kwad.sdk.c.a.a.a(context, 206.0f), com.kwad.sdk.c.a.a.a(context, 120.0f));
        this.LV.setImageResource(R.drawable.ksad_splash_up_highlight_arrow);
        this.LV.setAlpha(0.0f);
        layoutParams2.gravity = 17;
        addView(this.LV, layoutParams2);
        this.LU = new ImageView(context);
        FrameLayout.LayoutParams layoutParams3 = new FrameLayout.LayoutParams(com.kwad.sdk.c.a.a.a(context, 206.0f), com.kwad.sdk.c.a.a.a(context, 120.0f));
        this.LU.setImageResource(R.drawable.ksad_splash_right_highlight_arrow);
        this.LU.setAlpha(0.0f);
        layoutParams3.gravity = 17;
        addView(this.LU, layoutParams3);
        this.LW = new ImageView(context);
        FrameLayout.LayoutParams layoutParams4 = new FrameLayout.LayoutParams(com.kwad.sdk.c.a.a.a(context, 206.0f), com.kwad.sdk.c.a.a.a(context, 120.0f));
        this.LW.setImageResource(R.drawable.ksad_splash_down_highlight_arrow);
        this.LW.setAlpha(0.0f);
        layoutParams4.gravity = 17;
        addView(this.LW, layoutParams4);
        this.LT = new ImageView(context);
        FrameLayout.LayoutParams layoutParams5 = new FrameLayout.LayoutParams(com.kwad.sdk.c.a.a.a(context, 206.0f), com.kwad.sdk.c.a.a.a(context, 120.0f));
        this.LT.setImageResource(R.drawable.ksad_splash_left_highlight_arrow);
        this.LT.setAlpha(0.0f);
        layoutParams5.gravity = 17;
        addView(this.LT, layoutParams5);
        this.LR = new ImageView(context);
        FrameLayout.LayoutParams layoutParams6 = new FrameLayout.LayoutParams(com.kwad.sdk.c.a.a.a(context, 100.0f), com.kwad.sdk.c.a.a.a(context, 162.0f));
        this.LR.setImageResource(R.drawable.ksad_splash_slide_animation_hand);
        layoutParams6.leftMargin = com.kwad.sdk.c.a.a.a(context, 149.0f);
        layoutParams6.bottomMargin = com.kwad.sdk.c.a.a.a(context, -19.0f);
        layoutParams6.gravity = 83;
        addView(this.LR, layoutParams6);
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final Animator fX() {
        AnimatorSet animatorSet = new AnimatorSet();
        ObjectAnimator duration = ObjectAnimator.ofFloat(this.LR, "alpha", 0.0f, 0.0f).setDuration(50L);
        ObjectAnimator duration2 = ObjectAnimator.ofFloat(this.LR, "alpha", 1.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration3 = ObjectAnimator.ofFloat(this.LV, "alpha", 0.0f, 1.0f).setDuration(450L);
        ObjectAnimator duration4 = ObjectAnimator.ofFloat(this.LR, "translationY", com.kwad.sdk.c.a.a.a(getContext(), -73.0f)).setDuration(450L);
        ObjectAnimator duration5 = ObjectAnimator.ofFloat(this.LV, "alpha", 1.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration6 = ObjectAnimator.ofFloat(this.LV, "alpha", 1.0f, 0.0f).setDuration(450L);
        ObjectAnimator duration7 = ObjectAnimator.ofFloat(this.LR, "alpha", 1.0f, 0.0f).setDuration(450L);
        ObjectAnimator duration8 = ObjectAnimator.ofFloat(this.LR, "translationY", com.kwad.sdk.c.a.a.a(getContext(), 0.0f)).setDuration(50L);
        ObjectAnimator duration9 = ObjectAnimator.ofFloat(this.LR, "alpha", 0.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration10 = ObjectAnimator.ofFloat(this.LR, "alpha", 1.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration11 = ObjectAnimator.ofFloat(this.LU, "alpha", 0.0f, 1.0f).setDuration(450L);
        ObjectAnimator duration12 = ObjectAnimator.ofFloat(this.LR, "translationX", com.kwad.sdk.c.a.a.a(getContext(), 85.0f)).setDuration(450L);
        ObjectAnimator duration13 = ObjectAnimator.ofFloat(this.LU, "alpha", 1.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration14 = ObjectAnimator.ofFloat(this.LU, "alpha", 1.0f, 0.0f).setDuration(450L);
        ObjectAnimator duration15 = ObjectAnimator.ofFloat(this.LR, "alpha", 1.0f, 0.0f).setDuration(450L);
        ObjectAnimator duration16 = ObjectAnimator.ofFloat(this.LR, "translationX", com.kwad.sdk.c.a.a.a(getContext(), 0.0f)).setDuration(50L);
        ObjectAnimator duration17 = ObjectAnimator.ofFloat(this.LR, "alpha", 0.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration18 = ObjectAnimator.ofFloat(this.LR, "alpha", 1.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration19 = ObjectAnimator.ofFloat(this.LW, "alpha", 0.0f, 1.0f).setDuration(450L);
        ObjectAnimator duration20 = ObjectAnimator.ofFloat(this.LR, "translationY", com.kwad.sdk.c.a.a.a(getContext(), 60.0f)).setDuration(450L);
        ObjectAnimator duration21 = ObjectAnimator.ofFloat(this.LW, "alpha", 1.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration22 = ObjectAnimator.ofFloat(this.LW, "alpha", 1.0f, 0.0f).setDuration(450L);
        ObjectAnimator duration23 = ObjectAnimator.ofFloat(this.LR, "alpha", 1.0f, 0.0f).setDuration(450L);
        ObjectAnimator duration24 = ObjectAnimator.ofFloat(this.LR, "translationY", com.kwad.sdk.c.a.a.a(getContext(), 0.0f)).setDuration(50L);
        ObjectAnimator duration25 = ObjectAnimator.ofFloat(this.LR, "alpha", 0.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration26 = ObjectAnimator.ofFloat(this.LR, "alpha", 1.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration27 = ObjectAnimator.ofFloat(this.LT, "alpha", 0.0f, 1.0f).setDuration(450L);
        ObjectAnimator duration28 = ObjectAnimator.ofFloat(this.LR, "translationX", com.kwad.sdk.c.a.a.a(getContext(), -120.0f)).setDuration(450L);
        ObjectAnimator duration29 = ObjectAnimator.ofFloat(this.LT, "alpha", 1.0f, 1.0f).setDuration(100L);
        ObjectAnimator duration30 = ObjectAnimator.ofFloat(this.LT, "alpha", 1.0f, 0.0f).setDuration(450L);
        ObjectAnimator duration31 = ObjectAnimator.ofFloat(this.LR, "alpha", 1.0f, 0.0f).setDuration(450L);
        ObjectAnimator duration32 = ObjectAnimator.ofFloat(this.LR, "translationX", com.kwad.sdk.c.a.a.a(getContext(), 0.0f)).setDuration(50L);
        animatorSet.play(duration2).before(duration3);
        animatorSet.play(duration3).with(duration4).before(duration5).before(duration6);
        animatorSet.play(duration6).with(duration7).before(duration8);
        animatorSet.play(duration8).with(duration).before(duration9).before(duration10).before(duration11);
        animatorSet.play(duration11).with(duration12).before(duration13).before(duration14);
        animatorSet.play(duration14).with(duration15).before(duration16);
        animatorSet.play(duration16).with(duration).before(duration17).before(duration18).before(duration19);
        animatorSet.play(duration19).with(duration20).before(duration21).before(duration22);
        animatorSet.play(duration22).with(duration23).before(duration24);
        animatorSet.play(duration24).with(duration).before(duration25).before(duration26).before(duration27);
        animatorSet.play(duration27).with(duration28).before(duration29).before(duration30);
        animatorSet.play(duration30).with(duration31).before(duration32);
        animatorSet.play(duration32).with(duration);
        return animatorSet;
    }

    @Override // com.kwad.components.ad.splashscreen.widget.c
    protected final void nY() {
        this.LS.setAlpha(0.0f);
        this.LV.setAlpha(0.0f);
        this.LU.setAlpha(0.0f);
        this.LW.setAlpha(0.0f);
        this.LT.setAlpha(0.0f);
        this.LR.setAlpha(0.0f);
    }
}
