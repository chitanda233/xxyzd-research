package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.Handler;
import android.os.Looper;
import com.baidu.mobads.sdk.api.IAdInterListener;
import java.net.InetAddress;
import java.net.NetworkInterface;
import java.util.Enumeration;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.g, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0601g {
    public static synchronized boolean a(int i, Context context) {
        try {
            if (!AbstractC0606l.C) {
                return true;
            }
            return l0.c(context);
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "checkProcess Exception", e, "processName", Integer.valueOf(i));
            return true;
        }
    }

    public static String b(Context context) {
        try {
            String strA = p0.a(context, "cl_jm_a4", "");
            if (!AbstractC0600f.a(strA)) {
                return strA;
            }
            String strA2 = p0.a(context, v0.f2017a, "-1");
            if (!AbstractC0600f.a(strA2) && !"-1".equals(strA2)) {
                String strB = AbstractC0596b.b(strA2);
                String str = strB + "|" + C0616v.g().b() + "|" + C0616v.g().f() + "|" + C0616v.g().a();
                p0.b(context, "cl_jm_a4", str);
                p0.b(context, "cl_jm_a3", strB);
                return str;
            }
            String strA3 = AbstractC0598d.a();
            long jCurrentTimeMillis = System.currentTimeMillis();
            String str2 = strA3 + jCurrentTimeMillis;
            String str3 = strA3 + jCurrentTimeMillis + "|" + C0616v.g().b() + "|" + C0616v.g().f() + "|" + C0616v.g().a();
            p0.b(context, "cl_jm_a4", str3);
            p0.b(context, "cl_jm_a3", str2);
            return str3;
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }

    public static void c(Context context) {
        if (AbstractC0600f.a(p0.a(context, "cl_jm_f5", ""))) {
            p0.b(context, "cl_jm_f5", AbstractC0598d.a() + System.currentTimeMillis());
        }
    }

    public static void d(Context context) {
        if (AbstractC0600f.a(p0.a(context, "cl_jm_a2", ""))) {
            p0.b(context, "cl_jm_a2", AbstractC0598d.a() + System.currentTimeMillis());
        }
    }

    public static void a(Runnable runnable) {
        if (Looper.getMainLooper() == Looper.myLooper()) {
            runnable.run();
        } else {
            new Handler(Looper.getMainLooper()).post(runnable);
        }
    }

    public static String a() {
        StringBuilder sb = new StringBuilder();
        try {
            if (AbstractC0606l.F) {
                Enumeration<NetworkInterface> networkInterfaces = NetworkInterface.getNetworkInterfaces();
                while (networkInterfaces.hasMoreElements()) {
                    NetworkInterface networkInterfaceNextElement = networkInterfaces.nextElement();
                    String name = networkInterfaceNextElement.getName();
                    if (name == null || (!name.contains("wlan") && !name.contains("eth0") && !name.contains(IAdInterListener.AdReqParam.AP))) {
                        Enumeration<InetAddress> inetAddresses = networkInterfaceNextElement.getInetAddresses();
                        Q.a("LogInfoShanYanLogger", "get addresses from system", name);
                        while (inetAddresses.hasMoreElements()) {
                            InetAddress inetAddressNextElement = inetAddresses.nextElement();
                            if (!inetAddressNextElement.isLoopbackAddress() && !inetAddressNextElement.isLinkLocalAddress()) {
                                String hostAddress = inetAddressNextElement.getHostAddress();
                                Q.a("LogInfoShanYanLogger", "get hostAddress from system", hostAddress);
                                if (AbstractC0600f.b(hostAddress)) {
                                    if (sb.length() > 0) {
                                        sb.append(",");
                                    }
                                    sb.append(hostAddress);
                                }
                            }
                        }
                    }
                }
            }
            String string = sb.toString();
            Q.a("LogInfoShanYanLogger", "get ipList from system", string);
            return string;
        } catch (Exception unused) {
            return "";
        }
    }

    public static boolean a(Context context, String str) {
        return context == null || context.getPackageManager().checkPermission(str, C0616v.g().c(context)) == 0;
    }

    public static void a(Context context) {
        try {
            for (String str : AbstractC0612r.d) {
                if (a(context, str)) {
                    Q.a("CheckPermissionShanYanLogger", "getPermission success:", str);
                } else {
                    Q.a("CheckPermissionShanYanLogger", "getPermission lacks:", str);
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "getPermission Exception_e:", e);
        }
    }
}
