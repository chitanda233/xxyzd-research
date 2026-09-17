package com.byazt.nys;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 430, 46})
public class n {
    public static StringBuffer c = new StringBuffer();

    public static void c(String str, String str2) {
        StringBuffer stringBuffer = c;
        if (stringBuffer == null || str2 == null) {
            return;
        }
        try {
            if (stringBuffer.length() > 204800) {
                return;
            }
            c.append(System.currentTimeMillis()).append(';').append(str).append(';').append(str2).append('\n');
        } catch (Exception unused) {
        }
    }

    public static void c() {
        c = null;
    }

    public static String tt() {
        StringBuffer stringBuffer = c;
        String string = stringBuffer != null ? stringBuffer.toString() : "";
        c = null;
        return string;
    }
}
