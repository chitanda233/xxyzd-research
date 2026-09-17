package com.czhj.sdk.common.mta;

/* JADX INFO: loaded from: classes2.dex */
public abstract class PointEntityCrash extends PointEntitySuper {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f2253a;
    private long b = 0;

    public String getCrashMessage() {
        return this.f2253a;
    }

    public long getCrashTime() {
        return this.b;
    }

    public void setCrashMessage(String str) {
        this.f2253a = str;
    }

    public void setCrashTime(long j) {
        this.b = j;
    }
}
