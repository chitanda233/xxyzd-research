package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.s1, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0677s1 extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ boolean f2928a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0677s1(boolean z) {
        super(0);
        this.f2928a = z;
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        AbstractC0684v.f = this.f2928a;
        return Unit.INSTANCE;
    }
}
