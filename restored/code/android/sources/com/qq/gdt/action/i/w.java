package com.qq.gdt.action.i;

import android.os.SystemClock;

/* JADX INFO: loaded from: classes3.dex */
public class w {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile Long f3090a;

    public static void a(long j) {
        if (j <= 0 || a()) {
            return;
        }
        f3090a = Long.valueOf(j - SystemClock.elapsedRealtime());
    }

    public static boolean a() {
        return f3090a != null;
    }

    public static long b() {
        if (a()) {
            return SystemClock.elapsedRealtime() + f3090a.longValue();
        }
        return -1L;
    }
}
