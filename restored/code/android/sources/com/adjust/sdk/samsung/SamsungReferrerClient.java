package com.adjust.sdk.samsung;

import android.content.Context;
import com.adjust.sdk.ILogger;
import com.samsung.android.sdk.sinstallreferrer.api.InstallReferrerClient;
import com.samsung.android.sdk.sinstallreferrer.api.InstallReferrerStateListener;
import com.samsung.android.sdk.sinstallreferrer.api.ReferrerDetails;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes.dex */
public class SamsungReferrerClient {
    public static SamsungInstallReferrerResult getReferrer(Context context, final ILogger iLogger, long j) {
        try {
            final InstallReferrerClient installReferrerClientBuild = InstallReferrerClient.newBuilder(context).build();
            final LinkedBlockingQueue linkedBlockingQueue = new LinkedBlockingQueue(1);
            installReferrerClientBuild.startConnection(new InstallReferrerStateListener() { // from class: com.adjust.sdk.samsung.SamsungReferrerClient.1
                @Override // com.samsung.android.sdk.sinstallreferrer.api.InstallReferrerStateListener
                public void onInstallReferrerSetupFinished(int i) {
                    InstallReferrerClient installReferrerClient;
                    try {
                        if (i != 0) {
                            if (i == 1) {
                                linkedBlockingQueue.offer(new SamsungInstallReferrerResult("SamsungReferrer onInstallReferrerSetupFinished: SERVICE_UNAVAILABLE"));
                                iLogger.info("SamsungReferrer onInstallReferrerSetupFinished: SERVICE_UNAVAILABLE", new Object[0]);
                                return;
                            } else {
                                if (i != 2) {
                                    return;
                                }
                                linkedBlockingQueue.offer(new SamsungInstallReferrerResult("SamsungReferrer onInstallReferrerSetupFinished: FEATURE_NOT_SUPPORTED"));
                                iLogger.info("SamsungReferrer onInstallReferrerSetupFinished: FEATURE_NOT_SUPPORTED", new Object[0]);
                                return;
                            }
                        }
                        try {
                            try {
                                linkedBlockingQueue.offer(new SamsungInstallReferrerResult(SamsungReferrerClient.getSamsungInstallReferrerDetails(installReferrerClientBuild)));
                                installReferrerClient = installReferrerClientBuild;
                            } catch (Exception e) {
                                String str = "SamsungReferrer getInstallReferrer: " + e.getMessage();
                                linkedBlockingQueue.offer(new SamsungInstallReferrerResult(str));
                                iLogger.error(str, new Object[0]);
                                installReferrerClient = installReferrerClientBuild;
                            }
                            installReferrerClient.endConnection();
                        } catch (Throwable th) {
                            installReferrerClientBuild.endConnection();
                            throw th;
                        }
                    } catch (Exception e2) {
                        String str2 = "SamsungReferrer onInstallReferrerSetupFinished: " + e2.getMessage();
                        linkedBlockingQueue.offer(new SamsungInstallReferrerResult(str2));
                        iLogger.error(str2, new Object[0]);
                    }
                }

                @Override // com.samsung.android.sdk.sinstallreferrer.api.InstallReferrerStateListener
                public void onInstallReferrerServiceDisconnected() {
                    installReferrerClientBuild.endConnection();
                }
            });
            return (SamsungInstallReferrerResult) linkedBlockingQueue.poll(j, TimeUnit.MILLISECONDS);
        } catch (Exception e) {
            String str = "SamsungReferrer read error: " + e.getMessage();
            iLogger.info(str, new Object[0]);
            return new SamsungInstallReferrerResult(str);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static SamsungInstallReferrerDetails getSamsungInstallReferrerDetails(InstallReferrerClient installReferrerClient) {
        ReferrerDetails installReferrer = installReferrerClient.getInstallReferrer();
        return new SamsungInstallReferrerDetails(installReferrer.getInstallReferrer(), installReferrer.getReferrerClickTimestampSeconds(), installReferrer.getInstallBeginTimestampSeconds());
    }
}
