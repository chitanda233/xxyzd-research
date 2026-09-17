package com.kwad.components.ad.reward.n;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.AnimatorSet;
import android.animation.ObjectAnimator;
import android.animation.ValueAnimator;
import android.content.Context;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Interpolator;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import androidx.core.view.animation.PathInterpolatorCompat;
import com.kwad.components.ad.widget.KsPriceView;
import com.kwad.components.core.widget.KSCornerImageView;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.components.core.widget.KsStyledTextButton;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdProductInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.CouponInfo;
import com.kwad.sdk.utils.as;

/* JADX INFO: loaded from: classes3.dex */
public final class i extends d implements View.OnClickListener {
    private ViewGroup Dq;
    private KsPriceView Dr;
    private TextView Ds;
    private KsStyledTextButton Dt;
    private TextView Du;
    private TextView Dv;
    private View Dw;
    private ImageView Dx;
    private TextView fH;
    private TextView kG;
    private KsLogoView mLogoView;
    private KSCornerImageView on;
    private com.kwad.components.ad.reward.g ub;
    private ViewGroup wL;

    static /* synthetic */ Animator a(i iVar, View view, float f) {
        return a(view, f);
    }

    public i(com.kwad.components.ad.reward.g gVar, ViewGroup viewGroup, KsLogoView ksLogoView) {
        this.ub = gVar;
        this.mLogoView = ksLogoView;
        this.Dq = viewGroup;
        initView();
    }

