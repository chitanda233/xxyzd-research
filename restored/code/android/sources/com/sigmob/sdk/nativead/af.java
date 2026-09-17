package com.sigmob.sdk.nativead;

import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.animation.ValueAnimator;
import android.view.ViewGroup;
import android.view.animation.DecelerateInterpolator;

/* JADX INFO: loaded from: classes4.dex */
public class af {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private ViewGroup f3569a;
    private ae b;
    private ae c;
    private long d;

    public af(ViewGroup targetView, ae fromViewInfo, ae toViewInfo, long duration) {
        this.f3569a = targetView;
        this.b = fromViewInfo;
        this.c = toViewInfo;
        this.d = duration;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(ValueAnimator valueAnimator) {
        ViewGroup.LayoutParams layoutParams = this.f3569a.getLayoutParams();
        layoutParams.height = ((Integer) valueAnimator.getAnimatedValue()).intValue();
        this.f3569a.setLayoutParams(layoutParams);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(ValueAnimator valueAnimator) {
        ViewGroup.LayoutParams layoutParams = this.f3569a.getLayoutParams();
        layoutParams.width = ((Integer) valueAnimator.getAnimatedValue()).intValue();
        this.f3569a.setLayoutParams(layoutParams);
    }

    public void a() {
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(this.f3569a, "x", this.b.a(), this.c.a());
        ObjectAnimator objectAnimatorOfFloat2 = ObjectAnimator.ofFloat(this.f3569a, "y", this.b.b(), this.c.b());
        ValueAnimator valueAnimatorOfInt = ValueAnimator.ofInt(this.b.c(), this.c.c());
        ValueAnimator valueAnimatorOfInt2 = ValueAnimator.ofInt(this.b.d(), this.c.d());
        valueAnimatorOfInt.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.sigmob.sdk.nativead.af$$ExternalSyntheticLambda0
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                this.f$0.b(valueAnimator);
            }
        });
        valueAnimatorOfInt2.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.sigmob.sdk.nativead.af$$ExternalSyntheticLambda1
            @Override // android.animation.ValueAnimator.AnimatorUpdateListener
            public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                this.f$0.a(valueAnimator);
            }
        });
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.playTogether(objectAnimatorOfFloat, objectAnimatorOfFloat2, valueAnimatorOfInt, valueAnimatorOfInt2);
        animatorSet.setDuration(this.d);
        animatorSet.setInterpolator(new DecelerateInterpolator());
        animatorSet.start();
    }
}
