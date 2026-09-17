package com.cmic.gen.sdk.f;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.Build;
import android.telephony.SubscriptionManager;
import android.telephony.TelephonyManager;
import com.baidu.mobads.sdk.internal.bn;
import java.lang.reflect.Method;

/* JADX INFO: compiled from: TelephonyUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class n {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f2128a = Build.BRAND;
    private static final String b = Build.MODEL;
    private static final String c = "android" + Build.VERSION.RELEASE;
    private static final boolean d;
    private static final String e;

    static {
        d = Build.VERSION.SDK_INT <= 28;
        e = Build.MANUFACTURER;
    }

    public static int a(Context context, boolean z, com.cmic.gen.sdk.a aVar) {
        try {
            ConnectivityManager connectivityManager = (ConnectivityManager) context.getApplicationContext().getSystemService("connectivity");
            NetworkInfo activeNetworkInfo = connectivityManager != null ? connectivityManager.getActiveNetworkInfo() : null;
            if (activeNetworkInfo != null && activeNetworkInfo.isAvailable()) {
                int type = activeNetworkInfo.getType();
                if (type != 1) {
                    if (type == 0) {
                        c.b("TelephonyUtils", "流量");
                        return 1;
                    }
                    return 0;
                }
                c.b("TelephonyUtils", "WIFI");
                boolean zA = h.a(context, "android.permission.CHANGE_NETWORK_STATE");
                c.a("TelephonyUtils", "CHANGE_NETWORK_STATE=" + zA);
                if (!zA || !z || !a(connectivityManager, context, aVar)) {
                    return 2;
                }
                c.b("TelephonyUtils", "流量数据 WIFI 同开");
                return 3;
            }
            return 0;
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }

    private static boolean a(ConnectivityManager connectivityManager, Context context, com.cmic.gen.sdk.a aVar) {
        try {
            Method declaredMethod = ConnectivityManager.class.getDeclaredMethod("getMobileDataEnabled", new Class[0]);
            declaredMethod.setAccessible(true);
            boolean zBooleanValue = ((Boolean) declaredMethod.invoke(connectivityManager, new Object[0])).booleanValue();
            c.b("TelephonyUtils", "data is on ---------" + zBooleanValue);
            TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
            if (telephonyManager != null) {
                if (telephonyManager.createForSubscriptionId(SubscriptionManager.getDefaultSubscriptionId()).isDataEnabled()) {
                    aVar.a("networkTypeByAPI", "1");
                } else {
                    aVar.a("networkTypeByAPI", "0");
                }
            }
            return zBooleanValue;
        } catch (Exception unused) {
            c.a("TelephonyUtils", "isMobileEnabled ----反射出错-----");
            return false;
        }
    }

    public static String a() {
        return f2128a;
    }

    public static String b() {
        return b;
    }

    public static String c() {
        return c;
    }

    public static boolean d() {
        return d;
    }

    public static boolean e() {
        String str = e;
        c.a(bn.j, str);
        return "HUAWEI".equalsIgnoreCase(str);
    }

    public static boolean a(Context context) {
        TelephonyManager telephonyManager = (TelephonyManager) context.getSystemService("phone");
        return telephonyManager == null || 1 != telephonyManager.getSimState();
    }
}
