package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class gw implements com.kwad.sdk.core.d<com.kwad.components.ad.interstitial.d.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.ad.interstitial.d.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.ad.interstitial.d.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.ad.interstitial.d.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.mu = jSONObject.optLong("lastShowCardTimeStamp");
        aVar.mv = jSONObject.optInt("cardShowCount");
    }

    private static JSONObject b(com.kwad.components.ad.interstitial.d.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.mu != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "lastShowCardTimeStamp", aVar.mu);
        }
        if (aVar.mv != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "cardShowCount", aVar.mv);
        }
        return jSONObject;
    }
}
