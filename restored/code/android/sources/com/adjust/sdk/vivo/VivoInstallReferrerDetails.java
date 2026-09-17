package com.adjust.sdk.vivo;

import com.adjust.sdk.ReferrerDetails;

/* JADX INFO: loaded from: classes.dex */
public class VivoInstallReferrerDetails {
    public long installBeginTimestampSeconds;
    public String installReferrer;
    public String installVersion;
    public long referrerClickTimestampSeconds;

    public VivoInstallReferrerDetails(String str, long j, long j2, String str2) {
        this.installReferrer = str;
        this.referrerClickTimestampSeconds = j;
        this.installBeginTimestampSeconds = j2;
        this.installVersion = str2;
    }

    VivoInstallReferrerDetails(ReferrerDetails referrerDetails) {
        if (referrerDetails == null) {
            return;
        }
        this.installReferrer = referrerDetails.installReferrer;
        this.referrerClickTimestampSeconds = referrerDetails.referrerClickTimestampSeconds;
        this.installBeginTimestampSeconds = referrerDetails.installBeginTimestampSeconds;
        this.installVersion = referrerDetails.installVersion;
    }

    public String toString() {
        return com.adjust.sdk.Util.formatString(" installReferrer : %s referrerClickTimestampSeconds : %d installBeginTimestampSeconds : %d installVersion : %s", new Object[]{this.installReferrer, Long.valueOf(this.referrerClickTimestampSeconds), Long.valueOf(this.installBeginTimestampSeconds), this.installVersion});
    }
}
