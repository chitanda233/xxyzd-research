package com.kwad.components.ad.interstitial.a;

import android.text.TextUtils;
import com.kwad.components.ad.interstitial.report.b;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.videocache.f;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.y;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static boolean s(AdTemplate adTemplate) {
        boolean zA;
        f fVarCl;
        String strM = com.kwad.sdk.core.response.helper.a.M(e.eM(adTemplate));
        if (TextUtils.isEmpty(strM)) {
            b.eV().b(adTemplate, "empty videoUrl");
            return false;
        }
        b.eV().x(adTemplate);
        int iGm = com.kwad.sdk.core.config.e.Gm();
        String str = "";
        if (iGm < 0) {
            File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(strM);
            if (y.Q(fileCM)) {
                zA = true;
            } else {
                com.kwad.sdk.core.network.a.a.C0515a c0515a = new com.kwad.sdk.core.network.a.a.C0515a();
                zA = com.kwad.sdk.core.diskcache.b.a.LI().a(strM, c0515a);
                str = c0515a.msg;
            }
            adTemplate.setDownloadSize(fileCM != null ? fileCM.length() : 0L);
            adTemplate.setDownloadType(2);
        } else if (iGm > 0) {
            com.kwad.sdk.core.network.a.a.C0515a c0515a2 = new com.kwad.sdk.core.network.a.a.C0515a();
            if (com.kwad.sdk.core.config.e.KL() == 1) {
                fVarCl = com.kwad.sdk.core.videocache.c.a.b(ServiceProvider.getContext(), 1, 0);
            } else if (com.kwad.sdk.core.config.e.KL() == 2) {
                fVarCl = com.kwad.sdk.core.videocache.c.a.b(ServiceProvider.getContext(), 1, 1);
            } else {
                fVarCl = com.kwad.sdk.core.videocache.c.a.cl(ServiceProvider.getContext());
            }
            zA = !fVarCl.fx(strM) ? fVarCl.a(strM, iGm * 1024, c0515a2, null) : true;
            str = c0515a2.msg;
            adTemplate.setDownloadSize(((long) iGm) * 1024);
            adTemplate.setDownloadType(3);
        } else {
            adTemplate.setDownloadSize(0L);
            adTemplate.setDownloadType(1);
            zA = true;
        }
        if (!zA) {
            adTemplate.setDownloadStatus(2);
            b.eV().b(adTemplate, str);
            com.kwad.components.ad.interstitial.report.realtime.a.fb();
            com.kwad.components.ad.interstitial.report.realtime.a.b(str, adTemplate);
        } else {
            adTemplate.setDownloadStatus(1);
        }
        return zA;
    }
}
