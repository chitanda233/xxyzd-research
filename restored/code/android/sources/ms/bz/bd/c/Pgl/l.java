package ms.bz.bd.c.Pgl;

import android.telephony.TelephonyManager;

/* JADX INFO: loaded from: classes4.dex */
final class l extends pblz.pgla {
    l() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    public final Object c(long j, String str, Object obj) throws Throwable {
        Boolean bool = Boolean.FALSE;
        TelephonyManager telephonyManager = (TelephonyManager) pblw.c().tt().getApplicationContext().getSystemService((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "86bdca", new byte[]{57, 60, 30, 30, 89}));
        return (telephonyManager == null || telephonyManager.getSimState() != 5) ? bool : Boolean.TRUE;
    }
}
