package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.provider.Settings;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Tough {
    public static boolean a(Context context) {
        return Settings.Secure.getInt(context.getContentResolver(), "mock_location", 0) != 0;
    }
}
