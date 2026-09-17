package com.kwad.sdk.utils;

import android.content.Context;

/* JADX INFO: loaded from: classes3.dex */
public final class w {
    private static String hD(String str) {
        return bq.i("kssdk_api_pref", str, "");
    }

    public static String bn(Context context) {
        return hD("curversion");
    }
}
