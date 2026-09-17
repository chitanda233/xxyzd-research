package com.kwad.components.ad.splashscreen.presenter.playcard;

import android.content.Context;
import android.text.TextUtils;
import android.util.AttributeSet;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.core.widget.KSCornerImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.am;

/* JADX INFO: loaded from: classes3.dex */
public class SplashPlayDefaultInfoView extends FrameLayout {
    private KSCornerImageView Ks;
    private ImageView Kt;
    private TextView Ku;
    private TextView fH;
    private TextView kG;

    public SplashPlayDefaultInfoView(Context context) {
        super(context);
        nH();
    }

    public SplashPlayDefaultInfoView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        nH();
    }

    public SplashPlayDefaultInfoView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        nH();
    }

    public SplashPlayDefaultInfoView(Context context, AttributeSet attributeSet, int i, int i2) {
        super(context, attributeSet, i, i2);
        nH();
    }

    private void nH() {
        inflate(getContext(), R.layout.ksad_play_card_default_info, this);
        this.Ks = (KSCornerImageView) findViewById(R.id.ksad_splash_default_icon);
        this.kG = (TextView) findViewById(R.id.ksad_splash_default_title);
        this.Kt = (ImageView) findViewById(R.id.ksad_splash_default_img);
        this.fH = (TextView) findViewById(R.id.ksad_splash_default_desc);
        this.Ku = (TextView) findViewById(R.id.ksad_splash_default_tips);
    }

    public final void a(AdTemplate adTemplate, float f) {
        c cVarNF;
        AdInfo adInfoEM = e.eM(adTemplate);
        if (com.kwad.sdk.core.response.helper.a.dv(adInfoEM)) {
            cVarNF = c.c(f);
        } else {
            cVarNF = c.nF();
        }
        a(cVarNF);
        this.Ks.setRadius(com.kwad.sdk.c.a.a.a(getContext(), cVarNF.nG()));
        KSImageLoader.loadImage(this.Ks, com.kwad.sdk.core.response.helper.a.cv(adInfoEM), adTemplate);
        this.kG.setText(com.kwad.sdk.core.response.helper.a.cs(adInfoEM));
        if (TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.aA(adInfoEM))) {
            this.fH.setVisibility(8);
        } else {
            this.fH.setText(com.kwad.sdk.core.response.helper.a.aA(adInfoEM));
        }
    }

    private void a(c cVar) {
        am.a(this, cVar.W(getContext()));
        am.a(this.Ks, cVar.X(getContext()));
        am.a(this.kG, cVar.Y(getContext()));
        am.a(this.Kt, cVar.Z(getContext()));
        am.a(this.fH, cVar.aa(getContext()));
        am.a(this.Ku, cVar.ab(getContext()));
        this.kG.setTextSize(0, cVar.ac(getContext()));
        this.fH.setTextSize(0, cVar.ad(getContext()));
        this.Ku.setTextSize(0, cVar.ae(getContext()));
    }
}
