package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public final class Wild {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Object f3908a;
    public long b;
    public long c;

    public final synchronized void a(Object obj, long j) {
        if (obj == null) {
            return;
        }
        this.f3908a = obj;
        this.b = System.currentTimeMillis();
        this.c = j;
    }

    public final synchronized Object a() {
        Object obj = this.f3908a;
        if (obj == null) {
            return null;
        }
        long j = this.c;
        if (j < 0) {
            return obj;
        }
        if (j != 0 && Math.abs(System.currentTimeMillis() - this.b) <= this.c) {
            return this.f3908a;
        }
        this.f3908a = null;
        return null;
    }
}
