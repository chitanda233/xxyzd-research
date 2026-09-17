package com.adjust.sdk.xiaomi;

import com.miui.referrer.api.GetAppsReferrerDetails;

/* JADX INFO: loaded from: classes.dex */
public class XiaomiInstallReferrerDetails {
    public long installBeginTimestampSeconds;
    public long installBeginTimestampServerSeconds;
    public String installReferrer;
    public String installVersion;
    public long referrerClickTimestampSeconds;
    public long referrerClickTimestampServerSeconds;

    public XiaomiInstallReferrerDetails(GetAppsReferrerDetails getAppsReferrerDetails) {
        this.installReferrer = getAppsReferrerDetails.getInstallReferrer();
        this.referrerClickTimestampSeconds = getAppsReferrerDetails.getReferrerClickTimestampSeconds();
        this.installBeginTimestampSeconds = getAppsReferrerDetails.getInstallBeginTimestampSeconds();
        this.installBeginTimestampServerSeconds = getAppsReferrerDetails.getInstallBeginTimestampServerSeconds();
        this.referrerClickTimestampServerSeconds = getAppsReferrerDetails.getReferrerClickTimestampServerSeconds();
        this.installVersion = getAppsReferrerDetails.getInstallVersion();
    }
}
