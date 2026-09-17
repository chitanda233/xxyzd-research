package a.f.a;

import android.os.Binder;
import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;

/* JADX INFO: loaded from: classes.dex */
public interface a extends IInterface {

    /* JADX INFO: renamed from: a.f.a.a$a, reason: collision with other inner class name */
    public static abstract class AbstractBinderC0007a extends Binder implements a {

        /* JADX INFO: renamed from: a.f.a.a$a$a, reason: collision with other inner class name */
        public static class C0008a implements a {

            /* JADX INFO: renamed from: a, reason: collision with root package name */
            public IBinder f30a;

            public C0008a(IBinder iBinder) {
                this.f30a = iBinder;
            }

            @Override // a.f.a.a
            public boolean a(String str) {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(com.alipay.sdk.m.v0.a.AbstractBinderC0052a.f368a);
                    parcelObtain.writeString(str);
                    this.f30a.transact(6, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readInt() != 0;
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // android.os.IInterface
            public IBinder asBinder() {
                return this.f30a;
            }

            @Override // a.f.a.a
            public String getAAID(String str) {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(com.alipay.sdk.m.v0.a.AbstractBinderC0052a.f368a);
                    parcelObtain.writeString(str);
                    this.f30a.transact(5, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // a.f.a.a
            public String getOAID() {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(com.alipay.sdk.m.v0.a.AbstractBinderC0052a.f368a);
                    this.f30a.transact(1, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // a.f.a.a
            public String getVAID(String str) {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(com.alipay.sdk.m.v0.a.AbstractBinderC0052a.f368a);
                    parcelObtain.writeString(str);
                    this.f30a.transact(4, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readString();
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }

            @Override // a.f.a.a
            public boolean isSupport() {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(com.alipay.sdk.m.v0.a.AbstractBinderC0052a.f368a);
                    this.f30a.transact(3, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    return parcelObtain2.readInt() != 0;
                } finally {
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                }
            }
        }

        public static a a(IBinder iBinder) {
            if (iBinder == null) {
                return null;
            }
            IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(com.alipay.sdk.m.v0.a.AbstractBinderC0052a.f368a);
            return (iInterfaceQueryLocalInterface == null || !(iInterfaceQueryLocalInterface instanceof a)) ? new C0008a(iBinder) : (a) iInterfaceQueryLocalInterface;
        }
    }

    boolean a(String str);

    String getAAID(String str);

    String getOAID();

    String getVAID(String str);

    boolean isSupport();
}
