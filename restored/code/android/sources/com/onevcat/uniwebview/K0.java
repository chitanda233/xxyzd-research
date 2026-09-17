package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: loaded from: classes3.dex */
public final class K0 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2842a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public K0(String str) {
        super(1);
        this.f2842a = str;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        C0687w c0687w = it.p;
        String domain = this.f2842a;
        c0687w.getClass();
        Intrinsics.checkNotNullParameter(domain, "domain");
        c0687w.e.i.remove(domain);
        return Unit.INSTANCE;
    }
}
