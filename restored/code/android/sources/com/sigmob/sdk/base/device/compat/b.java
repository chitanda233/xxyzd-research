package com.sigmob.sdk.base.device.compat;

import android.content.Context;
import android.os.Build;
import android.provider.Settings;
import android.text.TextUtils;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private static final String[] A;
    private static final String[] B;
    private static final String[] C;
    private static final String[] D;
    private static final String E = "ro.vendor.asus.product.mkt_name";
    private static final String F = "ro.vendor.asus.product.mkt_name";
    private static final String[] G;
    private static final String[] H;
    private static final String I = "ro.product.letv_name";
    private static final String J = "ro.product.letv_name";
    private static final String K = "ro.qiku.product.devicename";
    private static final String L = "ro.qiku.product.devicename";
    private static final Map<String, String> M;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static String f3211a = "";
    private static boolean b = false;
    private static final String c = "net.hostname";
    private static final String d = "ro.product.model";
    private static final String[] e;
    private static final String[] f;
    private static final String[] g;
    private static final String[] h;
    private static final String[] i;
    private static final String[] j;
    private static final String[] k;
    private static final String[] l;
    private static final String[] m;
    private static final String[] n;
    private static final String[] o;
    private static final String p = "ro.config.marketing_name";
    private static final String q = "ro.config.marketing_name";
    private static final String r = "ro.config.marketing_name";
    private static final String s = "ro.config.marketing_name";
    private static final String t = "ro.config.marketing_name";
    private static final String u = "ro.vendor.product.ztename";
    private static final String v = "ro.vendor.product.ztename";
    private static final String w = "ro.vendor.product.ztename";
    private static final String x = "ro.product.model";
    private static final String[] y;
    private static final String[] z;

    static {
        String[] strArr = {"ro.product.marketname", "ro.product.odm.marketname", "ro.product.vendor.marketname"};
        e = strArr;
        f = strArr;
        g = strArr;
        String[] strArr2 = {"ro.vendor.oplus.market.enname", "ro.vendor.oplus.market.name", "ro.oppo.market.name"};
        h = strArr2;
        i = strArr2;
        j = strArr2;
        String[] strArr3 = {"ro.display.series", "ro.common.soft"};
        k = strArr3;
        l = new String[]{strArr2[0], strArr2[1], strArr2[2], strArr3[0], strArr3[1]};
        String[] strArr4 = {"ro.vivo.internet.name", "ro.vivo.market.name"};
        m = strArr4;
        n = strArr4;
        o = strArr4;
        String[] strArr5 = {"persist.sys.devicename", "persist.sys.exif.model", "ro.vendor.product.ztename"};
        y = strArr5;
        z = new String[]{strArr5[0], strArr5[1]};
        A = strArr5;
        String[] strArr6 = {"ro.zuk.product.market", "ro.product.display", "ro.product.en.display"};
        B = strArr6;
        C = strArr6;
        D = strArr6;
        String[] strArr7 = {"net.devicename", "ro.product.codename"};
        G = strArr7;
        H = strArr7;
        HashMap map = new HashMap();
        M = map;
        String str = a.a() ? "Redmi" : "Xiaomi";
        map.put("Mi", str);
        map.put("MI", str);
        map.put("mi", str);
        map.put("小米", str);
        map.put("华为", "HUAWEI");
        map.put("荣耀平板", "HONOR Pad");
        map.put("荣耀", "HONOR");
        map.put("一加", "OnePlus");
        map.put("真我", "realme");
        map.put("meizu", "MEIZU");
        map.put("魅族", "MEIZU");
        map.put("拯救者电竞手机", "Lenovo Legion Phone");
        map.put("拯救者平板", "Lenovo Legion Tab");
        map.put("联想", "Lenovo");
        map.put("努比亚红魔", "nubia RedMagic");
        map.put("红魔", "nubia RedMagic");
        map.put("努比亚", "nubia");
        map.put("中兴", "ZTE");
        map.put("华硕", "ASUS");
        map.put("黑鲨", "BlackShark");
        map.put("锤子", "Smartisan");
        map.put("乐视", "LeEco");
    }

    private b() {
    }

    public static String a(Context context) throws Throwable {
        if (!b) {
            b = true;
            b(context);
        }
        return f3211a;
    }

    private static void a(String marketName) {
        if (marketName == null) {
            marketName = "";
        }
        String strTrim = marketName.trim();
        for (String str : M.keySet()) {
            if (strTrim.startsWith(str)) {
                strTrim = M.get(str) + " " + strTrim.replaceFirst(str, "").trim();
                break;
            }
        }
        if (a.h() && strTrim.startsWith("nova")) {
            strTrim = "HUAWEI " + strTrim;
        }
        if (a.f() && strTrim.startsWith("iQOO")) {
            strTrim = "vivo " + strTrim;
        }
        if (a.j() && strTrim.startsWith("Galaxy")) {
            strTrim = "Samsung " + strTrim;
        }
        if (a.i() && strTrim.endsWith("_CN")) {
            strTrim = strTrim.replace("_CN", " ");
        }
        if (a.n() && strTrim.startsWith("Legion")) {
            strTrim = "Lenovo " + strTrim;
        }
        if (a.q() && strTrim.startsWith("坚果")) {
            strTrim = "Smartisan " + strTrim;
        }
        if (a.r() && strTrim.startsWith("乐")) {
            strTrim = "LeEco Le " + strTrim.replaceFirst("乐", "").trim();
        }
        if (a.s() && !strTrim.startsWith("360")) {
            strTrim = "360 " + strTrim;
        }
        if (strTrim.contains("_")) {
            strTrim = strTrim.replace("_", " ");
        }
        if (strTrim.contains("-")) {
            strTrim = strTrim.replace("-", " ");
        }
        if (strTrim.contains("Pro+")) {
            strTrim = strTrim.replace("Pro+", "Pro Plus");
        }
        f3211a = strTrim;
    }

    private static void a(String... systemPropertyKeys) throws Throwable {
        for (String str : systemPropertyKeys) {
            String strA = d.a(str);
            if (b(strA)) {
                a(strA);
                return;
            }
        }
    }

    private static void b(Context context) throws Throwable {
        if (c.a()) {
            a(f);
        } else if (c.e()) {
            a(g);
        }
        if (TextUtils.isEmpty(f3211a)) {
            if (c.i()) {
                a(i);
            } else if (c.j()) {
                a(j);
            } else if (c.t()) {
                a(k);
            } else if (c.s()) {
                a(l);
            }
        }
        if (TextUtils.isEmpty(f3211a)) {
            if (c.k()) {
                a(n);
            } else if (c.l()) {
                a(o);
            }
        }
        if (TextUtils.isEmpty(f3211a) && (c.n() || c.p() || c.m() || c.q())) {
            a("ro.config.marketing_name");
        }
        if (TextUtils.isEmpty(f3211a)) {
            if (c.w()) {
                a("ro.vendor.product.ztename");
            } else if (c.v()) {
                a(A);
            } else if (c.x()) {
                a("ro.vendor.product.ztename");
            } else if (c.D()) {
                a(z);
            } else if (c.y()) {
                a("ro.product.model");
            }
        }
        if (TextUtils.isEmpty(f3211a)) {
            if (c.B()) {
                a(C);
            } else if (c.C()) {
                a(D);
            }
        }
        if (TextUtils.isEmpty(f3211a) && c.F()) {
            a("ro.vendor.asus.product.mkt_name");
        }
        if (TextUtils.isEmpty(f3211a) && c.z()) {
            a(H);
        }
        if (TextUtils.isEmpty(f3211a) && c.A()) {
            a("ro.product.letv_name");
        }
        if (TextUtils.isEmpty(f3211a) && c.G()) {
            a("ro.qiku.product.devicename");
        }
        if (TextUtils.isEmpty(f3211a) && c.r()) {
            try {
                String string = Settings.Global.getString(context.getContentResolver(), "default_device_name");
                if (b(string)) {
                    a(string);
                }
            } catch (Exception unused) {
            }
        }
        if (a.b() || a.a()) {
            a(e);
        }
        if (TextUtils.isEmpty(f3211a) && (a.h() || a.g())) {
            a("ro.config.marketing_name");
        }
        if (TextUtils.isEmpty(f3211a) && (a.d() || a.c() || a.e())) {
            a(h);
        }
        if (TextUtils.isEmpty(f3211a) && a.f()) {
            a(m);
        }
        if (TextUtils.isEmpty(f3211a) && a.l()) {
            a("ro.vendor.product.ztename");
        }
        if (TextUtils.isEmpty(f3211a) && a.k()) {
            a(y);
        }
        if (TextUtils.isEmpty(f3211a) && a.n()) {
            a(B);
        }
        if (TextUtils.isEmpty(f3211a) && a.o()) {
            a("ro.vendor.asus.product.mkt_name");
        }
        if (TextUtils.isEmpty(f3211a) && a.q()) {
            a(G);
        }
        if (TextUtils.isEmpty(f3211a) && a.r()) {
            a("ro.product.letv_name");
        }
        if (TextUtils.isEmpty(f3211a) && a.s()) {
            a("ro.qiku.product.devicename");
        }
        if (TextUtils.isEmpty(f3211a)) {
            String str = Build.BRAND;
            String str2 = Build.MODEL;
            String str3 = Build.PRODUCT;
            String lowerCase = str.trim().toLowerCase();
            String lowerCase2 = str2.trim().toLowerCase();
            String lowerCase3 = str3.trim().toLowerCase();
            if (!TextUtils.isEmpty(lowerCase)) {
                if (lowerCase2.startsWith(lowerCase) && b(lowerCase2)) {
                    a(str2);
                } else if (lowerCase3.startsWith(lowerCase) && b(lowerCase3)) {
                    a(str3);
                }
            }
            if (TextUtils.isEmpty(f3211a)) {
                if (str2.contains(" ") && b(str2)) {
                    a(str2);
                } else if (str3.contains(" ") && b(str3)) {
                    a(str3);
                }
            }
        }
        if (TextUtils.isEmpty(f3211a)) {
            String strA = d.a(c);
            if (strA.matches("^(?i)android")) {
                return;
            }
            if (strA.matches(".+-[a-zA-Z0-9]{10,}$")) {
                strA = strA.replaceFirst("-[a-zA-Z0-9]{10,}$", "");
            }
            if (b(strA)) {
                a(strA);
            }
        }
    }

    private static boolean b(String marketName) {
        return (TextUtils.isEmpty(marketName) || marketName.matches("[A-Z]{2,3}-[A-Z|0-9]{4}[a-zA-Z|0-9]*") || marketName.matches("[A-Z0-9]{5,}") || marketName.matches("[A-Z0-9]{4}-[A-Z0-9]{3,}") || marketName.matches("[A-Z]{2}\\d{4,}-[A-Z0-9]+")) ? false : true;
    }
}
