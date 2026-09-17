package com.czhj.wire.okio;

import java.io.IOException;
import java.util.zip.Deflater;

/* JADX INFO: loaded from: classes2.dex */
public final class DeflaterSink implements Sink {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final BufferedSink f2377a;
    private final Deflater b;
    private boolean c;

    DeflaterSink(BufferedSink bufferedSink, Deflater deflater) {
        if (bufferedSink == null) {
            throw new IllegalArgumentException("source == null");
        }
        if (deflater == null) {
            throw new IllegalArgumentException("inflater == null");
        }
        this.f2377a = bufferedSink;
        this.b = deflater;
    }

    public DeflaterSink(Sink sink, Deflater deflater) {
        this(Okio.buffer(sink), deflater);
    }

    private void a(boolean z) throws IOException {
        Segment segmentA;
        Buffer buffer = this.f2377a.buffer();
        while (true) {
            segmentA = buffer.a(1);
            Deflater deflater = this.b;
            byte[] bArr = segmentA.c;
            int i = segmentA.e;
            int i2 = 8192 - segmentA.e;
            int iDeflate = z ? deflater.deflate(bArr, i, i2, 2) : deflater.deflate(bArr, i, i2);
            if (iDeflate > 0) {
                segmentA.e += iDeflate;
                buffer.c += (long) iDeflate;
                this.f2377a.emitCompleteSegments();
            } else if (this.b.needsInput()) {
                break;
            }
        }
        if (segmentA.d == segmentA.e) {
            buffer.b = segmentA.pop();
            SegmentPool.a(segmentA);
        }
    }

    void a() throws IOException {
        this.b.finish();
        a(false);
    }

    @Override // com.czhj.wire.okio.Sink, java.io.Closeable, java.lang.AutoCloseable
    public void close() throws Throwable {
        if (this.c) {
            return;
        }
        a();
        th = null;
        try {
            this.b.end();
        } catch (Throwable th) {
            if (th == null) {
                th = th;
            }
        }
        try {
            this.f2377a.close();
        } catch (Throwable th2) {
            if (th == null) {
                th = th2;
            }
        }
        this.c = true;
        if (th != null) {
            Util.sneakyRethrow(th);
        }
    }

    @Override // com.czhj.wire.okio.Sink, java.io.Flushable
    public void flush() throws IOException {
        a(true);
        this.f2377a.flush();
    }

    @Override // com.czhj.wire.okio.Sink
    public Timeout timeout() {
        return this.f2377a.timeout();
    }

    public String toString() {
        return "DeflaterSink(" + this.f2377a + ")";
    }

    @Override // com.czhj.wire.okio.Sink
    public void write(Buffer buffer, long j) throws IOException {
        Util.checkOffsetAndCount(buffer.c, 0L, j);
        while (j > 0) {
            Segment segment = buffer.b;
            int iMin = (int) Math.min(j, segment.e - segment.d);
            this.b.setInput(segment.c, segment.d, iMin);
            a(false);
            long j2 = iMin;
            buffer.c -= j2;
            segment.d += iMin;
            if (segment.d == segment.e) {
                buffer.b = segment.pop();
                SegmentPool.a(segment);
            }
            j -= j2;
        }
    }
}
