package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class jk implements com.kwad.sdk.core.d<com.kwad.components.core.offline.moitor.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.offline.moitor.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.offline.moitor.b) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.offline.moitor.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.acZ = jSONObject.optString("load_module");
        if (JSONObject.NULL.toString().equals(bVar.acZ)) {
            bVar.acZ = "";
        }
        bVar.ada = jSONObject.optLong("load_status");
        bVar.adb = jSONObject.optLong("load_duration_ms");
        bVar.adc = jSONObject.optLong("thread_core_size", new Long("0").longValue());
        bVar.add = jSONObject.optString("load_source");
        if (JSONObject.NULL.toString().equals(bVar.add)) {
            bVar.add = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.offline.moitor.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.acZ != null && !bVar.acZ.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "load_module", bVar.acZ);
        }
        if (bVar.ada != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "load_status", bVar.ada);
        }
        if (bVar.adb != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "load_duration_ms", bVar.adb);
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, "thread_core_size", bVar.adc);
        if (bVar.add != null && !bVar.add.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "load_source", bVar.add);
        }
        return jSONObject;
    }
}
