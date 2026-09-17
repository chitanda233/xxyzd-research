package com.czhj.wire.okio;

import java.io.IOException;

/* JADX INFO: loaded from: classes2.dex */
final class PeekSource implements Source {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final BufferedSource f2390a;
    private final Buffer b;
    private Segment c;
    private int d;
    private boolean e;
    private long f;

    PeekSource(BufferedSource bufferedSource) {
        this.f2390a = bufferedSource;
        Buffer buffer = bufferedSource.buffer();
        this.b = buffer;
        Segment segment = buffer.b;
        this.c = segment;
        this.d = segment != null ? segment.d : -1;
    }

    @Override // com.czhj.wire.okio.Source, java.io.Closeable, java.lang.AutoCloseable
    public void close() throws IOException {
        this.e = true;
    }

    @Override // com.czhj.wire.okio.Source
    public long read(Buffer buffer, long j) throws IOException {
        if (j < 0) {
            throw new IllegalArgumentException("byteCount < 0: " + j);
        }
        if (this.e) {
            throw new IllegalStateException("closed");
        }
        Segment segment = this.c;
        if (segment != null && (segment != this.b.b || this.d != this.b.b.d)) {
            throw new IllegalStateException("Peek source is invalid because upstream source was used");
        }
        if (j == 0) {
            return 0L;
        }
        if (!this.f2390a.request(this.f + 1)) {
            return -1L;
        }
        if (this.c == null && this.b.b != null) {
            this.c = this.b.b;
            this.d = this.b.b.d;
        }
        long jMin = Math.min(j, this.b.c - this.f);
        this.b.copyTo(buffer, this.f, jMin);
        this.f += jMin;
        return jMin;
    }

    @Override // com.czhj.wire.okio.Source
    public Timeout timeout() {
        return this.f2390a.timeout();
    }
}
