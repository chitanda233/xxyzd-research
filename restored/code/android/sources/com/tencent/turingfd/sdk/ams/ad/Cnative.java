package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.native, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Cnative extends Pyxis {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3949a = 0;
    public byte[] b = null;
    public String c = "";
    public int d = 0;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        int i = this.f3949a;
        if (i != 0) {
            phoenix.a(i, 0);
        }
        byte[] bArr = this.b;
        if (bArr != null) {
            phoenix.a(1, bArr);
        }
        String str = this.c;
        if (str != null) {
            phoenix.a(str, 2);
        }
        int i2 = this.d;
        if (i2 != 0) {
            phoenix.a(i2, 3);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3949a = perseus.a(this.f3949a, 0, false);
        this.b = perseus.a(1, false);
        this.c = perseus.b(2, false);
        this.d = perseus.a(this.d, 3, false);
    }
}
