package com.kwad.components.ad.reward.b;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.content.Context;
import android.text.SpannableString;
import android.text.TextUtils;
import android.text.style.AbsoluteSizeSpan;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Interpolator;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import androidx.core.view.animation.PathInterpolatorCompat;
import com.kwad.components.ad.reward.n.d;
import com.kwad.components.ad.reward.n.r;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdProductInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.CouponInfo;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.wrapper.m;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends d implements View.OnClickListener {
    private TextView fH;
    private TextView kG;
    private final ViewGroup mRootContainer;
    private ImageView uA;
    private TextView uB;
    private Button uC;
    private b uD;
    private int[] uy;
    private View uz;

    public interface b {
        void id();

        void ie();
    }

    static /* synthetic */ Animator a(a aVar, View view) {
        return n(view);
    }

    static /* synthetic */ Animator a(a aVar, ImageView imageView, long j) {
        return a(imageView, j);
    }

    public a(Context context, ViewGroup viewGroup, int[] iArr) {
        this.uy = iArr;
        ViewGroup viewGroup2 = (ViewGroup) m.a(context, R.layout.ksad_reward_coupon_dialog, viewGroup, false);
        this.mRootContainer = viewGroup2;
        f(viewGroup2);
    }

    public final void a(b bVar) {
        this.uD = bVar;
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final ViewGroup hZ() {
        return this.mRootContainer;
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final void a(r rVar) {
        super.a(rVar);
        a(C0391a.Q(rVar.getAdTemplate()));
        this.mRootContainer.post(new AnonymousClass1(rVar, com.kwad.components.ad.reward.a.b.hS()));
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.reward.b.a$1, reason: invalid class name */
    final class AnonymousClass1 extends bi {
        final /* synthetic */ r uE;
        final /* synthetic */ long uF;

        AnonymousClass1(r rVar, long j) {
            this.uE = rVar;
            this.uF = j;
        }

        @Override // com.kwad.sdk.utils.bi
        public final void doTask() {
            a aVar = a.this;
            final Animator animatorA = a.a(aVar, aVar.uz);
            animatorA.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.b.a.1.1
                @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
                public final void onAnimationEnd(Animator animator) {
                    super.onAnimationEnd(animator);
                    animatorA.removeListener(this);
                    com.kwad.sdk.core.adlog.c.b(AnonymousClass1.this.uE.getAdTemplate(), 169, (JSONObject) null);
                    a.a(a.this, a.this.uA, AnonymousClass1.this.uF).start();
                    by.a(new Runnable() { // from class: com.kwad.components.ad.reward.b.a.1.1.1
                        @Override // java.lang.Runnable
                        public final void run() {
                            a.this.ia();
                        }
                    }, null, AnonymousClass1.this.uF);
                }
            });
            animatorA.start();
        }
    }

    private void a(C0391a c0391a) {
        if (c0391a == null) {
            return;
        }
        TextView textView = this.kG;
        if (textView != null) {
            textView.setText(c0391a.getTitle());
        }
        TextView textView2 = this.uB;
        if (textView2 != null) {
            textView2.setText(c0391a.Q(this.mRootContainer.getContext()));
        }
        TextView textView3 = this.fH;
        if (textView3 != null) {
            textView3.setText(c0391a.ib());
        }
        Button button = this.uC;
        if (button != null) {
            button.setText(c0391a.ic());
        }
    }

    private void f(ViewGroup viewGroup) {
        this.uz = viewGroup.findViewById(R.id.ksad_coupon_dialog_card);
        this.uA = (ImageView) viewGroup.findViewById(R.id.ksad_coupon_dialog_bg);
        this.kG = (TextView) viewGroup.findViewById(R.id.ksad_coupon_dialog_title);
        this.uB = (TextView) viewGroup.findViewById(R.id.ksad_coupon_dialog_content);
        this.fH = (TextView) viewGroup.findViewById(R.id.ksad_coupon_dialog_desc);
        Button button = (Button) viewGroup.findViewById(R.id.ksad_coupon_dialog_btn_action);
        this.uC = button;
        button.setOnClickListener(this);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        b bVar;
        if (!view.equals(this.uC) || (bVar = this.uD) == null) {
            return;
        }
        bVar.id();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ia() {
        final Animator animatorO = o(this.uz);
        animatorO.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.b.a.2
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                animatorO.removeListener(this);
                if (a.this.uD != null) {
                    a.this.uD.ie();
                }
            }
        });
        animatorO.start();
    }

    private static Animator n(View view) {
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(view, "scaleX", 0.0f, 1.0f);
        ObjectAnimator objectAnimatorOfFloat2 = ObjectAnimator.ofFloat(view, "scaleY", 0.0f, 1.0f);
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.setDuration(300L);
        animatorSet.playTogether(objectAnimatorOfFloat, objectAnimatorOfFloat2);
        return animatorSet;
    }

    private static Animator a(ImageView imageView, long j) {
        ObjectAnimator objectAnimatorOfFloat = ObjectAnimator.ofFloat(imageView, "alpha", imageView.getAlpha(), 0.0f);
        objectAnimatorOfFloat.setDuration(j);
        return objectAnimatorOfFloat;
    }

    private Animator o(View view) {
        ObjectAnimator objectAnimatorOfFloat;
        ObjectAnimator objectAnimatorOfFloat2;
        int[] iArrL;
        Interpolator interpolatorCreate = PathInterpolatorCompat.create(0.89f, 0.02f, 0.72f, 1.0f);
        ObjectAnimator objectAnimatorOfFloat3 = ObjectAnimator.ofFloat(view, "scaleX", 1.0f, 0.0f);
        ObjectAnimator objectAnimatorOfFloat4 = ObjectAnimator.ofFloat(view, "scaleY", 1.0f, 0.0f);
        objectAnimatorOfFloat3.setInterpolator(interpolatorCreate);
        objectAnimatorOfFloat4.setInterpolator(interpolatorCreate);
        int[] iArr = this.uy;
        if (iArr == null || iArr.length < 2 || (iArrL = com.kwad.sdk.c.a.a.L(view)) == null) {
            objectAnimatorOfFloat = null;
            objectAnimatorOfFloat2 = null;
        } else {
            Interpolator interpolatorCreate2 = PathInterpolatorCompat.create(0.33f, 0.0f, 0.83f, 1.0f);
            objectAnimatorOfFloat = ObjectAnimator.ofFloat(view, "translationX", this.uy[0] - iArrL[0]);
            objectAnimatorOfFloat2 = ObjectAnimator.ofFloat(view, "translationY", this.uy[1] - iArrL[1]);
            objectAnimatorOfFloat.setInterpolator(interpolatorCreate2);
            objectAnimatorOfFloat2.setInterpolator(interpolatorCreate2);
        }
        ObjectAnimator objectAnimatorOfFloat5 = ObjectAnimator.ofFloat(view, "alpha", 1.0f, 1.0f);
        objectAnimatorOfFloat5.setDuration(200L);
        ObjectAnimator objectAnimatorOfFloat6 = ObjectAnimator.ofFloat(view, "alpha", 1.0f, 0.0f);
        objectAnimatorOfFloat6.setDuration(200L);
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.playSequentially(objectAnimatorOfFloat5, objectAnimatorOfFloat6);
        AnimatorSet animatorSet2 = new AnimatorSet();
        animatorSet2.setDuration(500L);
        if (objectAnimatorOfFloat != null) {
            animatorSet2.playTogether(objectAnimatorOfFloat3, objectAnimatorOfFloat4, animatorSet, objectAnimatorOfFloat, objectAnimatorOfFloat2);
        } else {
            animatorSet2.playTogether(objectAnimatorOfFloat3, objectAnimatorOfFloat4, animatorSet);
        }
        return animatorSet2;
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.reward.b.a$a, reason: collision with other inner class name */
    static class C0391a {
        private CharSequence title;
        private CharSequence uL;
        private CharSequence uM;
        private CharSequence uN;

        private C0391a(CouponInfo couponInfo) {
            this.title = couponInfo.displayTitle;
            this.uL = couponInfo.displayValue;
            if (TextUtils.isEmpty(couponInfo.displayBase)) {
                this.uM = "";
            } else {
                this.uM = String.format("满%s可用", couponInfo.displayBase);
            }
            this.uN = couponInfo.displayActionWords;
        }

        public final CharSequence getTitle() {
            return this.title;
        }

        public final CharSequence Q(Context context) {
            AbsoluteSizeSpan absoluteSizeSpan = new AbsoluteSizeSpan(context.getResources().getDimensionPixelSize(R.dimen.ksad_coupon_dialog_value_prefix_text_size));
            SpannableString spannableString = new SpannableString("¥" + ((Object) this.uL));
            spannableString.setSpan(absoluteSizeSpan, 0, 1, 17);
            return spannableString;
        }

        public final CharSequence ib() {
            return this.uM;
        }

        public final CharSequence ic() {
            return this.uN;
        }

        public static C0391a Q(AdTemplate adTemplate) {
            AdProductInfo adProductInfoDc = com.kwad.sdk.core.response.helper.a.dc(e.eM(adTemplate));
            if (adProductInfoDc == null || adProductInfoDc.couponList == null || adProductInfoDc.couponList.size() <= 0) {
                return null;
            }
            return a(adProductInfoDc.couponList.get(0));
        }

        private static C0391a a(CouponInfo couponInfo) {
            if (couponInfo == null) {
                return null;
            }
            return new C0391a(couponInfo);
        }
    }
}
