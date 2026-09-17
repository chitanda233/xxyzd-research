package com.kwad.components.ad.draw.a;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwai.adclient.kscommerciallogger.model.BusinessType;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public static void g(AdTemplate adTemplate) {
        AdInfo adInfoEM = e.eM(adTemplate);
        a(d.aP().y(1).z(com.kwad.sdk.core.response.helper.a.bk(adInfoEM)).q(com.kwad.sdk.core.response.helper.a.bh(adInfoEM)).setAdTemplate(adTemplate), false);
    }

    public static void a(AdTemplate adTemplate, long j) {
        AdInfo adInfoEM = e.eM(adTemplate);
        a(d.aP().y(2).z(com.kwad.sdk.core.response.helper.a.bk(adInfoEM)).q(com.kwad.sdk.core.response.helper.a.bh(adInfoEM)).h(j).setAdTemplate(adTemplate), false);
    }

    public static void a(AdTemplate adTemplate, long j, String str) {
        AdInfo adInfoEM = e.eM(adTemplate);
        a(d.aP().y(3).z(com.kwad.sdk.core.response.helper.a.bk(adInfoEM)).q(com.kwad.sdk.core.response.helper.a.bh(adInfoEM)).h(j).setAdTemplate(adTemplate).setErrorMsg(str), true);
    }

    private static void a(com.kwad.sdk.commercial.c.a aVar, boolean z) {
        try {
            com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(z ? ILoggerReporter.Category.ERROR_LOG : ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.001d).b(BusinessType.AD_DRAW).P("ad_sdk_draw_material_load", "status").A(aVar));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
