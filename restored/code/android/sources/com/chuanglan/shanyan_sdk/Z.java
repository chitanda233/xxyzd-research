package com.chuanglan.shanyan_sdk;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.IBinder;
import java.util.concurrent.CountDownLatch;

/* JADX INFO: loaded from: classes2.dex */
public class Z implements ServiceConnection {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private H f1962a;
    private String b;
    private CountDownLatch c;
    private IBinder d;

    Z(String str, CountDownLatch countDownLatch) {
        this.b = str;
        this.c = countDownLatch;
    }

    public H a() {
        return this.f1962a;
    }

    @Override // android.content.ServiceConnection
    public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
        try {
            this.d = iBinder;
            this.c.countDown();
        } catch (Throwable unused) {
        }
    }

    @Override // android.content.ServiceConnection
    public void onServiceDisconnected(ComponentName componentName) {
        this.f1962a = null;
        this.d = null;
    }

    public boolean a(Context context, Intent intent) {
        if (context == null) {
            return false;
        }
        if (this.f1962a != null) {
            return true;
        }
        try {
            boolean zBindService = context.bindService(intent, this, 1);
            this.c.await();
            this.f1962a = H.a(this.d, this.b);
            return zBindService;
        } catch (Throwable unused) {
            return false;
        }
    }
}
