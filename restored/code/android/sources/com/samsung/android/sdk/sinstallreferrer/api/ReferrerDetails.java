package com.samsung.android.sdk.sinstallreferrer.api;

import android.os.Bundle;

/* JADX INFO: loaded from: classes3.dex */
public class ReferrerDetails {
    private static final String KEY_INSTALL_BEGIN_TIMESTAMP = "install_begin_timestamp";
    private static final String KEY_INSTALL_REFERRER = "install_referrer";
    private static final String KEY_REFERRER_CLICK_TIMESTAMP = "referrer_click_timestamp";
    private final Bundle mOriginalBundle;

    public ReferrerDetails(Bundle bundle) {
        this.mOriginalBundle = bundle;
    }

    public long getInstallBeginTimestampSeconds() {
        return this.mOriginalBundle.getLong(KEY_INSTALL_BEGIN_TIMESTAMP) / 1000;
    }

    public String getInstallReferrer() {
        return this.mOriginalBundle.getString(KEY_INSTALL_REFERRER);
    }

    public long getReferrerClickTimestampSeconds() {
        return this.mOriginalBundle.getLong(KEY_REFERRER_CLICK_TIMESTAMP) / 1000;
    }
}
