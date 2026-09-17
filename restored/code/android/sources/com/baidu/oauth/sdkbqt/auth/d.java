package com.baidu.oauth.sdkbqt.auth;

/* JADX INFO: loaded from: classes.dex */
class d implements b.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ com.baidu.oauth.sdkbqt.callback.a f566a;
    final /* synthetic */ c b;

    d(c cVar, com.baidu.oauth.sdkbqt.callback.a aVar) {
        this.b = cVar;
        this.f566a = aVar;
    }

    @Override // com.baidu.oauth.sdkbqt.auth.b.a
    public void a(long j) {
        com.baidu.oauth.sdkbqt.result.a aVar = new com.baidu.oauth.sdkbqt.result.a();
        aVar.f596a = new h().a(Long.valueOf(j));
        aVar.setResultCode(0);
        this.f566a.onSuccess(aVar);
    }
}
