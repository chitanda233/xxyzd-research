package com.sec.android.app.samsungapps.lib;

import android.os.Binder;
import android.os.Bundle;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;
import android.os.RemoteException;

/* JADX INFO: loaded from: classes3.dex */
public interface IInstallReferrerAgentAPI extends IInterface {

    public static abstract class a extends Binder implements IInstallReferrerAgentAPI {

        /* JADX INFO: renamed from: com.sec.android.app.samsungapps.lib.IInstallReferrerAgentAPI$a$a, reason: collision with other inner class name */
        private static class C0555a implements IInstallReferrerAgentAPI {
            public static IInstallReferrerAgentAPI b;

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            private IBinder f3105a;

            C0555a(IBinder iBinder) {
                this.f3105a = iBinder;
            }

            @Override // com.sec.android.app.samsungapps.lib.IInstallReferrerAgentAPI
            public void a(Bundle bundle, IInstallReferrerAgentResultCallback iInstallReferrerAgentResultCallback) throws RemoteException {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken("com.sec.android.app.samsungapps.lib.IInstallReferrerAgentAPI");
                    if (bundle != null) {
                        parcelObtain.writeInt(1);
                        bundle.writeToParcel(parcelObtain, 0);
                    } else {
                        parcelObtain.writeInt(0);
                    }
                    parcelObtain.writeStrongBinder(iInstallReferrerAgentResultCallback != null ? iInstallReferrerAgentResultCallback.asBinder() : null);
                    if (this.f3105a.transact(1, parcelObtain, parcelObtain2, 0) || a.a() == null) {
                        parcelObtain2.readException();
                    } else {
                        a.a().a(bundle, iInstallReferrerAgentResultCallback);
                    }
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f3105a;
            }
        }

        public static IInstallReferrerAgentAPI a() {
            return C0555a.b;
        }

        public static IInstallReferrerAgentAPI a(IBinder iBinder) {
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface("com.sec.android.app.samsungapps.lib.IInstallReferrerAgentAPI");
            return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof IInstallReferrerAgentAPI)) ? new C0555a(iBinder) : (IInstallReferrerAgentAPI) iInterfaceQueryLocalInterface;
        }
    }

    void a(Bundle bundle, IInstallReferrerAgentResultCallback iInstallReferrerAgentResultCallback) throws RemoteException;
}
