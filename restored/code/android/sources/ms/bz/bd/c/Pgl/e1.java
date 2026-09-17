package ms.bz.bd.c.Pgl;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.content.pm.Signature;
import android.os.IBinder;
import android.os.Looper;
import android.os.Parcel;
import android.os.SystemClock;
import java.security.MessageDigest;
import kotlin.UByte;
import kotlin.io.encoding.Base64;

/* JADX INFO: loaded from: classes4.dex */
public final class e1 {
    ServiceConnection c;
    private final Context tt;
    private f1 uj;
    private String ve;

    final class pgla implements ServiceConnection {
        pgla() {
        }

        @Override // android.content.ServiceConnection
        public final void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            e1.this.uj = new f1(iBinder);
        }

        @Override // android.content.ServiceConnection
        public final void onServiceDisconnected(ComponentName componentName) {
            e1.this.uj = null;
        }
    }

    public e1(Context context) {
        com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "8ea24d", new byte[]{6, 82, 59, 98});
        this.c = new pgla();
        this.tt = context;
    }

    /* JADX WARN: Code duplicated, block: B:18:0x0076  */
    private String c(f1 f1Var, String str) {
        Signature[] signatureArr;
        String string;
        String string2;
        String packageName = this.tt.getPackageName();
        if (this.ve == null) {
            try {
                signatureArr = this.tt.getPackageManager().getPackageInfo(packageName, 64).signatures;
            } catch (Exception unused) {
                signatureArr = null;
            }
            if (signatureArr == null || signatureArr.length <= 0) {
                string = null;
            } else {
                byte[] byteArray = signatureArr[0].toByteArray();
                try {
                    MessageDigest messageDigest = MessageDigest.getInstance((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "f67ad6", new byte[]{68, 28, 101, 68}));
                    if (messageDigest != null) {
                        byte[] bArrDigest = messageDigest.digest(byteArray);
                        StringBuilder sb = new StringBuilder();
                        for (byte b : bArrDigest) {
                            sb.append(Integer.toHexString((b & UByte.MAX_VALUE) | 256).substring(1, 3));
                        }
                        string = sb.toString();
                    } else {
                        string = null;
                    }
                } catch (Exception unused2) {
                }
            }
            this.ve = string;
        }
        String str2 = this.ve;
        f1Var.getClass();
        Parcel parcelObtain = Parcel.obtain();
        Parcel parcelObtain2 = Parcel.obtain();
        try {
            try {
                parcelObtain.writeInterfaceToken((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "4e77bc", new byte[]{38, 104, 73, 13, 85, 113, 46, 80, com.sigmob.sdk.archives.tar.e.T, 119, 107, 104, 84, 70, com.sigmob.sdk.archives.tar.e.Q, 125, com.sigmob.sdk.archives.tar.e.K, 10, 79, 72, com.sigmob.sdk.archives.tar.e.M, 98, 74, 106, 121}));
                parcelObtain.writeString(packageName);
                parcelObtain.writeString(str2);
                parcelObtain.writeString(str);
                f1Var.c.transact(1, parcelObtain, parcelObtain2, 0);
                parcelObtain2.readException();
                string2 = parcelObtain2.readString();
            } catch (Exception unused3) {
                com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "d4e50b", new byte[]{122, 38, 31});
                string2 = null;
            }
            return string2;
        } finally {
            parcelObtain.recycle();
            parcelObtain2.recycle();
        }
    }

    public final void c(pblk.pblb pblbVar) {
        boolean z;
        if (Looper.myLooper() == Looper.getMainLooper()) {
            throw new IllegalStateException((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "c79b4c", new byte[]{81, com.sigmob.sdk.archives.tar.e.L, 68, 24, 4, 96, 32, 4, 125, 60, com.sigmob.sdk.archives.tar.e.J, 58, 68, 86, 38, 117, 105, 24, 92, 58, 96, com.sigmob.sdk.archives.tar.e.H, 75, 18}));
        }
        Intent intent = new Intent();
        intent.setComponent(new ComponentName((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "d01b79", new byte[]{118, Base64.padSymbol, 79, com.sigmob.sdk.archives.tar.e.S, 0, 43, 126, 5, 97, 34, 59, Base64.padSymbol, 82, 19, 6, 39, 99}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "126c53", new byte[]{35, 63, 72, 89, 2, 33, 43, 7, 102, 35, 110, 63, 85, 18, 4, 45, com.sigmob.sdk.archives.tar.e.N, 93, 78, com.sigmob.sdk.archives.tar.e.O, 37, 62, 81, 30, 12, Base64.padSymbol, 1, 22, 117, 37, 41, com.sigmob.sdk.archives.tar.e.K, 64})));
        intent.setAction((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "9aa7f0", new byte[]{41, 96, 6, 74, 86, 41, 116, 67, 63, 106, 102, 107, 23, 90, 77, 38, 42, 14, 63, 119, 45, 109, 27, 71, 23, 8, 10, 101, 30, com.sigmob.sdk.archives.tar.e.S, 1, 71, 45, 112, 124, 21, 12, 105, 19, 66}));
        boolean z2 = false;
        try {
            if (this.tt.bindService(intent, this.c, 1)) {
                try {
                    try {
                        SystemClock.sleep(com.alipay.sdk.m.y.c.f378a);
                    } catch (Exception unused) {
                    }
                    f1 f1Var = this.uj;
                    if (f1Var != null) {
                        String strC = c(f1Var, (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "2d3ffa", new byte[]{12, com.sigmob.sdk.archives.tar.e.Q, 105, com.sigmob.sdk.archives.tar.e.N}));
                        if (pblbVar != null) {
                            pblbVar.c(strC);
                        }
                    }
                    z2 = true;
                } catch (Throwable unused2) {
                    z = true;
                    try {
                        com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "00fb13", new byte[]{46, 34});
                        if (!z) {
                            return;
                        }
                    } finally {
                        if (z) {
                            this.tt.unbindService(this.c);
                        }
                    }
                }
            }
            if (!z2) {
            }
        } catch (Throwable unused3) {
            z = false;
        }
    }
}
