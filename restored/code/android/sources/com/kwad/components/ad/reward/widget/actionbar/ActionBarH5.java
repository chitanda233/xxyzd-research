package com.kwad.components.ad.reward.widget.actionbar;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.FrameLayout;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.d;
import com.kwad.sdk.widget.h;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class ActionBarH5 extends FrameLayout implements d {
    private TextView FK;
    private a FL;
    private View FM;
    private TextView gP;
    private AdTemplate mAdTemplate;

    public interface a {
        void P(boolean z);
    }

    public ActionBarH5(Context context) {
        super(context);
        B(context);
    }

    public ActionBarH5(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        B(context);
    }

    public ActionBarH5(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        B(context);
    }

    private void B(Context context) {
        m.inflate(context, R.layout.ksad_video_actionbar_h5, this);
        this.FK = (TextView) findViewById(R.id.ksad_h5_ad_desc);
        this.gP = (TextView) findViewById(R.id.ksad_h5_open_btn);
        this.FM = findViewById(R.id.ksad_download_bar_cover);
    }

    public final void a(AdTemplate adTemplate, a aVar) {
        this.mAdTemplate = adTemplate;
        this.FL = aVar;
        AdInfo adInfoEM = e.eM(adTemplate);
        this.FK.setText(com.kwad.sdk.core.response.helper.a.aA(adInfoEM));
        this.gP.setText(com.kwad.sdk.core.response.helper.a.aK(adInfoEM));
        setClickable(true);
        this.FM.setClickable(true);
        new h(this.FM, this);
        new h(this, this);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        d(view, true);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (SlideConvertHelper.a(this.mAdTemplate, f, f2, f3, f4)) {
            d(view, false);
        }
    }

    private void d(View view, final boolean z) {
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(view.getContext()).aF(this.mAdTemplate).aD(view == this.FM ? 1 : 2).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.reward.widget.actionbar.ActionBarH5.1
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                if (ActionBarH5.this.FL != null) {
                    ActionBarH5.this.FL.P(z);
                }
            }
        }));
    }
}
