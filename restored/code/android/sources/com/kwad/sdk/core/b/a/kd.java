package com.kwad.sdk.core.b.a;

import com.alipay.sdk.app.AlipayApi;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class kd implements com.kwad.sdk.core.d<com.kwad.components.core.webview.jshandler.ah.a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.jshandler.ah.a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.jshandler.ah.a) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.jshandler.ah.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        aVar.SDKVersion = jSONObject.optString("SDKVersion");
        if (JSONObject.NULL.toString().equals(aVar.SDKVersion)) {
            aVar.SDKVersion = "";
        }
        aVar.SDKVersionCode = jSONObject.optInt("SDKVersionCode");
        aVar.sdkApiVersion = jSONObject.optString("sdkApiVersion");
        if (JSONObject.NULL.toString().equals(aVar.sdkApiVersion)) {
            aVar.sdkApiVersion = "";
        }
        aVar.sdkApiVersionCode = jSONObject.optInt("sdkApiVersionCode");
        aVar.sdkType = jSONObject.optInt("sdkType");
        aVar.appVersion = jSONObject.optString("appVersion");
        if (JSONObject.NULL.toString().equals(aVar.appVersion)) {
            aVar.appVersion = "";
        }
        aVar.appName = jSONObject.optString("appName");
        if (JSONObject.NULL.toString().equals(aVar.appName)) {
            aVar.appName = "";
        }
        aVar.appId = jSONObject.optString(AlipayApi.c);
        if (JSONObject.NULL.toString().equals(aVar.appId)) {
            aVar.appId = "";
        }
        aVar.aqw = jSONObject.optString("networkType");
        if (JSONObject.NULL.toString().equals(aVar.aqw)) {
            aVar.aqw = "";
        }
        aVar.aqx = jSONObject.optString("manufacturer");
        if (JSONObject.NULL.toString().equals(aVar.aqx)) {
            aVar.aqx = "";
        }
        aVar.model = jSONObject.optString(com.baidu.mobads.sdk.internal.bn.i);
        if (JSONObject.NULL.toString().equals(aVar.model)) {
            aVar.model = "";
        }
        aVar.Ni = jSONObject.optString("deviceBrand");
        if (JSONObject.NULL.toString().equals(aVar.Ni)) {
            aVar.Ni = "";
        }
        aVar.aqy = jSONObject.optInt("osType");
        aVar.aqz = jSONObject.optString("systemVersion");
        if (JSONObject.NULL.toString().equals(aVar.aqz)) {
            aVar.aqz = "";
        }
        aVar.aqA = jSONObject.optInt("osApi");
        aVar.aqB = jSONObject.optString(MediaFormat.KEY_LANGUAGE);
        if (JSONObject.NULL.toString().equals(aVar.aqB)) {
            aVar.aqB = "";
        }
        aVar.Uv = jSONObject.optString("locale");
        if (JSONObject.NULL.toString().equals(aVar.Uv)) {
            aVar.Uv = "";
        }
        aVar.Si = jSONObject.optInt("screenWidth");
        aVar.Sh = jSONObject.optInt("screenHeight");
        aVar.aqC = jSONObject.optInt("statusBarHeight");
        aVar.aqD = jSONObject.optInt("titleBarHeight");
    }

    private static JSONObject b(com.kwad.components.core.webview.jshandler.ah.a aVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (aVar.SDKVersion != null && !aVar.SDKVersion.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "SDKVersion", aVar.SDKVersion);
        }
        if (aVar.SDKVersionCode != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "SDKVersionCode", aVar.SDKVersionCode);
        }
        if (aVar.sdkApiVersion != null && !aVar.sdkApiVersion.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sdkApiVersion", aVar.sdkApiVersion);
        }
        if (aVar.sdkApiVersionCode != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sdkApiVersionCode", aVar.sdkApiVersionCode);
        }
        if (aVar.sdkType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sdkType", aVar.sdkType);
        }
        if (aVar.appVersion != null && !aVar.appVersion.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "appVersion", aVar.appVersion);
        }
        if (aVar.appName != null && !aVar.appName.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "appName", aVar.appName);
        }
        if (aVar.appId != null && !aVar.appId.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, AlipayApi.c, aVar.appId);
        }
        if (aVar.aqw != null && !aVar.aqw.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "networkType", aVar.aqw);
        }
        if (aVar.aqx != null && !aVar.aqx.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "manufacturer", aVar.aqx);
        }
        if (aVar.model != null && !aVar.model.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, com.baidu.mobads.sdk.internal.bn.i, aVar.model);
        }
        if (aVar.Ni != null && !aVar.Ni.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "deviceBrand", aVar.Ni);
        }
        if (aVar.aqy != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "osType", aVar.aqy);
        }
        if (aVar.aqz != null && !aVar.aqz.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "systemVersion", aVar.aqz);
        }
        if (aVar.aqA != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "osApi", aVar.aqA);
        }
        if (aVar.aqB != null && !aVar.aqB.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, MediaFormat.KEY_LANGUAGE, aVar.aqB);
        }
        if (aVar.Uv != null && !aVar.Uv.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "locale", aVar.Uv);
        }
        if (aVar.Si != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "screenWidth", aVar.Si);
        }
        if (aVar.Sh != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "screenHeight", aVar.Sh);
        }
        if (aVar.aqC != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "statusBarHeight", aVar.aqC);
        }
        if (aVar.aqD != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "titleBarHeight", aVar.aqD);
        }
        return jSONObject;
    }
}
