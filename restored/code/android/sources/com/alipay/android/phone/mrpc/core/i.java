package com.alipay.android.phone.mrpc.core;

import android.content.Context;

/* JADX INFO: loaded from: classes.dex */
class i implements g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ ab f187a;
    public final /* synthetic */ h b;

    public i(h hVar, ab abVar) {
        this.b = hVar;
        this.f187a = abVar;
    }

    @Override // com.alipay.android.phone.mrpc.core.g
    public String a() {
        return this.f187a.a();
    }

    @Override // com.alipay.android.phone.mrpc.core.g
    public ad b() {
        return l.a(e());
    }

    @Override // com.alipay.android.phone.mrpc.core.g
    public ab c() {
        return this.f187a;
    }

    @Override // com.alipay.android.phone.mrpc.core.g
    public boolean d() {
        return this.f187a.c();
    }

    public Context e() {
        return this.b.f186a.getApplicationContext();
    }
}
