package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;
import kotlin.text.StringsKt;

/* JADX INFO: renamed from: com.onevcat.uniwebview.u1, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0683u1 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2933a;
    public final /* synthetic */ String b;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public C0683u1(String str, String str2) {
        super(1);
        this.f2933a = str;
        this.b = str2;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        C0687w c0687w = it.p;
        String key = this.f2933a;
        String str = this.b;
        c0687w.getClass();
        Intrinsics.checkNotNullParameter(key, "key");
        if (StringsKt.isBlank(key)) {
            C0654l c0654l = C0654l.b;
            c0654l.getClass();
            Intrinsics.checkNotNullParameter("Trying to set null or empty key for header field. Please check you have set correct key.", "message");
            c0654l.a(EnumC0651k.CRITICAL, "Trying to set null or empty key for header field. Please check you have set correct key.");
        } else if (str == null) {
            c0687w.e.g.remove(key);
        } else {
            c0687w.e.g.put(key, str);
        }
        return Unit.INSTANCE;
    }
}
