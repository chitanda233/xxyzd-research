package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.l1, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0656l1 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2910a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0656l1(String str) {
        super(1);
        this.f2910a = str;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        it.q.setGoBackButtonText(this.f2910a);
        return Unit.INSTANCE;
    }
}
