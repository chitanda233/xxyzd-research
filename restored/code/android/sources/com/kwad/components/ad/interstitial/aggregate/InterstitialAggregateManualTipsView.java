package com.kwad.components.ad.interstitial.aggregate;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import androidx.viewpager.widget.ViewPager;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class InterstitialAggregateManualTipsView extends LinearLayout implements View.OnClickListener {
    private int lD;
    private ImageView lJ;
    private ImageView lK;
    private ImageView lL;
    private int lM;
    private final ViewPager.OnPageChangeListener lN;
    private TransViewPager lx;
    private AdTemplate mAdTemplate;
    private final Context mContext;

    public InterstitialAggregateManualTipsView(Context context) {
        this(context, null);
    }

    public InterstitialAggregateManualTipsView(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public InterstitialAggregateManualTipsView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.lN = new ViewPager.SimpleOnPageChangeListener() { // from class: com.kwad.components.ad.interstitial.aggregate.InterstitialAggregateManualTipsView.1
            @Override // androidx.viewpager.widget.ViewPager.SimpleOnPageChangeListener, androidx.viewpager.widget.ViewPager.OnPageChangeListener
            public final void onPageSelected(int i2) {
                InterstitialAggregateManualTipsView.this.lM = i2;
                if (InterstitialAggregateManualTipsView.this.lM == InterstitialAggregateManualTipsView.this.lD - 1) {
                    InterstitialAggregateManualTipsView.this.lJ.setAlpha(0.5f);
                    InterstitialAggregateManualTipsView.this.lK.setAlpha(0.5f);
                } else {
                    InterstitialAggregateManualTipsView.this.lJ.setAlpha(1.0f);
                    InterstitialAggregateManualTipsView.this.lK.setAlpha(1.0f);
                }
            }
        };
        this.mContext = context;
        initView();
    }

    private void initView() {
        m.inflate(this.mContext, R.layout.ksad_interstitial_aggregate_manual_tips, this);
        this.lJ = (ImageView) findViewById(R.id.ksad_interstitial_aggregate_cut);
        this.lK = (ImageView) findViewById(R.id.ksad_interstitial_aggregate_refresh);
        ImageView imageView = (ImageView) findViewById(R.id.ksad_interstitial_aggregate_convert);
        this.lL = imageView;
        com.kwad.sdk.c.a.a.a(this, this.lJ, this.lK, imageView);
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        com.kwad.components.ad.interstitial.h.c cVarJ;
        if (view.equals(this.lJ)) {
            dI();
            com.kwad.sdk.core.adlog.c.s(this.mAdTemplate, 162);
        } else if (view.equals(this.lK)) {
            dI();
            com.kwad.sdk.core.adlog.c.s(this.mAdTemplate, 36);
        } else {
            if (!view.equals(this.lL) || (cVarJ = this.lx.J(this.lM)) == null) {
                return;
            }
            cVarJ.fh();
        }
    }

    private void dI() {
        int i = this.lM;
        if (i < this.lD - 1) {
            this.lx.setCurrentItem(i + 1, true);
        }
    }
}
