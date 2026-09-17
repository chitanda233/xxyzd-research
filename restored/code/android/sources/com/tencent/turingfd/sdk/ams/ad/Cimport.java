package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.import, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Cimport extends Pyxis {
    public static final Cfinally h = new Cfinally();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3937a = 0;
    public int b = 0;
    public int c = 0;
    public byte[] d = null;
    public Cfinally e = null;
    public byte[] f = null;
    public int g = 0;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(this.f3937a, 0);
        int i = this.b;
        if (i != 0) {
            phoenix.a(i, 1);
        }
        int i2 = this.c;
        if (i2 != 0) {
            phoenix.a(i2, 2);
        }
        byte[] bArr = this.d;
        if (bArr != null) {
            phoenix.a(3, bArr);
        }
        Cfinally cfinally = this.e;
        if (cfinally != null) {
            phoenix.a((Pyxis) cfinally, 4);
        }
        byte[] bArr2 = this.f;
        if (bArr2 != null) {
            phoenix.a(5, bArr2);
        }
        int i3 = this.g;
        if (i3 != 0) {
            phoenix.a(i3, 6);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3937a = perseus.a(this.f3937a, 0, true);
        this.b = perseus.a(this.b, 1, false);
        this.c = perseus.a(this.c, 2, false);
        this.d = perseus.a(3, false);
        this.e = (Cfinally) perseus.a((Pyxis) h, 4, false);
        this.f = perseus.a(5, false);
        this.g = perseus.a(this.g, 6, false);
    }
}
