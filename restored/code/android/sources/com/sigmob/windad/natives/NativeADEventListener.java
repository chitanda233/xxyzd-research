package com.sigmob.windad.natives;

import com.sigmob.windad.WindAdError;

/* JADX INFO: loaded from: classes4.dex */
public interface NativeADEventListener {
    void onAdClicked();

    void onAdDetailDismiss();

    void onAdDetailShow();

    void onAdError(WindAdError error);

    void onAdExposed();
}
