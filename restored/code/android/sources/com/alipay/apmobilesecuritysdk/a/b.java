package com.alipay.apmobilesecuritysdk.a;

import android.content.Context;
import com.alipay.apmobilesecuritysdk.d.e;
import com.alipay.apmobilesecuritysdk.e.c;
import com.alipay.apmobilesecuritysdk.e.h;
import com.alipay.apmobilesecuritysdk.otherid.UmidSdkWrapper;
import com.alipay.sdk.m.k0.d;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class b {
    public static d a(Context context, Map<String, String> map) {
        d dVar = new d();
        a(context, dVar, map);
        dVar.f = e.a(context, map);
        return dVar;
    }

    private static void a(Context context, d dVar, Map<String, String> map) {
        String str;
        String str2;
        String str3;
        com.alipay.apmobilesecuritysdk.e.b bVarE;
        com.alipay.apmobilesecuritysdk.e.b bVarD;
        String str4 = "";
        String strA = com.alipay.sdk.m.d0.a.a(map, "appName", "");
        String strA2 = com.alipay.sdk.m.d0.a.a(map, "sessionId", "");
        String strA3 = com.alipay.sdk.m.d0.a.a(map, "rpcVersion", "");
        String strA4 = a.a(context, strA);
        String securityToken = UmidSdkWrapper.getSecurityToken(context);
        String strD = h.d(context);
        if (com.alipay.sdk.m.d0.a.b(strA2)) {
            dVar.c = strA2;
        } else {
            dVar.c = strA4;
        }
        dVar.d = securityToken;
        dVar.e = strD;
        dVar.f305a = "android";
        c cVarD = com.alipay.apmobilesecuritysdk.e.d.d(context);
        if (cVarD != null) {
            str2 = cVarD.f203a;
            str = cVarD.c;
        } else {
            str = "";
            str2 = str;
        }
        if (com.alipay.sdk.m.d0.a.a(str2) && (bVarD = com.alipay.apmobilesecuritysdk.e.a.d(context)) != null) {
            str2 = bVarD.f202a;
            str = bVarD.c;
        }
        c cVarE = com.alipay.apmobilesecuritysdk.e.d.e(context);
        if (cVarE != null) {
            str4 = cVarE.f203a;
            str3 = cVarE.c;
        } else {
            str3 = "";
        }
        if (com.alipay.sdk.m.d0.a.a(str4) && (bVarE = com.alipay.apmobilesecuritysdk.e.a.e(context)) != null) {
            str4 = bVarE.f202a;
            str3 = bVarE.c;
        }
        dVar.h = str2;
        dVar.g = str4;
        dVar.j = strA3;
        if (com.alipay.sdk.m.d0.a.a(str2)) {
            dVar.b = str4;
            dVar.i = str3;
        } else {
            dVar.b = str2;
            dVar.i = str;
        }
    }
}
