package com.bytedance.android;

import android.app.Activity;
import com.bytedance.sdk.openadsdk.TTAdConstant;
import com.bytedance.sdk.openadsdk.TTAdInteractionListener;
import com.bytedance.sdk.openadsdk.TTAppDownloadListener;
import com.bytedance.sdk.openadsdk.TTRewardVideoAd;
import com.bytedance.sdk.openadsdk.mediation.manager.MediationRewardManager;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
public class RewardVideoAdWrapper implements TTRewardVideoAd {
    private TTRewardVideoAd realAdObject;

    public RewardVideoAdWrapper(TTRewardVideoAd tTRewardVideoAd) {
        this.realAdObject = tTRewardVideoAd;
    }

    @Override // com.bytedance.sdk.openadsdk.TTRewardVideoAd
    public void setRewardAdInteractionListener(TTRewardVideoAd.RewardAdInteractionListener rewardAdInteractionListener) {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd != null) {
            tTRewardVideoAd.setRewardAdInteractionListener(rewardAdInteractionListener);
        }
    }

    @Override // com.bytedance.sdk.openadsdk.TTRewardVideoAd
    public void setDownloadListener(TTAppDownloadListener tTAppDownloadListener) {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd != null) {
            tTRewardVideoAd.setDownloadListener(tTAppDownloadListener);
        }
    }

    @Override // com.bytedance.sdk.openadsdk.TTRewardVideoAd
    public int getInteractionType() {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd != null) {
            return tTRewardVideoAd.getInteractionType();
        }
        return 0;
    }

    @Override // com.bytedance.sdk.openadsdk.TTRewardVideoAd
    public void showRewardVideoAd(Activity activity) {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd != null) {
            tTRewardVideoAd.showRewardVideoAd(activity);
        }
    }

    @Override // com.bytedance.sdk.openadsdk.TTRewardVideoAd
    public Map<String, Object> getMediaExtraInfo() {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd != null) {
            return tTRewardVideoAd.getMediaExtraInfo();
        }
        return new HashMap();
    }

    @Override // com.bytedance.sdk.openadsdk.TTRewardVideoAd
    public void showRewardVideoAd(Activity activity, TTAdConstant.RitScenes ritScenes, String str) {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd != null) {
            tTRewardVideoAd.showRewardVideoAd(activity, ritScenes, str);
        }
    }

    @Override // com.bytedance.sdk.openadsdk.TTRewardVideoAd
    public int getRewardVideoAdType() {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd == null) {
            return 0;
        }
        tTRewardVideoAd.getRewardVideoAdType();
        return 0;
    }

    @Override // com.bytedance.sdk.openadsdk.TTRewardVideoAd
    public long getExpirationTimestamp() {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd == null) {
            return 0L;
        }
        tTRewardVideoAd.getExpirationTimestamp();
        return 0L;
    }

    @Override // com.bytedance.sdk.openadsdk.TTClientBidding
    public void win(Double d) {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd != null) {
            tTRewardVideoAd.win(d);
        }
    }

    @Override // com.bytedance.sdk.openadsdk.TTClientBidding
    public void loss(Double d, String str, String str2) {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd != null) {
            tTRewardVideoAd.loss(d, str, str2);
        }
    }

    @Override // com.bytedance.sdk.openadsdk.TTClientBidding
    public void setPrice(Double d) {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd != null) {
            tTRewardVideoAd.setPrice(d);
        }
    }

    @Override // com.bytedance.sdk.openadsdk.TTClientBidding
    public void setAdInteractionListener(TTAdInteractionListener tTAdInteractionListener) {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd == null || tTAdInteractionListener == null) {
            return;
        }
        tTRewardVideoAd.setAdInteractionListener(tTAdInteractionListener);
    }

    @Override // com.bytedance.sdk.openadsdk.TTRewardVideoAd
    public MediationRewardManager getMediationManager() {
        TTRewardVideoAd tTRewardVideoAd = this.realAdObject;
        if (tTRewardVideoAd != null) {
            return tTRewardVideoAd.getMediationManager();
        }
        return null;
    }
}
