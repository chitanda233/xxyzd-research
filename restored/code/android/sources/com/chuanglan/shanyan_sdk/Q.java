package com.chuanglan.shanyan_sdk;

import android.util.Log;
import com.baidu.mobads.sdk.api.IAdInterListener;
import com.chuanglan.shanyan_sdk.listener.OneKeyLoginLogListener;

/* JADX INFO: loaded from: classes2.dex */
public abstract class Q {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static OneKeyLoginLogListener f1954a;

    public static void a(OneKeyLoginLogListener oneKeyLoginLogListener) {
        f1954a = oneKeyLoginLogListener;
    }

    public static void b(String str, Object... objArr) {
        String strA = a(objArr);
        if (P.f1953a) {
            Log.e(str, strA);
        }
        OneKeyLoginLogListener oneKeyLoginLogListener = f1954a;
        if (oneKeyLoginLogListener != null) {
            oneKeyLoginLogListener.onLog("e", str, strA);
        }
    }

    public static void c(String str, Object... objArr) {
        String strA = a(objArr);
        if (P.b) {
            Log.v(str, strA);
            OneKeyLoginLogListener oneKeyLoginLogListener = f1954a;
            if (oneKeyLoginLogListener != null) {
                oneKeyLoginLogListener.onLog(com.kuaishou.weapon.p0.t.c, str, strA);
            }
        }
    }

    public static void d(String str, Object... objArr) {
        String strA = a(objArr);
        if (P.f1953a) {
            Log.w(str, strA);
        }
        OneKeyLoginLogListener oneKeyLoginLogListener = f1954a;
        if (oneKeyLoginLogListener != null) {
            oneKeyLoginLogListener.onLog(IAdInterListener.AdReqParam.WIDTH, str, strA);
        }
    }

    public static void a(String str, Object... objArr) {
        String strA = a(objArr);
        if (P.f1953a) {
            Log.d(str, strA);
        }
        OneKeyLoginLogListener oneKeyLoginLogListener = f1954a;
        if (oneKeyLoginLogListener != null) {
            oneKeyLoginLogListener.onLog(com.kuaishou.weapon.p0.t.t, str, strA);
        }
    }

    private static String a(Object... objArr) {
        StringBuilder sb = new StringBuilder();
        if (objArr != null) {
            try {
                for (Object obj : objArr) {
                    sb.append(obj);
                    sb.append("**");
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        return sb.toString();
    }
}
