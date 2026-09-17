package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class j0 extends Pyxis {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3941a = 0;
    public String b = "";

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        int i = this.f3941a;
        if (i != 0) {
            phoenix.a(i, 0);
        }
        String str = this.b;
        if (str != null) {
            phoenix.a(str, 1);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3941a = perseus.a(this.f3941a, 0, false);
        this.b = perseus.b(1, false);
    }
}
