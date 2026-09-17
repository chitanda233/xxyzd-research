package com.adjust.sdk.meta;

import android.content.Context;
import com.adjust.sdk.AdjustFactory;
import com.adjust.sdk.scheduler.AsyncTaskExecutor;

/* JADX INFO: loaded from: classes.dex */
public class AdjustMetaReferrer {
    static boolean shouldReadMetaReferrer = true;

    /* JADX WARN: Type inference failed for: r1v0, types: [com.adjust.sdk.meta.AdjustMetaReferrer$1] */
    public static void getMetaInstallReferrer(final Context context, final String str, final OnMetaInstallReferrerReadListener onMetaInstallReferrerReadListener) {
        if (onMetaInstallReferrerReadListener == null) {
            AdjustFactory.getLogger().error("onMetaInstallReferrerReadListener can not be null", new Object[0]);
        } else {
            new AsyncTaskExecutor<Context, MetaInstallReferrerResult>() { // from class: com.adjust.sdk.meta.AdjustMetaReferrer.1
                /* JADX INFO: Access modifiers changed from: protected */
                public MetaInstallReferrerResult doInBackground(Context[] contextArr) {
                    try {
                        return MetaReferrerClient.getMetaInstallReferrer(context, str, AdjustFactory.getLogger(), false);
                    } catch (Exception e) {
                        return new MetaInstallReferrerResult(e.getMessage());
                    }
                }

                /* JADX INFO: Access modifiers changed from: protected */
                public void onPostExecute(MetaInstallReferrerResult metaInstallReferrerResult) {
                    if (metaInstallReferrerResult != null) {
                        if (metaInstallReferrerResult.metaInstallReferrerDetails != null) {
                            onMetaInstallReferrerReadListener.onInstallReferrerDetailsRead(metaInstallReferrerResult.metaInstallReferrerDetails);
                            return;
                        } else if (metaInstallReferrerResult.error != null) {
                            onMetaInstallReferrerReadListener.onFail(metaInstallReferrerResult.error);
                            return;
                        } else {
                            onMetaInstallReferrerReadListener.onFail("Meta Install Referrer details null");
                            return;
                        }
                    }
                    onMetaInstallReferrerReadListener.onFail("Meta Install Referrer result null");
                }
            }.execute(new Context[]{context});
        }
    }

    public static void readMetaReferrer(Context context) {
        shouldReadMetaReferrer = true;
    }

    public static void doNotReadMetaReferrer() {
        shouldReadMetaReferrer = false;
    }
}
