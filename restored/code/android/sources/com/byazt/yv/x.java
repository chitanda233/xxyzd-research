package com.byazt.yv;

import android.os.SystemProperties;
import com.byazt.nr.m;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 499, 71})
public class x {
    public static volatile Object c;

    private Object c() {
        if (c == null) {
            synchronized (x.class) {
                if (c == null) {
                    try {
                        c = Class.forName("android.os.SystemProperties").newInstance();
                    } catch (Throwable th) {
                        m.c(th);
                    }
                }
            }
        }
        return c;
    }

    public String c(String str) throws IllegalArgumentException {
        try {
            return SystemProperties.get(str);
        } catch (Throwable th) {
            da.c(th);
            try {
                Object objC = c();
                return (String) objC.getClass().getMethod("get", String.class).invoke(objC, str);
            } catch (Throwable th2) {
                da.c(th2);
                return "";
            }
        }
    }
}
