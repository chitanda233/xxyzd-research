package com.byazt.fp;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;
import android.os.RemoteException;
import com.bun.lib.MsaIdInterface;

/* JADX INFO: loaded from: classes.dex */
public interface a extends IInterface {
    void a() throws RemoteException;

    String c() throws RemoteException;

    boolean n() throws RemoteException;

    String tt() throws RemoteException;

    boolean uj() throws RemoteException;

    String ve() throws RemoteException;

    @com.byazt.zqa.c(c = {0, 1, 218, 464})
    public static abstract class c extends Binder implements a {
        public static a c(IBinder iBinder) {
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(MsaIdInterface.Stub.DESCRIPTOR);
            if (iInterfaceQueryLocalInterface != null && (iInterfaceQueryLocalInterface instanceof a)) {
                return (a) iInterfaceQueryLocalInterface;
            }
            return new C0118c(iBinder);
        }

        @Override // android.os.Binder
        public boolean onTransact(int i, Parcel parcel, Parcel parcel2, int i2) throws RemoteException {
            if (i == 1598968902) {
                parcel2.writeString(MsaIdInterface.Stub.DESCRIPTOR);
                return true;
            }
            switch (i) {
                case 1:
                    parcel.enforceInterface(MsaIdInterface.Stub.DESCRIPTOR);
                    String strC = c();
                    parcel2.writeNoException();
                    parcel2.writeString(strC);
                    return true;
                case 2:
                    parcel.enforceInterface(MsaIdInterface.Stub.DESCRIPTOR);
                    String strTt = tt();
                    parcel2.writeNoException();
                    parcel2.writeString(strTt);
                    return true;
                case 3:
                    parcel.enforceInterface(MsaIdInterface.Stub.DESCRIPTOR);
                    String strVe = ve();
                    parcel2.writeNoException();
                    parcel2.writeString(strVe);
                    return true;
                case 4:
                    parcel.enforceInterface(MsaIdInterface.Stub.DESCRIPTOR);
                    boolean zUj = uj();
                    parcel2.writeNoException();
                    parcel2.writeInt(zUj ? 1 : 0);
                    return true;
                case 5:
                    parcel.enforceInterface(MsaIdInterface.Stub.DESCRIPTOR);
                    boolean zN = n();
                    parcel2.writeNoException();
                    parcel2.writeInt(zN ? 1 : 0);
                    return true;
                case 6:
                    parcel.enforceInterface(MsaIdInterface.Stub.DESCRIPTOR);
                    a();
                    parcel2.writeNoException();
                    return true;
                default:
                    return super.onTransact(i, parcel, parcel2, i2);
            }
        }

        /* JADX INFO: renamed from: com.byazt.fp.a$c$c, reason: collision with other inner class name */
        @com.byazt.zqa.c(c = {0, 1, 218, 999})
        private static class C0118c implements a {
            public static a c;
            public IBinder tt;

            public C0118c(IBinder iBinder) {
                this.tt = iBinder;
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.tt;
            }

            @Override // com.byazt.fp.a
            public String c() throws RemoteException {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(MsaIdInterface.Stub.DESCRIPTOR);
                    if (!this.tt.transact(1, parcelObtain, parcelObtain2, 0) && c.sp() != null) {
                        return c.sp().c();
                    }
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // com.byazt.fp.a
            public String tt() throws RemoteException {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(MsaIdInterface.Stub.DESCRIPTOR);
                    if (!this.tt.transact(2, parcelObtain, parcelObtain2, 0) && c.sp() != null) {
                        return c.sp().tt();
                    }
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // com.byazt.fp.a
            public String ve() throws RemoteException {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(MsaIdInterface.Stub.DESCRIPTOR);
                    if (!this.tt.transact(3, parcelObtain, parcelObtain2, 0) && c.sp() != null) {
                        return c.sp().ve();
                    }
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // com.byazt.fp.a
            public boolean uj() throws RemoteException {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(MsaIdInterface.Stub.DESCRIPTOR);
                    if (!this.tt.transact(4, parcelObtain, parcelObtain2, 0) && c.sp() != null) {
                        return c.sp().uj();
                    }
                    parcelObtain2.readException();
                    return parcelObtain2.readInt() != 0;
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // com.byazt.fp.a
            public boolean n() throws RemoteException {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(MsaIdInterface.Stub.DESCRIPTOR);
                    if (!this.tt.transact(5, parcelObtain, parcelObtain2, 0) && c.sp() != null) {
                        return c.sp().n();
                    }
                    parcelObtain2.readException();
                    return parcelObtain2.readInt() != 0;
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // com.byazt.fp.a
            public void a() throws RemoteException {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(MsaIdInterface.Stub.DESCRIPTOR);
                    if (!this.tt.transact(6, parcelObtain, parcelObtain2, 0) && c.sp() != null) {
                        c.sp().a();
                    } else {
                        parcelObtain2.readException();
                    }
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }
        }

        public static a sp() {
            return C0118c.c;
        }
    }
}
