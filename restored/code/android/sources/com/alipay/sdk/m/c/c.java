package com.alipay.sdk.m.c;

import android.content.Context;
import android.os.Looper;

/* JADX INFO: loaded from: classes.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static b f250a = null;
    public static boolean b = false;

    public static synchronized String a(Context context) {
        try {
            if (context == null) {
                throw new RuntimeException("Context is null");
            }
            if (Looper.myLooper() == Looper.getMainLooper()) {
                throw new IllegalStateException("Cannot be called from the main thread");
            }
            b(context);
            b bVar = f250a;
            if (bVar != null) {
                try {
                    return bVar.a(context);
                } catch (Exception unused) {
                }
            }
            return null;
        } catch (Throwable th) {
            throw th;
        }
    }

    public static void b(Context context) {
        if (f250a != null || b) {
            return;
        }
        synchronized (c.class) {
            if (f250a == null && !b) {
                f250a = com.alipay.sdk.m.d.a.a(context);
                b = true;
            }
        }
    }
}
