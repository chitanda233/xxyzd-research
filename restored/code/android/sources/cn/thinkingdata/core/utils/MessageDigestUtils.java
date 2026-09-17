package cn.thinkingdata.core.utils;

import com.baidu.mobads.sdk.internal.bz;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

/* JADX INFO: loaded from: classes.dex */
public class MessageDigestUtils {
    public static String calculateMD5(String str) {
        if (str == null) {
            return "";
        }
        try {
            return new String(Base64Coder.encode(MessageDigest.getInstance(bz.f456a).digest(str.getBytes())));
        } catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
            return "";
        }
    }

    public static String calculateSHA256(String str) {
        if (str == null) {
            return "";
        }
        try {
            return new String(Base64Coder.encode(MessageDigest.getInstance("SHA-256").digest(str.getBytes())));
        } catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
            return "";
        }
    }
}
