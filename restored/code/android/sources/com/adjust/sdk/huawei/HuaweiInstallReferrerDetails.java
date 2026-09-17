package com.adjust.sdk.huawei;

/* JADX INFO: loaded from: classes.dex */
public class HuaweiInstallReferrerDetails {
    public long installBeginTimestampSeconds;
    public String installReferrer;
    public long referrerClickTimestampSeconds;

    HuaweiInstallReferrerDetails(String str, long j, long j2) {
        this.installReferrer = str;
        this.referrerClickTimestampSeconds = j;
        this.installBeginTimestampSeconds = j2;
    }

    public String toString() {
        return com.adjust.sdk.Util.formatString(" installReferrer : %s referrerClickTimestampSeconds : %d installBeginTimestampSeconds : %d", new Object[]{this.installReferrer, Long.valueOf(this.referrerClickTimestampSeconds), Long.valueOf(this.installBeginTimestampSeconds)});
    }
}
