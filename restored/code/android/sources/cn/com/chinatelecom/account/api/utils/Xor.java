package cn.com.chinatelecom.account.api.utils;

import com.sigmob.sdk.archives.tar.e;

/* JADX INFO: loaded from: classes.dex */
public class Xor {
    private static final String TAG = "Xor";
    private static byte[] keyBytes = {68, 64, 94, e.I, 69, 35, e.J, e.Q};

    public static String de(byte[] bArr) {
        try {
            int length = bArr.length;
            byte[] bArr2 = new byte[length];
            for (int i = 0; i < length; i++) {
                bArr2[i] = bArr[i];
                for (byte b : keyBytes) {
                    bArr2[i] = (byte) (b ^ bArr2[i]);
                }
            }
            return new String(bArr2);
        } catch (Throwable th) {
            th.printStackTrace();
            return "";
        }
    }
}
