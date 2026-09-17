package com.alipay.sdk.m.l;

import com.alipay.sdk.m.y.l;

/* JADX INFO: loaded from: classes.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static volatile boolean f307a = false;
    public static volatile String b;

    public static void a(String str) {
        b = str;
    }

    public static String b() {
        c cVarA = c.a(c.DOUBLE_REQUEST.c());
        return a(cVarA.c(), cVarA.b(), "");
    }

    public static boolean c() {
        return f307a;
    }

    public static String d() {
        return b;
    }

    public static String e() {
        c cVarA = c.a(c.PARAMS_ERROR.c());
        return a(cVarA.c(), cVarA.b(), "");
    }

    public static void a(boolean z) {
        f307a = z;
    }

    public static String a() {
        c cVarA = c.a(c.CANCELED.c());
        return a(cVarA.c(), cVarA.b(), "");
    }

    public static String a(int i, String str, String str2) {
        StringBuilder sb = new StringBuilder("resultStatus={");
        sb.append(i).append("};memo={").append(str).append("};result={").append(str2).append(l.d);
        return sb.toString();
    }
}
