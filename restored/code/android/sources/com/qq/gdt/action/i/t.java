package com.qq.gdt.action.i;

import android.content.Context;
import android.content.SharedPreferences;

/* JADX INFO: loaded from: classes3.dex */
public class t {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile String f3088a;
    private static volatile String b;

    private static long a(Context context, String str) {
        return context.getApplicationContext().getSharedPreferences("com.qq.gdt.action.SessionTimePref", 0).getLong(str, 0L);
    }

    public static String a() {
        try {
            String strP = com.qq.gdt.action.d.a().p();
            if (strP == null) {
                strP = "";
            }
            if (strP.equals(b) && f3088a != null) {
                return f3088a;
            }
            synchronized (t.class) {
                if (strP.equals(b) && f3088a != null) {
                    return f3088a;
                }
                f3088a = "com.qq.gdt.action.SessionTimePref_" + u.a(strP);
                b = strP;
                return f3088a;
            }
        } catch (Exception unused) {
            return "com.qq.gdt.action.SessionTimePref_default";
        }
    }

    public static void a(Context context, long j) {
        SharedPreferences.Editor editorEdit = context.getApplicationContext().getSharedPreferences(a(), 0).edit();
        if (j > 0) {
            editorEdit.putLong("ActivateTimeRevised", j);
        }
        editorEdit.apply();
    }

    public static void a(Context context, long j, long j2) {
        SharedPreferences.Editor editorEdit = context.getApplicationContext().getSharedPreferences(a(), 0).edit();
        editorEdit.putLong("AppStartTime", j);
        if (j2 > 0) {
            editorEdit.putLong("AppStartTimeRevised", j2);
        }
        editorEdit.apply();
    }

    public static void a(Context context, boolean z) {
        SharedPreferences.Editor editorEdit = context.getApplicationContext().getSharedPreferences(a(), 0).edit();
        editorEdit.putBoolean("ActivateWithImei", z);
        editorEdit.apply();
    }

    public static boolean a(Context context) {
        return context.getApplicationContext().getSharedPreferences(a(), 0).getBoolean("ActivateWithImei", false);
    }

    public static void b(Context context, long j) {
        SharedPreferences.Editor editorEdit = context.getApplicationContext().getSharedPreferences(a(), 0).edit();
        editorEdit.putLong("SessionStartTimeV1", j);
        editorEdit.apply();
    }

    public static void b(Context context, boolean z) {
        SharedPreferences.Editor editorEdit = context.getApplicationContext().getSharedPreferences(a(), 0).edit();
        editorEdit.putBoolean("ActivateWithOaid", z);
        editorEdit.apply();
    }

    public static boolean b(Context context) {
        return context.getApplicationContext().getSharedPreferences(a(), 0).getBoolean("ActivateWithOaid", false);
    }

    public static long c(Context context) {
        return context.getApplicationContext().getSharedPreferences(a(), 0).getLong("ActivateTimeRevised", -1L);
    }

    public static void c(Context context, long j) {
        SharedPreferences.Editor editorEdit = context.getApplicationContext().getSharedPreferences(a(), 0).edit();
        editorEdit.putLong("SessionEndTimeV1", j);
        editorEdit.apply();
    }

    public static long d(Context context) {
        return context.getApplicationContext().getSharedPreferences(a(), 0).getLong("AppStartTime", -1L);
    }

    public static void d(Context context, long j) {
        o.a("setLastRefreshTraceIdTime:" + j, new Object[0]);
        SharedPreferences.Editor editorEdit = context.getApplicationContext().getSharedPreferences(a(), 0).edit();
        editorEdit.putLong("RefreshTraceIdTime", j);
        editorEdit.apply();
    }

    public static long e(Context context) {
        return context.getApplicationContext().getSharedPreferences(a(), 0).getLong("AppStartTimeRevised", -1L);
    }

    public static synchronized void f(Context context) {
        try {
            SharedPreferences sharedPreferences = context.getApplicationContext().getSharedPreferences(a(), 0);
            if (sharedPreferences.getInt("version", 0) == 0) {
                long jA = a(context, "SessionStartTime");
                long jA2 = a(context, "ActivateTimeRevised");
                SharedPreferences.Editor editorEdit = sharedPreferences.edit();
                editorEdit.putInt("version", 1);
                if (jA > 0) {
                    editorEdit.putLong("AppStartTime", jA);
                    if (jA2 <= 0) {
                        editorEdit.putLong("ActivateTimeRevised", jA);
                    }
                    editorEdit.putBoolean("ActivateWithImei", true);
                    editorEdit.putBoolean("ActivateWithOaid", true);
                }
                editorEdit.apply();
            }
        } catch (Throwable unused) {
            o.c("Exception while upgrade preference");
        }
    }

    public static boolean g(Context context) {
        return System.currentTimeMillis() - j(context) > 2592000000L;
    }

    public static long h(Context context) {
        long jCurrentTimeMillis;
        SharedPreferences sharedPreferences = context.getApplicationContext().getSharedPreferences(a(), 0);
        long j = sharedPreferences.getLong("AmsClickIdFirstStartTime", 0L);
        if (j > 0) {
            return j;
        }
        synchronized (t.class) {
            jCurrentTimeMillis = sharedPreferences.getLong("AmsClickIdFirstStartTime", 0L);
            if (jCurrentTimeMillis <= 0) {
                jCurrentTimeMillis = System.currentTimeMillis();
                SharedPreferences.Editor editorEdit = sharedPreferences.edit();
                editorEdit.putLong("AmsClickIdFirstStartTime", jCurrentTimeMillis);
                editorEdit.apply();
                o.a("Set AmsClickIdFirstStartTime: " + jCurrentTimeMillis, new Object[0]);
            }
        }
        return jCurrentTimeMillis;
    }

    public static long i(Context context) {
        return context.getApplicationContext().getSharedPreferences(a(), 0).getLong("AmsClickIdFirstStartTime", 0L);
    }

    private static long j(Context context) {
        return context.getApplicationContext().getSharedPreferences(a(), 0).getLong("RefreshTraceIdTime", -1L);
    }
}
