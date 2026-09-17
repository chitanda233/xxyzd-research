package com.sigmob.sdk.videoAd;

import com.sigmob.windad.WindAdError;

/* JADX INFO: loaded from: classes4.dex */
public interface m {
    void onAdClicked(String placementId);

    void onAdClosed(String placementId);

    void onAdShow(String placementId);

    void onAdShowError(WindAdError error, String placementId);

    void onVideoAdPlayComplete(String placementId);

    void onVideoAdPlayEnd(String placementId);
}
