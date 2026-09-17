package com.onevcat.uniwebview;

import android.graphics.Rect;
import java.io.ByteArrayOutputStream;
import kotlin.Unit;
import kotlin.jvm.functions.Function1;
import kotlin.jvm.internal.Intrinsics;
import kotlin.jvm.internal.Lambda;

/* JADX INFO: loaded from: classes3.dex */
public final class R1 extends Lambda implements Function1 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ String f2860a;

    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public R1(String str) {
        super(1);
        this.f2860a = str;
    }

    @Override // kotlin.jvm.functions.Function1
    public final Object invoke(Object obj) {
        N it = (N) obj;
        Intrinsics.checkNotNullParameter(it, "it");
        String str = this.f2860a;
        ByteArrayOutputStream byteArrayOutputStream = it.m;
        if (byteArrayOutputStream != null) {
            try {
                byteArrayOutputStream.close();
            } catch (Exception e) {
                C0654l c0654l = C0654l.b;
                C0654l c0654l2 = C0654l.b;
                String message = "Snapshot buffer close exception: " + e;
                c0654l2.getClass();
                Intrinsics.checkNotNullParameter(message, "message");
                c0654l2.a(EnumC0651k.CRITICAL, message);
            }
        }
        it.m = new ByteArrayOutputStream();
        if (it.e.getHeight() > 0 && it.e.getWidth() > 0) {
            it.n = it.a((Rect) null);
            if (str != null) {
                it.c.a(it.b, d2.SnapshotRenderingStarted, str);
            }
        }
        return Unit.INSTANCE;
    }
}
