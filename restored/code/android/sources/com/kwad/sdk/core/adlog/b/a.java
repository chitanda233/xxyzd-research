package com.kwad.sdk.core.adlog.b;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.commercial.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static void a(com.kwad.sdk.core.adlog.a.a aVar, com.kwad.sdk.core.adlog.a.c cVar, b bVar) {
        a(aVar, cVar, false, bVar);
    }

    private static void a(com.kwad.sdk.core.adlog.a.a aVar, com.kwad.sdk.core.adlog.a.c cVar, boolean z, b bVar) {
        AdTemplate adTemplate = aVar.aLN.adTemplate;
        bVar.dB(aVar.aLN.aKK).dC(aVar.retryCount).dD(aVar.aLP).dW(aVar.aLQ).dE(cVar.aLY).bE(cVar.aLZ).setAdTemplate(adTemplate);
        com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.1d).b(e.bw(adTemplate)).P("ad_sdk_adlog_retry", "status").A(bVar));
    }

    public static void a(com.kwad.sdk.core.adlog.a.a aVar, com.kwad.sdk.core.adlog.a.c cVar, int i) {
        try {
            a(aVar, cVar, b.Jp().dA(1).dF(i));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(com.kwad.sdk.core.adlog.a.a aVar, com.kwad.sdk.core.adlog.a.c cVar, int i) {
        try {
            a(aVar, cVar, b.Jp().dA(2).dF(i));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void c(com.kwad.sdk.core.adlog.a.a aVar, com.kwad.sdk.core.adlog.a.c cVar, int i) {
        try {
            a(aVar, cVar, true, b.Jp().dA(3).dF(i));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void d(com.kwad.sdk.core.adlog.a.a aVar, com.kwad.sdk.core.adlog.a.c cVar, int i) {
        try {
            a(aVar, cVar, b.Jp().dA(4).dF(i));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(com.kwad.sdk.core.adlog.a.a aVar, com.kwad.sdk.core.adlog.a.c cVar, int i, long j) {
        try {
            a(aVar, cVar, b.Jp().dA(5).dF(i).aw(j));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(com.kwad.sdk.core.adlog.a.a aVar, com.kwad.sdk.core.adlog.a.c cVar, int i, long j) {
        try {
            a(aVar, cVar, true, b.Jp().dA(6).dF(i).aw(j));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void e(com.kwad.sdk.core.adlog.a.a aVar, com.kwad.sdk.core.adlog.a.c cVar, int i) {
        try {
            a(aVar, cVar, true, b.Jp().dA(7).dF(i));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
