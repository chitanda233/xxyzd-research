package com.cmic.gen.sdk.f;

import android.content.Context;
import android.security.keystore.KeyGenParameterSpec;
import android.text.TextUtils;
import android.util.Base64;
import java.security.Key;
import java.security.KeyStore;
import java.security.PrivateKey;
import java.security.PublicKey;
import java.util.HashMap;
import javax.crypto.Cipher;
import javax.crypto.KeyGenerator;
import javax.crypto.SecretKey;
import javax.crypto.spec.IvParameterSpec;

/* JADX INFO: compiled from: KeystoreUtil.java */
/* JADX INFO: loaded from: classes2.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static byte[] f2118a;

    public static boolean a(Context context, boolean z) {
        try {
            KeyStore keyStore = KeyStore.getInstance("AndroidKeyStore");
            keyStore.load(null);
            if (keyStore.getKey("CMCC_SDK_V1", null) != null) {
                return true;
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        if (z) {
            return b(context);
        }
        return false;
    }

    private static boolean b(Context context) {
        try {
            KeyGenerator keyGenerator = KeyGenerator.getInstance("AES", "AndroidKeyStore");
            keyGenerator.init(new KeyGenParameterSpec.Builder("CMCC_SDK_V1", 3).setDigests("SHA-256", "SHA-512").setBlockModes("CBC").setEncryptionPaddings("PKCS7Padding").setRandomizedEncryptionRequired(false).setKeySize(256).build());
            Thread.sleep(1000L);
            keyGenerator.generateKey();
            return true;
        } catch (Exception e) {
            c.a("KeystoreUtil", e.getMessage());
            return false;
        }
    }

    static String a(Context context, String str) {
        byte[] bArrA = a(context);
        if (bArrA != null) {
            return a.a(bArrA, str, f2118a);
        }
        a();
        return null;
    }

    static String b(Context context, String str) {
        byte[] bArrA = a(context);
        if (bArrA != null) {
            return a.a(bArrA, str, f2118a);
        }
        a();
        return null;
    }

    static String c(Context context, String str) {
        if (TextUtils.isEmpty(str)) {
            return null;
        }
        byte[] bArrA = a(context);
        if (bArrA != null) {
            return a.b(bArrA, str, f2118a);
        }
        a();
        return null;
    }

    public static synchronized byte[] a(Context context) {
        Cipher cipher;
        byte[] bArrDoFinal;
        Cipher cipher2;
        try {
            KeyStore keyStore = KeyStore.getInstance("AndroidKeyStore");
            keyStore.load(null);
            if (!a(context, false)) {
                return null;
            }
            String strB = b();
            boolean z = true;
            if (TextUtils.isEmpty(strB)) {
                bArrDoFinal = r.a();
                f2118a = r.a();
                Key key = keyStore.getKey("CMCC_SDK_V1", null);
                if (key instanceof SecretKey) {
                    c.b("KeystoreUtil", "随机生成aes秘钥");
                    cipher2 = Cipher.getInstance("AES/CBC/PKCS7Padding");
                    cipher2.init(1, key, new IvParameterSpec(f2118a));
                } else {
                    if (!(key instanceof PrivateKey)) {
                        return null;
                    }
                    PublicKey publicKey = keyStore.getCertificate("CMCC_SDK_V1").getPublicKey();
                    cipher2 = Cipher.getInstance("RSA/ECB/OAEPWithSHA256AndMGF1Padding");
                    c.b("KeystoreUtil", "生成rsa密");
                    cipher2.init(1, publicKey);
                }
                String strEncodeToString = Base64.encodeToString(cipher2.doFinal(bArrDoFinal), 0);
                String strEncodeToString2 = Base64.encodeToString(f2118a, 0);
                HashMap map = new HashMap();
                map.put("AES_IV", strEncodeToString2);
                map.put("AES_KEY", strEncodeToString);
                l.a(map);
            } else {
                f2118a = Base64.decode(c(), 0);
                byte[] bArrDecode = Base64.decode(strB, 0);
                Key key2 = keyStore.getKey("CMCC_SDK_V1", null);
                if (key2 == null) {
                    return null;
                }
                if (key2 instanceof SecretKey) {
                    cipher = Cipher.getInstance("AES/CBC/PKCS7Padding");
                    cipher.init(2, key2, new IvParameterSpec(f2118a));
                    c.b("KeystoreUtil", "使用aes");
                } else {
                    if (!(key2 instanceof PrivateKey)) {
                        return null;
                    }
                    cipher = Cipher.getInstance("RSA/ECB/OAEPWithSHA256AndMGF1Padding");
                    cipher.init(2, key2);
                    c.b("KeystoreUtil", "使用rsa");
                }
                bArrDoFinal = cipher.doFinal(bArrDecode);
                StringBuilder sb = new StringBuilder("是否解密出秘钥：");
                if (TextUtils.isEmpty(Base64.encodeToString(bArrDoFinal, 0))) {
                    z = false;
                }
                c.b("KeystoreUtil", sb.append(z).toString());
            }
            c.b("KeystoreUtil", "是否解密出秘钥：" + Base64.encodeToString(bArrDoFinal, 0));
            return bArrDoFinal;
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
        throw th;
    }

    public static void a() {
        l.a("AES_KEY");
    }

    private static String b() {
        return l.b("AES_KEY", "");
    }

    private static String c() {
        return l.b("AES_IV", "");
    }
}
