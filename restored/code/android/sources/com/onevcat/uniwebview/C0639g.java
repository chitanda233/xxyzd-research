package com.onevcat.uniwebview;

import kotlin.NoWhenBranchMatchedException;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: renamed from: com.onevcat.uniwebview.g, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0639g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final AbstractC0648j f2894a;
    public String b;
    public final boolean c;

    public C0639g(AbstractC0648j downloadType, String fileName, boolean z) {
        Intrinsics.checkNotNullParameter(downloadType, "downloadType");
        Intrinsics.checkNotNullParameter(fileName, "fileName");
        this.f2894a = downloadType;
        this.b = fileName;
        this.c = z;
    }

    public final String a() {
        AbstractC0648j abstractC0648j = this.f2894a;
        if (abstractC0648j instanceof C0645i) {
            return ((C0645i) abstractC0648j).f2900a;
        }
        if (abstractC0648j instanceof C0642h) {
            return ((C0642h) abstractC0648j).f2897a;
        }
        throw new NoWhenBranchMatchedException();
    }

    public final boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj instanceof C0639g)) {
            return false;
        }
        C0639g c0639g = (C0639g) obj;
        return Intrinsics.areEqual(this.f2894a, c0639g.f2894a) && Intrinsics.areEqual(this.b, c0639g.b) && this.c == c0639g.c;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r0v4, types: [int] */
    /* JADX WARN: Type inference failed for: r0v5 */
    /* JADX WARN: Type inference failed for: r0v6 */
    /* JADX WARN: Type inference failed for: r1v4, types: [int] */
    public final int hashCode() {
        int iHashCode = (this.b.hashCode() + (this.f2894a.hashCode() * 31)) * 31;
        boolean z = this.c;
        ?? r0 = z;
        if (z) {
            r0 = 1;
        }
        return iHashCode + r0;
    }

    public final String toString() {
        return "DownloadTask(downloadType=" + this.f2894a + ", fileName=" + this.b + ", shouldSendEvent=" + this.c + ')';
    }
}
