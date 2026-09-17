package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.f1, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0638f1 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ int f2893a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0638f1(int i) {
        super(1);
        this.f2893a = i;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        it.p.setDefaultFontSize(this.f2893a);
        return Unit.INSTANCE;
    }
}
