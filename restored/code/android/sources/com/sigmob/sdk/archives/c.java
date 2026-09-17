package com.sigmob.sdk.archives;

import java.io.IOException;
import java.io.InputStream;
import kotlin.UByte;

/* JADX INFO: loaded from: classes2.dex */
public abstract class c extends InputStream {
    private static final int b = 255;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private byte[] f3112a = new byte[1];
    private long c = 0;

    private void b(long read) {
        if (read != -1) {
            this.c += read;
        }
    }

    public abstract a a() throws IOException;

    protected void a(int read) {
        b(read);
    }

    protected void a(long pushedBack) {
        this.c -= pushedBack;
    }

    public boolean a(a ae) {
        return true;
    }

    @Deprecated
    public int b() {
        return (int) this.c;
    }

    protected long c() {
        return this.c;
    }

    @Override // java.io.InputStream
    public int read() throws IOException {
        if (read(this.f3112a, 0, 1) == -1) {
            return -1;
        }
        return this.f3112a[0] & UByte.MAX_VALUE;
    }
}
