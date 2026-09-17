package com.sigmob.sdk.videoAd;

import com.sigmob.windad.WindAdError;

/* JADX INFO: loaded from: classes4.dex */
public interface k {
    void onAdLoadError(WindAdError error, String placementId);

    void onAdLoadSuccess(String placementId);

    void onAdPreLoadFail(WindAdError error, String placementId);

    void onAdPreLoadSuccess(String placementId);
}
