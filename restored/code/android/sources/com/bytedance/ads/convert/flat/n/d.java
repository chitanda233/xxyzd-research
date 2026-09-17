package com.bytedance.ads.convert.flat.n;

import android.os.SystemProperties;

/* JADX INFO: loaded from: classes2.dex */
public class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static volatile Object f1745a;

    public final Object a() {
        if (f1745a == null) {
            synchronized (d.class) {
                if (f1745a == null) {
                    try {
                        f1745a = Class.forName("android.os.SystemProperties").newInstance();
                    } catch (Throwable th) {
                        th.printStackTrace();
                    }
                }
            }
        }
        return f1745a;
    }

    public String a(String str) {
        try {
            return SystemProperties.get(str);
        } catch (Throwable th) {
            th.printStackTrace();
            try {
                Object objA = a();
                return (String) objA.getClass().getMethod("get", String.class).invoke(objA, str);
            } catch (IllegalArgumentException e) {
                throw e;
            } catch (Throwable unused) {
                return "";
            }
        }
    }
}
