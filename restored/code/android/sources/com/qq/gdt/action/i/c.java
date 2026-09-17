package com.qq.gdt.action.i;

import android.app.Application;
import android.content.Context;
import androidx.core.view.PointerIconCompat;

/* JADX INFO: loaded from: classes3.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile c f3076a;
    private volatile boolean b = false;

    private c() {
    }

    public static c a() {
        if (f3076a == null) {
            synchronized (c.class) {
                if (f3076a == null) {
                    f3076a = new c();
                }
            }
        }
        return f3076a;
    }

    public void a(Context context) {
        try {
            o.a("registerApplicationLifeCallback register = " + this.b, new Object[0]);
            if (this.b) {
                return;
            }
            if (context == null) {
                o.c("传入的Context对象为空，请参考接入文档");
                return;
            }
            if (!(context.getApplicationContext() instanceof Application)) {
                com.qq.gdt.action.g.a.a(PointerIconCompat.TYPE_TEXT);
                o.c("传入的Context对象不是Application类的实例，请参考接入文档");
            } else {
                Application application = (Application) context.getApplicationContext();
                o.a("registerApplicationLifeCallback begin register", new Object[0]);
                application.registerActivityLifecycleCallbacks(new com.qq.gdt.action.f(com.qq.gdt.action.d.a()));
                this.b = true;
            }
        } catch (Throwable th) {
            o.a("registerApplicationLifeCallback", th);
            com.qq.gdt.action.g.a.a(1010);
        }
    }
}
