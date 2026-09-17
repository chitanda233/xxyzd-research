package com.kwad.sdk.commercial.convert;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.internal.api.SceneImpl;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private static void a(final SceneImpl sceneImpl, final com.kwad.sdk.commercial.c.a aVar) {
        GlobalThreadPools.Or().execute(new Runnable() { // from class: com.kwad.sdk.commercial.convert.e.1
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.001d).b(com.kwad.sdk.commercial.e.di(sceneImpl.getAdStyle())).P("ad_convert_method_call", "method_name").A(aVar));
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        });
    }

    public static void c(SceneImpl sceneImpl) {
        try {
            a(sceneImpl, b.IC().dr("loadRequest").dq(sceneImpl.getAdNum()).setPosId(sceneImpl.getPosId()));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void c(SceneImpl sceneImpl, String str) {
        try {
            a(sceneImpl, b.IC().dr("requestStart").dq(sceneImpl.getAdNum()).ds(str).setPosId(sceneImpl.getPosId()));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(SceneImpl sceneImpl, String str, String str2) {
        try {
            a(sceneImpl, b.IC().dr("requestFinish").dq(sceneImpl.getAdNum()).ds(str).dt(str2).setPosId(sceneImpl.getPosId()));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(SceneImpl sceneImpl, int i) {
        try {
            a(sceneImpl, b.IC().dr("dataReady").dq(i));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(int i, int i2, String str, String str2) {
        try {
            com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).b(com.kwad.sdk.commercial.e.di(i)).P("ad_convert_method_call", "method_name").A(b.IC().dr("requestError").ds(str2).setErrorCode(com.kwad.sdk.commercial.e.dj(i2)).setErrorMsg(str)));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
