package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.text.TextUtils;
import com.qq.gdt.action.ActionUtils;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.super, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public abstract class Csuper {
    public static int a(Context context) {
        try {
            Intent intentRegisterReceiver = context.registerReceiver(null, new IntentFilter("android.intent.action.BATTERY_CHANGED"));
            if (intentRegisterReceiver == null || !TextUtils.equals(intentRegisterReceiver.getAction(), "android.intent.action.BATTERY_CHANGED")) {
                return -1;
            }
            int intExtra = intentRegisterReceiver.getIntExtra(ActionUtils.LEVEL, 0);
            int intExtra2 = intentRegisterReceiver.getIntExtra("scale", 100);
            if (intExtra2 == 0) {
                return -1;
            }
            int i = (intExtra * 100) / intExtra2;
            int i2 = i >= 0 ? i : 0;
            if (i2 > 100) {
                return 100;
            }
            return i2;
        } catch (Throwable unused) {
            return -1;
        }
    }
}
