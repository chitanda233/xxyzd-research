package com.sigmob.windad.newInterstitial;

import com.sigmob.windad.WindAdRequest;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class WindNewInterstitialAdRequest extends WindAdRequest {
    private boolean b;
    private boolean c;

    public WindNewInterstitialAdRequest(String placementId, String userId, Map<String, Object> options) {
        super(placementId, userId, options, 6);
    }

    public boolean isEnableKeepOn() {
        return this.c;
    }

    public boolean isEnableScreenLockDisPlayAd() {
        return this.b;
    }

    public void setEnableKeepOn(boolean enableKeepOn) {
        this.c = enableKeepOn;
    }

    public void setEnableScreenLockDisPlayAd(boolean enableScreenLockDisPlayAd) {
        this.b = enableScreenLockDisPlayAd;
    }
}
