package com.adjust.sdk.samsung;

import android.content.Context;
import com.adjust.sdk.AdjustFactory;
import com.adjust.sdk.scheduler.AsyncTaskExecutor;

/* JADX INFO: loaded from: classes.dex */
public class AdjustSamsungReferrer {
    static boolean shouldReadSamsungReferrer = true;

    /* JADX WARN: Type inference failed for: r1v0, types: [com.adjust.sdk.samsung.AdjustSamsungReferrer$1] */
    public static void getSamsungInstallReferrer(final Context context, final OnSamsungInstallReferrerReadListener onSamsungInstallReferrerReadListener) {
        if (onSamsungInstallReferrerReadListener == null) {
            AdjustFactory.getLogger().error("onSamsungInstallReferrerReadListener can not be null", new Object[0]);
        } else {
            new AsyncTaskExecutor<Context, SamsungInstallReferrerResult>() { // from class: com.adjust.sdk.samsung.AdjustSamsungReferrer.1
                /* JADX INFO: Access modifiers changed from: protected */
                public SamsungInstallReferrerResult doInBackground(Context[] contextArr) {
                    try {
                        return SamsungReferrerClient.getReferrer(context, AdjustFactory.getLogger(), 2000L);
                    } catch (Exception e) {
                        return new SamsungInstallReferrerResult(e.getMessage());
                    }
                }

                /* JADX INFO: Access modifiers changed from: protected */
                public void onPostExecute(SamsungInstallReferrerResult samsungInstallReferrerResult) {
                    if (samsungInstallReferrerResult != null) {
                        if (samsungInstallReferrerResult.samsungInstallReferrerDetails != null) {
                            onSamsungInstallReferrerReadListener.onSamsungInstallReferrerRead(samsungInstallReferrerResult.samsungInstallReferrerDetails);
                            return;
                        } else if (samsungInstallReferrerResult.error != null) {
                            onSamsungInstallReferrerReadListener.onFail(samsungInstallReferrerResult.error);
                            return;
                        } else {
                            onSamsungInstallReferrerReadListener.onFail("SamsungReferrer getInstallReferrer: samsungInstallReferrerDetails is null");
                            return;
                        }
                    }
                    onSamsungInstallReferrerReadListener.onFail("SamsungReferrer getInstallReferrer: samsungInstallReferrerResult is null");
                }
            }.execute(new Context[]{context});
        }
    }

    public static void readSamsungReferrer(Context context) {
        shouldReadSamsungReferrer = true;
    }

    public static void doNotReadSamsungReferrer() {
        shouldReadSamsungReferrer = false;
    }
}
