package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class eg implements com.kwad.sdk.core.d<com.kwad.components.ad.draw.a.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.ad.draw.a.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.ad.draw.a.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.ad.draw.a.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.status = jSONObject.optInt("status");
        aVar.methodName = jSONObject.optString("method_name");
        if (JSONObject.NULL.toString().equals(aVar.methodName)) {
            aVar.methodName = "";
        }
        aVar.materialType = jSONObject.optInt("material_type");
        aVar.materialUrl = jSONObject.optString("material_url");
        if (JSONObject.NULL.toString().equals(aVar.materialUrl)) {
            aVar.materialUrl = "";
        }
        aVar.adNum = jSONObject.optInt("ad_num");
        aVar.loadTime = jSONObject.optLong("load_ad_duration_ms");
        aVar.renderTime = jSONObject.optLong("render_duration_ms");
        aVar.dI = jSONObject.optLong("request_ad_duration_ms");
        aVar.renderType = jSONObject.optInt("render_type");
        aVar.dJ = jSONObject.optInt("expect_render_type");
        aVar.adStyle = jSONObject.optInt("ad_style");
    }

    private static JSONObject b(com.kwad.components.ad.draw.a.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.status != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "status", aVar.status);
        }
        if (aVar.methodName != null && !aVar.methodName.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "method_name", aVar.methodName);
        }
        if (aVar.materialType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "material_type", aVar.materialType);
        }
        if (aVar.materialUrl != null && !aVar.materialUrl.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "material_url", aVar.materialUrl);
        }
        if (aVar.adNum != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_num", aVar.adNum);
        }
        if (aVar.loadTime != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "load_ad_duration_ms", aVar.loadTime);
        }
        if (aVar.renderTime != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "render_duration_ms", aVar.renderTime);
        }
        if (aVar.dI != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "request_ad_duration_ms", aVar.dI);
        }
        if (aVar.renderType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "render_type", aVar.renderType);
        }
        if (aVar.dJ != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "expect_render_type", aVar.dJ);
        }
        if (aVar.adStyle != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_style", aVar.adStyle);
        }
        return jSONObject;
    }
}
