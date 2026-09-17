package com.byazt.dbo;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 961, 15})
public class uj {
    public static JSONObject c(String str, String str2) {
        JSONObject jSONObject = new JSONObject();
        try {
            int iCurrentTimeMillis = (int) (System.currentTimeMillis() / 1000);
            StringBuilder sb = new StringBuilder("id=");
            sb.append(str).append("&timestamp=");
            sb.append(iCurrentTimeMillis).append("&ext=");
            sb.append(str2);
            String upperCase = com.byazt.nr.a.tt(sb.toString()).toUpperCase();
            jSONObject.put("id", str);
            jSONObject.put(com.alipay.sdk.m.x.a.k, iCurrentTimeMillis);
            jSONObject.put("sign", upperCase);
            jSONObject.put(com.sigmob.sdk.base.n.m, str2);
        } catch (Exception unused) {
        }
        return jSONObject;
    }
}
