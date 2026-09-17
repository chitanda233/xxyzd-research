package com.kwad.components.ad.feed;

import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class f {
    public static String l(AdTemplate adTemplate) {
        String strAA = com.kwad.sdk.core.response.helper.a.aA(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
        if (com.kwad.components.core.c.b.oI()) {
            return (adTemplate.fromCache ? "【cache】" : "") + strAA;
        }
        return strAA;
    }
}
