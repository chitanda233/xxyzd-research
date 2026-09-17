package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.r1, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0674r1 extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ boolean f2926a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0674r1(boolean z) {
        super(0);
        this.f2926a = z;
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        AbstractC0684v.e = this.f2926a;
        return Unit.INSTANCE;
    }
}
