package com.byazt.yv;

import android.telephony.TelephonyManager;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 499, 34})
public class a {
    public static String c(TelephonyManager telephonyManager) throws SecurityException {
        if (da.tt) {
            da.c("SensitiveUtils gDI c", null);
        }
        return telephonyManager.getDeviceId();
    }
}
