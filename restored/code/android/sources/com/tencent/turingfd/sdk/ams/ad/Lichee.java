package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Lichee {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final int f3860a;
    public final String b;
    public final long c;
    public final long d;
    public final int e;
    public final String f;
    public final Longan g;

    public Lichee(int i, String str, long j, long j2, int i2, String str2, Longan longan) {
        this.f3860a = i;
        this.b = str;
        this.c = j;
        this.d = j2;
        this.e = i2;
        this.f = str2;
        this.g = longan;
    }

    public Lichee(int i) {
        this(i, null, System.currentTimeMillis(), 0L, 0, null, null);
    }
}
