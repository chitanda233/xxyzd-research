package com.alipay.android.phone.mrpc.core;

import java.lang.reflect.InvocationHandler;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes.dex */
public class z implements InvocationHandler {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public g f198a;
    public Class<?> b;
    public aa c;

    public z(g gVar, Class<?> cls, aa aaVar) {
        this.f198a = gVar;
        this.b = cls;
        this.c = aaVar;
    }

    @Override // java.lang.reflect.InvocationHandler
    public Object invoke(Object obj, Method method, Object[] objArr) {
        return this.c.a(obj, this.b, method, objArr);
    }
}
