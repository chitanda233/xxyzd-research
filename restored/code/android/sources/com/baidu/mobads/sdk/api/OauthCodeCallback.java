package com.baidu.mobads.sdk.api;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public interface OauthCodeCallback {
    void onFailure(int i, String str, JSONObject jSONObject);

    void onSuccess(String str, JSONObject jSONObject);
}
