package com.kwad.components.ad.interstitial;

import com.kwad.sdk.api.KsInterstitialAd;
import com.kwad.sdk.core.response.model.AdResultData;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    public static KsInterstitialAd f(AdResultData adResultData) {
        int iFe = com.kwad.sdk.core.response.helper.e.fe(com.kwad.sdk.core.response.helper.c.r(adResultData));
        if (iFe == 1) {
            return new com.kwad.components.ad.interstitial.e.a(true, adResultData);
        }
        if (iFe == 2) {
            return new com.kwad.components.ad.interstitial.e.a(false, adResultData);
        }
        return new b(adResultData);
    }
}
