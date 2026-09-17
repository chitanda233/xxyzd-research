package com.kwad.components.ad.reward.e;

import com.kwad.components.ad.reward.monitor.RewardInteractionCallbackType;
import com.kwad.components.ad.reward.monitor.RewardMonitorInfo;
import com.kwad.sdk.api.KsRewardVideoAd;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public class i extends c {
    private static String vl = "IS_FRAUD";
    private static String vm = "IS_FRAUD_ERROR_CODE";
    private AdTemplate mAdTemplate;
    private com.kwad.components.ad.reward.g ub;
    private String vj;
    private Map<String, Object> vk = new HashMap();

    public final void setCallerContext(com.kwad.components.ad.reward.g gVar) {
        this.ub = gVar;
    }

    public final void Q(String str) {
        this.vj = str;
    }

    public final void setAdTemplate(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
    }

    @Override // com.kwad.components.ad.reward.e.c, com.kwad.components.ad.reward.e.b
    public void cY() {
        super.cY();
        KsRewardVideoAd.RewardAdInteractionListener rewardAdInteractionListenerIm = im();
        if (rewardAdInteractionListenerIm != null) {
            rewardAdInteractionListenerIm.onAdClicked();
        }
        com.kwad.components.ad.reward.monitor.d.a(true, (com.kwad.components.ad.reward.monitor.a) RewardInteractionCallbackType.AD_CLICK, this.mAdTemplate, (com.kwad.sdk.g.a<RewardMonitorInfo>) null);
    }

    @Override // com.kwad.components.ad.reward.e.c, com.kwad.components.ad.reward.e.b
    public final void onVideoPlayStart() {
        super.onVideoPlayStart();
        KsRewardVideoAd.RewardAdInteractionListener rewardAdInteractionListenerIm = im();
        if (rewardAdInteractionListenerIm != null) {
            rewardAdInteractionListenerIm.onVideoPlayStart();
        }
        com.kwad.components.ad.reward.monitor.d.a(true, (com.kwad.components.ad.reward.monitor.a) RewardInteractionCallbackType.VIDEO_PLAY_START, this.mAdTemplate, (com.kwad.sdk.g.a<RewardMonitorInfo>) null);
    }

    @Override // com.kwad.components.ad.reward.e.c, com.kwad.components.ad.reward.e.b
    public final void onVideoPlayError(int i, int i2) {
        super.onVideoPlayError(i, i2);
        KsRewardVideoAd.RewardAdInteractionListener rewardAdInteractionListenerIm = im();
        if (rewardAdInteractionListenerIm != null) {
            rewardAdInteractionListenerIm.onVideoPlayError(i, i2);
        }
        com.kwad.components.ad.reward.monitor.d.a(true, (com.kwad.components.ad.reward.monitor.a) RewardInteractionCallbackType.VIDEO_PLAY_ERROR, this.mAdTemplate, (com.kwad.sdk.g.a<RewardMonitorInfo>) null);
    }

    @Override // com.kwad.components.ad.reward.e.c, com.kwad.components.ad.reward.e.b
    public final void onVideoPlayEnd() {
        super.onVideoPlayEnd();
        KsRewardVideoAd.RewardAdInteractionListener rewardAdInteractionListenerIm = im();
        if (rewardAdInteractionListenerIm != null) {
            rewardAdInteractionListenerIm.onVideoPlayEnd();
        }
        com.kwad.components.ad.reward.monitor.d.a(true, (com.kwad.components.ad.reward.monitor.a) RewardInteractionCallbackType.VIDEO_PLAY_END, this.mAdTemplate, (com.kwad.sdk.g.a<RewardMonitorInfo>) null);
    }

    @Override // com.kwad.components.ad.reward.e.c, com.kwad.components.ad.reward.e.b
    public final void onVideoSkipToEnd(long j) {
        super.onVideoSkipToEnd(j);
        try {
            KsRewardVideoAd.RewardAdInteractionListener rewardAdInteractionListenerIm = im();
            if (rewardAdInteractionListenerIm != null) {
                rewardAdInteractionListenerIm.onVideoSkipToEnd(j);
            }
            com.kwad.components.ad.reward.monitor.d.a(true, (com.kwad.components.ad.reward.monitor.a) RewardInteractionCallbackType.VIDEO_SKIP_TO_END, this.mAdTemplate, (com.kwad.sdk.g.a<RewardMonitorInfo>) null);
        } catch (Throwable unused) {
        }
    }

    @Override // com.kwad.components.ad.reward.e.c, com.kwad.components.ad.reward.e.b
    public void onRewardVerify() {
        super.onRewardVerify();
    }

    @Override // com.kwad.components.ad.reward.e.c, com.kwad.components.ad.reward.e.b
    public void i(boolean z) {
        super.i(z);
        KsRewardVideoAd.RewardAdInteractionListener rewardAdInteractionListenerIm = im();
        if (rewardAdInteractionListenerIm != null) {
            rewardAdInteractionListenerIm.onPageDismiss();
        }
        com.kwad.components.ad.reward.monitor.d.a(true, (com.kwad.components.ad.reward.monitor.a) RewardInteractionCallbackType.PAGE_DISMISS, this.mAdTemplate, (com.kwad.sdk.g.a<RewardMonitorInfo>) null);
    }

    public final boolean il() {
        KsRewardVideoAd.RewardAdInteractionListener rewardAdInteractionListenerIm = im();
        if (rewardAdInteractionListenerIm != null) {
            if (com.kwad.sdk.core.response.helper.a.m178do(com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate))) {
                this.vk.put(vl, Boolean.valueOf(this.ub.sO == 3));
                this.vk.put(vm, Integer.valueOf(this.ub.sP));
                com.kwad.components.ad.reward.monitor.d.d(this.ub.mAdTemplate, this.ub.sO, this.ub.sP);
            }
            try {
                rewardAdInteractionListenerIm.onRewardVerify(this.vk);
            } catch (Throwable unused) {
            }
            rewardAdInteractionListenerIm.onRewardVerify();
        }
        com.kwad.components.ad.reward.monitor.d.a(true, (com.kwad.components.ad.reward.monitor.a) RewardInteractionCallbackType.REWARD_VERIFY, this.mAdTemplate, (com.kwad.sdk.g.a<RewardMonitorInfo>) null);
        return rewardAdInteractionListenerIm != null;
    }

    public final boolean i(final int i, final int i2) {
        KsRewardVideoAd.RewardAdInteractionListener rewardAdInteractionListenerIm = im();
        if (rewardAdInteractionListenerIm != null) {
            rewardAdInteractionListenerIm.onRewardStepVerify(i, i2);
        }
        com.kwad.components.ad.reward.monitor.d.a(true, (com.kwad.components.ad.reward.monitor.a) RewardInteractionCallbackType.REWARD_STEP_VERIFY, this.mAdTemplate, new com.kwad.sdk.g.a<RewardMonitorInfo>() { // from class: com.kwad.components.ad.reward.e.i.1
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.g.a
            /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
            public void accept(RewardMonitorInfo rewardMonitorInfo) {
                rewardMonitorInfo.setTaskType(i).setTaskStep(i2);
            }
        });
        return rewardAdInteractionListenerIm != null;
    }

    private KsRewardVideoAd.RewardAdInteractionListener im() {
        return f.M(getUniqueId());
    }

    private String getUniqueId() {
        return this.vj;
    }
}
