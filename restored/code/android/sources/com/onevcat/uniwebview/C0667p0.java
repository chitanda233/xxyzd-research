package com.onevcat.uniwebview;

import android.view.ViewGroup;
import android.view.ViewParent;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: renamed from: com.onevcat.uniwebview.p0, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0667p0 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final C0667p0 f2920a = new C0667p0();

    public C0667p0() {
        super(1);
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) throws IOException {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        ViewParent parent = it.e.getParent();
        ViewGroup viewGroup = parent instanceof ViewGroup ? (ViewGroup) parent : null;
        if (viewGroup != null) {
            viewGroup.removeView(it.e);
        }
        it.b();
        ByteArrayOutputStream byteArrayOutputStream = it.m;
        if (byteArrayOutputStream != null) {
            byteArrayOutputStream.close();
        }
        it.m = null;
        it.n = null;
        it.p.destroy();
        C0633e c0633e = C0633e.b;
        String name = it.b;
        c0633e.getClass();
        Intrinsics.checkNotNullParameter(name, "name");
        C0654l c0654l = C0654l.b;
        c0654l.a(EnumC0651k.DEBUG, AbstractC0669q.a("Removing web view container from manager: ", name, c0654l, "message"));
        c0633e.f2889a.remove(name);
        P.b();
        return Unit.INSTANCE;
    }
}
