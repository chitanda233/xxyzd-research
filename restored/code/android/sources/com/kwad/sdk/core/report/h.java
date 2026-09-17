package com.kwad.sdk.core.report;

import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public class h extends com.kwad.sdk.core.response.a.a {
    public int aVp;
    public long creativeId;
    public long llsid;
    public int score;
    public String source = "union";

    public static h cD(AdTemplate adTemplate) {
        h hVar = new h();
        hVar.creativeId = com.kwad.sdk.core.response.helper.e.eW(adTemplate);
        hVar.llsid = com.kwad.sdk.core.response.helper.e.eJ(adTemplate);
        int iFa = com.kwad.sdk.core.response.helper.e.fa(adTemplate);
        hVar.score = iFa;
        hVar.aVp = iFa > 0 ? 1 : 0;
        return hVar;
    }

    public final String Nl() {
        return toJson().toString();
    }
}
