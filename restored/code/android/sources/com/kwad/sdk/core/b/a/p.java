package com.kwad.sdk.core.b.a;

import com.kwad.sdk.core.response.model.AdCouponReceiveParam;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class p implements com.kwad.sdk.core.d<AdCouponReceiveParam> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((AdCouponReceiveParam) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((AdCouponReceiveParam) bVar, jSONObject);
    }

    private static void a(AdCouponReceiveParam adCouponReceiveParam, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        adCouponReceiveParam.receiveToast = jSONObject.optString("receiveToast");
        if (JSONObject.NULL.toString().equals(adCouponReceiveParam.receiveToast)) {
            adCouponReceiveParam.receiveToast = "";
        }
        adCouponReceiveParam.sign = jSONObject.optString("sign");
        if (JSONObject.NULL.toString().equals(adCouponReceiveParam.sign)) {
            adCouponReceiveParam.sign = "";
        }
        adCouponReceiveParam.ext = jSONObject.optString(com.sigmob.sdk.base.n.m);
        if (JSONObject.NULL.toString().equals(adCouponReceiveParam.ext)) {
            adCouponReceiveParam.ext = "";
        }
        adCouponReceiveParam.receiveFailToast = jSONObject.optString("receiveFailToast");
        if (JSONObject.NULL.toString().equals(adCouponReceiveParam.receiveFailToast)) {
            adCouponReceiveParam.receiveFailToast = "";
        }
        adCouponReceiveParam.flowType = jSONObject.optInt("flowType");
    }

    private static JSONObject b(AdCouponReceiveParam adCouponReceiveParam, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (adCouponReceiveParam.receiveToast != null && !adCouponReceiveParam.receiveToast.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "receiveToast", adCouponReceiveParam.receiveToast);
        }
        if (adCouponReceiveParam.sign != null && !adCouponReceiveParam.sign.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sign", adCouponReceiveParam.sign);
        }
        if (adCouponReceiveParam.ext != null && !adCouponReceiveParam.ext.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, com.sigmob.sdk.base.n.m, adCouponReceiveParam.ext);
        }
        if (adCouponReceiveParam.receiveFailToast != null && !adCouponReceiveParam.receiveFailToast.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "receiveFailToast", adCouponReceiveParam.receiveFailToast);
        }
        if (adCouponReceiveParam.flowType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "flowType", adCouponReceiveParam.flowType);
        }
        return jSONObject;
    }
}
