package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class dw implements com.kwad.sdk.core.d<com.kwad.components.core.pfmonitor.model.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.pfmonitor.model.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.pfmonitor.model.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.pfmonitor.model.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.aip = jSONObject.optString("pathName");
        if (JSONObject.NULL.toString().equals(aVar.aip)) {
            aVar.aip = "";
        }
        aVar.aiq = jSONObject.optInt("pathType");
    }

    private static JSONObject b(com.kwad.components.core.pfmonitor.model.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.aip != null && !aVar.aip.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "pathName", aVar.aip);
        }
        if (aVar.aiq != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "pathType", aVar.aiq);
        }
        return jSONObject;
    }
}
