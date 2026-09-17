package com.sigmob.sdk.base.models;

/* JADX INFO: loaded from: classes3.dex */
public class AppInfo {
    public final String appVersion;
    public final String os;
    public final String sdkVersion;

    public AppInfo(String sdkVersion, String appVersion, String os) {
        this.sdkVersion = sdkVersion;
        this.appVersion = appVersion;
        this.os = os;
    }

    public String toString() {
        return "appInfo={sdkVersion='" + this.sdkVersion + "', appVersion='" + this.appVersion + "', os='" + this.os + "'}";
    }
}
