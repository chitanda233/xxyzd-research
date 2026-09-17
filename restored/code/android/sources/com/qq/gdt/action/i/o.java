package com.qq.gdt.action.i;

import android.util.Log;

/* JADX INFO: loaded from: classes3.dex */
public class o {
    public static void a(String str) {
        Log.i("gdt_action", str);
    }

    public static void a(String str, String str2, Object... objArr) {
    }

    public static void a(String str, Throwable th) {
        if (th == null) {
            b(str);
        } else {
            Log.w("gdt_action", str, th);
        }
    }

    public static void a(String str, Object... objArr) {
    }

    public static void b(String str) {
        Log.w("gdt_action", str);
    }

    public static void b(String str, Throwable th) {
        if (th == null) {
            c(str);
        } else {
            Log.e("gdt_action", str, th);
        }
    }

    public static void c(String str) {
        Log.e("gdt_action", str);
    }
}
