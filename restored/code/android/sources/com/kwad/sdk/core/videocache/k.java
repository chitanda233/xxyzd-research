package com.kwad.sdk.core.videocache;

import com.kwad.sdk.utils.az;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
class k {
    private final m bat;
    private final com.kwad.sdk.core.videocache.a bau;
    private volatile Thread bay;
    private volatile boolean nC;
    private final Object bav = new Object();
    private final Object baw = new Object();
    private volatile int baz = -1;
    private final AtomicInteger bax = new AtomicInteger();

    protected void eC(int i) {
    }

    public k(m mVar, com.kwad.sdk.core.videocache.a aVar) {
        this.bat = (m) az.checkNotNull(mVar);
        this.bau = (com.kwad.sdk.core.videocache.a) az.checkNotNull(aVar);
    }

    public final int a(byte[] bArr, long j, int i) throws ProxyCacheException {
        l.b(bArr, j, 1024);
        while (!this.bau.isCompleted() && this.bau.Pe() < 1024 + j && !this.nC) {
            Pr();
            Ps();
            Pq();
        }
        int iA = this.bau.a(bArr, j, 1024);
        if (this.bau.isCompleted() && this.baz != 100) {
            this.baz = 100;
            eC(100);
        }
        return iA;
    }

    private void Pq() throws ProxyCacheException {
        int i = this.bax.get();
        if (i <= 0) {
            return;
        }
        this.bax.set(0);
        throw new ProxyCacheException("Error reading source " + i + " times");
    }

    public final void shutdown() {
        synchronized (this.baw) {
            com.kwad.sdk.core.d.c.d("ProxyCache", "Shutdown proxy for " + this.bat);
            try {
                this.nC = true;
                if (this.bay != null) {
                    this.bay.interrupt();
                }
                this.bau.close();
            } catch (ProxyCacheException e) {
                onError(e);
            }
        }
    }

    private synchronized void Pr() {
        byte b = 0;
        boolean z = (this.bay == null || this.bay.getState() == Thread.State.TERMINATED) ? false : true;
        if (!this.nC && !this.bau.isCompleted() && !z) {
            this.bay = new Thread(new a(this, b), "Source reader for " + this.bat);
            this.bay.start();
        }
    }

    private void Ps() {
        synchronized (this.bav) {
            try {
                try {
                    this.bav.wait(1000L);
                } catch (InterruptedException e) {
                    throw new ProxyCacheException("Waiting source data is interrupted!", e);
                }
            } catch (Throwable th) {
                throw th;
            }
        }
    }

    private void j(long j, long j2) {
        k(j, j2);
        synchronized (this.bav) {
            this.bav.notifyAll();
        }
    }

    private void k(long j, long j2) {
        int i = (j2 > 0L ? 1 : (j2 == 0L ? 0 : -1)) == 0 ? 100 : (int) ((j / j2) * 100.0f);
        boolean z = i != this.baz;
        if ((j2 >= 0) && z) {
            eC(i);
        }
        this.baz = i;
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code restructure failed: missing block: B:15:0x0039, code lost:
    
        r2 = r2 + ((long) r5);
     */
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    public void Pt() {
        /*
            r8 = this;
            r0 = -1
            r2 = 0
            com.kwad.sdk.core.videocache.a r4 = r8.bau     // Catch: java.lang.Throwable -> L49
            long r2 = r4.Pe()     // Catch: java.lang.Throwable -> L49
            com.kwad.sdk.core.videocache.m r4 = r8.bat     // Catch: java.lang.Throwable -> L49
            r4.aM(r2)     // Catch: java.lang.Throwable -> L49
            com.kwad.sdk.core.videocache.m r4 = r8.bat     // Catch: java.lang.Throwable -> L49
            long r0 = r4.length()     // Catch: java.lang.Throwable -> L49
            r4 = 1024(0x400, float:1.435E-42)
            byte[] r4 = new byte[r4]     // Catch: java.lang.Throwable -> L49
        L19:
            com.kwad.sdk.core.videocache.m r5 = r8.bat     // Catch: java.lang.Throwable -> L49
            int r5 = r5.read(r4)     // Catch: java.lang.Throwable -> L49
            r6 = -1
            if (r5 == r6) goto L42
            java.lang.Object r6 = r8.baw     // Catch: java.lang.Throwable -> L49
            monitor-enter(r6)     // Catch: java.lang.Throwable -> L49
            boolean r7 = r8.isStopped()     // Catch: java.lang.Throwable -> L3f
            if (r7 == 0) goto L33
            monitor-exit(r6)     // Catch: java.lang.Throwable -> L3f
        L2c:
            r8.Pv()
            r8.j(r2, r0)
            return
        L33:
            com.kwad.sdk.core.videocache.a r7 = r8.bau     // Catch: java.lang.Throwable -> L3f
            r7.d(r4, r5)     // Catch: java.lang.Throwable -> L3f
            monitor-exit(r6)     // Catch: java.lang.Throwable -> L3f
            long r5 = (long) r5
            long r2 = r2 + r5
            r8.j(r2, r0)     // Catch: java.lang.Throwable -> L49
            goto L19
        L3f:
            r4 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Throwable -> L3f
            throw r4     // Catch: java.lang.Throwable -> L49
        L42:
            r8.tryComplete()     // Catch: java.lang.Throwable -> L49
            r8.Pu()     // Catch: java.lang.Throwable -> L49
            goto L2c
        L49:
            r4 = move-exception
            java.util.concurrent.atomic.AtomicInteger r5 = r8.bax     // Catch: java.lang.Throwable -> L53
            r5.incrementAndGet()     // Catch: java.lang.Throwable -> L53
            onError(r4)     // Catch: java.lang.Throwable -> L53
            goto L2c
        L53:
            r4 = move-exception
            r8.Pv()
            r8.j(r2, r0)
            throw r4
        */
        throw new UnsupportedOperationException("Method not decompiled: com.kwad.sdk.core.videocache.k.Pt():void");
    }

    private void Pu() {
        this.baz = 100;
        eC(this.baz);
    }

    private void tryComplete() {
        synchronized (this.baw) {
            if (!isStopped() && this.bau.Pe() == this.bat.length()) {
                this.bau.complete();
            }
        }
    }

    private boolean isStopped() {
        return Thread.currentThread().isInterrupted() || this.nC;
    }

    private void Pv() {
        try {
            this.bat.close();
        } catch (ProxyCacheException e) {
            onError(new ProxyCacheException("Error closing source " + this.bat, e));
        }
    }

    private static void onError(Throwable th) {
        if (th instanceof InterruptedProxyCacheException) {
            com.kwad.sdk.core.d.c.d("ProxyCache", "ProxyCache is interrupted");
        } else {
            com.kwad.sdk.core.d.c.e("ProxyCache", "ProxyCache error");
        }
    }

    class a implements Runnable {
        private a() {
        }

        /* synthetic */ a(k kVar, byte b) {
            this();
        }

        @Override // java.lang.Runnable
        public final void run() {
            k.this.Pt();
        }
    }
}
