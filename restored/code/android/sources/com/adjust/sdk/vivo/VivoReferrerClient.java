package com.adjust.sdk.vivo;

import android.content.Context;
import android.net.Uri;
import android.os.Bundle;
import android.text.TextUtils;
import com.adjust.sdk.ILogger;

/* JADX INFO: loaded from: classes.dex */
public class VivoReferrerClient {
    public static VivoInstallReferrerResult getReferrer(Context context, ILogger iLogger) {
        try {
            Bundle bundleCall = context.getContentResolver().call(Uri.parse("content://com.vivo.appstore.provider.referrer"), "read_referrer", (String) null, (Bundle) null);
            if (bundleCall == null) {
                return new VivoInstallReferrerResult("VivoReferrer read error: resultBundle null");
            }
            String string = bundleCall.getString("install_referrer");
            if (TextUtils.isEmpty(string)) {
                return new VivoInstallReferrerResult("VivoReferrer read error: referrer string null");
            }
            return new VivoInstallReferrerResult(new VivoInstallReferrerDetails(string, bundleCall.getLong("referrer_click_timestamp_seconds"), bundleCall.getLong("download_begin_timestamp_seconds"), bundleCall.getString("install_version")));
        } catch (Exception e) {
            String str = "VivoReferrer read error: " + e.getMessage();
            iLogger.info(str, new Object[0]);
            return new VivoInstallReferrerResult(str);
        }
    }
}
