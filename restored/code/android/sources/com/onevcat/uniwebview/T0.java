package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: loaded from: classes3.dex */
public final class T0 extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ boolean f2863a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public T0(boolean z) {
        super(0);
        this.f2863a = z;
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        AbstractC0684v.f2934a = this.f2863a;
        return Unit.INSTANCE;
    }
}
