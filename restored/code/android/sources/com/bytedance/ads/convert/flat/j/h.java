package com.bytedance.ads.convert.flat.j;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;
import com.bun.lib.MsaIdInterface;

/* JADX INFO: loaded from: classes2.dex */
public interface h extends IInterface {

    public static abstract class a extends Binder implements h {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final /* synthetic */ int f1720a = 0;

        /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.j.h$a$a, reason: collision with other inner class name */
        public static class C0333a implements h {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f1721a;

            public C0333a(IBinder iBinder) {
                this.f1721a = iBinder;
            }

            @Override // com.bytedance.ads.convert.flat.j.h
            public String a() {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(MsaIdInterface.Stub.DESCRIPTOR);
                    if (!this.f1721a.transact(1, parcelObtain, parcelObtain2, 0)) {
                        int i = a.f1720a;
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
                return this.f1721a;
            }
        }
    }

    String a();
}
