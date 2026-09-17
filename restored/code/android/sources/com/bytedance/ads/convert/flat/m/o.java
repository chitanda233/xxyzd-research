package com.bytedance.ads.convert.flat.m;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.IBinder;
import java.util.concurrent.CountDownLatch;

/* JADX INFO: loaded from: classes2.dex */
public final class o<SERVICE, RESULT> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final CountDownLatch f1740a = new CountDownLatch(1);
    public final Intent b;
    public final b<SERVICE, RESULT> c;
    public final Context d;

    public class a implements ServiceConnection {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public final CountDownLatch f1741a;
        public final b<SERVICE, RESULT> b;
        public SERVICE c;

        public a(o oVar, CountDownLatch countDownLatch, b<SERVICE, RESULT> bVar) {
            this.f1741a = countDownLatch;
            this.b = bVar;
        }

        @Override // android.content.ServiceConnection
        public void onBindingDied(ComponentName componentName) {
        }

        @Override // android.content.ServiceConnection
        public void onNullBinding(ComponentName componentName) {
        }

        @Override // android.content.ServiceConnection
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            StringBuilder sb;
            String str = "Oaid#ServiceBlockBinder#onServiceConnected " + componentName;
            try {
                this.c = this.b.a(iBinder);
                try {
                    this.f1741a.countDown();
                } catch (Exception e) {
                    e = e;
                    sb = new StringBuilder("ServiceBlockBinder# onServiceConnected latch.countDown error: ");
                    StringBuilder sbAppend = sb.append(e.getMessage());
                }
            } catch (Throwable th) {
                try {
                    String str2 = "ServiceBlockBinder# onServiceConnected error: " + th.getMessage();
                    try {
                        this.f1741a.countDown();
                    } catch (Exception e2) {
                        e = e2;
                        sb = new StringBuilder("ServiceBlockBinder# onServiceConnected latch.countDown error: ");
                        StringBuilder sbAppend2 = sb.append(e.getMessage());
                    }
                } finally {
                    try {
                        this.f1741a.countDown();
                    } catch (Exception e3) {
                        String str3 = "ServiceBlockBinder# onServiceConnected latch.countDown error: " + e3.getMessage();
                    }
                }
            }
        }

        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
            String str = "Oaid#ServiceBlockBinder#onServiceDisconnected" + componentName;
            try {
                this.f1741a.countDown();
            } catch (Exception e) {
                String str2 = "ServiceBlockBinder# onServiceDisconnected latch.countDown error: " + e.getMessage();
            }
        }
    }

    public interface b<T, RESULT> {
        T a(IBinder iBinder);

        RESULT a(T t);
    }

    public o(Context context, Intent intent, b<SERVICE, RESULT> bVar) {
        this.d = context;
        this.b = intent;
        this.c = bVar;
    }

    public RESULT a() {
        Throwable th;
        o<SERVICE, RESULT>.a aVar;
        try {
            try {
                aVar = new a(this, this.f1740a, this.c);
                if (!this.d.bindService(this.b, aVar, 1)) {
                    a(null);
                    return null;
                }
                this.f1740a.await();
                try {
                    RESULT resultA = this.c.a(aVar.c);
                    a(aVar);
                    return resultA;
                } catch (Throwable th2) {
                    th = th2;
                }
            } catch (Throwable th3) {
                th = th3;
                aVar = null;
            }
            String str = "ServiceBlockBinder# blockFetchResult error" + th.getMessage();
            return null;
        } finally {
            a(aVar);
        }
    }

    public final void a(o<SERVICE, RESULT>.a aVar) {
        if (aVar != null) {
            try {
                this.d.unbindService(aVar);
            } catch (Throwable th) {
                String str = "ServiceBlockBinder# oaid release error: " + th.getMessage();
            }
        }
    }
}
