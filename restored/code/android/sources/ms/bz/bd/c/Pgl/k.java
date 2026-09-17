package ms.bz.bd.c.Pgl;

import android.content.Context;
import android.content.pm.Signature;

/* JADX INFO: loaded from: classes4.dex */
final class k extends pblz.pgla {
    k() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    public final Object c(long j, String str, Object obj) throws Throwable {
        Context contextTt = pblw.c().tt();
        Signature[] signatureArr = contextTt.getPackageManager().getPackageInfo(contextTt.getPackageName(), 64).signatures;
        if (signatureArr == null || signatureArr.length <= 0) {
            return null;
        }
        return signatureArr[0].toByteArray();
    }
}
