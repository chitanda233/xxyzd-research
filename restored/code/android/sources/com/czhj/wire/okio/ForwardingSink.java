package com.czhj.wire.okio;

import java.io.IOException;

/* JADX INFO: loaded from: classes2.dex */
public abstract class ForwardingSink implements Sink {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Sink f2378a;

    public ForwardingSink(Sink sink) {
        if (sink == null) {
            throw new IllegalArgumentException("delegate == null");
        }
        this.f2378a = sink;
    }

    @Override // com.czhj.wire.okio.Sink, java.io.Closeable, java.lang.AutoCloseable
    public void close() throws IOException {
        this.f2378a.close();
    }

    public final Sink delegate() {
        return this.f2378a;
    }

    @Override // com.czhj.wire.okio.Sink, java.io.Flushable
    public void flush() throws IOException {
        this.f2378a.flush();
    }

    @Override // com.czhj.wire.okio.Sink
    public Timeout timeout() {
        return this.f2378a.timeout();
    }

    public String toString() {
        return getClass().getSimpleName() + "(" + this.f2378a.toString() + ")";
    }

    @Override // com.czhj.wire.okio.Sink
    public void write(Buffer buffer, long j) throws IOException {
        this.f2378a.write(buffer, j);
    }
}
