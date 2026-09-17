package com.sigmob.sdk.videocache;

import java.io.ByteArrayInputStream;

/* JADX INFO: loaded from: classes4.dex */
public class b implements t {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final byte[] f3658a;
    private ByteArrayInputStream b;

    public b(byte[] data) {
        this.f3658a = data;
    }

    @Override // com.sigmob.sdk.videocache.t
    public int a(byte[] buffer) throws p {
        return this.b.read(buffer, 0, buffer.length);
    }

    @Override // com.sigmob.sdk.videocache.t
    public long a() throws p {
        return this.f3658a.length;
    }

    @Override // com.sigmob.sdk.videocache.t
    public void a(long offset) throws p {
        ByteArrayInputStream byteArrayInputStream = new ByteArrayInputStream(this.f3658a);
        this.b = byteArrayInputStream;
        byteArrayInputStream.skip(offset);
    }

    @Override // com.sigmob.sdk.videocache.t
    public void b() throws p {
    }

    @Override // com.sigmob.sdk.videocache.t
    public String c() throws p {
        return null;
    }

    @Override // com.sigmob.sdk.videocache.t
    public u d() {
        return null;
    }

    @Override // com.sigmob.sdk.videocache.t
    public com.sigmob.sdk.videocache.sourcestorage.c e() {
        return null;
    }

    @Override // com.sigmob.sdk.videocache.t
    public com.sigmob.sdk.videocache.headers.b f() {
        return null;
    }

    @Override // com.sigmob.sdk.videocache.t
    public String g() {
        return null;
    }
}
