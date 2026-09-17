package com.tencent.turingfd.sdk.ams.ad;

import android.content.ComponentName;
import android.content.ServiceConnection;
import android.os.IBinder;
import java.util.concurrent.LinkedBlockingQueue;

/* JADX INFO: loaded from: classes4.dex */
public final class Cepheus implements ServiceConnection {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public boolean f3836a = false;
    public final LinkedBlockingQueue b = new LinkedBlockingQueue(1);

    public final IBinder a() {
        if (this.f3836a) {
            throw new IllegalStateException();
        }
        this.f3836a = true;
        return (IBinder) this.b.take();
    }

    @Override // android.content.ServiceConnection
    public final void onServiceConnected(ComponentName componentName, IBinder iBinder) {
        try {
            this.b.put(iBinder);
        } catch (InterruptedException unused) {
        }
    }

    @Override // android.content.ServiceConnection
    public final void onServiceDisconnected(ComponentName componentName) {
    }
}
