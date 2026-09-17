package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class lr implements com.kwad.sdk.core.d<com.kwad.components.core.webview.tachikoma.c.u> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.tachikoma.c.u) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.tachikoma.c.u) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.tachikoma.c.u uVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        uVar.auz = jSONObject.optBoolean("needPromopt");
        uVar.needReport = jSONObject.optBoolean("needReport");
        uVar.showTime = jSONObject.optInt("showTime");
        uVar.apx = jSONObject.optLong("playDuration");
    }

    private static JSONObject b(com.kwad.components.core.webview.tachikoma.c.u uVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (uVar.auz) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "needPromopt", uVar.auz);
        }
        if (uVar.needReport) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "needReport", uVar.needReport);
        }
        if (uVar.showTime != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "showTime", uVar.showTime);
        }
        if (uVar.apx != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "playDuration", uVar.apx);
        }
        return jSONObject;
    }
}
