package com.qq.e.comm.util;

import android.os.SystemClock;

/* JADX INFO: loaded from: classes3.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private long f3007a;
    private final StringBuilder b = new StringBuilder();
    private long c;

    public void a() {
        long jElapsedRealtime = SystemClock.elapsedRealtime() - this.f3007a;
        this.c += jElapsedRealtime;
        this.b.append(jElapsedRealtime).append(",");
    }

    public void b() {
        a();
        c();
    }

    public void c() {
        this.f3007a = SystemClock.elapsedRealtime();
    }

    public String toString() {
        int length = this.b.length();
        return length <= 0 ? "" : this.b.deleteCharAt(length - 1).append(":").append(this.c).toString();
    }
}
