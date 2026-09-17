package com.tencent.turingfd.sdk.ams.ad;

import android.app.Application;
import android.os.HandlerThread;
import java.util.WeakHashMap;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.extends, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public abstract class Cextends {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final WeakHashMap f3926a = new WeakHashMap();
    public static final AtomicReference b = new AtomicReference(null);

    public static synchronized void a(Grapefruit grapefruit) {
        if (grapefruit != null) {
            Application applicationB = Ccatch.b();
            if (applicationB != null) {
                AtomicReference atomicReference = b;
                synchronized (atomicReference) {
                    if (atomicReference.get() != null) {
                        return;
                    }
                    HandlerThread handlerThread = new HandlerThread("TuringDispatch");
                    handlerThread.start();
                    Cdefault cdefault = new Cdefault(new Cstatic(handlerThread.getLooper(), grapefruit));
                    atomicReference.set(cdefault);
                    applicationB.registerActivityLifecycleCallbacks(cdefault);
                }
            }
        }
    }
}
