package cn.com.chinatelecom.account.api.encrypt;

import android.util.Log;
import com.alipay.sdk.m.y.l;
import com.sigmob.sdk.archives.tar.e;
import java.nio.charset.Charset;

/* JADX INFO: loaded from: classes.dex */
public class Xor {
    private static final String TAG = "Xor";
    private static final Charset charset = Charset.forName("UTF-8");
    private static byte[] keyBytes = {68, 64, 94, e.I, e.J, e.Q};

    public static byte[] encode(String str) {
        byte[] bytes = str.getBytes(charset);
        int length = bytes.length;
        for (int i = 0; i < length; i++) {
            for (byte b : keyBytes) {
                bytes[i] = (byte) (b ^ bytes[i]);
            }
        }
        return bytes;
    }

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

    private static String genXorStr(String str) {
        StringBuffer stringBuffer = new StringBuffer("{");
        byte[] bArrEncode = encode(str);
        for (int i = 0; i < bArrEncode.length; i++) {
            if (i != 0) {
                stringBuffer.append(",");
            }
            stringBuffer.append((int) bArrEncode[i]);
        }
        stringBuffer.append(l.d);
        return stringBuffer.toString();
    }

    public static void textXor() {
        String[] strArr = {"189"};
        String str = TAG;
        Log.i(str, "// " + strArr[0]);
        Log.i(str, "public static final byte[] net_params0 = " + genXorStr(strArr[0]) + l.b);
    }
}
