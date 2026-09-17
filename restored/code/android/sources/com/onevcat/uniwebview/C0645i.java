package com.onevcat.uniwebview;

import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: renamed from: com.onevcat.uniwebview.i, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0645i extends AbstractC0648j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f2900a;

    public C0645i(String url) {
        Intrinsics.checkNotNullParameter(url, "url");
        this.f2900a = url;
    }

    public final boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        return (obj instanceof C0645i) && Intrinsics.areEqual(this.f2900a, ((C0645i) obj).f2900a);
    }

    public final int hashCode() {
        return this.f2900a.hashCode();
    }

    public final String toString() {
        return "Normal(url=" + this.f2900a + ')';
    }
}
