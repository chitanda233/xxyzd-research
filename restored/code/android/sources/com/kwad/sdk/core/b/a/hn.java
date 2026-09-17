package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class hn implements com.kwad.sdk.core.d<com.kwad.components.core.b.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.b.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.b.b) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.b.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.title = jSONObject.optString(com.alipay.sdk.m.c0.d.w);
        if (JSONObject.NULL.toString().equals(bVar.title)) {
            bVar.title = "";
        }
        bVar.OU = jSONObject.optString("titleTextColor");
        if (JSONObject.NULL.toString().equals(bVar.OU)) {
            bVar.OU = "";
        }
        bVar.OV = jSONObject.optString("titleBackgroundColor");
        if (JSONObject.NULL.toString().equals(bVar.OV)) {
            bVar.OV = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.b.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.title != null && !bVar.title.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, com.alipay.sdk.m.c0.d.w, bVar.title);
        }
        if (bVar.OU != null && !bVar.OU.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "titleTextColor", bVar.OU);
        }
        if (bVar.OV != null && !bVar.OV.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "titleBackgroundColor", bVar.OV);
        }
        return jSONObject;
    }
}
