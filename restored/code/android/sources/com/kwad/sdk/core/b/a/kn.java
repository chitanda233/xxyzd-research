package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class kn implements com.kwad.sdk.core.d<com.kwad.components.core.pfmonitor.model.f> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.pfmonitor.model.f) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.pfmonitor.model.f) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.pfmonitor.model.f fVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        fVar.aip = jSONObject.optString("pathName");
        if (JSONObject.NULL.toString().equals(fVar.aip)) {
            fVar.aip = "";
        }
        fVar.fileName = jSONObject.optString("fileName");
        if (JSONObject.NULL.toString().equals(fVar.fileName)) {
            fVar.fileName = "";
        }
        fVar.aiC = jSONObject.optString("absPath");
        if (JSONObject.NULL.toString().equals(fVar.aiC)) {
            fVar.aiC = "";
        }
        fVar.aiD = jSONObject.optLong("diskSize");
    }

    private static JSONObject b(com.kwad.components.core.pfmonitor.model.f fVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (fVar.aip != null && !fVar.aip.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "pathName", fVar.aip);
        }
        if (fVar.fileName != null && !fVar.fileName.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "fileName", fVar.fileName);
        }
        if (fVar.aiC != null && !fVar.aiC.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "absPath", fVar.aiC);
        }
        if (fVar.aiD != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "diskSize", fVar.aiD);
        }
        return jSONObject;
    }
}
