package com.tencent.turingfd.sdk.ams.ad;

import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public final class s0 implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ AtomicBoolean f3960a;
    public final /* synthetic */ AtomicReference b;
    public final /* synthetic */ Object c;

    public s0(AtomicBoolean atomicBoolean, AtomicReference atomicReference, Object obj) {
        this.f3960a = atomicBoolean;
        this.b = atomicReference;
        this.c = obj;
    }

    @Override // java.lang.Runnable
    public final void run() {
        if (this.f3960a.get()) {
            return;
        }
        try {
            throw new Exception("");
        } catch (Exception e) {
            String strA = Cinstanceof.a(Cinstanceof.D0);
            for (StackTraceElement stackTraceElement : e.getStackTrace()) {
                if (strA.equals(stackTraceElement.getClassName() + "_" + stackTraceElement.getMethodName())) {
                    this.b.set(Boolean.TRUE);
                }
            }
            synchronized (this.c) {
                this.c.notify();
            }
        }
    }
}
