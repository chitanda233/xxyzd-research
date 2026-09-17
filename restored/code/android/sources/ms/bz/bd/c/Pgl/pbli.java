package ms.bz.bd.c.Pgl;

import kotlin.io.encoding.Base64;
import kotlin.jvm.internal.ByteCompanionObject;

/* JADX INFO: loaded from: classes4.dex */
public final class pbli {
    public static boolean c() {
        return c((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "0494bf", new byte[]{34, 57, 71, 14, 95, 104, 39, 16, 108, 101, 47, com.sigmob.sdk.archives.tar.e.M, 79, 14, 91, 99, com.sigmob.sdk.archives.tar.e.J, 24, ByteCompanionObject.MAX_VALUE, 107, com.sigmob.sdk.archives.tar.e.K, Base64.padSymbol, 4, 67, 82, 99, com.sigmob.sdk.archives.tar.e.N, 91, 123, 96, 42, 59, 69, 78, 84, 101, 60, 7, 38, 84, 38, 58, 121, 100, 118, 92, 60, 27, 97, 112, 46, 36, ByteCompanionObject.MAX_VALUE, 84, 84, 125, 32}));
    }

    private static boolean c(String... strArr) {
        boolean z;
        boolean z2 = true;
        for (String str : strArr) {
            try {
                Class.forName(str);
                z = true;
            } catch (Throwable unused) {
                z = false;
            }
            z2 &= z;
            if (!z2) {
                break;
            }
        }
        return z2;
    }
}
