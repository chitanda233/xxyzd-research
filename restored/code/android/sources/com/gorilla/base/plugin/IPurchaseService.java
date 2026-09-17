package com.gorilla.base.plugin;

import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public interface IPurchaseService {
    void purchase(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback);
}
