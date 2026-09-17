package com.kwad.components.core.g;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.commercial.c;
import com.kwad.sdk.commercial.d;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.service.ServiceProvider;
import com.kwai.adclient.kscommerciallogger.model.BusinessType;
import java.util.concurrent.atomic.AtomicInteger;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static int RQ;
    public static AtomicInteger RR = new AtomicInteger(0);

    public static void a(final BusinessType businessType) {
        GlobalThreadPools.Or().execute(new Runnable() { // from class: com.kwad.components.core.g.a.1
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    String strKY = e.KY();
                    if (strKY == null) {
                        return;
                    }
                    JSONObject jSONObject = new JSONObject(strKY);
                    boolean zOptBoolean = jSONObject.optBoolean("isCheatUser", false);
                    boolean zOptBoolean2 = jSONObject.optBoolean("enableAdClientCheaterReport", false);
                    a.RQ = jSONObject.optInt("maxCollectCount", 0);
                    if (zOptBoolean2 && a.RR.incrementAndGet() <= a.RQ) {
                        c.d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(1.0d).b(businessType).P("ad_sdk_feature_info_collect", "default_type").i(b.qU().aI(zOptBoolean).aK(a.RQ).toJson()));
                    }
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        });
    }
}
