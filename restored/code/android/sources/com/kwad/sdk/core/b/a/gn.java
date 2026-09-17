package com.kwad.sdk.core.b.a;

import com.kwad.components.core.innerEc.InnerEcUserLoginBindInfo;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class gn implements com.kwad.sdk.core.d<InnerEcUserLoginBindInfo> {
    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ void a(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        a((InnerEcUserLoginBindInfo) bVar, jSONObject);
    }

    @Override // com.kwad.sdk.core.d
    public final /* bridge */ /* synthetic */ JSONObject b(com.kwad.sdk.core.b bVar, JSONObject jSONObject) {
        return b((InnerEcUserLoginBindInfo) bVar, jSONObject);
    }

    private static void a(InnerEcUserLoginBindInfo innerEcUserLoginBindInfo, JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        innerEcUserLoginBindInfo.userId = jSONObject.optLong("userId");
        innerEcUserLoginBindInfo.userName = jSONObject.optString("userName");
        if (JSONObject.NULL.toString().equals(innerEcUserLoginBindInfo.userName)) {
            innerEcUserLoginBindInfo.userName = "";
        }
        innerEcUserLoginBindInfo.serviceToken = jSONObject.optString("serviceToken");
        if (JSONObject.NULL.toString().equals(innerEcUserLoginBindInfo.serviceToken)) {
            innerEcUserLoginBindInfo.serviceToken = "";
        }
        innerEcUserLoginBindInfo.expire = jSONObject.optLong("expire");
        innerEcUserLoginBindInfo.sid = jSONObject.optString("sid");
        if (JSONObject.NULL.toString().equals(innerEcUserLoginBindInfo.sid)) {
            innerEcUserLoginBindInfo.sid = "";
        }
    }

    private static JSONObject b(InnerEcUserLoginBindInfo innerEcUserLoginBindInfo, JSONObject jSONObject) {
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        if (innerEcUserLoginBindInfo.userId != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "userId", innerEcUserLoginBindInfo.userId);
        }
        if (innerEcUserLoginBindInfo.userName != null && !innerEcUserLoginBindInfo.userName.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "userName", innerEcUserLoginBindInfo.userName);
        }
        if (innerEcUserLoginBindInfo.serviceToken != null && !innerEcUserLoginBindInfo.serviceToken.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "serviceToken", innerEcUserLoginBindInfo.serviceToken);
        }
        if (innerEcUserLoginBindInfo.expire != 0) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "expire", innerEcUserLoginBindInfo.expire);
        }
        if (innerEcUserLoginBindInfo.sid != null && !innerEcUserLoginBindInfo.sid.equals("")) {
            com.kwad.sdk.utils.ac.putValue(jSONObject, "sid", innerEcUserLoginBindInfo.sid);
        }
        return jSONObject;
    }
}
