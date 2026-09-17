package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.w0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0690w0 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final C0690w0 f2938a = new C0690w0();

    public C0690w0() {
        super(1);
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        C0687w c0687w = it.p;
        C0687w c0687w2 = c0687w.d.i;
        if (c0687w2 != null) {
            if (c0687w2.canGoForward()) {
                c0687w2.goForward();
            }
        } else if (c0687w.canGoForward()) {
            c0687w.goForward();
        }
        return Unit.INSTANCE;
    }
}
