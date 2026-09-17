package com.sigmob.sdk.mraid;

import android.util.Base64;
import android.webkit.JavascriptInterface;
import androidx.core.app.NotificationCompat;
import com.byazt.nys.PluginConstants;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.track.AdTracker;
import com.czhj.sdk.common.utils.ReflectionUtil;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.ai;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.mta.PointParamKey;
import com.sigmob.windad.WindAds;
import java.lang.ref.WeakReference;
import java.util.HashMap;
import java.util.Iterator;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f3478a = "AppInfoJS";
    private final WeakReference<c> b;

    public a(c mraidBridge) {
        this.b = new WeakReference<>(mraidBridge);
    }

    public static String a(int code, String message, Object data) {
        try {
            JSONObject jSONObject = new JSONObject();
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, code);
            if (!com.sigmob.sdk.base.utils.s.a((CharSequence) message)) {
                jSONObject.put("message", message);
            }
            if (data != null) {
                jSONObject.put("data", data);
            }
            return jSONObject.toString();
        } catch (Throwable th) {
            return th.getMessage();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(String str, c cVar) {
        try {
            JSONObject jSONObject = new JSONObject(str);
            cVar.a(jSONObject.optString(NotificationCompat.CATEGORY_EVENT), jSONObject.optString("subEvent"), jSONObject.optJSONObject("args"));
        } catch (Exception e) {
            com.sigmob.sdk.base.utils.k.f("AppInfoJS", "postMessage: error = " + e.getMessage(), new Object[0]);
        }
        cVar.e(str);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(JSONObject jSONObject, BaseAdUnit baseAdUnit, Object obj) {
        HashMap map = new HashMap();
        Iterator<String> itKeys = jSONObject.keys();
        while (itKeys.hasNext()) {
            String next = itKeys.next();
            if (next.equalsIgnoreCase(com.sigmob.sdk.base.n.m)) {
                try {
                    try {
                        JSONObject jSONObject2 = new JSONObject(jSONObject.optString(next));
                        Iterator<String> itKeys2 = jSONObject2.keys();
                        while (itKeys2.hasNext()) {
                            String next2 = itKeys2.next();
                            map.put(next2, jSONObject2.optString(next2));
                        }
                    } catch (Exception unused) {
                        map.put(com.sigmob.sdk.base.n.m, Base64.encodeToString(jSONObject.getString(com.sigmob.sdk.base.n.m).getBytes(), 2));
                    }
                } catch (JSONException e) {
                    e.printStackTrace();
                }
            } else if (!next.equalsIgnoreCase(PointParamKey._AC_TYPE)) {
                map.put(next, jSONObject.getString(next));
            }
        }
        map.put(com.sigmob.sdk.base.n.l, "js");
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            String str = (String) map.get("sub_category");
            if (com.sigmob.sdk.base.utils.v.b(baseAdUnit) && com.sigmob.sdk.base.utils.s.a(str, "click")) {
                ClickCommon clickCommon = baseAdUnit.getClickCommon();
                if (com.sigmob.sdk.base.utils.v.b(clickCommon)) {
                    map.put(ClickCommon.CLICK_LOSE_RATE, String.valueOf(clickCommon.click_lose_rate));
                    map.put(ClickCommon.CLICK_CB_STATE, String.valueOf(clickCommon.click_cb_state));
                }
            }
            pointEntitySigmob.setOptions(map);
        }
    }

    public c a() {
        return this.b.get();
    }

    @JavascriptInterface
    public String addMacro(JSONObject jsonData) {
        try {
            BaseAdUnit baseAdUnitB = b();
            String string = jsonData.has("key") ? jsonData.getString("key") : null;
            String string2 = jsonData.has("value") ? jsonData.getString("value") : null;
            if (!com.sigmob.sdk.base.utils.s.a((CharSequence) string) && !com.sigmob.sdk.base.utils.s.a((CharSequence) string2)) {
                baseAdUnitB.getMacroCommon().addMarcoKey(string, string2);
                return a(200, "addMacro success", (Object) null);
            }
            return a(300, "key or value is empty", (Object) null);
        } catch (Throwable th) {
            return a(500, "addMacro add fail " + th.getMessage(), (Object) null);
        }
    }

    public BaseAdUnit b() {
        c cVarA = a();
        if (cVarA == null) {
            return null;
        }
        return cVarA.c;
    }

    @JavascriptInterface
    public String excuteRewardAdTrack(JSONObject jsonData) {
        try {
            BaseAdUnit baseAdUnitB = b();
            String string = jsonData.getString(NotificationCompat.CATEGORY_EVENT);
            if (com.sigmob.sdk.base.utils.s.a((CharSequence) string, (CharSequence) "click")) {
                com.sigmob.sdk.base.utils.d.a("AppInfoJS", baseAdUnitB);
            }
            int iB = com.sigmob.sdk.base.network.h.b(baseAdUnitB, string, true);
            if (iB == 0) {
                return a(200, "excuteRewardAdTrack success", (Object) null);
            }
            if (iB == -1) {
                return a(300, "event is empty", (Object) null);
            }
            return iB == -2 ? a(300, string + " can't find in trackers", (Object) null) : a(MediaPlayer.MEDIA_PLAYER_OPTION_USE_CODEC_POOL, "unknown error: " + iB, (Object) null);
        } catch (Throwable th) {
            return a(500, "unknown error: " + th.getMessage(), (Object) null);
        }
    }

    @JavascriptInterface
    public String func(String jsonData) {
        try {
            JSONObject jSONObject = new JSONObject(jsonData);
            String string = jSONObject.has("func") ? jSONObject.getString("func") : null;
            if (com.sigmob.sdk.base.utils.s.a((CharSequence) string)) {
                return a(MediaPlayer.MEDIA_PLAYER_OPTION_USE_CODEC_POOL, "func is empty", (Object) null);
            }
            ReflectionUtil.MethodBuilder methodBuilder = new ReflectionUtil.MethodBuilder(this, string.replace(":", ""));
            methodBuilder.addParam(JSONObject.class, jSONObject);
            return (String) methodBuilder.execute();
        } catch (Throwable th) {
            return a(500, th.getMessage(), (Object) null);
        }
    }

    /* JADX WARN: Code duplicated, block: B:117:0x01b7  */
    @JavascriptInterface
    public String getAppInfo(JSONObject jsonData) {
        Object androidId;
        int densityDpi;
        try {
            JSONObject jSONObject = new JSONObject();
            BaseAdUnit baseAdUnitB = b();
            if (jsonData != null && baseAdUnitB != null && jsonData.has("arguments")) {
                JSONArray jSONArray = jsonData.getJSONArray("arguments");
                for (int i = 0; i < jSONArray.length(); i++) {
                    String string = jSONArray.getString(i);
                    try {
                        switch (string) {
                            case "os":
                                jSONObject.put(string, 2);
                                break;
                            case "imei":
                                androidId = "";
                                jSONObject.put(string, androidId);
                                break;
                            case "android_id":
                                androidId = ClientMetadata.getInstance().getAndroidId();
                                jSONObject.put(string, androidId);
                                break;
                            case "google_aid":
                                androidId = ClientMetadata.getInstance().getAdvertisingId();
                                jSONObject.put(string, androidId);
                                break;
                            case "clienttype":
                                androidId = ClientMetadata.getDeviceModel();
                                jSONObject.put(string, androidId);
                                break;
                            case "app_version":
                                androidId = ClientMetadata.getInstance().getAppVersion();
                                jSONObject.put(string, androidId);
                                break;
                            case "sdk_version":
                                androidId = "4.25.14";
                                jSONObject.put(string, androidId);
                                break;
                            case "os_version":
                                androidId = ClientMetadata.getDeviceOsVersion();
                                jSONObject.put(string, androidId);
                                break;
                            case "client_pixel":
                                androidId = String.format("%sx%s", Integer.valueOf(ClientMetadata.getInstance().getDisplayMetrics().widthPixels), Integer.valueOf(ClientMetadata.getInstance().getDisplayMetrics().heightPixels));
                                jSONObject.put(string, androidId);
                                break;
                            case "device_width":
                                androidId = ClientMetadata.getInstance().getDeviceScreenWidthDip();
                                jSONObject.put(string, androidId);
                                break;
                            case "device_height":
                                androidId = ClientMetadata.getInstance().getDeviceScreenHeightDip();
                                jSONObject.put(string, androidId);
                                break;
                            case "screen_density":
                                densityDpi = ClientMetadata.getInstance().getDensityDpi();
                                jSONObject.put(string, densityDpi);
                                break;
                            case "network_type":
                                densityDpi = ClientMetadata.getInstance().getActiveNetworkType();
                                jSONObject.put(string, densityDpi);
                                break;
                            case "pkgname":
                                androidId = ClientMetadata.getInstance().getAppPackageName();
                                jSONObject.put(string, androidId);
                                break;
                            case "screenangle":
                                densityDpi = Math.abs(ClientMetadata.getInstance().getOrientationInt().intValue() - 1) * 90;
                                jSONObject.put(string, densityDpi);
                                break;
                            case "creative_type":
                                densityDpi = baseAdUnitB.getCreativeType();
                                jSONObject.put(string, densityDpi);
                                break;
                            case "ad_type":
                                densityDpi = baseAdUnitB.getAd_type();
                                jSONObject.put(string, densityDpi);
                                break;
                            case "request_id":
                                androidId = baseAdUnitB.getRequestId();
                                jSONObject.put(string, androidId);
                                break;
                            case "placement_id":
                            case "adslot_id":
                                androidId = baseAdUnitB.getAdslot_id();
                                jSONObject.put(string, androidId);
                                break;
                            case "appid":
                                androidId = WindAds.sharedAds().getAppId();
                                jSONObject.put(string, androidId);
                                break;
                            case "ad_source_logo":
                                androidId = baseAdUnitB.getAd_source_logo();
                                jSONObject.put(string, androidId);
                                break;
                            case "ad_source_channel":
                                androidId = baseAdUnitB.getAd_source_channel();
                                jSONObject.put(string, androidId);
                                break;
                            case "vid":
                                androidId = baseAdUnitB.getAd().vid;
                                jSONObject.put(string, androidId);
                                break;
                            case "crid":
                                androidId = baseAdUnitB.getCrid();
                                jSONObject.put(string, androidId);
                                break;
                            case "camp_id":
                                androidId = baseAdUnitB.getCamp_id();
                                jSONObject.put(string, androidId);
                                break;
                            case "cust_id":
                                androidId = baseAdUnitB.getAd().cust_id;
                                jSONObject.put(string, androidId);
                                break;
                            case "bid_price":
                                androidId = baseAdUnitB.getAd().bid_price;
                                jSONObject.put(string, androidId);
                                break;
                            case "product_id":
                                androidId = baseAdUnitB.getAd().product_id;
                                jSONObject.put(string, androidId);
                                break;
                            case "settlement_price_enc":
                                androidId = baseAdUnitB.getAd().settlement_price_enc;
                                jSONObject.put(string, androidId);
                                break;
                            case "is_override":
                                androidId = baseAdUnitB.getAd().is_override;
                                jSONObject.put(string, androidId);
                                break;
                            case "forbiden_parse_landingpage":
                                androidId = baseAdUnitB.getAd().forbiden_parse_landingpage;
                                jSONObject.put(string, androidId);
                                break;
                            case "display_orientation":
                                densityDpi = baseAdUnitB.getDisplay_orientation();
                                jSONObject.put(string, densityDpi);
                                break;
                            case "expired_time":
                                androidId = baseAdUnitB.getAd().expired_time;
                                jSONObject.put(string, androidId);
                                break;
                        }
                    } catch (Throwable unused) {
                    }
                }
            }
            return a(200, "getAppInfo success ", jSONObject);
        } catch (Throwable th) {
            return a(500, "getAppInfo error: " + th.getMessage(), (Object) null);
        }
    }

    @JavascriptInterface
    public String hello(JSONObject jsonData) {
        try {
            return jsonData.toString();
        } catch (Throwable unused) {
            return null;
        }
    }

    @JavascriptInterface
    public String javascriptAddDcLog(final JSONObject jsonData) {
        try {
            if (jsonData == null) {
                return a(MediaPlayer.MEDIA_PLAYER_OPTION_USE_CODEC_POOL, "not params", (Object) null);
            }
            if (!jsonData.has(PointParamKey._AC_TYPE)) {
                return a(300, "_ac_type is empty", (Object) null);
            }
            String string = jsonData.getString(PointParamKey._AC_TYPE);
            final BaseAdUnit baseAdUnitB = b();
            ad.a(string, baseAdUnitB, (LoadAdRequest) null, new ad.a() { // from class: com.sigmob.sdk.mraid.a$$ExternalSyntheticLambda1
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    a.a(jsonData, baseAdUnitB, obj);
                }
            });
            return a(200, "add dc log success", (Object) null);
        } catch (Throwable th) {
            return a(500, th.toString(), (Object) null);
        }
    }

    @JavascriptInterface
    public String mraidJsLoaded() {
        c cVarA = a();
        if (cVarA != null && cVarA.d != null) {
            cVarA.d.b();
        }
        return null;
    }

    @JavascriptInterface
    public void postMessage(final String data) {
        com.sigmob.sdk.base.utils.k.c("AppInfoJS", "postMessage: raw = " + data, new Object[0]);
        final c cVarA = a();
        if (cVarA == null) {
            return;
        }
        cVarA.e.post(new Runnable() { // from class: com.sigmob.sdk.mraid.a$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a(data, cVarA);
            }
        });
    }

    @JavascriptInterface
    public String tracking(JSONObject jsonData) {
        try {
            BaseAdUnit baseAdUnitB = b();
            String strOptString = jsonData.optString(NotificationCompat.CATEGORY_EVENT);
            JSONArray jSONArrayOptJSONArray = jsonData.optJSONArray("urls");
            if (jSONArrayOptJSONArray != null && jSONArrayOptJSONArray.length() > 0) {
                for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                    ai aiVar = new ai(jSONArrayOptJSONArray.optString(i), strOptString, baseAdUnitB.getRequestId());
                    aiVar.setRetryNum(Integer.valueOf(baseAdUnitB.getTrackingRetryNum()));
                    aiVar.setSource("js");
                    com.sigmob.sdk.base.network.h.a((AdTracker) aiVar, baseAdUnitB, false);
                }
                return a(200, "tracking success.", (Object) null);
            }
            return a(300, "urls is empty.", (Object) null);
        } catch (Throwable th) {
            return a(500, "unknown error: " + th.getMessage(), (Object) null);
        }
    }
}
