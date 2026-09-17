package com.kwad.components.ad.fullscreen;

import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public final boolean jE = com.kwad.components.ad.reward.a.b.hY();
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;

    public b(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
    }

    public final AdTemplate getAdTemplate() {
        return this.mAdTemplate;
    }

    public final AdInfo cW() {
        return this.mAdInfo;
    }

    public final boolean cX() {
        return com.kwad.sdk.core.response.helper.e.eY(this.mAdTemplate);
    }
}
