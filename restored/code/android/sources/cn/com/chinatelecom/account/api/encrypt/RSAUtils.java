package cn.com.chinatelecom.account.api.encrypt;

import com.alipay.sdk.m.p.d;
import java.security.InvalidKeyException;
import java.security.KeyFactory;
import java.security.NoSuchAlgorithmException;
import java.security.PublicKey;
import java.security.interfaces.RSAPrivateKey;
import java.security.interfaces.RSAPublicKey;
import java.security.spec.X509EncodedKeySpec;
import javax.crypto.BadPaddingException;
import javax.crypto.Cipher;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import kotlin.jvm.internal.ByteCompanionObject;

/* JADX INFO: loaded from: classes.dex */
public class RSAUtils {
    private static String RSAC = "RSA/ECB/PKCS1Padding";
    private static final String publicKeyStr = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC5se07mkN71qsSJHjZ2Z0+Z+4LlLvf2sz7Md38VAa3EmAOvI7vZp3hbAxicL724ylcmisTPtZQhT/9C+25AELqy9PN9JmzKpwoVTUoJvxG4BoyT49+gGVl6s6zo1byNoHUzTfkmRfmC9MC53HvG8GwKP5xtcdptFjAIcgIR7oAWQIDAQAB";

    public static RSAPublicKey getPublicKey() {
        try {
            return (RSAPublicKey) getPublicKey(publicKeyStr);
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    public static PublicKey getPublicKey(String str) throws Exception {
        return KeyFactory.getInstance(d.f334a).generatePublic(new X509EncodedKeySpec(Base64Utils.decode(str)));
    }

    public static String encryptWithHex(String str, RSAPublicKey rSAPublicKey) {
        try {
            return StringUtil.toHex(encrypt(rSAPublicKey, str.getBytes()));
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }

    public static byte[] encrypt(RSAPublicKey rSAPublicKey, byte[] bArr) throws Exception {
        if (rSAPublicKey == null) {
            throw new Exception(Xor.de(new byte[]{-17, ByteCompanionObject.MIN_VALUE, -86, -17, -91, -116, -17, -113, -90, -29, -104, -81, -18, -78, -80, -19, -93, -80, 38, 42, -30, -91, -67, -30, -92, -76, -19, -73, -92}));
        }
        try {
            Cipher cipher = Cipher.getInstance(RSAC);
            cipher.init(1, rSAPublicKey);
            return cipher.doFinal(bArr);
        } catch (InvalidKeyException unused) {
            throw new Exception(Xor.de(new byte[]{-17, ByteCompanionObject.MIN_VALUE, -86, -17, -91, -116, -17, -113, -90, -29, -104, -81, -29, -105, -108, -20, -71, -97, 38, -30, -91, -67, -20, -87, -118, -20, -107, -81}));
        } catch (NoSuchAlgorithmException unused2) {
            throw new Exception(Xor.de(new byte[]{-20, -99, -86, -20, -89, -82, -17, ByteCompanionObject.MIN_VALUE, -86, -17, -91, -116, -19, -92, -99, -20, -71, -97}));
        } catch (BadPaddingException unused3) {
            throw new Exception(Xor.de(new byte[]{-20, -110, -124, -20, -100, -115, -20, -97, -70, -20, -121, -92, -17, -67, -72, -20, -121, -107, -17, -105, -123}));
        } catch (IllegalBlockSizeException unused4) {
            throw new Exception(Xor.de(new byte[]{-20, -110, -124, -20, -100, -115, -29, -97, -75, -17, -80, -84, -29, -105, -108, -20, -71, -97}));
        } catch (NoSuchPaddingException e) {
            e.printStackTrace();
            return null;
        }
    }

    public static byte[] decrypt(RSAPrivateKey rSAPrivateKey, byte[] bArr) throws Exception {
        if (rSAPrivateKey == null) {
            throw new Exception(Xor.de(new byte[]{-30, -83, -87, -17, -91, -116, -19, -83, -117, -29, -104, -81, -18, -78, -80, -19, -93, -80, 38, 42, -30, -91, -67, -30, -92, -76, -19, -73, -92}));
        }
        try {
            Cipher cipher = Cipher.getInstance(RSAC);
            cipher.init(2, rSAPrivateKey);
            return cipher.doFinal(bArr);
        } catch (InvalidKeyException unused) {
            throw new InvalidKeyException(Xor.de(new byte[]{-30, -83, -87, -17, -91, -116, -19, -83, -117, -29, -104, -81, -29, -105, -108, -20, -71, -97, 38, -30, -91, -67, -20, -87, -118, -20, -107, -81}));
        } catch (NoSuchAlgorithmException unused2) {
            throw new NoSuchAlgorithmException(Xor.de(new byte[]{-20, -99, -86, -20, -89, -82, -30, -83, -87, -17, -91, -116, -19, -92, -99, -20, -71, -97}));
        } catch (BadPaddingException unused3) {
            throw new BadPaddingException(Xor.de(new byte[]{-17, -91, -116, -20, -100, -115, -20, -97, -70, -20, -121, -92, -17, -67, -72, -20, -121, -107, -17, -105, -123}));
        } catch (IllegalBlockSizeException unused4) {
            throw new IllegalBlockSizeException(Xor.de(new byte[]{-17, -91, -116, -20, -100, -115, -29, -97, -75, -17, -80, -84, -29, -105, -108, -20, -71, -97}));
        } catch (NoSuchPaddingException unused5) {
            throw new NoSuchPaddingException(Xor.de(new byte[]{-30, -83, -87, -17, -91, -116, -17, -115, -80, -29, -98, -109, -27, -74, -117, -18, -78, -121, -20, -98, -91, -20, -122, -117, -30, -91, -81, -17, -85, -95, -17, -113, -113, -20, -106, -80, -17, -126, -68}));
        }
    }
}
