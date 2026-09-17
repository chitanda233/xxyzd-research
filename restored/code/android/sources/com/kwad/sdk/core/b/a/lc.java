package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class lc implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.live.base.c> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.live.base.c) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.live.base.c) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.live.base.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        cVar.TD = jSONObject.optString("accumulatedWatchCount");
        if (JSONObject.NULL.toString().equals(cVar.TD)) {
            cVar.TD = "";
        }
        cVar.TE = jSONObject.optString("liteAccumulatedWatchCount");
        if (JSONObject.NULL.toString().equals(cVar.TE)) {
            cVar.TE = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.innerEc.live.base.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (cVar.TD != null && !cVar.TD.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "accumulatedWatchCount", cVar.TD);
        }
        if (cVar.TE != null && !cVar.TE.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "liteAccumulatedWatchCount", cVar.TE);
        }
        return jSONObject;
    }
}
