package com.cmic.gen.sdk.e;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.IBinder;
import android.os.Parcel;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.TimeUnit;

/* JADX INFO: compiled from: CoolpadOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class b extends j {
    private final Context b;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final LinkedBlockingQueue<IBinder> f2099a = new LinkedBlockingQueue<>(1);
    private final ServiceConnection c = new ServiceConnection() { // from class: com.cmic.gen.sdk.e.b.1
        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
        }

        @Override // android.content.ServiceConnection
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            try {
                b.this.f2099a.offer(iBinder, com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
            } catch (InterruptedException unused) {
            }
        }
    };

    b(Context context) {
        this.b = context;
    }

    @Override // com.cmic.gen.sdk.e.j
    public String a() {
        Context context;
        Intent intent = new Intent();
        intent.setClassName("com.coolpad.deviceidsupport", "com.coolpad.deviceidsupport.DeviceIdService");
        String string = "";
        if (!this.b.bindService(intent, this.c, 1)) {
            return "";
        }
        try {
            IBinder iBinderPoll = this.f2099a.poll(com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
            if (iBinderPoll == null) {
                return "";
            }
            Parcel parcelObtain = Parcel.obtain();
            Parcel parcelObtain2 = Parcel.obtain();
            try {
                parcelObtain.writeInterfaceToken("com.coolpad.deviceidsupport.IDeviceIdManager");
                iBinderPoll.transact(1, parcelObtain, parcelObtain2, 0);
                parcelObtain2.readException();
                string = parcelObtain2.readString();
                parcelObtain2.recycle();
                parcelObtain.recycle();
                context = this.b;
            } catch (Throwable unused) {
                parcelObtain2.recycle();
                parcelObtain.recycle();
                context = this.b;
            }
            context.unbindService(this.c);
        } catch (InterruptedException unused2) {
        }
        return string;
    }
}
