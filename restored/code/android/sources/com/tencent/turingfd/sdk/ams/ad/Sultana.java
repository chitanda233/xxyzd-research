package com.tencent.turingfd.sdk.ams.ad;

import android.content.ComponentName;
import android.content.ServiceConnection;
import android.os.IBinder;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public final class Sultana implements ServiceConnection {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ AtomicReference f3896a;
    public final /* synthetic */ long b;
    public final /* synthetic */ Object c;

    public Sultana(AtomicReference atomicReference, long j, Object obj) {
        this.f3896a = atomicReference;
        this.b = j;
        this.c = obj;
    }

    @Override // android.content.ServiceConnection
    public final void onServiceConnected(ComponentName componentName, IBinder iBinder) {
        new Sugarcane(this, iBinder).start();
    }

    @Override // android.content.ServiceConnection
    public final void onServiceDisconnected(ComponentName componentName) {
        this.f3896a.set(new Segment(-2004, 200, -1L, "", -1, -3));
        synchronized (this.c) {
            this.c.notify();
        }
    }
}
