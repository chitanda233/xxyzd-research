package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ml implements com.kwad.sdk.core.d<com.kwad.sdk.wrapper.l.a.C0541a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.wrapper.l.a.C0541a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.wrapper.l.a.C0541a) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.wrapper.l.a.C0541a c0541a, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c0541a.btW = jSONObject.optString("s_cn");
        if (JSONObject.NULL.toString().equals(c0541a.btW)) {
            c0541a.btW = "";
        }
        c0541a.btX = jSONObject.optString("s_mn");
        if (JSONObject.NULL.toString().equals(c0541a.btX)) {
            c0541a.btX = "";
        }
    }

    private static JSONObject b(com.kwad.sdk.wrapper.l.a.C0541a c0541a, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (c0541a.btW != null && !c0541a.btW.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "s_cn", c0541a.btW);
        }
        if (c0541a.btX != null && !c0541a.btX.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "s_mn", c0541a.btX);
        }
        return jSONObject;
    }
}
