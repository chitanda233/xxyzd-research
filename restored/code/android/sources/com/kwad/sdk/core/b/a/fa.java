package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class fa implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.followuser.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.followuser.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.followuser.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.followuser.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.To = jSONObject.optString("toUserId");
        if (JSONObject.NULL.toString().equals(aVar.To)) {
            aVar.To = "";
        }
        aVar.Tp = jSONObject.optInt("fType");
    }

    private static JSONObject b(com.kwad.components.core.innerEc.followuser.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.To != null && !aVar.To.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "toUserId", aVar.To);
        }
        if (aVar.Tp != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "fType", aVar.Tp);
        }
        return jSONObject;
    }
}
