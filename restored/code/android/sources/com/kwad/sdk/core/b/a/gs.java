package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class gs implements com.kwad.sdk.core.d<com.kwad.sdk.a.a.a.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.a.a.a.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.a.a.a.a) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.a.a.a.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.jV = jSONObject.optLong("lastShowTimestamp");
        aVar.aul = jSONObject.optInt("showCount");
    }

    private static JSONObject b(com.kwad.sdk.a.a.a.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.jV != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "lastShowTimestamp", aVar.jV);
        }
        if (aVar.aul != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "showCount", aVar.aul);
        }
        return jSONObject;
    }
}
