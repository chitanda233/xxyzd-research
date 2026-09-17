package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class of implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.live.config.net.i> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.live.config.net.i) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.live.config.net.i) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.live.config.net.i iVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        iVar.UE = jSONObject.optString("serverGroupPath");
        if (JSONObject.NULL.toString().equals(iVar.UE)) {
            iVar.UE = "";
        }
        iVar.UF = jSONObject.optString("enableWss");
        if (JSONObject.NULL.toString().equals(iVar.UF)) {
            iVar.UF = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.innerEc.live.config.net.i iVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (iVar.UE != null && !iVar.UE.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "serverGroupPath", iVar.UE);
        }
        if (iVar.UF != null && !iVar.UF.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "enableWss", iVar.UF);
        }
        return jSONObject;
    }
}
