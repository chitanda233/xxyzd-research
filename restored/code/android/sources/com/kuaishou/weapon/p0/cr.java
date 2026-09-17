package com.kuaishou.weapon.p0;

import android.os.Build;
import com.kuaishou.weapon.p0.jni.Engine;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes3.dex */
public class cr {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static int f2686a;
    private static boolean b;

    public cr() {
        b();
    }

    private void b() {
        if (!Engine.loadSuccess || b) {
            return;
        }
        boolean zB = cp.b();
        int i = Build.VERSION.SDK_INT;
        if (zB && i < 29) {
            f2686a = Engine.off();
        }
        b = true;
    }

    private boolean c() {
        return b && f2686a > 1;
    }

    private int a(Method method) {
        try {
            int i = f2686a;
            if (i <= 1 || method == null) {
                return 0;
            }
            return Engine.mmo(method, i, method.getModifiers());
        } catch (Exception unused) {
            return 0;
        }
    }

    public int a(Class cls, String str, Object... objArr) {
        try {
            if (c()) {
                return a(df.a(cls, str, objArr));
            }
            return 0;
        } catch (Exception unused) {
            return 0;
        }
    }

    public int a(int i, Class cls, String str, Object... objArr) {
        Method methodA;
        try {
            if (!c() || (methodA = df.a(cls, str, objArr)) == null) {
                return 0;
            }
            return Engine.mqc(methodA, i);
        } catch (Exception unused) {
            return 0;
        }
    }

    public int a() {
        if (!c()) {
            return -1;
        }
        long jA = co.b.a();
        long jA2 = co.f2682a.a();
        if (f2686a == jA) {
            return (int) jA2;
        }
        return -1;
    }
}
