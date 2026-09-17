package com.tencent.turingfd.sdk.ams.ad;

import android.os.Handler;
import android.os.Message;
import java.lang.reflect.Method;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.else, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Celse implements Handler.Callback {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Handler.Callback f3925a;
    public final Cdefault b;
    public final String c;

    public Celse(Handler.Callback callback, Cdefault cdefault, String str) {
        this.f3925a = callback;
        this.b = cdefault;
        this.c = str;
    }

    public static boolean a(Message message) {
        Object objA;
        Object obj = message.obj;
        if (obj == null) {
            return false;
        }
        Object objA2 = Filbert.a(obj.getClass(), "argi3", message.obj);
        if (!(objA2 instanceof Integer) || (objA = Filbert.a(message.obj.getClass(), "arg1", message.obj)) == null) {
            return false;
        }
        Class<?> cls = objA.getClass();
        Class[] clsArr = {Boolean.TYPE, Integer.TYPE};
        Object[] objArr = {Boolean.FALSE, objA2};
        try {
            Method methodA = Filbert.a((Class) cls, "setPerformAccessibilityActionResult", clsArr);
            if (methodA != null) {
                methodA.invoke(objA, objArr);
            }
        } catch (Throwable unused) {
        }
        return true;
    }

    /* JADX WARN: Code restructure failed: missing block: B:15:0x0031, code lost:
    
        if (com.tencent.turingfd.sdk.ams.ad.Cassiopeia.c.get() != false) goto L16;
     */
    @Override // android.os.Handler.Callback
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    public final boolean handleMessage(android.os.Message r6) {
        /*
            r5 = this;
            r0 = 0
            int r1 = r6.what     // Catch: java.lang.Throwable -> L3d
            r2 = 1
            if (r1 != r2) goto L2b
            com.tencent.turingfd.sdk.ams.ad.default r1 = r5.b     // Catch: java.lang.Throwable -> L3d
            java.lang.String r3 = r5.c     // Catch: java.lang.Throwable -> L3d
            java.util.concurrent.atomic.AtomicBoolean r4 = r1.f3922a     // Catch: java.lang.Throwable -> L3d
            boolean r4 = r4.get()     // Catch: java.lang.Throwable -> L3d
            if (r4 == 0) goto L13
            goto L1c
        L13:
            com.tencent.turingfd.sdk.ams.ad.static r1 = r1.b     // Catch: java.lang.Throwable -> L3d
            android.os.Message r1 = r1.obtainMessage(r2, r3)     // Catch: java.lang.Throwable -> L3d
            r1.sendToTarget()     // Catch: java.lang.Throwable -> L3d
        L1c:
            java.util.concurrent.atomic.AtomicBoolean r1 = com.tencent.turingfd.sdk.ams.ad.Cassiopeia.b     // Catch: java.lang.Throwable -> L3d
            boolean r1 = r1.get()     // Catch: java.lang.Throwable -> L3d
            if (r1 == 0) goto L34
            boolean r1 = a(r6)     // Catch: java.lang.Throwable -> L3d
            if (r1 == 0) goto L34
            goto L33
        L2b:
            java.util.concurrent.atomic.AtomicBoolean r1 = com.tencent.turingfd.sdk.ams.ad.Cassiopeia.c     // Catch: java.lang.Throwable -> L3d
            boolean r1 = r1.get()     // Catch: java.lang.Throwable -> L3d
            if (r1 == 0) goto L34
        L33:
            return r2
        L34:
            android.os.Handler$Callback r1 = r5.f3925a     // Catch: java.lang.Throwable -> L3d
            if (r1 == 0) goto L3d
            boolean r6 = r1.handleMessage(r6)     // Catch: java.lang.Throwable -> L3d
            return r6
        L3d:
            return r0
        */
        throw new UnsupportedOperationException("Method not decompiled: com.tencent.turingfd.sdk.ams.ad.Celse.handleMessage(android.os.Message):boolean");
    }
}
