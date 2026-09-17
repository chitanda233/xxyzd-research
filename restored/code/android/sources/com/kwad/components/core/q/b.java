package com.kwad.components.core.q;

import com.kwad.sdk.api.core.SpeedLimitApi;
import java.io.InputStream;
import java.util.Collections;
import java.util.Iterator;
import java.util.Set;
import java.util.WeakHashMap;

/* JADX INFO: loaded from: classes3.dex */
public class b {
    private static volatile b akt = null;
    private static volatile int aku = 204800;
    static volatile boolean akv = true;
    static volatile boolean akw = false;
    static volatile Set<c> akx = Collections.synchronizedSet(Collections.newSetFromMap(new WeakHashMap()));

    public static void register() {
        try {
            com.kwad.sdk.service.c.a(SpeedLimitApi.class, a.class);
        } catch (Throwable unused) {
        }
    }

    public static b wr() {
        if (akt == null) {
            synchronized (b.class) {
                if (akt == null) {
                    akt = new b();
                }
            }
        }
        return akt;
    }

    public static void f(boolean z, int i) {
        if (i > 0) {
            aku = i * 1024;
        }
        akv = z;
    }

    private static synchronized InputStream wrap(InputStream inputStream) {
        c cVar;
        cVar = new c(inputStream, aku / (akx.size() + 1));
        akx.add(cVar);
        return cVar;
    }

    public static synchronized void a(c cVar) {
        if (akx.contains(cVar)) {
            akx.remove(cVar);
        }
    }

    public static InputStream wrapInputStream(InputStream inputStream) {
        return wrap(inputStream);
    }

    public static boolean ws() {
        return akv;
    }

    public static int wt() {
        return aku / 1024;
    }

    public final synchronized int wu() {
        int iWv;
        iWv = 0;
        try {
            Iterator<c> it = akx.iterator();
            while (it.hasNext()) {
                iWv += (int) it.next().wv();
            }
        } catch (Exception unused) {
        }
        return iWv;
    }
}
