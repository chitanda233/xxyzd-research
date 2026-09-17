package com.tencent.turingfd.sdk.ams.ad;

import android.os.Message;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public final class White {
    public static final Vermillion c = new Vermillion();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Watermelon f3907a = null;
    public final AtomicBoolean b = new AtomicBoolean(false);

    public final synchronized h0 a(int i, int i2, int i3, byte[] bArr, Leo leo) {
        AtomicReference atomicReference;
        if (!this.b.get()) {
            throw new RuntimeException("Must call after initialized");
        }
        Object obj = new Object();
        atomicReference = new AtomicReference();
        AtomicBoolean atomicBoolean = new AtomicBoolean(false);
        g0 g0Var = new g0();
        g0Var.f3931a = -4;
        atomicReference.set(new h0(g0Var));
        Walnut walnut = new Walnut(atomicBoolean, atomicReference, obj);
        Watermelon watermelon = this.f3907a;
        e0 e0Var = new e0(i, i2, i3);
        e0Var.d = null;
        e0Var.e = bArr;
        e0Var.f = null;
        e0Var.f3924a = walnut;
        e0Var.g = leo;
        Message.obtain(watermelon, 2, new f0(e0Var)).sendToTarget();
        synchronized (obj) {
            try {
                obj.wait(200000L);
            } catch (InterruptedException unused) {
            }
        }
        atomicBoolean.set(true);
        return (h0) atomicReference.get();
    }
}
