package com.kwad.components.ad.reward.retryReward;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwai.adclient.kscommerciallogger.model.BusinessType;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public static void a(f fVar) {
        a(fVar.mAdTemplate, c.kC().c(fVar).ag(1), false);
    }

    public static void b(f fVar) {
        if (fVar == null) {
            return;
        }
        a(fVar.mAdTemplate, c.kC().c(fVar).ag(2), false);
    }

    public static void Y(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return;
        }
        a(adTemplate, c.kC().aa(adTemplate).ag(4), false);
    }

    public static void Z(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return;
        }
        a(adTemplate, c.kC().aa(adTemplate).ag(3), false);
    }

    public static void kA() {
        com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).b(BusinessType.AD_REWARD).P("ad_sdk_reward_retry_task_performance", "status").A(c.kC().ag(5)));
    }

    public static void kB() {
        com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).b(BusinessType.AD_REWARD).P("ad_sdk_reward_retry_task_performance", "status").A(c.kC().ag(6)));
    }

    public static void h(int i, String str) {
        com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.1d).b(BusinessType.AD_REWARD).P("ad_sdk_reward_retry_task_performance", "status").A(c.kC().ag(7).setErrorMsg(str).setErrorCode(i)));
    }

    private static void a(AdTemplate adTemplate, com.kwad.sdk.commercial.c.a aVar, boolean z) {
        try {
            com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).b(com.kwad.sdk.commercial.e.bw(adTemplate)).P("ad_sdk_reward_retry_task_performance", "status").A(aVar));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
