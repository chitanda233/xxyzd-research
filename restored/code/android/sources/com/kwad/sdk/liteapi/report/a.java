package com.kwad.sdk.liteapi.report;

import android.content.Context;
import android.content.pm.PackageInfo;
import com.alipay.sdk.app.AlipayApi;
import com.alipay.sdk.m.n.c;
import com.kwad.sdk.api.SdkConfig;
import com.kwad.sdk.liteapi.InputParamHolder;
import com.kwad.sdk.liteapi.LiteApiLogger;
import com.kwad.sdk.liteapi.PackageManagerUtils;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
final class a {
    private String appId;
    private String name;
    private String packageName;
    private String version;

    a() {
    }

    public static a cA(Context context) {
        a aVar = new a();
        SdkConfig sDKConfig = InputParamHolder.getSDKConfig();
        if (sDKConfig != null) {
            aVar.appId = sDKConfig.appId;
            aVar.name = sDKConfig.appName;
        }
        aVar.packageName = context.getPackageName();
        try {
            PackageInfo packageInfo = PackageManagerUtils.getPackageInfo(context.getApplicationContext(), context.getPackageName(), 64);
            if (packageInfo != null) {
                aVar.version = packageInfo.versionName;
            }
        } catch (Exception e) {
            LiteApiLogger.printStackTraceOnly(e);
        }
        return aVar;
    }

    public final String getAppId() {
        return this.appId;
    }

    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.putOpt(AlipayApi.c, this.appId);
            jSONObject.putOpt(c.e, this.name);
            jSONObject.putOpt("packageName", this.packageName);
            jSONObject.putOpt("version", this.version);
        } catch (JSONException e) {
            LiteApiLogger.printStackTrace(e);
        }
        return jSONObject;
    }
}
