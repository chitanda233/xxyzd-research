package com.bytedance.ads.convert.flat.j;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;

/* JADX INFO: loaded from: classes2.dex */
public interface a extends IInterface {

    /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.j.a$a, reason: collision with other inner class name */
    public static abstract class AbstractBinderC0326a extends Binder implements a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final /* synthetic */ int f1708a = 0;

        /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.j.a$a$a, reason: collision with other inner class name */
        public static class C0327a implements a {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f1709a;

            public C0327a(IBinder iBinder) {
                this.f1709a = iBinder;
            }

            @Override // com.bytedance.ads.convert.flat.j.a
            public String a(String str) {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken("com.coolpad.deviceidsupport.IDeviceIdManager");
                    parcelObtain.writeString(str);
                    if (!this.f1709a.transact(2, parcelObtain, parcelObtain2, 0)) {
                        int i = AbstractBinderC0326a.f1708a;
                    }
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f1709a;
            }
        }
    }

    String a(String str);
}
