package com.cmic.gen.sdk.e;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.IBinder;
import android.os.Parcel;
import com.bun.lib.MsaIdInterface;
import com.bun.miitmdid.content.StringValues;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.TimeUnit;

/* JADX INFO: compiled from: ZteOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class p extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2116a;
    private final LinkedBlockingQueue<IBinder> b = new LinkedBlockingQueue<>(1);
    private final ServiceConnection c = new ServiceConnection() { // from class: com.cmic.gen.sdk.e.p.1
        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
        }

        @Override // android.content.ServiceConnection
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            try {
                p.this.b.offer(iBinder, com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
            } catch (InterruptedException unused) {
            }
        }
    };

    p(Context context) {
        this.f2116a = context;
    }

    @Override // com.cmic.gen.sdk.e.j
    public String a() {
        Intent intent = new Intent();
        intent.setClassName("com.mdid.msa", "com.mdid.msa.service.MsaIdService");
        intent.setAction(StringValues.ACTION_BINDTO_MSASERVICE);
        intent.putExtra(StringValues.PARAM_BIND_PKGNAME, this.f2116a.getPackageName());
        if (this.f2116a.bindService(intent, this.c, 1)) {
            try {
                IBinder iBinderPoll = this.b.poll(com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
                if (iBinderPoll == null) {
                    return "";
                }
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(MsaIdInterface.Stub.DESCRIPTOR);
                    iBinderPoll.transact(3, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    String string = parcelObtain2.readString();
                    parcelObtain.recycle();
                    parcelObtain2.recycle();
                    return string;
                } catch (Throwable unused) {
                    parcelObtain.recycle();
                    parcelObtain2.recycle();
                    this.f2116a.unbindService(this.c);
                }
            } catch (Exception unused2) {
            }
        }
        return "";
    }
}
