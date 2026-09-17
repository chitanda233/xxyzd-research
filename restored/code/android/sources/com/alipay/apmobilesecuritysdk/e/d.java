package com.alipay.apmobilesecuritysdk.e;

import android.content.Context;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class d {
    private static c a(String str) {
        try {
            if (!com.alipay.sdk.m.d0.a.a(str)) {
                JSONObject jSONObject = new JSONObject(str);
                return new c(jSONObject.optString("apdid"), jSONObject.optString("deviceInfoHash"), jSONObject.optString(com.alipay.sdk.m.x.a.k), jSONObject.optString("tid"), jSONObject.optString(com.alipay.sdk.m.n.b.g));
            }
        } catch (Exception e) {
            com.alipay.apmobilesecuritysdk.c.a.a(e);
        }
        return null;
    }

    public static synchronized void a(Context context) {
        com.alipay.apmobilesecuritysdk.f.a.a(context, "vkeyid_profiles_v4", "key_deviceid_v4", "");
        com.alipay.apmobilesecuritysdk.f.a.a("wxcasxx_v4", "key_wxcasxx_v4", "");
    }

    public static synchronized void a(Context context, c cVar) {
        try {
            JSONObject jSONObject = new JSONObject();
            jSONObject.put("apdid", cVar.f203a);
            jSONObject.put("deviceInfoHash", cVar.b);
            jSONObject.put(com.alipay.sdk.m.x.a.k, cVar.c);
            jSONObject.put("tid", cVar.d);
            jSONObject.put(com.alipay.sdk.m.n.b.g, cVar.e);
            String string = jSONObject.toString();
            com.alipay.apmobilesecuritysdk.f.a.a(context, "vkeyid_profiles_v4", "key_deviceid_v4", string);
            com.alipay.apmobilesecuritysdk.f.a.a("wxcasxx_v4", "key_wxcasxx_v4", string);
        } catch (Exception e) {
            com.alipay.apmobilesecuritysdk.c.a.a(e);
        }
    }

    public static synchronized void b(Context context) {
    }

    public static synchronized c c(Context context) {
        String strA;
        strA = com.alipay.apmobilesecuritysdk.f.a.a(context, "vkeyid_profiles_v4", "key_deviceid_v4");
        if (com.alipay.sdk.m.d0.a.a(strA)) {
            strA = com.alipay.apmobilesecuritysdk.f.a.a("wxcasxx_v4", "key_wxcasxx_v4");
        }
        return a(strA);
    }

    public static synchronized c d(Context context) {
        String strA = com.alipay.apmobilesecuritysdk.f.a.a(context, "vkeyid_profiles_v4", "key_deviceid_v4");
        if (com.alipay.sdk.m.d0.a.a(strA)) {
            return null;
        }
        return a(strA);
    }

    public static synchronized c e(Context context) {
        String strA = com.alipay.apmobilesecuritysdk.f.a.a("wxcasxx_v4", "key_wxcasxx_v4");
        if (com.alipay.sdk.m.d0.a.a(strA)) {
            return null;
        }
        return a(strA);
    }
}
