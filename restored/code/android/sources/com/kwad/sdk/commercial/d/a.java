package com.kwad.sdk.commercial.d;

import android.text.TextUtils;
import com.kwad.components.offline.api.core.api.ILoggerReporter;
import com.kwad.sdk.commercial.d;
import com.kwad.sdk.commercial.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.internal.api.SceneImpl;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static void c(AdTemplate adTemplate, String str, String str2) {
        com.kwad.sdk.commercial.c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(0.01d).b(e.bw(adTemplate)).P("ad_sdk_ad_data_performance", "error_name").A(b.ID().du(str).dv(str2).setAdTemplate(adTemplate)));
    }

    public static void a(SceneImpl sceneImpl, long j, String str) {
        if (sceneImpl == null) {
            return;
        }
        try {
            com.kwad.sdk.commercial.c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(0.01d).b(e.di(sceneImpl.getAdStyle())).P("ad_sdk_ad_parse_performance", "default").A(c.IE().dw(str).setPosId(sceneImpl.posId).setLlsid(j)));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void a(SceneImpl sceneImpl, long j, String str, String str2) {
        if (sceneImpl == null) {
            return;
        }
        try {
            com.kwad.sdk.commercial.c.d(d.Iz().dm(ILoggerReporter.Category.ERROR_LOG).g(0.01d).b(e.di(sceneImpl.getAdStyle())).P("ad_sdk_ad_parse_performance", "default").A(c.IE().dw(str).dx(str2).setErrorCode(100013).setPosId(sceneImpl.posId).setLlsid(j)));
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void ce(AdTemplate adTemplate) {
        try {
            if (adTemplate.llsid == 0) {
                c(adTemplate, "llsid", "");
            }
            if (com.kwad.sdk.core.response.helper.e.eW(adTemplate) == 0) {
                c(adTemplate, "create_id", "");
            }
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
            int i = adInfoEM.adBaseInfo.adOperationType;
            if (i == 1) {
                String strDb = com.kwad.sdk.core.response.helper.a.db(adInfoEM);
                if (by.iq(strDb)) {
                    c(adTemplate, "download_url", strDb);
                }
            } else if (i == 2) {
                String strAY = com.kwad.sdk.core.response.helper.a.aY(adInfoEM);
                if (by.iq(strAY)) {
                    c(adTemplate, "h5_url", strAY);
                }
            }
            AdInfo.AdMaterialInfo.MaterialFeature materialFeatureP = com.kwad.sdk.core.response.helper.a.P(adInfoEM);
            int i2 = materialFeatureP.featureType;
            String str = materialFeatureP.materialUrl;
            if (i2 == 1) {
                if (by.iq(str)) {
                    c(adTemplate, "video_url", str);
                    return;
                }
                return;
            }
            if (i2 == 2) {
                if (by.iq(str)) {
                    c(adTemplate, "image_url", str);
                }
            } else if (i2 == 3) {
                long jCw = com.kwad.sdk.core.response.helper.a.cw(adInfoEM);
                String strBn = com.kwad.sdk.core.response.helper.a.bn(adInfoEM);
                if (jCw == 0) {
                    c(adTemplate, "live_author_id", "");
                } else if (TextUtils.isEmpty(strBn)) {
                    c(adTemplate, "live_stream_id", strBn);
                }
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static void n(AdTemplate adTemplate, String str) {
        c(adTemplate, "tk_template_id", str);
    }
}
