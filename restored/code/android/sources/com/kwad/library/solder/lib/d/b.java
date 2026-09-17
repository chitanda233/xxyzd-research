package com.kwad.library.solder.lib.d;

import com.baidu.mobads.sdk.internal.bz;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import kotlin.UByte;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public static String getMD5(String str) {
        try {
            MessageDigest messageDigest = MessageDigest.getInstance(bz.f456a);
            messageDigest.update(str.getBytes());
            return j(messageDigest.digest());
        } catch (NoSuchAlgorithmException unused) {
            return String.valueOf(str.hashCode());
        }
    }

    private static String j(byte[] bArr) {
        StringBuilder sb = new StringBuilder();
        for (byte b : bArr) {
            String hexString = Integer.toHexString(b & UByte.MAX_VALUE);
            if (hexString.length() == 1) {
                sb.append('0');
            }
            sb.append(hexString);
        }
        return sb.toString();
    }
}
