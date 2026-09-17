package com.qq.gdt.action.i;

import java.security.NoSuchAlgorithmException;
import java.security.SecureRandom;
import java.security.spec.InvalidKeySpecException;
import javax.crypto.Cipher;
import javax.crypto.SecretKey;
import javax.crypto.SecretKeyFactory;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.PBEKeySpec;
import javax.crypto.spec.SecretKeySpec;

/* JADX INFO: loaded from: classes3.dex */
public class a {
    public static String a(SecretKey secretKey, byte[] bArr) throws Exception {
        return i.a(b(secretKey, bArr));
    }

    public static SecretKey a(String str) throws InvalidKeySpecException, NoSuchAlgorithmException {
        byte[] bArr = new byte[32];
        new SecureRandom().nextBytes(bArr);
        return new SecretKeySpec(SecretKeyFactory.getInstance("PBKDF2WithHmacSHA1").generateSecret(new PBEKeySpec(str.toCharArray(), bArr, 1000, 256)).getEncoded(), "AES");
    }

    public static byte[] b(SecretKey secretKey, byte[] bArr) throws Exception {
        Cipher cipher = Cipher.getInstance("AES");
        cipher.init(1, secretKey, new IvParameterSpec(new byte[cipher.getBlockSize()]));
        return cipher.doFinal(bArr);
    }
}
