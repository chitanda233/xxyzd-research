package com.baidu.passbqt.common;

import com.baidu.mobads.sdk.internal.bz;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import javax.crypto.Cipher;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;
import kotlin.UByte;

/* JADX INFO: loaded from: classes.dex */
class Security {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f615a = "Security";

    Security() {
    }

    public String a(byte[] bArr, boolean z) {
        try {
            MessageDigest messageDigest = MessageDigest.getInstance(bz.f456a);
            messageDigest.reset();
            messageDigest.update(bArr);
            return a(messageDigest.digest(), "", z);
        } catch (NoSuchAlgorithmException e) {
            throw new RuntimeException(e);
        }
    }

    private String a(byte[] bArr, String str, boolean z) {
        StringBuilder sb = new StringBuilder();
        try {
            for (byte b : bArr) {
                String hexString = Integer.toHexString(b & UByte.MAX_VALUE);
                if (z) {
                    hexString = hexString.toUpperCase();
                }
                if (hexString.length() == 1) {
                    sb.append("0");
                }
                sb.append(hexString).append(str);
            }
        } catch (Exception unused) {
            Log.d(f615a, "toHexString is error");
        }
        return sb.toString();
    }

    public String a(byte[] bArr) {
        int i;
        if (bArr == null || bArr.length == 0) {
            return "";
        }
        StringBuilder sb = new StringBuilder();
        int length = bArr.length * 8;
        int i2 = 6;
        int i3 = 0;
        int i4 = 0;
        int i5 = 0;
        byte b = 0;
        while (true) {
            if (i3 > 0 && i2 > 0) {
                if (i4 >= 0 && i4 < bArr.length - 1) {
                    b = (byte) (((bArr[i4] & UByte.MAX_VALUE) << i2) | ((bArr[i4 + 1] & UByte.MAX_VALUE) >> (8 - i2)));
                }
                b = (byte) (b & 63);
                i3 = 8 - i2;
                i2 = 6 - i3;
            } else if (i3 == 0) {
                if (i4 >= 0 && i4 < bArr.length) {
                    b = (byte) ((bArr[i4] & UByte.MAX_VALUE) >> (8 - i2));
                }
                i3 = 2;
                i2 = 4;
            } else if (i2 == 0) {
                if (i4 >= 0 && i4 < bArr.length) {
                    b = (byte) (bArr[i4] & 63);
                }
                i2 = 6;
                i3 = 0;
            }
            sb.append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt(b));
            i5 += 6;
            int i6 = i5 / 8;
            i = length - i5;
            if (i < 6) {
                break;
            }
            i4 = i6;
        }
        if (i > 0) {
            sb.append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt((byte) ((bArr[bArr.length - 1] << (6 - i)) & 63)));
        }
        int i7 = length % 3;
        for (int i8 = 0; i8 < i7; i8++) {
            sb.append("=");
        }
        return sb.toString();
    }

    static class AES {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private static final String f616a = "UTF-8";
        private static final String b = "AES/CBC/NoPadding";
        private static final String c = "AES";
        private String d;
        private String e;
        private String f;

        public AES() {
            this(c, "AES/CBC/NoPadding", "UTF-8");
        }

        public AES(String str, String str2, String str3) {
            this.f = str;
            this.e = str2;
            this.d = str3;
        }

        public byte[] a(String str, String str2, String str3) throws Exception {
            if (str == null || str.length() == 0) {
                throw new Exception("Empty string");
            }
            try {
                IvParameterSpec ivParameterSpec = new IvParameterSpec(str2.getBytes(this.d));
                SecretKeySpec secretKeySpec = new SecretKeySpec(str3.getBytes(), this.f);
                Cipher cipher = Cipher.getInstance(this.e);
                cipher.init(1, secretKeySpec, ivParameterSpec);
                return cipher.doFinal(a(str).getBytes());
            } catch (NoSuchAlgorithmException e) {
                Log.a(e);
                return null;
            } catch (NoSuchPaddingException e2) {
                Log.a(e2);
                return null;
            }
        }

        public byte[] a(byte[] bArr, String str, String str2) throws Exception {
            if (bArr == null || bArr.length == 0) {
                throw new Exception("Empty string");
            }
            byte[] bArr2 = new byte[0];
            try {
                IvParameterSpec ivParameterSpec = new IvParameterSpec(str.getBytes(this.d));
                SecretKeySpec secretKeySpec = new SecretKeySpec(str2.getBytes(), this.f);
                Cipher cipher = Cipher.getInstance(this.e);
                cipher.init(2, secretKeySpec, ivParameterSpec);
                return cipher.doFinal(bArr);
            } catch (Throwable th) {
                Log.a(th);
                return bArr2;
            }
        }

        private String a(String str) {
            int length = 16 - (str.getBytes().length % 16);
            for (int i = 0; i < length; i++) {
                str = str + ' ';
            }
            return str;
        }
    }
}
