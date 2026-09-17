package com.kwad.components.ad.interstitial.f;

import android.text.TextUtils;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.components.ad.widget.KsPriceView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdProductInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends com.kwad.components.ad.interstitial.f.b {
    private static int nL = 4;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private c mF;
    private a nJ = new a();
    private b nK = new b();

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.components.ad.interstitial.f.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        c cVar = (c) SK();
        this.mF = cVar;
        this.mAdTemplate = cVar.mAdTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.mF.mAdTemplate);
        this.nJ.nM = (ImageView) this.mF.mG.findViewById(R.id.ksad_app_icon);
        this.nJ.nN = (TextView) this.mF.mG.findViewById(R.id.ksad_app_title);
        this.nJ.nO = (TextView) this.mF.mG.findViewById(R.id.ksad_app_desc);
        this.nJ.nP = (KsPriceView) this.mF.mG.findViewById(R.id.ksad_product_price);
        d(this.mAdInfo);
        a(this.nJ, this.nK, this.mAdInfo, this.mAdTemplate);
    }

    private void a(a aVar, b bVar, AdInfo adInfo, AdTemplate adTemplate) {
        ImageView imageView = aVar.nM;
        if (!TextUtils.isEmpty(bVar.getAppIconUrl())) {
            imageView.setVisibility(0);
            if (com.kwad.sdk.core.response.helper.a.co(adInfo) == 2) {
                KSImageLoader.loadCircleIcon(imageView, bVar.getAppIconUrl(), getContext().getResources().getDrawable(R.drawable.ksad_default_app_icon));
            } else {
                imageView.setImageResource(R.drawable.ksad_default_app_icon);
                KSImageLoader.loadWithRadius(imageView, bVar.getAppIconUrl(), adTemplate, nL);
            }
        } else {
            imageView.setVisibility(8);
        }
        aVar.nN.setText(bVar.eE());
        if (!com.kwad.components.ad.interstitial.b.b.dS() || com.kwad.sdk.core.response.helper.a.co(adInfo) != 3) {
            aVar.nO.setText(bVar.eF());
        } else {
            aVar.nP.d(bVar.getPrice(), bVar.eG(), true);
            aVar.nP.setVisibility(0);
            aVar.nO.setVisibility(8);
            eD();
        }
        this.mF.mG.f(bVar.eH(), 0);
    }

    private void d(AdInfo adInfo) {
        if (com.kwad.sdk.core.response.helper.a.co(adInfo) == 2) {
            this.nK.w(com.kwad.sdk.core.response.helper.a.cV(adInfo));
            this.nK.x(com.kwad.sdk.core.response.helper.a.cu(adInfo));
            CharSequence charSequenceB = com.kwad.sdk.core.response.helper.a.b(adInfo, com.kwad.components.core.widget.e.awy);
            if (TextUtils.isEmpty(charSequenceB)) {
                charSequenceB = com.kwad.sdk.core.response.helper.a.cU(adInfo);
            }
            this.nK.a(charSequenceB);
            if (com.kwad.sdk.core.response.helper.a.cR(adInfo)) {
                this.nK.z(com.kwad.components.ad.e.b.aE());
                return;
            } else {
                this.nK.z(com.kwad.components.ad.e.b.aH());
                return;
            }
        }
        if (com.kwad.components.ad.interstitial.b.b.dS() && com.kwad.sdk.core.response.helper.a.co(adInfo) == 3) {
            AdProductInfo adProductInfoDc = com.kwad.sdk.core.response.helper.a.dc(adInfo);
            this.nK.w(adProductInfoDc.icon);
            this.nK.x(adProductInfoDc.name);
            this.nK.y(adProductInfoDc.originPrice);
            this.nK.setPrice(adProductInfoDc.price);
            this.nK.z(com.kwad.components.ad.e.b.aF());
            return;
        }
        if (com.kwad.sdk.core.response.helper.a.aL(adInfo)) {
            this.nK.w(com.kwad.sdk.core.response.helper.a.cv(adInfo));
            if (!TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.aB(adInfo))) {
                this.nK.x(com.kwad.sdk.core.response.helper.a.aB(adInfo));
            } else if (!TextUtils.isEmpty(adInfo.advertiserInfo.adAuthorText)) {
                this.nK.x(adInfo.advertiserInfo.adAuthorText);
            } else {
                this.nK.x(getContext().getString(R.string.ksad_ad_default_username_normal));
            }
            this.nK.a(com.kwad.sdk.core.response.helper.a.aA(adInfo));
            this.nK.z(com.kwad.sdk.core.response.helper.a.aK(adInfo));
            return;
        }
        this.nK.w(com.kwad.sdk.core.response.helper.a.cv(adInfo));
        if (!TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.aD(adInfo))) {
            this.nK.x(com.kwad.sdk.core.response.helper.a.aD(adInfo));
        } else if (!TextUtils.isEmpty(adInfo.advertiserInfo.adAuthorText)) {
            this.nK.x(adInfo.advertiserInfo.adAuthorText);
        } else {
            this.nK.x(getContext().getString(R.string.ksad_ad_default_username_normal));
        }
        this.nK.a(com.kwad.sdk.core.response.helper.a.aA(adInfo));
        this.nK.z(com.kwad.sdk.core.response.helper.a.aK(adInfo));
    }

    private void eD() {
        View viewFindViewById = this.mF.mG.findViewById(R.id.ksad_ad_desc_layout);
        View viewFindViewById2 = this.mF.mG.findViewById(R.id.ksad_space);
        LinearLayout.LayoutParams layoutParams = (LinearLayout.LayoutParams) viewFindViewById.getLayoutParams();
        layoutParams.weight = 2.68f;
        viewFindViewById.setLayoutParams(layoutParams);
        viewFindViewById2.setVisibility(8);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
    }

    static class a {
        private ImageView nM;
        private TextView nN;
        private TextView nO;
        private KsPriceView nP;

        a() {
        }
    }

    static class b {
        private String appIconUrl;
        private String nQ;
        private CharSequence nR;
        private String nS;
        private String nT;
        private String price;

        b() {
        }

        public final String getAppIconUrl() {
            return this.appIconUrl;
        }

        public final void w(String str) {
            this.appIconUrl = str;
        }

        public final String eE() {
            return this.nQ;
        }

        public final void x(String str) {
            this.nQ = str;
        }

        public final CharSequence eF() {
            return this.nR;
        }

        public final void a(CharSequence charSequence) {
            this.nR = charSequence;
        }

        public final String eG() {
            return this.nS;
        }

        public final void y(String str) {
            this.nS = str;
        }

        public final String getPrice() {
            return this.price;
        }

        public final void setPrice(String str) {
            this.price = str;
        }

        public final String eH() {
            return this.nT;
        }

        public final void z(String str) {
            this.nT = str;
        }
    }
}
