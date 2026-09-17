package com.kwad.sdk.core.request.model;

import android.text.TextUtils;
import com.alipay.sdk.app.AlipayApi;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.bu;
import com.kwad.sdk.utils.n;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a implements com.kwad.sdk.core.b {
    private static JSONObject aWN;
    private String aWO;
    private String appId;
    private String name;
    private String packageName;
    private String version;
    private int versionCode;

    @Override // com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
    }

    public static JSONObject Nz() {
        if (!m(aWN)) {
            aWN = NA().toJson();
        }
        return aWN;
    }

    public static a NA() {
        a aVar = new a();
        try {
            aVar.appId = ServiceProvider.getSDKConfig().appId;
            aVar.name = ServiceProvider.getSDKConfig().appName;
            aVar.packageName = ServiceProvider.Um().getPackageName();
            aVar.version = n.cY(ServiceProvider.Um());
            aVar.versionCode = n.da(ServiceProvider.Um());
            aVar.aWO = com.kwad.sdk.utils.g.cM(ServiceProvider.Um());
            if (!TextUtils.isEmpty(bu.getAppId())) {
                aVar.appId = bu.getAppId();
            }
            if (!TextUtils.isEmpty(bu.getPackageName())) {
                aVar.packageName = bu.getPackageName();
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
        return aVar;
    }

    private static boolean m(JSONObject jSONObject) {
        if (jSONObject == null) {
            return false;
        }
        String strOptString = jSONObject.optString(AlipayApi.c);
        String strOptString2 = jSONObject.optString(com.alipay.sdk.m.n.c.e);
        return !TextUtils.isEmpty(strOptString2) && !TextUtils.isEmpty(strOptString) && strOptString.equals(ServiceProvider.getSDKConfig().appId) && strOptString2.equals(ServiceProvider.getSDKConfig().appName);
    }

    @Override // com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, AlipayApi.c, this.appId);
        ac.putValue(jSONObject, com.alipay.sdk.m.n.c.e, this.name);
        ac.putValue(jSONObject, "packageName", this.packageName);
        ac.putValue(jSONObject, "version", this.version);
        ac.putValue(jSONObject, "versionCode", this.versionCode);
        ac.putValue(jSONObject, "sha1", this.aWO);
        return jSONObject;
    }
}
