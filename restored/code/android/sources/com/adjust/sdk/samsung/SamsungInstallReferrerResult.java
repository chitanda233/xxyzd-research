package com.adjust.sdk.samsung;

/* JADX INFO: loaded from: classes.dex */
public class SamsungInstallReferrerResult {
    public String error;
    public SamsungInstallReferrerDetails samsungInstallReferrerDetails;

    SamsungInstallReferrerResult(SamsungInstallReferrerDetails samsungInstallReferrerDetails) {
        this.samsungInstallReferrerDetails = samsungInstallReferrerDetails;
    }

    public SamsungInstallReferrerResult(String str) {
        this.error = str;
    }
}
