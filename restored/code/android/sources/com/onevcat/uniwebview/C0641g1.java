package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.g1, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0641g1 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ boolean f2896a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0641g1(boolean z) {
        super(1);
        this.f2896a = z;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        it.p.setSendDownloadEventForContextMenu(this.f2896a);
        return Unit.INSTANCE;
    }
}
