package com.unicom.online.account.kernel;

import android.content.Context;
import android.text.TextUtils;
import java.net.InetAddress;
import java.net.UnknownHostException;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Iterator;
import java.util.UUID;

/* JADX INFO: loaded from: classes4.dex */
public abstract class ao {
    public static final String b;
    public static final String c;
    public static final String d;
    public static final String e;
    public static final String f;
    public static final String g;
    public static final String h;
    public static final String i;
    public static final String j;
    public static final String k;
    public static final String l;
    public static final String m;
    public static final String n;
    public static ArrayList o;
    public static final HashSet p;
    public static int q;
    public static String r;
    public static String s;
    public static String t;
    public static int u;
    public static String v;

    static {
        new String(aq.b("MTAwMTAuY29t"));
        new String(aq.b("aWQ2Lm1l"));
        new String(aq.b("Y21wYXNzcG9ydC5jb20="));
        b = new String(aq.b("bXN2Ni53b3Ntcy5jbg=="));
        c = new String(aq.b("YWxpLndvc21zLmNu"));
        d = new String(aq.b("bS56enguY25rbG9nLmNvbQ=="));
        e = new String(aq.b("dGVzdC53b3Ntcy5jbg=="));
        f = new String(aq.b("YXV0aC53b3Ntcy5jbg=="));
        g = new String(aq.b("c2RrbG9nLndvc21zLmNu"));
        h = new String(aq.b("Ki53b3Ntcy5jbg=="));
        i = new String(aq.b("Lndvc21zLmNu"));
        j = new String(aq.b("L2Ryby92MS9yZXBvcnQ="));
        k = new String(aq.b("L3VuaWNvbUF1dGgvYW5kcm9pZC92My4wL3Fj"));
        l = new String(aq.b("L3VuaWNvbUF1dGgvYW5kcm9pZC92My4wL3Fj"));
        m = new String(aq.b("L3VuaWNvbVVhaWQvYW5kcm9pZC92MS4wL3Fj"));
        n = new String(aq.b("L2Nsb3VkL2FuZHJvaWQvdjMuMC9xYw=="));
        p = new HashSet();
        r = "0";
        s = "";
        t = "";
        u = 5;
        v = "";
    }

    public static boolean c(String str, String str2) {
        if (!str.startsWith(str2) && !str.endsWith(str2)) {
            StringBuilder sb = new StringBuilder("CN=");
            String str3 = h;
            if (!str.startsWith(sb.append(str3).toString()) && !str.endsWith("CN=" + str3)) {
                return false;
            }
        }
        return true;
    }

    public static void b() {
        String strReplace = "";
        try {
            strReplace = UUID.randomUUID().toString().replace("-", "");
            if (TextUtils.isEmpty(strReplace) || strReplace.length() < 32) {
                strReplace = ap.j.substring(0, 32);
            }
        } catch (Exception e2) {
            as.b(e2);
        }
        s = strReplace;
        c();
    }

    public static String c() {
        if (s.length() != 32) {
            b();
        }
        return s;
    }

    public static void c(Context context, String str, String str2) {
        t tVar;
        int i2 = 0;
        while (true) {
            if (i2 >= o.size()) {
                tVar = null;
                break;
            }
            tVar = (t) o.get(i2);
            if (tVar.b.equalsIgnoreCase(str) && tVar.c.equalsIgnoreCase(str2)) {
                break;
            } else {
                i2++;
            }
        }
        if (tVar != null) {
            tVar.d = "";
            tVar.e = 0L;
            boolean z = ap.b;
            bf.b(context, new ArrayList(o));
        }
    }

    public static String b(int i2) {
        if (i2 == 12 || i2 == 13) {
            return "https://" + bp.d() + n + "?";
        }
        if (i2 == 24 || i2 == 25) {
            return "https://" + bp.d() + m + "?";
        }
        if (i2 != 2 && i2 != 3 && i2 != 4 && i2 != 5) {
            return "https://" + bp.d() + l + "?";
        }
        return "https://" + bp.d() + k + "?";
    }

    public static boolean b(String str, String str2) {
        if (ap.c && str != null) {
            try {
                if (str.length() > 0) {
                    InetAddress byName = InetAddress.getByName(str.replaceFirst("^\\[", "").replaceAll("\\]$", ""));
                    Iterator it = p.iterator();
                    while (it.hasNext()) {
                        if (byName.equals(InetAddress.getByName((String) it.next()))) {
                            return true;
                        }
                    }
                }
            } catch (UnknownHostException e2) {
                as.b(e2);
            }
        }
        if (!str.endsWith(".10010.com") || !c(str2, "CN=10010.com")) {
            String str3 = f;
            if (!str.equals(str3) || !c(str2, "CN=" + str3)) {
                String str4 = b;
                if (!str.equals(str4) || !c(str2, "CN=" + str4)) {
                    String str5 = c;
                    if (!str.equals(str5) || !c(str2, "CN=" + str5)) {
                        String str6 = e;
                        if (!str.equals(str6) || !c(str2, "CN=" + str6)) {
                            String str7 = d;
                            if ((!str.equals(str7) || !c(str2, "CN=" + str7)) && ((!str.equals("id6.me") || !c(str2, "CN=*.id6.me")) && (!str.equals("cert.cmpassport.com") || !c(str2, "CN=*.cmpassport.com")))) {
                                return false;
                            }
                        }
                    }
                }
            }
        }
        return true;
    }

    public static String b(String str) {
        if ("cmnet".equals(str) || "cmwap".equals(str)) {
            return "1";
        }
        if ("3gwap".equals(str) || "uniwap".equals(str) || "3gnet".equals(str) || "uninet".equals(str)) {
            return "3";
        }
        return ("ctnet".equals(str) || "ctwap".equals(str)) ? "2" : "0";
    }

    public static void b(Context context, String str, String str2) {
        t tVar = new t();
        tVar.b = str;
        tVar.c = str2;
        if (o.isEmpty()) {
            o.add(tVar);
        } else {
            o.add(1, tVar);
            if (o.size() > 4) {
                o.remove(4);
            }
        }
        boolean z = ap.b;
        bf.b(context, new ArrayList(o));
    }

    public static void b(int i2, Context context, String str, String str2) {
        t tVar = new t();
        tVar.b = str;
        tVar.c = str2;
        if (i2 < 0) {
            return;
        }
        if (i2 >= o.size()) {
            o.add(tVar);
        } else {
            o.add(i2, tVar);
        }
        while (o.size() > 4) {
            ArrayList arrayList = o;
            arrayList.remove(arrayList.size() - 1);
        }
        boolean z = ap.b;
        bf.b(context, new ArrayList(o));
    }
}
