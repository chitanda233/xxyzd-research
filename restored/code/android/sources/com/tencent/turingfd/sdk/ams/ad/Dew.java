package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Dew {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final int f3845a;
    public final int b;
    public final int c;
    public final String d;
    public final int e;

    public Dew(int i, int i2, String str, int i3, int i4) {
        this.f3845a = i;
        this.b = i2;
        this.d = str;
        this.c = i3;
        this.e = i4;
    }

    public final String toString() {
        return "" + String.format("% 6d", Integer.valueOf(this.f3845a)) + "    " + String.format("% 6d", Integer.valueOf(this.b)) + "    " + String.format("% 6d", Integer.valueOf(this.c)) + "    " + this.d;
    }
}
