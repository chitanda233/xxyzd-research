package com.alipay.sdk.m.c0;

import java.util.Iterator;
import java.util.Stack;

/* JADX INFO: loaded from: classes.dex */
public class f {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Stack<e> f271a = new Stack<>();

    public void a(e eVar) {
        this.f271a.push(eVar);
    }

    public boolean b() {
        return this.f271a.isEmpty();
    }

    public e c() {
        return this.f271a.pop();
    }

    public void a() {
        if (b()) {
            return;
        }
        Iterator<e> it = this.f271a.iterator();
        while (it.hasNext()) {
            it.next().b();
        }
        this.f271a.clear();
    }
}
