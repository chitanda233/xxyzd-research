package com.cmic.gen.sdk.f;

import android.text.TextUtils;
import java.security.SecureRandom;
import java.util.UUID;

/* JADX INFO: compiled from: UmcUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class r {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final char[] f2133a = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

    static String a(byte[] bArr) {
        if (bArr == null) {
            return "";
        }
        char[] cArr = new char[bArr.length * 2];
        int i = 0;
        for (byte b : bArr) {
            int i2 = i + 1;
            char[] cArr2 = f2133a;
            cArr[i] = cArr2[(b >>> 4) & 15];
            i = i2 + 1;
            cArr[i2] = cArr2[b & 15];
        }
        return new String(cArr);
    }

    public static byte[] a() {
        byte[] bArr = new byte[16];
        new SecureRandom().nextBytes(bArr);
        return bArr;
    }

    public static String b() {
        return UUID.randomUUID().toString().replaceAll("-", "");
    }

    public static String c() {
        return d().replace("-", "");
    }

    private static String d() {
        return UUID.randomUUID().toString();
    }

    public static void a(com.cmic.gen.sdk.a aVar, String str) {
        if (TextUtils.isEmpty(aVar.b("interfaceType", ""))) {
            aVar.a("interfaceType", str);
        } else {
            aVar.a("interfaceType", aVar.b("interfaceType") + com.alipay.sdk.m.y.l.b + str);
        }
    }

    public static void b(com.cmic.gen.sdk.a aVar, String str) {
        if (TextUtils.isEmpty(aVar.b("interfaceCode", ""))) {
            aVar.a("interfaceCode", str);
        } else {
            aVar.a("interfaceCode", aVar.b("interfaceCode") + com.alipay.sdk.m.y.l.b + str);
        }
    }

    public static void c(com.cmic.gen.sdk.a aVar, String str) {
        if (TextUtils.isEmpty(aVar.b("interfaceElasped", ""))) {
            aVar.a("interfaceElasped", str);
        } else {
            aVar.a("interfaceElasped", aVar.b("interfaceElasped") + com.alipay.sdk.m.y.l.b + str);
        }
    }

    public static boolean a(com.cmic.gen.sdk.a.a aVar) {
        return l.a("logCloseTime", 0L) + ((long) (((aVar.m() * 60) * 60) * 1000)) >= System.currentTimeMillis();
    }
}
