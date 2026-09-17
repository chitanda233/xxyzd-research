package com.kwad.components.ad.feed.monitor;

import android.text.TextUtils;
import android.util.Pair;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.videocache.f;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.y;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static Pair<Integer, String> m(AdTemplate adTemplate) {
        String strM = com.kwad.sdk.core.response.helper.a.M(e.eM(adTemplate));
        if (TextUtils.isEmpty(strM)) {
            return new Pair<>(2, "empty videoUrl");
        }
        int iGm = com.kwad.sdk.core.config.e.Gm();
        int i = 1;
        String str = "";
        if (iGm < 0) {
            File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(strM);
            if (!y.Q(fileCM)) {
                com.kwad.sdk.core.network.a.a.C0515a c0515a = new com.kwad.sdk.core.network.a.a.C0515a();
                int i2 = com.kwad.sdk.core.diskcache.b.a.LI().a(strM, c0515a) ? 1 : 2;
                str = c0515a.msg;
                i = i2;
            }
            adTemplate.setDownloadSize(fileCM != null ? fileCM.length() : 0L);
        } else if (iGm > 0) {
            com.kwad.sdk.core.network.a.a.C0515a c0515a2 = new com.kwad.sdk.core.network.a.a.C0515a();
            f fVarCl = com.kwad.sdk.core.videocache.c.a.cl(ServiceProvider.getContext());
            if (!fVarCl.fx(strM)) {
                i = fVarCl.a(strM, (long) (iGm * 1024), c0515a2, null) ? 1 : 2;
            }
            str = c0515a2.msg;
            adTemplate.setDownloadSize(iGm * 1024);
        } else {
            adTemplate.setDownloadSize(0L);
        }
        return new Pair<>(Integer.valueOf(i), str);
    }
}
