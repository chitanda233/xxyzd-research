package com.kwad.components.core.offline.moitor;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static void a(b bVar) {
        a(bVar, false);
    }

    private static void a(b bVar, boolean z) {
        com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(z ? ILoggerReporter.Category.ERROR_LOG : ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.01d).P("ad_sdk_offline_component_monitor", "load_status").A(bVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
    }

    public static void c(String str, long j) {
        try {
            a(new b().aQ(str).I(j).H(1L));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(String str, long j, int i, String str2, String str3) {
        try {
            a(new b().aQ(str).I(j).setErrorCode(i).aS(str3).aR(str2).H(7L), true);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(String str, long j, int i) {
        try {
            a(new b().aQ(str).I(j).bi(i).H(2L));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(String str, long j, String str2) {
        try {
            a(new b().aQ(str).aS(str2).I(j).H(5L));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(String str, long j, String str2) {
        try {
            a(new b().aQ(str).I(j).aS(str2).H(3L));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void c(String str, long j, String str2) {
        try {
            a(new b().aQ(str).I(j).aS(str2).H(4L));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void d(String str, long j) {
        try {
            a(new b().aQ(str).I(j).H(6L));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void c(String str, long j, int i) {
        try {
            a(new b().aQ(str).H(8L).bi(i).I(j));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
