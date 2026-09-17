package com.tencent.turingfd.sdk.ams.ad;

import android.util.Base64;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.StringWriter;
import java.security.cert.Certificate;
import java.security.cert.X509Certificate;
import org.json.JSONObject;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.return, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public abstract class Creturn {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3958a = Cinstanceof.a(Cinstanceof.Q0);
    public static final String b = Cinstanceof.a(Cinstanceof.M0);
    public static final String c = Cinstanceof.a(Cinstanceof.N0);
    public static final String d = Cinstanceof.a(Cinstanceof.O0);
    public static final /* synthetic */ boolean e = true;

    public static String a(Certificate certificate) throws IOException {
        StringWriter stringWriter = new StringWriter();
        BufferedWriter bufferedWriter = new BufferedWriter(stringWriter);
        bufferedWriter.write("-----BEGIN CERTIFICATE-----");
        bufferedWriter.write("\n");
        byte[] bArrEncode = Base64.encode(certificate.getEncoded(), 2);
        char[] cArr = new char[64];
        for (int i = 0; i < bArrEncode.length; i += 64) {
            int i2 = 0;
            while (i2 != 64) {
                int i3 = i + i2;
                if (i3 >= bArrEncode.length) {
                    break;
                }
                cArr[i2] = (char) bArrEncode[i3];
                i2++;
            }
            bufferedWriter.write(cArr, 0, i2);
            bufferedWriter.write("\n");
        }
        bufferedWriter.write("-----END CERTIFICATE-----");
        bufferedWriter.write("\n");
        bufferedWriter.close();
        return stringWriter.toString();
    }

    public static void a(X509Certificate x509Certificate, Strawberry strawberry) throws Exception {
        byte[] extensionValue = x509Certificate.getExtensionValue(f3958a);
        if (extensionValue != null && extensionValue.length != 0) {
            try {
                byte b2 = "{".getBytes()[0];
                byte b3 = com.alipay.sdk.m.y.l.d.getBytes()[0];
                int i = 0;
                int i2 = 0;
                for (int i3 = 0; i3 < extensionValue.length; i3++) {
                    byte b4 = extensionValue[i3];
                    if (b4 == b2) {
                        i = i3;
                    } else if (b4 == b3) {
                        i2 = i3;
                    }
                }
                if (i <= 0 || i >= i2) {
                    return;
                }
                if (!e && extensionValue[i - 1] != (i2 - i) + 1) {
                    throw new AssertionError();
                }
                int i4 = (i2 - i) + 1;
                byte[] bArr = new byte[i4];
                System.arraycopy(extensionValue, i, bArr, 0, i4);
                JSONObject jSONObject = new JSONObject(new String(bArr));
                strawberry.c = jSONObject.getString(c);
                strawberry.b = jSONObject.getInt(d);
                strawberry.f3894a = jSONObject.getLong(b);
                return;
            } catch (Exception e2) {
                throw new Exception("C" + e2.getStackTrace());
            }
        }
        throw new Exception("Couldn't find the keystore attestation extension data.");
    }
}
