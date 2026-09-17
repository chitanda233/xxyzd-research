package com.adjust.sdk.xiaomi;

import android.content.Context;
import com.adjust.sdk.AdjustFactory;
import com.adjust.sdk.scheduler.AsyncTaskExecutor;
import com.alipay.sdk.m.y.c;

/* JADX INFO: loaded from: classes.dex */
public class AdjustXiaomiReferrer {
    static boolean shouldReadXiaomiReferrer = true;

    public static void readXiaomiReferrer(Context context) {
        shouldReadXiaomiReferrer = true;
    }

    public static void doNotReadXiaomiReferrer() {
        shouldReadXiaomiReferrer = false;
    }

    /* JADX WARN: Type inference failed for: r1v0, types: [com.adjust.sdk.xiaomi.AdjustXiaomiReferrer$1] */
    public static void getXiaomiInstallReferrer(final Context context, final OnXiaomiInstallReferrerReadListener onXiaomiInstallReferrerReadListener) {
        if (onXiaomiInstallReferrerReadListener == null) {
            AdjustFactory.getLogger().error("onXiaomiInstallReferrerReadListener can not be null", new Object[0]);
        } else {
            new AsyncTaskExecutor<Context, XiaomiInstallReferrerResult>() { // from class: com.adjust.sdk.xiaomi.AdjustXiaomiReferrer.1
                /* JADX INFO: Access modifiers changed from: protected */
                public XiaomiInstallReferrerResult doInBackground(Context[] contextArr) {
                    try {
                        return XiaomiReferrerClient.getReferrer(context, AdjustFactory.getLogger(), c.f378a);
                    } catch (Exception e) {
                        return new XiaomiInstallReferrerResult(e.getMessage());
                    }
                }

                /* JADX INFO: Access modifiers changed from: protected */
                public void onPostExecute(XiaomiInstallReferrerResult xiaomiInstallReferrerResult) {
                    if (xiaomiInstallReferrerResult != null) {
                        if (xiaomiInstallReferrerResult.xiaomiInstallReferrerDetails != null) {
                            onXiaomiInstallReferrerReadListener.onXiaomiInstallReferrerRead(xiaomiInstallReferrerResult.xiaomiInstallReferrerDetails);
                            return;
                        } else if (xiaomiInstallReferrerResult.error != null) {
                            onXiaomiInstallReferrerReadListener.onFail(xiaomiInstallReferrerResult.error);
                            return;
                        } else {
                            onXiaomiInstallReferrerReadListener.onFail("XiaomiReferrer getInstallReferrer: xiaomiInstallReferrerDetails is null");
                            return;
                        }
                    }
                    onXiaomiInstallReferrerReadListener.onFail("XiaomiReferrer getInstallReferrer: xiaomiInstallReferrerResult is null");
                }
            }.execute(new Context[]{context});
        }
    }
}
