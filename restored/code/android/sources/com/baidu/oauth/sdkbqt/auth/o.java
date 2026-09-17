package com.baidu.oauth.sdkbqt.auth;

/* JADX INFO: loaded from: classes.dex */
class o extends com.baidu.oauth.sdkbqt.callback.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i f581a;

    o(i iVar) {
        this.f581a = iVar;
    }

    @Override // com.baidu.oauth.sdkbqt.callback.OauthCallback
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void onSuccess(com.baidu.oauth.sdkbqt.result.a aVar) {
        i iVar = this.f581a;
        iVar.loadUrl(iVar.d(aVar.f596a));
    }
}
