package com.kwad.components.ad.reward.n;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.kwad.components.ad.reward.widget.KsAuthorIconView;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.as;

/* JADX INFO: loaded from: classes3.dex */
public final class o extends s implements View.OnClickListener {
    private KsAuthorIconView Er;
    private RelativeLayout Es;
    private TextView fG;
    private TextView fH;
    private TextView fI;
    private KsLogoView fJ;
    private String fM;
    private KsLogoView fN;
    private com.kwad.components.ad.reward.g ub;
    private boolean fE = false;
    private Runnable fU = new Runnable() { // from class: com.kwad.components.ad.reward.n.o.2
        @Override // java.lang.Runnable
        public final void run() {
            try {
                com.kwad.sdk.c.a.a.a(o.this.fH, o.this.fM, KsLogoView.a(o.this.fN));
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                o.this.fH.setText(o.this.fM);
                o.this.fH.setVisibility(0);
            }
        }
    };

    public o(com.kwad.components.ad.reward.g gVar) {
        this.ub = gVar;
    }

    public final void b(ViewGroup viewGroup, int i) {
        if (i == 8) {
            super.a(viewGroup, R.id.ksad_reward_origin_live_shop_stub, R.id.ksad_reward_origin_live_root);
            this.fE = true;
        } else {
            super.a(viewGroup, R.id.ksad_reward_origin_live_base_stub, R.id.ksad_reward_origin_live_root);
            this.fE = false;
        }
        initView();
    }

    private void initView() {
        if (this.wL == null) {
            return;
        }
        this.Er = (KsAuthorIconView) this.wL.findViewById(R.id.ksad_live_author_icon);
        this.fG = (TextView) this.wL.findViewById(R.id.kwad_actionbar_title);
        this.fH = (TextView) this.wL.findViewById(R.id.kwad_actionbar_des_text);
        this.fI = (TextView) this.wL.findViewById(R.id.ksad_live_actionbar_btn);
        this.fJ = (KsLogoView) this.wL.findViewById(R.id.ksad_reward_live_kwai_logo);
        if (!this.fE) {
            this.Es = (RelativeLayout) this.wL.findViewById(R.id.ksad_reward_origin_live_relative);
        }
        this.wL.setOnClickListener(this);
        this.fI.setOnClickListener(this);
        this.Er.setOnClickListener(this);
        this.fH.setOnClickListener(this);
        this.fG.setOnClickListener(this);
    }

    @Override // com.kwad.components.ad.reward.n.d
    protected final void a(r rVar) {
        super.a(rVar);
        j(rVar.getAdTemplate());
    }

    private void j(AdTemplate adTemplate) {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.fG.setText(com.kwad.sdk.core.response.helper.a.cs(adInfoEM));
        com.kwad.components.core.widget.e eVar = new com.kwad.components.core.widget.e();
        this.Er.setVisibility(0);
        this.Er.j(adTemplate);
        this.Er.a(eVar);
        this.fI.setText(com.kwad.sdk.core.response.helper.a.aK(adInfoEM));
        if (com.kwad.sdk.core.response.helper.a.bl(adInfoEM) == 8) {
            this.fJ.setVisibility(0);
            this.fJ.bh(adTemplate);
            this.fH.setText(com.kwad.sdk.core.response.helper.a.aA(adInfoEM));
        } else {
            this.fM = com.kwad.sdk.core.response.helper.a.aA(adInfoEM);
            KsLogoView ksLogoView = new KsLogoView(this.wL.getContext(), false);
            this.fN = ksLogoView;
            ksLogoView.setLogoLoadFinishListener(new KsLogoView.a() { // from class: com.kwad.components.ad.reward.n.o.1
                @Override // com.kwad.components.core.widget.KsLogoView.a
                public final void bG() {
                    o.this.fH.post(o.this.fU);
                }
            });
            this.fN.bh(adTemplate);
            this.fJ.setVisibility(8);
        }
    }

    @Override // com.kwad.components.ad.reward.n.d
    protected final void ad(boolean z) {
        super.ad(z);
        Context context = this.wL.getContext();
        if (as.VV()) {
            return;
        }
        if (!this.fE) {
            this.wL.findViewById(R.id.ksad_reward_origin_live_base1).setVisibility(0);
            ViewGroup.LayoutParams layoutParams = this.Es.getLayoutParams();
            layoutParams.width = context.getResources().getDimensionPixelSize(R.dimen.ksad_live_subscribe_card_width_horizontal);
            this.Es.setLayoutParams(layoutParams);
            ViewGroup.LayoutParams layoutParams2 = this.fI.getLayoutParams();
            layoutParams2.width = context.getResources().getDimensionPixelSize(R.dimen.ksad_live_subscribe_card_width_horizontal);
            this.fI.setLayoutParams(layoutParams2);
            return;
        }
        ViewGroup.LayoutParams layoutParams3 = this.wL.getLayoutParams();
        layoutParams3.width = context.getResources().getDimensionPixelSize(R.dimen.ksad_live_subscribe_card_width_horizontal);
        this.wL.setLayoutParams(layoutParams3);
        i(this.wL, 85);
    }

    private static void i(View view, int i) {
        if (view == null) {
            return;
        }
        ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
        if (layoutParams instanceof FrameLayout.LayoutParams) {
            FrameLayout.LayoutParams layoutParams2 = (FrameLayout.LayoutParams) layoutParams;
            layoutParams2.gravity = 85;
            layoutParams2.bottomMargin = com.kwad.sdk.c.a.a.a(view.getContext(), 20.0f);
            view.requestLayout();
        }
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view.equals(this.fI)) {
            this.ub.a(1, view.getContext(), 29, 1);
            return;
        }
        if (view.equals(this.Er)) {
            this.ub.a(1, view.getContext(), 30, 2);
            return;
        }
        if (view.equals(this.fH)) {
            this.ub.a(1, view.getContext(), 32, 2);
        } else if (view.equals(this.fG)) {
            this.ub.a(1, view.getContext(), 31, 2);
        } else if (view.equals(this.wL)) {
            this.ub.a(1, view.getContext(), 53, 2);
        }
    }
}
