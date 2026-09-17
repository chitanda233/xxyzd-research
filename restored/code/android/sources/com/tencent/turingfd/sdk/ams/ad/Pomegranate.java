package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Pomegranate extends Pyxis {
    public static final j0 l = new j0();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3881a = 2;
    public int b = 0;
    public String c = "";
    public String d = "";
    public String e = "";
    public int f = 0;
    public int g = 0;
    public long h = 0;
    public int i = 0;
    public String j = "";
    public j0 k = null;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(this.f3881a, 0);
        phoenix.a(this.b, 1);
        String str = this.c;
        if (str != null) {
            phoenix.a(str, 2);
        }
        String str2 = this.d;
        if (str2 != null) {
            phoenix.a(str2, 3);
        }
        String str3 = this.e;
        if (str3 != null) {
            phoenix.a(str3, 4);
        }
        int i = this.f;
        if (i != 0) {
            phoenix.a(i, 5);
        }
        int i2 = this.g;
        if (i2 != 0) {
            phoenix.a(i2, 6);
        }
        long j = this.h;
        if (j != 0) {
            phoenix.a(7, j);
        }
        int i3 = this.i;
        if (i3 != 0) {
            phoenix.a(i3, 8);
        }
        String str4 = this.j;
        if (str4 != null) {
            phoenix.a(str4, 9);
        }
        j0 j0Var = this.k;
        if (j0Var != null) {
            phoenix.a((Pyxis) j0Var, 10);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3881a = perseus.a(this.f3881a, 0, true);
        this.b = perseus.a(this.b, 1, true);
        this.c = perseus.b(2, false);
        this.d = perseus.b(3, false);
        this.e = perseus.b(4, false);
        this.f = perseus.a(this.f, 5, false);
        this.g = perseus.a(this.g, 6, false);
        this.h = perseus.a(this.h, 7, false);
        this.i = perseus.a(this.i, 8, false);
        this.j = perseus.b(9, false);
        this.k = (j0) perseus.a((Pyxis) l, 10, false);
    }
}
