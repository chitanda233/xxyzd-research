package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class le implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.live.base.e> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.live.base.e) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.live.base.e) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.live.base.e eVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        eVar.TH = jSONObject.optBoolean("showYellowCart");
        eVar.TI = jSONObject.optInt("onSaleCount");
    }

    private static JSONObject b(com.kwad.components.core.innerEc.live.base.e eVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (eVar.TH) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "showYellowCart", eVar.TH);
        }
        if (eVar.TI != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "onSaleCount", eVar.TI);
        }
        return jSONObject;
    }
}
