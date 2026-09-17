package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.h0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0643h0 extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2898a;
    public final /* synthetic */ boolean b;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0643h0(String str, boolean z) {
        super(0);
        this.f2898a = str;
        this.b = z;
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        C0630d c0630d = C0630d.b;
        String name = this.f2898a;
        c0630d.getClass();
        Intrinsics.checkNotNullParameter(name, "name");
        A a2 = (A) c0630d.f2885a.get(name);
        if (a2 != null) {
            a2.i = this.b;
        }
        return Unit.INSTANCE;
    }
}