    private void initView() {
        this.wL = (ViewGroup) this.Dq.findViewById(R.id.ksad_reward_jinniu_root);
        this.on = (KSCornerImageView) this.Dq.findViewById(R.id.ksad_reward_jinniu_icon);
        this.kG = (TextView) this.Dq.findViewById(R.id.ksad_reward_jinniu_title);
        this.fH = (TextView) this.Dq.findViewById(R.id.ksad_reward_jinniu_desc);
        this.Dr = (KsPriceView) this.Dq.findViewById(R.id.ksad_reward_jinniu_price);
        this.Ds = (TextView) this.Dq.findViewById(R.id.ksad_reward_jinniu_right_label);
        this.Dt = (KsStyledTextButton) this.Dq.findViewById(R.id.ksad_reward_jinniu_btn_buy);
        this.Dx = (ImageView) this.Dq.findViewById(R.id.ksad_reward_jinniu_light_sweep);
        this.Dw = this.Dq.findViewById(R.id.ksad_reward_jinniu_coupon_layout);
        this.Du = (TextView) this.Dq.findViewById(R.id.ksad_reward_jinniu_coupon);
        this.Dv = (TextView) this.Dq.findViewById(R.id.ksad_reward_jinniu_coupon_prefix);
        this.wL.setOnClickListener(this);
        KsStyledTextButton ksStyledTextButton = this.Dt;
        if (ksStyledTextButton != null) {
            ksStyledTextButton.setOnClickListener(this);
        }
        Context context = this.wL.getContext();
        if (as.VV()) {
            return;
        }
        ViewGroup.LayoutParams layoutParams = this.wL.getLayoutParams();
        if (layoutParams instanceof FrameLayout.LayoutParams) {
            FrameLayout.LayoutParams layoutParams2 = (FrameLayout.LayoutParams) layoutParams;
            layoutParams2.width = context.getResources().getDimensionPixelSize(R.dimen.ksad_reward_follow_card_width_horizontal);
            this.wL.setLayoutParams(layoutParams2);
        }
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final void a(r rVar) {
        super.a(rVar);
        if (rVar == null) {
            return;
        }
        a(rVar.getAdTemplate(), a.ac(rVar.getAdTemplate()));
        ViewGroup viewGroup = this.wL;
        if (viewGroup != null) {
            viewGroup.postDelayed(new Runnable() { // from class: com.kwad.components.ad.reward.n.i.1
                @Override // java.lang.Runnable
                public final void run() {
                    i iVar = i.this;
                    Animator animatorA = iVar.a(iVar.wL, i.this.Dt, i.this.mLogoView);
                    if (animatorA != null) {
                        animatorA.start();
                    }
                }
            }, com.alipay.sdk.m.y.c.f378a);
            this.wL.postDelayed(new Runnable() { // from class: com.kwad.components.ad.reward.n.i.2
                @Override // java.lang.Runnable
                public final void run() {
                    if (i.this.Dt == null || i.this.Dt.getWidth() == 0) {
                        return;
                    }
                    float width = i.this.Dt.getWidth();
                    i iVar = i.this;
                    final Animator animatorA = i.a(iVar, iVar.Dx, width);
                    if (animatorA != null) {
                        animatorA.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.n.i.2.1
                            private int Dz = 1;

                            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
                            public final void onAnimationEnd(Animator animator) {
                                super.onAnimationEnd(animator);
                                if (this.Dz >= 3) {
                                    return;
                                }
                                animatorA.start();
                                this.Dz++;
                            }
                        });
                        animatorA.start();
                    }
                }
            }, 5000L);
        }
    }

    private void a(AdTemplate adTemplate, a aVar) {
        if (aVar == null) {
            return;
        }
        KSImageLoader.loadAppIcon(this.on, aVar.hy(), adTemplate, 4);
        TextView textView = this.kG;
        if (textView != null) {
            textView.setText(aVar.getTitle());
        }
        TextView textView2 = this.fH;
        if (textView2 != null) {
            textView2.setText(aVar.hz());
        }
        KsPriceView ksPriceView = this.Dr;
        if (ksPriceView != null) {
            int dimensionPixelSize = ksPriceView.getResources().getDimensionPixelSize(R.dimen.ksad_reward_jinniu_end_origin_text_size);
            this.Dr.getConfig().au(dimensionPixelSize).aw(dimensionPixelSize).av(this.Dr.getResources().getColor(R.color.ksad_jinniu_end_origin_color));
            this.Dr.d(aVar.lz(), aVar.eG(), true);
        }
        if (this.Ds != null) {
            if (!TextUtils.isEmpty(aVar.lC())) {
                this.Ds.setText(aVar.lC());
            } else if (!TextUtils.isEmpty(aVar.getRating())) {
                this.Ds.setText(aVar.getRating());
            } else {
                this.Ds.setVisibility(8);
            }
        }
        if (this.Du != null && !TextUtils.isEmpty(aVar.lA())) {
            this.Du.setText(aVar.lA());
        }
        if (this.Dt != null && !TextUtils.isEmpty(aVar.lB())) {
            this.Dt.setText(aVar.lB());
        }
        int i = TextUtils.isEmpty(aVar.lA()) ? 8 : 0;
        View view = this.Dw;
        if (view != null) {
            view.setVisibility(i);
        }
        if (this.Dv == null || TextUtils.isEmpty(aVar.ir())) {
            return;
        }
        this.Dv.setText(aVar.ir());
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final ViewGroup hZ() {
        return this.wL;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public Animator a(final View view, View view2, final View view3) {
        final int height = view.getHeight();
        if (height <= 0 || view.getLayoutParams() == null) {
            return null;
        }
        Interpolator interpolatorCreate = PathInterpolatorCompat.create(0.51f, 0.0f, 0.67f, 1.0f);
        ValueAnimator duration = ValueAnimator.ofInt(height, view.getResources().getDimensionPixelSize(R.dimen.ksad_reward_jinniu_card_height_full)).setDuration(500L);
        duration.setInterpolator(interpolatorCreate);
        view.getContext();
        if (as.VV() && view3 != null && (view3.getLayoutParams() instanceof ViewGroup.MarginLayoutParams)) {
            final ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) view3.getLayoutParams();
            final int i = marginLayoutParams.bottomMargin;
            duration.addUpdateListener(new ValueAnimator.AnimatorUpdateListener() { // from class: com.kwad.components.ad.reward.n.i.3
                @Override // android.animation.ValueAnimator.AnimatorUpdateListener
                public final void onAnimationUpdate(ValueAnimator valueAnimator) {
                    int iIntValue = ((Integer) valueAnimator.getAnimatedValue()).intValue();
                    int i2 = iIntValue - height;
                    marginLayoutParams.bottomMargin = i + i2;
                    view3.setLayoutParams(marginLayoutParams);
                    ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
                    if (layoutParams != null) {
                        layoutParams.height = iIntValue;
                        view.setLayoutParams(layoutParams);
                    }
                }
            });
        }
        AnimatorSet animatorSet = new AnimatorSet();
        ObjectAnimator duration2 = ObjectAnimator.ofFloat(view2, "alpha", 0.0f, 0.0f).setDuration(200L);
        Interpolator interpolatorCreate2 = PathInterpolatorCompat.create(0.86f, 0.0f, 0.83f, 1.0f);
        ObjectAnimator duration3 = ObjectAnimator.ofFloat(view2, "alpha", 0.0f, 1.0f).setDuration(300L);
        duration3.setInterpolator(interpolatorCreate2);
        animatorSet.playSequentially(duration2, duration3);
        AnimatorSet animatorSet2 = new AnimatorSet();
        animatorSet2.playTogether(duration, animatorSet);
        return animatorSet2;
    }

    private static Animator a(View view, float f) {
        if (view == null || view.getWidth() <= 0) {
            return null;
        }
        ObjectAnimator duration = ObjectAnimator.ofFloat(view, "translationX", view.getResources().getDimension(R.dimen.ksad_jinniu_light_sweep_width) + f).setDuration(1000L);
        duration.setInterpolator(PathInterpolatorCompat.create(0.42f, 0.0f, 1.0f, 1.0f));
        ObjectAnimator duration2 = ObjectAnimator.ofFloat(view, "alpha", 1.0f, 1.0f).setDuration(1000L);
        AnimatorSet animatorSet = new AnimatorSet();
        animatorSet.playSequentially(duration, duration2);
        return animatorSet;
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view.equals(this.wL)) {
            this.ub.a(1, view.getContext(), 118, 2);
        } else if (view.equals(this.Dt)) {
            this.ub.a(1, view.getContext(), 1, 1);
        }
    }

    static class a {
        private String DH;
        private String DI;
        private String DJ;
        private String DK;
        private String nS;
        private String rating;
        private String tL;
        private String tM;
        private String title;
        private String vI;

        private a() {
        }

        static a ac(AdTemplate adTemplate) {
            CouponInfo firstCouponList;
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
            AdProductInfo adProductInfoDc = com.kwad.sdk.core.response.helper.a.dc(adInfoEM);
            a aVar = new a();
            String name = adProductInfoDc.getName();
            aVar.title = name;
            if (TextUtils.isEmpty(name)) {
                aVar.title = com.kwad.sdk.core.response.helper.a.aD(adInfoEM);
            }
            aVar.DJ = com.kwad.sdk.core.response.helper.a.aK(adInfoEM);
            aVar.tL = adProductInfoDc.getIcon();
            aVar.tM = com.kwad.sdk.core.response.helper.a.aA(adInfoEM);
            aVar.DH = adProductInfoDc.getPrice();
            aVar.nS = adProductInfoDc.getOriginPrice();
            aVar.DK = adProductInfoDc.getVolume();
            aVar.rating = adProductInfoDc.getRating();
            if (!adProductInfoDc.isCouponListEmpty() && (firstCouponList = adProductInfoDc.getFirstCouponList()) != null) {
                aVar.DI = CouponInfo.jinniuFormatCoupon(firstCouponList);
                aVar.R(firstCouponList.getFormattedJinniuPrefix());
            }
            return aVar;
        }

        public final String hy() {
            return this.tL;
        }

        public final String getTitle() {
            return this.title;
        }

        public final String hz() {
            return this.tM;
        }

        public final String lz() {
            return this.DH;
        }

        public final String eG() {
            return this.nS;
        }

        public final String lA() {
            return this.DI;
        }

        public final String lB() {
            return this.DJ;
        }

        public final String lC() {
            return this.DK;
        }

        public final String getRating() {
            return this.rating;
        }

        public final String ir() {
            return this.vI;
        }

        private void R(String str) {
            this.vI = str;
        }
    }
}
