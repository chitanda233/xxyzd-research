package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class cq implements com.kwad.sdk.core.d<com.kwad.components.ad.reward.h.c> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.ad.reward.h.c) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.ad.reward.h.c) bVar, jSONObject);
    }

    private static void a(com.kwad.components.ad.reward.h.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        cVar.style = jSONObject.optInt("style");
        cVar.title = jSONObject.optString(com.alipay.sdk.m.c0.d.w);
        if (JSONObject.NULL.toString().equals(cVar.title)) {
            cVar.title = "";
        }
        cVar.tH = jSONObject.optString("closeBtnText");
        if (JSONObject.NULL.toString().equals(cVar.tH)) {
            cVar.tH = "";
        }
        cVar.tI = jSONObject.optString("continueBtnText");
        if (JSONObject.NULL.toString().equals(cVar.tI)) {
            cVar.tI = "";
        }
        cVar.tJ = jSONObject.optString("viewDetailText");
        if (JSONObject.NULL.toString().equals(cVar.tJ)) {
            cVar.tJ = "";
        }
        cVar.tK = jSONObject.optString("unWatchedVideoTime");
        if (JSONObject.NULL.toString().equals(cVar.tK)) {
            cVar.tK = "";
        }
        cVar.tL = jSONObject.optString("iconUrl");
        if (JSONObject.NULL.toString().equals(cVar.tL)) {
            cVar.tL = "";
        }
        cVar.tM = jSONObject.optString("desc");
        if (JSONObject.NULL.toString().equals(cVar.tM)) {
            cVar.tM = "";
        }
        cVar.tN = jSONObject.optString("descTxt");
        if (JSONObject.NULL.toString().equals(cVar.tN)) {
            cVar.tN = "";
        }
        cVar.tO = jSONObject.optString("currentPlayTime");
        if (JSONObject.NULL.toString().equals(cVar.tO)) {
            cVar.tO = "";
        }
    }

    private static JSONObject b(com.kwad.components.ad.reward.h.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (cVar.style != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "style", cVar.style);
        }
        if (cVar.title != null && !cVar.title.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, com.alipay.sdk.m.c0.d.w, cVar.title);
        }
        if (cVar.tH != null && !cVar.tH.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "closeBtnText", cVar.tH);
        }
        if (cVar.tI != null && !cVar.tI.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "continueBtnText", cVar.tI);
        }
        if (cVar.tJ != null && !cVar.tJ.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "viewDetailText", cVar.tJ);
        }
        if (cVar.tK != null && !cVar.tK.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "unWatchedVideoTime", cVar.tK);
        }
        if (cVar.tL != null && !cVar.tL.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "iconUrl", cVar.tL);
        }
        if (cVar.tM != null && !cVar.tM.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "desc", cVar.tM);
        }
        if (cVar.tN != null && !cVar.tN.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "descTxt", cVar.tN);
        }
        if (cVar.tO != null && !cVar.tO.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "currentPlayTime", cVar.tO);
        }
        return jSONObject;
    }
}
