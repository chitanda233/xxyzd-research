package com.baidu.oauth.sdkbqt.auth;

import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
class ad extends com.baidu.oauth.sdkbqt.callback.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ ac f563a;

    ad(ac acVar) {
        this.f563a = acVar;
    }

    @Override // com.baidu.oauth.sdkbqt.callback.OauthCallback
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void onSuccess(com.baidu.oauth.sdkbqt.result.a aVar) {
        com.baidu.oauth.sdkbqt.a.d.a(i.b, "FE need get a new sso_hash");
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("errno", 0);
            jSONObject.put("sso_hash", aVar.f596a);
        } catch (JSONException e) {
            com.baidu.oauth.sdkbqt.a.d.a(e);
        }
        this.f563a.f562a.u.confirm(aVar.f596a);
    }
}
