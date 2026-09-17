package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ih implements com.kwad.sdk.core.d<com.kwad.sdk.commercial.h.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.commercial.h.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.commercial.h.a) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.commercial.h.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.aKC = jSONObject.optString("origin_url");
        if (JSONObject.NULL.toString().equals(aVar.aKC)) {
            aVar.aKC = "";
        }
        aVar.aKD = jSONObject.optString("final_url");
        if (JSONObject.NULL.toString().equals(aVar.aKD)) {
            aVar.aKD = "";
        }
        aVar.aKu = jSONObject.optString("error_name");
        if (JSONObject.NULL.toString().equals(aVar.aKu)) {
            aVar.aKu = "";
        }
        aVar.aKE = jSONObject.optString("macro_type");
        if (JSONObject.NULL.toString().equals(aVar.aKE)) {
            aVar.aKE = "";
        }
    }

    private static JSONObject b(com.kwad.sdk.commercial.h.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.aKC != null && !aVar.aKC.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "origin_url", aVar.aKC);
        }
        if (aVar.aKD != null && !aVar.aKD.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "final_url", aVar.aKD);
        }
        if (aVar.aKu != null && !aVar.aKu.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "error_name", aVar.aKu);
        }
        if (aVar.aKE != null && !aVar.aKE.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "macro_type", aVar.aKE);
        }
        return jSONObject;
    }
}
