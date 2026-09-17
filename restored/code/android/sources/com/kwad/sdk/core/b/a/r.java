package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class r implements com.kwad.sdk.core.d<com.kwad.sdk.commercial.d.c> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.commercial.d.c) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.commercial.d.c) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.commercial.d.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        cVar.aKw = jSONObject.optString("imp_ad_info");
        if (JSONObject.NULL.toString().equals(cVar.aKw)) {
            cVar.aKw = "";
        }
        cVar.aKx = jSONObject.optString("final_imp_ad_info");
        if (JSONObject.NULL.toString().equals(cVar.aKx)) {
            cVar.aKx = "";
        }
    }

    private static JSONObject b(com.kwad.sdk.commercial.d.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (cVar.aKw != null && !cVar.aKw.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "imp_ad_info", cVar.aKw);
        }
        if (cVar.aKx != null && !cVar.aKx.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "final_imp_ad_info", cVar.aKx);
        }
        return jSONObject;
    }
}
