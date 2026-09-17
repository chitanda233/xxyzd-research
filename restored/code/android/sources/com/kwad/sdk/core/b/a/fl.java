package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class fl implements com.kwad.sdk.core.d<com.kwad.sdk.m.b.a.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.m.b.a.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.m.b.a.b) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.m.b.a.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.key = jSONObject.optString("key");
        if (JSONObject.NULL.toString().equals(bVar.key)) {
            bVar.key = "";
        }
        bVar.value = jSONObject.optInt("value");
    }

    private static JSONObject b(com.kwad.sdk.m.b.a.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.key != null && !bVar.key.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "key", bVar.key);
        }
        if (bVar.value != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "value", bVar.value);
        }
        return jSONObject;
    }
}
