package com.qq.gdt.action.e.b.a;

import com.qq.gdt.action.e.b.i;
import com.qq.gdt.action.i.n;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.v;
import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public class e implements c {
    @Override // com.qq.gdt.action.e.b.a.c
    public i a(c.a aVar) throws IOException {
        com.qq.gdt.action.e.b.g gVarA = aVar.a();
        long jNanoTime = System.nanoTime();
        o.a(v.a("Sending request %s %s", gVarA.e(), gVarA.a()), new Object[0]);
        i iVarA = aVar.a(gVarA);
        o.a(v.a("Received response for %s in %.1fms (http status code %d)%n%s", iVarA.a().a(), Double.valueOf((System.nanoTime() - jNanoTime) / 1000000.0d), Integer.valueOf(iVarA.c()), n.a(iVarA.e().c())), new Object[0]);
        return iVarA;
    }
}
