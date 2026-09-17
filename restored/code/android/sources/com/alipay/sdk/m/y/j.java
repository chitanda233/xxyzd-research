package com.alipay.sdk.m.y;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.telephony.TelephonyManager;
import androidx.core.app.ActivityCompat;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes.dex */
public class j {

    public static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static String f383a = "0";
        public static String b = "1";
        public static String c = "2";
        public static String d = "3";
    }

    public static String a(Context context) {
        ConnectivityManager connectivityManager;
        NetworkInfo activeNetworkInfo;
        String str = a.f383a;
        if (context == null || (activeNetworkInfo = (connectivityManager = (ConnectivityManager) context.getSystemService("connectivity")).getActiveNetworkInfo()) == null) {
            return str;
        }
        int type = activeNetworkInfo.getType();
        if (type == 0) {
            return a.b;
        }
        if (type != 1) {
            return str;
        }
        String str2 = a.c;
        try {
            boolean z = 1 != ((TelephonyManager) context.getSystemService("phone")).getSimState();
            boolean z2 = ActivityCompat.checkSelfPermission(context, "android.permission.CHANGE_NETWORK_STATE") == 0;
            Method declaredMethod = ConnectivityManager.class.getDeclaredMethod("getMobileDataEnabled", new Class[0]);
            declaredMethod.setAccessible(true);
            return (z && z2 && ((Boolean) declaredMethod.invoke(connectivityManager, new Object[0])).booleanValue()) ? a.d : str2;
        } catch (Throwable th) {
            g.a(th);
            return str2;
        }
    }
}
