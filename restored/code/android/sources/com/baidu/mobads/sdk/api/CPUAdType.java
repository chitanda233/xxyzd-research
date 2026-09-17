package com.baidu.mobads.sdk.api;

import com.bytedance.sdk.openadsdk.mediation.MediationConstant;

/* JADX INFO: loaded from: classes.dex */
public enum CPUAdType {
    FEED("feed"),
    INTERSTITIAL(IAdInterListener.AdProdType.PRODUCT_INTERSTITIAL),
    REWARDVIDEO(IAdInterListener.AdProdType.PRODUCT_REWARDVIDEO),
    OTHER(MediationConstant.KEY_USE_POLICY_OBJ_CUSTOM);

    private final String value;

    CPUAdType(String str) {
        this.value = str;
    }

    public String getValue() {
        return this.value;
    }

    public static CPUAdType parse(String str) {
        for (CPUAdType cPUAdType : values()) {
            if (cPUAdType.value.equalsIgnoreCase(str)) {
                return cPUAdType;
            }
        }
        return null;
    }
}
