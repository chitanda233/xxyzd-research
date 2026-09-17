package ms.bz.bd.c.Pgl;

import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;

/* JADX INFO: loaded from: classes4.dex */
public final class pblb implements IInterface {
    private final IBinder c;

    public pblb(IBinder iBinder) {
        this.c = iBinder;
    }

    @Override // android.os.IInterface
    public final IBinder asBinder() {
        return this.c;
    }

    public final String c() {
        String string;
        Parcel parcelObtain = Parcel.obtain();
        Parcel parcelObtain2 = Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "7b1f8e", new byte[]{37, 111, 79, 92, 6, 97, 33, 80, 46, 59, com.sigmob.sdk.archives.tar.e.M, 97, 12, 33, 18, 98, 36, 79, 101, 59, 35, 110, 86, 19, 21, 107, 16, 106, 68, com.sigmob.sdk.archives.tar.e.R, 15, 68, 75, 22, 38, 123, com.sigmob.sdk.archives.tar.e.H, 79, 73, 56, com.sigmob.sdk.archives.tar.e.J, 101, 80, 20, 6, 113, com.sigmob.sdk.archives.tar.e.I}));
            try {
                this.c.transact(3, parcelObtain, parcelObtain2, 0);
                parcelObtain2.readException();
                string = parcelObtain2.readString();
            } catch (Throwable unused) {
                parcelObtain.recycle();
                parcelObtain2.recycle();
                string = null;
            }
        } catch (Throwable unused2) {
        }
        parcelObtain.recycle();
        parcelObtain2.recycle();
        return string;
    }
}
