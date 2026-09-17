package com.kwad.components.ad.c;

import android.os.SystemClock;
import android.text.TextUtils;
import com.kwad.components.ad.KsAdLoadManager;
import com.kwad.components.core.request.j;
import com.kwad.components.core.request.model.ImpInfo;
import com.kwad.components.core.t.t;
import com.kwad.sdk.api.KsBannerAd;
import com.kwad.sdk.api.KsLoadManager;
import com.kwad.sdk.api.KsScene;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.AdVideoPreCacheConfig;
import com.kwad.sdk.internal.api.SceneImpl;
import com.kwad.sdk.o;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import com.kwad.sdk.utils.l;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    public static KsScene cf;

    public static void loadBannerAd(KsScene ksScene, final KsLoadManager.BannerAdListener bannerAdListener) {
        final long jElapsedRealtime = SystemClock.elapsedRealtime();
        if (!o.GE().FJ()) {
            com.kwad.sdk.core.d.c.e("KsAdBannerLoadManager", "loadBannerAd please init sdk first");
            by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.c.g.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    bannerAdListener.onError(com.kwad.sdk.core.network.e.aTe.errorCode, com.kwad.sdk.core.network.e.aTe.msg + "sdk not init");
                }
            });
            return;
        }
        ksScene.setAdNum(com.kwad.sdk.core.config.e.KQ());
        cf = ksScene;
        final SceneImpl sceneImplCovert = SceneImpl.covert(ksScene);
        com.kwad.sdk.commercial.convert.e.c(sceneImplCovert);
        boolean zB = t.xg().b(sceneImplCovert, "loadBannerAd");
        sceneImplCovert.setAdStyle(5);
        KsAdLoadManager.O().a(new com.kwad.components.core.request.model.a.C0459a().e(new ImpInfo(sceneImplCovert)).aZ(zB).a(new j() { // from class: com.kwad.components.ad.c.g.3
            @Override // com.kwad.components.core.request.j
            public final void ak() {
            }
        }).a(new com.kwad.components.core.request.d() { // from class: com.kwad.components.ad.c.g.2
            @Override // com.kwad.components.core.request.d, com.kwad.components.core.request.l
            public final void onError(final int i, final String str) {
                if (i != com.kwad.sdk.core.network.e.aTe.errorCode) {
                    com.kwad.sdk.core.network.e eVar = com.kwad.sdk.core.network.e.aSZ;
                }
                by.runOnUiThread(new bi() { // from class: com.kwad.components.ad.c.g.2.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        bannerAdListener.onError(i, str);
                    }
                });
            }

            @Override // com.kwad.components.core.request.d, com.kwad.components.core.request.c
            public final void a(AdResultData adResultData, boolean z) {
                List listA = g.a(sceneImplCovert, adResultData.getAdTemplateList());
                if (listA.isEmpty()) {
                    onError(com.kwad.sdk.core.network.e.aTe.errorCode, TextUtils.isEmpty(adResultData.testErrorMsg) ? com.kwad.sdk.core.network.e.aTe.msg : adResultData.testErrorMsg);
                    l.as("bannerAd_", "onBannerAdCacheFailed");
                    return;
                }
                AdVideoPreCacheConfig adVideoPreCacheConfigObtainVideoPreCacheConfig = AdResultData.obtainVideoPreCacheConfig(adResultData, com.kwad.sdk.core.config.e.Gm());
                final AdTemplate adTemplate = (AdTemplate) listA.get(0);
                new h(adResultData);
                com.kwad.sdk.commercial.convert.e.a(sceneImplCovert, listA.size());
                final h hVar = new h(adResultData);
                com.kwad.sdk.core.config.e.KM();
                AdTemplate adTemplate2 = hVar.getAdTemplate();
                if (com.kwad.sdk.core.response.helper.a.bj(com.kwad.sdk.core.response.helper.e.eM(adTemplate2))) {
                    g.a(adTemplate, bannerAdListener, hVar, jElapsedRealtime);
                } else {
                    com.kwad.components.ad.c.a.a.a(adTemplate2, adVideoPreCacheConfigObtainVideoPreCacheConfig, new com.kwad.components.ad.c.a.b() { // from class: com.kwad.components.ad.c.g.2.2
                        @Override // com.kwad.components.ad.c.a.b
                        public final void ai() {
                            com.kwad.sdk.core.d.c.d("KsAdBannerLoadManager", "loadFullScreenVideoAd startCacheVideo onCacheTargetSuccess");
                            g.a(adTemplate, bannerAdListener, hVar, jElapsedRealtime);
                        }

                        @Override // com.kwad.components.ad.c.a.b
                        public final void aj() {
                            g.a(adTemplate, bannerAdListener, hVar, jElapsedRealtime);
                        }
                    });
                }
                com.kwad.sdk.core.d.c.d("KsAdBannerLoadManager", "loadFullScreenVideoAd after cache");
            }
        }).wp());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static List<AdTemplate> a(SceneImpl sceneImpl, List<AdTemplate> list) {
        ArrayList arrayList = new ArrayList();
        if (list.isEmpty()) {
            return arrayList;
        }
        for (AdTemplate adTemplate : list) {
            if (adTemplate != null) {
                if (adTemplate.mAdScene == null) {
                    adTemplate.mAdScene = sceneImpl;
                }
                AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
                if (1 == com.kwad.sdk.core.response.helper.a.bk(adInfoEM)) {
                    arrayList.add(adTemplate);
                } else if (com.kwad.sdk.core.response.helper.a.bj(adInfoEM)) {
                    arrayList.add(adTemplate);
                }
            }
        }
        return arrayList;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void a(final AdTemplate adTemplate, final KsLoadManager.BannerAdListener bannerAdListener, final KsBannerAd ksBannerAd, final long j) {
        by.postOnUiThread(new bi() { // from class: com.kwad.components.ad.c.g.4
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                l.as("bannerAd_", "onBannerAdCacheSuccess");
                try {
                    com.kwad.sdk.commercial.convert.d.a(com.kwad.sdk.core.response.helper.e.eG(adTemplate), SystemClock.elapsedRealtime() - j, 2);
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
                bannerAdListener.onBannerAdLoad(ksBannerAd);
            }
        });
    }
}
