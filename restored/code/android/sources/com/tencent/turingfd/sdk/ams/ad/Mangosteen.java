package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Mangosteen extends Pyxis {
    public static final Pitaya k = new Pitaya();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3865a = 0;
    public int b = 0;
    public int c = 0;
    public int d = 0;
    public int e = 0;
    public byte[] f = null;
    public Pitaya g = null;
    public byte[] h = null;
    public int i = 0;
    public String j = "";

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(this.f3865a, 0);
        int i = this.b;
        if (i != 0) {
            phoenix.a(i, 1);
        }
        int i2 = this.c;
        if (i2 != 0) {
            phoenix.a(i2, 2);
        }
        phoenix.a(this.d, 3);
        int i3 = this.e;
        if (i3 != 0) {
            phoenix.a(i3, 4);
        }
        byte[] bArr = this.f;
        if (bArr != null) {
            phoenix.a(5, bArr);
        }
        Pitaya pitaya = this.g;
        if (pitaya != null) {
            phoenix.a((Pyxis) pitaya, 6);
        }
        byte[] bArr2 = this.h;
        if (bArr2 != null) {
            phoenix.a(7, bArr2);
        }
        int i4 = this.i;
        if (i4 != 0) {
            phoenix.a(i4, 8);
        }
        String str = this.j;
        if (str != null) {
            phoenix.a(str, 9);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3865a = perseus.a(this.f3865a, 0, true);
        this.b = perseus.a(this.b, 1, false);
        this.c = perseus.a(this.c, 2, false);
        this.d = perseus.a(this.d, 3, false);
        this.e = perseus.a(this.e, 4, false);
        this.f = perseus.a(5, false);
        this.g = (Pitaya) perseus.a((Pyxis) k, 6, false);
        this.h = perseus.a(7, false);
        this.i = perseus.a(this.i, 8, false);
        this.j = perseus.b(9, false);
    }
}
