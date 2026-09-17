package com.bytedance.ads.convert.flat.j;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;

/* JADX INFO: loaded from: classes2.dex */
public interface i extends IInterface {

    public static abstract class a extends Binder implements i {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final /* synthetic */ int f1722a = 0;

        /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.j.i$a$a, reason: collision with other inner class name */
        public static class C0334a implements i {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f1723a;

            public C0334a(IBinder iBinder) {
                this.f1723a = iBinder;
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f1723a;
            }

            @Override // com.bytedance.ads.convert.flat.j.i
            public boolean b() {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(com.alipay.sdk.m.d.b.f273a);
                    this.f1723a.transact(2, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readInt() != 0;
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // com.bytedance.ads.convert.flat.j.i
            public String c() {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(com.alipay.sdk.m.d.b.f273a);
                    this.f1723a.transact(1, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }
        }
    }

    boolean b();

    String c();
}
