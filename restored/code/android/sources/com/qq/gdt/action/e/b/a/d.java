package com.qq.gdt.action.e.b.a;

import com.qq.gdt.action.e.b.i;
import java.io.IOException;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class d implements c.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final List<c> f3048a;
    private final int b;
    private int c;
    private final com.qq.gdt.action.e.b.g d;
    private final com.qq.gdt.action.e.b.e e;
    private final com.qq.gdt.action.e.b.a f;

    public d(com.qq.gdt.action.e.b.e eVar, List<c> list, int i, com.qq.gdt.action.e.b.g gVar, com.qq.gdt.action.e.b.a aVar) {
        this.e = eVar;
        this.f3048a = list;
        this.b = i;
        this.d = gVar;
        this.f = aVar;
    }

    @Override // com.qq.gdt.action.e.b.a.c.a
    public com.qq.gdt.action.e.b.g a() {
        return this.d;
    }

    @Override // com.qq.gdt.action.e.b.a.c.a
    public i a(com.qq.gdt.action.e.b.g gVar) throws IOException {
        if (this.b >= this.f3048a.size()) {
            throw new AssertionError();
        }
        this.c++;
        d dVar = new d(this.e, this.f3048a, this.b + 1, gVar, this.f);
        c cVar = this.f3048a.get(this.b);
        i iVarA = cVar.a(dVar);
        if (iVarA == null) {
            throw new NullPointerException("interceptor " + cVar + " returned null");
        }
        if (iVarA.e() != null) {
            return iVarA;
        }
        throw new IllegalStateException("interceptor " + cVar + " returned a response with no body");
    }

    public com.qq.gdt.action.e.b.e b() {
        return this.e;
    }
}
