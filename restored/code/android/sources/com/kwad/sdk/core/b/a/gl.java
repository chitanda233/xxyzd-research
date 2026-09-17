package com.kwad.sdk.core.b.a;

import com.kwad.components.core.innerEc.logger.InnerEcEvent;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class gl implements com.kwad.sdk.core.d<InnerEcEvent> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((InnerEcEvent) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((InnerEcEvent) bVar, jSONObject);
    }

    private static void a(InnerEcEvent innerEcEvent, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        innerEcEvent.clickCancelTime = jSONObject.optInt("click_cancel_time", new Integer("0").intValue());
        innerEcEvent.clickLiveCheckEnv = jSONObject.optBoolean("click_live_check_env", new Boolean("false").booleanValue());
        innerEcEvent.clickUserNowCancel = jSONObject.optBoolean("click_user_now_cancel", new Boolean("false").booleanValue());
        innerEcEvent.clickHasInnerecFailed = jSONObject.optBoolean("click_has_innerec_failed", new Boolean("false").booleanValue());
        innerEcEvent.authType = jSONObject.optString("auth_type");
        if (JSONObject.NULL.toString().equals(innerEcEvent.authType)) {
            innerEcEvent.authType = "";
        }
    }

    private static JSONObject b(InnerEcEvent innerEcEvent, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, "click_cancel_time", innerEcEvent.clickCancelTime);
        com.kwad.sdk.utils.ac.putValue(jSONObject, "click_live_check_env", innerEcEvent.clickLiveCheckEnv);
        com.kwad.sdk.utils.ac.putValue(jSONObject, "click_user_now_cancel", innerEcEvent.clickUserNowCancel);
        com.kwad.sdk.utils.ac.putValue(jSONObject, "click_has_innerec_failed", innerEcEvent.clickHasInnerecFailed);
        if (innerEcEvent.authType != null && !innerEcEvent.authType.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "auth_type", innerEcEvent.authType);
        }
        return jSONObject;
    }
}
