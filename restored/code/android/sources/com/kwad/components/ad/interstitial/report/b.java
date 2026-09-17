package com.kwad.components.ad.interstitial.report;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwai.adclient.kscommerciallogger.model.BusinessType;

/* JADX INFO: loaded from: classes3.dex */
public final class b {

    static class a {
        private static final b oj = new b();
    }

    public static b eV() {
        return a.oj;
    }

    private static void a(boolean z, com.kwad.sdk.commercial.c.a aVar) {
        try {
            com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.01d).P("ad_sdk_interstitial_download_error", "status").b(BusinessType.AD_INTERSTITIAL).A(aVar).a(com.kwai.adclient.kscommerciallogger.model.b.buJ));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void x(AdTemplate adTemplate) {
        a(false, new InterstitialReportInfo().setDownloadType(adTemplate.getDownloadType()).setStatus(1).setAdTemplate(adTemplate));
    }

    public final void b(AdTemplate adTemplate, String str) {
        AdInfo adInfoEM = e.eM(adTemplate);
        a(true, new InterstitialReportInfo().setCreativeId(com.kwad.sdk.core.response.helper.a.L(adInfoEM)).setVideoUrl(com.kwad.sdk.core.response.helper.a.M(adInfoEM)).setDownloadSize(adTemplate.getDownloadSize()).setDownloadType(adTemplate.getDownloadType()).setVideoDuration(com.kwad.sdk.core.response.helper.a.N(adInfoEM) * 1000).setStatus(2).setErrorMsg(str).setAdTemplate(adTemplate));
    }
}
