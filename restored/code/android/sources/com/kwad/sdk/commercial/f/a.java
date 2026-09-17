package com.kwad.sdk.commercial.f;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.commercial.c;
import com.kwad.sdk.commercial.d;
import com.kwad.sdk.commercial.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static void a(AdTemplate adTemplate, com.kwad.sdk.commercial.c.a aVar) {
        a(adTemplate, false, aVar);
    }

    private static void a(AdTemplate adTemplate, boolean z, com.kwad.sdk.commercial.c.a aVar) {
        aVar.setAdTemplate(adTemplate);
        c.d(d.Iz().dm(z ? ILoggerReporter.Category.ERROR_LOG : ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.01d).b(e.bw(adTemplate)).P("ad_sdk_landing_page_performance", "status").A(aVar));
    }

    private static void b(AdTemplate adTemplate, com.kwad.sdk.commercial.c.a aVar) {
        aVar.setAdTemplate(adTemplate);
        c.d(d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.001d).b(e.bw(adTemplate)).P("ad_sdk_landing_page_performance", "status").A(aVar));
    }

    public static void k(AdTemplate adTemplate, int i, String str) {
        try {
            a(adTemplate, b.IG().ds(1).dz(str).dt(i));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(AdTemplate adTemplate, int i, String str, String str2) {
        try {
            a(adTemplate, true, b.IG().ds(3).dz(str).dt(i).setErrorCode(100009).setErrorMsg(str2));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void l(AdTemplate adTemplate, int i, String str) {
        try {
            a(adTemplate, b.IG().ds(2).dz(str).dt(i));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void m(AdTemplate adTemplate, int i, String str) {
        try {
            a(adTemplate, b.IG().ds(4).dz(str).dt(i));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void n(AdTemplate adTemplate, int i, String str) {
        try {
            a(adTemplate, b.IG().ds(5).dz(str).dt(i));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(AdTemplate adTemplate, int i, String str, int i2, String str2) {
        try {
            a(adTemplate, true, b.IG().ds(6).dz(str).dt(i).setErrorCode(i2).setErrorMsg(str2));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(AdTemplate adTemplate, int i, String str, int i2, String str2) {
        try {
            b(adTemplate, b.IG().ds(7).dz(str).dt(i).setErrorCode(i2).setErrorMsg(str2));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
