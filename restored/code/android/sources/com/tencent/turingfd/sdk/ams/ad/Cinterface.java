package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.interface, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Cinterface extends Pyxis {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f3939a = "";
    public String b = "";

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(this.f3939a, 0);
        phoenix.a(this.b, 1);
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3939a = perseus.b(0, true);
        this.b = perseus.b(1, true);
    }
}
