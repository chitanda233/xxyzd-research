package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class fr implements com.kwad.sdk.core.d<com.kwad.components.core.webview.jshandler.j.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.jshandler.j.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.jshandler.j.b) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.jshandler.j.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.apF = jSONObject.optInt("playableSrc");
        bVar.apG = jSONObject.optInt("isMiddleEnd");
        bVar.abd = jSONObject.optInt("adType");
        bVar.apH = jSONObject.optString("showTime");
        if (JSONObject.NULL.toString().equals(bVar.apH)) {
            bVar.apH = "";
        }
        bVar.convertCount = jSONObject.optInt("convertCount");
    }

    private static JSONObject b(com.kwad.components.core.webview.jshandler.j.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.apF != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "playableSrc", bVar.apF);
        }
        if (bVar.apG != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "isMiddleEnd", bVar.apG);
        }
        if (bVar.abd != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "adType", bVar.abd);
        }
        if (bVar.apH != null && !bVar.apH.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "showTime", bVar.apH);
        }
        if (bVar.convertCount != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "convertCount", bVar.convertCount);
        }
        return jSONObject;
    }
}
