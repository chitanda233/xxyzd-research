package com.qq.gdt.action.a;

/* JADX INFO: loaded from: classes3.dex */
public final class d<A, B> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final A f3016a;
    private final B b;

    private d(A a2, B b) {
        this.f3016a = a2;
        this.b = b;
    }

    public static <A, B> d<A, B> a(A a2, B b) {
        return new d<>(a2, b);
    }

    public A a() {
        return this.f3016a;
    }

    public B b() {
        return this.b;
    }

    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null || getClass() != obj.getClass()) {
            return false;
        }
        d dVar = (d) obj;
        A a2 = this.f3016a;
        if (a2 == null) {
            if (dVar.f3016a != null) {
                return false;
            }
        } else if (!a2.equals(dVar.f3016a)) {
            return false;
        }
        B b = this.b;
        B b2 = dVar.b;
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
        A a2 = this.f3016a;
        int iHashCode = ((a2 == null ? 0 : a2.hashCode()) + 31) * 31;
        B b = this.b;
        return iHashCode + (b != null ? b.hashCode() : 0);
    }

    public String toString() {
        return "first = " + this.f3016a + " , second = " + this.b;
    }
}
