package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class kr implements com.kwad.sdk.core.d<com.kwad.components.ad.reward.h.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.ad.reward.h.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.ad.reward.h.b) bVar, jSONObject);
    }

    private static void a(com.kwad.components.ad.reward.h.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.jV = jSONObject.optLong("lastShowTimestamp");
        bVar.vF = jSONObject.optInt("jumpDirectCount");
    }

    private static JSONObject b(com.kwad.components.ad.reward.h.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.jV != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "lastShowTimestamp", bVar.jV);
        }
        if (bVar.vF != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "jumpDirectCount", bVar.vF);
        }
        return jSONObject;
    }
}
