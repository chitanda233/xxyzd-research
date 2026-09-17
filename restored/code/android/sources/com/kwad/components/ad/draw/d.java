package com.kwad.components.ad.draw;

import android.os.SystemClock;
import android.text.TextUtils;
import com.kwad.components.ad.KsAdLoadManager;
import com.kwad.components.core.request.model.ImpInfo;
import com.kwad.components.core.t.t;
import com.kwad.sdk.api.KsLoadManager;
import com.kwad.sdk.api.KsScene;
import com.kwad.sdk.commercial.convert.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.internal.api.SceneImpl;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.ArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    public static void loadDrawAd(KsScene ksScene, final KsLoadManager.DrawAdListener drawAdListener) {
        final long jElapsedRealtime = SystemClock.elapsedRealtime();
        final SceneImpl sceneImplCovert = SceneImpl.covert(ksScene);
        if (sceneImplCovert.getAdNum() <= 0) {
            com.kwad.components.ad.draw.a.c.a(sceneImplCovert, "ad_num");
        }
        boolean zB = t.xg().b(sceneImplCovert, "loadDrawAd");
        sceneImplCovert.setAdStyle(6);
        com.kwad.components.ad.draw.a.c.b(sceneImplCovert);
        e.c(sceneImplCovert);
        final long jElapsedRealtime2 = SystemClock.elapsedRealtime();
        KsAdLoadManager.O().a(new com.kwad.components.core.request.model.a.C0459a().e(new ImpInfo(sceneImplCovert)).aZ(zB).a(new com.kwad.components.core.request.d() { // from class: com.kwad.components.ad.draw.d.1
            @Override // com.kwad.components.core.request.d, com.kwad.components.core.request.l
            public final void onError(final int i, final String str) {
                com.kwad.components.ad.draw.a.c.a(sceneImplCovert, i, str, SystemClock.elapsedRealtime() - jElapsedRealtime2);
                by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.draw.d.1.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        drawAdListener.onError(i, str);
                    }
                });
            }

            @Override // com.kwad.components.core.request.d, com.kwad.components.core.request.l
            public final void b(AdResultData adResultData) {
                com.kwad.components.ad.draw.a.c.a(sceneImplCovert, adResultData.getAdTemplateList().size(), SystemClock.elapsedRealtime() - jElapsedRealtime2);
                final ArrayList arrayList = new ArrayList();
                for (AdTemplate adTemplate : adResultData.getAdTemplateList()) {
                    if (adTemplate != null) {
                        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
                        if (adTemplate.adStyle != 6) {
                            com.kwad.components.ad.draw.a.c.h(adTemplate);
                        }
                        if (!com.kwad.sdk.core.response.helper.a.cY(adInfoEM) && TextUtils.isEmpty(com.kwad.sdk.core.response.helper.a.M(adInfoEM))) {
                            com.kwad.components.ad.draw.a.c.h(adTemplate);
                        } else {
                            arrayList.add(new c(com.kwad.sdk.core.response.helper.c.a(adResultData, adTemplate)));
                        }
                    }
                }
                if (arrayList.isEmpty()) {
                    onError(com.kwad.sdk.core.network.e.aTe.errorCode, TextUtils.isEmpty(adResultData.testErrorMsg) ? com.kwad.sdk.core.network.e.aTe.msg + "(无视频资源)" : adResultData.testErrorMsg);
                } else {
                    by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.draw.d.1.2
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            KsAdLoadManager.O().b(arrayList);
                            try {
                                com.kwad.sdk.commercial.convert.d.a(sceneImplCovert.adStyle, SystemClock.elapsedRealtime() - jElapsedRealtime, 1);
                            } catch (Throwable th) {
                                ServiceProvider.reportSdkCaughtException(th);
                            }
                            drawAdListener.onDrawAdLoad(arrayList);
                        }
                    });
                }
                com.kwad.components.ad.draw.a.c.b(sceneImplCovert, arrayList.size(), SystemClock.elapsedRealtime() - jElapsedRealtime2);
                e.a(sceneImplCovert, arrayList.size());
            }
        }).wp());
    }
}
