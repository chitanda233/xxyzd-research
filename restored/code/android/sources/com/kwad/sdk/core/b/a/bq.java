package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class bq implements com.kwad.sdk.core.d<com.kwad.components.core.request.model.b.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.request.model.b.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.request.model.b.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.request.model.b.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.streamType = jSONObject.optInt("streamType");
        aVar.akq = jSONObject.optInt("maxVolume");
        aVar.akr = jSONObject.optInt("minVolume");
        aVar.aks = jSONObject.optInt("currentVolume");
    }

    private static JSONObject b(com.kwad.components.core.request.model.b.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.streamType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "streamType", aVar.streamType);
        }
        if (aVar.akq != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "maxVolume", aVar.akq);
        }
        if (aVar.akr != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "minVolume", aVar.akr);
        }
        if (aVar.aks != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "currentVolume", aVar.aks);
        }
        return jSONObject;
    }
}
