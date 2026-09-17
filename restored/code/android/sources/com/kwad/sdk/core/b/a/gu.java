package com.kwad.sdk.core.b.a;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class gu implements com.kwad.sdk.core.d<com.kwad.components.ad.j.b.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.ad.j.b.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.ad.j.b.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.ad.j.b.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.Nh = jSONObject.optString("device_model");
        if (JSONObject.NULL.toString().equals(aVar.Nh)) {
            aVar.Nh = "";
        }
        aVar.Ni = jSONObject.optString("device_brand");
        if (JSONObject.NULL.toString().equals(aVar.Ni)) {
            aVar.Ni = "";
        }
        aVar.Nj = jSONObject.optString("os_version");
        if (JSONObject.NULL.toString().equals(aVar.Nj)) {
            aVar.Nj = "";
        }
        aVar.Nk = jSONObject.optString("rom_name");
        if (JSONObject.NULL.toString().equals(aVar.Nk)) {
            aVar.Nk = "";
        }
        aVar.Nl = jSONObject.optString("device_id");
        if (JSONObject.NULL.toString().equals(aVar.Nl)) {
            aVar.Nl = "";
        }
        aVar.status = jSONObject.optInt("status");
        aVar.Nm = jSONObject.optString("install_check_record");
        if (JSONObject.NULL.toString().equals(aVar.Nm)) {
            aVar.Nm = "";
        }
        aVar.Nn = jSONObject.optString("local_installer_pkgs");
        if (JSONObject.NULL.toString().equals(aVar.Nn)) {
            aVar.Nn = "";
        }
    }

    private static JSONObject b(com.kwad.components.ad.j.b.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.Nh != null && !aVar.Nh.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "device_model", aVar.Nh);
        }
        if (aVar.Ni != null && !aVar.Ni.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "device_brand", aVar.Ni);
        }
        if (aVar.Nj != null && !aVar.Nj.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "os_version", aVar.Nj);
        }
        if (aVar.Nk != null && !aVar.Nk.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "rom_name", aVar.Nk);
        }
        if (aVar.Nl != null && !aVar.Nl.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "device_id", aVar.Nl);
        }
        if (aVar.status != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "status", aVar.status);
        }
        if (aVar.Nm != null && !aVar.Nm.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "install_check_record", aVar.Nm);
        }
        if (aVar.Nn != null && !aVar.Nn.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "local_installer_pkgs", aVar.Nn);
        }
        return jSONObject;
    }
}
