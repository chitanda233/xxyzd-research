package com.gorilla.plugin.shanyan;

import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import com.gorilla.base.plugin.GorillaPlugin;
import com.gorilla.base.plugin.INumberAuthService;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class ShanYanPlugin extends GorillaPlugin implements INumberAuthService {
    @Override // com.gorilla.base.plugin.GorillaPlugin
    public String getVersion() {
        return "2.3.7.5";
    }

    @Override // com.gorilla.base.plugin.INumberAuthService
    public void initSDK(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        ShanYanService.getInstance().doInit(this.activity, jSONObject, iSuccessCallback, iFailureCallback);
    }

    @Override // com.gorilla.base.plugin.INumberAuthService
    public void prepare(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        ShanYanService.getInstance().doPrepare(jSONObject, iSuccessCallback, iFailureCallback);
    }

    @Override // com.gorilla.base.plugin.INumberAuthService
    public void auth(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        ShanYanService.getInstance().doAuth(this.activity, jSONObject, iSuccessCallback, iFailureCallback);
    }

    @Override // com.gorilla.base.plugin.INumberAuthService
    public void dismiss(ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        ShanYanService.getInstance().doDismiss(iSuccessCallback);
    }
}
