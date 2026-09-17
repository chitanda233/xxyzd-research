package com.kwad.sdk.commercial.b;

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
        c.d(d.Iz().dm(z ? ILoggerReporter.Category.ERROR_LOG : ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.01d).b(e.bw(adTemplate)).P("ad_sdk_appstore_performance", "status").A(aVar));
    }

    public static void c(AdTemplate adTemplate, String str, int i, int i2) {
        try {
            a(adTemplate, "", str, i, i2, "marketUrl is empty");
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(AdTemplate adTemplate, String str, String str2, int i, int i2) {
        try {
            a(adTemplate, b.IB().dn(1).dp(str).dq(str2).dp(i).m176do(i2));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(AdTemplate adTemplate, String str, String str2, int i, int i2) {
        try {
            a(adTemplate, b.IB().dn(2).dp(str).dq(str2).dp(i).m176do(i2));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(AdTemplate adTemplate, String str, String str2, int i, int i2, String str3) {
        try {
            a(adTemplate, true, b.IB().dn(4).dp(str).dq(str2).dp(i).m176do(i2).setErrorCode(100006).setErrorMsg(str3));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
