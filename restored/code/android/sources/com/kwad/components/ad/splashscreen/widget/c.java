package com.kwad.components.ad.splashscreen.widget;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.widget.KSFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public abstract class c extends KSFrameLayout {
    private Animator qM;
    private boolean qN;

    protected void a(Context context, AttributeSet attributeSet, int i) {
    }

    protected abstract Animator fX();

    protected abstract int getAnimationDelayTime();

    protected abstract View getInteractionView();

    protected abstract void nX();

    protected abstract void nY();

    public c(Context context) {
        this(context, null, 0);
    }

    public c(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public c(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.qN = false;
        a(context, attributeSet, i);
        nX();
    }

    public final void fW() {
        Animator animator = this.qM;
        if (animator != null) {
            animator.cancel();
            this.qM = null;
        }
        Animator animatorFX = fX();
        this.qM = animatorFX;
        if (animatorFX != null) {
            animatorFX.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.splashscreen.widget.c.1
                @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
                public final void onAnimationEnd(Animator animator2) {
                    super.onAnimationEnd(animator2);
                    if (c.this.qN) {
                        return;
                    }
                    c.this.getInteractionView().postDelayed(new bi() { // from class: com.kwad.components.ad.splashscreen.widget.c.1.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            if (c.this.qM != null) {
                                c.this.qM.start();
                            }
                        }
                    }, c.this.getAnimationDelayTime());
                }

                @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
                public final void onAnimationCancel(Animator animator2) {
                    super.onAnimationCancel(animator2);
                    c.this.nY();
                }
            });
            this.qM.start();
        }
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        super.af();
        Animator animator = this.qM;
        if (animator != null) {
            animator.cancel();
        }
    }

    public final void nZ() {
        this.qN = true;
        Animator animator = this.qM;
        if (animator != null) {
            animator.cancel();
        }
    }
}
