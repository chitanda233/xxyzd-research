package com.kwad.framework.filedownloader.download;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    final long aAY;
    final long aAZ;
    final long aBa;
    final long contentLength;

    a(long j, long j2, long j3, long j4) {
        this.aAY = j;
        this.aAZ = j2;
        this.aBa = j3;
        this.contentLength = j4;
    }

    public final String toString() {
        return com.kwad.framework.filedownloader.f.f.c("range[%d, %d) current offset[%d]", Long.valueOf(this.aAY), Long.valueOf(this.aBa), Long.valueOf(this.aAZ));
    }
}
