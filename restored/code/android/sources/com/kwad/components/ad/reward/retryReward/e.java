package com.kwad.components.ad.reward.retryReward;

import com.kwad.sdk.api.KsRewardVideoAd;
import com.kwad.sdk.api.model.KSAdInfoData;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bz;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private Object Bz;

    static class a {
        private static final e BA = new e(0);
    }

    /* synthetic */ e(byte b) {
        this();
    }

    private e() {
    }

    public static e kG() {
        return a.BA;
    }

    public final void e(Object obj) {
        try {
            if (kH() && (obj instanceof KsRewardVideoAd.KSAdRewardRetryTaskListener)) {
                this.Bz = obj;
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public final void onAdRewardRetryTaskNotify(KSAdInfoData kSAdInfoData) {
        try {
            if (kH()) {
                Object obj = this.Bz;
                if (obj instanceof KsRewardVideoAd.KSAdRewardRetryTaskListener) {
                    ((KsRewardVideoAd.KSAdRewardRetryTaskListener) obj).onAdRewardRetryTaskNotify(kSAdInfoData);
                }
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    public static boolean kH() {
        return bz.aD(((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getApiVersion(), "4.9.20.1");
    }
}
