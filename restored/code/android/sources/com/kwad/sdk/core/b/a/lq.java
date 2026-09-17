package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class lq implements com.kwad.sdk.core.d<com.kwad.components.core.innerEc.live.f.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.innerEc.live.f.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.innerEc.live.f.b) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.innerEc.live.f.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.XD = jSONObject.optString("areaCode");
        if (JSONObject.NULL.toString().equals(bVar.XD)) {
            bVar.XD = "";
        }
        bVar.XE = jSONObject.optLong("pendantResourceId");
        bVar.XF = jSONObject.optString("pendantCode");
        if (JSONObject.NULL.toString().equals(bVar.XF)) {
            bVar.XF = "";
        }
        bVar.action = jSONObject.optInt("action");
        bVar.XG = jSONObject.optString("eventData");
        if (JSONObject.NULL.toString().equals(bVar.XG)) {
            bVar.XG = "";
        }
        bVar.XI = jSONObject.optBoolean("needServerProcess");
        bVar.XJ = jSONObject.optBoolean("needBusinessHandle");
        bVar.XK = jSONObject.optString("callbackApi");
        if (JSONObject.NULL.toString().equals(bVar.XK)) {
            bVar.XK = "";
        }
        bVar.XL = jSONObject.optBoolean("needRandomCall");
        bVar.XM = jSONObject.optLong("randomRangeMillis");
        bVar.XN = jSONObject.optBoolean("needSignalFallback");
        bVar.XO = jSONObject.optString("callbackPath");
        if (JSONObject.NULL.toString().equals(bVar.XO)) {
            bVar.XO = "";
        }
    }

    private static JSONObject b(com.kwad.components.core.innerEc.live.f.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.XD != null && !bVar.XD.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "areaCode", bVar.XD);
        }
        if (bVar.XE != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "pendantResourceId", bVar.XE);
        }
        if (bVar.XF != null && !bVar.XF.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "pendantCode", bVar.XF);
        }
        if (bVar.action != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "action", bVar.action);
        }
        if (bVar.XG != null && !bVar.XG.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "eventData", bVar.XG);
        }
        if (bVar.XI) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "needServerProcess", bVar.XI);
        }
        if (bVar.XJ) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "needBusinessHandle", bVar.XJ);
        }
        if (bVar.XK != null && !bVar.XK.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "callbackApi", bVar.XK);
        }
        if (bVar.XL) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "needRandomCall", bVar.XL);
        }
        if (bVar.XM != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "randomRangeMillis", bVar.XM);
        }
        if (bVar.XN) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "needSignalFallback", bVar.XN);
        }
        if (bVar.XO != null && !bVar.XO.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "callbackPath", bVar.XO);
        }
        return jSONObject;
    }
}
