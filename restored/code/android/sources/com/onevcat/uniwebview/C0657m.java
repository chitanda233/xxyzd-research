package com.onevcat.uniwebview;

import java.util.Arrays;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: renamed from: com.onevcat.uniwebview.m, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0657m {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f2911a;
    public final byte[] b;

    public C0657m(String str, byte[] data) {
        Intrinsics.checkNotNullParameter(data, "data");
        this.f2911a = str;
        this.b = data;
    }

    public final boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj instanceof C0657m)) {
            return false;
        }
        C0657m c0657m = (C0657m) obj;
        return Intrinsics.areEqual(this.f2911a, c0657m.f2911a) && Intrinsics.areEqual(this.b, c0657m.b);
    }

    public final int hashCode() {
        String str = this.f2911a;
        return Arrays.hashCode(this.b) + ((str == null ? 0 : str.hashCode()) * 31);
    }

    public final String toString() {
        return "ParsedDataUrl(mediaType=" + this.f2911a + ", data=" + Arrays.toString(this.b) + ')';
    }
}
