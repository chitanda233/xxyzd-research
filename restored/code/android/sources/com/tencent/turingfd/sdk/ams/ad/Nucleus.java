package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Nucleus extends Pyxis {
    public static final Nectarine d = new Nectarine();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Nectarine f3869a = null;
    public byte[] b = null;
    public byte[] c = null;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        Nectarine nectarine = this.f3869a;
        if (nectarine != null) {
            phoenix.a((Pyxis) nectarine, 0);
        }
        byte[] bArr = this.b;
        if (bArr != null) {
            phoenix.a(1, bArr);
        }
        byte[] bArr2 = this.c;
        if (bArr2 != null) {
            phoenix.a(2, bArr2);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3869a = (Nectarine) perseus.a((Pyxis) d, 0, false);
        this.b = perseus.a(1, false);
        this.c = perseus.a(2, false);
    }
}
