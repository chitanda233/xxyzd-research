package com.kwad.components.ad.splashscreen.presenter.endcard;

import android.content.Context;
import android.text.TextUtils;
import android.util.AttributeSet;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.splashscreen.widget.CloseCountDownView;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.am;

/* JADX INFO: loaded from: classes3.dex */
public class SplashEndLandView extends FrameLayout {
    private CloseCountDownView JD;
    private ViewGroup JE;
    private ViewGroup JF;
    private ImageView JG;
    private TextView JH;
    private TextView JI;
    private ImageView JT;
    private TextView JU;
    private TextView JV;
    private TextView JW;
    private int JX;
    private KsLogoView cI;

    public SplashEndLandView(Context context) {
        super(context);
        this.JX = 24;
    }

    public SplashEndLandView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.JX = 24;
    }

    public SplashEndLandView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.JX = 24;
    }

    public SplashEndLandView(Context context, AttributeSet attributeSet, int i, int i2) {
        super(context, attributeSet, i, i2);
        this.JX = 24;
    }

    public final void t(boolean z) {
        int i;
        if (z) {
            i = R.layout.ksad_splash_end_card_area_land;
        } else {
            i = R.layout.ksad_splash_end_card_area;
        }
        inflate(getContext(), i, this);
        this.JT = (ImageView) findViewById(R.id.ksad_ad_endcard_title_view);
        this.JE = (ViewGroup) findViewById(R.id.ksad_splash_end_card_giftbox_view);
        this.JG = (ImageView) findViewById(R.id.ksad_ad_endcard_icon);
        this.JH = (TextView) findViewById(R.id.ksad_ad_endcard_appname);
        this.JU = (TextView) findViewById(R.id.ksad_ad_endcard_appversion);
        this.JI = (TextView) findViewById(R.id.ksad_ad_endcard_appdesc);
        this.cI = (KsLogoView) findViewById(R.id.ksad_ad_endcard_logo);
        this.JV = (TextView) findViewById(R.id.ksad_ad_btn_title);
        this.JW = (TextView) findViewById(R.id.ksad_ad_btn_sub_title);
        this.JD = (CloseCountDownView) findViewById(R.id.ksad_ad_endcard_close_root);
        this.JF = (ViewGroup) findViewById(R.id.ksad_splash_endcard_actionbar);
    }

    public final void a(AdTemplate adTemplate, com.kwad.components.core.e.d.d dVar, float f) {
        a(new g(getContext(), f));
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.JG.setImageResource(R.drawable.ksad_default_app_icon);
        com.kwad.sdk.core.d.c.d("SplashEndLandView", "bindView, appIconRadius: " + this.JX);
        KSImageLoader.loadAppIcon(this.JG, com.kwad.sdk.core.response.helper.a.cv(adInfoEM), adTemplate, this.JX);
        this.JH.setText(com.kwad.sdk.core.response.helper.a.cs(adInfoEM));
        this.JI.setText(com.kwad.sdk.core.response.helper.a.aA(adInfoEM));
        this.cI.bh(adTemplate);
        if (!com.kwad.sdk.core.response.helper.a.aL(adInfoEM)) {
            this.JV.setText("点击查看");
            this.JW.setVisibility(0);
            this.JW.setText("跳转详情页/第三方应用");
        } else {
            b(adTemplate, adInfoEM, dVar);
        }
        this.JD.a(adInfoEM, f);
    }

    public final void bv() {
        CloseCountDownView closeCountDownView = this.JD;
        if (closeCountDownView != null) {
            closeCountDownView.bv();
        }
    }

    public final void bw() {
        CloseCountDownView closeCountDownView = this.JD;
        if (closeCountDownView != null) {
            closeCountDownView.bw();
        }
    }

    public final void nl() {
        CloseCountDownView closeCountDownView = this.JD;
        if (closeCountDownView != null) {
            closeCountDownView.cs();
        }
    }

    public final void ad(String str) {
        TextView textView = this.JV;
        if (textView == null || str == null) {
            return;
        }
        textView.setText(str);
    }

    public CloseCountDownView getCloseView() {
        return this.JD;
    }

    public ViewGroup getGiftBoxView() {
        return this.JE;
    }

    public ViewGroup getActionBarView() {
        return this.JF;
    }

    public ImageView getAppIcon() {
        return this.JG;
    }

    public TextView getAppName() {
        return this.JH;
    }

    public TextView getAppDesc() {
        return this.JI;
    }

    private void b(AdTemplate adTemplate, AdInfo adInfo, com.kwad.components.core.e.d.d dVar) {
        if (dVar == null) {
            return;
        }
        String strA = com.kwad.components.ad.splashscreen.d.a(adTemplate, adInfo, dVar.qm(), 0);
        if (!TextUtils.isEmpty(strA)) {
            this.JV.setText(strA);
        } else {
            this.JV.setText(com.kwad.sdk.core.response.helper.a.aK(adInfo));
        }
    }

    private void a(g gVar) {
        am.a(this.JT, gVar.nm());
        am.a(this.JE, gVar.nn());
        am.a(this.JG, gVar.no());
        am.a(this.JF, gVar.nq());
        am.a(this.JH, gVar.nr());
        am.a(this.JU, gVar.ns());
        am.a(this.JI, gVar.nt());
        am.a(this.JD, gVar.nu());
        TextView textView = this.JH;
        if (textView != null) {
            textView.setTextSize(0, gVar.nv());
        }
        TextView textView2 = this.JU;
        if (textView2 != null) {
            textView2.setTextSize(0, gVar.nw());
        }
        TextView textView3 = this.JI;
        if (textView3 != null) {
            textView3.setTextSize(0, gVar.nx());
        }
        TextView textView4 = this.JV;
        if (textView4 != null) {
            textView4.setTextSize(0, gVar.ny());
        }
        TextView textView5 = this.JW;
        if (textView5 != null) {
            textView5.setTextSize(0, gVar.nz());
        }
        this.JX = gVar.np();
    }
}
