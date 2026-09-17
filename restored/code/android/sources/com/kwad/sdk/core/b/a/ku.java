package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class ku implements com.kwad.sdk.core.d<com.kwad.components.ad.reward.retryReward.c> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.ad.reward.retryReward.c) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.ad.reward.retryReward.c) bVar, jSONObject);
    }

    private static void a(com.kwad.components.ad.reward.retryReward.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        cVar.status = jSONObject.optInt("status");
        cVar.Br = jSONObject.optString("convert_url");
        if (JSONObject.NULL.toString().equals(cVar.Br)) {
            cVar.Br = "";
        }
        cVar.convertType = jSONObject.optInt("convert_type");
        cVar.Bs = jSONObject.optString("ad_desc");
        if (JSONObject.NULL.toString().equals(cVar.Bs)) {
            cVar.Bs = "";
        }
        cVar.productName = jSONObject.optString("product_name");
        if (JSONObject.NULL.toString().equals(cVar.productName)) {
            cVar.productName = "";
        }
        cVar.tL = jSONObject.optString("icon_url");
        if (JSONObject.NULL.toString().equals(cVar.tL)) {
            cVar.tL = "";
        }
        cVar.errorCode = jSONObject.optInt("error_code");
        cVar.errorMsg = jSONObject.optString("error_msg");
        if (JSONObject.NULL.toString().equals(cVar.errorMsg)) {
            cVar.errorMsg = "";
        }
    }

    private static JSONObject b(com.kwad.components.ad.reward.retryReward.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (cVar.status != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "status", cVar.status);
        }
        if (cVar.Br != null && !cVar.Br.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "convert_url", cVar.Br);
        }
        if (cVar.convertType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "convert_type", cVar.convertType);
        }
        if (cVar.Bs != null && !cVar.Bs.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_desc", cVar.Bs);
        }
        if (cVar.productName != null && !cVar.productName.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "product_name", cVar.productName);
        }
        if (cVar.tL != null && !cVar.tL.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "icon_url", cVar.tL);
        }
        if (cVar.errorCode != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "error_code", cVar.errorCode);
        }
        if (cVar.errorMsg != null && !cVar.errorMsg.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "error_msg", cVar.errorMsg);
        }
        return jSONObject;
    }
}
