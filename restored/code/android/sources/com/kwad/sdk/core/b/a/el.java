package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class el implements com.kwad.sdk.core.d<com.kwad.sdk.core.report.j> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.core.report.j) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.core.report.j) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.core.report.j jVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        jVar.aVq = jSONObject.optString("log");
        if (JSONObject.NULL.toString().equals(jVar.aVq)) {
            jVar.aVq = "";
        }
    }

    private static JSONObject b(com.kwad.sdk.core.report.j jVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (jVar.aVq != null && !jVar.aVq.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "log", jVar.aVq);
        }
        return jSONObject;
    }
}
