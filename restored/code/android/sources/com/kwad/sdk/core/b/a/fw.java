package com.kwad.sdk.core.b.a;

import com.alipay.sdk.app.AlipayApi;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class fw implements com.kwad.sdk.core.d<com.kwad.sdk.core.webview.d.a.C0521a> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.sdk.core.webview.d.a.C0521a) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.sdk.core.webview.d.a.C0521a) bVar, jSONObject);
    }

    private static void a(com.kwad.sdk.core.webview.d.a.C0521a c0521a, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        c0521a.SDKVersion = jSONObject.optString("SDKVersion");
        if (JSONObject.NULL.toString().equals(c0521a.SDKVersion)) {
            c0521a.SDKVersion = "";
        }
        c0521a.SDKVersionCode = jSONObject.optInt("SDKVersionCode");
        c0521a.aWn = jSONObject.optString("tkVersion");
        if (JSONObject.NULL.toString().equals(c0521a.aWn)) {
            c0521a.aWn = "";
        }
        c0521a.sdkApiVersion = jSONObject.optString("sdkApiVersion");
        if (JSONObject.NULL.toString().equals(c0521a.sdkApiVersion)) {
            c0521a.sdkApiVersion = "";
        }
        c0521a.sdkApiVersionCode = jSONObject.optInt("sdkApiVersionCode");
        c0521a.sdkType = jSONObject.optInt("sdkType");
        c0521a.appVersion = jSONObject.optString("appVersion");
        if (JSONObject.NULL.toString().equals(c0521a.appVersion)) {
            c0521a.appVersion = "";
        }
        c0521a.appName = jSONObject.optString("appName");
        if (JSONObject.NULL.toString().equals(c0521a.appName)) {
            c0521a.appName = "";
        }
        c0521a.appId = jSONObject.optString(AlipayApi.c);
        if (JSONObject.NULL.toString().equals(c0521a.appId)) {
            c0521a.appId = "";
        }
        c0521a.bda = jSONObject.optString("globalId");
        if (JSONObject.NULL.toString().equals(c0521a.bda)) {
            c0521a.bda = "";
        }
        c0521a.aXb = jSONObject.optString("eGid");
        if (JSONObject.NULL.toString().equals(c0521a.aXb)) {
            c0521a.aXb = "";
        }
        c0521a.aXa = jSONObject.optString("deviceSig");
        if (JSONObject.NULL.toString().equals(c0521a.aXa)) {
            c0521a.aXa = "";
        }
        c0521a.aqw = jSONObject.optString("networkType");
        if (JSONObject.NULL.toString().equals(c0521a.aqw)) {
            c0521a.aqw = "";
        }
        c0521a.aqx = jSONObject.optString("manufacturer");
        if (JSONObject.NULL.toString().equals(c0521a.aqx)) {
            c0521a.aqx = "";
        }
        c0521a.model = jSONObject.optString(com.baidu.mobads.sdk.internal.bn.i);
        if (JSONObject.NULL.toString().equals(c0521a.model)) {
            c0521a.model = "";
        }
        c0521a.Ni = jSONObject.optString("deviceBrand");
        if (JSONObject.NULL.toString().equals(c0521a.Ni)) {
            c0521a.Ni = "";
        }
        c0521a.aqy = jSONObject.optInt("osType");
        c0521a.aqz = jSONObject.optString("systemVersion");
        if (JSONObject.NULL.toString().equals(c0521a.aqz)) {
            c0521a.aqz = "";
        }
        c0521a.aqA = jSONObject.optInt("osApi");
        c0521a.aqB = jSONObject.optString(MediaFormat.KEY_LANGUAGE);
        if (JSONObject.NULL.toString().equals(c0521a.aqB)) {
            c0521a.aqB = "";
        }
        c0521a.Uv = jSONObject.optString("locale");
        if (JSONObject.NULL.toString().equals(c0521a.Uv)) {
            c0521a.Uv = "";
        }
        c0521a.bdb = jSONObject.optString("uuid");
        if (JSONObject.NULL.toString().equals(c0521a.bdb)) {
            c0521a.bdb = "";
        }
        c0521a.bdc = jSONObject.optBoolean("isDynamic");
        c0521a.Si = jSONObject.optInt("screenWidth");
        c0521a.Sh = jSONObject.optInt("screenHeight");
        c0521a.aQZ = jSONObject.optString("imei");
        if (JSONObject.NULL.toString().equals(c0521a.aQZ)) {
            c0521a.aQZ = "";
        }
        c0521a.aRa = jSONObject.optString("oaid");
        if (JSONObject.NULL.toString().equals(c0521a.aRa)) {
            c0521a.aRa = "";
        }
        c0521a.aWY = jSONObject.optString("androidId");
        if (JSONObject.NULL.toString().equals(c0521a.aWY)) {
            c0521a.aWY = "";
        }
        c0521a.aXo = jSONObject.optString("mac");
        if (JSONObject.NULL.toString().equals(c0521a.aXo)) {
            c0521a.aXo = "";
        }
        c0521a.aqC = jSONObject.optInt("statusBarHeight");
        c0521a.aqD = jSONObject.optInt("titleBarHeight");
        c0521a.bdd = jSONObject.optString("bridgeVersion");
        if (JSONObject.NULL.toString().equals(c0521a.bdd)) {
            c0521a.bdd = "";
        }
    }

    private static JSONObject b(com.kwad.sdk.core.webview.d.a.C0521a c0521a, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (c0521a.SDKVersion != null && !c0521a.SDKVersion.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "SDKVersion", c0521a.SDKVersion);
        }
        if (c0521a.SDKVersionCode != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "SDKVersionCode", c0521a.SDKVersionCode);
        }
        if (c0521a.aWn != null && !c0521a.aWn.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "tkVersion", c0521a.aWn);
        }
        if (c0521a.sdkApiVersion != null && !c0521a.sdkApiVersion.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sdkApiVersion", c0521a.sdkApiVersion);
        }
        if (c0521a.sdkApiVersionCode != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sdkApiVersionCode", c0521a.sdkApiVersionCode);
        }
        if (c0521a.sdkType != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sdkType", c0521a.sdkType);
        }
        if (c0521a.appVersion != null && !c0521a.appVersion.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "appVersion", c0521a.appVersion);
        }
        if (c0521a.appName != null && !c0521a.appName.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "appName", c0521a.appName);
        }
        if (c0521a.appId != null && !c0521a.appId.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, AlipayApi.c, c0521a.appId);
        }
        if (c0521a.bda != null && !c0521a.bda.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "globalId", c0521a.bda);
        }
        if (c0521a.aXb != null && !c0521a.aXb.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "eGid", c0521a.aXb);
        }
        if (c0521a.aXa != null && !c0521a.aXa.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "deviceSig", c0521a.aXa);
        }
        if (c0521a.aqw != null && !c0521a.aqw.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "networkType", c0521a.aqw);
        }
        if (c0521a.aqx != null && !c0521a.aqx.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "manufacturer", c0521a.aqx);
        }
        if (c0521a.model != null && !c0521a.model.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, com.baidu.mobads.sdk.internal.bn.i, c0521a.model);
        }
        if (c0521a.Ni != null && !c0521a.Ni.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "deviceBrand", c0521a.Ni);
        }
        if (c0521a.aqy != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "osType", c0521a.aqy);
        }
        if (c0521a.aqz != null && !c0521a.aqz.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "systemVersion", c0521a.aqz);
        }
        if (c0521a.aqA != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "osApi", c0521a.aqA);
        }
        if (c0521a.aqB != null && !c0521a.aqB.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, MediaFormat.KEY_LANGUAGE, c0521a.aqB);
        }
        if (c0521a.Uv != null && !c0521a.Uv.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "locale", c0521a.Uv);
        }
        if (c0521a.bdb != null && !c0521a.bdb.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "uuid", c0521a.bdb);
        }
        if (c0521a.bdc) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "isDynamic", c0521a.bdc);
        }
        if (c0521a.Si != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "screenWidth", c0521a.Si);
        }
        if (c0521a.Sh != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "screenHeight", c0521a.Sh);
        }
        if (c0521a.aQZ != null && !c0521a.aQZ.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "imei", c0521a.aQZ);
        }
        if (c0521a.aRa != null && !c0521a.aRa.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "oaid", c0521a.aRa);
        }
        if (c0521a.aWY != null && !c0521a.aWY.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "androidId", c0521a.aWY);
        }
        if (c0521a.aXo != null && !c0521a.aXo.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "mac", c0521a.aXo);
        }
        if (c0521a.aqC != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "statusBarHeight", c0521a.aqC);
        }
        if (c0521a.aqD != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "titleBarHeight", c0521a.aqD);
        }
        if (c0521a.bdd != null && !c0521a.bdd.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "bridgeVersion", c0521a.bdd);
        }
        return jSONObject;
    }
}
