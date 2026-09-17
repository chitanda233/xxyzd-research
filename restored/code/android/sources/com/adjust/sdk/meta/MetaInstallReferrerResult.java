package com.adjust.sdk.meta;

/* JADX INFO: loaded from: classes.dex */
public class MetaInstallReferrerResult {
    public String error;
    public MetaInstallReferrerDetails metaInstallReferrerDetails;

    MetaInstallReferrerResult(MetaInstallReferrerDetails metaInstallReferrerDetails) {
        this.metaInstallReferrerDetails = metaInstallReferrerDetails;
    }

    public MetaInstallReferrerResult(String str) {
        this.error = str;
    }
}
