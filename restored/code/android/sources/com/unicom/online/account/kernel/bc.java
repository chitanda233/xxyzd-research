package com.unicom.online.account.kernel;

import java.security.Provider;
import javax.crypto.Cipher;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;
import org.bouncycastle.jce.provider.BouncyCastleProvider;

/* JADX INFO: loaded from: classes4.dex */
public final class bc {
    public static BouncyCastleProvider b;

    public static byte[] b(byte[] bArr, byte[] bArr2, byte[] bArr3, int i) throws bd {
        if (bArr == null || bArr.length != 16) {
            throw new bd(16);
        }
        if (bArr3 == null) {
            throw new bd(10);
        }
        if (bArr2 == null) {
            throw new bd(17);
        }
        if (i == 1) {
            if (bArr3.length <= 0) {
                throw new bd(14);
            }
        } else if (bArr3.length <= 0 || bArr3.length % 16 != 0) {
            throw new bd(15);
        }
        if (bArr2.length != 16) {
            throw new bd(17);
        }
        new SecretKeySpec(bArr, "SM4");
        IvParameterSpec ivParameterSpec = new IvParameterSpec(bArr2);
        try {
            Cipher cipher = Cipher.getInstance("SM4/CBC/PKCS5Padding", (Provider) b);
            cipher.init(i, new SecretKeySpec(bArr, "SM4"), ivParameterSpec);
            return cipher.doFinal(bArr3);
        } catch (Exception e) {
            if (i == 1) {
                throw new bd(8, e);
            }
            throw new bd(9, e);
        }
    }
}
