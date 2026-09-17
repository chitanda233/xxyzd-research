package com.kwad.sdk.crash.online.monitor;

import android.text.TextUtils;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.crash.online.monitor.block.e;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static volatile boolean hasInit = false;

    static /* synthetic */ boolean access$002(boolean z) {
        hasInit = true;
        return true;
    }

    public static void dA(final String str) {
        i.execute(new bi() { // from class: com.kwad.sdk.crash.online.monitor.a.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (a.hasInit) {
                    return;
                }
                c.d("perfMonitor.MonitorManager", "configStr:" + str);
                com.kwad.sdk.crash.online.monitor.a.c cVarGr = a.gr(str);
                c.d("perfMonitor.MonitorManager", cVarGr.toJson().toString());
                e.d(cVarGr.bfC);
                a.access$002(true);
            }
        });
    }

    public static com.kwad.sdk.crash.online.monitor.a.c gr(String str) {
        if (TextUtils.isEmpty(str)) {
            return QE();
        }
        try {
            JSONObject jSONObject = new JSONObject(str);
            com.kwad.sdk.crash.online.monitor.a.c cVar = new com.kwad.sdk.crash.online.monitor.a.c();
            cVar.parseJson(jSONObject);
            return cVar;
        } catch (Exception e) {
            c.w("perfMonitor.MonitorManager", e);
            return QE();
        }
    }

    private static com.kwad.sdk.crash.online.monitor.a.c QE() {
        com.kwad.sdk.crash.online.monitor.a.c cVar = new com.kwad.sdk.crash.online.monitor.a.c();
        cVar.bfC = new com.kwad.sdk.crash.online.monitor.a.a();
        cVar.bfC.bft = 5;
        return cVar;
    }
}
