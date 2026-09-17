package ms.bz.bd.c.Pgl;

import android.content.Context;
import java.lang.reflect.Method;
import kotlin.jvm.internal.ByteCompanionObject;

/* JADX INFO: loaded from: classes4.dex */
final class k0 extends pblz.pgla {
    k0() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    public final Object c(long j, String str, Object obj) throws Throwable {
        double dDoubleValue;
        Context contextTt = pblw.c().tt();
        try {
            Class<?> cls = Class.forName(new String(pblr.c((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "922ed4", new byte[]{126, 99, 23, 23, 13, 39, 104, 22, com.sigmob.sdk.archives.tar.e.M, 100, 126, com.sigmob.sdk.archives.tar.e.M, 23, 69, 12, 113, 108, 21, com.sigmob.sdk.archives.tar.e.M, 108, 126, 100, 19, 20, 13, 122, 108, 22, com.sigmob.sdk.archives.tar.e.L, 97, 126, 101, 22, 67, 13, 38, 108, 66, com.sigmob.sdk.archives.tar.e.M, com.sigmob.sdk.archives.tar.e.N, 122, com.sigmob.sdk.archives.tar.e.M, 23, 23, 12, 112, 104, 22, com.sigmob.sdk.archives.tar.e.N, 101, 126, com.sigmob.sdk.archives.tar.e.N, 22, 70, 13, 118, 109, 65, com.sigmob.sdk.archives.tar.e.N, 101, ByteCompanionObject.MAX_VALUE, 98, 23, 23, 13, 117, 108, 74, com.sigmob.sdk.archives.tar.e.M, com.sigmob.sdk.archives.tar.e.N, 126, 101}))));
            Object objNewInstance = cls.getConstructor(Context.class).newInstance(contextTt);
            Method declaredMethod = cls.getDeclaredMethod(new String(pblr.c((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "81e6d5", new byte[]{ByteCompanionObject.MAX_VALUE, 100, 64, 23, 12, 118, 111, 65, 99, com.sigmob.sdk.archives.tar.e.H, ByteCompanionObject.MAX_VALUE, 102, 65, 16, 13, 115, 109, 71, 98, com.sigmob.sdk.archives.tar.e.K, 124, 99, 64, 68, 12, 117, 109, 69, 99, com.sigmob.sdk.archives.tar.e.L}))), String.class);
            declaredMethod.setAccessible(true);
            dDoubleValue = ((Double) declaredMethod.invoke(objNewInstance, new String(pblr.c((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "3a6d16", new byte[]{116, com.sigmob.sdk.archives.tar.e.I, 19, 65, 89, 117, com.sigmob.sdk.archives.tar.e.T, 20, com.sigmob.sdk.archives.tar.e.I, 97, 117, com.sigmob.sdk.archives.tar.e.I, 18, 73, 92, 36, 102, 19, com.sigmob.sdk.archives.tar.e.I, 101, 117, com.sigmob.sdk.archives.tar.e.K, 19, 65, com.sigmob.sdk.archives.tar.e.S, 114, 102, 25, com.sigmob.sdk.archives.tar.e.H, 96, 117, 58}))))).doubleValue();
        } catch (Throwable unused) {
            dDoubleValue = 0.0d;
        }
        return Integer.toString((int) dDoubleValue);
    }
}
