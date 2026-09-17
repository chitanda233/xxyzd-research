package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Loquat extends Pyxis implements Cloneable {
    public static final Auriga d = new Auriga();
    public static final /* synthetic */ boolean e = true;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f3862a = 0;
    public Auriga b = null;
    public long c = 0;

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Phoenix phoenix) {
        phoenix.a(this.f3862a, 0);
        Auriga auriga = this.b;
        if (auriga != null) {
            phoenix.a((Pyxis) auriga, 1);
        }
        phoenix.a(2, this.c);
    }

    public final Object clone() {
        try {
            return super.clone();
        } catch (CloneNotSupportedException unused) {
            if (e) {
                return null;
            }
            throw new AssertionError();
        }
    }

    public final boolean equals(Object obj) {
        if (obj == null) {
            return false;
        }
        Loquat loquat = (Loquat) obj;
        int i = this.f3862a;
        int i2 = loquat.f3862a;
        int i3 = Scorpius.f3887a;
        return i == i2 && this.b.equals(loquat.b) && this.c == loquat.c;
    }

    public final int hashCode() {
        try {
            throw new Exception("");
        } catch (Exception e2) {
            e2.printStackTrace();
            return 0;
        }
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Pyxis
    public final void a(Perseus perseus) {
        this.f3862a = perseus.a(this.f3862a, 0, true);
        this.b = (Auriga) perseus.a((Pyxis) d, 1, false);
        this.c = perseus.a(this.c, 2, true);
    }
}
