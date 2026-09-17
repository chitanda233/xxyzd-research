package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.c0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0628c0 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2883a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0628c0(String str) {
        super(1);
        this.f2883a = str;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        C0687w c0687w = it.p;
        String domain = this.f2883a;
        c0687w.getClass();
        Intrinsics.checkNotNullParameter(domain, "domain");
        c0687w.d.h.add(domain);
        return Unit.INSTANCE;
    }
}
