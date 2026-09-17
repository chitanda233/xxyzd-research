package com.tencent.turingfd.sdk.ams.ad;

import android.text.TextUtils;
import java.io.UnsupportedEncodingException;
import java.security.SecureRandom;
import java.text.DecimalFormat;
import java.util.Locale;
import kotlin.UByte;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Teazle {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final Tangor f3900a = new Tangor();

    static {
        new SecureRandom();
    }

    public static String a(double d) {
        DecimalFormat decimalFormat = (DecimalFormat) f3900a.get();
        return decimalFormat == null ? String.valueOf(d) : decimalFormat.format(d);
    }

    public static String a(byte[] bArr) {
        StringBuffer stringBuffer = new StringBuffer(bArr.length);
        for (byte b : bArr) {
            String hexString = Integer.toHexString(b & UByte.MAX_VALUE);
            if (hexString.length() < 2) {
                stringBuffer.append(0);
            }
            stringBuffer.append(hexString.toUpperCase(Locale.getDefault()));
        }
        return stringBuffer.toString();
    }

    public static String a(String str, byte[] bArr) {
        try {
            if (str == null) {
                return new String(bArr);
            }
            return new String(bArr, str);
        } catch (UnsupportedEncodingException unused) {
            return null;
        }
    }

    public static String a(String str) {
        if (TextUtils.isEmpty(str) || TextUtils.isEmpty(",:")) {
            return str;
        }
        StringBuilder sb = new StringBuilder(str.length());
        for (int i = 0; i < str.length(); i++) {
            char cCharAt = str.charAt(i);
            if (",:".indexOf(cCharAt) >= 0) {
                sb.append('%').append(String.format("%H", Character.valueOf(cCharAt)));
            } else {
                sb.append(cCharAt);
            }
        }
        return sb.toString();
    }
}
