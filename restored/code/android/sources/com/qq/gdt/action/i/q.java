package com.qq.gdt.action.i;

import android.content.Context;
import android.content.pm.PackageInfo;
import java.lang.reflect.Method;
import java.util.Arrays;

/* JADX INFO: loaded from: classes3.dex */
public class q {
    private static Class<?> c;
    private static Method d;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static String[] f3084a = new String[0];
    private static String[] b = {com.kuaishou.weapon.p0.g.f2717a, com.kuaishou.weapon.p0.g.b};
    private static boolean e = false;

    static {
        a();
    }

    private static void a() {
        try {
            try {
                c = Class.forName("androidx.core.content.ContextCompat");
            } catch (ClassNotFoundException unused) {
                c = Class.forName("androidx.core.content.ContextCompat");
            }
            Class<?> cls = c;
            if (cls != null) {
                d = cls.getMethod("checkSelfPermission", Context.class, String.class);
            }
            e = true;
        } catch (Exception e2) {
            o.b("Failed to initialize ContextCompat", e2);
            e = true;
        }
    }

    public static boolean a(Context context) {
        try {
            PackageInfo packageInfo = context.getPackageManager().getPackageInfo(context.getPackageName(), 4096);
            String[] strArr = packageInfo != null ? packageInfo.requestedPermissions : null;
            if (strArr == null || strArr.length <= 0) {
                return false;
            }
            return Arrays.asList(strArr).containsAll(Arrays.asList(b));
        } catch (Exception e2) {
            o.b(e2.getMessage());
            return false;
        }
    }

    public static boolean a(Context context, String str) {
        Method method;
        if (!e || c == null || (method = d) == null) {
            o.a("PermissionUtil not properly initialized", new Object[0]);
            return true;
        }
        try {
            if (((Integer) method.invoke(null, context, str)).intValue() == 0) {
                return true;
            }
            o.a("请在AndroidManifest.xml文件中添加:\n<uses-permission android:name=\"" + str + "\" />", new Object[0]);
            return false;
        } catch (Exception e2) {
            o.b("Exception while check has permission " + str, e2);
            return true;
        }
    }
}
