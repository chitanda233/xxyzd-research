package cn.com.chinatelecom.account.api.encrypt;

import androidx.core.view.InputDeviceCompat;

/* JADX INFO: loaded from: classes.dex */
public class StringUtil {
    private static final char[] HEX = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

    public static String toHex(byte[] bArr) {
        if (bArr == null || bArr.length == 0) {
            return "";
        }
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < bArr.length; i++) {
            char[] cArr = HEX;
            sb.append(cArr[(bArr[i] >> 4) & 15]).append(cArr[bArr[i] & 15]);
        }
        return sb.toString();
    }

    public static byte[] hexToBytes(String str) {
        if (str == null) {
            return null;
        }
        char[] charArray = str.toCharArray();
        int length = charArray.length / 2;
        byte[] bArr = new byte[length];
        for (int i = 0; i < length; i++) {
            int i2 = i * 2;
            int iDigit = Character.digit(charArray[i2 + 1], 16) | (Character.digit(charArray[i2], 16) << 4);
            if (iDigit > 127) {
                iDigit += InputDeviceCompat.SOURCE_ANY;
            }
            bArr[i] = (byte) iDigit;
        }
        return bArr;
    }

    public static byte[] getBytes(String str) {
        byte[] bArr = new byte[0];
        try {
            return str.getBytes("UTF-8");
        } catch (Exception e) {
            e.printStackTrace();
            return bArr;
        }
    }
}
