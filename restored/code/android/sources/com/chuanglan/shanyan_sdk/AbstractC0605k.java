package com.chuanglan.shanyan_sdk;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import kotlin.UByte;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.k, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0605k {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final char[] f1982a = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".toCharArray();

    public static String a(byte[] bArr) {
        int length = bArr.length;
        StringBuffer stringBuffer = new StringBuffer((bArr.length * 3) / 2);
        int i = length - 3;
        int i2 = 0;
        int i3 = 0;
        while (i2 <= i) {
            int i4 = ((bArr[i2] & UByte.MAX_VALUE) << 16) | ((bArr[i2 + 1] & UByte.MAX_VALUE) << 8) | (bArr[i2 + 2] & UByte.MAX_VALUE);
            char[] cArr = f1982a;
            stringBuffer.append(cArr[(i4 >> 18) & 63]);
            stringBuffer.append(cArr[(i4 >> 12) & 63]);
            stringBuffer.append(cArr[(i4 >> 6) & 63]);
            stringBuffer.append(cArr[i4 & 63]);
            i2 += 3;
            int i5 = i3 + 1;
            if (i3 >= 14) {
                stringBuffer.append(" ");
                i3 = 0;
            } else {
                i3 = i5;
            }
        }
        if (i2 == length - 2) {
            int i6 = ((bArr[i2 + 1] & UByte.MAX_VALUE) << 8) | ((bArr[i2] & UByte.MAX_VALUE) << 16);
            char[] cArr2 = f1982a;
            stringBuffer.append(cArr2[(i6 >> 18) & 63]);
            stringBuffer.append(cArr2[(i6 >> 12) & 63]);
            stringBuffer.append(cArr2[(i6 >> 6) & 63]);
            stringBuffer.append("=");
        } else if (i2 == length - 1) {
            int i7 = (bArr[i2] & UByte.MAX_VALUE) << 16;
            char[] cArr3 = f1982a;
            stringBuffer.append(cArr3[(i7 >> 18) & 63]);
            stringBuffer.append(cArr3[(i7 >> 12) & 63]);
            stringBuffer.append("==");
        }
        return stringBuffer.toString();
    }

    public static byte[] a(String str) throws Throwable {
        ByteArrayOutputStream byteArrayOutputStream;
        try {
            try {
                byteArrayOutputStream = new ByteArrayOutputStream();
                try {
                    a(str, byteArrayOutputStream);
                    byte[] byteArray = byteArrayOutputStream.toByteArray();
                    try {
                        byteArrayOutputStream.close();
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                    return byteArray;
                } catch (IOException unused) {
                    throw new RuntimeException();
                } catch (Throwable th) {
                    th = th;
                    if (byteArrayOutputStream != null) {
                        try {
                            byteArrayOutputStream.close();
                        } catch (Exception e2) {
                            e2.printStackTrace();
                        }
                    }
                    throw th;
                }
            } catch (Throwable th2) {
                th = th2;
                byteArrayOutputStream = null;
            }
        } catch (IOException unused2) {
        }
    }

    private static void a(String str, OutputStream outputStream) throws IOException {
        int length = str.length();
        int i = 0;
        while (true) {
            if (i < length && str.charAt(i) <= ' ') {
                i++;
            } else {
                if (i == length) {
                    return;
                }
                int i2 = i + 2;
                int i3 = i + 3;
                int iA = (a(str.charAt(i)) << 18) + (a(str.charAt(i + 1)) << 12) + (a(str.charAt(i2)) << 6) + a(str.charAt(i3));
                outputStream.write((iA >> 16) & 255);
                if (str.charAt(i2) == '=') {
                    return;
                }
                outputStream.write((iA >> 8) & 255);
                if (str.charAt(i3) == '=') {
                    return;
                }
                outputStream.write(iA & 255);
                i += 4;
            }
        }
    }

    private static int a(char c) {
        if (c >= 'A' && c <= 'Z') {
            return c - 'A';
        }
        if (c >= 'a' && c <= 'z') {
            return c - 'G';
        }
        if (c >= '0' && c <= '9') {
            return c + 4;
        }
        if (c == '+') {
            return 62;
        }
        if (c == '/') {
            return 63;
        }
        if (c == '=') {
            return 0;
        }
        throw new RuntimeException("unexpected code: " + c);
    }
}
