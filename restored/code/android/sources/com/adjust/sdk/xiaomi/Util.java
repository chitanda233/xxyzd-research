package com.adjust.sdk.xiaomi;

import android.content.Context;
import com.adjust.sdk.ILogger;
import com.adjust.sdk.ReferrerDetails;
import com.alipay.sdk.m.y.c;

/* JADX INFO: loaded from: classes.dex */
public class Util {
    public static synchronized ReferrerDetails getXiaomiInstallReferrerDetails(Context context, ILogger iLogger) {
        if (!AdjustXiaomiReferrer.shouldReadXiaomiReferrer) {
            return null;
        }
        iLogger.info("getXiaomiInstallReferrerDetails invoked", new Object[0]);
        XiaomiInstallReferrerDetails xiaomiInstallReferrerDetails = XiaomiReferrerClient.getReferrer(context, iLogger, c.f378a).xiaomiInstallReferrerDetails;
        if (xiaomiInstallReferrerDetails == null) {
            return null;
        }
        return new ReferrerDetails(xiaomiInstallReferrerDetails.installReferrer, xiaomiInstallReferrerDetails.referrerClickTimestampSeconds, xiaomiInstallReferrerDetails.installBeginTimestampSeconds, xiaomiInstallReferrerDetails.referrerClickTimestampServerSeconds, xiaomiInstallReferrerDetails.installBeginTimestampServerSeconds, xiaomiInstallReferrerDetails.installVersion, (Boolean) null, (Boolean) null);
    }
}
