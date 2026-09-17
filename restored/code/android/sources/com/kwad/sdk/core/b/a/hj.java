package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class hj implements com.kwad.sdk.core.d<com.kwad.components.core.webview.jsPublicBridge.a.a.C0463a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.jsPublicBridge.a.a.C0463a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.jsPublicBridge.a.a.C0463a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.jsPublicBridge.a.a.C0463a c0463a, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c0463a.apd = jSONObject.optInt("platform");
        c0463a.ape = jSONObject.optInt("flowSource");
        c0463a.apf = jSONObject.optInt("clientId");
        c0463a.appVersion = jSONObject.optString(com.sigmob.sdk.base.n.r);
        if (JSONObject.NULL.toString().equals(c0463a.appVersion)) {
            c0463a.appVersion = "";
        }
        c0463a.netType = jSONObject.optInt("net_type");
        c0463a.apg = jSONObject.optString("publicKey");
        if (JSONObject.NULL.toString().equals(c0463a.apg)) {
            c0463a.apg = "";
        }
        c0463a.aph = jSONObject.optString("sdkgetNumberName");
        if (JSONObject.NULL.toString().equals(c0463a.aph)) {
            c0463a.aph = "";
        }
        c0463a.api = jSONObject.optString("sdkoperJudgeName");
        if (JSONObject.NULL.toString().equals(c0463a.api)) {
            c0463a.api = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.webview.jsPublicBridge.a.a.C0463a c0463a, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (c0463a.apd != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "platform", c0463a.apd);
        }
        if (c0463a.ape != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "flowSource", c0463a.ape);
        }
        if (c0463a.apf != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "clientId", c0463a.apf);
        }
        if (c0463a.appVersion != null && !c0463a.appVersion.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, com.sigmob.sdk.base.n.r, c0463a.appVersion);
        }
        if (c0463a.netType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "net_type", c0463a.netType);
        }
        if (c0463a.apg != null && !c0463a.apg.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "publicKey", c0463a.apg);
        }
        if (c0463a.aph != null && !c0463a.aph.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sdkgetNumberName", c0463a.aph);
        }
        if (c0463a.api != null && !c0463a.api.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sdkoperJudgeName", c0463a.api);
        }
        return jSONObject;
    }
}
