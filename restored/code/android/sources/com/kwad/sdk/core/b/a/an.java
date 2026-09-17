package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class an implements com.kwad.sdk.core.d<com.kwad.components.core.webview.jshandler.a.C0464a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.jshandler.a.C0464a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.jshandler.a.C0464a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c0464a.Pu = jSONObject.optString("creativeId");
        if (JSONObject.NULL.toString().equals(c0464a.Pu)) {
            c0464a.Pu = "";
        }
        c0464a.apu = jSONObject.optString("targetMethod");
        if (JSONObject.NULL.toString().equals(c0464a.apu)) {
            c0464a.apu = "";
        }
        c0464a.apv = jSONObject.optString("methodParams");
        if (JSONObject.NULL.toString().equals(c0464a.apv)) {
            c0464a.apv = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.webview.jshandler.a.C0464a c0464a, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (c0464a.Pu != null && !c0464a.Pu.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "creativeId", c0464a.Pu);
        }
        if (c0464a.apu != null && !c0464a.apu.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "targetMethod", c0464a.apu);
        }
        if (c0464a.apv != null && !c0464a.apv.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "methodParams", c0464a.apv);
        }
        return jSONObject;
    }
}
