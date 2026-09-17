package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Longan extends Pyxis implements Cloneable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f3861a;
    public byte[] b;
    public int c;

    public Longan() {
        this.f3861a = "";
        this.b = null;
        this.c = 0;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(this.f3861a, 0);
        phoenix.a(1, this.b);
        phoenix.a(this.c, 2);
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3861a = perseus.b(0, true);
        this.b = perseus.a(1, true);
        this.c = perseus.a(this.c, 2, true);
    }

    public Longan(String str, byte[] bArr, int i) {
        this.f3861a = str;
        this.b = bArr;
        this.c = i;
    }
}
