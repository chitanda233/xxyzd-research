package com.byazt.vgp;

/* JADX INFO: loaded from: classes2.dex */
public enum c {
    USE_KWS(0),
    USE_ALOG(1),
    USE_PITAYA(2),
    USE_OTHER(3);


    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f1508a;
    public long n;

    c(int i) {
        if (i < 0 || i > 63) {
            throw new IllegalArgumentException("bit argument illegal exception,range [0,63]");
        }
        this.n = 1 << i;
        this.f1508a = i;
    }

    public long c() {
        return this.n;
    }
}
