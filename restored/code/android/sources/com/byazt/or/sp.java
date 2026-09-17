package com.byazt.or;

import android.text.TextUtils;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 579, 91})
public class sp {
    public static boolean c(String str) {
        return TextUtils.equals(str, "fullscreen_interstitial_ad") || TextUtils.equals(str, "rewarded_video");
    }

    public static boolean tt(String str) {
        return com.byazt.sr.uj.c() && c(str);
    }
}
