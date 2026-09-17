package com.kwad.components.ad.interstitial.report.realtime;

import com.kwad.components.ad.interstitial.report.realtime.model.InterstitialRealTimeInfo;
import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.commercial.c;
import com.kwad.sdk.commercial.d;
import com.kwad.sdk.core.network.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwai.adclient.kscommerciallogger.model.BusinessType;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    /* synthetic */ a(byte b) {
        this();
    }

    /* JADX INFO: renamed from: com.kwad.components.ad.interstitial.report.realtime.a$a, reason: collision with other inner class name */
    static class C0379a {
        private static final a om = new a(0);
    }

    private a() {
    }

    public static a fb() {
        return C0379a.om;
    }

    public static void a(e eVar) {
        try {
            InterstitialRealTimeInfo interstitialRealTimeInfo = new InterstitialRealTimeInfo();
            interstitialRealTimeInfo.setErrorCode(eVar.errorCode);
            c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_interstitial_data_result_monitor", "error_code").b(BusinessType.AD_INTERSTITIAL).A(interstitialRealTimeInfo).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void F(AdTemplate adTemplate) {
        try {
            InterstitialRealTimeInfo interstitialRealTimeInfo = new InterstitialRealTimeInfo();
            interstitialRealTimeInfo.setRenderType(com.kwad.sdk.core.response.helper.e.eM(adTemplate).adMatrixInfo.adDataV2.interstitialCardInfo.renderType);
            interstitialRealTimeInfo.setAdTemplate(adTemplate);
            c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_interstitial_data_check_monitor", "monitor_index").b(BusinessType.AD_INTERSTITIAL).A(interstitialRealTimeInfo).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(String str, AdTemplate adTemplate) {
        try {
            InterstitialRealTimeInfo interstitialRealTimeInfo = new InterstitialRealTimeInfo();
            interstitialRealTimeInfo.setAdTemplate(adTemplate);
            interstitialRealTimeInfo.setErrorMsg(str);
            c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_interstitial_render_result_monitor", "monitor_index").b(BusinessType.AD_INTERSTITIAL).A(interstitialRealTimeInfo).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void G(AdTemplate adTemplate) {
        try {
            InterstitialRealTimeInfo interstitialRealTimeInfo = new InterstitialRealTimeInfo();
            interstitialRealTimeInfo.setAdTemplate(adTemplate);
            c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_interstitial_service_call_monitor", "monitor_index").b(BusinessType.AD_INTERSTITIAL).A(interstitialRealTimeInfo).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(String str, AdTemplate adTemplate) {
        try {
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
            InterstitialRealTimeInfo interstitialRealTimeInfo = new InterstitialRealTimeInfo();
            interstitialRealTimeInfo.setAdTemplate(adTemplate);
            interstitialRealTimeInfo.setErrorMsg(str);
            interstitialRealTimeInfo.setMaterialUrl(com.kwad.sdk.core.response.helper.a.M(adInfoEM));
            c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).P("ad_sdk_interstitial_resource_monitor", "monitor_index").b(BusinessType.AD_INTERSTITIAL).A(interstitialRealTimeInfo).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
