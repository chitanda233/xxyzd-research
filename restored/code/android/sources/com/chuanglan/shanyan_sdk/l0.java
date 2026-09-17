package com.chuanglan.shanyan_sdk;

import android.app.Application;
import android.content.Context;
import android.os.Build;
import android.os.Process;
import android.text.TextUtils;
import java.io.BufferedReader;
import java.io.FileReader;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes2.dex */
public abstract class l0 {
    public static String a(Context context) {
        String strB = b();
        if (!TextUtils.isEmpty(strB)) {
            return strB;
        }
        String strA = a();
        return !TextUtils.isEmpty(strA) ? strA : b(context);
    }

    public static String b() {
        if (Build.VERSION.SDK_INT >= 28) {
            return Application.getProcessName();
        }
        return null;
    }

    public static boolean c(Context context) {
        String strA = a(context);
        if (context == null || strA == null) {
            return true;
        }
        return context.getPackageName().equals(strA);
    }

    public static String b(Context context) {
        if (context == null) {
            return null;
        }
        return a(Process.myPid());
    }

    public static String a() {
        try {
            Method declaredMethod = Class.forName("android.app.ActivityThread", false, Application.class.getClassLoader()).getDeclaredMethod("currentProcessName", null);
            declaredMethod.setAccessible(true);
            Object objInvoke = declaredMethod.invoke(null, null);
            if (objInvoke instanceof String) {
                return (String) objInvoke;
            }
            return null;
        } catch (Throwable th) {
            th.printStackTrace();
            return null;
        }
    }

    public static String a(int i) {
        try {
            BufferedReader bufferedReader = new BufferedReader(new FileReader("/proc/" + i + "/cmdline"));
            try {
                String strTrim = bufferedReader.readLine().replace((char) 0, ' ').trim();
                bufferedReader.close();
                return strTrim;
            } catch (Throwable th) {
                try {
                    bufferedReader.close();
                } catch (Throwable th2) {
                    th.addSuppressed(th2);
                }
                throw th;
            }
        } catch (Throwable th3) {
            th3.printStackTrace();
            return null;
        }
    }
}
