package com.bytedance.ads.convert.flat.j;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;

/* JADX INFO: loaded from: classes2.dex */
public interface g extends IInterface {

    public static abstract class a extends Binder implements g {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final /* synthetic */ int f1718a = 0;

        /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.j.g$a$a, reason: collision with other inner class name */
        public static class C0332a implements g {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f1719a;

            public C0332a(IBinder iBinder) {
                this.f1719a = iBinder;
            }

            @Override // com.bytedance.ads.convert.flat.j.g
            public String a(String str, String str2, String str3) {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken("com.heytap.openid.IOpenID");
                    parcelObtain.writeString(str);
                    parcelObtain.writeString(str2);
                    parcelObtain.writeString(str3);
                    this.f1719a.transact(1, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f1719a;
            }
        }
    }

    String a(String str, String str2, String str3);
}
