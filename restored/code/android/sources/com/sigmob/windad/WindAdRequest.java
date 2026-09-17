package com.sigmob.windad;

import android.text.TextUtils;
import com.czhj.sdk.common.Constants;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class WindAdRequest {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected int f3704a = 1;
    private final int b;
    private final String c;
    private String d;
    private Map<String, Object> e;
    private Map<String, Object> f;
    private boolean g;

    protected WindAdRequest(String placementId, String userId, Map<String, Object> options, int adFormat) {
        this.c = placementId;
        this.d = userId;
        this.e = options;
        this.b = adFormat;
    }

    public static boolean isPlacementEmpty(WindAdRequest adRequest) {
        return adRequest == null || TextUtils.isEmpty(adRequest.getPlacementId());
    }

    public int getAdCount() {
        return this.f3704a;
    }

    public int getAdType() {
        return this.b;
    }

    public String getAdxId() {
        Map<String, Object> map = this.f;
        if (map == null) {
            return null;
        }
        Object obj = map.get(WindAds.ADX_ID);
        if (obj instanceof String) {
            return (String) obj;
        }
        return null;
    }

    public String getLoadId() {
        Map<String, Object> map = this.f;
        if (map == null) {
            return null;
        }
        Object obj = map.get(Constants.LOAD_ID);
        if (obj instanceof String) {
            return (String) obj;
        }
        return null;
    }

    public Map<String, Object> getOptions() {
        return this.e;
    }

    public String getPlacementId() {
        return this.c;
    }

    public Map<?, ?> getTBAdxInfo() {
        Object obj;
        Map<String, Object> map = this.f;
        if (map == null || (obj = map.get(WindAds.SAAS_OPTIONS)) == null || !(obj instanceof Map)) {
            return null;
        }
        return (Map) obj;
    }

    public String getUserId() {
        return this.d;
    }

    public boolean hasOptions() {
        return this.e != null;
    }

    public boolean isHalfInterstitial() {
        return this.g;
    }

    public void setAdCount(int adCount) {
        this.f3704a = adCount;
    }

    public void setExtOptions(Map<String, Object> extOptions) {
        this.f = extOptions;
    }

    public void setHalfInterstitial(boolean halfInterstitial) {
        this.g = halfInterstitial;
    }

    public void setOptions(Map<String, Object> options) {
        this.e = options;
    }

    public void setUserId(String userId) {
        this.d = userId;
    }
}
