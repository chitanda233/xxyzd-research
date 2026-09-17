package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: loaded from: classes3.dex */
public final class Y0 extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ boolean f2872a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public Y0(boolean z) {
        super(0);
        this.f2872a = z;
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        AbstractC0684v.d = this.f2872a;
        return Unit.INSTANCE;
    }
}
