package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class iq implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.live.a.a.C0435a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.live.a.a.C0435a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.live.a.a.C0435a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.live.a.a.C0435a c0435a, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c0435a.TJ = jSONObject.optString("mCookieJson");
        if (JSONObject.NULL.toString().equals(c0435a.TJ)) {
            c0435a.TJ = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.innerEc.live.a.a.C0435a c0435a, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (c0435a.TJ != null && !c0435a.TJ.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "mCookieJson", c0435a.TJ);
        }
        return jSONObject;
    }
}
