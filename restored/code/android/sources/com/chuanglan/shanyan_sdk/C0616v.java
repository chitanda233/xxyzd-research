package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.Build;
import com.cmic.gen.sdk.auth.GenAuthnHelper;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.v, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public final class C0616v {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile C0616v f2016a;
    private static volatile String b;
    private static volatile String c;
    private static volatile String d;
    private static volatile int e;
    private static volatile long f;
    private static volatile String g;
    private static volatile String h;
    private static volatile String i;
    private static volatile String j;
    private static volatile String k;
    private static volatile String l;
    private static volatile String m;
    private static volatile long n;

    private C0616v() {
    }

    public static C0616v g() {
        if (f2016a == null) {
            synchronized (C0616v.class) {
                if (f2016a == null) {
                    f2016a = new C0616v();
                }
            }
        }
        return f2016a;
    }

    public String a() {
        if (l == null && AbstractC0606l.G) {
            l = Build.MODEL;
        }
        return l;
    }

    public String b() {
        if (j == null && AbstractC0606l.G) {
            j = Build.BRAND;
        }
        return j;
    }

    public String c() {
        if (k == null && AbstractC0606l.G) {
            k = Build.DISPLAY;
        }
        return k;
    }

    public String d(Context context) {
        if (h == null) {
            h = B.a(context);
        }
        return h;
    }

    public String e() {
        if (i == null && AbstractC0606l.G) {
            i = Build.MANUFACTURER.toUpperCase();
        }
        return i;
    }

    public String f() {
        if (m == null && AbstractC0606l.G) {
            m = Build.VERSION.RELEASE;
        }
        return m;
    }

    public String h() {
        if (d == null) {
            synchronized (C0616v.class) {
                if (d == null && AbstractC0606l.G) {
                    d = o0.a();
                }
            }
        }
        if (d == null) {
            d = "";
        }
        Q.c("CheckAuthEnableShanYanLogger", "rom v", d);
        return d;
    }

    private String a(Context context) {
        String str;
        String strOptString = GenAuthnHelper.getInstance(context).getNetworkType(context).optString("operatortype");
        Q.a("CheckAuthEnableShanYanLogger", "cmcc current Type", strOptString);
        if ("1".equals(strOptString)) {
            str = "CMCC";
        } else if ("2".equals(strOptString)) {
            str = "CUCC";
        } else if ("3".equals(strOptString)) {
            str = "CTCC";
        } else {
            str = "4".equals(strOptString) ? "CMHK" : "Unknown_Operator";
        }
        Q.a("CheckAuthEnableShanYanLogger", "cmcc current Type end", str);
        return str;
    }

    public String b(Context context) {
        if (System.currentTimeMillis() - n > 5000) {
            b = AbstractC0610p.i(context);
            n = System.currentTimeMillis();
        } else if (AbstractC0610p.b(context, "operator_sub")) {
            b = AbstractC0610p.i(context);
        } else if (b == null) {
            synchronized (C0616v.class) {
                if (b == null) {
                    b = AbstractC0610p.i(context);
                }
            }
        }
        if ((b == null || "Unknown_Operator".equals(b)) && e(context) > 0) {
            b = a(context);
        }
        Q.a("CheckAuthEnableShanYanLogger", "current Operator Type", b);
        return b;
    }

    public String c(Context context) {
        if (g == null) {
            g = context.getPackageName();
        }
        return g;
    }

    public String d() {
        if (c == null) {
            synchronized (C0616v.class) {
                if (c == null) {
                    c = AbstractC0601g.a();
                }
            }
        }
        if (c == null) {
            c = "";
        }
        Q.c("CheckAuthEnableShanYanLogger", "d f i p ", c);
        return c;
    }

    public int e(Context context) {
        long jCurrentTimeMillis = System.currentTimeMillis() - f;
        if (jCurrentTimeMillis > 1000) {
            f = System.currentTimeMillis();
            e = AbstractC0610p.k(context);
        }
        Q.c("CheckAuthEnableShanYanLogger", "current simCount", Integer.valueOf(e), Long.valueOf(jCurrentTimeMillis));
        return e;
    }
}
