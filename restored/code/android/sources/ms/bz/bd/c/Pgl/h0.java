package ms.bz.bd.c.Pgl;

import java.lang.reflect.Method;
import java.util.HashSet;

/* JADX INFO: loaded from: classes4.dex */
final class h0 extends pblz.pgla {
    h0() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    public final Object c(long j, String str, Object obj) throws Throwable {
        String[] strArr = {(String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "fed4f9", new byte[]{com.sigmob.sdk.archives.tar.e.R, 119, 7, 79}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "180b4e", new byte[]{45, com.sigmob.sdk.archives.tar.e.K, 86, 31}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "411fb1", new byte[]{com.sigmob.sdk.archives.tar.e.K, 58, 84, 29}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "f724c7", new byte[]{122, com.sigmob.sdk.archives.tar.e.H, 72, 90, 73}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "a30e30", new byte[]{98, com.sigmob.sdk.archives.tar.e.L, 71, 28, 5}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "c0a91c", new byte[]{106, 59, 19, 66, 3, 125}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "dab23c", new byte[]{125, 118, 16, 81, 9, 125}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "3da7cb", new byte[]{45, 104, 23, com.sigmob.sdk.archives.tar.e.Q, 80, 96, 35}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "7577cb", new byte[]{42, 62, 74, 70, 93, 114, com.sigmob.sdk.archives.tar.e.I}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "3a73c2", new byte[]{com.sigmob.sdk.archives.tar.e.I, 98, 73, 84, 73, 43, com.sigmob.sdk.archives.tar.e.O}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "91d06e", new byte[]{com.sigmob.sdk.archives.tar.e.H, 35, 24, 87, 12, 118}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "683138", new byte[]{105, com.sigmob.sdk.archives.tar.e.N, 69, 80, 5, 97}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "2becee", new byte[]{com.sigmob.sdk.archives.tar.e.I, 101, 23, 27, 87, 119}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "01cded", new byte[]{32, 32, 5, 3}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "38318d", new byte[]{32, com.sigmob.sdk.archives.tar.e.N, 65, 70, 12, 96, 56, 24, 112, 106}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "ded861", new byte[]{com.sigmob.sdk.archives.tar.e.R, 98, 30, com.sigmob.sdk.archives.tar.e.S, 28}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "825fba", new byte[]{37, 57, 68, 1, 72}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "c1863b", new byte[]{125, 35, 71, 87, 31}), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "513756", new byte[]{44, 60, 78, com.sigmob.sdk.archives.tar.e.P, 24})};
        HashSet hashSet = new HashSet();
        try {
            Method declaredMethod = Class.forName((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "56003b", new byte[]{37, 58, 71, 86, 3, 124, com.sigmob.sdk.archives.tar.e.J, 89, 110, 115, 106, 7, 70, 86, 26, 124, com.sigmob.sdk.archives.tar.e.M, 18, com.sigmob.sdk.archives.tar.e.P, 97, 42, com.sigmob.sdk.archives.tar.e.M, 68, 65, 30})).getDeclaredMethod((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "a580bc", new byte[]{124, 62, com.sigmob.sdk.archives.tar.e.S, 80, 110, 113, 112, 2, 96, 99, 117, 36}), new Class[0]);
            declaredMethod.setAccessible(true);
            String[] strArr2 = (String[]) declaredMethod.invoke(null, new Object[0]);
            if (strArr2 != null) {
                for (String str2 : strArr2) {
                    for (int i = 0; i < 19; i++) {
                        String str3 = strArr[i];
                        if (str2.toLowerCase().contains(str3)) {
                            hashSet.add(str3);
                        }
                    }
                }
            }
        } catch (Exception unused) {
        }
        return hashSet.toString();
    }
}
