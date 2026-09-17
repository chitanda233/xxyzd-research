package com.adjust.sdk.meta;

import android.content.Context;
import com.adjust.sdk.ILogger;
import com.adjust.sdk.ReferrerDetails;

/* JADX INFO: loaded from: classes.dex */
public class Util {
    public static synchronized ReferrerDetails getMetaInstallReferrerDetails(Context context, String str, ILogger iLogger) {
        if (!AdjustMetaReferrer.shouldReadMetaReferrer) {
            return null;
        }
        iLogger.info("getMetaInstallReferrerDetails invoked", new Object[0]);
        MetaInstallReferrerResult metaInstallReferrer = MetaReferrerClient.getMetaInstallReferrer(context, str, iLogger, true);
        if (metaInstallReferrer == null) {
            return null;
        }
        if (metaInstallReferrer.metaInstallReferrerDetails == null) {
            return null;
        }
        MetaInstallReferrerDetails metaInstallReferrerDetails = metaInstallReferrer.metaInstallReferrerDetails;
        return new ReferrerDetails(metaInstallReferrerDetails.installReferrer, metaInstallReferrerDetails.actualTimestampInSec, Boolean.valueOf(metaInstallReferrerDetails.isClick));
    }
}
