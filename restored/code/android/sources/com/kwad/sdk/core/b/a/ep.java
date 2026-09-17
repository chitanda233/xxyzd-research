package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ep implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.live.config.net.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.live.config.net.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.live.config.net.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.live.config.net.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.Un = new com.kwad.components.core.innerEc.live.config.net.c();
        aVar.Un.parseJson(jSONObject.optJSONObject("authorInfo"));
    }

    private static JSONObject b(com.kwad.components.core.innerEc.live.config.net.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        com.kwad.sdk.utils.ac.a(jSONObject, "authorInfo", aVar.Un);
        return jSONObject;
    }
}
