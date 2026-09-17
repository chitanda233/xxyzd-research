package com.samsung.android.sdk.sinstallreferrer;

/* JADX INFO: loaded from: classes3.dex */
public class SInstallReferrer {
    public static int getVersionCode() {
        try {
            Integer num = 30;
            return num.intValue();
        } catch (NumberFormatException e) {
            e.printStackTrace();
            return -1;
        }
    }

    public static String getVersionName() {
        return "3.0.1";
    }
}
