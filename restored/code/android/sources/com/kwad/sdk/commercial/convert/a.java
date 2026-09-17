package com.kwad.sdk.commercial.convert;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static void a(AdTemplate adTemplate, com.kwad.sdk.commercial.c.a aVar) {
        aVar.setAdTemplate(adTemplate);
        com.kwad.sdk.commercial.c.d(com.kwad.sdk.commercial.d.Iz().dm(ILoggerReporter.Category.APM_LOG).g(0.001d).b(com.kwad.sdk.commercial.e.bw(adTemplate)).P("ad_convert_method_call", "method_name").A(aVar));
    }

    public static void g(AdTemplate adTemplate, boolean z) {
        try {
            a(adTemplate, b.IC().dr("adUserClick").bC(z));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bG(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("adClick"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bH(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("startH5Page"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bI(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("dplinkStart"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bJ(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("smallAppSuccess"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bK(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("appstoreStart"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bL(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("disableClick"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bM(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toVideoH5Web"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bN(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toDownload"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bO(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toOpenApp"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bP(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toInstallApp"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bQ(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toDownloadDialog"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bR(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toDownloadThirdDialog"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bS(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toDownloadPage"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bT(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toDownloadPause"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bU(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toDownloadResume"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bV(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toDownloadNoNet"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bW(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toDoNoting"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bX(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toOpenAppDialog"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bY(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toOpenDeeplinkDialog"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void bZ(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toH5PageDialog"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void ca(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toMiddlePageDialog"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void cb(AdTemplate adTemplate) {
        try {
            a(adTemplate, b.IC().dr("toSmallAppDialog"));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
