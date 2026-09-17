package com.czhj.wire.okio;

import java.io.IOException;

/* JADX INFO: loaded from: classes2.dex */
public abstract class ForwardingSource implements Source {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Source f2379a;

    public ForwardingSource(Source source) {
        if (source == null) {
            throw new IllegalArgumentException("delegate == null");
        }
        this.f2379a = source;
    }

    @Override // com.czhj.wire.okio.Source, java.io.Closeable, java.lang.AutoCloseable
    public void close() throws IOException {
        this.f2379a.close();
    }

    public final Source delegate() {
        return this.f2379a;
    }

    @Override // com.czhj.wire.okio.Source
    public long read(Buffer buffer, long j) throws IOException {
        return this.f2379a.read(buffer, j);
    }

    @Override // com.czhj.wire.okio.Source
    public Timeout timeout() {
        return this.f2379a.timeout();
    }

    public String toString() {
        return getClass().getSimpleName() + "(" + this.f2379a.toString() + ")";
    }
}
