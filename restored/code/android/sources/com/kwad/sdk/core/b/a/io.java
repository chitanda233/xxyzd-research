package com.kwad.sdk.core.b.a;

import com.kwad.sdk.monitor.MediaMessageInfo;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class io implements com.kwad.sdk.core.d<MediaMessageInfo> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((MediaMessageInfo) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((MediaMessageInfo) bVar, jSONObject);
    }

    private static void a(MediaMessageInfo mediaMessageInfo, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        mediaMessageInfo.Ni = jSONObject.optString("device_brand");
        if (JSONObject.NULL.toString().equals(mediaMessageInfo.Ni)) {
            mediaMessageInfo.Ni = "";
        }
        mediaMessageInfo.bjd = jSONObject.optString("permission_list");
        if (JSONObject.NULL.toString().equals(mediaMessageInfo.bjd)) {
            mediaMessageInfo.bjd = "";
        }
        mediaMessageInfo.bje = jSONObject.optString("appid");
        if (JSONObject.NULL.toString().equals(mediaMessageInfo.bje)) {
            mediaMessageInfo.bje = "";
        }
        mediaMessageInfo.bjf = jSONObject.optInt("device_os_id");
    }

    private static JSONObject b(MediaMessageInfo mediaMessageInfo, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (mediaMessageInfo.Ni != null && !mediaMessageInfo.Ni.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "device_brand", mediaMessageInfo.Ni);
        }
        if (mediaMessageInfo.bjd != null && !mediaMessageInfo.bjd.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "permission_list", mediaMessageInfo.bjd);
        }
        if (mediaMessageInfo.bje != null && !mediaMessageInfo.bje.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "appid", mediaMessageInfo.bje);
        }
        if (mediaMessageInfo.bjf != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "device_os_id", mediaMessageInfo.bjf);
        }
        return jSONObject;
    }
}
