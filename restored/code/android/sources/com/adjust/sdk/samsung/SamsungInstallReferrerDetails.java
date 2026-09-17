package com.adjust.sdk.samsung;

/* JADX INFO: loaded from: classes.dex */
public class SamsungInstallReferrerDetails {
    public long installBeginTimestampSeconds;
    public String installReferrer;
    public long referrerClickTimestampSeconds;

    SamsungInstallReferrerDetails(String str, long j, long j2) {
        this.installReferrer = str;
        this.referrerClickTimestampSeconds = j;
        this.installBeginTimestampSeconds = j2;
    }

    public String toString() {
        return com.adjust.sdk.Util.formatString(" installReferrer : %s referrerClickTimestampSeconds : %d installBeginTimestampSeconds : %d", new Object[]{this.installReferrer, Long.valueOf(this.referrerClickTimestampSeconds), Long.valueOf(this.installBeginTimestampSeconds)});
    }
}
