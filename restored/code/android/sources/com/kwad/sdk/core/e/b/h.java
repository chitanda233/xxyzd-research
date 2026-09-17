package com.kwad.sdk.core.e.b;

import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;
import com.bun.lib.MsaIdInterface;

/* JADX INFO: loaded from: classes3.dex */
public interface h extends IInterface {
    String getOAID();

    public static final class a implements h {
        private IBinder aUQ;

        public a(IBinder iBinder) {
            this.aUQ = iBinder;
        }

        @Override // com.kwad.sdk.core.e.b.h
        public final String getOAID() {
            String string;
            Parcel parcelObtain = Parcel.obtain();
            Parcel parcelObtain2 = Parcel.obtain();
            try {
                try {
                    parcelObtain.writeInterfaceToken(MsaIdInterface.Stub.DESCRIPTOR);
                    this.aUQ.transact(1, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    string = parcelObtain2.readString();
                    parcelObtain.recycle();
                    parcelObtain2.recycle();
                } catch (Exception e) {
                    com.kwad.sdk.core.d.c.printStackTrace(e);
                    parcelObtain.recycle();
                    parcelObtain2.recycle();
                    string = null;
                }
                return string;
            } catch (Throwable th) {
                parcelObtain.recycle();
                parcelObtain2.recycle();
                throw th;
            }
        }

        @Override // android.os.IInterface
        public final IBinder asBinder() {
            return this.aUQ;
        }
    }
}
