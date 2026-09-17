package com.tencent.turingfd.sdk.ams.ad;

import java.io.IOException;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Pomelo {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static volatile n0 f3882a;

    public static n0 a() {
        try {
            return new n0();
        } catch (Exception unused) {
            return null;
        }
    }

    public static void a(Exception exc) {
        if (((exc instanceof IOException) || (exc instanceof InterruptedException)) && f3882a != null) {
            synchronized (Pomelo.class) {
                if (f3882a != null) {
                    n0 n0Var = f3882a;
                    n0Var.getClass();
                    try {
                        n0Var.a();
                    } catch (Throwable unused) {
                    }
                    f3882a = null;
                }
            }
        }
    }

    public static l0 a(String str) {
        l0 l0VarA;
        m0 m0Var = new m0(str, str, 5000L);
        try {
            if (f3882a == null) {
                synchronized (Pomelo.class) {
                    if (f3882a == null) {
                        f3882a = a();
                    }
                }
            }
            l0VarA = f3882a.a(m0Var);
        } catch (Exception e) {
            a(e);
            l0VarA = null;
        }
        return l0VarA == null ? new l0("", "e") : l0VarA;
    }
}
