package com.sigmob.windad.rewardVideo;

import com.sigmob.windad.WindAdRequest;
import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public class WindRewardAdRequest extends WindAdRequest {
    private boolean b;
    private boolean c;

    public WindRewardAdRequest(String placementId, String userId, Map<String, Object> options) {
        super(placementId, userId, options, 1);
    }

    public static WindRewardAdRequest getWindVideoAdRequest(WindAdRequest adRequest) {
        if (adRequest == null) {
            return null;
        }
        return new WindRewardAdRequest(adRequest.getPlacementId(), adRequest.getUserId(), adRequest.getOptions());
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
