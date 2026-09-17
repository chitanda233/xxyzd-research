package com.onevcat.uniwebview;

import java.util.Arrays;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: renamed from: com.onevcat.uniwebview.h, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0642h extends AbstractC0648j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f2897a;
    public final byte[] b;

    public C0642h(String url, byte[] data) {
        Intrinsics.checkNotNullParameter(url, "url");
        Intrinsics.checkNotNullParameter(data, "data");
        this.f2897a = url;
        this.b = data;
    }

    public final boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (!Intrinsics.areEqual(C0642h.class, obj != null ? obj.getClass() : null)) {
            return false;
        }
        if (obj == null) {
            throw new NullPointerException("null cannot be cast to non-null type com.onevcat.uniwebview.DownloadTaskType.DataUrl");
        }
        C0642h c0642h = (C0642h) obj;
        if (Intrinsics.areEqual(this.f2897a, c0642h.f2897a)) {
            return Arrays.equals(this.b, c0642h.b);
        }
        return false;
    }

    public final int hashCode() {
        return Arrays.hashCode(this.b) + (this.f2897a.hashCode() * 31);
    }

    public final String toString() {
        return "DataUrl(url=" + this.f2897a + ", data=" + Arrays.toString(this.b) + ')';
    }
}
