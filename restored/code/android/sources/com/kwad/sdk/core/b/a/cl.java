package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class cl implements com.kwad.sdk.core.d<com.kwad.sdk.core.adlog.a.C0502a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.core.adlog.a.C0502a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.core.adlog.a.C0502a) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.core.adlog.a.C0502a c0502a, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c0502a.aLh = jSONObject.optInt("ad_retry_type");
        c0502a.templateId = jSONObject.optString("template_id");
        if (JSONObject.NULL.toString().equals(c0502a.templateId)) {
            c0502a.templateId = "";
        }
        c0502a.aLi = jSONObject.optString("template_sub_id");
        if (JSONObject.NULL.toString().equals(c0502a.aLi)) {
            c0502a.aLi = "";
        }
        c0502a.aLj = jSONObject.optString("default_type");
        if (JSONObject.NULL.toString().equals(c0502a.aLj)) {
            c0502a.aLj = "";
        }
        c0502a.aLl = jSONObject.optString("template_show_type");
        if (JSONObject.NULL.toString().equals(c0502a.aLl)) {
            c0502a.aLl = "";
        }
        c0502a.aLm = jSONObject.optInt("network_download_status", new Integer("3").intValue());
        c0502a.aLn = jSONObject.optInt("award_task_name");
        c0502a.aLo = jSONObject.optInt("jumps_liveroom_type");
        c0502a.aLp = jSONObject.optInt("universe_feature_freg");
        c0502a.aLq = jSONObject.optInt("replace_url_succ");
        c0502a.aLr = jSONObject.optBoolean("is_dp_opt");
        c0502a.aLs = jSONObject.optString("component_module");
        if (JSONObject.NULL.toString().equals(c0502a.aLs)) {
            c0502a.aLs = "";
        }
        c0502a.aLu = jSONObject.optInt("is_carousel");
        c0502a.aLv = jSONObject.optInt("is_special_preload");
        c0502a.aLw = jSONObject.optInt("card_type");
        c0502a.aLx = jSONObject.optInt("is_closure");
        c0502a.aLy = jSONObject.optInt("is_click_invoked");
        c0502a.aLz = jSONObject.optString("authorization_status");
        if (JSONObject.NULL.toString().equals(c0502a.aLz)) {
            c0502a.aLz = "";
        }
        c0502a.aLA = jSONObject.optString("login_source");
        if (JSONObject.NULL.toString().equals(c0502a.aLA)) {
            c0502a.aLA = "";
        }
        c0502a.aLB = jSONObject.optInt("is_login");
        c0502a.aLC = jSONObject.optInt("interception_time");
        c0502a.aLD = jSONObject.optInt("interception_reason");
        c0502a.aLE = jSONObject.optInt("coupon_receive_status");
        c0502a.aLG = jSONObject.optInt("deeplink_evocation_source");
    }

    private static JSONObject b(com.kwad.sdk.core.adlog.a.C0502a c0502a, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (c0502a.aLh != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "ad_retry_type", c0502a.aLh);
        }
        if (c0502a.templateId != null && !c0502a.templateId.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "template_id", c0502a.templateId);
        }
        if (c0502a.aLi != null && !c0502a.aLi.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "template_sub_id", c0502a.aLi);
        }
        if (c0502a.aLj != null && !c0502a.aLj.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "default_type", c0502a.aLj);
        }
        if (c0502a.aLl != null && !c0502a.aLl.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "template_show_type", c0502a.aLl);
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, "network_download_status", c0502a.aLm);
        if (c0502a.aLn != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "award_task_name", c0502a.aLn);
        }
        if (c0502a.aLo != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "jumps_liveroom_type", c0502a.aLo);
        }
        if (c0502a.aLp != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "universe_feature_freg", c0502a.aLp);
        }
        if (c0502a.aLq != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "replace_url_succ", c0502a.aLq);
        }
        if (c0502a.aLr) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "is_dp_opt", c0502a.aLr);
        }
        if (c0502a.aLs != null && !c0502a.aLs.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "component_module", c0502a.aLs);
        }
        if (c0502a.aLu != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "is_carousel", c0502a.aLu);
        }
        if (c0502a.aLv != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "is_special_preload", c0502a.aLv);
        }
        if (c0502a.aLw != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "card_type", c0502a.aLw);
        }
        if (c0502a.aLx != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "is_closure", c0502a.aLx);
        }
        if (c0502a.aLy != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "is_click_invoked", c0502a.aLy);
        }
        if (c0502a.aLz != null && !c0502a.aLz.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "authorization_status", c0502a.aLz);
        }
        if (c0502a.aLA != null && !c0502a.aLA.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "login_source", c0502a.aLA);
        }
        if (c0502a.aLB != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "is_login", c0502a.aLB);
        }
        if (c0502a.aLC != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "interception_time", c0502a.aLC);
        }
        if (c0502a.aLD != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "interception_reason", c0502a.aLD);
        }
        if (c0502a.aLE != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "coupon_receive_status", c0502a.aLE);
        }
        if (c0502a.aLG != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "deeplink_evocation_source", c0502a.aLG);
        }
        return jSONObject;
    }
}
