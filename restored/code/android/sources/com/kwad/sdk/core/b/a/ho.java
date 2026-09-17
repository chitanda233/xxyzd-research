package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ho implements com.kwad.sdk.core.d<com.kwad.sdk.utils.b.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.utils.b.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.utils.b.a) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.utils.b.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.bsG = jSONObject.optInt("put_count");
        aVar.bsH = jSONObject.optInt("get_failed_count");
        aVar.bsI = jSONObject.optInt("get_success_count");
    }

    private static JSONObject b(com.kwad.sdk.utils.b.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.bsG != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "put_count", aVar.bsG);
        }
        if (aVar.bsH != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "get_failed_count", aVar.bsH);
        }
        if (aVar.bsI != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "get_success_count", aVar.bsI);
        }
        return jSONObject;
    }
}
