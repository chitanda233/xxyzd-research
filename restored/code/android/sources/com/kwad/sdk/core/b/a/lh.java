package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class lh implements com.kwad.sdk.core.d<com.kwad.sdk.monitor.b.C0534b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.monitor.b.C0534b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.monitor.b.C0534b) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.monitor.b.C0534b c0534b, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c0534b.bjh = jSONObject.optInt("enable_monitor");
        c0534b.bji = jSONObject.optString("c_sc_name");
        if (JSONObject.NULL.toString().equals(c0534b.bji)) {
            c0534b.bji = "";
        }
        c0534b.bjj = jSONObject.optString("c_pcl_name");
        if (JSONObject.NULL.toString().equals(c0534b.bjj)) {
            c0534b.bjj = "";
        }
        c0534b.bjk = jSONObject.optString("m_gam_name");
        if (JSONObject.NULL.toString().equals(c0534b.bjk)) {
            c0534b.bjk = "";
        }
        c0534b.bjl = jSONObject.optString("m_gsv_name");
        if (JSONObject.NULL.toString().equals(c0534b.bjl)) {
            c0534b.bjl = "";
        }
        c0534b.bjm = jSONObject.optString("m_gpv_name");
        if (JSONObject.NULL.toString().equals(c0534b.bjm)) {
            c0534b.bjm = "";
        }
    }

    private static JSONObject b(com.kwad.sdk.monitor.b.C0534b c0534b, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (c0534b.bjh != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "enable_monitor", c0534b.bjh);
        }
        if (c0534b.bji != null && !c0534b.bji.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "c_sc_name", c0534b.bji);
        }
        if (c0534b.bjj != null && !c0534b.bjj.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "c_pcl_name", c0534b.bjj);
        }
        if (c0534b.bjk != null && !c0534b.bjk.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "m_gam_name", c0534b.bjk);
        }
        if (c0534b.bjl != null && !c0534b.bjl.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "m_gsv_name", c0534b.bjl);
        }
        if (c0534b.bjm != null && !c0534b.bjm.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "m_gpv_name", c0534b.bjm);
        }
        return jSONObject;
    }
}
