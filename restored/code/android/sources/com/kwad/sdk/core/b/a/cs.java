package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class cs implements com.kwad.sdk.core.d<com.kwad.components.core.webview.tachikoma.c.g> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.tachikoma.c.g) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.tachikoma.c.g) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.tachikoma.c.g gVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        gVar.QQ = jSONObject.optString("payload");
        if (JSONObject.NULL.toString().equals(gVar.QQ)) {
            gVar.QQ = "";
        }
        gVar.actionType = jSONObject.optInt("actionType");
        gVar.apq = jSONObject.optInt("adCacheId");
        gVar.Pu = jSONObject.optString("creativeId");
        if (JSONObject.NULL.toString().equals(gVar.Pu)) {
            gVar.Pu = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.webview.tachikoma.c.g gVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (gVar.QQ != null && !gVar.QQ.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "payload", gVar.QQ);
        }
        if (gVar.actionType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "actionType", gVar.actionType);
        }
        if (gVar.apq != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "adCacheId", gVar.apq);
        }
        if (gVar.Pu != null && !gVar.Pu.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "creativeId", gVar.Pu);
        }
        return jSONObject;
    }
}
