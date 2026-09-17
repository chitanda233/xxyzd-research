package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class fq implements com.kwad.sdk.core.d<com.kwad.components.core.webview.jshandler.j.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.jshandler.j.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.jshandler.j.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.jshandler.j.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.apE = jSONObject.optString("target");
        if (JSONObject.NULL.toString().equals(aVar.apE)) {
            aVar.apE = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.webview.jshandler.j.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.apE != null && !aVar.apE.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "target", aVar.apE);
        }
        return jSONObject;
    }
}
