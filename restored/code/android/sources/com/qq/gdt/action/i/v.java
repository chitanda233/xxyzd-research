package com.qq.gdt.action.i;

import java.util.Locale;

/* JADX INFO: loaded from: classes3.dex */
public class v {
    public static String a(String str, Object... objArr) {
        return String.format(Locale.US, str, objArr);
    }

    public static boolean a(String str) {
        return str == null || str.trim().length() == 0;
    }
}
