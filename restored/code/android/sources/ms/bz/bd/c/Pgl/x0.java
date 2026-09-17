package ms.bz.bd.c.Pgl;

import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes4.dex */
final class x0 extends pblz.pgla {
    x0() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    public final Object c(long j, String str, Object obj) throws Throwable {
        try {
            Class<?> cls = Class.forName((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "fe9a42", new byte[]{116, 104, 71, 91, 24, com.sigmob.sdk.archives.tar.e.N, 43, 69, 102, com.sigmob.sdk.archives.tar.e.M, 101, 104, 67, 17, 69, com.sigmob.sdk.archives.tar.e.H, 98, 71, 38, 32, 98, 104, 94, 20, 69, 7, 65, 106, 109, 37, 96, 104, com.sigmob.sdk.archives.tar.e.S, 30, 63, 36, 98, com.sigmob.sdk.archives.tar.e.T, com.sigmob.sdk.archives.tar.e.T, 63, 99, 98, 82, 1, 59, com.sigmob.sdk.archives.tar.e.O, 106, 82, 97, com.sigmob.sdk.archives.tar.e.M, 114, 117, 107, 17, 10, com.sigmob.sdk.archives.tar.e.M, 113, 65, 122}));
            Method declaredMethod = cls.getDeclaredMethod((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "bff27e", new byte[]{126, 101, 7, 77, 41, 97, 79, 66, 32, 87, 96, 97, 7}), new Class[0]);
            declaredMethod.setAccessible(true);
            Object objNewInstance = cls.newInstance();
            if (objNewInstance != null ? ((Boolean) declaredMethod.invoke(objNewInstance, new Object[0])).booleanValue() : false) {
                return (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "894e7b", new byte[]{39, 62, 80, 36, 27, 112, 41});
            }
            return null;
        } catch (Throwable unused) {
            com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "158d9a", new byte[]{39, com.sigmob.sdk.archives.tar.e.N, 77});
            return null;
        }
    }
}
