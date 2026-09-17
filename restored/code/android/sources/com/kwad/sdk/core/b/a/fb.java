package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class fb implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.followuser.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.followuser.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.followuser.b) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.followuser.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.Tq = jSONObject.optString("userId");
        if (JSONObject.NULL.toString().equals(bVar.Tq)) {
            bVar.Tq = "";
        }
        bVar.Tr = jSONObject.optBoolean("following");
    }

    private static JSONObject b(com.kwad.components.core.innerEc.followuser.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.Tq != null && !bVar.Tq.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "userId", bVar.Tq);
        }
        if (bVar.Tr) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "following", bVar.Tr);
        }
        return jSONObject;
    }
}
