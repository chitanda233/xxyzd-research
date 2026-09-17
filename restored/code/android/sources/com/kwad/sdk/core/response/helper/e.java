package com.kwad.sdk.core.response.helper;

import android.text.TextUtils;
import com.kwad.sdk.api.model.KsLiveInfo;
import com.kwad.sdk.api.model.liveModel.KsCouponInfo;
import com.kwad.sdk.api.model.liveModel.KsLiveBaseInfo;
import com.kwad.sdk.api.model.liveModel.KsLiveShopInfo;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdProductInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.CouponInfo;
import com.kwad.sdk.core.response.model.PhotoInfo;
import com.kwad.sdk.service.ServiceProvider;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private static g NI() {
        com.kwad.sdk.service.a.f fVar = (com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class);
        if (fVar != null) {
            return fVar.Au();
        }
        return null;
    }

    public static boolean eE(AdTemplate adTemplate) {
        return (adTemplate.realShowType != 2 || adTemplate.adInfoList.isEmpty() || adTemplate.adInfoList.get(0) == null) ? false : true;
    }

    public static long eF(AdTemplate adTemplate) {
        return adTemplate.posId;
    }

    public static int eG(AdTemplate adTemplate) {
        return adTemplate.adStyle;
    }

    @Deprecated
    public static int eH(AdTemplate adTemplate) {
        if (adTemplate != null) {
            return (adTemplate.mAdScene == null || adTemplate.mAdScene.adStyle == 0) ? eG(adTemplate) : adTemplate.mAdScene.getAdStyle();
        }
        return 0;
    }

    public static int eI(AdTemplate adTemplate) {
        return adTemplate.contentType;
    }

    public static long eJ(AdTemplate adTemplate) {
        return adTemplate.llsid;
    }

    public static String eK(AdTemplate adTemplate) {
        return adTemplate.extra;
    }

    public static String eL(AdTemplate adTemplate) {
        return adTemplate.impAdExtra;
    }

    public static AdInfo eM(AdTemplate adTemplate) {
        AdInfo adInfo = adTemplate.adInfoList.size() > 0 ? adTemplate.adInfoList.get(0) : null;
        if (adInfo != null) {
            return adInfo;
        }
        com.kwad.sdk.core.d.c.e("AdTemplateHelper", "adInfo in null");
        return new AdInfo();
    }

    public static PhotoInfo eN(AdTemplate adTemplate) {
        return adTemplate.photoInfo;
    }

    public static String eO(AdTemplate adTemplate) {
        if (eE(adTemplate)) {
            return a.M(eM(adTemplate));
        }
        return h.a(eN(adTemplate));
    }

    public static String eP(AdTemplate adTemplate) {
        return eM(adTemplate).adConversionInfo.appDownloadUrl;
    }

    public static String eQ(AdTemplate adTemplate) {
        g gVarNI = NI();
        String strNM = gVarNI == null ? "" : gVarNI.NM();
        return TextUtils.isEmpty(strNM) ? strNM : a.ab(eM(adTemplate));
    }

    public static String eR(AdTemplate adTemplate) {
        if (eE(adTemplate)) {
            return a.cv(eM(adTemplate));
        }
        g gVarNI = NI();
        return gVarNI == null ? "" : gVarNI.NN();
    }

    public static long eS(AdTemplate adTemplate) {
        if (eE(adTemplate)) {
            return a.ae(eM(adTemplate));
        }
        g gVarNI = NI();
        return gVarNI == null ? adTemplate.hashCode() : gVarNI.NO();
    }

    public static int eT(AdTemplate adTemplate) {
        g gVarNI = NI();
        if (gVarNI == null) {
            return 0;
        }
        return gVarNI.NP();
    }

    public static boolean m(AdTemplate adTemplate, boolean z) {
        if (adTemplate == null) {
            return false;
        }
        AdInfo adInfoEM = eM(adTemplate);
        return a.aL(adInfoEM) && !a.de(adInfoEM) && !z && eU(adTemplate) == 2;
    }

    public static boolean O(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return false;
        }
        AdInfo adInfoEM = eM(adTemplate);
        return (a.aL(adInfoEM) || a.de(adInfoEM) || eU(adTemplate) != 3) ? false : true;
    }

    public static int eU(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return -1;
        }
        return eM(adTemplate).adBaseInfo.taskType;
    }

    public static String eV(AdTemplate adTemplate) {
        if (eE(adTemplate)) {
            return a.cP(eM(adTemplate));
        }
        return h.c(eN(adTemplate));
    }

    public static long eW(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return 0L;
        }
        return eM(adTemplate).adBaseInfo.creativeId;
    }

    public static boolean eX(AdTemplate adTemplate) {
        return eM(adTemplate).adConversionInfo.blockCallbackIfSpam && adTemplate.mCheatingFlow;
    }

    public static boolean eY(AdTemplate adTemplate) {
        int iN = n(adTemplate, true);
        return iN == 1 || iN == 2;
    }

    public static boolean eZ(AdTemplate adTemplate) {
        int iN = n(adTemplate, false);
        return iN == 1 || iN == 2;
    }

    public static int n(AdTemplate adTemplate, boolean z) {
        int i;
        AdInfo adInfoEM = eM(adTemplate);
        if (!fg(adTemplate)) {
            return adInfoEM.adBaseInfo.mABParams.playableStyle;
        }
        if (z) {
            i = adInfoEM.adMatrixInfo.adDataV2.actionBarInfo.cardType;
        } else {
            i = adInfoEM.adMatrixInfo.adDataV2.endCardInfo.cardType;
        }
        if (i == 5) {
            return 1;
        }
        return i == 6 ? 2 : -1;
    }

    public static AdTemplate a(List<AdTemplate> list, long j, int i) {
        if (j >= 0 && list != null) {
            for (AdTemplate adTemplate : list) {
                if (b(adTemplate, j, i)) {
                    return adTemplate;
                }
            }
        }
        return null;
    }

    public static boolean b(List<AdTemplate> list, long j, int i) {
        AdTemplate adTemplateA = a(list, j, i);
        if (adTemplateA == null) {
            return false;
        }
        long jEW = eW(adTemplateA);
        int iEG = eG(adTemplateA);
        if (i > 0) {
            if (jEW != j || iEG != i) {
                return false;
            }
        } else if (jEW != j) {
            return false;
        }
        return true;
    }

    public static boolean b(AdTemplate adTemplate, long j, int i) {
        long jEW = eW(adTemplate);
        int iEG = eG(adTemplate);
        if (i > 0) {
            if (jEW == j && iEG == i) {
                return true;
            }
        } else if (jEW == j) {
            return true;
        }
        return false;
    }

    public static int fa(AdTemplate adTemplate) {
        return eM(adTemplate).adBaseInfo.ecpm;
    }

    public static boolean fb(AdTemplate adTemplate) {
        AdInfo adInfoEM = eM(adTemplate);
        return adInfoEM.adStyleConfInfo.adPushDownloadJumpType == 0 && eG(adTemplate) == 17 && a.aL(adInfoEM);
    }

    public static int fc(AdTemplate adTemplate) {
        if (adTemplate.adVideoPreCacheConfig == null) {
            com.kwad.sdk.service.a.h hVar = (com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class);
            if (hVar != null) {
                return hVar.Gm();
            }
            return 800;
        }
        return adTemplate.adVideoPreCacheConfig.adVideoPreCacheSize;
    }

    public static KsLiveInfo fd(AdTemplate adTemplate) {
        AdInfo adInfoEM = eM(adTemplate);
        if (adInfoEM.adBaseInfo.roiType == 0) {
            return null;
        }
        KsLiveInfo ksLiveInfo = new KsLiveInfo();
        ksLiveInfo.setRoiType(adInfoEM.adBaseInfo.roiType);
        KsLiveBaseInfo ksLiveBaseInfo = ksLiveInfo.getKsLiveBaseInfo();
        if (adInfoEM.advertiserInfo.userName != null) {
            ksLiveBaseInfo.setUserName(adInfoEM.advertiserInfo.userName);
        }
        if (adInfoEM.advertiserInfo.portraitUrl != null) {
            ksLiveBaseInfo.setPortraitUrl(adInfoEM.advertiserInfo.portraitUrl);
        }
        if (adInfoEM.adBaseInfo.liveDisplayWatchingCount > 0) {
            ksLiveBaseInfo.setLiveDisplayWatchingCount(adInfoEM.adBaseInfo.liveDisplayWatchingCount);
        }
        KsLiveShopInfo ksLiveShopInfo = new KsLiveShopInfo();
        AdProductInfo adProductInfo = adInfoEM.adProductInfo;
        ksLiveShopInfo.setIcon(adProductInfo.icon);
        ksLiveShopInfo.setName(adProductInfo.name);
        ksLiveShopInfo.setPrice(adProductInfo.price);
        ksLiveShopInfo.setOriginPrice(adProductInfo.originPrice);
        ksLiveShopInfo.setVolume(adProductInfo.volume);
        if (adProductInfo.couponList != null && adProductInfo.couponList.size() > 0) {
            ksLiveShopInfo.setHaveCoupon(true);
        }
        ksLiveInfo.getKsLiveShopInfo().add(ksLiveShopInfo);
        KsCouponInfo ksCouponInfo = new KsCouponInfo();
        CouponInfo firstCouponList = adProductInfo.getFirstCouponList();
        if (firstCouponList != null) {
            ksCouponInfo.setDisplayBase(firstCouponList.displayBase);
            ksCouponInfo.setDisplayType(firstCouponList.displayType);
            ksCouponInfo.setDisplayValue(firstCouponList.displayValue);
            ksCouponInfo.setEndFetchTime(firstCouponList.endFetchTime);
            ksCouponInfo.setStartFetchTime(firstCouponList.startFetchTime);
            ksLiveInfo.getKsCouponInfo().add(ksCouponInfo);
        }
        return ksLiveInfo;
    }

    public static int fe(AdTemplate adTemplate) {
        return eM(adTemplate).adBaseInfo.adRolloutSize;
    }

    public static boolean ff(AdTemplate adTemplate) {
        int iEG = eG(adTemplate);
        if (iEG == 13) {
            return true;
        }
        return iEG == 23 && fe(adTemplate) == 2;
    }

    public static boolean fg(AdTemplate adTemplate) {
        int iEG = eG(adTemplate);
        if (iEG == 3) {
            return true;
        }
        return iEG == 23 && fe(adTemplate) == 1;
    }

    public static int fh(AdTemplate adTemplate) {
        return adTemplate.type;
    }

    public static int fi(AdTemplate adTemplate) {
        return adTemplate.defaultType;
    }

    public static long fj(AdTemplate adTemplate) {
        return eM(adTemplate).adProductInfo.itemId;
    }

    public static boolean fk(AdTemplate adTemplate) {
        return (adTemplate == null || adTemplate.liveInfo == null || adTemplate.liveInfo.playInfo == null) ? false : true;
    }
}
