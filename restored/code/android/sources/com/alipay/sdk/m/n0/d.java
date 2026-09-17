package com.alipay.sdk.m.n0;

/* JADX INFO: loaded from: classes.dex */
public class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public String f324a;
    public int b;
    public long c = System.currentTimeMillis() + 86400000;

    public d(String str, int i) {
        this.f324a = str;
        this.b = i;
    }

    public String toString() {
        return "ValueData{value='" + this.f324a + "', code=" + this.b + ", expired=" + this.c + '}';
    }
}
