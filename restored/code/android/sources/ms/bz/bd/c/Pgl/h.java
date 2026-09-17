package ms.bz.bd.c.Pgl;

import java.util.Locale;

/* JADX INFO: loaded from: classes4.dex */
final class h extends pblz.pgla {
    h() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    public final Object c(long j, String str, Object obj) throws Throwable {
        String str2;
        try {
            Locale locale = pblw.c().tt().getResources().getConfiguration().locale;
            str2 = locale.getLanguage() + ((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "bb6a63", new byte[]{com.sigmob.sdk.archives.tar.e.P})) + locale.getCountry();
        } catch (Throwable unused) {
            str2 = null;
        }
        return v1.c(str2);
    }
}
