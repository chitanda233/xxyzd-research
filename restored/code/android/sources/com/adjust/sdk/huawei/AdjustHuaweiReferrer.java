package com.adjust.sdk.huawei;

import android.content.Context;
import com.adjust.sdk.AdjustFactory;
import com.adjust.sdk.scheduler.AsyncTaskExecutor;

/* JADX INFO: loaded from: classes.dex */
public class AdjustHuaweiReferrer {
    static boolean shouldReadHuaweiReferrer = true;

    /* JADX WARN: Type inference failed for: r1v0, types: [com.adjust.sdk.huawei.AdjustHuaweiReferrer$1] */
    public static void getHuaweiAppGalleryInstallReferrer(final Context context, final OnHuaweiInstallReferrerReadListener onHuaweiInstallReferrerReadListener) {
        if (onHuaweiInstallReferrerReadListener == null) {
            AdjustFactory.getLogger().error("onHuaweiInstallReferrerReadListener can not be null", new Object[0]);
        } else {
            new AsyncTaskExecutor<Context, HuaweiInstallReferrerResult>() { // from class: com.adjust.sdk.huawei.AdjustHuaweiReferrer.1
                /* JADX INFO: Access modifiers changed from: protected */
                public HuaweiInstallReferrerResult doInBackground(Context[] contextArr) {
                    try {
                        return HuaweiReferrerClient.getHuaweiAppGalleryInstallReferrer(context, AdjustFactory.getLogger());
                    } catch (Exception e) {
                        return new HuaweiInstallReferrerResult(e.getMessage());
                    }
                }

                /* JADX INFO: Access modifiers changed from: protected */
                public void onPostExecute(HuaweiInstallReferrerResult huaweiInstallReferrerResult) {
                    if (huaweiInstallReferrerResult != null) {
                        if (huaweiInstallReferrerResult.huaweiInstallReferrerDetails != null) {
                            onHuaweiInstallReferrerReadListener.onInstallReferrerDetailsRead(huaweiInstallReferrerResult.huaweiInstallReferrerDetails);
                            return;
                        } else if (huaweiInstallReferrerResult.error != null) {
                            onHuaweiInstallReferrerReadListener.onFail(huaweiInstallReferrerResult.error);
                            return;
                        } else {
                            onHuaweiInstallReferrerReadListener.onFail("HuaweiReferrer getInstallReferrer: huaweiInstallReferrerDetails is null");
                            return;
                        }
                    }
                    onHuaweiInstallReferrerReadListener.onFail("HuaweiReferrer getInstallReferrer: huaweiInstallReferrerResult is null");
                }
            }.execute(new Context[]{context});
        }
    }

    /* JADX WARN: Type inference failed for: r1v0, types: [com.adjust.sdk.huawei.AdjustHuaweiReferrer$2] */
    public static void getHuaweiAdsInstallReferrer(final Context context, final OnHuaweiInstallReferrerReadListener onHuaweiInstallReferrerReadListener) {
        if (onHuaweiInstallReferrerReadListener == null) {
            AdjustFactory.getLogger().error("onHuaweiInstallReferrerReadListener can not be null", new Object[0]);
        } else {
            new AsyncTaskExecutor<Context, HuaweiInstallReferrerResult>() { // from class: com.adjust.sdk.huawei.AdjustHuaweiReferrer.2
                /* JADX INFO: Access modifiers changed from: protected */
                public HuaweiInstallReferrerResult doInBackground(Context[] contextArr) {
                    try {
                        return HuaweiReferrerClient.getHuaweiAdsInstallReferrer(context, AdjustFactory.getLogger());
                    } catch (Exception e) {
                        return new HuaweiInstallReferrerResult(e.getMessage());
                    }
                }

                /* JADX INFO: Access modifiers changed from: protected */
                public void onPostExecute(HuaweiInstallReferrerResult huaweiInstallReferrerResult) {
                    if (huaweiInstallReferrerResult != null) {
                        if (huaweiInstallReferrerResult.huaweiInstallReferrerDetails != null) {
                            onHuaweiInstallReferrerReadListener.onInstallReferrerDetailsRead(huaweiInstallReferrerResult.huaweiInstallReferrerDetails);
                            return;
                        } else if (huaweiInstallReferrerResult.error != null) {
                            onHuaweiInstallReferrerReadListener.onFail(huaweiInstallReferrerResult.error);
                            return;
                        } else {
                            onHuaweiInstallReferrerReadListener.onFail("HuaweiReferrer getInstallReferrer: huaweiInstallReferrerDetails is null");
                            return;
                        }
                    }
                    onHuaweiInstallReferrerReadListener.onFail("HuaweiReferrer getInstallReferrer: huaweiInstallReferrerResult is null");
                }
            }.execute(new Context[]{context});
        }
    }

    public static void readHuaweiReferrer(Context context) {
        shouldReadHuaweiReferrer = true;
    }

    public static void doNotReadHuaweiReferrer() {
        shouldReadHuaweiReferrer = false;
    }
}
