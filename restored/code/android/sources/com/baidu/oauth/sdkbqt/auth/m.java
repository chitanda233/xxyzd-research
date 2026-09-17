package com.baidu.oauth.sdkbqt.auth;

/* JADX INFO: loaded from: classes.dex */
class m extends i.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i f579a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    m(i iVar) {
        super();
        this.f579a = iVar;
    }

    @Override // com.baidu.oauth.sdkbqt.auth.i.a
    public String a(i.e eVar) {
        com.baidu.oauth.sdkbqt.a.d.a(i.b, "user has clicked Authorized login");
        if (this.f579a.t == null) {
            return null;
        }
        this.f579a.t.f572a.a(eVar.b().get(0));
        return null;
    }
}
