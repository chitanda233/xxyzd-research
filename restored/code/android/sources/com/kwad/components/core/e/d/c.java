package com.kwad.components.core.e.d;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.page.AdWebViewVideoActivityProxy;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ae;
import com.kwad.sdk.utils.ag;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    public static int q(a.C0428a c0428a) {
        e.aD(false);
        Context context = c0428a.getContext();
        AdTemplate adTemplate = c0428a.getAdTemplate();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if (c0428a.pU()) {
            return b(c0428a);
        }
        int iF = e.F(c0428a);
        if (iF == 1) {
            t(c0428a);
            return 13;
        }
        if (iF == 2) {
            return 16;
        }
        int iS = s(c0428a);
        if (iS == 1) {
            return 12;
        }
        if (iS == 2) {
            return 17;
        }
        if (!com.kwad.sdk.core.response.helper.a.aL(adInfoEM)) {
            if (adTemplate.isWebViewDownload) {
                int iA = a(c0428a, adTemplate, adInfoEM);
                t(c0428a);
                adTemplate.isWebViewDownload = false;
                return iA;
            }
            if (j(c0428a)) {
                return 11;
            }
            t(c0428a);
            return a(c0428a, adTemplate, context);
        }
        if (c0428a.qg() == 2 || c0428a.qg() == 1) {
            c0428a.av(false);
            t(c0428a);
            return a(c0428a, adTemplate, adInfoEM);
        }
        if (c0428a.qb() && com.kwad.sdk.core.response.helper.a.b(adInfoEM, com.kwad.sdk.core.config.e.JU()) && !TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.aY(adInfoEM)) && !AdWebViewVideoActivityProxy.showingAdWebViewVideoActivity) {
            int iU = c0428a.it().u(c0428a);
            if (iU == 0) {
                t(c0428a);
                return a(c0428a, adTemplate, context);
            }
            t(c0428a);
            a.d(adTemplate, iU);
            return iU;
        }
        t(c0428a);
        c0428a.av(true);
        return a(c0428a, adTemplate, adInfoEM);
    }

    private static int b(a.C0428a c0428a) {
        Context context = c0428a.getContext();
        AdTemplate adTemplate = c0428a.getAdTemplate();
        AdWebViewActivityProxy.launch(context, new AdWebViewActivityProxy.a.C0449a().aX(com.kwad.sdk.core.response.helper.b.dh(adTemplate)).aU(adTemplate).aR(true).um());
        a.d(adTemplate, 20);
        return 20;
    }

    private static int a(a.C0428a c0428a, AdTemplate adTemplate, Context context) {
        AdWebViewActivityProxy.launch(context, new AdWebViewActivityProxy.a.C0449a().aX(com.kwad.sdk.core.response.helper.b.dh(adTemplate)).aU(adTemplate).aS(c0428a.pR()).bl(1).um());
        a.d(adTemplate, 14);
        return 14;
    }

    private static boolean j(a.C0428a c0428a) {
        AdTemplate adTemplate = c0428a.getAdTemplate();
        boolean zL = com.kwad.sdk.utils.f.l(c0428a.getContext(), adTemplate);
        if (zL) {
            t(c0428a);
            a.d(adTemplate, 11);
        }
        return zL;
    }

    private static int a(a.C0428a c0428a, AdTemplate adTemplate, AdInfo adInfo) {
        int iR;
        d dVarIt = c0428a.it();
        dVarIt.qr();
        switch (adInfo.status) {
            case 0:
            case 1:
            case 5:
            case 6:
            case 7:
                iR = r(c0428a);
                break;
            case 2:
            case 3:
            case 10:
            default:
                iR = 0;
                break;
            case 4:
                iR = dVarIt.qz();
                break;
            case 8:
            case 9:
            case 11:
                iR = dVarIt.qw();
                break;
            case 12:
                iR = d(adTemplate, adInfo);
                break;
        }
        a.d(c0428a.getAdTemplate(), iR);
        return iR;
    }

    private static int r(a.C0428a c0428a) {
        Context context = c0428a.getContext();
        AdTemplate adTemplate = c0428a.getAdTemplate();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if (com.kwad.sdk.utils.f.a(context, com.kwad.sdk.core.response.helper.a.dd(adInfoEM), adTemplate) || a(c0428a, adTemplate)) {
            return 11;
        }
        if (!aq.isNetworkConnected(context)) {
            ae.V(context, ag.dk(context));
            return 2;
        }
        return F(adInfoEM);
    }

    private static int d(final AdTemplate adTemplate, AdInfo adInfo) {
        i.execute(new bi() { // from class: com.kwad.components.core.e.d.c.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.components.d.f(com.kwad.components.a.a.a.class);
            }
        });
        au.az(ServiceProvider.getContext(), com.kwad.sdk.core.response.helper.a.aE(adInfo));
        return 6;
    }

    private static int F(AdInfo adInfo) {
        com.kwad.sdk.core.download.a.K(adInfo);
        return 3;
    }

    private static boolean a(a.C0428a c0428a, AdTemplate adTemplate) {
        return com.kwad.sdk.utils.f.l(c0428a.getContext(), adTemplate);
    }

    private static int s(a.C0428a c0428a) {
        Context context = c0428a.getContext();
        AdTemplate adTemplate = c0428a.getAdTemplate();
        int iF = f.f(context, adTemplate);
        if (iF == 1) {
            t(c0428a);
            a.d(adTemplate, 12);
        }
        return iF;
    }

    private static void t(a.C0428a c0428a) {
        if (c0428a.pQ() != null) {
            try {
                c0428a.pQ().onAdClicked();
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
    }
}
