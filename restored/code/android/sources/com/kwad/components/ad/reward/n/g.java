package com.kwad.components.ad.reward.n;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Interpolator;
import android.widget.TextView;
import androidx.core.view.animation.PathInterpolatorCompat;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.bi;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends s implements View.OnClickListener {
    private TextView kG;
    private com.kwad.components.ad.reward.g ub;

    public interface a {
        void iQ();
    }

    public g(com.kwad.components.ad.reward.g gVar) {
        this.ub = gVar;
    }

    public final void h(ViewGroup viewGroup) {
        super.a(viewGroup, R.id.ksad_card_tips_view, R.id.ksad_card_tips_root);
        if (this.kG == null) {
            this.kG = (TextView) this.wL.findViewById(R.id.ksad_card_tips_title);
        }
        this.wL.setOnClickListener(this);
    }

    public final void a(final a aVar, long j) {
        final Animator animatorR = r(this.wL);
        if (animatorR == null) {
            aVar.iQ();
        } else {
            animatorR.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.n.g.1
                @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
                public final void onAnimationCancel(Animator animator) {
                    super.onAnimationCancel(animator);
                    a aVar2 = aVar;
                    if (aVar2 != null) {
                        aVar2.iQ();
                    }
                }

                @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
                public final void onAnimationEnd(Animator animator) {
                    super.onAnimationEnd(animator);
                    a aVar2 = aVar;
                    if (aVar2 != null) {
                        aVar2.iQ();
                    }
                }
            });
            this.wL.postDelayed(new bi() { // from class: com.kwad.components.ad.reward.n.g.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    animatorR.start();
                }
            }, 500L);
        }
    }

    private static Animator r(View view) {
        if (view == null) {
            return null;
        }
        int dimensionPixelSize = view.getContext().getResources().getDimensionPixelSize(R.dimen.ksad_live_card_tips_animation_y);
        Interpolator interpolatorCreate = PathInterpolatorCompat.create(0.0f, 0.0f, 0.58f, 1.0f);
        AnimatorSet animatorSet = new AnimatorSet();
        ObjectAnimator duration = ObjectAnimator.ofFloat(view, "translationY", -dimensionPixelSize).setDuration(500L);
        duration.setInterpolator(interpolatorCreate);
        ObjectAnimator duration2 = ObjectAnimator.ofFloat(view, "alpha", 1.0f, 1.0f).setDuration(2500L);
        ObjectAnimator duration3 = ObjectAnimator.ofFloat(view, "translationY", 0.0f).setDuration(500L);
        duration3.setInterpolator(interpolatorCreate);
        animatorSet.playSequentially(duration, duration2, duration3);
        return animatorSet;
    }

    @Override // com.kwad.components.ad.reward.n.d
    protected final void a(r rVar) {
        String str;
        TextView textView;
        super.a(rVar);
        AdTemplate adTemplate = rVar.getAdTemplate();
        if (adTemplate == null || (str = com.kwad.sdk.core.response.helper.b.dP(adTemplate).title) == null || (textView = this.kG) == null) {
            return;
        }
        textView.setText(str);
    }

    @Override // com.kwad.components.ad.reward.n.s, com.kwad.components.ad.reward.n.d
    public final ViewGroup hZ() {
        return this.wL;
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view.equals(this.wL)) {
            com.kwad.components.ad.reward.g gVar = this.ub;
            gVar.a(1, gVar.mContext, 1, 1);
        }
    }
}
