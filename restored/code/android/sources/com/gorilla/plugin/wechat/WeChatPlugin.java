package com.gorilla.plugin.wechat;

import android.app.Activity;
import com.baidu.mobads.sdk.internal.cb;
import com.gorilla.base.callback.ICancelCallback;
import com.gorilla.base.callback.IFailureCallback;
import com.gorilla.base.callback.ISuccessCallback;
import com.gorilla.base.plugin.GorillaPlugin;
import com.gorilla.base.plugin.ILoginService;
import com.gorilla.base.plugin.IPurchaseService;
import com.gorilla.base.plugin.IShareService;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class WeChatPlugin extends GorillaPlugin implements ILoginService, IShareService, IPurchaseService {
    @Override // com.gorilla.base.plugin.GorillaPlugin
    public String getVersion() {
        try {
            return (String) Class.forName("com.tencent.mm.opensdk.constants.Build").getDeclaredField("SDK_VERSION_NAME").get(null);
        } catch (Exception unused) {
            return "6.8.0";
        }
    }

    @Override // com.gorilla.base.plugin.GorillaPlugin
    public void init(Activity activity, JSONObject jSONObject) {
        super.init(activity, jSONObject);
        WeChatService.getInstance().registerToWX(activity);
    }

    @Override // com.gorilla.base.plugin.ILoginService
    public boolean isInstalled() {
        return WeChatService.getInstance().isInstalled();
    }

    @Override // com.gorilla.base.plugin.ILoginService
    public void login(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        WeChatService.getInstance().login(this.activity, jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
    }

    @Override // com.gorilla.base.plugin.ILoginService
    public void logout(ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback) {
        if (iSuccessCallback != null) {
            iSuccessCallback.onSuccess(cb.o);
        }
    }

    @Override // com.gorilla.base.plugin.IShareService
    public void share(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        WeChatService.getInstance().share(this.activity, jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
    }

    @Override // com.gorilla.base.plugin.IPurchaseService
    public void purchase(JSONObject jSONObject, ISuccessCallback iSuccessCallback, IFailureCallback iFailureCallback, ICancelCallback iCancelCallback) {
        WeChatService.getInstance().purchase(this.activity, jSONObject, iSuccessCallback, iFailureCallback, iCancelCallback);
    }
}
