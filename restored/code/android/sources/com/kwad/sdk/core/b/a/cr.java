package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class cr implements com.kwad.sdk.core.d<com.kwad.components.ad.reward.k.f.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.ad.reward.k.f.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.ad.reward.k.f.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.ad.reward.k.f.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.BQ = jSONObject.optBoolean("forceClose");
    }

    private static JSONObject b(com.kwad.components.ad.reward.k.f.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.BQ) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "forceClose", aVar.BQ);
        }
        return jSONObject;
    }
}
