package com.czhj.devicehelper.honor.oaid;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;
import android.os.RemoteException;

/* JADX INFO: loaded from: classes2.dex */
public interface b extends IInterface {

    public static abstract class a extends Binder implements b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private static final String f2223a = "com.hihonor.cloudservice.oaid.IOAIDService";

        /* JADX INFO: renamed from: com.czhj.devicehelper.honor.oaid.b$a$a, reason: collision with other inner class name */
        public static class C0353a implements b {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f2224a;

            public C0353a(IBinder iBinder) {
                this.f2224a = iBinder;
            }

            @Override // com.czhj.devicehelper.honor.oaid.b
            public void a(com.czhj.devicehelper.honor.oaid.a.AbstractBinderC0352a abstractBinderC0352a) throws Throwable {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcel = null;
                try {
                    Parcel parcelObtain2 = Parcel.obtain();
                    try {
                        parcelObtain2.writeInterfaceToken(a.f2223a);
                        if (abstractBinderC0352a == null) {
                            abstractBinderC0352a = null;
                        }
                        parcelObtain2.writeStrongBinder(abstractBinderC0352a);
                        this.f2224a.transact(2, parcelObtain2, parcelObtain, 0);
                        parcelObtain.readException();
                        parcelObtain.recycle();
                        parcelObtain2.recycle();
                    } catch (Throwable th) {
                        th = th;
                        parcel = parcelObtain2;
                        parcelObtain.recycle();
                        parcel.recycle();
                        throw th;
                    }
                } catch (Throwable th2) {
                    th = th2;
                }
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f2224a;
            }

            @Override // com.czhj.devicehelper.honor.oaid.b
            public void b(com.czhj.devicehelper.honor.oaid.a.AbstractBinderC0352a abstractBinderC0352a) throws Throwable {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcel = null;
                try {
                    Parcel parcelObtain2 = Parcel.obtain();
                    try {
                        parcelObtain2.writeInterfaceToken(a.f2223a);
                        if (abstractBinderC0352a == null) {
                            abstractBinderC0352a = null;
                        }
                        parcelObtain2.writeStrongBinder(abstractBinderC0352a);
                        this.f2224a.transact(3, parcelObtain2, parcelObtain, 0);
                        parcelObtain.readException();
                        parcelObtain.recycle();
                        parcelObtain2.recycle();
                    } catch (Throwable th) {
                        th = th;
                        parcel = parcelObtain2;
                        parcelObtain.recycle();
                        parcel.recycle();
                        throw th;
                    }
                } catch (Throwable th2) {
                    th = th2;
                }
            }
        }
    }

    void a(com.czhj.devicehelper.honor.oaid.a.AbstractBinderC0352a abstractBinderC0352a) throws RemoteException;

    void b(com.czhj.devicehelper.honor.oaid.a.AbstractBinderC0352a abstractBinderC0352a) throws RemoteException;
}
