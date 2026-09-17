package com.adjust.sdk.vivo;

import android.content.Context;
import com.adjust.sdk.ILogger;
import com.adjust.sdk.ReferrerDetails;

/* JADX INFO: loaded from: classes.dex */
public class Util {
    public static synchronized ReferrerDetails getVivoInstallReferrerDetails(Context context, ILogger iLogger) {
        if (!AdjustVivoReferrer.shouldReadVivoReferrer) {
            return null;
        }
        iLogger.info("getVivoInstallReferrerDetails invoked", new Object[0]);
        VivoInstallReferrerResult referrer = VivoReferrerClient.getReferrer(context, iLogger);
        if (referrer.vivoInstallReferrerDetails == null) {
            return null;
        }
        VivoInstallReferrerDetails vivoInstallReferrerDetails = referrer.vivoInstallReferrerDetails;
        return new ReferrerDetails(vivoInstallReferrerDetails.installReferrer, vivoInstallReferrerDetails.referrerClickTimestampSeconds, vivoInstallReferrerDetails.installBeginTimestampSeconds, -1L, -1L, vivoInstallReferrerDetails.installVersion, (Boolean) null, (Boolean) null);
    }
}
