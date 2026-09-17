package com.kwad.sdk.core.response.helper;

import android.text.TextUtils;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.FeedSlideConf;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.br;
import java.util.List;
import java.util.Random;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private static Random aXC = new Random();

    public static AdMatrixInfo cJ(AdTemplate adTemplate) {
        if (e.eE(adTemplate)) {
            return e.eM(adTemplate).adMatrixInfo;
        }
        return new AdMatrixInfo();
    }

    public static List<AdMatrixInfo.MatrixTemplate> cK(AdTemplate adTemplate) {
        return cJ(adTemplate).styles.templateList;
    }

    public static AdMatrixInfo.AdDataV2 cL(AdTemplate adTemplate) {
        return e.eM(adTemplate).adMatrixInfo.adDataV2;
    }

    public static AdMatrixInfo.MatrixTemplate t(AdTemplate adTemplate, String str) {
        for (AdMatrixInfo.MatrixTemplate matrixTemplate : cJ(adTemplate).styles.templateList) {
            if (br.isEquals(str, matrixTemplate.templateId)) {
                return matrixTemplate;
            }
        }
        return null;
    }

    private static AdMatrixInfo.TemplateData u(AdTemplate adTemplate, String str) {
        for (AdMatrixInfo.TemplateData templateData : cJ(adTemplate).adDataV2.templateDataList) {
            if (br.isEquals(str, templateData.templateId)) {
                return templateData;
            }
        }
        return null;
    }

    private static long v(AdTemplate adTemplate, String str) {
        AdMatrixInfo.TemplateData templateDataU = u(adTemplate, str);
        if (templateDataU != null) {
            return templateDataU.templateDelayTime;
        }
        return 0L;
    }

    public static FeedSlideConf cM(AdTemplate adTemplate) {
        JSONArray jSONArrayOptJSONArray;
        AdMatrixInfo.TemplateData templateDataU = u(adTemplate, dj(adTemplate).templateId);
        try {
            JSONObject jSONObjectOptJSONObject = new JSONObject(templateDataU != null ? templateDataU.data : "").optJSONObject("slideInfo");
            if (jSONObjectOptJSONObject != null && (jSONArrayOptJSONArray = jSONObjectOptJSONObject.optJSONArray("angle")) != null && jSONArrayOptJSONArray.length() > 1) {
                FeedSlideConf feedSlideConf = new FeedSlideConf();
                feedSlideConf.minRange = ((Integer) jSONArrayOptJSONArray.get(0)).intValue();
                feedSlideConf.maxRange = ((Integer) jSONArrayOptJSONArray.get(1)).intValue();
                return feedSlideConf;
            }
        } catch (Throwable unused) {
        }
        return null;
    }

    public static AdMatrixInfo.InterstitialCardInfo cN(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.interstitialCardInfo;
    }

    public static String cO(AdTemplate adTemplate) {
        AdMatrixInfo.MatrixTemplate matrixTemplateT = t(adTemplate, cJ(adTemplate).adDataV2.splashActionBarInfo.templateId);
        return matrixTemplateT != null ? matrixTemplateT.templateUrl : "";
    }

    private static AdMatrixInfo.ActionBarInfoNew cP(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.actionBarInfo;
    }

    public static String cQ(AdTemplate adTemplate) {
        AdInfo adInfoEM = e.eM(adTemplate);
        boolean z = e.fg(adTemplate) || e.eG(adTemplate) == 2;
        if (a.cY(adInfoEM)) {
            return "";
        }
        if (z && a.cI(adTemplate)) {
            AdMatrixInfo.MatrixTemplate matrixTemplateT = t(adTemplate, dP(adTemplate).templateId);
            return matrixTemplateT != null ? matrixTemplateT.templateUrl : "";
        }
        AdMatrixInfo.MatrixTemplate matrixTemplateT2 = t(adTemplate, cP(adTemplate).templateId);
        return matrixTemplateT2 != null ? matrixTemplateT2.templateUrl : "";
    }

    public static boolean fk(String str) {
        try {
            return ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).cN(str);
        } catch (Exception unused) {
            return false;
        }
    }

    public static long cR(AdTemplate adTemplate) {
        return cP(adTemplate).maxTimeOut;
    }

    public static boolean cS(AdTemplate adTemplate) {
        return !TextUtils.isEmpty(cQ(adTemplate));
    }

    private static AdMatrixInfo.AggregationCardInfo cT(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.aggregationCardInfo;
    }

    public static String cU(AdTemplate adTemplate) {
        AdMatrixInfo.MatrixTemplate matrixTemplateT = t(adTemplate, cT(adTemplate).templateId);
        return matrixTemplateT != null ? matrixTemplateT.templateUrl : "";
    }

    public static long cV(AdTemplate adTemplate) {
        return v(adTemplate, cT(adTemplate).templateId);
    }

    public static long cW(AdTemplate adTemplate) {
        return ((long) cT(adTemplate).changeTime) * 1000;
    }

    public static int cX(AdTemplate adTemplate) {
        return cT(adTemplate).maxTimesPerDay;
    }

    public static long cY(AdTemplate adTemplate) {
        return cT(adTemplate).intervalTime;
    }

    public static boolean cZ(AdTemplate adTemplate) {
        AdInfo adInfoEM = e.eM(adTemplate);
        return !a.aL(adInfoEM) && a.az(adInfoEM);
    }

    public static boolean da(AdTemplate adTemplate) {
        if (!TextUtils.isEmpty(cU(adTemplate)) && cV(adTemplate) > 0) {
            return as.isOrientationPortrait();
        }
        return false;
    }

    private static AdMatrixInfo.BaseMatrixTemplate db(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.halfCardInfo;
    }

    public static String dc(AdTemplate adTemplate) {
        AdMatrixInfo.MatrixTemplate matrixTemplateT = t(adTemplate, db(adTemplate).templateId);
        return matrixTemplateT != null ? matrixTemplateT.templateUrl : "";
    }

    private static AdMatrixInfo.EndCardInfo dd(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.endCardInfo;
    }

    public static String de(AdTemplate adTemplate) {
        AdMatrixInfo.MatrixTemplate matrixTemplateT = t(adTemplate, dd(adTemplate).templateId);
        return matrixTemplateT != null ? matrixTemplateT.templateUrl : "";
    }

    public static boolean df(AdTemplate adTemplate) {
        return !TextUtils.isEmpty(de(adTemplate));
    }

    private static String dg(AdTemplate adTemplate) {
        AdMatrixInfo.MatrixTemplate matrixTemplateT = t(adTemplate, e.eM(adTemplate).adMatrixInfo.adDataV2.activityMiddlePageInfo.templateId);
        return matrixTemplateT != null ? matrixTemplateT.templateUrl : "";
    }

    public static String dh(AdTemplate adTemplate) {
        if (di(adTemplate)) {
            return dg(adTemplate);
        }
        return a.aY(e.eM(adTemplate));
    }

    private static boolean di(AdTemplate adTemplate) {
        return (adTemplate.mIsForceJumpLandingPage || a.cG(adTemplate) || !dQ(e.eM(adTemplate))) ? false : true;
    }

    private static AdMatrixInfo.FeedInfo dj(AdTemplate adTemplate) {
        if (dl(adTemplate)) {
            return cJ(adTemplate).adDataV2.adUnionFeedLiveTemplateInfo;
        }
        return cJ(adTemplate).adDataV2.feedInfo;
    }

    private static AdMatrixInfo.NativeMatrixAdInfo dk(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.nativeAdInfo;
    }

    private static boolean dl(AdTemplate adTemplate) {
        return a.cY(e.eM(adTemplate));
    }

    private static AdMatrixInfo.FeedInfo dm(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.adUnionFeedLiveMediaInfo;
    }

    public static String dn(AdTemplate adTemplate) {
        AdMatrixInfo.MatrixTemplate matrixTemplateT = t(adTemplate, dj(adTemplate).templateId);
        return matrixTemplateT != null ? matrixTemplateT.templateUrl : "";
    }

    /* JADX INFO: renamed from: do, reason: not valid java name */
    private static AdMatrixInfo.FeedTKInfo m179do(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.feedTKCardInfo;
    }

    public static AdMatrixInfo.NativeTKInfo dp(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.nativeTKCardInfo;
    }

    public static String dq(AdTemplate adTemplate) {
        AdMatrixInfo.MatrixTemplate matrixTemplateT = t(adTemplate, dm(adTemplate).templateId);
        return matrixTemplateT != null ? matrixTemplateT.templateUrl : "";
    }

    public static boolean dr(AdTemplate adTemplate) {
        return dj(adTemplate).interactionInfo.interactiveStyle == 2;
    }

    public static boolean ds(AdTemplate adTemplate) {
        return dj(adTemplate).interactionInfo.shakeInfo.clickDisabled;
    }

    public static int dt(AdTemplate adTemplate) {
        AdMatrixInfo.AdInteractionInfo adInteractionInfo = dj(adTemplate).interactionInfo;
        if (adInteractionInfo == null || adInteractionInfo.shakeInfo == null) {
            return 0;
        }
        return adInteractionInfo.shakeInfo.acceleration;
    }

    public static boolean dI(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.feedInfo.interactionInfo.shakeInfo.enable;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static boolean dJ(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.feedInfo.interactionInfo.shakeInfo.bidirectionalSwitch;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static boolean du(AdTemplate adTemplate) {
        AdMatrixInfo.AdInteractionInfo adInteractionInfo = dk(adTemplate).interactionInfo;
        if (adInteractionInfo == null || adInteractionInfo.shakeInfo == null) {
            return false;
        }
        return adInteractionInfo.shakeInfo.enable;
    }

    public static int dv(AdTemplate adTemplate) {
        AdMatrixInfo.AdInteractionInfo adInteractionInfo = dk(adTemplate).interactionInfo;
        if (adInteractionInfo == null || adInteractionInfo.shakeInfo == null) {
            return 0;
        }
        return adInteractionInfo.shakeInfo.acceleration;
    }

    public static boolean dK(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.nativeAdInfo.interactionInfo.shakeInfo.bidirectionalSwitch;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            try {
                return adInfo.adStyleConfInfo.nativeAdInfo.shakeInfo.bidirectionalSwitch;
            } catch (Exception e2) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e2);
                return false;
            }
        }
    }

    public static double dw(AdTemplate adTemplate) {
        return e.eM(adTemplate).adStyleInfo.feedAdInfo.heightRatio;
    }

    public static boolean dL(AdInfo adInfo) {
        return !TextUtils.isEmpty(adInfo.adMatrixInfo.adDataV2.splashEndCardTKInfo.templateId);
    }

    public static boolean dM(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashEndCardTKInfo.endCardFullScreenClick;
    }

    public static boolean dN(AdInfo adInfo) {
        return !TextUtils.isEmpty(adInfo.adMatrixInfo.adDataV2.topFloorTKInfo.templateId);
    }

    public static boolean dO(AdInfo adInfo) {
        return !TextUtils.isEmpty(adInfo.adMatrixInfo.adDataV2.splashPlayCardTKInfo.templateId);
    }

    public static boolean dP(AdInfo adInfo) {
        if (dQ(adInfo)) {
            return adInfo.adMatrixInfo.adDataV2.activityMiddlePageInfo.showHeaderBar;
        }
        return true;
    }

    public static boolean dQ(AdInfo adInfo) {
        return !TextUtils.isEmpty(adInfo.adMatrixInfo.adDataV2.activityMiddlePageInfo.templateId);
    }

    public static String dR(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.rotateInfo.title;
    }

    public static String dS(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.shakeInfo.subtitle;
        } catch (Exception unused) {
            return "摇一摇";
        }
    }

    public static long dT(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.tkDefaultTimeout;
    }

    public static String dU(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.rotateInfo.subTitle;
    }

    public static String dV(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.splashActionBarInfo.title;
    }

    public static boolean dx(AdTemplate adTemplate) {
        return !TextUtils.isEmpty(dn(adTemplate));
    }

    public static boolean dy(AdTemplate adTemplate) {
        return !TextUtils.isEmpty(m179do(adTemplate).templateId);
    }

    public static boolean dz(AdTemplate adTemplate) {
        AdMatrixInfo.NativeTKInfo nativeTKInfoDp = dp(adTemplate);
        return (nativeTKInfoDp == null || TextUtils.isEmpty(nativeTKInfoDp.templateId) || nativeTKInfoDp.renderType != 1) ? false : true;
    }

    public static boolean dA(AdTemplate adTemplate) {
        return !TextUtils.isEmpty(es(adTemplate));
    }

    public static String dB(AdTemplate adTemplate) {
        AdMatrixInfo.FeedTKInfo feedTKInfoM179do = m179do(adTemplate);
        return TextUtils.isEmpty(feedTKInfoM179do.templateId) ? "ksad-feed-card" : feedTKInfoM179do.templateId;
    }

    public static boolean dC(AdTemplate adTemplate) {
        return !TextUtils.isEmpty(dq(adTemplate));
    }

    public static boolean dW(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.interstitialCardInfo.interactionInfo.interactiveStyle == 2;
    }

    public static float dD(AdTemplate adTemplate) {
        int i;
        try {
            i = e.eM(adTemplate).adMatrixInfo.adDataV2.interstitialCardInfo.interactionInfo.shakeInfo.acceleration;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            i = 7;
        }
        if (i > 0) {
            return i;
        }
        return 7.0f;
    }

    public static boolean dX(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.interstitialCardInfo.interactionInfo.shakeInfo.enable;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static boolean dY(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.interstitialCardInfo.interactionInfo.shakeInfo.bidirectionalSwitch;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static boolean dE(AdTemplate adTemplate) {
        try {
            return e.eM(adTemplate).adMatrixInfo.adDataV2.interstitialCardInfo.renderType == 1;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static float dF(AdTemplate adTemplate) {
        int i;
        try {
            i = e.eM(adTemplate).adMatrixInfo.adDataV2.splashInfo.interactionInfo.shakeInfo.acceleration;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            i = 7;
        }
        return i;
    }

    public static boolean dZ(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.shakeInfo.enable;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static boolean ea(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.shakeInfo.bidirectionalSwitch;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static AdMatrixInfo.RotateInfo dG(AdTemplate adTemplate) {
        try {
            return e.eM(adTemplate).adMatrixInfo.adDataV2.splashInfo.interactionInfo.rotateInfo;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    public static AdMatrixInfo.RotateInfo dH(AdTemplate adTemplate) {
        try {
            AdMatrixInfo.AdInteractionInfo adInteractionInfo = dj(adTemplate).interactionInfo;
            if (adInteractionInfo != null) {
                return adInteractionInfo.rotateInfo;
            }
            return null;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    public static AdMatrixInfo.RotateInfo dI(AdTemplate adTemplate) {
        try {
            AdMatrixInfo.AdInteractionInfo adInteractionInfo = dk(adTemplate).interactionInfo;
            if (adInteractionInfo != null) {
                return adInteractionInfo.rotateInfo;
            }
            return null;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    public static int eb(AdInfo adInfo) {
        try {
            int i = adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.shakeInfo.componentIndex;
            if (i != 2) {
                return 1;
            }
            return i;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return 1;
        }
    }

    public static boolean ec(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.isMediaDisable && adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactiveStyle == 4;
    }

    public static boolean ed(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactiveStyle == 2;
    }

    public static int ee(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactiveStyle;
    }

    public static int ef(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactivityDefaultStyle;
    }

    public static boolean eg(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactivityDefaultStyle == 2;
    }

    public static boolean eh(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactiveStyle == 1;
    }

    public static boolean ei(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactivityDefaultStyle == 1;
    }

    public static boolean ej(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactiveStyle == 3;
    }

    public static boolean ek(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactiveStyle == 10;
    }

    public static boolean el(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactivityDefaultStyle == 3;
    }

    public static boolean em(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactivityDefaultStyle == 10;
        } catch (Exception unused) {
        }
    }

    public static boolean en(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactivityDefaultStyle == 9;
        } catch (Exception unused) {
        }
    }

    public static boolean eo(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactivityDefaultStyle == 12;
        } catch (Exception unused) {
        }
    }

    public static boolean ep(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactivityDefaultStyle == 14;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static boolean eq(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactiveStyle == 4 || adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactiveStyle == 9;
        } catch (Exception unused) {
            return false;
        }
    }

    public static boolean er(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.interactiveStyle == 4;
        } catch (Exception unused) {
        }
    }

    public static boolean es(AdInfo adInfo) {
        try {
            return !adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.shakeInfo.clickDisabled;
        } catch (Exception unused) {
        }
    }

    public static long et(AdInfo adInfo) {
        try {
            long j = adInfo.adMatrixInfo.adDataV2.splashInfo.interactionInfo.switchDefaultTime;
            if (j <= 0) {
                return 1500L;
            }
            return j;
        } catch (Exception unused) {
            return 1500L;
        }
    }

    public static boolean eu(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.neoVideoInfo.interactionInfo.shakeInfo.enable;
        } catch (Exception unused) {
            return false;
        }
    }

    public static boolean ev(AdInfo adInfo) {
        try {
            return !adInfo.adMatrixInfo.adDataV2.neoVideoInfo.interactionInfo.shakeInfo.clickDisabled;
        } catch (Exception unused) {
        }
    }

    public static boolean g(AdInfo adInfo) {
        return (!adInfo.adRewardInfo.recommendAggregateSwitch || a.de(adInfo) || a.bQ(adInfo)) ? false : true;
    }

    private static AdMatrixInfo.BaseMatrixTemplate dJ(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.complianceCardInfo;
    }

    public static String dK(AdTemplate adTemplate) {
        AdMatrixInfo.MatrixTemplate matrixTemplateT = t(adTemplate, dJ(adTemplate).templateId);
        return matrixTemplateT != null ? matrixTemplateT.templateUrl : "";
    }

    public static boolean dL(AdTemplate adTemplate) {
        return !TextUtils.isEmpty(dK(adTemplate));
    }

    private static AdMatrixInfo.BaseMatrixTemplate dM(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.downloadConfirmCardInfo;
    }

    public static String dN(AdTemplate adTemplate) {
        AdMatrixInfo.MatrixTemplate matrixTemplateT = t(adTemplate, dM(adTemplate).templateId);
        return matrixTemplateT != null ? matrixTemplateT.templateUrl : "";
    }

    public static boolean dO(AdTemplate adTemplate) {
        return !TextUtils.isEmpty(dN(adTemplate));
    }

    public static AdMatrixInfo.MerchantLiveReservationInfo dP(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.merchantLiveReservationInfo;
    }

    public static AdMatrixInfo.FullScreenInfo dQ(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.fullScreenInfo;
    }

    public static AdMatrixInfo.SplashPlayCardTKInfo dR(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.splashPlayCardTKInfo;
    }

    public static long dS(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.splashPlayCardTKInfo.tkTimeout;
    }

    public static int dT(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.splashPlayCardTKInfo.renderType;
    }

    public static AdMatrixInfo.AdBannerTKInfo dU(AdTemplate adTemplate) {
        return cJ(adTemplate).adDataV2.bannerTKInfo;
    }

    public static boolean dV(AdTemplate adTemplate) {
        AdInfo adInfoEM = e.eM(adTemplate);
        if (g(adInfoEM) || e.eY(adTemplate)) {
            return false;
        }
        return !(cP(adTemplate).cardType == 4) && e.eM(adTemplate).adStyleInfo2.playDetailInfo.detailCommonInfo.rewardInteractionType <= 0 && adInfoEM.adMatrixInfo.adDataV2.fullScreenInfo.interactionInfo.interactiveStyle == 2;
    }

    public static boolean dW(AdTemplate adTemplate) {
        AdInfo adInfoEM = e.eM(adTemplate);
        if (g(adInfoEM) || e.eY(adTemplate)) {
            return false;
        }
        return ((cP(adTemplate).cardType == 4) || e.eM(adTemplate).adStyleInfo2.playDetailInfo.detailWebCardInfo.cardType == 4 || adInfoEM.adMatrixInfo.adDataV2.neoVideoInfo.interactionInfo.interactiveStyle != 2) ? false : true;
    }

    public static float ew(AdInfo adInfo) {
        int i;
        try {
            i = adInfo.adMatrixInfo.adDataV2.fullScreenInfo.interactionInfo.shakeInfo.acceleration;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            i = 7;
        }
        return i;
    }

    public static boolean ex(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.fullScreenInfo.interactionInfo.shakeInfo.enable;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static boolean ey(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.fullScreenInfo.interactionInfo.shakeInfo.bidirectionalSwitch;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static float ez(AdInfo adInfo) {
        int i;
        try {
            i = adInfo.adMatrixInfo.adDataV2.neoVideoInfo.interactionInfo.shakeInfo.acceleration;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            i = 7;
        }
        return i;
    }

    public static boolean eA(AdInfo adInfo) {
        try {
            return adInfo.adMatrixInfo.adDataV2.neoVideoInfo.interactionInfo.shakeInfo.bidirectionalSwitch;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return false;
        }
    }

    public static String eB(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.fullScreenInfo.interactionInfo.shakeInfo.title;
    }

    public static String eC(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.neoVideoInfo.interactionInfo.shakeInfo.title;
    }

    public static String eD(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.fullScreenInfo.interactionInfo.shakeInfo.subtitle;
    }

    public static String eE(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.neoVideoInfo.interactionInfo.shakeInfo.subtitle;
    }

    public static AdMatrixInfo.DownloadTexts eF(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.fullScreenInfo.interactionInfo.splashActionBarInfo.downloadTexts;
    }

    public static AdMatrixInfo.DownloadTexts eG(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.neoVideoInfo.interactionInfo.splashActionBarInfo.downloadTexts;
    }

    public static boolean eH(AdInfo adInfo) {
        for (AdMatrixInfo.MatrixTag matrixTag : adInfo.adMatrixInfo.tag) {
            if ("playEndClose".equals(matrixTag.type)) {
                return matrixTag.isHide;
            }
        }
        return false;
    }

    public static boolean eI(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.neoTKInfo.renderType == 1;
    }

    public static int a(boolean z, AdInfo adInfo) {
        if (z) {
            return adInfo.adMatrixInfo.adDataV2.neoTKInfo.renderType;
        }
        return adInfo.adMatrixInfo.adDataV2.fullScreenInfo.renderType;
    }

    public static boolean eJ(AdInfo adInfo) {
        return (a.bQ(adInfo) || TextUtils.isEmpty(adInfo.adMatrixInfo.adDataV2.preLandingPageTKInfo.templateId)) ? false : true;
    }

    public static int eK(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.preLandingPageTKInfo.preLandingPageShowType;
    }

    public static String eL(AdInfo adInfo) {
        return adInfo.adMatrixInfo.adDataV2.videoLiveTKInfo.templateId;
    }

    public static AdMatrixInfo.PreLandingPageTKInfo dX(AdTemplate adTemplate) {
        return e.eM(adTemplate).adMatrixInfo.adDataV2.preLandingPageTKInfo;
    }

    public static boolean dY(AdTemplate adTemplate) {
        return cL(adTemplate).installedActivateInfo.cardSwitch;
    }

    public static long dZ(AdTemplate adTemplate) {
        long j = cL(adTemplate).installedActivateInfo.showTime;
        if (j > 0) {
            return j;
        }
        return 0L;
    }

    public static boolean eM(AdInfo adInfo) {
        return a.bj(adInfo) && !TextUtils.isEmpty(adInfo.adMatrixInfo.adDataV2.videoImageTKInfo.templateId);
    }

    public static String ea(AdTemplate adTemplate) {
        return cL(adTemplate).topFloorTKInfo.templateId;
    }

    public static String eb(AdTemplate adTemplate) {
        return cL(adTemplate).neoTKInfo.templateId;
    }

    public static String ec(AdTemplate adTemplate) {
        return cL(adTemplate).videoLiveTKInfo.templateId;
    }

    public static String ed(AdTemplate adTemplate) {
        return cL(adTemplate).innerEcLiveTKInfo.templateId;
    }

    public static String ee(AdTemplate adTemplate) {
        return cL(adTemplate).videoImageTKInfo.templateId;
    }

    public static String ef(AdTemplate adTemplate) {
        return cL(adTemplate).fullScreenInfo.templateId;
    }

    public static String eg(AdTemplate adTemplate) {
        return cL(adTemplate).rewardVideoTaskInfo.templateId;
    }

    public static String eh(AdTemplate adTemplate) {
        return cL(adTemplate).splashPlayCardTKInfo.templateId;
    }

    public static String ei(AdTemplate adTemplate) {
        return cL(adTemplate).splashEndCardTKInfo.templateId;
    }

    public static String ej(AdTemplate adTemplate) {
        return cL(adTemplate).bannerTKInfo.templateId;
    }

    public static String ek(AdTemplate adTemplate) {
        return cL(adTemplate).interstitialCardInfo.templateId;
    }

    public static String el(AdTemplate adTemplate) {
        return cL(adTemplate).confirmTKInfo.templateId;
    }

    public static String em(AdTemplate adTemplate) {
        return cL(adTemplate).activityTKInfo.templateId;
    }

    public static String en(AdTemplate adTemplate) {
        return cL(adTemplate).rewardWebTaskCloseInfo.templateId;
    }

    public static String eo(AdTemplate adTemplate) {
        return cL(adTemplate).rewardVideoInteractInfo.templateId;
    }

    public static String ep(AdTemplate adTemplate) {
        return cL(adTemplate).pushTKInfo.templateId;
    }

    public static String eq(AdTemplate adTemplate) {
        return cL(adTemplate).preLandingPageTKInfo.templateId;
    }

    public static String er(AdTemplate adTemplate) {
        return cL(adTemplate).feedTKCardInfo.templateId;
    }

    public static String es(AdTemplate adTemplate) {
        return cL(adTemplate).drawTKCardInfo.templateId;
    }

    public static boolean et(AdTemplate adTemplate) {
        AdMatrixInfo.InnerEcAuthInfo innerEcAuthInfo = cL(adTemplate).innerEcAuthInfo;
        return innerEcAuthInfo.showAuthDialogSwitch && innerEcAuthInfo.closureAuthToastSwitch;
    }

    public static String eu(AdTemplate adTemplate) {
        return cL(adTemplate).innerEcAuthInfo.closureAuthToastText;
    }

    public static int ev(AdTemplate adTemplate) {
        return cL(adTemplate).innerEcAuthInfo.cancelClosureAuthTime;
    }

    public static boolean ew(AdTemplate adTemplate) {
        return cL(adTemplate).innerEcAuthInfo.showAuthDialogSwitch;
    }
}
