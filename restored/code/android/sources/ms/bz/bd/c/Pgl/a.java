package ms.bz.bd.c.Pgl;

import com.byazt.nys.tt;
import java.io.File;

/* JADX INFO: loaded from: classes4.dex */
final class a extends pblz.pgla {
    a() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    public final Object c(long j, String str, Object obj) throws Throwable {
        File file = new File(tt.c(pblw.c().tt()), (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "80778f", new byte[]{com.sigmob.sdk.archives.tar.e.T, 63, 87, 71, 6, 101, 58}));
        if (!file.exists()) {
            file.mkdirs();
        }
        return file.getAbsolutePath();
    }
}
