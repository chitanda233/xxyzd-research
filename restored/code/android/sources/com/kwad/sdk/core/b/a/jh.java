package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class jh implements com.kwad.sdk.core.d<com.kwad.sdk.core.request.model.d> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.core.request.model.d) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.core.request.model.d) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.core.request.model.d dVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        dVar.aXo = jSONObject.optString("mac");
        if (JSONObject.NULL.toString().equals(dVar.aXo)) {
            dVar.aXo = "";
        }
        dVar.aXp = jSONObject.optString("kMac");
        if (JSONObject.NULL.toString().equals(dVar.aXp)) {
            dVar.aXp = "";
        }
        dVar.aXq = jSONObject.optInt("connectionType");
        dVar.operatorType = jSONObject.optInt("operatorType");
    }

    private static JSONObject b(com.kwad.sdk.core.request.model.d dVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (dVar.aXo != null && !dVar.aXo.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "mac", dVar.aXo);
        }
        if (dVar.aXp != null && !dVar.aXp.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "kMac", dVar.aXp);
        }
        if (dVar.aXq != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "connectionType", dVar.aXq);
        }
        if (dVar.operatorType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "operatorType", dVar.operatorType);
        }
        return jSONObject;
    }
}
