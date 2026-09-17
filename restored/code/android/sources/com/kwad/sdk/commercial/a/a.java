package com.kwad.sdk.commercial.a;

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
        try {
            c.d(d.Iz().dm(z ? ILoggerReporter.Category.ERROR_LOG : ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.1d).b(e.bw(adTemplate)).P("ad_sdk_download_performance", "status").A(aVar));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void x(AdTemplate adTemplate) {
        a(adTemplate, b.IA().dk(1).setAdTemplate(adTemplate));
    }

    public static void k(AdTemplate adTemplate, long j) {
        a(adTemplate, b.IA().dk(2).au(j).setAdTemplate(adTemplate));
    }

    public static void by(AdTemplate adTemplate) {
        a(adTemplate, b.IA().dk(3).setAdTemplate(adTemplate));
    }

    public static void bz(AdTemplate adTemplate) {
        a(adTemplate, b.IA().dk(4).setAdTemplate(adTemplate));
    }

    public static void bA(AdTemplate adTemplate) {
        a(adTemplate, b.IA().dk(5).setAdTemplate(adTemplate));
    }

    public static void i(AdTemplate adTemplate, int i, String str) {
        a(adTemplate, true, b.IA().dk(6).setAdTemplate(adTemplate).setErrorCode(i).setErrorMsg(str));
    }

    public static void bB(AdTemplate adTemplate) {
        i(adTemplate, 100002, "");
    }

    public static void bC(AdTemplate adTemplate) {
        a(adTemplate, b.IA().dk(7).dl(adTemplate.mInstallApkFormUser ? 1 : 2).setAdTemplate(adTemplate));
    }

    public static void bD(AdTemplate adTemplate) {
        int i = 1;
        b bVarDl = b.IA().dk(8).dl(adTemplate.mInstallApkFormUser ? 1 : 2);
        if (!adTemplate.mInstallApkFromSDK) {
            i = adTemplate.mClickOpenAppStore ? 2 : 0;
        }
        a(adTemplate, bVarDl.dm(i).setAdTemplate(adTemplate));
    }

    public static void bE(AdTemplate adTemplate) {
        int i;
        b bVarDk = b.IA().dk(10);
        if (adTemplate.mInstallApkFromSDK) {
            i = 1;
        } else {
            i = adTemplate.mClickOpenAppStore ? 2 : 0;
        }
        a(adTemplate, bVarDk.dm(i).setAdTemplate(adTemplate));
    }

    public static void j(AdTemplate adTemplate, int i, String str) {
        a(adTemplate, true, b.IA().dk(9).dl(adTemplate.mInstallApkFormUser ? 1 : 2).setAdTemplate(adTemplate).setErrorCode(100003).setErrorMsg(str));
    }
}
