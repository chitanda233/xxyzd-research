package com.bytedance.ads.convert.flat.a;

/* JADX INFO: loaded from: classes2.dex */
public final class e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public boolean f1678a;
    public long b;

    public e(boolean z, long j) {
        this.f1678a = z;
        this.b = j;
    }

    public final long a() {
        return this.b;
    }

    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj instanceof e)) {
            return false;
        }
        e eVar = (e) obj;
        return this.f1678a == eVar.f1678a && this.b == eVar.b;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v1, types: [int] */
    /* JADX WARN: Type inference failed for: r0v4 */
    /* JADX WARN: Type inference failed for: r0v5 */
    public int hashCode() {
        boolean z = this.f1678a;
        ?? r0 = z;
        if (z) {
            r0 = 1;
        }
        long j = this.b;
        return (r0 * 31) + ((int) (j ^ (j >>> 32)));
    }

    public String toString() {
        return "Config(enable=" + this.f1678a + ", timeout=" + this.b + ")";
    }
}
