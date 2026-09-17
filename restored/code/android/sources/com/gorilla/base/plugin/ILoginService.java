package com.gorilla.base.plugin;

import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public interface ILoginService {
    boolean isInstalled();

    void login(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback);

    void logout(ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback);
}
