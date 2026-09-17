package com.czhj.wire.okio;

import java.io.IOException;

/* JADX INFO: loaded from: classes2.dex */
public final class Pipe {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final long f2391a;
    boolean c;
    boolean d;
    private Sink g;
    final Buffer b = new Buffer();
    private final Sink e = new PipeSink();
    private final Source f = new PipeSource();

    final class PipeSink implements Sink {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final PushableTimeout f2392a = new PushableTimeout();

        PipeSink() {
        }

        @Override // com.czhj.wire.okio.Sink, java.io.Closeable, java.lang.AutoCloseable
        public void close() throws IOException {
            Sink sink;
            synchronized (Pipe.this.b) {
                if (Pipe.this.c) {
                    return;
                }
                if (Pipe.this.g != null) {
                    sink = Pipe.this.g;
                } else {
                    if (Pipe.this.d && Pipe.this.b.size() > 0) {
                        throw new IOException("source is closed");
                    }
                    Pipe.this.c = true;
                    Pipe.this.b.notifyAll();
                    sink = null;
                }
                if (sink != null) {
                    this.f2392a.a(sink.timeout());
                    try {
                        sink.close();
                    } finally {
                        this.f2392a.a();
                    }
                }
            }
        }

        @Override // com.czhj.wire.okio.Sink, java.io.Flushable
        public void flush() throws IOException {
            Sink sink;
            synchronized (Pipe.this.b) {
                if (Pipe.this.c) {
                    throw new IllegalStateException("closed");
                }
                if (Pipe.this.g != null) {
                    sink = Pipe.this.g;
                } else {
                    if (Pipe.this.d && Pipe.this.b.size() > 0) {
                        throw new IOException("source is closed");
                    }
                    sink = null;
                }
            }
            if (sink != null) {
                this.f2392a.a(sink.timeout());
                try {
                    sink.flush();
                } finally {
                    this.f2392a.a();
                }
            }
        }

        @Override // com.czhj.wire.okio.Sink
        public Timeout timeout() {
            return this.f2392a;
        }

        @Override // com.czhj.wire.okio.Sink
        public void write(Buffer buffer, long j) throws IOException {
            Sink sink;
            synchronized (Pipe.this.b) {
                if (!Pipe.this.c) {
                    while (true) {
                        if (j <= 0) {
                            sink = null;
                            break;
                        }
                        if (Pipe.this.g != null) {
                            sink = Pipe.this.g;
                            break;
                        }
                        if (Pipe.this.d) {
                            throw new IOException("source is closed");
                        }
                        long size = Pipe.this.f2391a - Pipe.this.b.size();
                        if (size == 0) {
                            this.f2392a.waitUntilNotified(Pipe.this.b);
                        } else {
                            long jMin = Math.min(size, j);
                            Pipe.this.b.write(buffer, jMin);
                            j -= jMin;
                            Pipe.this.b.notifyAll();
                        }
                    }
                } else {
                    throw new IllegalStateException("closed");
                }
            }
            if (sink != null) {
                this.f2392a.a(sink.timeout());
                try {
                    sink.write(buffer, j);
                } finally {
                    this.f2392a.a();
                }
            }
        }
    }

    final class PipeSource implements Source {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final Timeout f2393a = new Timeout();

        PipeSource() {
        }

        @Override // com.czhj.wire.okio.Source, java.io.Closeable, java.lang.AutoCloseable
        public void close() throws IOException {
            synchronized (Pipe.this.b) {
                Pipe.this.d = true;
                Pipe.this.b.notifyAll();
            }
        }

        @Override // com.czhj.wire.okio.Source
        public long read(Buffer buffer, long j) throws IOException {
            synchronized (Pipe.this.b) {
                if (Pipe.this.d) {
                    throw new IllegalStateException("closed");
                }
                while (Pipe.this.b.size() == 0) {
                    if (Pipe.this.c) {
                        return -1L;
                    }
                    this.f2393a.waitUntilNotified(Pipe.this.b);
                }
                long j2 = Pipe.this.b.read(buffer, j);
                Pipe.this.b.notifyAll();
                return j2;
            }
        }

        @Override // com.czhj.wire.okio.Source
        public Timeout timeout() {
            return this.f2393a;
        }
    }

    public Pipe(long j) {
        if (j < 1) {
            throw new IllegalArgumentException("maxBufferSize < 1: " + j);
        }
        this.f2391a = j;
    }

    public void fold(Sink sink) throws IOException {
        boolean z;
        Buffer buffer;
        while (true) {
            synchronized (this.b) {
                if (this.g != null) {
                    throw new IllegalStateException("sink already folded");
                }
                if (this.b.exhausted()) {
                    this.d = true;
                    this.g = sink;
                    return;
                } else {
                    z = this.c;
                    buffer = new Buffer();
                    Buffer buffer2 = this.b;
                    buffer.write(buffer2, buffer2.c);
                    this.b.notifyAll();
                }
            }
            try {
                sink.write(buffer, buffer.c);
                if (z) {
                    sink.close();
                } else {
                    sink.flush();
                }
            } catch (Throwable th) {
                synchronized (this.b) {
                    this.d = true;
                    this.b.notifyAll();
                    throw th;
                }
            }
        }
    }

    public final Sink sink() {
        return this.e;
    }

    public final Source source() {
        return this.f;
    }
}
