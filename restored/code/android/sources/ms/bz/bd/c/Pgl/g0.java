package ms.bz.bd.c.Pgl;

import android.accessibilityservice.AccessibilityServiceInfo;
import android.content.Context;
import android.view.accessibility.AccessibilityManager;
import java.lang.reflect.Method;
import java.util.List;
import kotlin.io.encoding.Base64;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
final class g0 extends pblz.pgla {
    g0() {
    }

    @Override // ms.bz.bd.c.Pgl.pblz.pgla
    public final Object c(long j, String str, Object obj) throws Throwable {
        List<AccessibilityServiceInfo> list;
        Context contextTt = pblw.c().tt();
        JSONArray jSONArray = new JSONArray();
        AccessibilityManager accessibilityManager = (AccessibilityManager) contextTt.getSystemService((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "5b1ee3", new byte[]{37, 99, 65, 20, 73, com.sigmob.sdk.archives.tar.e.O, 63, 65, 105, 57, 45, 116, 91}));
        if (accessibilityManager != null) {
            try {
                Method declaredMethod = accessibilityManager.getClass().getDeclaredMethod((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "4f4ddf", new byte[]{34, 97, com.sigmob.sdk.archives.tar.e.Q, 57, 85, 98, 35, 70, 105, 56, 32, 96, 102, 19, com.sigmob.sdk.archives.tar.e.S, 116, 36, 84, 108, com.sigmob.sdk.archives.tar.e.N, 44, 104, 78, 4, 66, 66, com.sigmob.sdk.archives.tar.e.J, 85, 115, Base64.padSymbol, 38, 97, 107, 25, 72, 101}), new Class[0]);
                list = declaredMethod != null ? (List) declaredMethod.invoke(accessibilityManager, new Object[0]) : null;
            } catch (Throwable unused) {
            }
            if (list == null || list.size() == 0) {
                return jSONArray.toString();
            }
            for (AccessibilityServiceInfo accessibilityServiceInfo : list) {
                JSONObject jSONObject = new JSONObject();
                try {
                    jSONObject.put((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "fbb1c2", new byte[]{114, 118}), accessibilityServiceInfo.eventTypes);
                    jSONObject.put((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "126c7a", new byte[]{41, com.sigmob.sdk.archives.tar.e.L}), accessibilityServiceInfo.getId());
                    jSONArray.put(jSONObject);
                } catch (Throwable unused2) {
                }
            }
        }
        return jSONArray.toString();
    }
}
