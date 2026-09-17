package com.kwad.components.ad.interstitial.e;

import android.app.Activity;
import com.kwad.components.ad.fullscreen.g;
import com.kwad.components.ad.interstitial.c;
import com.kwad.sdk.api.KsInterstitialAd;
import com.kwad.sdk.api.KsVideoPlayConfig;
import com.kwad.sdk.core.response.model.AdResultData;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.b implements com.kwad.components.core.internal.api.a, KsInterstitialAd {
    private final boolean mw;
    private g mx;
    private com.kwad.components.ad.interstitial.b my;
    private final c mz;

    public a(boolean z, AdResultData adResultData) {
        super(adResultData);
        this.mw = z;
        if (z) {
            this.mx = new g(adResultData);
        } else {
            this.my = new com.kwad.components.ad.interstitial.b(adResultData);
        }
        this.mz = new c();
    }

    @Override // com.kwad.sdk.api.KsInterstitialAd
    public final void showInterstitialAd(Activity activity, KsVideoPlayConfig ksVideoPlayConfig) {
        if (this.mw) {
            this.mx.showFullScreenVideoAd(activity, ksVideoPlayConfig);
        } else {
            this.my.showInterstitialAd(activity, ksVideoPlayConfig);
        }
    }

    @Override // com.kwad.sdk.api.KsInterstitialAd
    public final void setAdInteractionListener(KsInterstitialAd.AdInteractionListener adInteractionListener) {
        this.mz.a(adInteractionListener);
        if (this.mw) {
            this.mx.setFullScreenVideoAdInteractionListener(this.mz);
        } else {
            this.my.setAdInteractionListener(this.mz);
        }
    }
}
