package com.tencent.turingfd.sdk.ams.ad;

import android.content.ComponentName;
import android.content.ServiceConnection;
import android.os.IBinder;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes4.dex */
public final class Cherry implements ServiceConnection {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ AtomicReference f3838a;
    public final /* synthetic */ AtomicReference b;
    public final /* synthetic */ Object c;

    public Cherry(AtomicReference atomicReference, AtomicReference atomicReference2, Object obj) {
        this.f3838a = atomicReference;
        this.b = atomicReference2;
        this.c = obj;
    }

    @Override // android.content.ServiceConnection
    public final void onServiceConnected(ComponentName componentName, IBinder iBinder) {
        this.f3838a.set(iBinder);
        this.b.set(this);
        synchronized (this.c) {
            try {
                this.c.notifyAll();
            } catch (Throwable unused) {
            }
        }
    }

    @Override // android.content.ServiceConnection
    public final void onServiceDisconnected(ComponentName componentName) {
    }
}
