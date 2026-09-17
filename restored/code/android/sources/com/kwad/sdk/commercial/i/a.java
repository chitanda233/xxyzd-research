package com.kwad.sdk.commercial.i;

import android.text.TextUtils;
import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.commercial.c;
import com.kwad.sdk.commercial.d;
import com.kwad.sdk.commercial.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.h;
import com.kwad.sdk.utils.ac;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static C0500a aKI;

    /* JADX INFO: renamed from: com.kwad.sdk.commercial.i.a$a, reason: collision with other inner class name */
    public static class C0500a extends com.kwad.sdk.core.response.a.a {
        public List<String> aKJ;
    }

    private static void a(AdTemplate adTemplate, b bVar) {
        a(adTemplate, false, bVar);
    }

    private static void a(AdTemplate adTemplate, boolean z, b bVar) {
        if (dI(bVar.aKC)) {
            return;
        }
        c.d(d.Iz().dm(z ? ILoggerReporter.Category.ERROR_LOG : ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.001d).b(e.bw(adTemplate)).P("ad_sdk_track_performance", "status").A(bVar));
    }

    public static void o(AdTemplate adTemplate, int i, String str) {
        try {
            a(adTemplate, b.IN().dv(4).dw(i).dJ(str).setAdTemplate(adTemplate));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(AdTemplate adTemplate, String str, String str2, String str3, String str4) {
        try {
            c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(1.0d).b(e.bw(adTemplate)).P("ad_sdk_macro_check_performance", "error_name").A(com.kwad.sdk.commercial.h.a.IJ().dB(str).dD(str2).dE(str3).dC(str4).setAdTemplate(adTemplate)));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void p(AdTemplate adTemplate, int i, String str) {
        try {
            a(adTemplate, b.IN().dv(1).dw(i).dJ(str).setAdTemplate(adTemplate));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(AdTemplate adTemplate, int i, String str, int i2, int i3) {
        try {
            a(adTemplate, b.IN().dv(2).dw(i).dJ(str).dx(i3).setErrorCode(i2).setAdTemplate(adTemplate));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(AdTemplate adTemplate, int i, String str, String str2, int i2, String str3, int i3) {
        try {
            a(adTemplate, true, b.IN().dv(3).dw(i).dJ(str).dK(str2).setErrorCode(i2).setErrorMsg(str3).dx(i3).setAdTemplate(adTemplate));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private static boolean dI(String str) {
        C0500a c0500aIK;
        List<String> list;
        if (TextUtils.isEmpty(str) || (c0500aIK = IK()) == null || (list = c0500aIK.aKJ) == null) {
            return false;
        }
        for (String str2 : list) {
            if (!TextUtils.isEmpty(str2) && str.contains(str2)) {
                return true;
            }
        }
        return false;
    }

    private static C0500a IK() {
        String strGo = ((h) ServiceProvider.get(h.class)).Go();
        if (!TextUtils.isEmpty(strGo)) {
            aKI = (C0500a) ac.b(strGo, new com.kwad.sdk.core.c<C0500a>() { // from class: com.kwad.sdk.commercial.i.a.1
                @Override // com.kwad.sdk.core.c
                public final /* synthetic */ com.kwad.sdk.core.b IM() {
                    return IL();
                }

                private static C0500a IL() {
                    return new C0500a();
                }
            });
        }
        return aKI;
    }
}
