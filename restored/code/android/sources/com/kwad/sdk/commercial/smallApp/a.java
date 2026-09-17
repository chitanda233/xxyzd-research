package com.kwad.sdk.commercial.smallApp;

import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.commercial.c;
import com.kwad.sdk.commercial.d;
import com.kwad.sdk.commercial.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static void a(AdTemplate adTemplate, com.kwad.sdk.commercial.c.a aVar) {
        a(adTemplate, false, aVar);
    }

    private static void a(AdTemplate adTemplate, boolean z, com.kwad.sdk.commercial.c.a aVar) {
        aVar.setAdTemplate(adTemplate);
        c.d(d.Iz().dm(z ? ILoggerReporter.Category.ERROR_LOG : ILoggerReporter.Category.APM_LOG).g(z ? 1.0d : 0.01d).b(e.bw(adTemplate)).P("ad_sdk_small_app_performance", "status").A(aVar));
    }

    public static void a(AdTemplate adTemplate, JumpFrom jumpFrom, AdInfo.SmallAppJumpInfo smallAppJumpInfo) {
        if (adTemplate == null || smallAppJumpInfo == null) {
            return;
        }
        try {
            a(adTemplate, b.a(jumpFrom).du(1).dH(smallAppJumpInfo.mediaSmallAppId).dG(smallAppJumpInfo.originId).dF(smallAppJumpInfo.smallAppJumpUrl));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void b(AdTemplate adTemplate, JumpFrom jumpFrom, AdInfo.SmallAppJumpInfo smallAppJumpInfo) {
        if (adTemplate == null || smallAppJumpInfo == null) {
            return;
        }
        try {
            a(adTemplate, b.a(jumpFrom).du(2).dH(smallAppJumpInfo.mediaSmallAppId).dG(smallAppJumpInfo.originId).dF(smallAppJumpInfo.smallAppJumpUrl));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(AdTemplate adTemplate, JumpFrom jumpFrom, String str, String str2, String str3) {
        try {
            a(adTemplate, b.a(jumpFrom).du(3).dH(str).dG(str2).dF(str3));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(AdTemplate adTemplate, JumpFrom jumpFrom, AdInfo.SmallAppJumpInfo smallAppJumpInfo, String str) {
        if (adTemplate == null) {
            return;
        }
        try {
            String str2 = "";
            b bVarDG = b.a(jumpFrom).du(4).dH(smallAppJumpInfo == null ? "" : smallAppJumpInfo.mediaSmallAppId).dG(smallAppJumpInfo == null ? "" : smallAppJumpInfo.originId);
            if (smallAppJumpInfo != null) {
                str2 = smallAppJumpInfo.smallAppJumpUrl;
            }
            a(adTemplate, true, bVarDG.dF(str2).setErrorCode(100008).setErrorMsg(str));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
