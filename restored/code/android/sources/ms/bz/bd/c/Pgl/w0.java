package ms.bz.bd.c.Pgl;

import android.content.Context;
import android.content.pm.ApplicationInfo;
import java.util.HashMap;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
final class w0 extends pblz.pgla {
    w0() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    public final Object c(long j, String str, Object obj) throws Throwable {
        String string;
        Context contextTt = pblw.c().tt();
        ApplicationInfo applicationInfo = contextTt.getPackageManager().getApplicationInfo(contextTt.getPackageName(), 0);
        String str2 = applicationInfo.sourceDir;
        if (str2 == null) {
            str2 = applicationInfo.publicSourceDir;
        }
        HashMap mapC = pblc.c(str2);
        String string2 = "";
        String str3 = (mapC == null || !mapC.containsKey(1903654775)) ? "" : (String) mapC.get(1903654775);
        if (str3 != null && str3.length() > 0) {
            JSONObject jSONObject = new JSONObject(str3);
            try {
                string = jSONObject.getString((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "b4191a", new byte[]{126, com.sigmob.sdk.archives.tar.e.K, 86, com.sigmob.sdk.archives.tar.e.P, com.sigmob.sdk.archives.tar.e.I, 99, 108, 16, 110, 110, com.sigmob.sdk.archives.tar.e.P, com.sigmob.sdk.archives.tar.e.M, 74, com.sigmob.sdk.archives.tar.e.P, 0, com.sigmob.sdk.archives.tar.e.R, 100, 25}));
            } catch (JSONException unused) {
                string = "";
            }
            StringBuilder sbAppend = new StringBuilder().append(string).append((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "18b57b", new byte[]{123}));
            try {
                string2 = jSONObject.getString((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "807df7", new byte[]{59, com.sigmob.sdk.archives.tar.e.O, 72, 21, com.sigmob.sdk.archives.tar.e.S, com.sigmob.sdk.archives.tar.e.K, 62, 46, 100, 33, 32, 62, 64}));
            } catch (JSONException unused2) {
            }
            string2 = sbAppend.append(string2).toString();
        }
        return string2.length() == 0 ? (String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "d874b2", new byte[]{91, com.sigmob.sdk.archives.tar.e.M, 74, 69}) : string2;
    }
}
