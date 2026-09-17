package com.cmic.gen.sdk.f;

import android.util.Log;

/* JADX INFO: compiled from: LogUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final c f2119a = new c();
    private static boolean b = false;

    public static void a(boolean z) {
        b = z;
    }

    public static void a(String str, String str2) {
        if (b) {
            Log.e("CMCC-SDK:" + str, "" + str2);
        }
    }

    public static void b(String str, String str2) {
        if (b) {
            Log.d("CMCC-SDK:" + str, "" + str2);
        }
    }

    public static void c(String str, String str2) {
        if (b) {
            Log.i("CMCC-SDK:" + str, "" + str2);
        }
    }
}
