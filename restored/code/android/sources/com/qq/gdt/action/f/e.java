package com.qq.gdt.action.f;

import android.content.Context;

/* JADX INFO: loaded from: classes3.dex */
public class e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static boolean f3072a = false;

    public static void a(Context context) {
        if (!com.qq.gdt.action.d.a().x() || f3072a) {
            return;
        }
        b.a().b();
    }

    public static void b(Context context) {
        f3072a = false;
        if (com.qq.gdt.action.d.a().x()) {
            b.a().b();
        }
    }

    public static void c(Context context) {
        f3072a = true;
    }
}
