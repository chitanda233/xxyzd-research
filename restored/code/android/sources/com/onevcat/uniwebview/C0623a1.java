package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.a1, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0623a1 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ boolean f2876a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0623a1(boolean z) {
        super(1);
        this.f2876a = z;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        it.p.getDownloader$uniwebview_release().e = this.f2876a;
        return Unit.INSTANCE;
    }
}
