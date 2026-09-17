package com.kwad.components.ad.draw.view.playcard;

import android.animation.ValueAnimator;
import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.view.animation.DecelerateInterpolator;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.core.t.x;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.n;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class DrawCardH5 extends FrameLayout implements View.OnClickListener {
    private a gA;
    private ImageView gB;
    private TextView gC;
    private TextView gD;
    private ValueAnimator gy;
    private AdTemplate mAdTemplate;
    private Context mContext;
    private int mHeight;
    private KsLogoView mLogoView;

    public interface a {
        void bc();

        void bd();
    }

    public DrawCardH5(Context context) {
        super(context);
        B(context);
    }

    public DrawCardH5(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        B(context);
    }

    public DrawCardH5(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        B(context);
    }

    private void B(Context context) {
        this.mContext = context;
        m.inflate(context, R.layout.ksad_draw_card_h5, this);
        this.gB = (ImageView) findViewById(R.id.ksad_card_close);
        this.gC = (TextView) findViewById(R.id.ksad_card_ad_desc);
        this.gD = (TextView) findViewById(R.id.ksad_card_h5_open_btn);
        this.mLogoView = (KsLogoView) findViewById(R.id.ksad_draw_h5_logo);
    }

    public final void a(AdTemplate adTemplate, a aVar) {
        this.mAdTemplate = adTemplate;
        AdInfo adInfoEM = e.eM(adTemplate);
        this.gA = aVar;
        this.gC.setText(com.kwad.sdk.core.response.helper.a.aA(adInfoEM));
        this.gD.setText(com.kwad.sdk.core.response.helper.a.aK(adInfoEM));
        this.gB.setOnClickListener(this);
        this.gD.setOnClickListener(this);
        this.mLogoView.bh(adTemplate);
        setOnClickListener(this);
        this.gC.measure(View.MeasureSpec.makeMeasureSpec((n.getScreenWidth(this.mContext) - (com.kwad.sdk.c.a.a.a(this.mContext, 16.0f) * 2)) - (com.kwad.sdk.c.a.a.a(this.mContext, 10.0f) * 2), Integer.MIN_VALUE), View.MeasureSpec.makeMeasureSpec(0, 0));
        this.mHeight = com.kwad.sdk.c.a.a.a(this.mContext, 100.0f) + this.gC.getMeasuredHeight();
    }

    public final void release() {
        bn();
    }

    public final void bV() {
        d(0, this.mHeight);
    }

    private void bX() {
        d(this.mHeight, 0);
    }

    private void d(int i, int i2) {
        bn();
        ValueAnimator valueAnimatorB = x.b(this, i, i2);
        this.gy = valueAnimatorB;
        valueAnimatorB.setInterpolator(new DecelerateInterpolator(2.0f));
        this.gy.setDuration(300L);
        this.gy.start();
    }

    private void bn() {
        ValueAnimator valueAnimator = this.gy;
        if (valueAnimator != null) {
            valueAnimator.removeAllListeners();
            this.gy.cancel();
        }
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        if (view == this.gB) {
            bX();
            a aVar = this.gA;
            if (aVar != null) {
                aVar.bc();
                return;
            }
            return;
        }
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.mAdTemplate).aD(view == this.gD ? 1 : 2).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.draw.view.playcard.DrawCardH5.1
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                if (DrawCardH5.this.gA != null) {
                    DrawCardH5.this.gA.bd();
                }
            }
        }));
    }
}
