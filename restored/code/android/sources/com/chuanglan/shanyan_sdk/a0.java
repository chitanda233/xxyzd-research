package com.chuanglan.shanyan_sdk;

import android.content.Context;

/* JADX INFO: loaded from: classes2.dex */
public class a0 {
    private static a0 e;
    private Context b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private c0 f1963a = Y.a(C0616v.g().e());
    private boolean c = false;
    private boolean d = false;

    private void a(Context context) {
        if (this.f1963a != null && context != null) {
            this.b = context.getApplicationContext();
        }
        boolean zC = c();
        this.c = zC;
        if (zC) {
            this.d = this.f1963a.b(this.b);
        }
    }

    public static a0 b() {
        if (e == null) {
            e = new a0();
        }
        return e;
    }

    private boolean c() {
        c0 c0Var;
        try {
            Context context = this.b;
            if (context != null && (c0Var = this.f1963a) != null) {
                return c0Var.a(context);
            }
            return false;
        } catch (Throwable unused) {
            return false;
        }
    }

    private String b(Context context) {
        a(context);
        if (this.d) {
            return a();
        }
        return null;
    }

    public void c(Context context) {
        try {
            String strA = p0.a(context, v0.f2017a, "-1");
            if (AbstractC0606l.J && "-1".equals(strA)) {
                String strB = b(context);
                Q.c("LogInfoShanYanLogger", "init token dv", strB);
                if (!AbstractC0600f.a(strB) && !"00000000-0000-0000-0000-000000000000".equals(strB)) {
                    p0.b(context, v0.f2017a, strB);
                } else {
                    p0.b(context, v0.f2017a, "-1");
                }
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
    }

    private String a() {
        c0 c0Var;
        try {
            Context context = this.b;
            if (context != null && (c0Var = this.f1963a) != null && this.d) {
                return c0Var.c(context);
            }
            return null;
        } catch (Throwable unused) {
            return null;
        }
    }
}
