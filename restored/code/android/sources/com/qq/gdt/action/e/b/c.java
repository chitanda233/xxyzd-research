package com.qq.gdt.action.e.b;

import com.qq.gdt.action.i.o;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final d f3050a;
    private List<com.qq.gdt.action.e.b.a.c> b;

    public static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final d f3051a = new d();
        private final List<com.qq.gdt.action.e.b.a.c> b = new ArrayList();

        public a a(com.qq.gdt.action.e.b.a.c cVar) {
            if (cVar == null) {
                o.b("interceptor == null");
                return this;
            }
            this.b.add(cVar);
            return this;
        }

        public c a() {
            return new c(this);
        }
    }

    c(a aVar) {
        this.b = new ArrayList();
        this.f3050a = aVar.f3051a;
        this.b = k.a(aVar.b);
    }

    public com.qq.gdt.action.e.b.a a(g gVar) {
        return new com.qq.gdt.action.e.b.a(new e(this.f3050a), gVar, this);
    }

    public List<com.qq.gdt.action.e.b.a.c> a() {
        return this.b;
    }
}
