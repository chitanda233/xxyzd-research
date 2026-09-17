package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.finally, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Cfinally extends Pyxis {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f3929a = 0;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        long j = this.f3929a;
        if (j != 0) {
            phoenix.a(0, j);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3929a = perseus.a(this.f3929a, 0, false);
    }
}
