package com.qq.gdt.action.i;

import android.content.Context;
import android.content.pm.PackageManager;
import java.util.HashMap;
import java.util.Map;
import java.util.TimeZone;

/* JADX INFO: loaded from: classes3.dex */
public class h {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static String f3080a;
    private static String b;
    private static final Map<String, Integer> c = new HashMap<String, Integer>() { // from class: com.qq.gdt.action.i.h.1
        {
            put("46000", 1);
            put("46002", 1);
            put("46007", 1);
            put("46008", 1);
            put("46001", 2);
            put("46006", 2);
            put("46009", 2);
            put("46003", 3);
            put("46005", 3);
            put("46011", 3);
        }
    };

    public static String a() {
        try {
            return com.qq.gdt.action.d.a().g().getPackageName();
        } catch (Throwable th) {
            o.a("Get package name encountered exception: " + th.getMessage(), new Object[0]);
            return null;
        }
    }

    public static String a(Context context) {
        try {
            return context.getPackageManager().getPackageInfo(context.getPackageName(), 0).versionName;
        } catch (Throwable unused) {
            return null;
        }
    }

    public static int b(Context context) {
        try {
            return context.getPackageManager().getPackageInfo(context.getPackageName(), 0).versionCode;
        } catch (Throwable unused) {
            return 0;
        }
    }

    public static Integer b() {
        try {
            String strA = com.qq.gdt.action.d.g.a();
            if (v.a(strA)) {
                return 0;
            }
            for (Map.Entry<String, Integer> entry : c.entrySet()) {
                if (strA.startsWith(entry.getKey())) {
                    return entry.getValue();
                }
            }
        } catch (Throwable th) {
            o.a("Get carrier encounter exception: " + th.getMessage(), new Object[0]);
        }
        return 0;
    }

    public static String c() {
        try {
            return TimeZone.getDefault().getDisplayName(false, 0);
        } catch (AssertionError | Exception unused) {
            return "";
        }
    }

    public static String c(Context context) {
        try {
            PackageManager packageManager = context.getApplicationContext().getPackageManager();
            return (String) packageManager.getApplicationLabel(packageManager.getApplicationInfo(context.getPackageName(), 0));
        } catch (Throwable unused) {
            return null;
        }
    }

    public static com.qq.gdt.action.d.d.b d(Context context) {
        return com.qq.gdt.action.d.d.b(context);
    }

    public static com.qq.gdt.action.d.d.a e(Context context) {
        return com.qq.gdt.action.d.d.a(context, false);
    }

    public static void f(Context context) {
        com.qq.gdt.action.d.d.a(context);
    }
}
