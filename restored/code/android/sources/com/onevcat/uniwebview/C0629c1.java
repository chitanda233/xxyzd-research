package com.onevcat.uniwebview;

import kotlin.NoWhenBranchMatchedException;
import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.c1, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0629c1 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ boolean f2884a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0629c1(boolean z) {
        super(1);
        this.f2884a = z;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        int i;
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        C0687w c0687w = it.p;
        boolean z = this.f2884a;
        if (z) {
            i = 0;
        } else {
            if (z) {
                throw new NoWhenBranchMatchedException();
            }
            i = 2;
        }
        c0687w.setOverScrollMode(i);
        return Unit.INSTANCE;
    }
}
