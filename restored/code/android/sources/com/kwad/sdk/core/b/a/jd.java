package com.kwad.sdk.core.b.a;

import com.byazt.bv.BaseConstants;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class jd implements com.kwad.sdk.core.d<com.kwad.components.core.webview.jshandler.a.c> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((com.kwad.components.core.webview.jshandler.a.c) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((com.kwad.components.core.webview.jshandler.a.c) bVar, jSONObject);
    }

    private static void a(com.kwad.components.core.webview.jshandler.a.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        cVar.errorCode = jSONObject.optInt(MediationConstant.KEY_ERROR_CODE);
        cVar.apw = jSONObject.optInt(BaseConstants.EVENT_LABEL_EXTRA);
        cVar.apx = jSONObject.optLong("playDuration");
        cVar.apy = jSONObject.optBoolean("clickRewardDialog");
    }

    private static JSONObject b(com.kwad.components.core.webview.jshandler.a.c cVar, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (cVar.errorCode != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, MediationConstant.KEY_ERROR_CODE, cVar.errorCode);
        }
        if (cVar.apw != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, BaseConstants.EVENT_LABEL_EXTRA, cVar.apw);
        }
        if (cVar.apx != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "playDuration", cVar.apx);
        }
        if (cVar.apy) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "clickRewardDialog", cVar.apy);
        }
        return jSONObject;
    }
}
