package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Nectarine extends Pyxis {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3868a = 0;
    public int b = 0;
    public int c = 0;
    public int d = 0;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        int i = this.f3868a;
        if (i != 0) {
            phoenix.a(i, 0);
        }
        phoenix.a(this.b, 1);
        int i2 = this.c;
        if (i2 != 0) {
            phoenix.a(i2, 2);
        }
        int i3 = this.d;
        if (i3 != 0) {
            phoenix.a(i3, 3);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3868a = perseus.a(this.f3868a, 0, false);
        this.b = perseus.a(this.b, 1, false);
        this.c = perseus.a(this.c, 2, false);
        this.d = perseus.a(this.d, 3, false);
    }
}
