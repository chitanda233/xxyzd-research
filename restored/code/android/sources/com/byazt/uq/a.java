package com.byazt.uq;

import com.baidu.mobads.sdk.internal.bz;
import java.io.File;
import java.io.FileInputStream;
import java.security.MessageDigest;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1759, 34})
public final class a {
    public static final char[] c = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

    public static String c(String str) {
        return c(str.getBytes());
    }

    public static String c(byte[] bArr) {
        if (bArr != null && bArr.length > 0) {
            try {
                MessageDigest messageDigest = MessageDigest.getInstance(bz.f456a);
                messageDigest.update(bArr);
                return tt(messageDigest.digest());
            } catch (Exception unused) {
            }
        }
        return null;
    }

    private static String tt(byte[] bArr) {
        int length;
        if (bArr == null || (length = bArr.length) <= 0) {
            return null;
        }
        char[] cArr = new char[length << 1];
        int i = 0;
        for (byte b : bArr) {
            int i2 = i + 1;
            char[] cArr2 = c;
            cArr[i] = cArr2[(b >>> 4) & 15];
            i = i2 + 1;
            cArr[i2] = cArr2[b & 15];
        }
        return new String(cArr);
    }

    public static String c(File file) {
        try {
            MessageDigest messageDigest = MessageDigest.getInstance(bz.f456a);
            FileInputStream fileInputStream = new FileInputStream(file);
            byte[] bArr = new byte[8192];
            while (true) {
                int i = fileInputStream.read(bArr, 0, 8192);
                if (i > 0) {
                    messageDigest.update(bArr, 0, i);
                } else {
                    fileInputStream.close();
                    return tt(messageDigest.digest());
                }
            }
        } catch (Exception unused) {
            return null;
        }
    }
}
