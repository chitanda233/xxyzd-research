package com.alipay.sdk.m.n0;

/* JADX INFO: loaded from: classes.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f321a;
    public String b;
    public String c;
    public int d;

    public a(String str) {
        this.c = str;
    }

    public void a(int i) {
        this.d = i;
    }

    public void a(long j) {
        this.f321a = j;
    }

    public void a(String str) {
        this.b = str;
    }

    public boolean a() {
        return this.f321a > System.currentTimeMillis();
    }

    public void b() {
        this.f321a = 0L;
    }
}
