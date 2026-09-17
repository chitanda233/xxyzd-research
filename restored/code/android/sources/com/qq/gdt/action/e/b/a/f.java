package com.qq.gdt.action.e.b.a;

import com.qq.gdt.action.e.b.i;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.v;
import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public class f implements c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3049a;

    public f(int i) {
        this.f3049a = i;
    }

    @Override // com.qq.gdt.action.e.b.a.c
    public i a(c.a aVar) throws IOException {
        com.qq.gdt.action.e.b.g gVarA = aVar.a();
        i iVarA = aVar.a(gVarA);
        int i = 0;
        while (!iVarA.b() && i < this.f3049a) {
            iVarA.e().close();
            i++;
            o.a(v.a("Retry for %s, retry number = %d", gVarA.a(), Integer.valueOf(i)), new Object[0]);
            iVarA = aVar.a(gVarA);
        }
        return iVarA;
    }
}
