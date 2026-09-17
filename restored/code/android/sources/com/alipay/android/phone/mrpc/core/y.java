package com.alipay.android.phone.mrpc.core;

import java.lang.reflect.Proxy;

/* JADX INFO: loaded from: classes.dex */
public class y {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private g f197a;
    private aa b = new aa(this);

    public y(g gVar) {
        this.f197a = gVar;
    }

    public g a() {
        return this.f197a;
    }

    public <T> T a(Class<T> cls) {
        return (T) Proxy.newProxyInstance(cls.getClassLoader(), new Class[]{cls}, new z(this.f197a, cls, this.b));
    }
}
