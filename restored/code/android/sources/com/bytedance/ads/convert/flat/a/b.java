package com.bytedance.ads.convert.flat.a;

import android.content.Context;
import android.net.Network;
import com.alipay.sdk.app.AlipayApi;
import com.baidu.mobads.sdk.internal.bz;
import com.czhj.sdk.common.Constants;
import java.io.UnsupportedEncodingException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.UUID;
import java.util.concurrent.CountDownLatch;
import java.util.concurrent.TimeUnit;
import kotlin.jvm.internal.Intrinsics;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public final class b extends com.bytedance.ads.convert.flat.a.a {
    /* JADX WARN: 'super' call moved to the top of the method (can break code semantics) */
    public b(e config) {
        super(config);
        Intrinsics.checkNotNullParameter(config, "config");
    }

    @Override // com.bytedance.ads.convert.flat.a.a
    public i a(Context context, Network network) throws InterruptedException {
        String strA;
        Intrinsics.checkNotNullParameter(context, "context");
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put(AlipayApi.c, "300012449765");
            jSONObject.put("version", "1.0");
            long jCurrentTimeMillis = System.currentTimeMillis();
            SimpleDateFormat simpleDateFormat = new SimpleDateFormat("yyyyMMddHHmmssSSS");
            Calendar calendar = Calendar.getInstance();
            calendar.setTimeInMillis(jCurrentTimeMillis);
            String str = simpleDateFormat.format(calendar.getTime());
            jSONObject.put(com.alipay.sdk.m.x.a.k, str);
            jSONObject.put(com.alipay.sdk.m.w.a.t, "90E4DEDAD9B1CB57EA1538871ED468A7");
            jSONObject.put("businessType", "3");
            String string = UUID.randomUUID().toString();
            jSONObject.put("traceId", string);
            jSONObject.put("msgId", string);
            String str2 = "3000124497653" + string + str + string + "1.090E4DEDAD9B1CB57EA1538871ED468A7";
            byte[] bArr = com.bytedance.ads.convert.flat.c.a.f1685a;
            try {
                strA = com.bytedance.ads.convert.flat.c.a.a(MessageDigest.getInstance(bz.f456a).digest(str2.getBytes("utf-8")));
            } catch (UnsupportedEncodingException | NoSuchAlgorithmException unused) {
                strA = null;
            }
            jSONObject.put("sign", strA);
        } catch (JSONException unused2) {
        }
        String string2 = jSONObject.toString();
        CountDownLatch countDownLatch = new CountDownLatch(1);
        com.bytedance.ads.convert.flat.c.b.a(network, "https://msg.cmpassport.com/h5/getMobile", string2, new a(context, countDownLatch));
        countDownLatch.await(5000L, TimeUnit.MICROSECONDS);
        return this.b;
    }

    @Override // com.bytedance.ads.convert.flat.a.a
    public String a() {
        return "1";
    }

    public static final class a implements com.bytedance.ads.convert.flat.c.b.a {
        public final /* synthetic */ Context b;
        public final /* synthetic */ CountDownLatch c;

        public a(Context context, CountDownLatch countDownLatch) {
            this.b = context;
            this.c = countDownLatch;
        }

        @Override // com.bytedance.ads.convert.flat.c.b.a
        public void a() {
            this.c.countDown();
            b.this.b.b = "51128";
            this.c.countDown();
        }

        @Override // com.bytedance.ads.convert.flat.c.b.a
        public void a(String response) {
            String string;
            Intrinsics.checkNotNullParameter(response, "response");
            String str = "";
            try {
                JSONObject jSONObject = new JSONObject(response).getJSONObject("body");
                string = jSONObject.getString("resultCode");
                Intrinsics.checkNotNullExpressionValue(string, "responseBody.getString(\"resultCode\")");
                if (Intrinsics.areEqual("103000", string)) {
                    String string2 = jSONObject.getString(Constants.TOKEN);
                    Intrinsics.checkNotNullExpressionValue(string2, "responseBody.getString(\"token\")");
                    string = "01128";
                    str = string2;
                }
            } catch (Exception unused) {
                string = "51128";
            }
            i iVar = b.this.b;
            iVar.f1684a = str;
            iVar.b = string;
            iVar.d = "1";
            iVar.c = "1";
            iVar.e = 0;
            iVar.g = System.currentTimeMillis();
            this.c.countDown();
        }
    }
}
