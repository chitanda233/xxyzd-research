package com.alipay.sdk.m.r;

/* JADX INFO: loaded from: classes.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f344a;
    public final String b;
    public final String c;

    /* JADX INFO: renamed from: com.alipay.sdk.m.r.a$a, reason: collision with other inner class name */
    public static class C0048a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static String f345a = "0";
        public static String b = "1";
        public static String c = "2";
    }

    public a(String str, String str2, String str3) {
        this.f344a = str;
        this.b = str2;
        this.c = str3;
    }

    public String a() {
        return this.f344a;
    }

    public String b() {
        return this.b;
    }

    public String c() {
        return this.c;
    }

    public String toString() {
        return "updateStrategy: " + this.c + " sha256:" + this.f344a + " sourceUrl:" + this.b;
    }
}
