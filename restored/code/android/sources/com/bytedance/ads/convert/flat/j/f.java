package com.bytedance.ads.convert.flat.j;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;

/* JADX INFO: loaded from: classes2.dex */
public interface f extends IInterface {

    public static abstract class a extends Binder implements f {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public static final /* synthetic */ int f1716a = 0;

        /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.j.f$a$a, reason: collision with other inner class name */
        public static class C0331a implements f {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f1717a;

            public C0331a(IBinder iBinder) {
                this.f1717a = iBinder;
            }

            @Override // com.bytedance.ads.convert.flat.j.f
            public void a(e eVar) {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken("com.hihonor.cloudservice.oaid.IOAIDService");
                    parcelObtain.writeStrongBinder(eVar != null ? (e.a) eVar : null);
                    if (!this.f1717a.transact(3, parcelObtain, parcelObtain2, 0)) {
                        int i = a.f1716a;
                    }
                    parcelObtain2.readException();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f1717a;
            }

            @Override // com.bytedance.ads.convert.flat.j.f
            public void b(e eVar) {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken("com.hihonor.cloudservice.oaid.IOAIDService");
                    parcelObtain.writeStrongBinder(eVar != null ? (e.a) eVar : null);
                    if (!this.f1717a.transact(2, parcelObtain, parcelObtain2, 0)) {
                        int i = a.f1716a;
                    }
                    parcelObtain2.readException();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }
        }
    }

    void a(e eVar);

    void b(e eVar);
}
