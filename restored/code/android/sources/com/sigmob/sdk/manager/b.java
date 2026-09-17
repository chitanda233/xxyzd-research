package com.sigmob.sdk.manager;

import com.czhj.sdk.common.models.AdStatus;
import com.czhj.sdk.logger.SigmobLogger;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.j;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.rtb.AndroidMarket;
import com.sigmob.sdk.base.models.rtb.BiddingResponse;
import com.sigmob.sdk.base.models.rtb.FrequencyControl;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.mta.PointEntitySigmobError;
import com.sigmob.sdk.base.mta.PointEntitySigmobRequest;
import com.sigmob.sdk.base.mta.PointParamKey;
import com.sigmob.sdk.base.n;
import com.sigmob.sdk.base.network.h;
import com.sigmob.sdk.base.o;
import com.sigmob.sdk.base.utils.i;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.sdk.videoAd.m;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAdRequest;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.UUID;
import java.util.concurrent.ConcurrentHashMap;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b {
    private static final ConcurrentHashMap<String, Boolean> h = new ConcurrentHashMap<>();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f3469a = getClass().getSimpleName();
    protected AdStatus b = AdStatus.AdStatusNone;
    protected final int c = 8193;
    protected String d;
    protected String e;
    protected Integer f;
    protected String g;

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(BaseAdUnit baseAdUnit, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            Map<String, String> options = ((PointEntitySigmob) obj).getOptions();
            options.put(PointParamKey.IS_CACHE, "1");
            Map<String, String> mapM = m(baseAdUnit);
            if (com.sigmob.sdk.base.utils.f.b(mapM)) {
                options.putAll(mapM);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(String str, int i, Object obj) {
        if (obj instanceof PointEntitySigmobRequest) {
            PointEntitySigmobRequest pointEntitySigmobRequest = (PointEntitySigmobRequest) obj;
            pointEntitySigmobRequest.setTrace_id(str);
            pointEntitySigmobRequest.setAdx_id(null);
            Map<String, String> options = pointEntitySigmobRequest.getOptions();
            options.putAll(d.a().a(this, Integer.valueOf(i)));
            pointEntitySigmobRequest.setOptions(options);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(String str, BaseAdUnit baseAdUnit, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            if (s.b(str)) {
                pointEntitySigmob.setFinal_url(str);
            }
            if (baseAdUnit == null) {
                return;
            }
            AndroidMarket androidMarket = baseAdUnit.getAndroidMarket();
            if (baseAdUnit.getInteractionType() == 8 || v.b(androidMarket)) {
                pointEntitySigmob.getOptions().put(PointParamKey.FAST_PKG, com.sigmob.sdk.b.a());
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(String str, String str2, int i, Object obj) {
        if (obj instanceof PointEntitySigmobError) {
            PointEntitySigmobError pointEntitySigmobError = (PointEntitySigmobError) obj;
            pointEntitySigmobError.setLoad_id(str);
            pointEntitySigmobError.setPlacement_id(str2);
            pointEntitySigmobError.setAdtype(String.valueOf(i));
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(List list, BaseAdUnit baseAdUnit, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            Map<String, String> options = pointEntitySigmob.getOptions();
            options.put(PointParamKey.AD_COUNT, String.valueOf(list.size()));
            Map<String, String> mapM = m(baseAdUnit);
            if (com.sigmob.sdk.base.utils.f.b(mapM)) {
                options.putAll(mapM);
            }
            pointEntitySigmob.setOptions(options);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(Map map, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            if (map == null) {
                return;
            }
            pointEntitySigmob.getOptions().putAll(map);
        }
    }

    public static boolean a(j requestSceneType) {
        if (requestSceneType == null) {
            return false;
        }
        return a(Integer.valueOf(requestSceneType.a()));
    }

    public static boolean a(Integer requestSceneType) {
        if (requestSceneType == null) {
            return false;
        }
        return requestSceneType.intValue() == j.ReloadAfterExpiration.a() || requestSceneType.intValue() == j.ActiveFailureReload.a();
    }

    public static void b(final BaseAdUnit adUnit, String category, final String url) {
        k(adUnit);
        try {
            Thread.sleep(10L);
        } catch (InterruptedException e) {
            SigmobLogger.e("BaseAdManager", "trackDeeplinkResult: error = " + e.getMessage(), new Object[0]);
        }
        h.a(adUnit, category);
        ad.a(category, (String) null, adUnit, new ad.a() { // from class: com.sigmob.sdk.manager.b$$ExternalSyntheticLambda2
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                b.a(url, adUnit, obj);
            }
        });
    }

    public static boolean b(Integer requestSceneType) {
        if (requestSceneType == null) {
            return false;
        }
        return requestSceneType.intValue() == j.AutoNextPreload.a() || requestSceneType.intValue() == j.SplashCloseRequest.a();
    }

    public static boolean c(Integer requestSceneType) {
        return requestSceneType != null && requestSceneType.intValue() == j.NormalRequest.a();
    }

    public static String j() {
        return UUID.randomUUID().toString();
    }

    public static void k(BaseAdUnit adUnit) {
        int interactionType;
        if (adUnit == null || (interactionType = adUnit.getInteractionType()) == 7 || interactionType == 8 || !adUnit.enableDetectPkg()) {
            return;
        }
        String str = adUnit.canOpen() ? PointCategory.CAN_DP : PointCategory.NO_CAN_DP;
        ad.a(str, (String) null, adUnit, (ad.a) null);
        String requestId = adUnit.getRequestId();
        ConcurrentHashMap<String, Boolean> concurrentHashMap = h;
        if (concurrentHashMap.containsKey(requestId)) {
            return;
        }
        h.a(adUnit, str);
        concurrentHashMap.put(requestId, true);
    }

    public static boolean n(BaseAdUnit adUnit) {
        if (adUnit == null) {
            return false;
        }
        String ad_source_channel = adUnit.getAd_source_channel();
        if (s.a((CharSequence) ad_source_channel)) {
            return false;
        }
        return ad_source_channel.equalsIgnoreCase(n.i);
    }

    public void a(int requestSceneTypeValue) {
        boolean z = !c();
        boolean z2 = z && a(Integer.valueOf(requestSceneTypeValue));
        SigmobLogger.i(this.f3469a, "addToWindAdExpirationManager: allowAdd = " + z2 + ", unready = " + z + ", requestSceneTypeValue = " + requestSceneTypeValue, new Object[0]);
        if (z2) {
            a(this);
        }
    }

    public void a(AdStatus adStatus) {
        this.b = adStatus;
    }

    protected void a(BaseAdUnit adUnit, ad.a extra) {
        ad.a(PointCategory.RESPOND, "1", adUnit, extra);
    }

    public void a(BaseAdUnit adUnit, LoadAdRequest adRequest) {
        if (a(Integer.valueOf(adRequest.getRequest_scene_type()))) {
            this.b = AdStatus.AdStatusReady;
            a(this);
        }
        ad.a(PointCategory.READY, null, adUnit, null, adRequest, null);
    }

    protected void a(BaseAdUnit adUnit, String cate, final int adType, final String placementId, final String loadId, WindAdError adError) {
        ad.a(cate, adError, adUnit, new ad.a() { // from class: com.sigmob.sdk.manager.b$$ExternalSyntheticLambda0
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                b.a(loadId, placementId, adType, obj);
            }
        });
    }

    public void a(BaseAdUnit adUnit, String key, String value) {
        if (adUnit == null || adUnit.bidding_response == null) {
            return;
        }
        adUnit.getMacroCommon().addMarcoKey(key, value);
    }

    protected void a(LoadAdRequest loadAdRequest) {
        loadAdRequest.setRequestId("");
        final String traceId = loadAdRequest.getTraceId();
        final int request_scene_type = loadAdRequest.getRequest_scene_type();
        if (request_scene_type == j.NormalRequest.a()) {
            return;
        }
        ad.a(PointCategory.REQUEST, a(Integer.valueOf(request_scene_type)) ? "init" : PointCategory.PLAY, (WindAdRequest) null, loadAdRequest, new ad.a() { // from class: com.sigmob.sdk.manager.b$$ExternalSyntheticLambda5
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                this.f$0.a(traceId, request_scene_type, obj);
            }
        });
    }

    public void a(b adManager) {
        d.a().a(adManager);
        e.a().a(adManager);
    }

    protected void a(WindAdError error, m listener) {
        if (this.b != AdStatus.AdStatusLoading && this.b != AdStatus.AdStatusClose) {
            g();
            this.b = AdStatus.AdStatusNone;
        }
        if (listener == null || error == null) {
            return;
        }
        listener.onAdShowError(error, h());
    }

    public void a(String currency) {
        this.g = currency;
    }

    protected void a(String event, BaseAdUnit adUnit) {
        e.a().a(event, adUnit, this);
    }

    public void a(String originVid, String originPrice, j requestSceneType) {
        this.d = originVid;
        this.e = originPrice;
        SigmobLogger.i(this.f3469a, "expiredAdReload: originVid = " + originVid + ", originPrice = " + originPrice, new Object[0]);
    }

    public void a(String category, final Map<String, String> option) {
        BaseAdUnit baseAdUnitI = i();
        if (o.a().ae()) {
            ad.a(category, (String) null, baseAdUnitI, new ad.a() { // from class: com.sigmob.sdk.manager.b$$ExternalSyntheticLambda1
                @Override // com.sigmob.sdk.base.common.ad.a
                public final void onAddExtra(Object obj) {
                    b.a(option, obj);
                }
            });
        }
    }

    protected void a(final List<BaseAdUnit> adUnits, LoadAdRequest loadAdRequest, final BaseAdUnit adUnit) {
        ad.a(PointCategory.RESPOND, "1", adUnit, null, loadAdRequest, new ad.a() { // from class: com.sigmob.sdk.manager.b$$ExternalSyntheticLambda3
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                this.f$0.a(adUnits, adUnit, obj);
            }
        });
    }

    public void b(b adManager) {
        d.a().b(adManager);
    }

    public abstract boolean c();

    public void d(Integer bidFloor) {
        this.f = bidFloor;
    }

    public abstract boolean d();

    public abstract BaseAdUnit e();

    public abstract LoadAdRequest f();

    protected boolean f(BaseAdUnit adUnit) {
        return adUnit != null && adUnit.isExpiredAd();
    }

    protected abstract void g();

    protected boolean g(BaseAdUnit adUnit) {
        if (adUnit == null) {
            return false;
        }
        int playMode = adUnit.getPlayMode();
        SigmobLogger.d(this.f3469a, "checkAdUnit: playMode = " + playMode, new Object[0]);
        if (playMode != 0) {
            return true;
        }
        try {
            boolean zIsEndCardIndexExist = adUnit.isEndCardIndexExist();
            SigmobLogger.d(this.f3469a, "checkAdUnit: isEndCardReady = " + zIsEndCardIndexExist, new Object[0]);
            return zIsEndCardIndexExist;
        } catch (Throwable th) {
            SigmobLogger.e(this.f3469a, "checkAdUnit: error = " + th.getMessage(), new Object[0]);
            return false;
        }
    }

    public String h() {
        LoadAdRequest loadAdRequestF = f();
        if (loadAdRequestF == null) {
            return null;
        }
        return loadAdRequestF.getPlacementId();
    }

    protected String h(BaseAdUnit adUnit) {
        if (adUnit != null && adUnit.bidding_response != null && adUnit.bidding_response.ecpm != null) {
            try {
                String strValueOf = String.valueOf(adUnit.bidding_response.ecpm);
                SigmobLogger.d(this.f3469a, "getEcpm: eCPM = " + strValueOf, new Object[0]);
                return strValueOf;
            } catch (Exception e) {
                SigmobLogger.e(this.f3469a, "getEcpm: error = " + e.getMessage(), new Object[0]);
            }
        }
        return null;
    }

    public abstract BaseAdUnit i();

    protected String i(BaseAdUnit adUnit) {
        if (adUnit == null || adUnit.bidding_response == null || adUnit.bidding_response.currency == null) {
            return null;
        }
        String str = adUnit.bidding_response.currency;
        SigmobLogger.d(this.f3469a, "getCurrency: currency = " + str, new Object[0]);
        return str;
    }

    public Map<String, BiddingResponse> j(BaseAdUnit adUnit) {
        if (adUnit == null || adUnit.bidding_response == null) {
            return null;
        }
        HashMap map = new HashMap();
        map.put(adUnit.getRequestId(), adUnit.bidding_response);
        return map;
    }

    public Integer k() {
        return this.f;
    }

    public String l() {
        return this.g;
    }

    protected void l(final BaseAdUnit adUnit) {
        a(adUnit, new ad.a() { // from class: com.sigmob.sdk.manager.b$$ExternalSyntheticLambda4
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                this.f$0.a(adUnit, obj);
            }
        });
    }

    protected Map<String, String> m(BaseAdUnit adUnit) {
        if (adUnit == null) {
            return null;
        }
        List<FrequencyControl> frequencyControl = adUnit.getFrequencyControl();
        if (com.sigmob.sdk.base.utils.f.a(frequencyControl)) {
            return null;
        }
        HashMap map = new HashMap();
        map.put(PointParamKey.FREQUENCY_CONTROL_LIST, i.a(frequencyControl));
        for (FrequencyControl frequencyControl2 : frequencyControl) {
            SigmobLogger.d(this.f3469a, "频控策略 ID = " + frequencyControl2.strategy_id + ", 频控策略类型 = " + frequencyControl2.frequency_control_event, new Object[0]);
        }
        return map;
    }
}
