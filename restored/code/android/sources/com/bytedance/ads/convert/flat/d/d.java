package com.bytedance.ads.convert.flat.d;

import com.bytedance.ads.convert.flat.a.f;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes2.dex */
public final class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final f f1692a;
    public final boolean b;

    public d() {
        this(null, false, 3);
    }

    public d(f uaidConfig, boolean z) {
        Intrinsics.checkNotNullParameter(uaidConfig, "uaidConfig");
        this.f1692a = uaidConfig;
        this.b = z;
    }

    public /* synthetic */ d(f fVar, boolean z, int i) {
        this((i & 1) != 0 ? new f(false, null, null, null, 15) : null, (i & 2) != 0 ? false : z);
    }

    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj instanceof d)) {
            return false;
        }
        d dVar = (d) obj;
        return Intrinsics.areEqual(this.f1692a, dVar.f1692a) && this.b == dVar.b;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v4, types: [int] */
    /* JADX WARN: Type inference failed for: r1v1, types: [int] */
    /* JADX WARN: Type inference failed for: r1v2 */
    /* JADX WARN: Type inference failed for: r1v3 */
    public int hashCode() {
        f fVar = this.f1692a;
        int iHashCode = (fVar != null ? fVar.hashCode() : 0) * 31;
        boolean z = this.b;
        ?? r1 = z;
        if (z) {
            r1 = 1;
        }
        return iHashCode + r1;
    }

    public String toString() {
        return "ZaidConfig(uaidConfig=" + this.f1692a + ", enableFeatureV2=" + this.b + ")";
    }
}
