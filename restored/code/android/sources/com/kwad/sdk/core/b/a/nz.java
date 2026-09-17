package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class nz implements com.kwad.sdk.core.d<com.kwad.components.core.webview.tachikoma.c.z> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.tachikoma.c.z) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.tachikoma.c.z) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.tachikoma.c.z zVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        zVar.ri = jSONObject.optInt("currentTime");
        zVar.auD = jSONObject.optBoolean(com.alipay.sdk.m.y.k.j);
        zVar.aji = jSONObject.optBoolean("finished");
    }

    private static JSONObject b(com.kwad.components.core.webview.tachikoma.c.z zVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (zVar.ri != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "currentTime", zVar.ri);
        }
        if (zVar.auD) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, com.alipay.sdk.m.y.k.j, zVar.auD);
        }
        if (zVar.aji) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "finished", zVar.aji);
        }
        return jSONObject;
    }
}
