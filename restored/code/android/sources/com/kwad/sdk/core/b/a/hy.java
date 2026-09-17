package com.kwad.sdk.core.b.a;

import java.util.ArrayList;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class hy implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.live.config.net.e> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.live.config.net.e) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.live.config.net.e) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.live.config.net.e eVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        eVar.Ux = new ArrayList();
        JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray("playUrls");
        if (jSONArrayOptJSONArray != null) {
            for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                com.kwad.components.core.innerEc.live.config.net.f fVar = new com.kwad.components.core.innerEc.live.config.net.f();
                fVar.parseJson(jSONArrayOptJSONArray.optJSONObject(i));
                eVar.Ux.add(fVar);
            }
        }
    }

    private static JSONObject b(com.kwad.components.core.innerEc.live.config.net.e eVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, "playUrls", eVar.Ux);
        return jSONObject;
    }
}
