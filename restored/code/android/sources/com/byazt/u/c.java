package com.byazt.u;

import java.util.concurrent.ThreadFactory;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 67, 20})
public class c implements ThreadFactory {
    public final String c;
    public final AtomicInteger tt;
    public final boolean ve;

    public c(String str) {
        this(str, false);
    }

    public c(String str, boolean z) {
        this.tt = new AtomicInteger();
        this.c = str;
        this.ve = z;
    }

    @Override // java.util.concurrent.ThreadFactory
    public Thread newThread(Runnable runnable) {
        com.byazt.jtc.ve veVar = new com.byazt.jtc.ve(runnable, this.c + "-" + this.tt.incrementAndGet());
        if (!this.ve) {
            if (veVar.isDaemon()) {
                veVar.setDaemon(false);
            }
            if (veVar.getPriority() != 5) {
                veVar.setPriority(5);
            }
        }
        return veVar;
    }
}
