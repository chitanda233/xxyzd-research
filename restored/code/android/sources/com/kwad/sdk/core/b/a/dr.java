package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class dr implements com.kwad.sdk.core.d<com.kwad.sdk.commercial.e.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.commercial.e.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.commercial.e.b) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.commercial.e.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.status = jSONObject.optInt("status");
        bVar.url = jSONObject.optString("url");
        if (JSONObject.NULL.toString().equals(bVar.url)) {
            bVar.url = "";
        }
        bVar.aKa = jSONObject.optString("url_host");
        if (JSONObject.NULL.toString().equals(bVar.aKa)) {
            bVar.aKa = "";
        }
        bVar.aKh = jSONObject.optString("url_path");
        if (JSONObject.NULL.toString().equals(bVar.aKh)) {
            bVar.aKh = "";
        }
    }

    private static JSONObject b(com.kwad.sdk.commercial.e.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.status != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "status", bVar.status);
        }
        if (bVar.url != null && !bVar.url.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "url", bVar.url);
        }
        if (bVar.aKa != null && !bVar.aKa.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "url_host", bVar.aKa);
        }
        if (bVar.aKh != null && !bVar.aKh.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "url_path", bVar.aKh);
        }
        return jSONObject;
    }
}
