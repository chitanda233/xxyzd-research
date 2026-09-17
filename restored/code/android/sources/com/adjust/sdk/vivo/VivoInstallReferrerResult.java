package com.adjust.sdk.vivo;

/* JADX INFO: loaded from: classes.dex */
public class VivoInstallReferrerResult {
    public String error;
    public VivoInstallReferrerDetails vivoInstallReferrerDetails;

    public VivoInstallReferrerResult(VivoInstallReferrerDetails vivoInstallReferrerDetails) {
        this.vivoInstallReferrerDetails = vivoInstallReferrerDetails;
    }

    public VivoInstallReferrerResult(String str) {
        this.error = str;
    }
}
