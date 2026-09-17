package com.qq.gdt.action.i;

import android.util.Base64;
import java.io.UnsupportedEncodingException;
import java.net.URLEncoder;

/* JADX INFO: loaded from: classes3.dex */
public class i {
    public static String a(String str) {
        return a(str, "UTF-8");
    }

    private static String a(String str, String str2) {
        try {
            return URLEncoder.encode(str, str2);
        } catch (UnsupportedEncodingException unused) {
            return str;
        }
    }

    public static String a(byte[] bArr) {
        return Base64.encodeToString(bArr, 2);
    }

    public static byte[] b(String str) {
        return Base64.decode(str, 2);
    }
}
