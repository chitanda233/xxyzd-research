package com.kwad.components.core.q;

import java.io.IOException;
import java.io.InputStream;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends InputStream {
    private InputStream akB;
    private int akC;
    private volatile float akE;
    private volatile long akF;
    private int aky = -1;
    private int akz = 10000;
    private long akA = -1;
    private long akD = -1;
    private int akG = 20480;

    c(InputStream inputStream, int i) {
        i = i < 20480 ? 20480 : i;
        this.akB = inputStream;
        this.akE = i / 1000.0f;
    }

    public final long wv() {
        return this.akF;
    }

    @Override // java.io.InputStream
    public final int read() throws IOException {
        if (this.akD <= 0) {
            this.akD = System.currentTimeMillis();
        }
        this.akC++;
        if (!(b.akw && b.akv)) {
            return this.akB.read();
        }
        if (this.aky < 0) {
            ww();
        }
        int i = this.akB.read();
        this.aky++;
        wx();
        return i;
    }

    @Override // java.io.InputStream
    public final long skip(long j) {
        return this.akB.skip(j);
    }

    @Override // java.io.InputStream
    public final int available() {
        return this.akB.available();
    }

    @Override // java.io.InputStream, java.io.Closeable, java.lang.AutoCloseable
    public final void close() throws IOException {
        this.akB.close();
        b.a(this);
        this.akD = -1L;
    }

    @Override // java.io.InputStream
    public final synchronized void mark(int i) {
        this.akB.mark(i);
    }

    @Override // java.io.InputStream
    public final synchronized void reset() {
        this.akB.reset();
    }

    @Override // java.io.InputStream
    public final boolean markSupported() {
        return this.akB.markSupported();
    }

    private void ww() {
        this.aky = 0;
        this.akA = System.currentTimeMillis();
    }

    private void wx() {
        if (this.aky < this.akz) {
            return;
        }
        long jCurrentTimeMillis = System.currentTimeMillis();
        long j = jCurrentTimeMillis - this.akA;
        float f = this.aky / this.akE;
        this.akF = g(this.akC, jCurrentTimeMillis - this.akD);
        float f2 = j;
        if (f > f2) {
            Q((long) (f - f2));
        }
        ww();
    }

    private static long g(long j, long j2) {
        if (j <= 0) {
            return 0L;
        }
        if (j2 <= 0) {
            return -1L;
        }
        return j / j2;
    }

    private static void Q(long j) {
        try {
            Thread.sleep(j);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
