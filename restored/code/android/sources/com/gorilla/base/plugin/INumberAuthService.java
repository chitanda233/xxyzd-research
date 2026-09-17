package com.gorilla.base.plugin;

import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public interface INumberAuthService {
    void auth(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback);

    void dismiss(ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback);

    void initSDK(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback);

    void prepare(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback);
}
