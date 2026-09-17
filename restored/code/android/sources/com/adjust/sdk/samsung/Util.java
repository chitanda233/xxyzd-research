package com.adjust.sdk.samsung;

import android.content.Context;
import com.adjust.sdk.ILogger;
import com.adjust.sdk.ReferrerDetails;

/* JADX INFO: loaded from: classes.dex */
public class Util {
    public static synchronized ReferrerDetails getSamsungInstallReferrerDetails(Context context, ILogger iLogger) {
        if (!AdjustSamsungReferrer.shouldReadSamsungReferrer) {
            return null;
        }
        iLogger.info("getSamsungInstallReferrerDetails invoked", new Object[0]);
        SamsungInstallReferrerResult referrer = SamsungReferrerClient.getReferrer(context, iLogger, 2000L);
        if (referrer == null) {
            return null;
        }
        SamsungInstallReferrerDetails samsungInstallReferrerDetails = referrer.samsungInstallReferrerDetails;
        if (samsungInstallReferrerDetails == null) {
            return null;
        }
        return new ReferrerDetails(samsungInstallReferrerDetails.installReferrer, samsungInstallReferrerDetails.referrerClickTimestampSeconds, samsungInstallReferrerDetails.installBeginTimestampSeconds, -1L, -1L, (String) null, (Boolean) null, (Boolean) null);
    }
}
