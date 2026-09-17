package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Marc extends Pyxis {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f3866a = "";
    public int b = 0;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        String str = this.f3866a;
        if (str != null) {
            phoenix.a(str, 0);
        }
        int i = this.b;
        if (i != 0) {
            phoenix.a(i, 1);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3866a = perseus.b(0, false);
        this.b = perseus.a(this.b, 1, false);
    }
}
