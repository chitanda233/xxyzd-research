package com.unicom.online.account.kernel;

import javax.crypto.Cipher;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;

/* JADX INFO: loaded from: classes4.dex */
public abstract class b {
    public static String b(String str, String str2, String str3) throws Exception {
        if (str == null) {
            return null;
        }
        try {
            if (str.length() != 0 && str.trim().length() != 0) {
                if (str2 == null) {
                    throw new Exception("decrypt key is null");
                }
                if (str2.length() != 16) {
                    throw new Exception("decrypt key length error");
                }
                if (str3.length() != 16) {
                    throw new Exception(" iv decrypt key length error");
                }
                byte[] bArrB = aq.b(str);
                Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");
                cipher.init(2, new SecretKeySpec(str2.getBytes("utf-8"), "AES"), new IvParameterSpec(str3.getBytes("utf-8")));
                return new String(cipher.doFinal(bArrB), "utf-8");
            }
            return null;
        } catch (Exception e) {
            throw new Exception("decrypt error", e);
        }
    }

    public static String c(String str, String str2, String str3) throws Exception {
        if (str == null) {
            return null;
        }
        try {
            if (str.length() != 0 && str.trim().length() != 0) {
                if (str2 == null) {
                    throw new Exception("encrypt key is null");
                }
                if (str2.length() != 16) {
                    throw new Exception("encrypt key length error");
                }
                if (str3.length() != 16) {
                    throw new Exception(" iv encrypt key length error");
                }
                Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");
                cipher.init(1, new SecretKeySpec(str2.getBytes("utf-8"), "AES"), new IvParameterSpec(str3.getBytes("utf-8")));
                return aq.b(cipher.doFinal(str.getBytes("utf-8")));
            }
            return null;
        } catch (Exception e) {
            throw new Exception("Encrypt error", e);
        }
    }
}
