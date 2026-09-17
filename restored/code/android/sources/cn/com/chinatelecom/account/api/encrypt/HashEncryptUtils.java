package cn.com.chinatelecom.account.api.encrypt;

import java.io.FileInputStream;

/* JADX INFO: loaded from: classes.dex */
public class HashEncryptUtils {
    public static String hashEncryption(String str) {
        return SHA_256.encryptSHA256(str);
    }

    public static String hashEncryption(FileInputStream fileInputStream) {
        return SHA_256.encryptSHA256(fileInputStream);
    }

    public static String hmacHashEncryption(String str, String str2) {
        return SHA_256.encryptHMACSHA256(str, str2);
    }
}
