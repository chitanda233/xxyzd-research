package com.qq.gdt.action.e;

import com.qq.gdt.action.e.b.a.g;

/* JADX INFO: loaded from: classes3.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile b f3045a;
    private com.qq.gdt.action.e.b.c b;
    private com.qq.gdt.action.e.b.c c;

    private b() {
        a(null);
        b(null);
    }

    public static b a() {
        if (f3045a == null) {
            synchronized (b.class) {
                if (f3045a == null) {
                    f3045a = new b();
                }
            }
        }
        return f3045a;
    }

    private void a(com.qq.gdt.action.e.b.c cVar) {
        if (cVar == null) {
            cVar = new com.qq.gdt.action.e.b.c.a().a(new com.qq.gdt.action.e.b.a.e()).a(new com.qq.gdt.action.e.b.a.f(3)).a(new g()).a(new com.qq.gdt.action.e.b.a.a()).a();
        }
        this.b = cVar;
    }

    private void b(com.qq.gdt.action.e.b.c cVar) {
        if (this.c == null) {
            cVar = new com.qq.gdt.action.e.b.c.a().a(new com.qq.gdt.action.e.b.a.e()).a(new com.qq.gdt.action.e.b.a.f(3)).a();
        }
        this.c = cVar;
    }

    public static e d() {
        return new e();
    }

    public com.qq.gdt.action.e.b.c b() {
        return this.b;
    }

    public com.qq.gdt.action.e.b.c c() {
        return this.c;
    }
}
