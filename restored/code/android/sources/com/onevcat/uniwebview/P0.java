package com.onevcat.uniwebview;

import android.graphics.Color;
import kotlin.Unit;
import kotlin.jvm.functions.Function0;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: loaded from: classes3.dex */
public final class P0 extends Lambda implements Function0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2854a;
    public final /* synthetic */ float b;
    public final /* synthetic */ float c;
    public final /* synthetic */ float d;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public P0(String str, float f, float f2, float f3) {
        super(0);
        this.f2854a = str;
        this.b = f;
        this.c = f2;
        this.d = f3;
    }

    @Override // kotlin.jvm.functions.Function0
    public final Object invoke() {
        C0663o c0663o = C0663o.b;
        String name = this.f2854a;
        c0663o.getClass();
        Intrinsics.checkNotNullParameter(name, "name");
        b2 b2Var = (b2) c0663o.f2917a.get(name);
        if (b2Var != null) {
            float f = 255;
            b2Var.g = Integer.valueOf(Color.rgb((int) (this.b * f), (int) (this.c * f), (int) (this.d * f)));
        }
        return Unit.INSTANCE;
    }
}
