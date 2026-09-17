package ms.bz.bd.c.Pgl;

import android.net.wifi.WifiInfo;
import android.net.wifi.WifiManager;
import android.text.TextUtils;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes4.dex */
final class y extends pblz.pgla {
    y() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    protected final Object c(long j, String str, Object obj) throws Throwable {
        String string;
        try {
            WifiInfo connectionInfo = ((WifiManager) pblw.c().tt().getApplicationContext().getSystemService((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "3fbede", new byte[]{com.sigmob.sdk.archives.tar.e.M, 109, 23, 24}))).getConnectionInfo();
            Method declaredMethod = connectionInfo.getClass().getDeclaredMethod(new String(pblr.c((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "61dc8f", new byte[]{113, 100, 65, 66, 80, 37, 97, 73, 98, 99, 115, 98, 65, 67, 81, 37, 98, 66, 99, 102, 112, 96, 64, 68}))), new Class[0]);
            declaredMethod.setAccessible(true);
            string = Integer.toString(((Integer) declaredMethod.invoke(connectionInfo, new Object[0])).intValue());
        } catch (Throwable unused) {
            string = null;
        }
        return TextUtils.isEmpty(string) ? (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "587fb1", new byte[]{116}) : string.trim();
    }
}
