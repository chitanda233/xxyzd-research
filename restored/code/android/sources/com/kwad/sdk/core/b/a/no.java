package com.kwad.sdk.core.b.a;

import com.alipay.sdk.app.AlipayApi;
import com.kwad.components.offline.api.tk.model.report.TKDownloadReason;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class no implements com.kwad.sdk.core.d<com.kwad.components.core.webview.jshandler.aj.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.jshandler.aj.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.jshandler.aj.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.jshandler.aj.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.type = jSONObject.optInt("type");
        aVar.appName = jSONObject.optString("appName");
        if (JSONObject.NULL.toString().equals(aVar.appName)) {
            aVar.appName = "";
        }
        aVar.pkgName = jSONObject.optString("pkgName");
        if (JSONObject.NULL.toString().equals(aVar.pkgName)) {
            aVar.pkgName = "";
        }
        aVar.version = jSONObject.optString("version");
        if (JSONObject.NULL.toString().equals(aVar.version)) {
            aVar.version = "";
        }
        aVar.versionCode = jSONObject.optInt("versionCode");
        aVar.aqG = jSONObject.optInt("appSize");
        aVar.md5 = jSONObject.optString(TKDownloadReason.KSAD_TK_MD5);
        if (JSONObject.NULL.toString().equals(aVar.md5)) {
            aVar.md5 = "";
        }
        aVar.url = jSONObject.optString("url");
        if (JSONObject.NULL.toString().equals(aVar.url)) {
            aVar.url = "";
        }
        aVar.aqH = jSONObject.optString("appLink");
        if (JSONObject.NULL.toString().equals(aVar.aqH)) {
            aVar.aqH = "";
        }
        aVar.icon = jSONObject.optString("icon");
        if (JSONObject.NULL.toString().equals(aVar.icon)) {
            aVar.icon = "";
        }
        aVar.tM = jSONObject.optString("desc");
        if (JSONObject.NULL.toString().equals(aVar.tM)) {
            aVar.tM = "";
        }
        aVar.appId = jSONObject.optString(AlipayApi.c);
        if (JSONObject.NULL.toString().equals(aVar.appId)) {
            aVar.appId = "";
        }
        aVar.aqI = jSONObject.optString("marketUri");
        if (JSONObject.NULL.toString().equals(aVar.aqI)) {
            aVar.aqI = "";
        }
        aVar.aqJ = jSONObject.optBoolean("disableLandingPageDeepLink");
        aVar.aqK = jSONObject.optBoolean("isLandscapeSupported");
        aVar.aqL = jSONObject.optBoolean("isFromLive");
    }

    private static JSONObject b(com.kwad.components.core.webview.jshandler.aj.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.type != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "type", aVar.type);
        }
        if (aVar.appName != null && !aVar.appName.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "appName", aVar.appName);
        }
        if (aVar.pkgName != null && !aVar.pkgName.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "pkgName", aVar.pkgName);
        }
        if (aVar.version != null && !aVar.version.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "version", aVar.version);
        }
        if (aVar.versionCode != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "versionCode", aVar.versionCode);
        }
        if (aVar.aqG != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "appSize", aVar.aqG);
        }
        if (aVar.md5 != null && !aVar.md5.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, TKDownloadReason.KSAD_TK_MD5, aVar.md5);
        }
        if (aVar.url != null && !aVar.url.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "url", aVar.url);
        }
        if (aVar.aqH != null && !aVar.aqH.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "appLink", aVar.aqH);
        }
        if (aVar.icon != null && !aVar.icon.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "icon", aVar.icon);
        }
        if (aVar.tM != null && !aVar.tM.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "desc", aVar.tM);
        }
        if (aVar.appId != null && !aVar.appId.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, AlipayApi.c, aVar.appId);
        }
        if (aVar.aqI != null && !aVar.aqI.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "marketUri", aVar.aqI);
        }
        if (aVar.aqJ) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "disableLandingPageDeepLink", aVar.aqJ);
        }
        if (aVar.aqK) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "isLandscapeSupported", aVar.aqK);
        }
        if (aVar.aqL) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "isFromLive", aVar.aqL);
        }
        return jSONObject;
    }
}
