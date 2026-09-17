package com.unicom.online.account.kernel;

import java.nio.charset.Charset;
import kotlin.UByte;
import org.bouncycastle.crypto.digests.SM3Digest;

/* JADX INFO: loaded from: classes4.dex */
public abstract class bb {
    public static String b(String str) {
        SM3Digest sM3Digest = new SM3Digest();
        byte[] bytes = str.getBytes(Charset.forName("UTF-8"));
        sM3Digest.update(bytes, 0, bytes.length);
        int digestSize = sM3Digest.getDigestSize();
        byte[] bArr = new byte[digestSize];
        sM3Digest.doFinal(bArr, 0);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < digestSize; i++) {
            String hexString = Integer.toHexString(bArr[i] & UByte.MAX_VALUE);
            if (hexString.length() == 1) {
                hexString = "0".concat(hexString);
            }
            sb.append(hexString);
        }
        return sb.toString();
    }
}
