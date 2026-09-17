package com.sigmob.sdk.videocache;

import com.czhj.sdk.logger.SigmobLog;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes4.dex */
class o {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final int f3675a = 1;
    private final t b;
    private final c c;
    private volatile Thread g;
    private volatile boolean h;
    private final Object d = new Object();
    private final Object e = new Object();
    private volatile int i = -1;
    private final AtomicInteger f = new AtomicInteger();

    private class a implements Runnable {
        private a() {
        }

        @Override // java.lang.Runnable
        public void run() {
            o.this.e();
        }
    }

    public o(t source, c cache) {
        this.b = (t) n.a(source);
        this.c = (c) n.a(cache);
    }

    private void b() throws p {
        int i = this.f.get();
        if (i < 1) {
            return;
        }
        this.f.set(0);
        throw new p("Error reading source " + i + " times");
    }

    private void b(long cacheAvailable, long sourceAvailable) {
        a(cacheAvailable, sourceAvailable);
        synchronized (this.d) {
            this.d.notifyAll();
        }
    }

    private synchronized void c() throws p {
        boolean z = (this.g == null || this.g.getState() == Thread.State.TERMINATED) ? false : true;
        if (!this.h && !this.c.d() && !z) {
            SigmobLog.d("Thread create ,current thread num :" + Thread.activeCount());
            this.g = new Thread(new a(), "Source reader for " + this.b);
            this.g.start();
        }
    }

    private void c(Throwable throwable) {
        a(throwable);
    }

    private void d() throws p {
        synchronized (this.d) {
            try {
                try {
                    this.d.wait(1000L);
                } catch (InterruptedException e) {
                    throw new p("Waiting source data is interrupted!", e);
                }
            } catch (Throwable th) {
                throw th;
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void e() {
        long jA = -1;
        long jA2 = 0;
        try {
            jA2 = this.c.a();
            this.b.a(jA2);
            jA = this.b.a();
            byte[] bArr = new byte[8192];
            while (true) {
                int iA = this.b.a(bArr);
                if (iA == -1) {
                    g();
                    f();
                    i();
                    b(jA2, jA);
                    synchronized (this.d) {
                        this.d.notifyAll();
                    }
                    return;
                }
                synchronized (this.e) {
                    if (h()) {
                        SigmobLog.d("SourceReaderRunnable停止从服务器下载视频数据");
                        i();
                        b(jA2, jA);
                        synchronized (this.d) {
                            this.d.notifyAll();
                        }
                        return;
                    }
                    this.c.a(bArr, iA);
                }
                jA2 += (long) iA;
                b(jA2, jA);
            }
        } catch (Throwable th) {
            try {
                this.f.incrementAndGet();
                b(th);
                c(th);
            } finally {
                i();
                b(jA2, jA);
                synchronized (this.d) {
                    this.d.notifyAll();
                }
            }
        }
    }

    private void f() {
        this.i = 100;
        a(this.i);
    }

    private void g() throws p {
        synchronized (this.e) {
            if (!h() && this.c.a() == this.b.a()) {
                this.c.c();
            }
        }
    }

    private boolean h() {
        return Thread.currentThread().isInterrupted() || this.h;
    }

    private void i() {
        try {
            this.b.b();
        } catch (p e) {
            b(new p("Error closing source " + this.b, e));
        }
    }

    public int a(byte[] buffer, long offset, int length) throws p {
        q.a(buffer, offset, length);
        while (!this.c.d() && this.c.a() < ((long) length) + offset && !this.h) {
            c();
            d();
            b();
        }
        int iA = this.c.a(buffer, offset, length);
        if (this.c.d() && this.i != 100) {
            this.i = 100;
            a(100);
        }
        return iA;
    }

    public void a() {
        synchronized (this.e) {
            SigmobLog.d("Shutdown proxy for " + this.b);
            try {
                this.h = true;
                if (this.g != null) {
                    this.g.interrupt();
                }
                this.c.b();
            } catch (p e) {
                b(e);
            }
        }
    }

    protected void a(int percentsAvailable) {
    }

    protected void a(long cacheAvailable, long sourceLength) {
        int i = (sourceLength > 0L ? 1 : (sourceLength == 0L ? 0 : -1)) == 0 ? 100 : (int) ((cacheAvailable / sourceLength) * 100.0f);
        boolean z = i != this.i;
        if ((sourceLength >= 0) && z) {
            a(i);
        }
        this.i = i;
    }

    protected void a(Throwable throwable) {
    }

    protected final void b(final Throwable e) {
        if (e instanceof k) {
            SigmobLog.d("ProxyCache is interrupted");
        } else {
            SigmobLog.e("ProxyCache error", e);
        }
    }
}
