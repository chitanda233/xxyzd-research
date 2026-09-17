package com.bytedance.ads.convert.flat.j;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;

/* JADX INFO: loaded from: classes2.dex */
public interface b extends IInterface {

    public static abstract class a extends Binder implements b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final /* synthetic */ int f1710a = 0;

        /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.j.b$a$a, reason: collision with other inner class name */
        public static class C0328a implements b {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f1711a;

            public C0328a(IBinder iBinder) {
                this.f1711a = iBinder;
            }

            @Override // com.bytedance.ads.convert.flat.j.b
            public String a() {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken("com.samsung.android.deviceidservice.IDeviceIdService");
                    this.f1711a.transact(1, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f1711a;
            }
        }
    }

    String a();
}
