package com.tencent.turingfd.sdk.ams.ad;

import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public final class Walnut {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ AtomicBoolean f3905a;
    public final /* synthetic */ AtomicReference b;
    public final /* synthetic */ Object c;

    public Walnut(AtomicBoolean atomicBoolean, AtomicReference atomicReference, Object obj) {
        this.f3905a = atomicBoolean;
        this.b = atomicReference;
        this.c = obj;
    }

    public final void a(h0 h0Var) {
        if (this.f3905a.get()) {
            return;
        }
        this.b.set(h0Var);
        synchronized (this.c) {
            this.c.notify();
        }
    }
}
