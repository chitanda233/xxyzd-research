package com.baidu.mobads.sdk.internal;

/* JADX INFO: loaded from: classes.dex */
class ce implements cp.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ cb f463a;

    ce(cb cbVar) {
        this.f463a = cbVar;
    }

    @Override // com.baidu.mobads.sdk.internal.cp.a
    public void a(String str) {
        try {
            this.f463a.b();
            this.f463a.a(str);
        } catch (Throwable th) {
            bv.a().a(th);
        }
    }
}
