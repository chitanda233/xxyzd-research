package com.kwad.sdk.commercial.convert;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private static void a(AdTemplate adTemplate, com.kwad.sdk.commercial.c.a aVar) {
        aVar.setAdTemplate(adTemplate);
        com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.001d).b(com.kwad.sdk.commercial.e.bw(adTemplate)).P("ad_convert_method_call", "method_name").A(aVar));
    }

    public static void cc(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("callShow"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void cd(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("adShowSuccess"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
