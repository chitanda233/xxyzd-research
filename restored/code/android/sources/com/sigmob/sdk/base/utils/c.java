package com.sigmob.sdk.base.utils;

import android.util.Base64;

/* JADX INFO: loaded from: classes3.dex */
public class c {
    public static String a(String str) {
        if (str == null) {
            return null;
        }
        return new String(Base64.decode(str, 2));
    }
}
