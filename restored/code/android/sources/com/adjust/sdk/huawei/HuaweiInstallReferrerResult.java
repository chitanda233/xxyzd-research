package com.adjust.sdk.huawei;

/* JADX INFO: loaded from: classes.dex */
public class HuaweiInstallReferrerResult {
    public String error;
    public HuaweiInstallReferrerDetails huaweiInstallReferrerDetails;

    HuaweiInstallReferrerResult(HuaweiInstallReferrerDetails huaweiInstallReferrerDetails) {
        this.huaweiInstallReferrerDetails = huaweiInstallReferrerDetails;
    }

    public HuaweiInstallReferrerResult(String str) {
        this.error = str;
    }
}
