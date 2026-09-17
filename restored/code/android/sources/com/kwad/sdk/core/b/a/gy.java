package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class gy implements com.kwad.sdk.core.d<com.kwad.components.ad.interstitial.c.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.ad.interstitial.c.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.ad.interstitial.c.b) bVar, jSONObject);
    }

    private static void a(com.kwad.components.ad.interstitial.c.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.jV = jSONObject.optLong("lastShowTimestamp");
        bVar.f2756ms = jSONObject.optInt("currentDailyAdShowCount");
        bVar.mt = jSONObject.optInt("currentDailyRetainShowCount");
    }

    private static JSONObject b(com.kwad.components.ad.interstitial.c.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.jV != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "lastShowTimestamp", bVar.jV);
        }
        if (bVar.f2756ms != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "currentDailyAdShowCount", bVar.f2756ms);
        }
        if (bVar.mt != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "currentDailyRetainShowCount", bVar.mt);
        }
        return jSONObject;
    }
}
