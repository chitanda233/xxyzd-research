package com.bytedance.ads.convert.flat.j;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;

/* JADX INFO: loaded from: classes2.dex */
public interface c extends IInterface {

    public static abstract class a extends Binder implements c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final /* synthetic */ int f1712a = 0;

        /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.j.c$a$a, reason: collision with other inner class name */
        public static class C0329a implements c {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f1713a;

            public C0329a(IBinder iBinder) {
                this.f1713a = iBinder;
            }

            @Override // com.bytedance.ads.convert.flat.j.c
            public String a() {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(com.alipay.sdk.m.v0.a.AbstractBinderC0052a.f368a);
                    this.f1713a.transact(1, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f1713a;
            }
        }
    }

    String a();
}
