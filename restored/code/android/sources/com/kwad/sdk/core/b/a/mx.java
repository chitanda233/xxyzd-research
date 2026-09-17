package com.kwad.sdk.core.b.a;

import java.util.ArrayList;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class mx implements com.kwad.sdk.core.d<com.kwad.sdk.m.a.b.C0531b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.m.a.b.C0531b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.m.a.b.C0531b) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.m.a.b.C0531b c0531b, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c0531b.name = jSONObject.optString(com.alipay.sdk.m.n.c.e);
        if (JSONObject.NULL.toString().equals(c0531b.name)) {
            c0531b.name = "";
        }
        c0531b.bns = jSONObject.optBoolean("isStatic");
        c0531b.bnt = new ArrayList();
        JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray("paramList");
        if (jSONArrayOptJSONArray != null) {
            for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                com.kwad.sdk.m.a.b.a aVar = new com.kwad.sdk.m.a.b.a();
                aVar.parseJson(jSONArrayOptJSONArray.optJSONObject(i));
                c0531b.bnt.add(aVar);
            }
        }
    }

    private static JSONObject b(com.kwad.sdk.m.a.b.C0531b c0531b, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (c0531b.name != null && !c0531b.name.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, com.alipay.sdk.m.n.c.e, c0531b.name);
        }
        if (c0531b.bns) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "isStatic", c0531b.bns);
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, "paramList", c0531b.bnt);
        return jSONObject;
    }
}
