package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class nw implements com.kwad.sdk.core.d<com.kwad.components.ad.draw.view.c.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.ad.draw.view.c.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.ad.draw.view.c.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.ad.draw.view.c.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.status = jSONObject.optInt("status");
        aVar.gn = jSONObject.optBoolean("controlPlayerStatus");
    }

    private static JSONObject b(com.kwad.components.ad.draw.view.c.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.status != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "status", aVar.status);
        }
        if (aVar.gn) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "controlPlayerStatus", aVar.gn);
        }
        return jSONObject;
    }
}
