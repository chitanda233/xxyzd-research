package com.sigmob.sdk.base.common;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.util.Base64;
import android.view.MotionEvent;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.mta.DeviceContext;
import com.czhj.sdk.common.track.AdTracker;
import com.czhj.sdk.common.utils.AppPackageUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.NetworkResponse;
import com.czhj.volley.VolleyError;
import com.czhj.volley.toolbox.DownloadItem;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.rtb.BiddingResponse;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.sdk.base.models.rtb.WXProgramRes;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntityClick;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.mta.PointEntitySigmobError;
import com.sigmob.sdk.base.mta.PointEntitySigmobPrivacy;
import com.sigmob.sdk.base.mta.PointEntitySigmobRequest;
import com.sigmob.sdk.base.mta.PointEntitySigmobSuper;
import com.sigmob.sdk.base.mta.PointFiveEntity;
import com.sigmob.sdk.base.mta.PointInitEntity;
import com.sigmob.sdk.base.mta.PointParamKey;
import com.sigmob.sdk.base.mta.PointType;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAdOptions;
import com.sigmob.windad.WindAdRequest;
import com.sigmob.windad.WindAds;
import com.sigmob.windad.WindCustomController;
import com.sigmob.windad.consent.WindAdConsentInformation;
import java.net.URLEncoder;
import java.util.Iterator;
import java.util.Locale;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class ad {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3142a = "ad";

    public interface a {
        void onAddExtra(Object pointEntityBase);
    }

    public static void a(int userAge) {
        PointEntitySigmobPrivacy pointEntitySigmobPrivacy = new PointEntitySigmobPrivacy();
        pointEntitySigmobPrivacy.setAge(String.valueOf(userAge));
        pointEntitySigmobPrivacy.setAc_type(PointType.GDPR_CONSENT);
        pointEntitySigmobPrivacy.setSub_category("coppa");
        pointEntitySigmobPrivacy.setCategory(PointCategory.PRIVACY);
        pointEntitySigmobPrivacy.commit();
    }

    public static void a(int gdprConsentStatus, boolean gdprRegion) {
        PointEntitySigmobPrivacy pointEntitySigmobPrivacy = new PointEntitySigmobPrivacy();
        pointEntitySigmobPrivacy.setUser_consent(String.valueOf(gdprConsentStatus));
        String str = "1";
        pointEntitySigmobPrivacy.setGdpr_region(gdprRegion ? "1" : "0");
        try {
            if (!WindAdConsentInformation.getInstance(com.sigmob.sdk.b.e()).isRequestLocationInEeaOrUnknown()) {
                str = "0";
            }
            pointEntitySigmobPrivacy.setGdpr_dialog_region(str);
        } catch (Throwable unused) {
        }
        pointEntitySigmobPrivacy.setSub_category(PointCategory.CONSENT);
        pointEntitySigmobPrivacy.setCategory("gdpr");
        pointEntitySigmobPrivacy.setAc_type(PointType.GDPR_CONSENT);
        pointEntitySigmobPrivacy.commit();
    }

    public static void a(PackageInfo info, int type) {
        if (info == null) {
            return;
        }
        PointEntitySigmobSuper pointEntitySigmobSuper = new PointEntitySigmobSuper();
        pointEntitySigmobSuper.setAc_type(PointType.SIGMOB_APP);
        pointEntitySigmobSuper.setCategory(PointCategory.APP);
        Map<String, String> options = pointEntitySigmobSuper.getOptions();
        try {
            options.put("app_name", String.valueOf(AppPackageUtil.getPackageManager(com.sigmob.sdk.b.e()).getApplicationLabel(info.applicationInfo)));
        } catch (Throwable unused) {
        }
        options.put(com.sigmob.sdk.base.n.p, info.packageName);
        options.put(com.sigmob.sdk.base.n.q, String.valueOf(info.lastUpdateTime));
        options.put(com.sigmob.sdk.base.n.r, info.versionName);
        options.put(com.sigmob.sdk.base.n.s, String.valueOf(type));
        pointEntitySigmobSuper.commit();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(PackageInfo packageInfo, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            Context contextE = com.sigmob.sdk.b.e();
            Map<String, String> options = ((PointEntitySigmob) obj).getOptions();
            try {
                options.put(com.sigmob.sdk.base.n.t, contextE.getPackageManager().canRequestPackageInstalls() ? "1" : "0");
            } catch (Throwable th) {
                SigmobLog.e(th.getMessage());
            }
            if (packageInfo == null) {
                return;
            }
            try {
                options.put("app_name", contextE.getPackageManager().getApplicationLabel(packageInfo.applicationInfo).toString());
            } catch (Throwable unused) {
            }
            options.put(com.sigmob.sdk.base.n.p, packageInfo.packageName);
            options.put(com.sigmob.sdk.base.n.q, String.valueOf(packageInfo.lastUpdateTime));
            options.put(com.sigmob.sdk.base.n.r, packageInfo.versionName);
        }
    }

    public static void a(final AdTracker tracker, final String url, BaseAdUnit adUnit, final NetworkResponse response, final a extraInfo) {
        if (tracker == null) {
            return;
        }
        al.a(tracker.getEvent()).a(adUnit).a(new a() { // from class: com.sigmob.sdk.base.common.ad$$ExternalSyntheticLambda0
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                ad.a(url, tracker, response, extraInfo, obj);
            }
        }).a();
    }

    public static void a(AdTracker tracker, String url, BaseAdUnit adUnit, final VolleyError volleyError) {
        NetworkResponse networkResponse = volleyError == null ? null : volleyError.networkResponse;
        if (com.sigmob.sdk.base.utils.v.b(networkResponse)) {
            a(tracker, url, adUnit, networkResponse, (a) null);
        } else {
            a(tracker, url, adUnit, (NetworkResponse) null, new a() { // from class: com.sigmob.sdk.base.common.ad$$ExternalSyntheticLambda1
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    ad.a(volleyError, obj);
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(VolleyError volleyError, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            pointEntitySigmob.setHttp_code("-1");
            if (volleyError == null) {
                pointEntitySigmob.setTime_spend("0");
            } else {
                pointEntitySigmob.setTime_spend(String.valueOf(volleyError.getNetworkTimeMs()));
                pointEntitySigmob.setError_message(volleyError.getMessage());
            }
        }
    }

    public static void a(DownloadItem item, BaseAdUnit adUnit, String error, boolean isCache) {
        PointEntitySigmob pointEntitySigmob = new PointEntitySigmob();
        pointEntitySigmob.setAc_type(PointType.DOWNLOAD_TRACKING);
        pointEntitySigmob.setIssuccess(String.valueOf(item.status));
        pointEntitySigmob.setIscached(isCache ? "1" : "0");
        pointEntitySigmob.setDuration(String.valueOf(item.networkMs));
        pointEntitySigmob.setFile_size(String.valueOf(item.size));
        pointEntitySigmob.setFile_name(Base64.encodeToString(item.url.getBytes(), 2));
        pointEntitySigmob.setError_message(error);
        pointEntitySigmob.setCategory(String.valueOf(item.type.getType()));
        a(pointEntitySigmob.getCategory(), pointEntitySigmob.getSub_category(), adUnit, pointEntitySigmob);
        pointEntitySigmob.commit();
    }

    public static void a(com.sigmob.sdk.base.a clickUIType, final String subCategory, final BaseAdUnit adUnit, final String isDeepLink, final String targetUrl, final String coordinate, final long duration, final JSONObject object) {
        a(clickUIType == null ? subCategory : clickUIType.name().toLowerCase(), subCategory, adUnit, new a() { // from class: com.sigmob.sdk.base.common.ad$$ExternalSyntheticLambda4
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                ad.a(adUnit, subCategory, isDeepLink, targetUrl, coordinate, duration, object, obj);
            }
        });
    }

    public static void a(aa item) {
        if (item != null) {
            if (item.f3138a == 0 && item.b == 0) {
                return;
            }
            PointEntitySigmobSuper pointEntitySigmobSuper = new PointEntitySigmobSuper();
            pointEntitySigmobSuper.setAc_type(PointType.LOAD_READY);
            pointEntitySigmobSuper.setCategory(PointCategory.LOAD_READY);
            Map<String, String> options = pointEntitySigmobSuper.getOptions();
            options.put(PointParamKey.PLACEMENT_ID, String.valueOf(item.c));
            options.put(PointParamKey.FEED_PRE_REQUEST_COUNT, String.valueOf(item.f3138a));
            options.put(PointParamKey.FEED_PRE_READY_COUNT, String.valueOf(item.b));
            pointEntitySigmobSuper.commit();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(a aVar, Object obj) {
        if (aVar == null) {
            return;
        }
        aVar.onAddExtra(obj);
    }

    public static void a(BaseAdUnit adUnit, MotionEvent event, String category, boolean isValidClick) {
        long eventTime = event.getEventTime() - event.getDownTime();
        PointEntityClick pointEntityClick = new PointEntityClick();
        pointEntityClick.setAc_type(PointType.ANTI_SPAM_TOUCH);
        pointEntityClick.setCategory(category);
        pointEntityClick.setLocation(String.format(Locale.getDefault(), "{x:%f,y:%f}", Float.valueOf(event.getRawX()), Float.valueOf(event.getRawY())));
        pointEntityClick.setClick_duration(String.valueOf(eventTime));
        pointEntityClick.setPressure(String.valueOf(event.getPressure()));
        pointEntityClick.setTouchSize(String.valueOf(event.getSize()));
        pointEntityClick.setTouchType(String.valueOf(event.getToolType(0)));
        pointEntityClick.setIs_valid_click(isValidClick ? "1" : "0");
        if (com.sigmob.sdk.base.utils.v.b(adUnit)) {
            pointEntityClick.setLoad_id(adUnit.getLoad_id());
        }
        pointEntityClick.commit();
    }

    public static void a(BaseAdUnit adUnit, String event, final PackageInfo info, String subCate) {
        a(event, subCate, adUnit, new a() { // from class: com.sigmob.sdk.base.common.ad$$ExternalSyntheticLambda2
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                ad.a(info, obj);
            }
        });
    }

    public static void a(BaseAdUnit adUnit, String actionType, final String downloadUrl) {
        a(PointCategory.TARGET_URL, (String) null, adUnit, new a() { // from class: com.sigmob.sdk.base.common.ad$$ExternalSyntheticLambda5
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                ad.a(downloadUrl, obj);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:17:0x0106  */
    /* JADX WARN: Code duplicated, block: B:20:0x0117  */
    /* JADX WARN: Code duplicated, block: B:22:0x0136  */
    /* JADX WARN: Code duplicated, block: B:25:0x014b  */
    public static /* synthetic */ void a(BaseAdUnit baseAdUnit, String str, String str2, String str3, String str4, long j, JSONObject jSONObject, Object obj) {
        String str5;
        String str6;
        ClickCommon clickCommon;
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            Map<String, String> options = pointEntitySigmob.getOptions();
            if (com.sigmob.sdk.base.utils.v.b(baseAdUnit) && com.sigmob.sdk.base.utils.s.a(str, "click")) {
                pointEntitySigmob.setScene_id(baseAdUnit.getAd_scene_id());
                pointEntitySigmob.setScene_desc(baseAdUnit.getAd_scene_desc());
                options.put("template_id", baseAdUnit.getClickCommon().template_id);
                String str7 = baseAdUnit.getClickCommon().sld;
                options.put("sld", str7);
                options.put("adarea_x", "0");
                options.put("adarea_y", "0");
                options.put("adarea_w", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealWidthDip()));
                options.put("adarea_h", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealHeightDip()));
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) str7, (CharSequence) "5")) {
                    options.put("turn_x", baseAdUnit.getClickCommon().turn_x);
                    options.put("turn_y", baseAdUnit.getClickCommon().turn_y);
                    options.put("turn_z", baseAdUnit.getClickCommon().turn_z);
                    str5 = baseAdUnit.getClickCommon().turn_time;
                    str6 = "turn_time";
                } else if (com.sigmob.sdk.base.utils.s.a((CharSequence) str7, (CharSequence) "2")) {
                    options.put("x_max_acc", baseAdUnit.getClickCommon().x_max_acc);
                    options.put("y_max_acc", baseAdUnit.getClickCommon().y_max_acc);
                    str5 = baseAdUnit.getClickCommon().z_max_acc;
                    str6 = "z_max_acc";
                } else {
                    options.put(ClickCommon.CLICK_AREA, baseAdUnit.getClickCommon().click_area);
                    options.put("click_scene", baseAdUnit.getClickCommon().click_scene);
                    options.put("cwidth", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealWidthDip()));
                    options.put("cheight", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealHeightDip()));
                    options.put("is_final_click", baseAdUnit.getClickCommon().is_final_click ? "1" : "0");
                    clickCommon = baseAdUnit.getClickCommon();
                    if (com.sigmob.sdk.base.utils.v.b(clickCommon)) {
                        options.put(ClickCommon.CLICK_LOSE_RATE, String.valueOf(clickCommon.click_lose_rate));
                        options.put(ClickCommon.CLICK_CB_STATE, String.valueOf(clickCommon.click_cb_state));
                        if (com.sigmob.sdk.base.utils.v.b(clickCommon.aim)) {
                            options.put(ClickCommon.AIM, String.valueOf(clickCommon.aim));
                            clickCommon.aim = null;
                        }
                        if (com.sigmob.sdk.base.utils.v.b(clickCommon.cpt_render_type)) {
                            options.put(ClickCommon.CPT_RENDER_TYPE, String.valueOf(clickCommon.cpt_render_type));
                            clickCommon.cpt_render_type = null;
                        }
                    }
                }
                options.put(str6, str5);
                options.put(ClickCommon.CLICK_AREA, baseAdUnit.getClickCommon().click_area);
                options.put("click_scene", baseAdUnit.getClickCommon().click_scene);
                options.put("cwidth", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealWidthDip()));
                options.put("cheight", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealHeightDip()));
                options.put("is_final_click", baseAdUnit.getClickCommon().is_final_click ? "1" : "0");
                clickCommon = baseAdUnit.getClickCommon();
                if (com.sigmob.sdk.base.utils.v.b(clickCommon)) {
                    options.put(ClickCommon.CLICK_LOSE_RATE, String.valueOf(clickCommon.click_lose_rate));
                    options.put(ClickCommon.CLICK_CB_STATE, String.valueOf(clickCommon.click_cb_state));
                    if (com.sigmob.sdk.base.utils.v.b(clickCommon.aim)) {
                        options.put(ClickCommon.AIM, String.valueOf(clickCommon.aim));
                        clickCommon.aim = null;
                    }
                    if (com.sigmob.sdk.base.utils.v.b(clickCommon.cpt_render_type)) {
                        options.put(ClickCommon.CPT_RENDER_TYPE, String.valueOf(clickCommon.cpt_render_type));
                        clickCommon.cpt_render_type = null;
                    }
                }
            }
            pointEntitySigmob.setIs_deeplink(str2);
            pointEntitySigmob.setFinal_url(str3);
            pointEntitySigmob.setCoordinate(str4);
            pointEntitySigmob.setVtime(String.format(Locale.getDefault(), "%.2f", Float.valueOf(j / 1000.0f)));
            if (jSONObject == null) {
                return;
            }
            Iterator<String> itKeys = jSONObject.keys();
            while (itKeys.hasNext()) {
                String next = itKeys.next();
                try {
                    Object obj2 = jSONObject.get(next);
                    options.put(next, obj2 instanceof String ? (String) obj2 : String.valueOf(obj2));
                } catch (Throwable th) {
                    SigmobLog.e("log_data error" + jSONObject + " " + th.getMessage());
                }
            }
        }
    }

    protected static void a(PointEntitySigmob entity) {
        WindAdOptions options = WindAds.sharedAds().getOptions();
        if (options == null || options.getCustomController() == null) {
            entity.setIs_custom_imei("0");
            entity.setIs_custom_android_id("0");
            entity.setIs_custom_oaid("0");
        } else {
            WindCustomController customController = options.getCustomController();
            entity.setIs_custom_imei(customController.isCanUsePhoneState() ? "0" : "1");
            entity.setIs_custom_android_id(customController.isCanUseAndroidId() ? "0" : "1");
            entity.setIs_custom_oaid(com.sigmob.sdk.base.utils.s.a((CharSequence) customController.getDevOaid()) ? "0" : "1");
        }
    }

    public static void a(String category) {
        PointEntitySigmobSuper pointEntitySigmobSuper = new PointEntitySigmobSuper();
        pointEntitySigmobSuper.setAc_type(PointType.ANTI_SPAM_TOUCH);
        pointEntitySigmobSuper.setCategory(category);
        pointEntitySigmobSuper.setSha1(ClientMetadata.getInstance().getApkSha1());
        pointEntitySigmobSuper.setMd5(ClientMetadata.getInstance().getApkMd5());
        pointEntitySigmobSuper.commit();
    }

    public static void a(String category, int code, String message, BaseAdUnit adUnit, a extraInfo) {
        PointEntitySigmobError pointEntitySigmobErrorSigmobError = PointEntitySigmobError.SigmobError(category, code, message);
        if (com.sigmob.sdk.base.utils.v.b(extraInfo)) {
            extraInfo.onAddExtra(pointEntitySigmobErrorSigmobError);
        }
        a(category, category, adUnit, pointEntitySigmobErrorSigmobError);
        pointEntitySigmobErrorSigmobError.commit();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(String str, AdTracker adTracker, NetworkResponse networkResponse, a aVar, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            pointEntitySigmob.setAc_type(PointType.SIGMOB_REPORT_TRACKING);
            pointEntitySigmob.setUrl(str);
            pointEntitySigmob.setRetry(adTracker.getId() == null ? "0" : "1");
            pointEntitySigmob.setCategory(adTracker.getEvent());
            pointEntitySigmob.setRequest_id(adTracker.getRequest_id());
            pointEntitySigmob.setSource(adTracker.getSource());
            long timestamp = adTracker.getTimestamp();
            if (timestamp != 0) {
                pointEntitySigmob.setTimestamp(String.valueOf(timestamp));
            }
            if (com.sigmob.sdk.base.utils.v.b(networkResponse)) {
                pointEntitySigmob.setResponse(networkResponse.data == null ? null : Base64.encodeToString(networkResponse.data, 2));
                pointEntitySigmob.setHttp_code(String.valueOf(networkResponse.statusCode));
                pointEntitySigmob.setTime_spend(String.valueOf(networkResponse.networkTimeMs));
                pointEntitySigmob.setContent_type(networkResponse.headers.get("Content-Type"));
                pointEntitySigmob.setContent_length(networkResponse.headers.get(com.sigmob.sdk.downloader.core.c.e));
            }
        }
        if (com.sigmob.sdk.base.utils.v.b(aVar)) {
            aVar.onAddExtra(obj);
        }
    }

    public static void a(String category, a extraInfo) {
        int i;
        PointInitEntity pointInitEntity = new PointInitEntity();
        pointInitEntity.setAc_type("1");
        pointInitEntity.setCategory(category);
        com.sigmob.sdk.base.o oVarA = com.sigmob.sdk.base.o.a();
        boolean zQ = oVarA.Q();
        boolean zP = oVarA.P();
        pointInitEntity.setAppinfo_switch(zQ ? "0,0" : "1,1");
        int i2 = 0;
        if (zP) {
            i = 0;
        } else {
            DeviceContext deviceContextB = com.sigmob.sdk.b.b();
            i = (deviceContextB == null ? ClientMetadata.getInstance().getLocation() : deviceContextB.getLocation()) != null ? 1 : 0;
            i2 = 1;
        }
        pointInitEntity.setLocation_switch(i2 + "," + i);
        if (com.sigmob.sdk.base.utils.v.b(extraInfo)) {
            extraInfo.onAddExtra(pointInitEntity);
        }
        WindAdOptions options = WindAds.sharedAds().getOptions();
        if (options == null || options.getCustomController() == null) {
            pointInitEntity.setIs_custom_imei("0");
            pointInitEntity.setIs_custom_android_id("0");
            pointInitEntity.setIs_custom_oaid("0");
        } else {
            WindCustomController customController = options.getCustomController();
            pointInitEntity.setIs_custom_imei(customController.isCanUsePhoneState() ? "0" : "1");
            pointInitEntity.setIs_custom_android_id(customController.isCanUseAndroidId() ? "0" : "1");
            pointInitEntity.setIs_custom_oaid(com.sigmob.sdk.base.utils.s.a((CharSequence) customController.getDevOaid()) ? "0" : "1");
        }
        pointInitEntity.commit();
    }

    public static void a(String acType, BaseAdUnit adUnit, LoadAdRequest adRequest, a extraInfo) {
        PointFiveEntity pointFiveEntity = new PointFiveEntity();
        pointFiveEntity.setAc_type(acType);
        if (com.sigmob.sdk.base.utils.v.b(extraInfo)) {
            extraInfo.onAddExtra(pointFiveEntity);
        }
        String category = pointFiveEntity.getCategory();
        String sub_category = pointFiveEntity.getSub_category();
        Map<String, String> options = pointFiveEntity.getOptions();
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) category) && com.sigmob.sdk.base.utils.f.b(options)) {
            category = options.get(PointParamKey.CATEGORY);
        }
        com.sigmob.sdk.base.utils.k.c(f3142a, "SigmobMRIADJS: category = " + category + ", options = " + options, new Object[0]);
        a(category, sub_category, adUnit, pointFiveEntity);
        if (com.sigmob.sdk.base.utils.v.b(adRequest)) {
            pointFiveEntity.setLoad_id(adRequest.getLoadId());
            pointFiveEntity.setAdtype(String.valueOf(adRequest.getAdType()));
            pointFiveEntity.setScene_id(adRequest.getAdSceneId());
            pointFiveEntity.setScene_desc(adRequest.getAdSceneDesc());
            pointFiveEntity.setPlacement_id(adRequest.getPlacementId());
        }
        pointFiveEntity.commit();
    }

    public static void a(String category, WindAdError adError, BaseAdUnit adUnit, a extraInfo) {
        if (adError == null) {
            return;
        }
        int errorCode = adError.getErrorCode();
        String message = adError.getMessage();
        PointEntitySigmobError pointEntitySigmobErrorSigmobError = PointEntitySigmobError.SigmobError(category, errorCode, message);
        a(category, category, adUnit, pointEntitySigmobErrorSigmobError);
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) message, (CharSequence) WindAdError.ERROR_SIGMOB_VIDEO_FILE.getMessage()) && com.sigmob.sdk.base.utils.s.a((CharSequence) category, (CharSequence) "load") && com.sigmob.sdk.base.utils.v.b(adUnit)) {
            pointEntitySigmobErrorSigmobError.getOptions().put("video_url", adUnit.getVideo_url());
        }
        if (com.sigmob.sdk.base.utils.v.b(extraInfo)) {
            extraInfo.onAddExtra(pointEntitySigmobErrorSigmobError);
        }
        pointEntitySigmobErrorSigmobError.commit();
    }

    public static void a(String category, WindAdError error, BaseAdUnit adUnit, LoadAdRequest request) {
        a(category, (String) null, error.getErrorCode(), error.getMessage(), (WindAdRequest) null, request, adUnit, (a) null);
    }

    public static void a(String category, WindAdError error, WindAdRequest adRequest) {
        a(category, (String) null, error.getErrorCode(), error.getMessage(), adRequest, (LoadAdRequest) null, (BaseAdUnit) null, (a) null);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(String str, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            ((PointEntitySigmob) obj).setFinal_url(str);
        }
    }

    public static void a(String category, String subCategory, int errCode, String errMsg, LoadAdRequest adRequest) {
        a(category, subCategory, errCode, errMsg, (WindAdRequest) null, adRequest, (BaseAdUnit) null, (a) null);
    }

    public static void a(String category, String subCategory, int errCode, String errMsg, WindAdRequest adRequest, LoadAdRequest loadAdRequest, BaseAdUnit adUnit, a extraInfo) {
        PointEntitySigmobError pointEntitySigmobErrorSigmobError = PointEntitySigmobError.SigmobError(category, errCode, errMsg);
        pointEntitySigmobErrorSigmobError.setSub_category(subCategory);
        a(category, category, pointEntitySigmobErrorSigmobError, adRequest);
        a(category, category, pointEntitySigmobErrorSigmobError, loadAdRequest);
        a(category, category, adUnit, pointEntitySigmobErrorSigmobError);
        if (com.sigmob.sdk.base.utils.v.b(extraInfo)) {
            extraInfo.onAddExtra(pointEntitySigmobErrorSigmobError);
        }
        pointEntitySigmobErrorSigmobError.commit();
    }

    public static void a(String category, String subCategory, BaseAdUnit adUnit, a extraInfo) {
        a(category, subCategory, adUnit, null, null, extraInfo);
    }

    protected static void a(String str, String str2, BaseAdUnit baseAdUnit, PointEntitySigmob pointEntitySigmob) {
        if (baseAdUnit == null || pointEntitySigmob == null) {
            return;
        }
        try {
            int ad_type = baseAdUnit.getAd_type();
            pointEntitySigmob.setAdtype(String.valueOf(ad_type));
            pointEntitySigmob.setCampaign_id(baseAdUnit.getCamp_id());
            pointEntitySigmob.setCreative_id(baseAdUnit.getCrid());
            pointEntitySigmob.setRequest_id(baseAdUnit.getRequestId());
            pointEntitySigmob.setPlacement_id(baseAdUnit.getAdslot_id());
            pointEntitySigmob.setLoad_id(baseAdUnit.getLoad_id());
            pointEntitySigmob.setVid(baseAdUnit.getVid());
            pointEntitySigmob.setScene_id(baseAdUnit.getAd_scene_id());
            pointEntitySigmob.setScene_desc(baseAdUnit.getAd_scene_desc());
            pointEntitySigmob.setPlay_mode(String.valueOf(baseAdUnit.getPlayMode()));
            pointEntitySigmob.setCreative_type(String.valueOf(baseAdUnit.getCreativeType()));
            pointEntitySigmob.setBid_token(baseAdUnit.getBid_token());
            BiddingResponse biddingResponse = baseAdUnit.bidding_response;
            if (com.sigmob.sdk.base.utils.v.b(biddingResponse)) {
                pointEntitySigmob.setHb_price(biddingResponse.ecpm.intValue());
            }
            pointEntitySigmob.setPrice(baseAdUnit.getAd().settlement_price_enc);
            String str3 = baseAdUnit.getAd().product_id;
            if (com.sigmob.sdk.base.utils.s.b(str3)) {
                pointEntitySigmob.setProduct_id(str3);
            }
            String adx_id = baseAdUnit.getAdx_id();
            if (com.sigmob.sdk.base.utils.s.b(adx_id)) {
                pointEntitySigmob.setAdx_id(adx_id);
            }
            pointEntitySigmob.setTemplate_id(String.valueOf(baseAdUnit.getTemplateId()));
            MaterialMeta material = baseAdUnit.getMaterial();
            if (com.sigmob.sdk.base.utils.v.b(material)) {
                pointEntitySigmob.setTemplate_type(material.template_type.intValue());
            }
            if (com.sigmob.sdk.base.utils.s.a((CharSequence) pointEntitySigmob.getTarget_url())) {
                pointEntitySigmob.setTarget_url(baseAdUnit.getLanding_page());
            }
            WXProgramRes wXProgramRes = baseAdUnit.getWXProgramRes();
            if (com.sigmob.sdk.base.utils.v.b(wXProgramRes)) {
                if (com.sigmob.sdk.base.utils.s.b(wXProgramRes.wx_app_path)) {
                    pointEntitySigmob.setWx_app_path(URLEncoder.encode(wXProgramRes.wx_app_path, "UTF-8"));
                }
                if (com.sigmob.sdk.base.utils.s.b(wXProgramRes.wx_app_username)) {
                    pointEntitySigmob.setWx_app_username(wXProgramRes.wx_app_username);
                }
            }
            String apkMd5 = baseAdUnit.getApkMd5();
            if (com.sigmob.sdk.base.utils.s.b(apkMd5)) {
                pointEntitySigmob.getOptions().put(PointParamKey.APK_MD5, apkMd5);
            }
            pointEntitySigmob.setAd_source_channel(baseAdUnit.getAd_source_channel());
            a(str, str2, pointEntitySigmob, ad_type, baseAdUnit.isHalfInterstitial());
        } catch (Throwable unused) {
        }
        Map<String, String> options = pointEntitySigmob.getOptions();
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) pointEntitySigmob.getCategory())) {
            String str4 = com.sigmob.sdk.base.utils.s.b(str) ? str : options.get(PointParamKey.CATEGORY);
            if (com.sigmob.sdk.base.utils.s.b(str4)) {
                pointEntitySigmob.setCategory(str4);
            }
        }
        if (com.sigmob.sdk.base.utils.s.b(str, PointCategory.REQUEST)) {
            Integer adExpiredTime = baseAdUnit.getAdExpiredTime();
            Long lValueOf = Long.valueOf(baseAdUnit.getCreate_time());
            boolean zExpiredAdCanReload = baseAdUnit.expiredAdCanReload();
            options.put(PointParamKey.EXPIRE_RELOAD_COUNT, String.valueOf(baseAdUnit.expiredAdReloadNum()));
            options.put(PointParamKey.CAN_EXPIRE_RELOAD, String.valueOf(zExpiredAdCanReload ? 1 : 0));
            options.put(PointParamKey.EXPIRE_TIMESTAMP, String.valueOf(lValueOf.longValue() + ((long) adExpiredTime.intValue())));
            int requestSceneType = baseAdUnit.getRequestSceneType();
            if (requestSceneType > 0) {
                options.put(PointParamKey.REQUEST_SCENE_TYPE, String.valueOf(requestSceneType));
            }
            Boolean boolEnableSmallWindow = baseAdUnit.enableSmallWindow();
            baseAdUnit.getDeeplinkUrl();
            if (com.sigmob.sdk.base.utils.v.b((Object) boolEnableSmallWindow) && (baseAdUnit.isValid(baseAdUnit.getInteractionType()) || baseAdUnit.isValid(baseAdUnit.getMraidInteractionType()))) {
                options.put(PointParamKey.ENABLE_SMALL_WINDOW, boolEnableSmallWindow.booleanValue() ? "1" : "0");
            }
            if (baseAdUnit.getAd_type() == 6) {
                Boolean boolAllowClickToAutoClose = baseAdUnit.allowClickToAutoClose();
                if (com.sigmob.sdk.base.utils.v.b((Object) boolAllowClickToAutoClose)) {
                    options.put(PointParamKey.CLICK_CLOSE_AD, boolAllowClickToAutoClose.booleanValue() ? "1" : "0");
                }
                Integer numAllowCountdownEndsClose = baseAdUnit.allowCountdownEndsClose();
                if (com.sigmob.sdk.base.utils.v.b(numAllowCountdownEndsClose)) {
                    options.put(PointParamKey.SECONDS_CLOSE_AD, String.valueOf(numAllowCountdownEndsClose));
                }
            }
            options.put(PointParamKey.TRACE_ID, baseAdUnit.getTraceId());
            if (requestSceneType == com.sigmob.sdk.base.j.NormalRequest.a() || requestSceneType == com.sigmob.sdk.base.j.ReloadAfterExpiration.a() || requestSceneType == com.sigmob.sdk.base.j.ActiveFailureReload.a()) {
                options.put(PointParamKey.VID, baseAdUnit.getVid());
                String originVid = baseAdUnit.getOriginVid();
                if (com.sigmob.sdk.base.utils.s.b(originVid)) {
                    options.put(PointParamKey.ORIGIN_VID, originVid);
                }
            }
        }
    }

    public static void a(String category, String subCategory, BaseAdUnit adUnit, WindAdRequest windAdRequest, LoadAdRequest loadAdRequest, final a extraInfo) {
        al.a(category).c(subCategory).a(adUnit).a(windAdRequest).a(loadAdRequest).a(new a() { // from class: com.sigmob.sdk.base.common.ad$$ExternalSyntheticLambda3
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                ad.a(extraInfo, obj);
            }
        }).a();
    }

    public static void a(String category, String subCategory, LoadAdRequest adRequest) {
        a(category, subCategory, null, null, adRequest, null);
    }

    private static void a(String category, String subCategory, PointEntitySigmob entity, int adType, boolean halfInterstitial) {
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) entity.getShow_type()) && com.sigmob.sdk.base.utils.s.b(category)) {
            if ((category.equals(PointCategory.REQUEST) || category.equals(PointCategory.READY) || category.equals("start") || category.equals("endcard") || (com.sigmob.sdk.base.utils.s.b(subCategory) && subCategory.equals("click"))) && adType == 4) {
                entity.setShow_type(halfInterstitial ? "2" : "1");
            }
        }
    }

    protected static void a(String category, String subCategory, PointEntitySigmob entity, LoadAdRequest adRequest) {
        if (entity == null || adRequest == null) {
            return;
        }
        entity.setPlacement_id(adRequest.getPlacementId());
        String bidToken = adRequest.getBidToken();
        if (com.sigmob.sdk.base.utils.s.b(bidToken)) {
            entity.setBid_token(bidToken);
        }
        String loadId = adRequest.getLoadId();
        if (com.sigmob.sdk.base.utils.s.b(loadId)) {
            entity.setLoad_id(loadId);
        }
        String adx_id = adRequest.getAdx_id();
        if (com.sigmob.sdk.base.utils.s.b(adx_id)) {
            entity.setAdx_id(adx_id);
        }
        int adType = adRequest.getAdType();
        entity.setAdtype(String.valueOf(adType));
        String requestId = adRequest.getRequestId();
        if (com.sigmob.sdk.base.utils.s.b(requestId)) {
            entity.setRequest_id(requestId);
        }
        String traceId = adRequest.getTraceId();
        if (com.sigmob.sdk.base.utils.s.b(traceId)) {
            entity.setTrace_id(traceId);
        }
        Map<String, String> options = adRequest.getOptions();
        if (com.sigmob.sdk.base.utils.v.b(options)) {
            entity.setExtinfo(new JSONObject(options).toString());
        }
        a(category, subCategory, entity, adType, adRequest.isHalfInterstitial());
        int request_scene_type = adRequest.getRequest_scene_type();
        if (request_scene_type > 0) {
            entity.getOptions().put(PointParamKey.REQUEST_SCENE_TYPE, String.valueOf(request_scene_type));
        }
    }

    protected static void a(String category, String subCategory, PointEntitySigmob entity, WindAdRequest adRequest) {
        if (entity == null || adRequest == null) {
            return;
        }
        int adType = adRequest.getAdType();
        entity.setPlacement_id(adRequest.getPlacementId());
        entity.setLoad_id(adRequest.getLoadId());
        entity.setAdx_id(adRequest.getAdxId());
        entity.setAdtype(String.valueOf(adType));
        if (adRequest.hasOptions()) {
            try {
                entity.setExtinfo(new JSONObject(adRequest.getOptions()).toString());
            } catch (Throwable unused) {
            }
        }
        a(category, subCategory, entity, adType, adRequest.isHalfInterstitial());
    }

    public static void a(String category, String subCategory, WindAdRequest windAdRequest, LoadAdRequest loadAdRequest, a extraInfo) {
        PointEntitySigmobRequest pointEntitySigmobRequest = new PointEntitySigmobRequest();
        pointEntitySigmobRequest.setAc_type("5");
        pointEntitySigmobRequest.setCategory(category);
        pointEntitySigmobRequest.setSub_category(subCategory);
        a(category, category, pointEntitySigmobRequest, windAdRequest);
        a(category, category, pointEntitySigmobRequest, loadAdRequest);
        if (com.sigmob.sdk.base.utils.v.b(extraInfo)) {
            extraInfo.onAddExtra(pointEntitySigmobRequest);
        }
        a(pointEntitySigmobRequest);
        pointEntitySigmobRequest.commit();
    }

    public static void a(String pkgName, boolean isCanOpen, int type) {
        PointEntitySigmobSuper pointEntitySigmobSuper = new PointEntitySigmobSuper();
        pointEntitySigmobSuper.setAc_type(PointType.SIGMOB_CANOPEN_APP);
        pointEntitySigmobSuper.setCategory(PointCategory.OPEN_APP);
        Map<String, String> options = pointEntitySigmobSuper.getOptions();
        options.put(PointParamKey.APP_PKG_NAME, pkgName);
        options.put(PointParamKey.CAN_OP, isCanOpen ? "1" : "0");
        options.put("type", String.valueOf(type));
        pointEntitySigmobSuper.commit();
    }

    public static void a(boolean isAdult) {
        PointEntitySigmobPrivacy pointEntitySigmobPrivacy = new PointEntitySigmobPrivacy();
        pointEntitySigmobPrivacy.setAc_type(PointType.GDPR_CONSENT);
        pointEntitySigmobPrivacy.setSub_category(PointCategory.ADULT);
        pointEntitySigmobPrivacy.setCategory(PointCategory.PRIVACY);
        pointEntitySigmobPrivacy.setIs_minor(isAdult ? "0" : "1");
        pointEntitySigmobPrivacy.commit();
    }

    public static void b(int age_restricted) {
        PointEntitySigmobPrivacy pointEntitySigmobPrivacy = new PointEntitySigmobPrivacy();
        pointEntitySigmobPrivacy.setAge_restricted(String.valueOf(age_restricted));
        pointEntitySigmobPrivacy.setAc_type(PointType.GDPR_CONSENT);
        pointEntitySigmobPrivacy.setSub_category("coppa");
        pointEntitySigmobPrivacy.setCategory(PointCategory.PRIVACY);
        pointEntitySigmobPrivacy.commit();
    }

    public static void b(boolean isPersonalizedAdvertisingOn) {
        PointEntitySigmobPrivacy pointEntitySigmobPrivacy = new PointEntitySigmobPrivacy();
        pointEntitySigmobPrivacy.setAc_type(PointType.GDPR_CONSENT);
        pointEntitySigmobPrivacy.setSub_category(PointCategory.PERSONALIZED);
        pointEntitySigmobPrivacy.setCategory(PointCategory.PRIVACY);
        pointEntitySigmobPrivacy.setIs_unpersonalized(isPersonalizedAdvertisingOn ? "0" : "1");
        pointEntitySigmobPrivacy.commit();
    }
}
