package com.czhj.devicehelper.cnoaid;

import android.util.Log;

/* JADX INFO: loaded from: classes2.dex */
public final class g {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f2179a = "OAID";
    private static boolean b = false;

    private g() {
    }

    public static void a() {
        b = true;
    }

    public static void a(Object obj) {
        if (b) {
            if (obj == null) {
                obj = "<null>";
            }
            Log.i("OAID", obj.toString());
        }
    }
}
