package com.kwad.components.ad.reward.presenter;

import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class i {
    public static boolean z(com.kwad.components.ad.reward.g gVar) {
        AdTemplate adTemplate = gVar.mAdTemplate;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if ((com.kwad.sdk.core.response.helper.a.bQ(adInfoEM) && gVar.ss != null && gVar.ss.vL()) || com.kwad.components.ad.reward.a.b.l(adInfoEM) || adTemplate.mXiaomiAppStoreDetailViewOpen) {
            return false;
        }
        if (com.kwad.components.ad.reward.a.b.hV()) {
            return true;
        }
        return com.kwad.sdk.core.response.helper.a.aL(adInfoEM) && com.kwad.sdk.core.response.helper.a.az(adInfoEM);
    }
}
