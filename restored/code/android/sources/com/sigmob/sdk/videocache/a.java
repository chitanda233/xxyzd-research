package com.sigmob.sdk.videocache;

import java.io.ByteArrayInputStream;
import java.util.Arrays;

/* JADX INFO: loaded from: classes4.dex */
public class a implements c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private volatile byte[] f3657a;
    private volatile boolean b;

    public a() {
        this(new byte[0]);
    }

    public a(byte[] data) {
        this.f3657a = (byte[]) n.a(data);
    }

    @Override // com.sigmob.sdk.videocache.c
    public int a(byte[] buffer, long offset, int length) throws p {
        if (offset >= this.f3657a.length) {
            return -1;
        }
        if (offset <= 2147483647L) {
            return new ByteArrayInputStream(this.f3657a).read(buffer, (int) offset, length);
        }
        throw new IllegalArgumentException("Too long offset for memory cache " + offset);
    }

    @Override // com.sigmob.sdk.videocache.c
    public long a() throws p {
        return this.f3657a.length;
    }

    @Override // com.sigmob.sdk.videocache.c
    public void a(byte[] newData, int length) throws p {
        n.a(this.f3657a);
        n.a(length >= 0 && length <= newData.length);
        byte[] bArrCopyOf = Arrays.copyOf(this.f3657a, this.f3657a.length + length);
        System.arraycopy(newData, 0, bArrCopyOf, this.f3657a.length, length);
        this.f3657a = bArrCopyOf;
    }

    @Override // com.sigmob.sdk.videocache.c
    public void b() throws p {
    }

    @Override // com.sigmob.sdk.videocache.c
    public void c() {
        this.b = true;
    }

    @Override // com.sigmob.sdk.videocache.c
    public boolean d() {
        return this.b;
    }
}
