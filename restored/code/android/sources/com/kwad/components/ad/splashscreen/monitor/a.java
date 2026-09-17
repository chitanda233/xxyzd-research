package com.kwad.components.ad.splashscreen.monitor;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.commercial.d;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.o;
import com.kwai.adclient.kscommerciallogger.model.BusinessType;

/* JADX INFO: loaded from: classes3.dex */
public final class a {

    /* JADX INFO: renamed from: com.kwad.components.ad.splashscreen.monitor.a$a, reason: collision with other inner class name */
    static class C0404a {
        private static final a Hh = new a();
    }

    public static a mr() {
        return C0404a.Hh;
    }

    private static void d(com.kwad.sdk.commercial.c.a aVar) {
        if (o.GE().FJ()) {
            com.kwad.sdk.commercial.c.d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_splash_callback", "callback_type").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        }
    }

    private static void e(com.kwad.sdk.commercial.c.a aVar) {
        if (o.GE().FJ()) {
            com.kwad.sdk.commercial.c.d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.01d).P("ad_sdk_splash_action", "action_type").b(BusinessType.AD_SPLASH).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        }
    }

    private static SplashMonitorInfo ag(AdTemplate adTemplate) {
        AdInfo adInfoEM = e.eM(adTemplate);
        return new SplashMonitorInfo().setPreloadId(com.kwad.sdk.core.response.helper.a.bf(adInfoEM)).setCreativeId(com.kwad.sdk.core.response.helper.a.L(adInfoEM)).setMaterialType(com.kwad.sdk.core.response.helper.a.bi(adInfoEM) ? 1 : 2).setAdTemplate(adTemplate);
    }

    public final void v(AdTemplate adTemplate) {
        d(ag(adTemplate).setCallbackType(1));
    }

    public final void ah(AdTemplate adTemplate) {
        d(ag(adTemplate).setCallbackType(2));
    }

    public final void w(AdTemplate adTemplate) {
        d(ag(adTemplate).setCallbackType(3));
    }

    public final void t(long j) {
        d(new SplashMonitorInfo().setCallbackType(4).setPosId(j));
    }

    public final void ai(AdTemplate adTemplate) {
        d(ag(adTemplate).setCallbackType(5));
    }

    public final void aj(AdTemplate adTemplate) {
        e(ag(adTemplate).setActionType(1));
    }

    public final void ak(AdTemplate adTemplate) {
        e(ag(adTemplate).setActionType(2));
    }
}
