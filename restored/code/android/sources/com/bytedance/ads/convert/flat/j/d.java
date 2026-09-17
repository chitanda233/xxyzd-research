package com.bytedance.ads.convert.flat.j;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;
import com.asus.msa.SupplementaryDID.IDidAidlInterface;

/* JADX INFO: loaded from: classes2.dex */
public interface d extends IInterface {

    public static abstract class a extends Binder implements d {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final /* synthetic */ int f1714a = 0;

        /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.j.d$a$a, reason: collision with other inner class name */
        public static class C0330a implements d {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f1715a;

            public C0330a(IBinder iBinder) {
                this.f1715a = iBinder;
            }

            @Override // com.bytedance.ads.convert.flat.j.d
            public String a() {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(IDidAidlInterface.Stub.DESCRIPTOR);
                    this.f1715a.transact(3, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f1715a;
            }
        }
    }

    String a();
}
