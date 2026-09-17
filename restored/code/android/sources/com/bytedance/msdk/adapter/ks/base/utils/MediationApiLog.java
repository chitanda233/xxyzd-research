package com.bytedance.msdk.adapter.ks.base.utils;

import android.util.Log;

/* JADX INFO: loaded from: classes2.dex */
public class MediationApiLog {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static boolean f1864a = false;
    private static String b = "Tme";

    public static void e(String str) {
        if (f1864a) {
            Log.e(b, str);
        }
    }

    public static void e(String str, String str2) {
        if (f1864a) {
            Log.e(str, str2);
        }
    }

    public static void i(String str) {
        if (f1864a) {
            Log.i(b, str);
        }
    }

    public static void i(String str, String str2) {
        if (f1864a) {
            Log.i(str, str2);
        }
    }

    public static void setDebug(Boolean bool) {
        f1864a = bool.booleanValue();
    }
}
