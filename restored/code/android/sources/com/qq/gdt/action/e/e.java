package com.qq.gdt.action.e;

import com.qq.gdt.action.e.b.h;

/* JADX INFO: loaded from: classes3.dex */
public class e extends d<e> {
    private byte[] d;

    public e a(byte[] bArr) {
        this.d = bArr;
        return this;
    }

    public c b() {
        a();
        return new c(this.c.a(h.a(com.qq.gdt.action.e.b.f.a("application/json; charset=utf-8"), this.d)).a(this.f3064a).a());
    }
}
