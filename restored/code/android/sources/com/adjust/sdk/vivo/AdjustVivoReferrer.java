package com.adjust.sdk.vivo;

import android.content.Context;
import com.adjust.sdk.AdjustFactory;
import com.adjust.sdk.scheduler.AsyncTaskExecutor;

/* JADX INFO: loaded from: classes.dex */
public class AdjustVivoReferrer {
    static boolean shouldReadVivoReferrer = true;

    /* JADX WARN: Type inference failed for: r1v0, types: [com.adjust.sdk.vivo.AdjustVivoReferrer$1] */
    public static void getVivoInstallReferrer(final Context context, final OnVivoInstallReferrerReadListener onVivoInstallReferrerReadListener) {
        if (onVivoInstallReferrerReadListener == null) {
            AdjustFactory.getLogger().error("onVivoInstallReferrerReadListener can not be null", new Object[0]);
        } else {
            new AsyncTaskExecutor<Context, VivoInstallReferrerResult>() { // from class: com.adjust.sdk.vivo.AdjustVivoReferrer.1
                /* JADX INFO: Access modifiers changed from: protected */
                public VivoInstallReferrerResult doInBackground(Context[] contextArr) {
                    try {
                        return VivoReferrerClient.getReferrer(context, AdjustFactory.getLogger());
                    } catch (Exception e) {
                        return new VivoInstallReferrerResult(e.getMessage());
                    }
                }

                /* JADX INFO: Access modifiers changed from: protected */
                public void onPostExecute(VivoInstallReferrerResult vivoInstallReferrerResult) {
                    if (vivoInstallReferrerResult != null) {
                        if (vivoInstallReferrerResult.vivoInstallReferrerDetails != null) {
                            onVivoInstallReferrerReadListener.onVivoInstallReferrerRead(vivoInstallReferrerResult.vivoInstallReferrerDetails);
                            return;
                        } else if (vivoInstallReferrerResult.error != null) {
                            onVivoInstallReferrerReadListener.onFail(vivoInstallReferrerResult.error);
                            return;
                        } else {
                            onVivoInstallReferrerReadListener.onFail("VivoReferrer getInstallReferrer: xiaomiInstallReferrerDetails is null");
                            return;
                        }
                    }
                    onVivoInstallReferrerReadListener.onFail("VivoReferrer getInstallReferrer: vivoInstallReferrerResult is null");
                }
            }.execute(new Context[]{context});
        }
    }

    public static void readVivoReferrer(Context context) {
        shouldReadVivoReferrer = true;
    }

    public static void doNotReadVivoReferrer() {
        shouldReadVivoReferrer = false;
    }
}
