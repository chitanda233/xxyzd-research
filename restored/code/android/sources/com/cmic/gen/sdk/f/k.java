package com.cmic.gen.sdk.f;

import android.content.Context;
import android.telephony.TelephonyManager;
import android.text.TextUtils;

/* JADX INFO: compiled from: SIMUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class k {
    private static k b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2125a;
    private long c = 0;
    private String d = "";

    public static void a(Context context) {
        b = new k(context);
    }

    private k(Context context) {
        this.f2125a = context;
    }

    public static k a() {
        return b;
    }

    public String b() {
        try {
            int iA = com.cmic.gen.sdk.b.a.a().b().a();
            return iA >= 0 ? Integer.toString(iA) : "";
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }

    private String a(String str) {
        str.hashCode();
        switch (str) {
            case "45412":
                c.b("SIMUtils", "香港移动");
                return "4";
            case "46000":
            case "46002":
            case "46004":
            case "46007":
                c.a("SIMUtils", "中国移动");
                return "1";
            case "46001":
            case "46006":
            case "46009":
                c.a("SIMUtils", "中国联通");
                return "2";
            case "46003":
            case "46005":
            case "46011":
                c.a("SIMUtils", "中国电信");
                return "3";
            default:
                return "0";
        }
    }

    public String a(String str, boolean z) {
        if (TextUtils.isEmpty(str)) {
            str = a(z);
        }
        return a(str);
    }

    public String a(boolean z) {
        if (!z) {
            return "";
        }
        if (System.currentTimeMillis() - this.c > com.alipay.sdk.m.y.c.f378a) {
            this.c = System.currentTimeMillis();
            TelephonyManager telephonyManager = (TelephonyManager) this.f2125a.getSystemService("phone");
            if (telephonyManager == null) {
                return "";
            }
            this.d = telephonyManager.getSimOperator();
            c.b("SIMUtils", "getSimOperator SysOperator= " + this.d);
            return this.d;
        }
        c.b("SIMUtils", "使用缓存operator Operator= " + this.d);
        return this.d;
    }
}
