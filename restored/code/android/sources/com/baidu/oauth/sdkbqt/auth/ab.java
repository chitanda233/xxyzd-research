package com.baidu.oauth.sdkbqt.auth;

/* JADX INFO: loaded from: classes.dex */
class ab extends i.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i f561a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    ab(i iVar) {
        super();
        this.f561a = iVar;
    }

    @Override // com.baidu.oauth.sdkbqt.auth.i.a
    public String a(i.e eVar) {
        if (this.f561a.canGoBack()) {
            this.f561a.goBack();
            return null;
        }
        this.f561a.c();
        return null;
    }
}
