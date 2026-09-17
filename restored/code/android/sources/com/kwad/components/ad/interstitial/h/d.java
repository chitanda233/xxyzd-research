package com.kwad.components.ad.interstitial.h;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.page.widget.TextProgressBar;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdProductInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.br;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.widget.h;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends KSFrameLayout implements com.kwad.sdk.widget.d {
    private KSFrameLayout fO;
    private ImageView gI;
    private TextView hS;
    private ImageView ia;
    private AdTemplate mAdTemplate;
    private KsLogoView mLogoView;
    private KSFrameLayout nk;
    private ViewGroup oA;
    private ViewGroup oB;
    private ImageView oC;
    private View oD;
    private View oE;
    private TextView oF;
    private ImageView oG;
    private TextView oH;
    private TextView oI;
    private TextView oJ;
    private TextProgressBar oK;
    private TextView oL;
    private e oM;
    private final a oN;
    private boolean oO;
    private String ow;
    private View ox;
    private ImageView oy;
    private TextProgressBar oz;

    public d(Context context, a aVar) {
        int i;
        super(context);
        this.ow = "%s秒后进入试玩页";
        this.oO = false;
        this.oN = aVar;
        if (aVar.fq()) {
            i = R.layout.ksad_interstitial_native_above;
        } else {
            i = R.layout.ksad_interstitial_native;
        }
        m.inflate(context, i, this);
        t(aVar.oQ);
    }

    private void t(boolean z) {
        setClickable(true);
        this.nk = (KSFrameLayout) findViewById(R.id.ksad_interstitial_native_container);
        this.fO = (KSFrameLayout) findViewById(R.id.ksad_interstitial_native_video_container);
        this.ox = findViewById(R.id.ksad_interstitial_full_bg);
        this.oy = (ImageView) findViewById(R.id.ksad_interstitial_tail_frame);
        this.ia = (ImageView) findViewById(R.id.ksad_video_first_frame_container);
        this.mLogoView = (KsLogoView) findViewById(R.id.ksad_ad_interstitial_logo);
        this.oA = (ViewGroup) findViewById(R.id.ksad_interstitial_playing);
        this.oB = (ViewGroup) findViewById(R.id.ksad_interstitial_play_end);
        this.oz = (TextProgressBar) findViewById(R.id.ksad_interstitial_download_btn);
        this.oD = findViewById(R.id.ksad_interstitial_close_outer);
        TextProgressBar textProgressBar = this.oz;
        if (textProgressBar != null) {
            textProgressBar.setTextDimen(com.kwad.sdk.c.a.a.a(getContext(), 10.0f));
            this.oz.setTextColor(-1);
        }
        this.oC = (ImageView) findViewById(R.id.ksad_interstitial_mute);
        this.oF = (TextView) findViewById(R.id.ksad_interstitial_count_down);
        this.oG = (ImageView) findViewById(R.id.ksad_interstitial_logo);
        this.oI = (TextView) findViewById(R.id.ksad_interstitial_name);
        this.oJ = (TextView) findViewById(R.id.ksad_interstitial_desc);
        this.oK = (TextProgressBar) findViewById(R.id.ksad_app_download_btn);
        this.oE = findViewById(R.id.ksad_ad_download_container);
        this.gI = (ImageView) findViewById(R.id.ksad_app_icon);
        this.oH = (TextView) findViewById(R.id.ksad_app_title);
        this.hS = (TextView) findViewById(R.id.ksad_app_desc);
        new h(this, this);
        new h(this.ia, this);
        new h(this.oz, this);
        new h(this.oK, this);
        new h(this.oD, this);
        new h(this.oB, this);
        new h(this.oF, this);
        new h(this.oE, this);
        new h(this.gI, this);
        new h(this.oH, this);
        new h(this.hS, this);
        new h(this.oG, this);
        new h(this.oI, this);
        new h(this.oJ, this);
        this.oC.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.interstitial.h.d.1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                d.this.oC.setSelected(!d.this.oC.isSelected());
                if (d.this.oM != null) {
                    d.this.oM.p(d.this.oC.isSelected());
                }
            }
        });
        this.oL = (TextView) findViewById(R.id.ksad_interstitial_playable_timer);
        a(this.fO, z);
        if (as.isOrientationPortrait()) {
            return;
        }
        fj();
    }

    private void a(KSFrameLayout kSFrameLayout, boolean z) {
        kSFrameLayout.setClickable(true);
        new h(kSFrameLayout, this);
        this.fO.setWidthBasedRatio(!z);
    }

    public final void setViewListener(e eVar) {
        this.oM = eVar;
    }

    public final void c(String str, AdTemplate adTemplate) {
        if (br.isNullString(str)) {
            return;
        }
        this.ia.setImageDrawable(null);
        KSImageLoader.loadImage(this.ia, str, adTemplate);
    }

    public final void H(AdTemplate adTemplate) {
        this.mLogoView.bh(adTemplate);
    }

    public final void d(boolean z, boolean z2) {
        ImageView imageView = this.ia;
        if (imageView != null) {
            imageView.setVisibility(z ? 0 : 8);
            this.ia.setClickable(z2);
        }
    }

    public final void setAdTemplate(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
    }

    private void fj() {
        a(this.oG, 40, 40);
        a(this.oK, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE, 30);
        this.oI.setTextSize(14.0f);
        e(this.oK, 11);
        e(this.oI, 7);
        e(this.oJ, 7);
    }

    private void a(View view, int i, int i2) {
        ViewGroup.LayoutParams layoutParams = view.getLayoutParams();
        layoutParams.width = com.kwad.sdk.c.a.a.a(getContext(), i);
        layoutParams.height = com.kwad.sdk.c.a.a.a(getContext(), i2);
        view.setLayoutParams(layoutParams);
    }

    private void e(View view, int i) {
        com.kwad.sdk.c.a.a.c(view, 0, com.kwad.sdk.c.a.a.a(getContext(), i), 0, 0);
    }

    public final void a(AdTemplate adTemplate, AdInfo adInfo) {
        this.oG.setImageResource(R.drawable.ksad_default_app_icon);
        if (com.kwad.sdk.core.response.helper.a.cp(adInfo) == 2) {
            KSImageLoader.loadCircleIcon(this.oG, com.kwad.sdk.core.response.helper.a.cV(adInfo), getContext().getResources().getDrawable(R.drawable.ksad_default_app_icon));
            this.oI.setText(com.kwad.sdk.core.response.helper.a.cu(adInfo));
            this.oJ.setText(com.kwad.sdk.core.response.helper.a.aA(adInfo));
            if (com.kwad.sdk.core.response.helper.a.cR(adInfo)) {
                this.oK.e(com.kwad.components.ad.e.b.aE(), 0);
                return;
            } else {
                this.oK.e(com.kwad.components.ad.e.b.aH(), 0);
                return;
            }
        }
        if (com.kwad.components.ad.interstitial.b.b.dS() && com.kwad.sdk.core.response.helper.a.cp(adInfo) == 3) {
            AdProductInfo adProductInfoDc = com.kwad.sdk.core.response.helper.a.dc(adInfo);
            KSImageLoader.loadWithRadius(this.oG, adProductInfoDc.icon, adTemplate, 4);
            this.oI.setText(adProductInfoDc.name);
            this.oJ.setVisibility(8);
            this.oK.e(com.kwad.components.ad.e.b.aF(), 0);
            return;
        }
        if (com.kwad.sdk.core.response.helper.a.aL(adInfo)) {
            KSImageLoader.loadWithRadius(this.oG, com.kwad.sdk.core.response.helper.a.cv(adInfo), adTemplate, 4);
            this.oI.setText(com.kwad.sdk.core.response.helper.a.aB(adInfo));
            this.oJ.setText(com.kwad.sdk.core.response.helper.a.aA(adInfo));
            this.oK.e(com.kwad.sdk.core.response.helper.a.aK(adInfo), 0);
            return;
        }
        KSImageLoader.loadWithRadius(this.oG, com.kwad.sdk.core.response.helper.e.eR(adTemplate), adTemplate, 4);
        this.oI.setText(com.kwad.sdk.core.response.helper.a.cs(adInfo));
        this.oJ.setText(com.kwad.sdk.core.response.helper.a.aA(adInfo));
        this.oK.e(com.kwad.sdk.core.response.helper.a.aK(adInfo), 0);
    }

    public final void u(boolean z) {
        ViewGroup viewGroup = this.oA;
        if (viewGroup != null) {
            viewGroup.setVisibility(z ? 0 : 8);
        }
    }

    public final void v(boolean z) {
        ImageView imageView = this.oC;
        if (imageView != null) {
            imageView.setSelected(z);
        }
    }

    public final void A(String str) {
        TextView textView = this.oF;
        if (textView == null) {
            return;
        }
        if (str != null) {
            textView.setText(str);
        }
        if (!this.oN.oR || this.oO || this.oF.getVisibility() == 0) {
            return;
        }
        this.oF.setVisibility(0);
    }

    public final void fk() {
        TextView textView = this.oF;
        if (textView != null) {
            textView.setVisibility(8);
            this.oO = true;
        }
    }

    public final void fl() {
        View view = this.oD;
        if (view != null) {
            view.setVisibility(8);
        }
    }

    public final void f(String str, int i) {
        TextProgressBar textProgressBar = this.oz;
        if (textProgressBar != null) {
            textProgressBar.e(str, 0);
        }
        TextProgressBar textProgressBar2 = this.oK;
        if (textProgressBar2 != null) {
            textProgressBar2.e(str, 0);
        }
    }

    public final void b(boolean z, int i) {
        TextView textView = this.oL;
        if (textView == null) {
            return;
        }
        textView.setVisibility(0);
        if (i >= 0) {
            this.oL.setText(String.format(this.ow, String.valueOf(i)));
        }
    }

    public final void a(float f, com.kwad.sdk.core.video.videoview.a aVar) {
        this.fO.setRatio(f);
        this.fO.addView(aVar);
        FrameLayout.LayoutParams layoutParams = (FrameLayout.LayoutParams) aVar.getLayoutParams();
        layoutParams.topMargin = 0;
        layoutParams.width = -1;
        layoutParams.height = -1;
        layoutParams.gravity = 17;
        aVar.setLayoutParams(layoutParams);
    }

    public final void fm() {
        u(false);
        this.oB.setVisibility(0);
        this.oy.setVisibility(0);
    }

    public final void fn() {
        this.oB.setVisibility(8);
        this.oy.setVisibility(8);
        u(true);
    }

    public final boolean fo() {
        ViewGroup viewGroup = this.oB;
        return viewGroup != null && viewGroup.getVisibility() == 0;
    }

    public final View getBlurBgView() {
        return this.ox;
    }

    public final ImageView getTailFrameView() {
        return this.oy;
    }

    public final void f(int i, int i2) {
        ViewGroup.MarginLayoutParams marginLayoutParams = (ViewGroup.MarginLayoutParams) getLayoutParams();
        marginLayoutParams.width = i;
        marginLayoutParams.height = i2;
        setLayoutParams(marginLayoutParams);
    }

    private void d(View view, boolean z) {
        e eVar;
        e eVar2;
        e eVar3 = this.oM;
        if (eVar3 != null) {
            eVar3.q(z);
            this.oM.a(this.nk);
        }
        if (view.equals(this)) {
            e eVar4 = this.oM;
            if (eVar4 != null) {
                eVar4.en();
                return;
            }
            return;
        }
        if (view.equals(this.oD)) {
            if (!(1 == this.oN.fp()) || (eVar2 = this.oM) == null) {
                return;
            }
            eVar2.em();
            return;
        }
        if (view.equals(this.oK)) {
            e eVar5 = this.oM;
            if (eVar5 != null) {
                eVar5.eo();
                return;
            }
            return;
        }
        if (view.equals(this.oB)) {
            e eVar6 = this.oM;
            if (eVar6 != null) {
                eVar6.ez();
                return;
            }
            return;
        }
        if (view.equals(this.oz)) {
            e eVar7 = this.oM;
            if (eVar7 != null) {
                eVar7.ep();
                return;
            }
            return;
        }
        if (view.equals(this.oE)) {
            e eVar8 = this.oM;
            if (eVar8 != null) {
                eVar8.es();
                return;
            }
            return;
        }
        if (view.equals(this.fO)) {
            e eVar9 = this.oM;
            if (eVar9 != null) {
                eVar9.eq();
                return;
            }
            return;
        }
        if (view.equals(this.ia)) {
            e eVar10 = this.oM;
            if (eVar10 != null) {
                eVar10.er();
                return;
            }
            return;
        }
        if (view.equals(this.gI)) {
            e eVar11 = this.oM;
            if (eVar11 != null) {
                eVar11.et();
                return;
            }
            return;
        }
        if (view.equals(this.oH)) {
            e eVar12 = this.oM;
            if (eVar12 != null) {
                eVar12.eu();
                return;
            }
            return;
        }
        if (view.equals(this.hS)) {
            e eVar13 = this.oM;
            if (eVar13 != null) {
                eVar13.ev();
                return;
            }
            return;
        }
        if (view.equals(this.oG)) {
            e eVar14 = this.oM;
            if (eVar14 != null) {
                eVar14.ew();
                return;
            }
            return;
        }
        if (view.equals(this.oI)) {
            e eVar15 = this.oM;
            if (eVar15 != null) {
                eVar15.ex();
                return;
            }
            return;
        }
        if (!view.equals(this.oJ) || (eVar = this.oM) == null) {
            return;
        }
        eVar.ey();
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

    public static class a {
        private boolean oQ = false;
        private boolean oR = false;
        private int oS = 0;
        private boolean oT = true;

        public final void w(boolean z) {
            this.oQ = z;
        }

        public final void x(boolean z) {
            this.oR = z;
        }

        public final int fp() {
            return this.oS;
        }

        public final void R(int i) {
            this.oS = i;
        }

        public final boolean fq() {
            return this.oT;
        }

        public final void y(boolean z) {
            this.oT = z;
        }
    }
}
