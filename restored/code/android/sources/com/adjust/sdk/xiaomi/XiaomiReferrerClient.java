package com.adjust.sdk.xiaomi;

import android.content.Context;
import com.adjust.sdk.ILogger;
import com.miui.referrer.api.GetAppsReferrerClient;
import com.miui.referrer.api.GetAppsReferrerStateListener;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes.dex */
public class XiaomiReferrerClient {
    public static XiaomiInstallReferrerResult getReferrer(Context context, final ILogger iLogger, long j) {
        try {
            final GetAppsReferrerClient getAppsReferrerClientBuild = new GetAppsReferrerClient.Builder(context).build();
            final LinkedBlockingQueue linkedBlockingQueue = new LinkedBlockingQueue(1);
            getAppsReferrerClientBuild.startConnection(new GetAppsReferrerStateListener() { // from class: com.adjust.sdk.xiaomi.XiaomiReferrerClient.1
                @Override // com.miui.referrer.api.GetAppsReferrerStateListener
                public void onGetAppsServiceDisconnected() {
                }

                @Override // com.miui.referrer.api.GetAppsReferrerStateListener
                public void onGetAppsReferrerSetupFinished(int i) {
                    try {
                        if (i == 0) {
                            try {
                                linkedBlockingQueue.offer(new XiaomiInstallReferrerResult(new XiaomiInstallReferrerDetails(getAppsReferrerClientBuild.getInstallReferrer())));
                            } catch (Exception e) {
                                String str = "XiaomiReferrer getInstallReferrer: " + e.getMessage();
                                iLogger.error(str, new Object[0]);
                                linkedBlockingQueue.offer(new XiaomiInstallReferrerResult(str));
                            }
                        } else if (i == 1) {
                            iLogger.info("XiaomiReferrer onGetAppsReferrerSetupFinished: SERVICE_UNAVAILABLE", new Object[0]);
                            linkedBlockingQueue.offer(new XiaomiInstallReferrerResult("XiaomiReferrer onGetAppsReferrerSetupFinished: SERVICE_UNAVAILABLE"));
                        } else {
                            if (i != 2) {
                                return;
                            }
                            iLogger.info("XiaomiReferrer onGetAppsReferrerSetupFinished: FEATURE_NOT_SUPPORTED", new Object[0]);
                            linkedBlockingQueue.offer(new XiaomiInstallReferrerResult("XiaomiReferrer onGetAppsReferrerSetupFinished: FEATURE_NOT_SUPPORTED"));
                        }
                    } catch (Exception e2) {
                        String str2 = "XiaomiReferrer onGetAppsReferrerSetupFinished: " + e2.getMessage();
                        iLogger.error(str2, new Object[0]);
                        linkedBlockingQueue.offer(new XiaomiInstallReferrerResult(str2));
                    }
                }
            });
            return (XiaomiInstallReferrerResult) linkedBlockingQueue.poll(j, TimeUnit.MILLISECONDS);
        } catch (Exception e) {
            iLogger.error("Exception while getting referrer: ", new Object[]{e.getMessage()});
            return new XiaomiInstallReferrerResult(e.getMessage());
        }
    }
}
