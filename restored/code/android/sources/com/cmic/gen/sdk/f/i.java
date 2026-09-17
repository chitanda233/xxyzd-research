package com.cmic.gen.sdk.f;

import android.content.Context;
import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.kuaishou.weapon.p0.bg;

/* JADX INFO: compiled from: PhoneScripUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class i {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static String f2122a = null;
    private static String b = null;
    private static String c = null;
    private static String d = null;
    private static long e = 0;
    private static int f = -1;

    public static void a(boolean z, boolean z2) {
        l.a aVarA = l.a();
        aVarA.a("phonescripstarttime");
        aVarA.a("phonescripcache");
        aVarA.a("securityphone");
        aVarA.a("securityphonecache");
        aVarA.a("pre_sim_key");
        aVarA.a("phonescripversion");
        if (z2) {
            aVarA.a();
        } else {
            aVarA.b();
        }
        if (z) {
            f2122a = null;
            d = null;
            e = 0L;
            f = -1;
        }
    }

    public static void a(final Context context, final String str, final String str2, long j, final String str3, String str4) {
        if (TextUtils.isEmpty(str) || TextUtils.isEmpty(str3) || j <= 0) {
            return;
        }
        c.b("PhoneScripUtils", "save phone scrip simKey = " + str3);
        f2122a = str;
        long j2 = j * 1000;
        e = System.currentTimeMillis() + j2;
        c.b("sLifeTime", e + "");
        d = str3;
        f = 1;
        if (!"operator".equals(str4)) {
            o.a(new o.a() { // from class: com.cmic.gen.sdk.f.i.1
                @Override // com.cmic.gen.sdk.f.o.a
                protected void a() {
                    c.b("PhoneScripUtils", "start save scrip to sp in sub thread");
                    i.b(context, str, str2, i.e, str3);
                }
            });
        } else if (j2 > bg.s) {
            e = System.currentTimeMillis() + bg.s;
        } else {
            e = System.currentTimeMillis() + j2;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void b(Context context, String str, String str2, long j, String str3) {
        String strA = b.a(context, str);
        if (TextUtils.isEmpty(strA)) {
            return;
        }
        l.a aVarA = l.a();
        aVarA.a("phonescripcache", strA);
        aVarA.a("phonescripstarttime", j);
        aVarA.a("phonescripversion", 1);
        aVarA.a("pre_sim_key", str3);
        aVarA.b();
    }

    public static String a(Context context) {
        if (TextUtils.isEmpty(f2122a)) {
            String strB = l.b("phonescripcache", "");
            if (TextUtils.isEmpty(strB)) {
                c.a("PhoneScripUtils", "null");
                return null;
            }
            e = l.a("phonescripstarttime", 0L);
            d = l.b("pre_sim_key", "");
            f = l.a("phonescripversion", -1);
            String strC = b.c(context, strB);
            f2122a = strC;
            return strC;
        }
        return f2122a;
    }

    public static void a(Context context, String str, String str2) {
        b = str;
        c = str2;
        c.a("PhoneScripUtils", "number=" + str);
        String strB = b.b(context, str);
        c.a("PhoneScripUtils", "encryptStr=" + strB);
        if (TextUtils.isEmpty(strB)) {
            return;
        }
        l.a aVarA = l.a();
        aVarA.a("securityphonecache", strB);
        aVarA.a("operatortypecache", c);
        aVarA.b();
    }

    public static String b(Context context) {
        if (!TextUtils.isEmpty(b)) {
            return b;
        }
        String strB = l.b("securityphone", "");
        if (!TextUtils.isEmpty(strB)) {
            return strB;
        }
        String strB2 = l.b("securityphonecache", "");
        c.a("PhoneScripUtils", "encryptData=" + strB2);
        if (TextUtils.isEmpty(strB2)) {
            c.a("PhoneScripUtils", "null");
            return null;
        }
        return b.c(context, strB2);
    }

    private static boolean c() {
        if (TextUtils.isEmpty(f2122a)) {
            return !TextUtils.isEmpty(l.b("phonescripcache", "")) && a(l.a("phonescripstarttime", 0L));
        }
        c.b("PhoneScripUtils", d + " " + e);
        return a(e);
    }

    private static boolean a(long j) {
        long jCurrentTimeMillis = System.currentTimeMillis();
        c.b("PhoneScripUtils", j + "");
        c.b("PhoneScripUtils", jCurrentTimeMillis + "");
        return j - jCurrentTimeMillis > ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT;
    }

    public static long a() {
        long jA;
        long j;
        long jCurrentTimeMillis = System.currentTimeMillis();
        if (!TextUtils.isEmpty(f2122a)) {
            c.b("PhoneScripUtils", d + " " + e);
            jA = e;
        } else {
            String strB = l.b("phonescripcache", "");
            jA = l.a("phonescripstarttime", 0L);
            if (TextUtils.isEmpty(strB)) {
                j = 0;
            }
            return Math.max(j / 1000, 0L);
        }
        j = (jA - jCurrentTimeMillis) - ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT;
        return Math.max(j / 1000, 0L);
    }

    private static int a(String str) {
        String strB;
        if (!TextUtils.isEmpty(d)) {
            strB = d;
        } else {
            strB = l.b("pre_sim_key", "");
            d = strB;
        }
        if (TextUtils.isEmpty(strB)) {
            return 0;
        }
        return strB.equals(str) ? 1 : 2;
    }

    public static boolean a(com.cmic.gen.sdk.a aVar) {
        int iA = a(aVar.b("scripKey"));
        aVar.a("imsiState", iA + "");
        c.b("PhoneScripUtils", "simState = " + iA);
        if (iA == 0) {
            return false;
        }
        if (f == -1) {
            f = l.a("phonescripversion", -1);
        }
        if (f != 1) {
            a(true, false);
            b.a();
            c.b("PhoneScripUtils", "phoneScriptVersion change");
            return false;
        }
        if (iA == 2) {
            a(true, false);
            return false;
        }
        return c();
    }
}
