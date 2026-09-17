package com.cmic.gen.sdk.e;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.IBinder;
import android.os.Parcel;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.TimeUnit;

/* JADX INFO: compiled from: LenovoOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class f extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2105a;
    private final LinkedBlockingQueue<IBinder> b = new LinkedBlockingQueue<>(1);
    private final ServiceConnection c = new ServiceConnection() { // from class: com.cmic.gen.sdk.e.f.1
        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
        }

        @Override // android.content.ServiceConnection
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            try {
                f.this.b.offer(iBinder, com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
            } catch (InterruptedException unused) {
            }
        }
    };

    f(Context context) {
        this.f2105a = context;
    }

    @Override // com.cmic.gen.sdk.e.j
    public String a() {
        Intent intent = new Intent();
        intent.setClassName("com.zui.deviceidservice", "com.zui.deviceidservice.DeviceidService");
        String string = "";
        if (this.f2105a.bindService(intent, this.c, 1)) {
            Parcel parcelObtain = Parcel.obtain();
            Parcel parcelObtain2 = Parcel.obtain();
            try {
                IBinder iBinderPoll = this.b.poll(com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
                if (iBinderPoll == null) {
                    return "";
                }
                parcelObtain.writeInterfaceToken(com.alipay.sdk.m.v0.a.AbstractBinderC0052a.f368a);
                iBinderPoll.transact(1, parcelObtain, parcelObtain2, 0);
                parcelObtain2.readException();
                string = parcelObtain2.readString();
            } catch (Exception unused) {
            } finally {
                parcelObtain2.recycle();
                parcelObtain.recycle();
                this.f2105a.unbindService(this.c);
            }
        }
        return string;
    }
}
