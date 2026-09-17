package com.kwad.library.solder.lib;

import android.util.Log;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static String DT() {
        return "";
    }

    public static void e(String str, String str2) {
        Log.e("Sodler", E(str, str2));
    }

    public static void e(String str, Throwable th) {
        Log.e("Sodler", E(str, ""), th);
    }

    public static void e(String str, String str2, Throwable th) {
        Log.e("Sodler", E(str, str2), th);
    }

    private static String E(String str, String str2) {
        return "[" + str + "]: " + str2 + " " + DT();
    }
}
