package com.tencent.turingfd.sdk.ams.ad;

import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Cumquat {
    public static String a(String str) {
        try {
            Method method = Class.forName("android.os.SystemProperties").getMethod("get", String.class);
            method.setAccessible(true);
            String str2 = (String) method.invoke(null, str);
            return str2 == null ? "" : str2;
        } catch (Throwable unused) {
            return "";
        }
    }
}
