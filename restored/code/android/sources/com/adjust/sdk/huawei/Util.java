package com.adjust.sdk.huawei;

import android.content.Context;
import com.adjust.sdk.ILogger;
import com.adjust.sdk.ReferrerDetails;

/* JADX INFO: loaded from: classes.dex */
public class Util {
    public static synchronized ReferrerDetails getHuaweiAdsInstallReferrerDetails(Context context, ILogger iLogger) {
        if (!AdjustHuaweiReferrer.shouldReadHuaweiReferrer) {
            return null;
        }
        iLogger.info("getHuaweiAdsInstallReferrerDetails invoked", new Object[0]);
        HuaweiInstallReferrerResult huaweiAdsInstallReferrer = HuaweiReferrerClient.getHuaweiAdsInstallReferrer(context, iLogger);
        if (huaweiAdsInstallReferrer == null) {
            return null;
        }
        if (huaweiAdsInstallReferrer.huaweiInstallReferrerDetails == null) {
            return null;
        }
        HuaweiInstallReferrerDetails huaweiInstallReferrerDetails = huaweiAdsInstallReferrer.huaweiInstallReferrerDetails;
        return new ReferrerDetails(huaweiInstallReferrerDetails.installReferrer, huaweiInstallReferrerDetails.referrerClickTimestampSeconds, huaweiInstallReferrerDetails.installBeginTimestampSeconds);
    }

    public static synchronized ReferrerDetails getHuaweiAppGalleryInstallReferrerDetails(Context context, ILogger iLogger) {
        if (!AdjustHuaweiReferrer.shouldReadHuaweiReferrer) {
            return null;
        }
        iLogger.info("getHuaweiAppGalleryInstallReferrerDetails invoked", new Object[0]);
        HuaweiInstallReferrerResult huaweiAppGalleryInstallReferrer = HuaweiReferrerClient.getHuaweiAppGalleryInstallReferrer(context, iLogger);
        if (huaweiAppGalleryInstallReferrer == null) {
            return null;
        }
        if (huaweiAppGalleryInstallReferrer.huaweiInstallReferrerDetails == null) {
            return null;
        }
        HuaweiInstallReferrerDetails huaweiInstallReferrerDetails = huaweiAppGalleryInstallReferrer.huaweiInstallReferrerDetails;
        return new ReferrerDetails(huaweiInstallReferrerDetails.installReferrer, huaweiInstallReferrerDetails.referrerClickTimestampSeconds, huaweiInstallReferrerDetails.installBeginTimestampSeconds);
    }
}
