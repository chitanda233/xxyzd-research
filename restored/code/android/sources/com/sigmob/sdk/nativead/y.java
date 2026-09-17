package com.sigmob.sdk.nativead;

import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.LoadAdRequest;
import com.sigmob.sdk.base.models.rtb.BiddingResponse;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.sdk.base.mta.PointParamKey;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.natives.WindNativeAdData;
import com.sigmob.windad.natives.WindNativeAdRequest;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class y implements com.sigmob.sdk.base.network.f.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final int f3593a = 1;
    public static final int b = 2;
    public static final int c = 3;
    public static final int d = 0;
    public static final int e = 1;
    public static final int f = 2;
    private List<BaseAdUnit> h;
    private aa i;
    private final WindNativeAdRequest j;
    private boolean k;
    private final Handler g = new Handler(Looper.getMainLooper()) { // from class: com.sigmob.sdk.nativead.y.1
        @Override // android.os.Handler
        public void handleMessage(Message msg) {
            if (msg.what == 20481 && y.this.k) {
                y.this.g.removeMessages(20481);
                y.this.a((List<WindNativeAdData>) null, WindAdError.ERROR_SIGMOB_AD_TIME_OUT.getErrorCode(), WindAdError.ERROR_SIGMOB_AD_TIME_OUT.getMessage());
            }
        }
    };
    private final int l = 20481;

    public y(WindNativeAdRequest adRequest, aa sigmobNativeAdLoadListener) {
        this.j = adRequest;
        this.i = sigmobNativeAdLoadListener;
    }

    private WindNativeAdData a(BaseAdUnit adUnit) {
        return new ag(adUnit);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(int i, List list, String str) {
        aa aaVar = this.i;
        if (aaVar == null) {
            return;
        }
        if (i == 0) {
            aaVar.onNativeAdLoaded(list);
        } else {
            aaVar.onNativeAdLoadFail(i, str);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(final List<WindNativeAdData> adUnits, final int error, final String message) {
        this.k = false;
        this.g.removeMessages(20481);
        this.g.post(new Runnable() { // from class: com.sigmob.sdk.nativead.y$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a(error, adUnits, message);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(List list, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            Map<String, String> options = pointEntitySigmob.getOptions();
            options.put(PointParamKey.AD_COUNT, String.valueOf(list.size()));
            pointEntitySigmob.setOptions(options);
        }
    }

    public int a(int adCount, String bidToken, int bidFloor, String currency, String traceId) {
        int errorCode;
        WindAdError windAdError;
        int i = 1;
        this.k = true;
        String placementId = this.j.getPlacementId();
        com.sigmob.sdk.base.common.z zVarA = com.sigmob.sdk.base.common.z.a(placementId);
        LoadAdRequest loadAdRequest = new LoadAdRequest(this.j);
        loadAdRequest.setBidToken(bidToken);
        loadAdRequest.setBidFloor(Integer.valueOf(bidFloor));
        loadAdRequest.setCurrency(currency);
        loadAdRequest.setAd_count(adCount);
        loadAdRequest.setTraceId(traceId);
        zVarA.f3206a++;
        com.sigmob.sdk.base.common.aa aaVarA = com.sigmob.sdk.base.common.aa.a(placementId);
        aaVarA.f3138a++;
        if (adCount >= 1) {
            if (zVarA.g <= 0 || zVarA.g + (((long) zVarA.d) * 1000) <= System.currentTimeMillis()) {
                this.g.sendEmptyMessageDelayed(20481, com.sigmob.sdk.base.o.a().A());
                zVarA.g = System.currentTimeMillis();
                com.sigmob.sdk.base.network.f.a(loadAdRequest, this);
            } else {
                List<BaseAdUnit> listA = com.sigmob.sdk.base.common.h.a(placementId, zVarA.f, adCount);
                if (listA.isEmpty()) {
                    errorCode = WindAdError.ERROR_NO_AD.getErrorCode();
                    windAdError = WindAdError.ERROR_NO_AD;
                } else {
                    this.h = listA;
                    ArrayList arrayList = new ArrayList();
                    for (int i2 = 0; i2 < listA.size(); i2++) {
                        BaseAdUnit baseAdUnit = listA.get(i2);
                        baseAdUnit.setLoad_id(loadAdRequest.getLoadId());
                        arrayList.add(a(baseAdUnit));
                        if (com.sigmob.sdk.manager.b.n(baseAdUnit)) {
                            com.sigmob.sdk.base.common.h.g().f(baseAdUnit);
                        }
                    }
                    a(this.h.get(0), loadAdRequest);
                    zVarA.b += listA.size();
                    aaVarA.b += listA.size();
                    a(arrayList, 0, (String) null);
                }
                i = 0;
            }
            com.sigmob.sdk.base.common.z.a(placementId, zVarA);
            com.sigmob.sdk.base.common.aa.a(placementId, aaVarA);
            return i;
        }
        errorCode = WindAdError.ERROR_SIGMOB_NATIVE_ADCOUNT.getErrorCode();
        windAdError = WindAdError.ERROR_SIGMOB_NATIVE_ADCOUNT;
        a((List<WindNativeAdData>) null, errorCode, windAdError.getMessage());
        i = 0;
        com.sigmob.sdk.base.common.z.a(placementId, zVarA);
        com.sigmob.sdk.base.common.aa.a(placementId, aaVarA);
        return i;
    }

    public String a() {
        BaseAdUnit baseAdUnit;
        List<BaseAdUnit> list = this.h;
        if (list == null || list.isEmpty() || (baseAdUnit = this.h.get(0)) == null || baseAdUnit.bidding_response == null) {
            return null;
        }
        return String.valueOf(baseAdUnit.bidding_response.ecpm);
    }

    @Override // com.sigmob.sdk.base.network.f.a
    public void a(int error, String message, String request_id, LoadAdRequest loadAdRequest) {
        com.sigmob.sdk.base.common.ad.a(PointCategory.RESPOND, "0", loadAdRequest);
        a((List<WindNativeAdData>) null, error, message);
    }

    public void a(BaseAdUnit adUnit, LoadAdRequest loadAdRequest) {
        com.sigmob.sdk.base.common.ad.a(PointCategory.READY, null, adUnit, null, loadAdRequest, null);
    }

    public void a(String key, String value) {
        BaseAdUnit baseAdUnit;
        List<BaseAdUnit> list = this.h;
        if (list == null || (baseAdUnit = list.get(0)) == null || baseAdUnit.bidding_response == null) {
            return;
        }
        baseAdUnit.getMacroCommon().addMarcoKey(key, value);
    }

    @Override // com.sigmob.sdk.base.network.f.a
    public void a(final List<BaseAdUnit> baseAdUnitList, LoadAdRequest loadAdRequest) {
        if (com.sigmob.sdk.base.utils.f.a(baseAdUnitList)) {
            a((List<WindNativeAdData>) null, WindAdError.ERROR_NO_AD.getErrorCode(), WindAdError.ERROR_NO_AD.getMessage());
            return;
        }
        com.sigmob.sdk.base.common.ad.a(PointCategory.RESPOND, "1", baseAdUnitList.get(0), null, loadAdRequest, new com.sigmob.sdk.base.common.ad.a() { // from class: com.sigmob.sdk.nativead.y$$ExternalSyntheticLambda1
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                y.a(baseAdUnitList, obj);
            }
        });
        com.sigmob.sdk.base.common.z zVarA = com.sigmob.sdk.base.common.z.a(this.j.getPlacementId());
        if (zVarA != null && zVarA.e > 0) {
            baseAdUnitList = com.sigmob.sdk.base.common.h.a(this.j.getPlacementId(), zVarA.f, this.j.getAdCount());
            if (com.sigmob.sdk.base.utils.f.a(baseAdUnitList)) {
                this.h = null;
                a((List<WindNativeAdData>) null, WindAdError.ERROR_NO_AD.getErrorCode(), WindAdError.ERROR_NO_AD.getMessage());
                return;
            }
        }
        this.h = baseAdUnitList;
        com.sigmob.sdk.base.common.aa aaVarA = com.sigmob.sdk.base.common.aa.a(this.j.getPlacementId());
        zVarA.b += this.h.size();
        aaVarA.b += this.h.size();
        com.sigmob.sdk.base.common.z.a(this.j.getPlacementId(), zVarA);
        com.sigmob.sdk.base.common.aa.a(this.j.getPlacementId(), aaVarA);
        ArrayList arrayList = new ArrayList();
        for (int i = 0; i < this.h.size(); i++) {
            BaseAdUnit baseAdUnit = this.h.get(i);
            arrayList.add(a(baseAdUnit));
            if (com.sigmob.sdk.manager.b.n(baseAdUnit)) {
                com.sigmob.sdk.base.common.h.g().f(baseAdUnit);
            }
        }
        a(this.h.get(0), loadAdRequest);
        a(arrayList, 0, (String) null);
    }

    public String b() {
        BaseAdUnit baseAdUnit;
        List<BaseAdUnit> list = this.h;
        if (list == null || list.isEmpty() || (baseAdUnit = this.h.get(0)) == null || baseAdUnit.bidding_response == null) {
            return null;
        }
        return baseAdUnit.bidding_response.currency;
    }

    public Map<String, BiddingResponse> c() {
        BaseAdUnit baseAdUnit;
        List<BaseAdUnit> list = this.h;
        if (list == null || (baseAdUnit = list.get(0)) == null || baseAdUnit.bidding_response == null) {
            return null;
        }
        HashMap map = new HashMap();
        map.put(baseAdUnit.getRequestId(), baseAdUnit.bidding_response);
        return map;
    }
}
