package com.kwad.sdk.core.b.a;

import com.kwad.sdk.core.response.model.AdMatrixInfo;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class gj implements com.kwad.sdk.core.d<AdMatrixInfo.InnerEcAuthInfo> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((AdMatrixInfo.InnerEcAuthInfo) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((AdMatrixInfo.InnerEcAuthInfo) bVar, jSONObject);
    }

    private static void a(AdMatrixInfo.InnerEcAuthInfo innerEcAuthInfo, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        innerEcAuthInfo.closureAuthToastSwitch = jSONObject.optBoolean("closureAuthToastSwitch");
        innerEcAuthInfo.closureAuthToastText = jSONObject.optString("closureAuthToastText");
        if (JSONObject.NULL.toString().equals(innerEcAuthInfo.closureAuthToastText)) {
            innerEcAuthInfo.closureAuthToastText = "";
        }
        innerEcAuthInfo.cancelClosureAuthTime = jSONObject.optInt("cancelClosureAuthTime");
        innerEcAuthInfo.showAuthDialogSwitch = jSONObject.optBoolean("showAuthDialogSwitch", new Boolean("true").booleanValue());
    }

    private static JSONObject b(AdMatrixInfo.InnerEcAuthInfo innerEcAuthInfo, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (innerEcAuthInfo.closureAuthToastSwitch) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "closureAuthToastSwitch", innerEcAuthInfo.closureAuthToastSwitch);
        }
        if (innerEcAuthInfo.closureAuthToastText != null && !innerEcAuthInfo.closureAuthToastText.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "closureAuthToastText", innerEcAuthInfo.closureAuthToastText);
        }
        if (innerEcAuthInfo.cancelClosureAuthTime != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "cancelClosureAuthTime", innerEcAuthInfo.cancelClosureAuthTime);
        }
        com.kwad.sdk.utils.ac.putValue(jSONObject, "showAuthDialogSwitch", innerEcAuthInfo.showAuthDialogSwitch);
        return jSONObject;
    }
}
