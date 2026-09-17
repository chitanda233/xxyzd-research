package ms.bz.bd.c.Pgl;

import android.net.ConnectivityManager;

/* JADX INFO: loaded from: classes4.dex */
final class c0 extends pblz.pgla {
    c0() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    protected final Object c(long j, String str, Object obj) {
        try {
            ConnectivityManager connectivityManager = (ConnectivityManager) pblw.c().tt().getSystemService((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "d8d57a", new byte[]{118, com.sigmob.sdk.archives.tar.e.M, 25, 79, 13, 117, 115, 16, 35, 108, 97, 35}));
            return (String) (connectivityManager.getNetworkCapabilities(connectivityManager.getActiveNetwork()).hasTransport(4) ? com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "325376", new byte[]{115}) : com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "bf5e48", new byte[]{35}));
        } catch (Throwable unused) {
            return (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "703b36", new byte[]{118});
        }
    }
}
