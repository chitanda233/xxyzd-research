package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Mango extends Pyxis implements Cloneable {
    public static final Longan h = new Longan();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3864a = 0;
    public String b = "";
    public int c = 0;
    public int d = 0;
    public String e = "";
    public long f = 0;
    public Longan g = null;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(this.f3864a, 0);
        phoenix.a(this.b, 1);
        int i = this.c;
        if (i != 0) {
            phoenix.a(i, 3);
        }
        int i2 = this.d;
        if (i2 != 0) {
            phoenix.a(i2, 4);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3864a = perseus.a(this.f3864a, 0, true);
        this.b = perseus.b(1, true);
        this.c = perseus.a(this.c, 3, false);
        this.d = perseus.a(this.d, 4, false);
        this.e = perseus.b(5, false);
        this.f = perseus.a(this.f, 6, false);
        this.g = (Longan) perseus.a((Pyxis) h, 8, false);
    }
}
