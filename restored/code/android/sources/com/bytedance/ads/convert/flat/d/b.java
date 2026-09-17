package com.bytedance.ads.convert.flat.d;

import com.bytedance.ad.common.interal.Nano;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes2.dex */
public final class b {
    public static final b b = new b();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static volatile c f1688a = new c();

    public final int[] a() {
        int[] iArrN = new int[24];
        try {
            iArrN = new Nano().n();
            c cVar = f1688a;
            cVar.getClass();
            Intrinsics.checkNotNullParameter(iArrN, "<set-?>");
            cVar.f = iArrN;
            return iArrN;
        } catch (Throwable unused) {
            return iArrN;
        }
    }
}
