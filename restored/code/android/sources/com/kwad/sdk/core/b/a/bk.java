package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class bk implements com.kwad.sdk.core.d<com.kwad.sdk.commercial.a.b> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.commercial.a.b) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.commercial.a.b) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.commercial.a.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        bVar.status = jSONObject.optInt("status");
        bVar.url = jSONObject.optString("url");
        if (JSONObject.NULL.toString().equals(bVar.url)) {
            bVar.url = "";
        }
        bVar.aKa = jSONObject.optString("url_host");
        if (JSONObject.NULL.toString().equals(bVar.aKa)) {
            bVar.aKa = "";
        }
        bVar.downloadId = jSONObject.optString("download_id");
        if (JSONObject.NULL.toString().equals(bVar.downloadId)) {
            bVar.downloadId = "";
        }
        bVar.aKb = jSONObject.optString("apk_package");
        if (JSONObject.NULL.toString().equals(bVar.aKb)) {
            bVar.aKb = "";
        }
        bVar.aKc = jSONObject.optString("apk_name");
        if (JSONObject.NULL.toString().equals(bVar.aKc)) {
            bVar.aKc = "";
        }
        bVar.aKd = jSONObject.optLong("apk_size");
        bVar.downloadTime = jSONObject.optLong("download_time");
        bVar.aKe = jSONObject.optLong("apk_cur_size");
        bVar.aKf = jSONObject.optInt("apk_install_type");
        bVar.aKg = jSONObject.optInt("apk_install_source");
    }

    private static JSONObject b(com.kwad.sdk.commercial.a.b bVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (bVar.status != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "status", bVar.status);
        }
        if (bVar.url != null && !bVar.url.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "url", bVar.url);
        }
        if (bVar.aKa != null && !bVar.aKa.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "url_host", bVar.aKa);
        }
        if (bVar.downloadId != null && !bVar.downloadId.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "download_id", bVar.downloadId);
        }
        if (bVar.aKb != null && !bVar.aKb.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "apk_package", bVar.aKb);
        }
        if (bVar.aKc != null && !bVar.aKc.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "apk_name", bVar.aKc);
        }
        if (bVar.aKd != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "apk_size", bVar.aKd);
        }
        if (bVar.downloadTime != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "download_time", bVar.downloadTime);
        }
        if (bVar.aKe != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "apk_cur_size", bVar.aKe);
        }
        if (bVar.aKf != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "apk_install_type", bVar.aKf);
        }
        if (bVar.aKg != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "apk_install_source", bVar.aKg);
        }
        return jSONObject;
    }
}
