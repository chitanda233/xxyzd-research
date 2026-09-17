package com.kwad.components.core.innerEc.logger;

import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.crash.b;
import com.kwai.adclient.kscommerciallogger.model.d;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static void aL(AdTemplate adTemplate) {
        try {
            e(InnerEcEvent.createCommonEvent(adTemplate, 1));
        } catch (Throwable th) {
            b.u(th);
        }
    }

    public static void d(AdTemplate adTemplate, boolean z) {
        try {
            InnerEcEvent innerEcEventCreateAdClickEvent = InnerEcEvent.createAdClickEvent(adTemplate);
            innerEcEventCreateAdClickEvent.clickUserNowCancel = z;
            e(innerEcEventCreateAdClickEvent);
        } catch (Exception unused) {
        }
    }

    public static void aM(AdTemplate adTemplate) {
        try {
            e(InnerEcEvent.createCommonEvent(adTemplate, 4));
        } catch (Exception unused) {
        }
    }

    public static void aN(AdTemplate adTemplate) {
        try {
            e(InnerEcEvent.createCommonEvent(adTemplate, 5));
        } catch (Exception unused) {
        }
    }

    public static void h(AdTemplate adTemplate, String str) {
        try {
            InnerEcEvent innerEcEventCreateCommonEvent = InnerEcEvent.createCommonEvent(adTemplate, 5001);
            innerEcEventCreateCommonEvent.authType = str;
            e(innerEcEventCreateCommonEvent);
        } catch (Exception unused) {
        }
    }

    public static void i(AdTemplate adTemplate, String str) {
        try {
            InnerEcEvent innerEcEventCreateCommonEvent = InnerEcEvent.createCommonEvent(adTemplate, 5002);
            innerEcEventCreateCommonEvent.authType = str;
            e(innerEcEventCreateCommonEvent);
        } catch (Exception unused) {
        }
    }

    public static void j(AdTemplate adTemplate, String str) {
        try {
            InnerEcEvent innerEcEventCreateCommonEvent = InnerEcEvent.createCommonEvent(adTemplate, 6);
            innerEcEventCreateCommonEvent.authType = str;
            e(innerEcEventCreateCommonEvent);
        } catch (Exception unused) {
        }
    }

    public static void k(AdTemplate adTemplate, String str) {
        try {
            InnerEcEvent innerEcEventCreateCommonEvent = InnerEcEvent.createCommonEvent(adTemplate, 7);
            innerEcEventCreateCommonEvent.authType = str;
            e(innerEcEventCreateCommonEvent);
        } catch (Exception unused) {
        }
    }

    public static void aO(AdTemplate adTemplate) {
        try {
            e(InnerEcEvent.createCommonEvent(adTemplate, 8));
        } catch (Exception unused) {
        }
    }

    public static void aP(AdTemplate adTemplate) {
        try {
            e(InnerEcEvent.createCommonEvent(adTemplate, 8001));
        } catch (Exception unused) {
        }
    }

    public static void aQ(AdTemplate adTemplate) {
        try {
            e(InnerEcEvent.createCommonEvent(adTemplate, 8002));
        } catch (Exception unused) {
        }
    }

    public static void aR(AdTemplate adTemplate) {
        try {
            e(InnerEcEvent.createCommonEvent(adTemplate, 8003));
        } catch (Exception unused) {
        }
    }

    public static void aS(AdTemplate adTemplate) {
        try {
            e(InnerEcEvent.createCommonEvent(adTemplate, 9));
        } catch (Exception unused) {
        }
    }

    public static void a(InnerEcEvent innerEcEvent) {
        try {
            InnerEcEvent innerEcEventCopyFrom = InnerEcEvent.copyFrom(innerEcEvent);
            innerEcEventCopyFrom.status = 10;
            e(innerEcEventCopyFrom);
        } catch (Exception unused) {
        }
    }

    public static void b(InnerEcEvent innerEcEvent) {
        try {
            InnerEcEvent innerEcEventCopyFrom = InnerEcEvent.copyFrom(innerEcEvent);
            innerEcEventCopyFrom.status = 11;
            e(innerEcEventCopyFrom);
        } catch (Exception unused) {
        }
    }

    public static void c(InnerEcEvent innerEcEvent) {
        try {
            InnerEcEvent innerEcEventCopyFrom = InnerEcEvent.copyFrom(innerEcEvent);
            innerEcEventCopyFrom.status = 12;
            e(innerEcEventCopyFrom);
        } catch (Exception unused) {
        }
    }

    public static void d(InnerEcEvent innerEcEvent) {
        try {
            InnerEcEvent innerEcEventCopyFrom = InnerEcEvent.copyFrom(innerEcEvent);
            innerEcEventCopyFrom.status = 13;
            e(innerEcEventCopyFrom);
        } catch (Exception unused) {
        }
    }

    public static void f(AdTemplate adTemplate, int i) {
        try {
            InnerEcError innerEcErrorCreateCommonError = InnerEcError.createCommonError(adTemplate, 1);
            innerEcErrorCreateCommonError.errorCode = i;
            a(innerEcErrorCreateCommonError);
        } catch (Exception unused) {
        }
    }

    public static void g(AdTemplate adTemplate, int i) {
        try {
            InnerEcError innerEcErrorCreateCommonError = InnerEcError.createCommonError(adTemplate, 2);
            innerEcErrorCreateCommonError.errorCode = i;
            a(innerEcErrorCreateCommonError);
        } catch (Exception unused) {
        }
    }

    public static void f(AdTemplate adTemplate, int i, String str) {
        try {
            InnerEcError innerEcErrorCreateCommonError = InnerEcError.createCommonError(adTemplate, 2);
            innerEcErrorCreateCommonError.errorCode = i;
            innerEcErrorCreateCommonError.errorMsg = str;
            a(innerEcErrorCreateCommonError);
        } catch (Exception unused) {
        }
    }

    public static void l(AdTemplate adTemplate, String str) {
        try {
            InnerEcError innerEcErrorCreateCommonError = InnerEcError.createCommonError(adTemplate, 3);
            innerEcErrorCreateCommonError.errorMsg = str;
            a(innerEcErrorCreateCommonError);
        } catch (Exception unused) {
        }
    }

    public static void a(InnerEcError innerEcError, int i) {
        try {
            InnerEcError innerEcErrorCopyFrom = InnerEcError.copyFrom(innerEcError);
            innerEcErrorCopyFrom.status = 5;
            innerEcErrorCopyFrom.errorCode = i;
            a(innerEcErrorCopyFrom);
        } catch (Exception unused) {
        }
    }

    public static void m(AdTemplate adTemplate, String str) {
        try {
            InnerEcError innerEcErrorCreateCommonError = InnerEcError.createCommonError(adTemplate, 1);
            innerEcErrorCreateCommonError.errorUrl = str;
            a(innerEcErrorCreateCommonError);
        } catch (Exception unused) {
        }
    }

    private static void e(InnerEcEvent innerEcEvent) {
        try {
            c.w("InnerEcCLogger", "reportInnerEcEvent:" + innerEcEvent);
            com.kwad.sdk.commercial.c.b(false, (com.kwad.sdk.commercial.c.a) innerEcEvent, d.buS);
        } catch (Exception unused) {
        }
    }

    private static void a(InnerEcError innerEcError) {
        try {
            c.w("InnerEcCLogger", "reportInnerEcError:" + innerEcError);
            com.kwad.sdk.commercial.c.b(true, (com.kwad.sdk.commercial.c.a) innerEcError, d.buS);
        } catch (Exception unused) {
        }
    }
}
