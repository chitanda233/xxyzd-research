package com.qq.gdt.action.d;

import android.text.TextUtils;

/* JADX INFO: loaded from: classes3.dex */
final class a {
    public static String a(String str) {
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        String strA = f.a(str, "UTF-8");
        if (TextUtils.isEmpty(strA)) {
            return null;
        }
        return strA.toLowerCase();
    }
}
