package com.onevcat.uniwebview;

import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: loaded from: classes3.dex */
public final class E0 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2826a;
    public final /* synthetic */ String b;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public E0(String str, String str2) {
        super(1);
        this.f2826a = str;
        this.b = str2;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        C0687w c0687w = it.p;
        String str = this.f2826a;
        String str2 = this.b;
        c0687w.getClass();
        C0654l c0654l = C0654l.b;
        c0654l.a(EnumC0651k.INFO, AbstractC0669q.a("UniWebView will load HTML string with base url: ", str2, c0654l, "message"));
        String message = "Input HTML content: \n" + str;
        Intrinsics.checkNotNullParameter(message, "message");
        c0654l.a(EnumC0651k.VERBOSE, message);
        J j = c0687w.e;
        j.f = 200;
        j.d = true;
        j.c = false;
        j.e = false;
        if (str == null) {
            str = "";
        }
        c0687w.loadDataWithBaseURL(str2, str, "text/html", "UTF-8", null);
        return Unit.INSTANCE;
    }
}
