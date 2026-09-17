package ms.bz.bd.c.Pgl;

import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;

/* JADX INFO: loaded from: classes4.dex */
public final class pblu implements IInterface {
    private final IBinder c;

    public pblu(IBinder iBinder) {
        this.c = iBinder;
    }

    @Override // android.os.IInterface
    public final IBinder asBinder() {
        return null;
    }

    public final String c() throws Throwable {
        Parcel parcelObtain = Parcel.obtain();
        Parcel parcelObtain2 = Parcel.obtain();
        try {
            try {
                parcelObtain.writeInterfaceToken((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "88ccbe", new byte[]{42, com.sigmob.sdk.archives.tar.e.M, 29, 89, 71, com.sigmob.sdk.archives.tar.e.T, com.sigmob.sdk.archives.tar.e.J, 87, com.sigmob.sdk.archives.tar.e.N, com.sigmob.sdk.archives.tar.e.N, 63, com.sigmob.sdk.archives.tar.e.K, 19, 18, 84, 118, 40, 28, 32, 37, 32, 57, 21, 89, 116, 86, 62, 15, 59, com.sigmob.sdk.archives.tar.e.H, 44, com.sigmob.sdk.archives.tar.e.K, 20, 62, com.sigmob.sdk.archives.tar.e.Q, 102, 62, 11, com.sigmob.sdk.archives.tar.e.L, com.sigmob.sdk.archives.tar.e.J, 42, 63}));
                try {
                    this.c.transact(1, parcelObtain, parcelObtain2, 0);
                    parcelObtain2.readException();
                    String string = parcelObtain2.readString();
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                    return string;
                } catch (Exception e) {
                    e = e;
                    com.byazt.nr.m.c(e);
                    parcelObtain2.recycle();
                    parcelObtain.recycle();
                    return null;
                }
            } catch (Throwable th) {
                th = th;
                parcelObtain2.recycle();
                parcelObtain.recycle();
                throw th;
            }
        } catch (Exception e2) {
            e = e2;
        } catch (Throwable th2) {
            th = th2;
            parcelObtain2.recycle();
            parcelObtain.recycle();
            throw th;
        }
    }
}
