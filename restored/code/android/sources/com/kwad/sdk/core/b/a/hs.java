package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class hs implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.live.config.net.c> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.live.config.net.c) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.live.config.net.c) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.live.config.net.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        cVar.name = jSONObject.optString(com.alipay.sdk.m.n.c.e);
        if (JSONObject.NULL.toString().equals(cVar.name)) {
            cVar.name = "";
        }
        cVar.Ur = jSONObject.optString("hearIcon");
        if (JSONObject.NULL.toString().equals(cVar.Ur)) {
            cVar.Ur = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.innerEc.live.config.net.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (cVar.name != null && !cVar.name.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, com.alipay.sdk.m.n.c.e, cVar.name);
        }
        if (cVar.Ur != null && !cVar.Ur.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "hearIcon", cVar.Ur);
        }
        return jSONObject;
    }
}
