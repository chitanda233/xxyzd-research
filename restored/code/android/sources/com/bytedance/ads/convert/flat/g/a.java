package com.bytedance.ads.convert.flat.g;

/* JADX INFO: loaded from: classes2.dex */
public final class a<A, B> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final A f1699a;
    public final B b;

    public a(A a2, B b) {
        this.f1699a = a2;
        this.b = b;
    }

    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null || a.class != obj.getClass()) {
            return false;
        }
        a aVar = (a) obj;
        A a2 = this.f1699a;
        if (a2 == null) {
            if (aVar.f1699a != null) {
                return false;
            }
        } else if (!a2.equals(aVar.f1699a)) {
            return false;
        }
        B b = this.b;
        B b2 = aVar.b;
        if (b == null) {
            if (b2 != null) {
                return false;
            }
        } else if (!b.equals(b2)) {
            return false;
        }
        return true;
    }

    public int hashCode() {
        A a2 = this.f1699a;
        int iHashCode = ((a2 == null ? 0 : a2.hashCode()) + 31) * 31;
        B b = this.b;
        return iHashCode + (b != null ? b.hashCode() : 0);
    }
}
