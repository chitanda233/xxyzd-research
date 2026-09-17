package com.sigmob.sdk.archives.utils;

import java.io.FilterInputStream;
import java.io.IOException;
import java.io.InputStream;

/* JADX INFO: loaded from: classes2.dex */
public class b extends FilterInputStream {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private long f3120a;

    public b(final InputStream in) {
        super(in);
    }

    public long a() {
        return this.f3120a;
    }

    protected final void a(long read) {
        if (read != -1) {
            this.f3120a += read;
        }
    }

    @Override // java.io.FilterInputStream, java.io.InputStream
    public int read() throws IOException {
        int i = this.in.read();
        if (i >= 0) {
            a(1L);
        }
        return i;
    }

    @Override // java.io.FilterInputStream, java.io.InputStream
    public int read(byte[] b) throws IOException {
        return read(b, 0, b.length);
    }

    @Override // java.io.FilterInputStream, java.io.InputStream
    public int read(byte[] b, int off, int len) throws IOException {
        int i = this.in.read(b, off, len);
        if (i >= 0) {
            a(i);
        }
        return i;
    }
}
