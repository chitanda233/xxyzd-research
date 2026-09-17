package com.cmic.gen.sdk.e;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.IBinder;
import android.os.Parcel;
import com.asus.msa.SupplementaryDID.IDidAidlInterface;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.TimeUnit;

/* JADX INFO: compiled from: AsusOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class a extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2097a;
    private final LinkedBlockingQueue<IBinder> b = new LinkedBlockingQueue<>(1);
    private final ServiceConnection c = new ServiceConnection() { // from class: com.cmic.gen.sdk.e.a.1
        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
        }

        @Override // android.content.ServiceConnection
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            try {
                a.this.b.offer(iBinder, com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
            } catch (Exception unused) {
            }
        }
    };

    a(Context context) {
        this.f2097a = context;
    }

    @Override // com.cmic.gen.sdk.e.j
    public String a() {
        Intent intent = new Intent();
        intent.setAction("com.asus.msa.action.ACCESS_DID");
        intent.setComponent(new ComponentName("com.asus.msa.SupplementaryDID", "com.asus.msa.SupplementaryDID.SupplementaryDIDService"));
        String string = "";
        if (this.f2097a.bindService(intent, this.c, 1)) {
            try {
                IBinder iBinderPoll = this.b.poll(com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
                if (iBinderPoll == null) {
                    return "";
                }
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(IDidAidlInterface.Stub.DESCRIPTOR);
                    iBinderPoll.transact(3, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    string = parcelObtain2.readString();
                    this.f2097a.unbindService(this.c);
                } catch (Throwable unused) {
                }
                parcelObtain.recycle();
                parcelObtain2.recycle();
            } catch (Exception unused2) {
            }
        }
        return string;
    }
}
