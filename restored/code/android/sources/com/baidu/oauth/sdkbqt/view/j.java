package com.baidu.oauth.sdkbqt.view;

import android.content.Intent;
import com.baidu.oauth.sdkbqt.auth.BdSsoHandler;

/* JADX INFO: loaded from: classes.dex */
class j extends com.baidu.oauth.sdkbqt.callback.b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ WebViewActivity f610a;

    j(WebViewActivity webViewActivity) {
        this.f610a = webViewActivity;
    }

    @Override // com.baidu.oauth.sdkbqt.callback.OauthCallback
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void onSuccess(com.baidu.oauth.sdkbqt.result.b bVar) {
        Intent intent = new Intent();
        intent.putExtra(BdSsoHandler.EXTRA_OAUTH_RESULT_JSON, bVar.f597a.toString());
        this.f610a.f = true;
        this.f610a.setResult(-1, intent);
        this.f610a.finish();
    }

    @Override // com.baidu.oauth.sdkbqt.callback.OauthCallback
    /* JADX INFO: renamed from: b, reason: merged with bridge method [inline-methods] */
    public void onFailure(com.baidu.oauth.sdkbqt.result.b bVar) {
        this.f610a.setResult(0, com.baidu.oauth.sdkbqt.a.i.a(bVar.getResultCode(), bVar.getResultMsg()));
        this.f610a.finish();
    }
}
