package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ea implements com.kwad.sdk.core.d<com.kwad.components.core.webview.a.a.C0461a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.a.a.C0461a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.a.a.C0461a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.a.a.C0461a c0461a, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c0461a.url = jSONObject.optString("url");
        if (JSONObject.NULL.toString().equals(c0461a.url)) {
            c0461a.url = "";
        }
        c0461a.packageName = jSONObject.optString("packageName");
        if (JSONObject.NULL.toString().equals(c0461a.packageName)) {
            c0461a.packageName = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.webview.a.a.C0461a c0461a, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (c0461a.url != null && !c0461a.url.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "url", c0461a.url);
        }
        if (c0461a.packageName != null && !c0461a.packageName.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "packageName", c0461a.packageName);
        }
        return jSONObject;
    }
}
