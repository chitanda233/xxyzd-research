package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Segment {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final int f3890a;
    public final int b;
    public final long c;
    public final String d;
    public final int e;
    public final int f;

    public Segment(int i, int i2, long j, String str, int i3, int i4) {
        this.f3890a = i;
        this.b = i2;
        this.c = j;
        this.d = str;
        this.e = i3;
        this.f = i4;
    }

    public static Segment a(int i) {
        return new Segment(i, 100, -1L, "", -1, -2);
    }

    public final String toString() {
        return this.f3890a + "_" + this.b + "_" + this.c + "_" + this.e + "_" + this.d + "_" + this.f;
    }
}
