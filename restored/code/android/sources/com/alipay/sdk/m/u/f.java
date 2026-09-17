package com.alipay.sdk.m.u;

import android.content.Context;
import java.nio.charset.Charset;
import java.util.HashMap;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class f extends com.alipay.sdk.m.t.e {
    @Override // com.alipay.sdk.m.t.e
    public String a(com.alipay.sdk.m.w.a aVar, String str, JSONObject jSONObject) {
        return str;
    }

    @Override // com.alipay.sdk.m.t.e
    public Map<String, String> a(boolean z, String str) {
        return new HashMap();
    }

    @Override // com.alipay.sdk.m.t.e
    public JSONObject a() {
        return null;
    }

    @Override // com.alipay.sdk.m.t.e
    public boolean c() {
        return false;
    }

    @Override // com.alipay.sdk.m.t.e
    public com.alipay.sdk.m.t.b a(com.alipay.sdk.m.w.a aVar, Context context, String str) throws Throwable {
        com.alipay.sdk.m.y.g.d(com.alipay.sdk.m.n.a.B, "mdap post");
        byte[] bArrA = com.alipay.sdk.m.p.b.a(str.getBytes(Charset.forName("UTF-8")));
        HashMap map = new HashMap();
        map.put("utdId", com.alipay.sdk.m.w.b.c().d());
        map.put("logHeader", "RAW");
        map.put("bizCode", com.alipay.sdk.m.y.g.b);
        map.put("productId", "alipaysdk_android");
        map.put("Content-Encoding", "Gzip");
        map.put("productVersion", "15.8.42");
        com.alipay.sdk.m.s.b.C0051b c0051bA = com.alipay.sdk.m.s.b.a(context, new com.alipay.sdk.m.s.b.a(com.alipay.sdk.m.n.a.f, map, bArrA));
        com.alipay.sdk.m.y.g.d(com.alipay.sdk.m.n.a.B, "mdap got " + c0051bA);
        if (c0051bA == null) {
            throw new RuntimeException("Response is null");
        }
        boolean zA = com.alipay.sdk.m.t.e.a(c0051bA);
        try {
            byte[] bArrB = c0051bA.c;
            if (zA) {
                bArrB = com.alipay.sdk.m.p.b.b(bArrB);
            }
            return new com.alipay.sdk.m.t.b("", new String(bArrB, Charset.forName("UTF-8")));
        } catch (Exception e) {
            com.alipay.sdk.m.y.g.a(e);
            return null;
        }
    }
}
