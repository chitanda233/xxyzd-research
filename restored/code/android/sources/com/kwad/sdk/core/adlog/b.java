package com.kwad.sdk.core.adlog;

import com.kwad.components.ad.reward.monitor.FraudVerifyCode;
import com.kwad.sdk.commercial.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.h;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.tencent.bugly.BuglyStrategy;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public static void a(final com.kwad.sdk.core.adlog.c.a aVar) {
        GlobalThreadPools.Or().execute(new bi() { // from class: com.kwad.sdk.core.adlog.b.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a aVar2 = new a(aVar);
                b.a(aVar2.getUrl(), aVar2.getBody(), aVar, null);
            }
        });
    }

    public static void Je() {
        GlobalThreadPools.Or().execute(new bi() { // from class: com.kwad.sdk.core.adlog.b.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.core.adlog.a.a aVarJk = com.kwad.sdk.core.adlog.a.b.Jh().Jk();
                if (aVarJk != null) {
                    JSONObject jSONObject = aVarJk.aLM;
                    ac.putValue(jSONObject, "retryCount", aVarJk.retryCount);
                    ac.putValue(jSONObject, "cacheType", 1);
                    b.a(aVarJk.url, jSONObject, aVarJk.aLN, aVarJk);
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void a(String str, JSONObject jSONObject, com.kwad.sdk.core.adlog.c.a aVar, com.kwad.sdk.core.adlog.a.a aVar2) {
        AdTemplate adTemplate = aVar.adTemplate;
        int i = aVar.aKK;
        try {
            com.kwad.sdk.core.adlog.b.c.a(adTemplate, i, aVar2);
            if (!aq.isNetworkConnected(ServiceProvider.getContext())) {
                com.kwad.sdk.core.d.c.w("AdLogRequestManager", "no network while report log");
                com.kwad.sdk.core.adlog.b.c.a(adTemplate, i, str, 100004, "no network", aVar2);
                com.kwad.sdk.core.adlog.a.b.Jh().a(aVar2, str, jSONObject, aVar, 100004, "no network");
                return;
            }
            if (by.iq(str)) {
                com.kwad.sdk.core.adlog.b.c.b(adTemplate, i, str, FraudVerifyCode.RerwardFraudUnknown, "", aVar2);
                return;
            }
            com.kwad.sdk.core.network.c cVarDoPost = h.ES().doPost(str, (Map<String, String>) null, jSONObject);
            AdLogRequestResult adLogRequestResult = new AdLogRequestResult();
            adLogRequestResult.parseResult(cVarDoPost.aSY);
            if (cVarDoPost.code != 200) {
                int iDj = e.dj(cVarDoPost.code);
                String str2 = cVarDoPost.aSY;
                com.kwad.sdk.core.adlog.b.c.d(adTemplate, i, str, iDj, str2, aVar2);
                com.kwad.sdk.core.adlog.a.b.Jh().a(aVar2, str, jSONObject, aVar, iDj, str2);
                return;
            }
            if (adLogRequestResult.isResultOk()) {
                com.kwad.sdk.core.adlog.b.c.b(adTemplate, i, aVar2);
                b(aVar);
                com.kwad.sdk.core.adlog.a.b.Jh().Ji();
            } else {
                if (adLogRequestResult.isCheatingFlow()) {
                    adTemplate.setCheatingFlow(adLogRequestResult.isCheatingFlow());
                    com.kwad.sdk.core.adlog.b.c.c(adTemplate, i, str, adLogRequestResult.result, adLogRequestResult.errorMsg, aVar2);
                    return;
                }
                int i2 = adLogRequestResult.result;
                String str3 = adLogRequestResult.errorMsg;
                com.kwad.sdk.core.d.c.w("AdLogRequestManager", "request fail code:" + i2 + ", errorMsg:" + str3 + ", url=" + str);
                com.kwad.sdk.core.adlog.b.c.c(adTemplate, i, str, i2, str3, aVar2);
                com.kwad.sdk.core.adlog.a.b.Jh().a(aVar2, str, jSONObject, aVar, i2, str3);
            }
        } catch (Throwable th) {
            com.kwad.sdk.core.adlog.b.c.b(adTemplate, i, "", BuglyStrategy.a.MAX_USERDATA_VALUE_LENGTH, by.y(th), aVar2);
            com.kwad.sdk.core.d.c.printStackTrace(th);
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(com.kwad.sdk.core.adlog.c.a aVar) {
        try {
            com.kwad.sdk.core.track.a.e(aVar);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTrace(th);
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
