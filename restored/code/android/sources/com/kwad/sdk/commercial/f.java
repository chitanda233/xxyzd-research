package com.kwad.sdk.commercial;

import com.kwad.components.offline.api.BuildConfig;
import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.bz;
import com.sigmob.sdk.base.mta.PointParamKey;
import com.sigmob.sdk.base.n;
import java.util.Iterator;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends com.kwad.sdk.core.response.a.a {
    public String aJU;
    public String aJV;
    public JSONObject aJW;
    public double aJX;
    public String maxVersion;
    public String minVersion;
    public String tag;
    public String type;
    public int category = -1;
    public double aJY = 0.0d;
    public int aJZ = 1;

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public final JSONObject toJson() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, PointParamKey.CATEGORY, this.category);
        ac.putValue(jSONObject, "min_version", this.minVersion);
        ac.putValue(jSONObject, "max_version", this.maxVersion);
        ac.putValue(jSONObject, "tag", this.tag);
        ac.putValue(jSONObject, com.alipay.sdk.m.m.b.l, this.aJU);
        ac.putValue(jSONObject, "subBiz", this.aJV);
        ac.putValue(jSONObject, "type", this.type);
        ac.putValue(jSONObject, "custom_dimension", this.aJW);
        ac.putValue(jSONObject, n.C, this.aJX);
        ac.putValue(jSONObject, "convert", this.aJY);
        ac.putValue(jSONObject, "device_mode", this.aJZ);
        return jSONObject;
    }

    @Override // com.kwad.sdk.core.response.a.a, com.kwad.sdk.core.b
    public final void parseJson(JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        this.category = jSONObject.optInt(PointParamKey.CATEGORY, 0);
        this.minVersion = jSONObject.optString("min_version");
        this.maxVersion = jSONObject.optString("max_version");
        this.tag = jSONObject.optString("tag");
        this.aJU = jSONObject.optString(com.alipay.sdk.m.m.b.l);
        this.aJV = jSONObject.optString("subBiz");
        this.type = jSONObject.optString("type");
        this.aJW = jSONObject.optJSONObject("custom_dimension");
        this.aJX = jSONObject.optDouble(n.C, 0.0d);
        this.aJY = jSONObject.optDouble("convert", 0.0d);
        this.aJZ = jSONObject.optInt("device_mode", 1);
    }

    public final boolean e(d dVar) {
        if (dVar == null) {
            return false;
        }
        try {
            if (!m177do(dVar.category)) {
                com.kwad.sdk.core.d.c.d("KCLRefineReport", "isMatch category not match " + dVar.category + " to " + this.category);
                return false;
            }
            String str = this.minVersion;
            if (str != null && !str.isEmpty() && !bz.aD(BuildConfig.VERSION_NAME, this.minVersion)) {
                com.kwad.sdk.core.d.c.d("KCLRefineReport", "isMatch minVersion not match 5.3.20.1 to " + this.minVersion);
                return false;
            }
            String str2 = this.maxVersion;
            if (str2 != null && !str2.isEmpty() && bz.aD(BuildConfig.VERSION_NAME, this.maxVersion)) {
                com.kwad.sdk.core.d.c.d("KCLRefineReport", "isMatch maxVersion not match 5.3.20.1 to " + this.maxVersion);
                return false;
            }
            String str3 = this.tag;
            if (str3 != null && !str3.isEmpty() && !this.tag.equals(dVar.tag)) {
                com.kwad.sdk.core.d.c.d("KCLRefineReport", "isMatch tag not match " + dVar.tag + " to " + this.tag);
                return false;
            }
            String str4 = this.aJU;
            if (str4 != null && !str4.isEmpty() && !this.aJU.equals(dVar.aJR.value)) {
                com.kwad.sdk.core.d.c.d("KCLRefineReport", "isMatch biz not match " + dVar.aJR.value + " to " + this.aJU);
                return false;
            }
            String str5 = this.aJV;
            if (str5 != null && !str5.isEmpty() && !this.aJV.equals(dVar.aJS.value)) {
                com.kwad.sdk.core.d.c.d("KCLRefineReport", "isMatch subBiz not match " + dVar.aJS.value + " to " + this.aJV);
                return false;
            }
            String str6 = this.type;
            if (str6 != null && !str6.isEmpty()) {
                if (dVar.aJT == null) {
                    return false;
                }
                if (!this.type.equals(dVar.aJT.getValue())) {
                    com.kwad.sdk.core.d.c.d("KCLRefineReport", "isMatch type not match " + dVar.aJT.getValue() + " to " + this.type);
                    return false;
                }
            }
            if (f(dVar)) {
                return true;
            }
            com.kwad.sdk.core.d.c.d("KCLRefineReport", "isMatchForMsg not match " + dVar.msg + " to " + this.aJW);
            return false;
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
            return false;
        }
    }

    private boolean f(d dVar) {
        if (dVar == null || dVar.msg == null) {
            return false;
        }
        JSONObject jSONObject = this.aJW;
        if (jSONObject == null) {
            return true;
        }
        Iterator<String> itKeys = jSONObject.keys();
        while (itKeys.hasNext()) {
            String next = itKeys.next();
            Object objOpt = dVar.msg.opt(next);
            if (objOpt == null || !objOpt.equals(this.aJW.opt(next))) {
                return false;
            }
        }
        return true;
    }

    /* JADX INFO: renamed from: do, reason: not valid java name */
    private boolean m177do(String str) {
        if (str == null) {
            return false;
        }
        int i = this.category;
        if (i == 0) {
            return str.equals(ILoggerReporter.Category.APM_LOG);
        }
        if (i != 1) {
            return false;
        }
        return str.equals(ILoggerReporter.Category.ERROR_LOG);
    }

    @Override // com.kwad.sdk.core.response.a.a
    public final String toString() {
        return "KCEventRatioRule{category=" + this.category + ", minVersion='" + this.minVersion + "', maxVersion='" + this.maxVersion + "', tag='" + this.tag + "', biz='" + this.aJU + "', subBiz='" + this.aJV + "', type='" + this.type + "', customDimension=" + this.aJW + ", ratio=" + this.aJX + ", convert=" + this.aJY + ", device_mode=" + this.aJZ + '}';
    }
}
