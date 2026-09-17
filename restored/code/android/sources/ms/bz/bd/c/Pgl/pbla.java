package ms.bz.bd.c.Pgl;

import android.os.IBinder;
import android.os.IInterface;
import android.os.Parcel;
import kotlin.io.encoding.Base64;

/* JADX INFO: loaded from: classes4.dex */
public final class pbla implements IInterface {
    private final IBinder c;

    public pbla(IBinder iBinder) {
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
            parcelObtain.writeInterfaceToken((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "90fe61", new byte[]{43, Base64.padSymbol, 24, 95, 28, 41, 62, 24, 36, 123, 39, 34, 16, 31, 13, 35, 44, 24, com.sigmob.sdk.archives.tar.e.L, com.sigmob.sdk.archives.tar.e.H, 102, com.sigmob.sdk.archives.tar.e.K, 28, 21, 5, 104, 21, 1, com.sigmob.sdk.archives.tar.e.J, 59, 12, com.sigmob.sdk.archives.tar.e.O, 3, 24, 10, 35, 19, 21, com.sigmob.sdk.archives.tar.e.J, 59, 60, 59, 19, 24, 12, com.sigmob.sdk.archives.tar.e.L, 9, 20, 37, 35, 33, com.sigmob.sdk.archives.tar.e.I, 16}));
            try {
                this.c.transact(1, parcelObtain, parcelObtain2, 0);
                parcelObtain2.readException();
                string = parcelObtain2.readString();
            } catch (Throwable th) {
                th = th;
                parcelObtain.recycle();
                parcelObtain2.recycle();
                com.byazt.nr.m.c(th);
                string = null;
            }
        } catch (Throwable th2) {
            th = th2;
        }
        parcelObtain.recycle();
        parcelObtain2.recycle();
        return string;
    }
}
