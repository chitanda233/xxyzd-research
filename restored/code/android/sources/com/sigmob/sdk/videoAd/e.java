package com.sigmob.sdk.videoAd;

import com.czhj.sdk.common.track.AdTracker;
import com.czhj.sdk.common.track.TrackManager;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.sdk.logger.SigmobLogger;
import com.czhj.volley.NetworkResponse;
import com.czhj.volley.VolleyError;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.windad.WindAdError;
import com.sigmob.windad.WindAds;
import com.sigmob.windad.rewardVideo.WindRewardInfo;
import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public class e extends com.sigmob.sdk.manager.f implements h {
    private static final int s = 0;
    private static final int t = 1;
    private static final int u = 2;
    private int v;
    private l w;
    private final boolean x;

    public e(boolean isHalfInterstitial) {
        this.x = isHalfInterstitial;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int status, String serverArrived, String rewardType) {
        this.v = status;
        if (this.w == null) {
            return;
        }
        HashMap map = new HashMap();
        map.put(WindAds.TRANS_ID, this.j);
        map.put(WindAds.SERVER_ARRIVED, serverArrived);
        map.put("reward_type", rewardType);
        this.w.onVideoAdRewarded(new WindRewardInfo(true, map), this.i);
    }

    private void t(BaseAdUnit baseAdUnit) {
        if (v.b(baseAdUnit)) {
            String rvCallBackUrl = baseAdUnit.getRvCallBackUrl();
            if (s.b(rvCallBackUrl)) {
                AdTracker adTracker = new AdTracker(AdTracker.MessageType.TRACKING_URL, rvCallBackUrl, "reward_server", baseAdUnit.getRequestId());
                adTracker.setRetryNum(Integer.valueOf(baseAdUnit.getTrackingRetryNum()));
                com.sigmob.sdk.base.network.h.a(adTracker, baseAdUnit, false, true, true, new TrackManager.Listener() { // from class: com.sigmob.sdk.videoAd.e.1
                    @Override // com.czhj.sdk.common.track.TrackManager.Listener
                    public void onErrorResponse(AdTracker tracker, VolleyError error) {
                        if (e.this.v == 1) {
                            e.this.a(2, "0", "1");
                        }
                    }

                    @Override // com.czhj.sdk.common.track.TrackManager.Listener
                    public void onSuccess(AdTracker tracker, NetworkResponse response) {
                        if (e.this.v == 1) {
                            e.this.a(2, "1", "1");
                        }
                    }
                });
                return;
            }
        }
        a(2, "0", "0");
    }

    public void a(l windAdRewardListener) {
        this.w = windAdRewardListener;
    }

    @Override // com.sigmob.sdk.videoAd.h
    public void c(BaseAdUnit adUnit, String message) {
        if (n(adUnit)) {
            com.sigmob.sdk.base.common.h.g().e(adUnit);
        }
        WindAdError windAdError = WindAdError.ERROR_SIGMOB_AD_PLAY;
        windAdError.setMessage(message);
        a(windAdError, this.r);
        a(adUnit, PointCategory.PLAY, this.m.getAdType(), this.i, this.m.getLoadId(), windAdError);
        SigmobLog.d("onVideoPlayFail() called");
    }

    @Override // com.sigmob.sdk.manager.b
    protected void g() {
        if (com.sigmob.sdk.base.utils.f.b(this.o)) {
            for (BaseAdUnit baseAdUnit : this.o) {
                if (baseAdUnit != null) {
                    if (n(baseAdUnit)) {
                        com.sigmob.sdk.base.common.h.g().e(baseAdUnit);
                    }
                    com.sigmob.sdk.base.common.h.b(baseAdUnit);
                }
            }
        }
        this.o = null;
    }

    @Override // com.sigmob.sdk.manager.f
    public com.sigmob.sdk.mraid.i o() {
        return new g(this, this.x);
    }

    @Override // com.sigmob.sdk.videoAd.h
    public void p(BaseAdUnit adUnit) {
        SigmobLogger.d(this.f3469a, "onVideoComplete", new Object[0]);
        this.v = 1;
        if (v.b(this.r)) {
            this.r.onVideoAdPlayComplete(this.i);
        }
        t(adUnit);
    }

    @Override // com.sigmob.sdk.manager.f
    protected void q() {
        this.v = 0;
    }

    @Override // com.sigmob.sdk.videoAd.h
    public void q(BaseAdUnit adUnit) {
        SigmobLog.d("onVideoPlay() called");
    }

    @Override // com.sigmob.sdk.manager.f
    protected void r() {
        if (this.v == 1) {
            a(0, "0", "1");
        }
    }

    @Override // com.sigmob.sdk.videoAd.h
    public void r(BaseAdUnit adUnit) {
        SigmobLog.d("onVideoSkip() called");
    }

    @Override // com.sigmob.sdk.manager.f
    public void s() {
        super.s();
        this.w = null;
    }

    @Override // com.sigmob.sdk.videoAd.h
    public void s(BaseAdUnit adUnit) {
        o(adUnit);
    }
}
