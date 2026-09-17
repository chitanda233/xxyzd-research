package com.baidu.oauth.sdkbqt.auth;

import com.baidu.oauth.sdkbqt.callback.QrLoginStatusCheckCallback;
import com.baidu.oauth.sdkbqt.result.QrLoginStatusCheckResult;

/* JADX INFO: loaded from: classes.dex */
class f extends QrLoginStatusCheckCallback {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ QrLoginStatusCheckCallback f568a;
    final /* synthetic */ c b;

    f(c cVar, QrLoginStatusCheckCallback qrLoginStatusCheckCallback) {
        this.b = cVar;
        this.f568a = qrLoginStatusCheckCallback;
    }

    @Override // com.baidu.oauth.sdkbqt.callback.QrLoginStatusCheckCallback
    public void onScanQrCodeDone(QrLoginStatusCheckResult qrLoginStatusCheckResult) {
        this.f568a.onScanQrCodeDone(qrLoginStatusCheckResult);
    }

    @Override // com.baidu.oauth.sdkbqt.callback.OauthCallback
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void onSuccess(QrLoginStatusCheckResult qrLoginStatusCheckResult) {
        this.f568a.onSuccess(qrLoginStatusCheckResult);
        this.b.f565a = null;
    }

    @Override // com.baidu.oauth.sdkbqt.callback.OauthCallback
    /* JADX INFO: renamed from: b, reason: merged with bridge method [inline-methods] */
    public void onFailure(QrLoginStatusCheckResult qrLoginStatusCheckResult) {
        this.f568a.onFailure(qrLoginStatusCheckResult);
        this.b.f565a = null;
    }

    @Override // com.baidu.oauth.sdkbqt.callback.OauthCallback
    public void onStart() {
        this.f568a.onStart();
    }

    @Override // com.baidu.oauth.sdkbqt.callback.OauthCallback
    public void onFinish() {
        this.f568a.onFinish();
    }
}
