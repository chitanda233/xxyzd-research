package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class b extends Pyxis {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3912a = 0;
    public float b = 0.0f;
    public float c = 0.0f;
    public float d = 0.0f;
    public float e = 0.0f;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(this.f3912a, 0);
        phoenix.a(this.b, 1);
        phoenix.a(this.c, 2);
        float f = this.d;
        if (f != 0.0f) {
            phoenix.a(f, 3);
        }
        float f2 = this.e;
        if (f2 != 0.0f) {
            phoenix.a(f2, 4);
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3912a = perseus.a(this.f3912a, 0, true);
        this.b = perseus.a(this.b, 1, true);
        this.c = perseus.a(this.c, 2, true);
        this.d = perseus.a(this.d, 3, false);
        this.e = perseus.a(this.e, 4, false);
    }
}
