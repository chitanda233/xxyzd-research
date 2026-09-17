package com.kwad.components.ad.reward.n;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.components.ad.reward.widget.KSCouponLabelTextView;
import com.kwad.components.ad.widget.KsPriceView;
import com.kwad.components.core.widget.KSCornerImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdProductInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.CouponInfo;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.br;

/* JADX INFO: loaded from: classes3.dex */
public final class n extends d implements View.OnClickListener {
    private TextView Dk;
    private ViewGroup Eb;
    private LinearLayout Eh;
    private KsPriceView Ei;
    private TextView Ej;
    private View Ek;
    private KSCornerImageView El;
    private b Em;
    private a En;
    private KSCornerImageView ex;
    private ViewGroup mRootContainer;

    public interface a {
        void iO();
    }

    static /* synthetic */ View a(n nVar, Context context, CouponInfo couponInfo, ViewGroup viewGroup) {
        return a(context, couponInfo, viewGroup);
    }

    public n(ViewGroup viewGroup, b bVar) {
        this.mRootContainer = viewGroup;
        this.Em = bVar;
        initView();
    }

    public final void a(a aVar) {
        this.En = aVar;
    }

    private void initView() {
        this.Eb = (ViewGroup) this.mRootContainer.findViewById(R.id.ksad_reward_order_root);
        this.ex = (KSCornerImageView) this.mRootContainer.findViewById(R.id.ksad_reward_order_icon);
        this.Dk = (TextView) this.mRootContainer.findViewById(R.id.ksad_reward_order_title);
        this.Eh = (LinearLayout) this.mRootContainer.findViewById(R.id.ksad_reward_order_coupon_list);
        this.Ei = (KsPriceView) this.mRootContainer.findViewById(R.id.ksad_reward_order_price);
        this.Ej = (TextView) this.mRootContainer.findViewById(R.id.ksad_reward_order_btn_buy);
        this.Ek = this.mRootContainer.findViewById(R.id.ksad_reward_order_text_area);
        this.El = (KSCornerImageView) this.mRootContainer.findViewById(R.id.ksad_reward_order_kwai_logo);
        this.Ej.setText(com.kwad.components.ad.e.b.aF());
        this.Ej.setOnClickListener(this);
        this.ex.setOnClickListener(this);
        this.Ek.setOnClickListener(this);
        Context context = this.mRootContainer.getContext();
        if (as.VV()) {
            return;
        }
        ViewGroup.LayoutParams layoutParams = this.mRootContainer.getLayoutParams();
        if (layoutParams instanceof FrameLayout.LayoutParams) {
            FrameLayout.LayoutParams layoutParams2 = (FrameLayout.LayoutParams) layoutParams;
            layoutParams2.width = context.getResources().getDimensionPixelSize(R.dimen.ksad_reward_follow_card_width_horizontal);
            this.mRootContainer.setLayoutParams(layoutParams2);
        }
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final void a(r rVar) {
        super.a(rVar);
        a(com.kwad.sdk.core.response.helper.a.dc(com.kwad.sdk.core.response.helper.e.eM(rVar.getAdTemplate())), rVar.getAdTemplate());
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final ViewGroup hZ() {
        return this.Eb;
    }

    private void a(final AdProductInfo adProductInfo, AdTemplate adTemplate) {
        KSImageLoader.loadImage(this.ex, adProductInfo.getIcon(), adTemplate);
        this.Dk.setText(adProductInfo.getName());
        if (adProductInfo.isCouponListEmpty()) {
            this.Eh.setVisibility(8);
            this.En.iO();
        } else {
            this.Eh.setVisibility(0);
            this.Eh.post(new bi() { // from class: com.kwad.components.ad.reward.n.n.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    for (CouponInfo couponInfo : adProductInfo.getCouponList()) {
                        n nVar = n.this;
                        View viewA = n.a(nVar, nVar.Eh.getContext(), couponInfo, n.this.Eh);
                        ViewGroup.LayoutParams layoutParams = viewA.getLayoutParams();
                        if (layoutParams == null) {
                            layoutParams = new ViewGroup.LayoutParams(-2, -1);
                        } else {
                            layoutParams.width = -2;
                            layoutParams.height = -1;
                        }
                        n.this.Eh.addView(viewA, layoutParams);
                        com.kwad.components.core.t.m.a(new com.kwad.components.core.widget.e(), n.this.Eh);
                    }
                    if (n.this.En != null) {
                        if (n.this.Eh.getChildCount() > 0) {
                            n.this.Eh.getChildAt(0).post(new bi() { // from class: com.kwad.components.ad.reward.n.n.1.1
                                @Override // com.kwad.sdk.utils.bi
                                public final void doTask() {
                                    n.this.En.iO();
                                }
                            });
                        } else {
                            n.this.En.iO();
                        }
                    }
                }
            });
        }
        this.Ei.h(adProductInfo.getPrice(), adProductInfo.getOriginPrice());
        String strAG = com.kwad.components.ad.e.b.aG();
        if (br.isNullString(strAG)) {
            return;
        }
        KSImageLoader.loadImage(this.El, strAG, adTemplate);
    }

    private static View a(Context context, CouponInfo couponInfo, ViewGroup viewGroup) {
        KSCouponLabelTextView kSCouponLabelTextView = (KSCouponLabelTextView) com.kwad.sdk.wrapper.m.a(context, R.layout.ksad_reward_order_card_coupon, viewGroup, false);
        kSCouponLabelTextView.setText(couponInfo.getDisplayName());
        return kSCouponLabelTextView;
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (this.Em == null) {
            return;
        }
        if (view.equals(this.Ej)) {
            this.Em.id();
        } else if (view.equals(this.ex)) {
            this.Em.jC();
        } else if (view.equals(this.Ek)) {
            this.Em.jD();
        }
    }
}
