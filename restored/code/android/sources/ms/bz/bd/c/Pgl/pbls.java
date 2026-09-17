package ms.bz.bd.c.Pgl;

import android.content.Context;
import android.content.Intent;
import android.content.pm.ActivityInfo;
import android.content.pm.PackageManager;
import android.content.pm.ResolveInfo;
import android.net.Uri;
import android.os.Binder;
import android.os.Bundle;
import android.os.IBinder;
import android.os.Parcel;
import java.lang.reflect.Method;
import java.util.Iterator;
import kotlin.io.encoding.Base64;
import kotlin.jvm.internal.ByteCompanionObject;

/* JADX INFO: loaded from: classes4.dex */
public final class pbls {
    private static final String c = (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0, "9b2cc3", new byte[]{4, com.sigmob.sdk.archives.tar.e.Q, 113, 24, 79, 33, 62});

    public static boolean c(Context context) {
        boolean z;
        boolean z2;
        Bundle bundle;
        PackageManager packageManager = context.getPackageManager();
        IBinder iBinder = null;
        if (packageManager != null) {
            Iterator<ResolveInfo> it = packageManager.queryIntentActivities(new Intent((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "73b964", new byte[]{39, 63, 21, 95, 6, 42, com.sigmob.sdk.archives.tar.e.H, 92, 58, com.sigmob.sdk.archives.tar.e.T, com.sigmob.sdk.archives.tar.e.J, com.sigmob.sdk.archives.tar.e.L, 31, 89, 71, 34, com.sigmob.sdk.archives.tar.e.O, 6, 58, 102, 40, ByteCompanionObject.MAX_VALUE, 60, 108, 32, 13}), (Uri) null), 128).iterator();
            while (true) {
                if (!it.hasNext()) {
                    z = false;
                    break;
                }
                ActivityInfo activityInfo = it.next().activityInfo;
                if (activityInfo != null && (bundle = activityInfo.applicationInfo.metaData) != null && bundle.get((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "429766", new byte[]{Base64.padSymbol, 32, 69, 80, 12, 37, 58, 26, 102, 113, 32, 34, 89, 74, 6, 47})) != null) {
                    z = true;
                    break;
                }
            }
        } else {
            z = false;
            break;
        }
        if (!z) {
            String packageName = context.getPackageName();
            String str = (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "3afefb", new byte[]{35, 96, 1, 24, 79, 124, 36, 89});
            try {
                byte[] bArr = new byte[25];
                bArr[0] = 37;
                bArr[1] = Base64.padSymbol;
                bArr[2] = 78;
                bArr[3] = 0;
                bArr[4] = 9;
                bArr[5] = 40;
                bArr[6] = com.sigmob.sdk.archives.tar.e.J;
                bArr[7] = 94;
                bArr[8] = com.sigmob.sdk.archives.tar.e.T;
                bArr[9] = 37;
                try {
                    bArr[10] = 106;
                    bArr[11] = 0;
                    bArr[12] = 79;
                    bArr[13] = 0;
                    bArr[14] = 16;
                    bArr[15] = 40;
                    bArr[16] = com.sigmob.sdk.archives.tar.e.M;
                    bArr[17] = 21;
                    bArr[18] = 69;
                    bArr[19] = com.sigmob.sdk.archives.tar.e.O;
                    bArr[20] = 42;
                    bArr[21] = com.sigmob.sdk.archives.tar.e.J;
                    bArr[22] = 77;
                    bArr[23] = 23;
                    bArr[24] = 20;
                    Method declaredMethod = Class.forName((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "519f96", bArr)).getDeclaredMethod((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "637ecd", new byte[]{32, com.sigmob.sdk.archives.tar.e.L, 80, 34, 89, 97, 35, 27, 101, com.sigmob.sdk.archives.tar.e.H}), String.class);
                    declaredMethod.setAccessible(true);
                    iBinder = null;
                    iBinder = (IBinder) declaredMethod.invoke(null, str);
                } catch (Exception e) {
                    e = e;
                    iBinder = null;
                    com.byazt.nr.m.c(e);
                }
            } catch (Exception e2) {
                e = e2;
            }
            if (iBinder == null) {
                z2 = false;
            } else {
                Parcel parcelObtain = Parcel.obtain();
                Parcel parcelObtain2 = Parcel.obtain();
                try {
                    parcelObtain.writeInterfaceToken(c);
                    parcelObtain.writeInt(2);
                    parcelObtain.writeString(packageName);
                    parcelObtain.writeStrongBinder(new Binder());
                    if (iBinder.transact(1598837584, parcelObtain, parcelObtain2, 0)) {
                        parcelObtain2.readException();
                        parcelObtain.recycle();
                        parcelObtain2.recycle();
                        z2 = true;
                    } else {
                        parcelObtain.recycle();
                        parcelObtain2.recycle();
                        z2 = false;
                    }
                } catch (Throwable th) {
                    try {
                        com.byazt.nr.m.c(th);
                    } catch (Throwable th2) {
                        parcelObtain.recycle();
                        parcelObtain2.recycle();
                        throw th2;
                    }
                }
            }
            if (!z2) {
                return false;
            }
        }
        return true;
    }
}
