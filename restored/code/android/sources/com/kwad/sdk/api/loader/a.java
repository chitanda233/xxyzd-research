package com.kwad.sdk.api.loader;

import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.kwad.components.offline.api.tk.model.report.TKDownloadReason;
import java.io.File;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
final class a {

    /* JADX INFO: renamed from: com.kwad.sdk.api.loader.a$a, reason: collision with other inner class name */
    static class C0495a {
        int aHE;
        String aHF;
        transient File aHG;
        long interval;
        String md5;
        String sdkVersion;

        C0495a() {
        }

        public final String toString() {
            return "Data{dynamicType=" + this.aHE + ", dynamicUrl='" + this.aHF + "', md5='" + this.md5 + "', interval=" + this.interval + ", sdkVersion='" + this.sdkVersion + "', downloadFile=" + this.aHG + '}';
        }

        public final void parseJson(JSONObject jSONObject) {
            if (jSONObject == null) {
                return;
            }
            this.aHE = jSONObject.optInt("dynamicType");
            this.aHF = jSONObject.optString("dynamicUrl");
            this.md5 = jSONObject.optString(TKDownloadReason.KSAD_TK_MD5);
            this.interval = jSONObject.optLong("interval");
            this.sdkVersion = jSONObject.optString("sdkVersion");
        }

        public final boolean HM() {
            return this.aHE == 1;
        }

        public final boolean HN() {
            return this.aHE == -1;
        }
    }

    static class b {
        C0495a aHH;
        String errorMsg;
        long result;

        b() {
        }

        public final void parseJson(JSONObject jSONObject) {
            this.result = jSONObject.optLong(com.alipay.sdk.m.y.o.c);
            this.errorMsg = jSONObject.optString(MediationConstant.KEY_ERROR_MSG);
            C0495a c0495a = new C0495a();
            this.aHH = c0495a;
            c0495a.parseJson(jSONObject.optJSONObject("data"));
        }

        public final String toString() {
            return "UpdateData{result=" + this.result + ", errorMsg='" + this.errorMsg + "', data=" + this.aHH + '}';
        }

        final boolean isLegal() {
            return this.result == 1 && this.aHH != null;
        }
    }
}
