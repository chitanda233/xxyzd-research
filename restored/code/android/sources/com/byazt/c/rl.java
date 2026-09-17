package com.byazt.c;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;
import android.os.RemoteException;

/* JADX INFO: loaded from: classes.dex */
public interface rl extends IInterface {
    boolean c(gt gtVar) throws RemoteException;

    @com.byazt.zqa.c(c = {0, 1, 20, 782})
    public static abstract class c extends Binder implements rl {
        @Override // android.os.IInterface
        public IBinder asBinder() {
            return this;
        }

        public c() {
            attachInterface(this, "com.ss.android.socialbase.downloader.depend.IDownloadForbiddenAidlHandler");
        }

        public static rl c(IBinder iBinder) {
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface("com.ss.android.socialbase.downloader.depend.IDownloadForbiddenAidlHandler");
            if (iInterfaceQueryLocalInterface != null && (iInterfaceQueryLocalInterface instanceof rl)) {
                return (rl) iInterfaceQueryLocalInterface;
            }
            return new C0083c(iBinder);
        }

        @Override // android.os.Binder
        public boolean onTransact(int i, Parcel parcel, Parcel parcel2, int i2) throws RemoteException {
            if (i != 1) {
                if (i == 1598968902) {
                    parcel2.writeString("com.ss.android.socialbase.downloader.depend.IDownloadForbiddenAidlHandler");
                    return true;
                }
                return super.onTransact(i, parcel, parcel2, i2);
            }
            parcel.enforceInterface("com.ss.android.socialbase.downloader.depend.IDownloadForbiddenAidlHandler");
            boolean zC = c(gt.c.c(parcel.readStrongBinder()));
            parcel2.writeNoException();
            parcel2.writeInt(zC ? 1 : 0);
            return true;
        }

        /* JADX INFO: renamed from: com.byazt.c.rl$c$c, reason: collision with other inner class name */
        @com.byazt.zqa.c(c = {0, 1, 20, 1952})
        private static class C0083c implements rl {
            public static rl c;
            public IBinder tt;

            public C0083c(IBinder iBinder) {
                this.tt = iBinder;
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.tt;
            }

            @Override // com.byazt.c.rl
            public boolean c(gt gtVar) throws RemoteException {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken("com.ss.android.socialbase.downloader.depend.IDownloadForbiddenAidlHandler");
                    parcelObtain.writeStrongBinder(gtVar != null ? gtVar.asBinder() : null);
                    if (!this.tt.transact(1, parcelObtain, parcelObtain2, 0) && c.c() != null) {
                        return c.c().c(gtVar);
                    }
                    parcelObtain2.readException();
                    return parcelObtain2.readInt() != 0;
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }
        }

        public static rl c() {
            return C0083c.c;
        }
    }
}
