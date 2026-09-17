package com.gorilla.plugin.alipay;

import android.app.Activity;
import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import com.gorilla.base.plugin.GorillaPlugin;
import com.gorilla.base.plugin.IPurchaseService;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class AliPayPlugin extends GorillaPlugin implements IPurchaseService {
    @Override // com.gorilla.base.plugin.GorillaPlugin
    public String getVersion() {
        return AliPayService.getInstance().getVersion(this.activity);
    }

    @Override // com.gorilla.base.plugin.GorillaPlugin
    public void init(Activity activity, JSONObject jSONObject) {
        super.init(activity, jSONObject);
        AliPayService.getInstance().init();
    }

    @Override // com.gorilla.base.plugin.IPurchaseService
    public void purchase(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        AliPayService.getInstance().purchase(this.activity, jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
    }
}
