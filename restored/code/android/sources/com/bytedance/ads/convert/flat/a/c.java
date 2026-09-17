package com.bytedance.ads.convert.flat.a;

import android.content.Context;
import android.net.Network;
import android.util.Base64;
import android.util.Log;
import com.alipay.sdk.app.AlipayApi;
import com.alipay.sdk.m.y.o;
import java.nio.charset.StandardCharsets;
import java.security.InvalidKeyException;
import java.security.KeyFactory;
import java.security.KeyPairGenerator;
import java.security.NoSuchAlgorithmException;
import java.security.SecureRandom;
import java.security.interfaces.RSAPublicKey;
import java.security.spec.X509EncodedKeySpec;
import java.util.Iterator;
import java.util.concurrent.CountDownLatch;
import java.util.concurrent.TimeUnit;
import javax.crypto.Cipher;
import javax.crypto.Mac;
import javax.crypto.spec.SecretKeySpec;
import kotlin.jvm.internal.Intrinsics;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public final class c extends com.bytedance.ads.convert.flat.a.a {
    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public c(e config) {
        super(config);
        Intrinsics.checkNotNullParameter(config, "config");
    }

    @Override // com.bytedance.ads.convert.flat.a.a
    public i a(Context context, Network network) throws InterruptedException {
        String strSubstring;
        String string;
        String strA;
        String strA2;
        Intrinsics.checkNotNullParameter(context, "context");
        byte[] bArr = com.bytedance.ads.convert.flat.c.a.f1685a;
        try {
            KeyPairGenerator keyPairGenerator = KeyPairGenerator.getInstance(com.alipay.sdk.m.p.d.f334a);
            keyPairGenerator.initialize(1024, new SecureRandom());
            strSubstring = Base64.encodeToString(keyPairGenerator.generateKeyPair().getPrivate().getEncoded(), 0).substring(0, 16);
        } catch (NoSuchAlgorithmException unused) {
            strSubstring = "";
        }
        StringBuilder sbAppend = new StringBuilder("https://id6.me/gw/preuniq.do").append("?");
        try {
            JSONObject jSONObject = new JSONObject();
            jSONObject.put(AlipayApi.c, "9386206798");
            jSONObject.put("clientType", "Android-30100");
            jSONObject.put("format", "json");
            jSONObject.put("version", "v1.5");
            byte[] bytes = strSubstring.getBytes();
            byte[] bArr2 = com.bytedance.ads.convert.flat.c.a.f1685a;
            try {
                RSAPublicKey rSAPublicKey = (RSAPublicKey) KeyFactory.getInstance(com.alipay.sdk.m.p.d.f334a).generatePublic(new X509EncodedKeySpec(Base64.decode("MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC5se07mkN71qsSJHjZ2Z0+Z+4LlLvf2sz7Md38VAa3EmAOvI7vZp3hbAxicL724ylcmisTPtZQhT/9C+25AELqy9PN9JmzKpwoVTUoJvxG4BoyT49+gGVl6s6zo1byNoHUzTfkmRfmC9MC53HvG8GwKP5xtcdptFjAIcgIR7oAWQIDAQAB", 0)));
                Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1PADDING");
                cipher.init(1, rSAPublicKey);
                strA = com.bytedance.ads.convert.flat.c.a.a(cipher.doFinal(bytes));
            } catch (Exception unused2) {
                strA = null;
            }
            jSONObject.put("paramKey", strA);
            String strA3 = com.bytedance.ads.convert.flat.c.a.a(true, ("timeStamp=" + System.currentTimeMillis()).getBytes(), strSubstring);
            jSONObject.put("paramStr", strA3);
            String[] strArr = {"9386206798", "Android-30100", "json", strA, strA3, "v1.5"};
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 6; i++) {
                sb.append(strArr[i]);
            }
            String string2 = sb.toString();
            try {
                SecretKeySpec secretKeySpec = new SecretKeySpec("tgIBkg304BUpjGHLSq1wYYb0Xs77pMIm".getBytes(StandardCharsets.UTF_8), "HmacSHA1");
                Mac mac = Mac.getInstance("HmacSHA1");
                mac.init(secretKeySpec);
                strA2 = com.bytedance.ads.convert.flat.c.a.a(mac.doFinal(string2.getBytes(StandardCharsets.UTF_8)));
            } catch (InvalidKeyException | NoSuchAlgorithmException e) {
                e.printStackTrace();
                strA2 = null;
            }
            jSONObject.put("sign", strA2);
            Iterator<String> itKeys = jSONObject.keys();
            while (itKeys.hasNext()) {
                String next = itKeys.next();
                sbAppend.append(next).append("=").append(jSONObject.getString(next)).append(com.alipay.sdk.m.w.a.p);
            }
            sbAppend.deleteCharAt(sbAppend.length() - 1);
            string = sbAppend.toString();
        } catch (Exception e2) {
            Log.d("RequestBodyUtils", e2.getMessage());
            string = null;
        }
        CountDownLatch countDownLatch = new CountDownLatch(1);
        com.bytedance.ads.convert.flat.c.b.a(network, string, null, new a(strSubstring, context, countDownLatch));
        countDownLatch.await(5000L, TimeUnit.MICROSECONDS);
        return this.b;
    }

    @Override // com.bytedance.ads.convert.flat.a.a
    public String a() {
        return "2";
    }

    public static final class a implements com.bytedance.ads.convert.flat.c.b.a {
        public final /* synthetic */ String b;
        public final /* synthetic */ Context c;
        public final /* synthetic */ CountDownLatch d;

        public a(String str, Context context, CountDownLatch countDownLatch) {
            this.b = str;
            this.c = context;
            this.d = countDownLatch;
        }

        @Override // com.bytedance.ads.convert.flat.c.b.a
        public void a() {
            c.this.b.b = "51128";
            this.d.countDown();
        }

        @Override // com.bytedance.ads.convert.flat.c.b.a
        public void a(String response) {
            String strValueOf;
            Intrinsics.checkNotNullParameter(response, "response");
            String str = "";
            try {
                JSONObject jSONObject = new JSONObject(response);
                strValueOf = String.valueOf(jSONObject.getInt(o.c));
                if (Intrinsics.areEqual("0", strValueOf)) {
                    String string = jSONObject.getString("data");
                    byte[] bArr = com.bytedance.ads.convert.flat.c.a.f1685a;
                    if (string.length() % 2 != 0) {
                        string = "0" + string;
                    }
                    int length = string.length() / 2;
                    byte[] bArr2 = new byte[length];
                    for (int i = 0; i < length; i++) {
                        int i2 = i * 2;
                        bArr2[i] = (byte) Integer.parseInt(string.substring(i2, i2 + 2), 16);
                    }
                    String string2 = new JSONObject(com.bytedance.ads.convert.flat.c.a.a(false, bArr2, this.b)).getString("accessCode");
                    Intrinsics.checkNotNullExpressionValue(string2, "data.getString(\"accessCode\")");
                    str = string2;
                    strValueOf = "01128";
                }
            } catch (Exception unused) {
                strValueOf = "51128";
            }
            i iVar = c.this.b;
            iVar.f1684a = str;
            iVar.b = strValueOf;
            iVar.d = "2";
            iVar.c = "2";
            iVar.e = 0;
            iVar.g = System.currentTimeMillis();
            this.d.countDown();
        }
    }
}
