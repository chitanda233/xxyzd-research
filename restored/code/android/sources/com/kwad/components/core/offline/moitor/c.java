package com.kwad.components.core.offline.moitor;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private static void a(d dVar, boolean z) {
        com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(z ? ILoggerReporter.Category.ERROR_LOG : ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.01d).P("ad_sdk_offline_component_update", "load_status").A(dVar).a(com.kwai.adclient.kscommerciallogger.model.a.buq));
    }

    public static void d(String str, long j, String str2) {
        try {
            a(new d().aT(str).aV(str2).K(j).J(1L), false);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(String str, long j, int i, String str2, String str3) {
        try {
            a(new d().aT(str).K(j).setErrorCode(i).aV(str2).aU(str3).J(2L), true);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(String str, long j, long j2, String str2) {
        try {
            a(new d().aT(str).K(j).L(j2).aV(str2).J(3L), false);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
