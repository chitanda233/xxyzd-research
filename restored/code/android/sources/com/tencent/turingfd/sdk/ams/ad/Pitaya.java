package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Pitaya extends Pyxis {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f3879a = 0;
    public String b = "";

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        long j = this.f3879a;
        if (j != 0) {
            phoenix.a(0, j);
        }
        String str = this.b;
        if (str != null) {
            phoenix.a(str, 1);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3879a = perseus.a(this.f3879a, 0, false);
        this.b = perseus.b(1, false);
    }
}
