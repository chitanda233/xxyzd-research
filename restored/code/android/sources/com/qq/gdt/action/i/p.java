package com.qq.gdt.action.i;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkCapabilities;

/* JADX INFO: loaded from: classes3.dex */
public class p {
    /* JADX WARN: Code restructure failed: missing block: B:21:0x0046, code lost:
    
        if (r2.hasTransport(4) == false) goto L22;
     */
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    public static java.lang.String a() {
        /*
            java.lang.String r0 = "UNKNOWN"
            com.qq.gdt.action.d r1 = com.qq.gdt.action.d.a()
            android.content.Context r1 = r1.g()
            java.lang.String r2 = "android.permission.ACCESS_NETWORK_STATE"
            boolean r2 = com.qq.gdt.action.i.q.a(r1, r2)     // Catch: java.lang.Throwable -> L67
            if (r2 != 0) goto L13
            return r0
        L13:
            java.lang.String r2 = "connectivity"
            java.lang.Object r2 = r1.getSystemService(r2)     // Catch: java.lang.Throwable -> L67
            android.net.ConnectivityManager r2 = (android.net.ConnectivityManager) r2     // Catch: java.lang.Throwable -> L67
            if (r2 == 0) goto L49
            android.net.Network r3 = r2.getActiveNetwork()     // Catch: java.lang.Throwable -> L67
            if (r3 == 0) goto L48
            android.net.NetworkCapabilities r2 = r2.getNetworkCapabilities(r3)     // Catch: java.lang.Throwable -> L67
            if (r2 == 0) goto L49
            r3 = 1
            boolean r3 = r2.hasTransport(r3)     // Catch: java.lang.Throwable -> L67
            if (r3 == 0) goto L33
            java.lang.String r0 = "WIFI"
            return r0
        L33:
            r3 = 0
            boolean r3 = r2.hasTransport(r3)     // Catch: java.lang.Throwable -> L67
            if (r3 != 0) goto L49
            r3 = 3
            boolean r3 = r2.hasTransport(r3)     // Catch: java.lang.Throwable -> L67
            if (r3 != 0) goto L49
            r3 = 4
            boolean r2 = r2.hasTransport(r3)     // Catch: java.lang.Throwable -> L67
            if (r2 != 0) goto L49
        L48:
            return r0
        L49:
            java.lang.String r2 = "phone"
            java.lang.Object r1 = r1.getSystemService(r2)     // Catch: java.lang.Throwable -> L67
            android.telephony.TelephonyManager r1 = (android.telephony.TelephonyManager) r1     // Catch: java.lang.Throwable -> L67
            if (r1 != 0) goto L54
            return r0
        L54:
            int r1 = r1.getNetworkType()     // Catch: java.lang.Throwable -> L67
            switch(r1) {
                case 1: goto L65;
                case 2: goto L65;
                case 3: goto L62;
                case 4: goto L65;
                case 5: goto L62;
                case 6: goto L62;
                case 7: goto L65;
                case 8: goto L62;
                case 9: goto L62;
                case 10: goto L62;
                case 11: goto L65;
                case 12: goto L62;
                case 13: goto L5f;
                case 14: goto L62;
                case 15: goto L62;
                case 16: goto L65;
                case 17: goto L62;
                case 18: goto L5f;
                case 19: goto L5b;
                case 20: goto L5c;
                default: goto L5b;
            }
        L5b:
            goto L67
        L5c:
            java.lang.String r0 = "5G"
            return r0
        L5f:
            java.lang.String r0 = "4G"
            return r0
        L62:
            java.lang.String r0 = "3G"
            return r0
        L65:
            java.lang.String r0 = "2G"
        L67:
            return r0
        */
        throw new UnsupportedOperationException("Method not decompiled: com.qq.gdt.action.i.p.a():java.lang.String");
    }

    public static boolean a(Context context) {
        Network activeNetwork;
        NetworkCapabilities networkCapabilities;
        if (!q.a(context, com.kuaishou.weapon.p0.g.b)) {
            return false;
        }
        try {
            ConnectivityManager connectivityManager = (ConnectivityManager) context.getSystemService("connectivity");
            if (connectivityManager == null || (activeNetwork = connectivityManager.getActiveNetwork()) == null || (networkCapabilities = connectivityManager.getNetworkCapabilities(activeNetwork)) == null) {
                return false;
            }
            return networkCapabilities.hasTransport(1) || networkCapabilities.hasTransport(0) || networkCapabilities.hasTransport(3) || networkCapabilities.hasTransport(4);
        } catch (Exception e) {
            o.a("Check network available exception", e);
            return false;
        }
    }

    public static boolean b() {
        try {
            return com.qq.gdt.action.b.a(com.qq.gdt.action.d.a().g()).s() == 0;
        } catch (Exception e) {
            o.a("isActionHttpsEnable e  = " + e, new Object[0]);
            return true;
        }
    }

    public static boolean c() {
        try {
            return com.qq.gdt.action.b.a(com.qq.gdt.action.d.a().g()).t() == 0;
        } catch (Exception e) {
            o.a("isEventHttpsEnable e  = " + e, new Object[0]);
            return true;
        }
    }
}
