package com.gorilla.plugin.wechat;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import com.gorilla.base.log.ILogger;
import com.gorilla.base.log.LogFactory;
import com.tencent.mm.opensdk.modelbase.BaseReq;
import com.tencent.mm.opensdk.modelbase.BaseResp;
import com.tencent.mm.opensdk.openapi.IWXAPIEventHandler;

/* JADX INFO: loaded from: classes3.dex */
public class WeChatHandlerActivity extends Activity implements IWXAPIEventHandler {
    private static final String TAG = "[WeChatHandlerActivity]";
    private static final ILogger logger = LogFactory.getLogger();

    @Override // android.app.Activity
    protected void onCreate(Bundle bundle) {
        try {
            super.onCreate(bundle);
            logger.log(TAG, "onCreate, activity name: " + getClass().getName());
            WeChatService.getInstance().handleIntent(getIntent(), this);
        } catch (Exception e) {
            logger.error(TAG, "onCreate error: " + e.getMessage());
        }
    }

    @Override // android.app.Activity
    protected void onNewIntent(Intent intent) {
        try {
            super.onNewIntent(intent);
            logger.log(TAG, "onNewIntent");
            setIntent(intent);
            WeChatService.getInstance().handleIntent(intent, this);
        } catch (Exception e) {
            logger.error(TAG, "onNewIntent error: " + e.getMessage());
        }
    }

    @Override // com.tencent.mm.opensdk.openapi.IWXAPIEventHandler
    public void onReq(BaseReq baseReq) {
        logger.log(TAG, "onReq type: " + baseReq.getType() + ", openId: " + baseReq.openId + ", transaction: " + baseReq.transaction);
        WeChatService.getInstance().onReq(baseReq);
    }

    @Override // com.tencent.mm.opensdk.openapi.IWXAPIEventHandler
    public void onResp(BaseResp baseResp) {
        logger.log(TAG, "onResp: " + baseResp + ", type: " + baseResp.getType() + ", errCode: " + baseResp.errCode + ", errStr: " + baseResp.errStr);
        WeChatService.getInstance().onResp(baseResp);
        finish();
    }
}
