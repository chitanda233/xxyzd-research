package com.onevcat.uniwebview;

import android.util.Log;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: renamed from: com.onevcat.uniwebview.l, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes3.dex */
public final class C0654l {
    public static final C0654l b = new C0654l();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f2908a;

    public C0654l() {
        Intrinsics.checkNotNullParameter("UniWebView", "tag");
        this.f2908a = 80;
    }

    public final void a(EnumC0651k enumC0651k, String str) {
        if (enumC0651k.f2905a < this.f2908a) {
            return;
        }
        if (enumC0651k == EnumC0651k.CRITICAL) {
            Log.e("UniWebView", "<UniWebView-Android> " + str);
        } else if (enumC0651k == EnumC0651k.WARNING) {
            Log.w("UniWebView", "<UniWebView-Android> " + str);
        } else {
            Log.d("UniWebView", "<UniWebView-Android> " + str);
        }
    }

    public static void a(EnumC0651k level, String mark, String message) {
        Intrinsics.checkNotNullParameter(level, "level");
        Intrinsics.checkNotNullParameter(mark, "mark");
        Intrinsics.checkNotNullParameter(message, "message");
        int iOrdinal = level.ordinal();
        if (iOrdinal == 3) {
            Log.w("UniWebView", mark + " <UniWebView-Web> " + message);
        } else if (iOrdinal != 4) {
            Log.d("UniWebView", mark + " <UniWebView-Web> " + message);
        } else {
            Log.e("UniWebView", mark + " <UniWebView-Web> " + message);
        }
    }
}
