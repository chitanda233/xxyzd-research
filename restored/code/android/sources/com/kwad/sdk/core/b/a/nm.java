package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class nm implements com.kwad.sdk.core.d<com.kwad.components.core.offline.moitor.d> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.offline.moitor.d) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.offline.moitor.d) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.offline.moitor.d dVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        dVar.acZ = jSONObject.optString("load_module");
        if (JSONObject.NULL.toString().equals(dVar.acZ)) {
            dVar.acZ = "";
        }
        dVar.ada = jSONObject.optLong("load_status");
        dVar.adb = jSONObject.optLong("load_duration_ms");
        dVar.ade = jSONObject.optLong("update_duration_ms");
        dVar.add = jSONObject.optString("load_source");
        if (JSONObject.NULL.toString().equals(dVar.add)) {
            dVar.add = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.offline.moitor.d dVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (dVar.acZ != null && !dVar.acZ.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "load_module", dVar.acZ);
        }
        if (dVar.ada != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "load_status", dVar.ada);
        }
        if (dVar.adb != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "load_duration_ms", dVar.adb);
        }
        if (dVar.ade != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "update_duration_ms", dVar.ade);
        }
        if (dVar.add != null && !dVar.add.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "load_source", dVar.add);
        }
        return jSONObject;
    }
}
