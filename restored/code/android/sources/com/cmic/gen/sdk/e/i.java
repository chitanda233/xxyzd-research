package com.cmic.gen.sdk.e;

import android.content.Context;

/* JADX INFO: compiled from: OAIDFactory.java */
/* JADX INFO: loaded from: classes2.dex */
public class i {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2109a;
    private final j b = b();

    public i(Context context) {
        this.f2109a = context;
    }

    public String a() {
        j jVar = this.b;
        return jVar == null ? "" : jVar.b();
    }

    private j b() {
        if (this.f2109a == null) {
            return null;
        }
        if (k.n()) {
            return new a(this.f2109a);
        }
        if (k.a() || k.c()) {
            return new e(this.f2109a);
        }
        if (k.b()) {
            return new d(this.f2109a);
        }
        if (k.l() || k.p()) {
            return new f(this.f2109a);
        }
        if (k.k()) {
            return new g(this.f2109a);
        }
        if (k.m()) {
            return new h(this.f2109a);
        }
        if (k.d() || k.i()) {
            return new l(this.f2109a);
        }
        if (k.j()) {
            return new m(this.f2109a);
        }
        if (k.e()) {
            return new n(this.f2109a);
        }
        if (k.f() || k.g() || k.h()) {
            return new o(this.f2109a);
        }
        if (k.o()) {
            return new p(this.f2109a);
        }
        if (k.a(this.f2109a)) {
            return new b(this.f2109a);
        }
        if (k.q()) {
            return new c(this.f2109a);
        }
        return null;
    }
}
