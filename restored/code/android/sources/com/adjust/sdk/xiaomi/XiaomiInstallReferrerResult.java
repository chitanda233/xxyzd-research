package com.adjust.sdk.xiaomi;

/* JADX INFO: loaded from: classes.dex */
public class XiaomiInstallReferrerResult {
    public String error;
    public XiaomiInstallReferrerDetails xiaomiInstallReferrerDetails;

    XiaomiInstallReferrerResult(XiaomiInstallReferrerDetails xiaomiInstallReferrerDetails) {
        this.xiaomiInstallReferrerDetails = xiaomiInstallReferrerDetails;
    }

    public XiaomiInstallReferrerResult(String str) {
        this.error = str;
    }
}
