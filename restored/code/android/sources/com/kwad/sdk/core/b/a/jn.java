package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class jn implements com.kwad.sdk.core.d<com.kwad.components.core.webview.a.c> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.a.c) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.a.c) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.a.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        cVar.apo = jSONObject.optString("originalID");
        if (JSONObject.NULL.toString().equals(cVar.apo)) {
            cVar.apo = "";
        }
        cVar.app = jSONObject.optString("path");
        if (JSONObject.NULL.toString().equals(cVar.app)) {
            cVar.app = "";
        }
        cVar.apq = jSONObject.optInt("adCacheId");
        cVar.Pu = jSONObject.optString("creativeId");
        if (JSONObject.NULL.toString().equals(cVar.Pu)) {
            cVar.Pu = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.webview.a.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (cVar.apo != null && !cVar.apo.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "originalID", cVar.apo);
        }
        if (cVar.app != null && !cVar.app.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "path", cVar.app);
        }
        if (cVar.apq != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "adCacheId", cVar.apq);
        }
        if (cVar.Pu != null && !cVar.Pu.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "creativeId", cVar.Pu);
        }
        return jSONObject;
    }
}
