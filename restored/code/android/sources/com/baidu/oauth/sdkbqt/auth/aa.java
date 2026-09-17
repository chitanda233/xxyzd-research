package com.baidu.oauth.sdkbqt.auth;

/* JADX INFO: loaded from: classes.dex */
class aa extends i.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ i f560a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    aa(i iVar) {
        super();
        this.f560a = iVar;
    }

    @Override // com.baidu.oauth.sdkbqt.auth.i.a
    public String a(i.e eVar) {
        String str = eVar.b().get(0);
        if (this.f560a.e == null) {
            return null;
        }
        this.f560a.e.a(str);
        return null;
    }
}
