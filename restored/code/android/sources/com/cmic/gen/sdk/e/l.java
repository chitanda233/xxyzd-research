package com.cmic.gen.sdk.e;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.content.pm.Signature;
import android.os.IBinder;
import android.os.Parcel;
import java.security.MessageDigest;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.TimeUnit;
import kotlin.UByte;

/* JADX INFO: compiled from: OppoOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class l extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2110a;
    private final LinkedBlockingQueue<IBinder> b = new LinkedBlockingQueue<>(1);
    private final ServiceConnection c = new ServiceConnection() { // from class: com.cmic.gen.sdk.e.l.1
        @Override // android.content.ServiceConnection
        public void onServiceDisconnected(ComponentName componentName) {
        }

        @Override // android.content.ServiceConnection
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            try {
                l.this.b.offer(iBinder, com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS);
            } catch (Throwable unused) {
            }
        }
    };

    l(Context context) {
        this.f2110a = context;
    }

    @Override // com.cmic.gen.sdk.e.j
    public String a() {
        Intent intent = new Intent();
        intent.setComponent(new ComponentName("com.heytap.openid", "com.heytap.openid.IdentifyService"));
        intent.setAction("action.com.heytap.openid.OPEN_ID_SERVICE");
        String strA = "";
        if (!this.f2110a.bindService(intent, this.c, 1)) {
            return "";
        }
        try {
            strA = a(this.b.poll(com.alipay.sdk.m.y.c.f378a, TimeUnit.MILLISECONDS));
            this.f2110a.unbindService(this.c);
            return strA;
        } catch (Throwable unused) {
            return strA;
        }
    }

    private String a(IBinder iBinder) {
        String string = "";
        if (iBinder == null) {
            return "";
        }
        String packageName = this.f2110a.getPackageName();
        String strA = a(this.f2110a, packageName);
        try {
            Parcel parcelObtain = Parcel.obtain();
            Parcel parcelObtain2 = Parcel.obtain();
            try {
                parcelObtain.writeInterfaceToken("com.heytap.openid.IOpenID");
                parcelObtain.writeString(packageName);
                parcelObtain.writeString(strA);
                parcelObtain.writeString("OUID");
                iBinder.transact(1, parcelObtain, parcelObtain2, 0);
                parcelObtain2.readException();
                string = parcelObtain2.readString();
            } finally {
                parcelObtain.recycle();
                parcelObtain2.recycle();
            }
        } catch (Exception unused) {
        }
        return string;
    }

    private String a(Context context, String str) {
        try {
            Signature[] signatureArr = context.getPackageManager().getPackageInfo(str, 64).signatures;
            if (signatureArr == null || signatureArr.length <= 0) {
                return "";
            }
            byte[] bArrDigest = MessageDigest.getInstance("SHA1").digest(signatureArr[0].toByteArray());
            StringBuilder sb = new StringBuilder();
            for (byte b : bArrDigest) {
                sb.append(Integer.toHexString((b & UByte.MAX_VALUE) | 256).substring(1, 3));
            }
            return sb.toString();
        } catch (Exception unused) {
            return "";
        }
    }
}
