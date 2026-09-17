package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class od implements com.kwad.sdk.core.d<com.kwad.components.core.webview.jshandler.ay.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.jshandler.ay.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.jshandler.ay.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.jshandler.ay.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.arw = jSONObject.optString("windowFocusEvent");
        if (JSONObject.NULL.toString().equals(aVar.arw)) {
            aVar.arw = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.webview.jshandler.ay.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.arw != null && !aVar.arw.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "windowFocusEvent", aVar.arw);
        }
        return jSONObject;
    }
}
