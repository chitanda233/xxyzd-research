package com.unicom.online.account.kernel;

import android.content.Context;
import android.net.Network;
import java.util.ArrayList;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes4.dex */
public final class s {
    public Network d;
    public Context e;
    public boolean f = false;
    public q b = new q();
    public ExecutorService c = Executors.newCachedThreadPool();

    public final void b() {
        if (this.f) {
            return;
        }
        this.f = true;
        q qVar = this.b;
        if (qVar != null) {
            qVar.c();
        }
        ExecutorService executorService = this.c;
        if (executorService != null && !executorService.isShutdown()) {
            try {
                this.c.shutdown();
                if (!this.c.awaitTermination(1L, TimeUnit.SECONDS)) {
                    this.c.shutdownNow();
                }
            } catch (InterruptedException unused) {
                this.c.shutdownNow();
                Thread.currentThread().interrupt();
            }
        }
        this.e = null;
        this.d = null;
    }

    public final void c() {
        if (this.f) {
            throw new IllegalStateException("ConnectionPoolManager已释放，不能再次使用");
        }
        if (this.e == null) {
            return;
        }
        ArrayList arrayList = new ArrayList(ao.o);
        if (arrayList.isEmpty()) {
            return;
        }
        arrayList.size();
        ExecutorService executorService = this.c;
        if (executorService == null || executorService.isShutdown() || this.c.isTerminated()) {
            this.c = Executors.newCachedThreadPool();
        }
        this.c.execute(new r(this, arrayList));
    }

    public final void finalize() throws Throwable {
        try {
            b();
        } finally {
            super.finalize();
        }
    }
}
