package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.ServiceConnection;
import android.os.IBinder;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public final class Chestnut extends Thread {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ AtomicReference f3839a;
    public final /* synthetic */ AtomicReference b;
    public final /* synthetic */ AtomicReference c;
    public final /* synthetic */ Context d;
    public final /* synthetic */ AtomicReference e;
    public final /* synthetic */ Object f;
    public final /* synthetic */ Coconut g;

    public Chestnut(Coconut coconut, AtomicReference atomicReference, AtomicReference atomicReference2, AtomicReference atomicReference3, Context context, AtomicReference atomicReference4, Object obj) {
        this.g = coconut;
        this.f3839a = atomicReference;
        this.b = atomicReference2;
        this.c = atomicReference3;
        this.d = context;
        this.e = atomicReference4;
        this.f = obj;
    }

    @Override // java.lang.Thread, java.lang.Runnable
    public final void run() {
        String strA = "";
        try {
            strA = this.g.a((IBinder) this.f3839a.get());
        } catch (Throwable unused) {
            this.b.set(-102);
        }
        this.c.set(strA);
        try {
            this.d.unbindService((ServiceConnection) this.e.get());
        } catch (Throwable unused2) {
            this.b.set(-103);
        }
        synchronized (this.f) {
            try {
                this.f.notifyAll();
            } catch (Throwable unused3) {
            }
        }
    }
}
