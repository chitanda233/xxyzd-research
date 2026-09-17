package com.alipay.sdk.m.y;

import android.os.SystemClock;

/* JADX INFO: loaded from: classes.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final long f378a = 3000;
    public static long b = -1;

    public static synchronized boolean a() {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        if (jElapsedRealtime - b < f378a) {
            return true;
        }
        b = jElapsedRealtime;
        return false;
    }
}
