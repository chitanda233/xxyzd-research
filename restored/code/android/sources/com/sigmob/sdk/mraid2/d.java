package com.sigmob.sdk.mraid2;

import android.content.Context;
import android.util.DisplayMetrics;
import android.view.View;
import android.webkit.ConsoleMessage;
import android.webkit.JavascriptInterface;
import android.webkit.JsPromptResult;
import android.webkit.JsResult;
import android.webkit.ValueCallback;
import android.webkit.WebChromeClient;
import android.webkit.WebView;
import androidx.core.app.NotificationCompat;
import com.byazt.bv.BaseConstants;
import com.byazt.nys.PluginConstants;
import com.bykv.vk.component.ttvideo.player.MediaFormat;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.json.JSONSerializer;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.ReflectionUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.wire.Wire;
import com.sigmob.sdk.Sigmob;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.ai;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.rtb.Ad;
import com.sigmob.sdk.base.models.rtb.AndroidMarket;
import com.sigmob.sdk.base.models.rtb.BidResponse;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.sdk.base.models.rtb.Template;
import com.sigmob.sdk.base.models.rtb.WXProgramRes;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.mta.PointParamKey;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class d implements j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3533a = "Mraid2Bridge";
    private static p e;
    private static final HashMap<String, List<String>> h = new HashMap<>();
    private final List<BaseAdUnit> b;
    private k c;
    private c d;
    private f f;
    private final List<BaseAdUnit> g;
    private volatile boolean i;
    private boolean j;
    private String k;

    /* JADX INFO: renamed from: com.sigmob.sdk.mraid2.d$2, reason: invalid class name */
    class AnonymousClass2 implements com.sigmob.sdk.base.network.f.a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ d f3535a;
        final /* synthetic */ String b;

        AnonymousClass2(final d val$mraidBridge, final String val$ev) {
            this.f3535a = val$mraidBridge;
            this.b = val$ev;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void a(List list, BaseAdUnit baseAdUnit, Object obj) {
            if (obj instanceof PointEntitySigmob) {
                Map<String, String> options = ((PointEntitySigmob) obj).getOptions();
                options.put(PointParamKey.AD_COUNT, String.valueOf(list.size()));
                options.put(PointParamKey.REQUEST_ID, baseAdUnit.getRequestId());
            }
        }

        @Override // com.sigmob.sdk.base.network.f.a
        public void a(int error, String message, String requestId, LoadAdRequest loadAdRequest) {
            com.sigmob.sdk.base.utils.k.f(d.f3533a, "onErrorResponse: error = " + error + ", message = " + message, new Object[0]);
            this.f3535a.a(this.b, (BidResponse) null, error, message);
            ad.a(PointCategory.RESPOND, "0", loadAdRequest);
        }

        @Override // com.sigmob.sdk.base.network.f.a
        public void a(final List<BaseAdUnit> adUnitList, LoadAdRequest loadAdRequest) {
            if (com.sigmob.sdk.base.utils.f.a(adUnitList)) {
                return;
            }
            com.sigmob.sdk.base.utils.k.c(d.f3533a, "onSuccess: size = " + adUnitList.size(), new Object[0]);
            d.this.g.addAll(adUnitList);
            this.f3535a.a(this.b, d.this.a(adUnitList), 0, (String) null);
            final BaseAdUnit baseAdUnit = adUnitList.get(0);
            ad.a(PointCategory.RESPOND, "1", baseAdUnit, new ad.a() { // from class: com.sigmob.sdk.mraid2.d$2$$ExternalSyntheticLambda0
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    d.AnonymousClass2.a(adUnitList, baseAdUnit, obj);
                }
            });
        }
    }

    static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final WeakReference<d> f3536a;

        public a(d mraidBridge) {
            this.f3536a = new WeakReference<>(mraidBridge);
        }

        /* JADX INFO: Access modifiers changed from: private */
        public /* synthetic */ void a(final JSONObject jSONObject) {
            c cVarA;
            final d dVarA = a();
            if (dVarA == null || (cVarA = dVarA.a()) == null) {
                return;
            }
            cVarA.post(new Runnable() { // from class: com.sigmob.sdk.mraid2.d$a$$ExternalSyntheticLambda3
                @Override // java.lang.Runnable
                public final void run() {
                    dVarA.b(jSONObject);
                }
            });
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void a(JSONObject jSONObject, Object obj) {
            HashMap map = new HashMap();
            Iterator<String> itKeys = jSONObject.keys();
            while (itKeys.hasNext()) {
                String next = itKeys.next();
                if (!next.equalsIgnoreCase(PointParamKey._AC_TYPE)) {
                    map.put(next, jSONObject.optString(next));
                }
            }
            if (obj instanceof PointEntitySigmob) {
                PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
                if (com.sigmob.sdk.base.utils.f.b(map)) {
                    pointEntitySigmob.getOptions().putAll(map);
                }
            }
        }

        public d a() {
            return this.f3536a.get();
        }

        @JavascriptInterface
        public String addDclog(JSONObject jsonData) {
            com.sigmob.sdk.base.utils.k.c(d.f3533a, "addDclog: jsonData = " + jsonData, new Object[0]);
            try {
                if (jsonData == null) {
                    return d.a(MediaPlayer.MEDIA_PLAYER_OPTION_USE_CODEC_POOL, "not params", (Object) null);
                }
                d dVarA = a();
                final JSONObject jSONObjectOptJSONObject = jsonData.optJSONObject("data");
                if (jSONObjectOptJSONObject == null || !jSONObjectOptJSONObject.has(PointParamKey._AC_TYPE)) {
                    return d.a(300, "_ac_type is empty", (Object) null);
                }
                String strOptString = jSONObjectOptJSONObject.optString(PointParamKey._AC_TYPE);
                String strOptString2 = jsonData.optString(PointParamKey.VID);
                if (jSONObjectOptJSONObject.optString(PointParamKey.CATEGORY).equals("start") && dVarA != null && dVarA.f != null) {
                    dVarA.f.d();
                }
                ad.a(strOptString, dVarA == null ? null : dVarA.b(strOptString2), dVarA == null ? null : dVarA.j(), new ad.a() { // from class: com.sigmob.sdk.mraid2.d$a$$ExternalSyntheticLambda1
                    @Override // com.sigmob.sdk.base.common.ad.a
                    public final void onAddExtra(Object obj) {
                        d.a.a(jSONObjectOptJSONObject, obj);
                    }
                });
                return d.a(200, "add dc log success", (Object) null);
            } catch (Throwable th) {
                return d.a(500, th.toString(), (Object) null);
            }
        }

        @JavascriptInterface
        public String func(String jsonData) {
            try {
                JSONObject jSONObject = new JSONObject(jsonData);
                String string = jSONObject.has("func") ? jSONObject.getString("func") : null;
                if (com.sigmob.sdk.base.utils.s.a((CharSequence) string)) {
                    return d.a(MediaPlayer.MEDIA_PLAYER_OPTION_USE_CODEC_POOL, "func is empty.", (Object) null);
                }
                ReflectionUtil.MethodBuilder methodBuilder = new ReflectionUtil.MethodBuilder(this, string.replace(":", ""));
                methodBuilder.addParam(JSONObject.class, jSONObject);
                return (String) methodBuilder.execute();
            } catch (Throwable th) {
                return d.a(500, th.getMessage(), (Object) null);
            }
        }

        @JavascriptInterface
        public String getDeviceInfo() {
            try {
                com.sigmob.sdk.base.utils.k.c(d.f3533a, "getDeviceInfo", new Object[0]);
                JSONObject jSONObject = new JSONObject();
                jSONObject.put("clientType", ClientMetadata.getDeviceModel());
                jSONObject.put("osVersion", ClientMetadata.getDeviceOsVersion());
                jSONObject.put("appVersion", ClientMetadata.getInstance().getAppVersion());
                jSONObject.put(MediaFormat.KEY_WIDTH, ClientMetadata.getInstance().getDisplayMetrics().widthPixels);
                jSONObject.put(MediaFormat.KEY_HEIGHT, ClientMetadata.getInstance().getDisplayMetrics().heightPixels);
                jSONObject.put("screenDensity", ClientMetadata.getInstance().getDensityDpi());
                jSONObject.put("networkType", ClientMetadata.getInstance().getActiveNetworkType());
                jSONObject.put("pkgName", ClientMetadata.getInstance().getAppPackageName());
                jSONObject.put("userAgent", Networking.getUserAgent());
                jSONObject.put("uid", ClientMetadata.getUid());
                jSONObject.put("udid", ClientMetadata.getInstance().getUDID());
                JSONObject jSONObject2 = new JSONObject();
                jSONObject2.put("imei", "");
                jSONObject2.put("androidId", ClientMetadata.getInstance().getAndroidId());
                jSONObject2.put("googleId", ClientMetadata.getInstance().getAdvertisingId());
                jSONObject2.put("oaid", ClientMetadata.getInstance().getOAID());
                jSONObject.put("android", jSONObject2);
                return jSONObject.toString();
            } catch (Throwable th) {
                com.sigmob.sdk.base.utils.k.f(d.f3533a, "getDeviceInfo: error = " + th, new Object[0]);
                return null;
            }
        }

        @JavascriptInterface
        public String getUniqueId() {
            d dVarA = a();
            if (dVarA == null) {
                return null;
            }
            return dVarA.a().getUniqueId();
        }

        /* JADX WARN: Code duplicated, block: B:30:0x0089  */
        /* JADX WARN: Failed to restore switch over string. Please report as a decompilation issue */
        @JavascriptInterface
        public String handleMacro(JSONObject jsonData) {
            byte b = 0;
            com.sigmob.sdk.base.utils.k.c(d.f3533a, "handleMacro: jsonData = " + jsonData, new Object[0]);
            if (jsonData == null) {
                return null;
            }
            try {
                String strOptString = jsonData.optString(NotificationCompat.CATEGORY_EVENT);
                JSONObject jSONObjectOptJSONObject = jsonData.optJSONObject("args");
                if (jSONObjectOptJSONObject == null) {
                    return null;
                }
                String strOptString2 = jSONObjectOptJSONObject.optString("key");
                String strOptString3 = jSONObjectOptJSONObject.optString("value");
                BaseAdUnit baseAdUnitB = a() != null ? a().b(jSONObjectOptJSONObject.optString(PointParamKey.VID)) : null;
                switch (strOptString.hashCode()) {
                    case -1253019733:
                        if (!strOptString.equals("addMacro")) {
                            b = -1;
                        } else {
                            b = 1;
                        }
                        break;
                    case -759131257:
                        if (!strOptString.equals("addAllMacros")) {
                            b = -1;
                        }
                        break;
                    case -750002817:
                        if (!strOptString.equals("clearMacro")) {
                            b = -1;
                        } else {
                            b = 4;
                        }
                        break;
                    case -310745688:
                        if (!strOptString.equals("removeMacro")) {
                            b = -1;
                        } else {
                            b = 3;
                        }
                        break;
                    case 1959477782:
                        if (!strOptString.equals("getMacro")) {
                            b = -1;
                        } else {
                            b = 2;
                        }
                        break;
                    default:
                        b = -1;
                        break;
                }
                if (b == 0) {
                    JSONObject jSONObjectOptJSONObject2 = jSONObjectOptJSONObject.optJSONObject("maps");
                    if (jSONObjectOptJSONObject2 == null) {
                        return null;
                    }
                    Iterator<String> itKeys = jSONObjectOptJSONObject2.keys();
                    while (itKeys.hasNext()) {
                        String next = itKeys.next();
                        (baseAdUnitB == null ? Sigmob.getInstance().getMacroCommon() : baseAdUnitB.getMacroCommon()).addMarcoKey(next, jSONObjectOptJSONObject2.optString(next));
                    }
                } else if (b != 1) {
                    if (b == 2) {
                        if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString2)) {
                            return null;
                        }
                        return baseAdUnitB == null ? Sigmob.getInstance().getMacroCommon().getMarcoKey(strOptString2) : baseAdUnitB.getMacroCommon().getMarcoKey(strOptString2);
                    }
                    if (b == 3) {
                        if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString2)) {
                            return null;
                        }
                        (baseAdUnitB == null ? Sigmob.getInstance().getMacroCommon() : baseAdUnitB.getMacroCommon()).removeMarcoKey(strOptString2);
                    } else if (b == 4) {
                        (baseAdUnitB == null ? Sigmob.getInstance().getMacroCommon() : baseAdUnitB.getMacroCommon()).clearMacro();
                    }
                } else {
                    if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString2)) {
                        return null;
                    }
                    (baseAdUnitB == null ? Sigmob.getInstance().getMacroCommon() : baseAdUnitB.getMacroCommon()).addMarcoKey(strOptString2, strOptString3);
                }
                return null;
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

        @JavascriptInterface
        public void postMessage(final String data) {
            final d dVarA;
            com.sigmob.sdk.base.utils.k.c(d.f3533a, "postMessage: data = " + data, new Object[0]);
            if (com.sigmob.sdk.base.utils.s.a((CharSequence) data) || (dVarA = a()) == null || dVarA.d == null) {
                return;
            }
            dVarA.d.post(new Runnable() { // from class: com.sigmob.sdk.mraid2.d$a$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    d dVar = dVarA;
                    dVar.a(dVar, data);
                }
            });
        }

        /* JADX WARN: Code duplicated, block: B:35:0x00ab  */
        /* JADX WARN: Failed to restore switch over string. Please report as a decompilation issue */
        @JavascriptInterface
        public String storage(String json) {
            byte b = 0;
            com.sigmob.sdk.base.utils.k.c(d.f3533a, "storage: json = " + json, new Object[0]);
            if (com.sigmob.sdk.base.utils.s.a((CharSequence) json)) {
                return null;
            }
            try {
                JSONObject jSONObject = new JSONObject(json);
                String strOptString = jSONObject.optString(NotificationCompat.CATEGORY_EVENT);
                JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("args");
                if (jSONObjectOptJSONObject == null) {
                    return null;
                }
                int iOptInt = jSONObjectOptJSONObject.optInt("type");
                String strOptString2 = jSONObjectOptJSONObject.optString("key");
                String strOptString3 = jSONObjectOptJSONObject.optString("value");
                if (iOptInt == 1 || iOptInt == 2) {
                    if (d.e == null) {
                        p unused = d.e = new p(a().d.getContext());
                    }
                    switch (strOptString.hashCode()) {
                        case -1106363674:
                            if (!strOptString.equals("length")) {
                                b = -1;
                            } else {
                                b = 4;
                            }
                            break;
                        case -625809843:
                            if (!strOptString.equals("addEventListener")) {
                                b = -1;
                            } else {
                                b = 5;
                            }
                            break;
                        case -75439223:
                            if (!strOptString.equals("getItem")) {
                                b = -1;
                            } else {
                                b = 1;
                            }
                            break;
                        case 94746189:
                            if (!strOptString.equals("clear")) {
                                b = -1;
                            } else {
                                b = 3;
                            }
                            break;
                        case 1098253751:
                            if (!strOptString.equals("removeItem")) {
                                b = -1;
                            } else {
                                b = 2;
                            }
                            break;
                        case 1984670357:
                            if (!strOptString.equals("setItem")) {
                                b = -1;
                            }
                            break;
                        default:
                            b = -1;
                            break;
                    }
                    if (b == 0) {
                        d.e.a(iOptInt, strOptString2, strOptString3);
                    } else {
                        if (b == 1) {
                            return d.e.a(iOptInt, strOptString2);
                        }
                        if (b == 2) {
                            d.e.b(iOptInt, strOptString2);
                        } else if (b == 3) {
                            d.e.a(iOptInt);
                        } else {
                            if (b == 4) {
                                return String.valueOf(d.e.b(iOptInt));
                            }
                            if (b == 5) {
                                d.e.a(iOptInt, strOptString2, new p.a() { // from class: com.sigmob.sdk.mraid2.d$a$$ExternalSyntheticLambda2
                                    @Override // com.sigmob.sdk.mraid2.p.a
                                    public final void valueChange(JSONObject jSONObject2) {
                                        this.f$0.a(jSONObject2);
                                    }
                                });
                            }
                        }
                    }
                }
                return null;
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

        @JavascriptInterface
        public String tracking(JSONObject jsonData) {
            boolean zOptBoolean;
            boolean zOptBoolean2;
            int iOptInt;
            String strOptString;
            boolean zOptBoolean3;
            int i;
            com.sigmob.sdk.base.utils.k.c(d.f3533a, "tracking: jsonData = " + jsonData, new Object[0]);
            try {
                if (jsonData == null) {
                    return d.a(MediaPlayer.MEDIA_PLAYER_OPTION_USE_CODEC_POOL, "not params", (Object) null);
                }
                String strOptString2 = jsonData.optString(NotificationCompat.CATEGORY_EVENT);
                JSONArray jSONArrayOptJSONArray = jsonData.optJSONArray("urls");
                JSONObject jSONObjectOptJSONObject = jsonData.optJSONObject("data");
                if (jSONObjectOptJSONObject == null) {
                    zOptBoolean = false;
                    zOptBoolean2 = false;
                    iOptInt = 0;
                    zOptBoolean3 = false;
                    strOptString = "";
                } else {
                    zOptBoolean = jSONObjectOptJSONObject.optBoolean("inQueue");
                    zOptBoolean2 = jSONObjectOptJSONObject.optBoolean("statistic");
                    iOptInt = jSONObjectOptJSONObject.optInt("retry");
                    strOptString = jSONObjectOptJSONObject.optString(PointParamKey.VID);
                    zOptBoolean3 = jSONObjectOptJSONObject.optBoolean("repeat");
                }
                d dVarA = a();
                Context context = dVarA == null ? null : dVarA.d.getContext();
                BaseAdUnit baseAdUnitB = dVarA == null ? null : dVarA.b(strOptString);
                if (!com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString2, (CharSequence) "click")) {
                    i = 0;
                } else if (context == null || baseAdUnitB == null) {
                    i = 0;
                    com.sigmob.sdk.base.utils.k.c(d.f3533a, "tracking: value is null.", new Object[0]);
                } else {
                    String requestId = baseAdUnitB.getRequestId();
                    int iOptInt2 = jSONObjectOptJSONObject == null ? 0 : jSONObjectOptJSONObject.optInt("clickLoseRate");
                    int iOptInt3 = com.sigmob.sdk.base.utils.d.b;
                    if (jSONObjectOptJSONObject != null) {
                        iOptInt3 = jSONObjectOptJSONObject.optInt("clickCbState", iOptInt3);
                    }
                    com.sigmob.sdk.base.utils.d.a(requestId, Integer.valueOf(iOptInt2), Integer.valueOf(iOptInt3));
                    com.sigmob.sdk.base.utils.k.c(d.f3533a, "tracking: clickCbState = " + iOptInt3, new Object[0]);
                    boolean z = true;
                    if (jSONObjectOptJSONObject != null && !jSONObjectOptJSONObject.optBoolean("normalClick", true)) {
                        z = false;
                    }
                    if (z) {
                        BaseBroadcastReceiver.a(context, baseAdUnitB.getUuid(), IntentActions.ACTION_INTERSTITIAL_CLICK);
                    }
                    i = 0;
                }
                if (jSONArrayOptJSONArray != null && jSONArrayOptJSONArray.length() != 0) {
                    for (int i2 = i; i2 < jSONArrayOptJSONArray.length(); i2++) {
                        ai aiVar = new ai(jSONArrayOptJSONArray.optString(i2), strOptString2, baseAdUnitB != null ? baseAdUnitB.getRequestId() : "");
                        aiVar.setRetryNum(Integer.valueOf(iOptInt));
                        aiVar.setSource("js");
                        com.sigmob.sdk.base.network.h.a(aiVar, baseAdUnitB, zOptBoolean3, zOptBoolean, zOptBoolean2, null);
                    }
                    return d.a(200, "tracking success", (Object) null);
                }
                List<ai> adTracker = baseAdUnitB == null ? null : baseAdUnitB.getAdTracker(strOptString2);
                if (com.sigmob.sdk.base.utils.f.b(adTracker)) {
                    for (ai aiVar2 : adTracker) {
                        aiVar2.setRetryNum(Integer.valueOf(iOptInt));
                        aiVar2.setSource("js");
                        com.sigmob.sdk.base.network.h.a(aiVar2, baseAdUnitB, zOptBoolean3, zOptBoolean, zOptBoolean2, null);
                    }
                }
                return d.a(300, "urls is empty", (Object) null);
            } catch (Throwable th) {
                return d.a(500, "unknown error: " + th.getMessage(), (Object) null);
            }
        }
    }

    d(final List<BaseAdUnit> adUnitList) {
        LinkedList linkedList = new LinkedList();
        this.g = linkedList;
        this.j = false;
        this.b = adUnitList;
        linkedList.addAll(adUnitList);
        ThreadPoolFactory.getFixIOExecutor().submit(new Runnable() { // from class: com.sigmob.sdk.mraid2.d$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.b(adUnitList);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public BidResponse a(List<BaseAdUnit> adUnitList) {
        Template templateBuild;
        ArrayList arrayList = new ArrayList();
        for (int i = 0; i < adUnitList.size(); i++) {
            Ad ad = adUnitList.get(i).getAd();
            ArrayList arrayList2 = new ArrayList();
            if (ad != null && ad.materials != null && !ad.materials.isEmpty()) {
                MaterialMeta.Builder builderNewBuilder = ad.materials.get(0).newBuilder();
                if (builderNewBuilder.main_template != null && builderNewBuilder.main_template.type.intValue() == 2) {
                    Template templateBuild2 = builderNewBuilder.main_template.newBuilder().context(null).build();
                    templateBuild2.templateId = builderNewBuilder.main_template.templateId;
                    builderNewBuilder.main_template(templateBuild2);
                }
                if (builderNewBuilder.sub_template != null && builderNewBuilder.sub_template.type.intValue() == 2) {
                    Template templateBuild3 = builderNewBuilder.sub_template.newBuilder().context(null).build();
                    templateBuild3.templateId = builderNewBuilder.sub_template.templateId;
                    builderNewBuilder.sub_template(templateBuild3);
                }
                arrayList2.add(builderNewBuilder.html_snippet(null).build());
                arrayList.add(ad.newBuilder().materials(arrayList2).build());
            }
        }
        BidResponse.Builder builder = new BidResponse.Builder();
        BaseAdUnit baseAdUnit = adUnitList.get(0);
        if (baseAdUnit != null) {
            if (baseAdUnit.scene != null) {
                if (baseAdUnit.scene.type.intValue() == 2) {
                    templateBuild = baseAdUnit.scene.newBuilder().context(null).build();
                    templateBuild.templateId = baseAdUnit.scene.templateId;
                } else {
                    templateBuild = baseAdUnit.scene.newBuilder().build();
                }
                builder.scene(templateBuild);
            }
            if (baseAdUnit.slotAdSetting != null) {
                builder.slot_ad_setting(baseAdUnit.slotAdSetting.newBuilder().build());
            }
            if (baseAdUnit.bidding_response != null) {
                builder.bidding_response(baseAdUnit.bidding_response.newBuilder().build());
            }
            builder.request_id(baseAdUnit.getRequestId());
            builder.uid(baseAdUnit.uid);
            builder.expiration_time(Integer.valueOf(baseAdUnit.expiration_time));
        }
        return builder.ads(arrayList).build();
    }

    public static String a(int code, String message, Object data) {
        try {
            JSONObject jSONObject = new JSONObject();
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, code);
            if (com.sigmob.sdk.base.utils.s.b(message)) {
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

    private void a(d bridge, String data, String subEvent) {
        if (com.sigmob.sdk.base.utils.v.b(this.f)) {
            subEvent.hashCode();
            if (subEvent.equals("init")) {
                this.f.a();
            } else if (subEvent.equals(com.sigmob.sdk.mraid.g.b)) {
                this.f.b();
            }
        }
        if (com.sigmob.sdk.base.utils.v.b(bridge)) {
            bridge.d(data);
        }
    }

    private void a(d bridge, String data, String subEvent, JSONObject args) {
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.a(subEvent, args);
        }
        bridge.d(data);
    }

    private void a(d bridge, String data, JSONObject args) {
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.c(args);
        }
        bridge.d(data);
    }

    /* JADX WARN: Code duplicated, block: B:42:0x010b  */
    /* JADX WARN: Type inference fix 'apply assigned field type' failed
    java.lang.UnsupportedOperationException: ArgType.getObject(), call class: class jadx.core.dex.instructions.args.ArgType$UnknownArg
    	at jadx.core.dex.instructions.args.ArgType.getObject(ArgType.java:596)
    	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsMapFor(ClassTypeVarsAttr.java:35)
    	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
     */
    private void a(d bridge, String cmd, JSONObject args, String event) throws JSONException {
        JSONObject jSONObject;
        String str;
        String strOptString = args == null ? null : args.optString(PointParamKey.VID);
        if (com.sigmob.sdk.base.utils.s.b(strOptString)) {
            JSONObject jSONObjectOptJSONObject = args.optJSONObject("data");
            if (jSONObjectOptJSONObject == null) {
                jSONObjectOptJSONObject = new JSONObject();
            }
            jSONObjectOptJSONObject.put(PointParamKey.VID, strOptString);
            BaseAdUnit baseAdUnitB = bridge.b(strOptString);
            String deeplinkUrl = baseAdUnitB.getDeeplinkUrl();
            String landing_page = baseAdUnitB.getLanding_page();
            AndroidMarket androidMarket = baseAdUnitB.getAndroidMarket();
            WXProgramRes wXProgramRes = baseAdUnitB.getWXProgramRes();
            JSONObject jSONObject2 = new JSONObject();
            boolean z = com.sigmob.sdk.base.utils.v.b(androidMarket) && com.sigmob.sdk.base.utils.s.b(androidMarket.market_url);
            int interactionType = z ? 3 : baseAdUnitB.getInteractionType();
            if (z) {
                jSONObject = new JSONObject();
                jSONObject.put("market_url", androidMarket.market_url);
                jSONObject.put("type", Wire.get(androidMarket.type, 0));
                String str2 = androidMarket.app_package_name;
                if (com.sigmob.sdk.base.utils.s.b(str2)) {
                    jSONObject.put("app_package_name", str2);
                }
                String str3 = androidMarket.appstore_package_name;
                if (com.sigmob.sdk.base.utils.s.b(str3)) {
                    jSONObject.put("appstore_package_name", str3);
                }
                str = BaseConstants.SCHEME_MARKET;
            } else {
                if (interactionType == 7 && com.sigmob.sdk.base.utils.v.b(wXProgramRes)) {
                    jSONObject = new JSONObject();
                    jSONObject.put("wx_app_id", wXProgramRes.wx_app_id);
                    jSONObject.put("wx_app_username", wXProgramRes.wx_app_username);
                    jSONObject.put("wx_app_path", wXProgramRes.wx_app_path);
                    jSONObject.put("wx_business_type", wXProgramRes.wx_business_type);
                    jSONObject.put("wx_ext_msg", wXProgramRes.wx_ext_msg);
                    str = "program";
                } else if (!com.sigmob.sdk.base.utils.s.b(deeplinkUrl) || interactionType == 2) {
                    jSONObject2.put("url", landing_page);
                } else {
                    jSONObject2.put("url", deeplinkUrl);
                }
                jSONObjectOptJSONObject.put("default_url", landing_page);
                jSONObjectOptJSONObject.put("in_app", !baseAdUnitB.isSkipSigmobBrowser());
                jSONObjectOptJSONObject.put("interaction_type", interactionType);
                jSONObjectOptJSONObject.put("parse_302", !baseAdUnitB.getAd().forbiden_parse_landingpage.booleanValue());
                jSONObject2.put(NotificationCompat.CATEGORY_EVENT, event);
                jSONObject2.put("data", jSONObjectOptJSONObject);
                if (com.sigmob.sdk.base.utils.v.b(this.c)) {
                    this.c.a(baseAdUnitB, jSONObject2);
                }
            }
            jSONObjectOptJSONObject.put(str, jSONObject);
            jSONObjectOptJSONObject.put("default_url", landing_page);
            jSONObjectOptJSONObject.put("in_app", !baseAdUnitB.isSkipSigmobBrowser());
            jSONObjectOptJSONObject.put("interaction_type", interactionType);
            jSONObjectOptJSONObject.put("parse_302", !baseAdUnitB.getAd().forbiden_parse_landingpage.booleanValue());
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, event);
            jSONObject2.put("data", jSONObjectOptJSONObject);
            if (com.sigmob.sdk.base.utils.v.b(this.c)) {
                this.c.a(baseAdUnitB, jSONObject2);
            }
        }
        bridge.d(cmd);
    }

    private void a(final d bridge, JSONObject args) {
        if (args == null) {
            return;
        }
        int iOptInt = args.optInt("delay");
        final String strOptString = args.optString(NotificationCompat.CATEGORY_EVENT);
        if (iOptInt < 0 || !com.sigmob.sdk.base.utils.s.b(strOptString)) {
            return;
        }
        bridge.a().postDelayed(new Runnable() { // from class: com.sigmob.sdk.mraid2.d$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.f(strOptString);
            }
        }, iOptInt);
    }

    private void a(String key, Map extras) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, key);
            jSONObject.put("notify", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    private void b(d bridge, String data, String subEvent, JSONObject args) {
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.b(subEvent, args);
        }
        bridge.d(data);
    }

    private void b(d bridge, String data, JSONObject args) {
        if (bridge == null) {
            return;
        }
        JSONObject jSONObjectOptJSONObject = args == null ? null : args.optJSONObject("data");
        String strOptString = jSONObjectOptJSONObject == null ? null : jSONObjectOptJSONObject.optString(PointParamKey.VID);
        BaseAdUnit baseAdUnitB = com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString) ? null : bridge.b(strOptString);
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.a(baseAdUnitB, args);
        }
        bridge.d(data);
    }

    private void b(d bridge, JSONObject args) {
        BaseAdUnit baseAdUnitB = null;
        String strOptString = args == null ? null : args.optString(PointParamKey.VID);
        if (!com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString)) {
            JSONObject jSONObjectOptJSONObject = args.optJSONObject("data");
            if (jSONObjectOptJSONObject == null) {
                jSONObjectOptJSONObject = new JSONObject();
            }
            try {
                jSONObjectOptJSONObject.put(PointParamKey.VID, strOptString);
            } catch (Exception e2) {
                com.sigmob.sdk.base.utils.k.f(f3533a, "handleFeedbackByVid: error = " + e2.getMessage(), new Object[0]);
            }
            baseAdUnitB = bridge.b(strOptString);
        }
        if (com.sigmob.sdk.base.utils.v.b(this.f)) {
            this.f.a(baseAdUnitB);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void b(List list) {
        this.k = JSONSerializer.Serialize(a((List<BaseAdUnit>) list), "bidResponse", true, true);
    }

    private void c(d bridge, String data, String subEvent, JSONObject args) {
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.c(subEvent, args);
        }
        bridge.d(data);
    }

    private void c(d mraidBridge, String data, JSONObject args) {
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.d(args);
        }
        mraidBridge.d(data);
    }

    private void c(d mraidBridge, JSONObject args) {
        String strOptString = args == null ? null : args.optString(NotificationCompat.CATEGORY_EVENT);
        JSONObject jSONObjectOptJSONObject = args != null ? args.optJSONObject("data") : null;
        HashMap map = new HashMap();
        if (com.sigmob.sdk.base.utils.v.b(jSONObjectOptJSONObject)) {
            Iterator<String> itKeys = jSONObjectOptJSONObject.keys();
            while (itKeys.hasNext()) {
                String next = itKeys.next();
                map.put(next, jSONObjectOptJSONObject.optString(next));
            }
        }
        if (com.sigmob.sdk.base.utils.v.b(this.b.get(0))) {
            LoadAdRequest adRequest = this.b.get(0).getAdRequest();
            adRequest.setOptions(map);
            adRequest.setLastCampid(com.sigmob.sdk.base.common.h.g().o());
            adRequest.setLastCrid(com.sigmob.sdk.base.common.h.g().n());
            com.sigmob.sdk.base.network.f.a(adRequest, new AnonymousClass2(mraidBridge, strOptString));
        }
    }

    private void c(JSONObject args) {
        k kVar = this.c;
        if (kVar == null) {
            return;
        }
        kVar.e(args);
    }

    private void d(d mraidBridge, String data, JSONObject args) {
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.b(args);
        }
        mraidBridge.d(data);
    }

    private void d(JSONObject args) {
        String strOptString = args == null ? null : args.optString(PointParamKey.VID);
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.a(strOptString);
        }
    }

    private void e(d bridge, String data, JSONObject json) {
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.g(json);
        }
        bridge.d(data);
    }

    private void e(JSONObject args) {
        v scrollTouchListener;
        c cVar = this.d;
        if (cVar == null || (scrollTouchListener = cVar.getScrollTouchListener()) == null) {
            return;
        }
        scrollTouchListener.a(this.d, args);
    }

    private void f(d bridge, String data, JSONObject args) {
        if (com.sigmob.sdk.base.utils.v.b(args)) {
            this.d.setVisibility(args.optBoolean("visible") ? 0 : 4);
        }
        bridge.d(data);
    }

    private void f(JSONObject args) {
        v scrollTouchListener;
        c cVar = this.d;
        if (cVar == null || (scrollTouchListener = cVar.getScrollTouchListener()) == null) {
            return;
        }
        scrollTouchListener.b(args);
    }

    private void g(d bridge, String data, JSONObject json) {
        if (com.sigmob.sdk.base.utils.v.b(this.c)) {
            this.c.f(json);
        }
        bridge.d(data);
    }

    private void g(JSONObject args) {
        v scrollTouchListener;
        c cVar = this.d;
        if (cVar == null || (scrollTouchListener = cVar.getScrollTouchListener()) == null) {
            return;
        }
        scrollTouchListener.a(args);
    }

    private void h(JSONObject args) {
        k kVar = this.c;
        if (kVar == null) {
            return;
        }
        kVar.a(args);
    }

    private void i() {
        this.i = true;
        this.d.post(new Runnable() { // from class: com.sigmob.sdk.mraid2.d$$ExternalSyntheticLambda2
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.o();
            }
        });
    }

    private void i(JSONObject args) {
        if (com.sigmob.sdk.base.utils.v.b(this.f) && com.sigmob.sdk.base.utils.v.b(args)) {
            this.f.a(args.optInt("red"), args.optInt("green"), args.optInt("blue"), args.optInt("alpha"));
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public LoadAdRequest j() {
        if (com.sigmob.sdk.base.utils.f.a(this.b)) {
            return null;
        }
        return this.b.get(0).getAdRequest();
    }

    private void j(JSONObject args) {
        List<String> list;
        if (args == null) {
            return;
        }
        String strOptString = args.optString("uniqId");
        String strOptString2 = args.optString(NotificationCompat.CATEGORY_EVENT);
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString) || com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString2) || (list = h.get(strOptString + "~" + strOptString2)) == null) {
            return;
        }
        for (String str : new CopyOnWriteArrayList(list)) {
            if (str.equals(strOptString)) {
                list.remove(str);
            }
        }
    }

    private void k() {
        k kVar = this.c;
        if (kVar == null) {
            return;
        }
        kVar.b();
    }

    private void k(JSONObject args) {
        List<String> list;
        HashMap<String, c> mraidWebViews;
        d mraidBridge;
        if (args == null) {
            return;
        }
        String uniqueId = a().getUniqueId();
        String strOptString = args.optString(NotificationCompat.CATEGORY_EVENT);
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) uniqueId) || com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString) || (list = h.get(uniqueId + "~" + strOptString)) == null || list.isEmpty() || (mraidWebViews = c.getMraidWebViews()) == null) {
            return;
        }
        Iterator<String> it = list.iterator();
        while (it.hasNext()) {
            c cVar = mraidWebViews.get(it.next());
            if (cVar != null && (mraidBridge = cVar.getMraidBridge()) != null) {
                mraidBridge.a(uniqueId, strOptString, args);
            }
        }
    }

    private void l() {
        k kVar = this.c;
        if (kVar == null) {
            return;
        }
        kVar.c();
    }

    private void l(JSONObject args) {
        if (args == null) {
            return;
        }
        String strOptString = args.optString("uniqId");
        String strOptString2 = args.optString(NotificationCompat.CATEGORY_EVENT);
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString) || com.sigmob.sdk.base.utils.s.a((CharSequence) strOptString2)) {
            return;
        }
        HashMap<String, List<String>> map = h;
        List<String> arrayList = map.get(strOptString2);
        if (arrayList == null) {
            arrayList = new ArrayList<>();
            map.put(strOptString + "~" + strOptString2, arrayList);
        }
        arrayList.add(this.d.getUniqueId());
    }

    private void m() {
        k kVar = this.c;
        if (kVar == null) {
            return;
        }
        kVar.d();
    }

    private void n() {
        k kVar = this.c;
        if (kVar == null) {
            return;
        }
        kVar.a();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void o() {
        try {
            if (com.sigmob.sdk.base.utils.v.b(this.f)) {
                this.f.c();
            }
            a(true);
            e();
            a(this.d.getAdSize());
            f();
            a(100);
            a(a(this.b), this.k);
        } catch (Throwable th) {
            com.sigmob.sdk.base.utils.k.f(f3533a, "handleJsLoad: error = " + th.getMessage(), new Object[0]);
        }
    }

    public c a() {
        return this.d;
    }

    void a(int exposedPercentage) {
        a("mraidbridge.fireChangeEvent({\"exposure\":" + exposedPercentage + "});");
    }

    void a(int type, int index) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("type", type);
            jSONObject.put("index", index);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.notifyPageChangeEvent(" + jSONObject + ");");
    }

    void a(int top, int left, int bottom, int right) {
        a("mraidbridge.setSafeAreaInsets(" + (top + "," + left + "," + bottom + "," + right) + ")");
    }

    public void a(com.sigmob.sdk.base.common.g adSize) {
        int iPixelsToIntDips;
        int iPixelsToIntDips2;
        Context context = this.d.getContext();
        DisplayMetrics displayMetrics = context.getResources().getDisplayMetrics();
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            if (adSize == null) {
                iPixelsToIntDips2 = Dips.pixelsToIntDips(displayMetrics.widthPixels, context);
                iPixelsToIntDips = Dips.pixelsToIntDips(displayMetrics.heightPixels, context);
            } else {
                int iPixelsToIntDips3 = Dips.pixelsToIntDips(adSize.a(), context);
                iPixelsToIntDips = Dips.pixelsToIntDips(adSize.b(), context);
                iPixelsToIntDips2 = iPixelsToIntDips3;
            }
            jSONObject2.put(MediaFormat.KEY_WIDTH, iPixelsToIntDips2);
            jSONObject2.put(MediaFormat.KEY_HEIGHT, iPixelsToIntDips);
            jSONObject.put("screenSize", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void a(BidResponse bidResponse, String bidResponseContent) {
        if (com.sigmob.sdk.base.utils.s.a((CharSequence) bidResponseContent)) {
            bidResponseContent = JSONSerializer.Serialize(bidResponse, "bidResponse", true, true);
        }
        a("mraidbridge.fireChangeEvent(" + bidResponseContent + ");");
    }

    public void a(c mraidWebView) {
        this.d = mraidWebView;
        mraidWebView.setScrollContainer(false);
        this.d.setVerticalScrollBarEnabled(false);
        this.d.setHorizontalScrollBarEnabled(false);
        this.d.setBackgroundColor(0);
        this.d.setWebChromeClient(new WebChromeClient() { // from class: com.sigmob.sdk.mraid2.d.1
            @Override // android.webkit.WebChromeClient
            public boolean onConsoleMessage(ConsoleMessage consoleMessage) {
                return d.this.f == null ? super.onConsoleMessage(consoleMessage) : d.this.f.a(consoleMessage);
            }

            @Override // android.webkit.WebChromeClient
            public boolean onJsAlert(WebView view, String url, String message, JsResult result) {
                return super.onJsAlert(view, url, message, result);
            }

            @Override // android.webkit.WebChromeClient
            public boolean onJsPrompt(WebView view, String url, String message, String defaultValue, JsPromptResult result) {
                return super.onJsPrompt(view, url, message, defaultValue, result);
            }

            @Override // android.webkit.WebChromeClient
            public void onProgressChanged(WebView view, int newProgress) {
                super.onProgressChanged(view, newProgress);
                if (d.this.i || d.this.j || newProgress <= 70) {
                    return;
                }
                d.this.j = true;
                d.this.a(g.INJECTION_JAVASCRIPT, (ValueCallback) null);
            }

            @Override // android.webkit.WebChromeClient
            public void onShowCustomView(final View view, final WebChromeClient.CustomViewCallback callback) {
                super.onShowCustomView(view, callback);
            }
        });
    }

    /* JADX WARN: Code duplicated, block: B:96:0x01a2  */
    public void a(d mraidBridge, String data) {
        try {
            com.sigmob.sdk.base.utils.k.c(f3533a, "handlePostMessage: data = " + data, new Object[0]);
            JSONObject jSONObject = new JSONObject(data);
            String strOptString = jSONObject.optString(NotificationCompat.CATEGORY_EVENT);
            String strOptString2 = jSONObject.optString("subEvent");
            JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("args");
            com.sigmob.sdk.base.utils.k.b(f3533a, "handlePostMessage: event = " + strOptString, new Object[0]);
            switch (strOptString) {
                case "mraidJsLoaded":
                    i();
                    return;
                case "ready":
                    m();
                    return;
                case "visible":
                    f(mraidBridge, data, jSONObjectOptJSONObject);
                    return;
                case "dispatch_after":
                    a(mraidBridge, jSONObjectOptJSONObject);
                    return;
                case "mraidLoadAd":
                    c(mraidBridge, jSONObjectOptJSONObject);
                    return;
                case "feedbackByVid":
                    b(mraidBridge, jSONObjectOptJSONObject);
                    return;
                case "openByVid":
                    a(mraidBridge, data, jSONObjectOptJSONObject, strOptString);
                    return;
                case "open":
                    b(mraidBridge, data, jSONObjectOptJSONObject);
                    return;
                case "close":
                    n();
                    return;
                case "unload":
                    k();
                    return;
                case "reward":
                    l();
                    return;
                case "curPlayAd":
                    d(jSONObjectOptJSONObject);
                    return;
                case "addSubview":
                    d(mraidBridge, data, jSONObjectOptJSONObject);
                    return;
                case "belowSubview":
                    a(mraidBridge, data, jSONObjectOptJSONObject);
                    return;
                case "useScrollView":
                    c(mraidBridge, data, jSONObjectOptJSONObject);
                    return;
                case "useCustomClose":
                    c(jSONObjectOptJSONObject);
                    return;
                case "timer":
                    b(mraidBridge, data, strOptString2, jSONObjectOptJSONObject);
                    return;
                case "vpaid":
                    a(mraidBridge, data, strOptString2, jSONObjectOptJSONObject);
                    return;
                case "webView":
                    c(mraidBridge, data, strOptString2, jSONObjectOptJSONObject);
                    return;
                case "animation":
                    h(jSONObjectOptJSONObject);
                    return;
                case "touchStart":
                    g(jSONObjectOptJSONObject);
                    return;
                case "touchMove":
                    f(jSONObjectOptJSONObject);
                    return;
                case "touchEnd":
                    e(jSONObjectOptJSONObject);
                    return;
                case "motion":
                    g(mraidBridge, data, jSONObject);
                    return;
                case "motionView":
                    e(mraidBridge, data, jSONObject);
                    return;
                case "backgroundColor":
                    i(jSONObjectOptJSONObject);
                    return;
                case "blurEffect":
                    a(mraidBridge, data, strOptString2);
                    return;
                case "subscribe":
                    l(jSONObjectOptJSONObject);
                    break;
                case "unsubscribe":
                    j(jSONObjectOptJSONObject);
                    break;
                case "publish":
                    k(jSONObjectOptJSONObject);
                    break;
                default:
                    return;
            }
            mraidBridge.d(data);
        } catch (Exception e2) {
            com.sigmob.sdk.base.utils.k.f(f3533a, "handlePostMessage: error = " + e2.getMessage(), new Object[0]);
            e2.printStackTrace();
        }
    }

    public void a(f controllerListener) {
        this.f = controllerListener;
    }

    void a(k listener) {
        this.c = listener;
    }

    void a(String javascript) {
        if (!this.i) {
            SigmobLog.w("MRAID JS Not Load attached: " + javascript);
        } else if (this.d == null) {
            SigmobLog.e("Attempted to inject Javascript into MRAID WebView while was not attached: " + javascript);
        } else {
            SigmobLog.d("Injecting Javascript into MRAID WebView: " + javascript);
            this.d.b(javascript, (ValueCallback) null);
        }
    }

    public void a(String uniqueId, int state) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("uniqueId", uniqueId);
            jSONObject2.put("state", state);
            jSONObject.put("vdPlayStateChanged", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    public void a(String uniqueId, int position, int duration) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("uniqueId", uniqueId);
            jSONObject2.put("currentTime", position / 1000.0f);
            jSONObject2.put(MediationConstant.EXTRA_DURATION, duration / 1000.0f);
            jSONObject.put("vdPlayCurrentTime", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void a(String uniqueId, int duration, int width, int height) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("uniqueId", uniqueId);
            jSONObject2.put(MediationConstant.EXTRA_DURATION, duration / 1000.0f);
            jSONObject2.put(MediaFormat.KEY_WIDTH, width);
            jSONObject2.put(MediaFormat.KEY_HEIGHT, height);
            jSONObject.put("vdReadyToPlay", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    public void a(String uniqueId, int code, String message) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(PluginConstants.KEY_ERROR_CODE, code);
            jSONObject2.put("message", message);
            JSONObject jSONObject3 = new JSONObject();
            jSONObject3.put("uniqueId", uniqueId);
            jSONObject3.put("error", jSONObject2);
            jSONObject.put("wvError", jSONObject3);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void a(String javascript, ValueCallback callback) {
        if (this.d == null) {
            SigmobLog.e("Attempted to inject Javascript into MRAID WebView while was not attached: " + javascript);
        } else {
            SigmobLog.d("Injecting Javascript into MRAID WebView: " + javascript);
            this.d.b(javascript, callback);
        }
    }

    void a(String event, BidResponse bidResponse, int code, String message) {
        JSONObject jSONObject;
        JSONObject jSONObject2 = new JSONObject();
        try {
            if (bidResponse == null) {
                jSONObject = new JSONObject();
                jSONObject.put("data", (Object) null);
            } else {
                jSONObject = new JSONObject(JSONSerializer.Serialize(bidResponse, "data", true, true));
            }
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, code);
            jSONObject.put("message", message);
            JSONObject jSONObject3 = new JSONObject();
            jSONObject3.put(NotificationCompat.CATEGORY_EVENT, event);
            jSONObject3.put("message", jSONObject);
            jSONObject2.put("notify", jSONObject3);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject2 + ");");
    }

    public void a(String uniqueId, String error) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("uniqueId", uniqueId);
            jSONObject2.put("error", error);
            jSONObject.put("vdPlayError", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    @Override // com.sigmob.sdk.mraid2.j
    public void a(String uniqueId, String type, String event, HashMap<String, Object> args) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, event);
            jSONObject2.put("uniqueId", uniqueId);
            if (args != null) {
                jSONObject2.put("args", new JSONObject(args));
            }
            jSONObject.put("onChangeFired", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void a(String uniqid, String event, JSONObject data) {
        JSONObject jSONObject = new JSONObject();
        Object objOpt = data.opt("data");
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, uniqid + "~" + event);
            if (objOpt != null) {
                jSONObject2.put("data", objOpt);
            }
            jSONObject.put("onChangeEvent", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    public void a(String event, HashMap<String, Object> args) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, event);
            if (args != null) {
                jSONObject2.put("args", new JSONObject(args));
            }
            jSONObject.put("onChangeEvent", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void a(JSONObject jsonObject) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("bindData", jsonObject);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void a(boolean isViewable) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("viewable", isViewable);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ")");
    }

    public BaseAdUnit b(String vid) {
        if (!com.sigmob.sdk.base.utils.s.a((CharSequence) vid) && !com.sigmob.sdk.base.utils.f.a(this.g)) {
            for (int i = 0; i < this.g.size(); i++) {
                BaseAdUnit baseAdUnit = this.b.get(i);
                if (vid.equals(baseAdUnit.getAd().vid)) {
                    return baseAdUnit;
                }
            }
        }
        return null;
    }

    public void b(String uniqueId, int state) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("uniqueId", uniqueId);
            jSONObject2.put("state", state);
            jSONObject.put("vdLoadStateChanged", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void b(String event, String message) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, event);
            if (com.sigmob.sdk.base.utils.s.b(message)) {
                jSONObject2.put("message", message);
            }
            jSONObject.put("notify", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    public void b(JSONObject jsonObject) {
        a("mraidbridge.onStorageChanged(" + jsonObject.toString() + ");");
    }

    public boolean b() {
        return this.i;
    }

    public List<BaseAdUnit> c() {
        return this.g;
    }

    public void c(String uniqueId) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("uniqueId", uniqueId);
            jSONObject.put("wvFinished", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    public void c(String uniqueId, int position) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("uniqueId", uniqueId);
            jSONObject2.put("currentTime", position / 1000.0f);
            jSONObject.put("vdPlayToEnd", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void d() {
        a("mraidbridge.fireReadyEvent();");
    }

    void d(String cmd) {
        a("mraidbridge.nativeCallComplete(" + JSONObject.quote(cmd) + ")");
    }

    void e() {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("orientation", ClientMetadata.getInstance().getOrientationInt());
            jSONObject2.put(PointCategory.LOCKED, true);
            jSONObject.put("orientation", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void e(String key) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, "fire_" + key);
            jSONObject.put("notify", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    void f() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("sdkVersion", "4.25.14");
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ")");
    }

    /* JADX INFO: Access modifiers changed from: package-private */
    public void f(String key) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, key);
            jSONObject.put("notify", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }

    public void g() {
        if (e != null) {
            e = null;
        }
        if (this.d != null) {
            this.d = null;
        }
        this.c = null;
        this.f = null;
    }

    void g(String key) {
        JSONObject jSONObject = new JSONObject();
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put(NotificationCompat.CATEGORY_EVENT, key);
            jSONObject.put("notify", jSONObject2);
        } catch (JSONException e2) {
            e2.printStackTrace();
        }
        a("mraidbridge.fireChangeEvent(" + jSONObject + ");");
    }
}
