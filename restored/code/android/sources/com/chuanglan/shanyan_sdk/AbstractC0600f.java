package com.chuanglan.shanyan_sdk;

import android.content.Context;
import com.czhj.sdk.common.Constants;
import java.util.Random;
import org.json.JSONObject;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.f, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0600f {
    public static boolean a(int i) {
        return new Random().nextInt(100) < i;
    }

    public static boolean b(String str) {
        return (str == null || "null".equals(str) || "".equals(str)) ? false : true;
    }

    public static String c(String str) {
        JSONObject jSONObject = new JSONObject();
        String strA = f0.a(str);
        String strB = f0.b(str);
        try {
            jSONObject.put("telecom", str);
            jSONObject.put("protocolName", strA);
            jSONObject.put("protocolUrl", strB);
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "operatorInfoToJsonString  Exception_e=", e);
        }
        Q.a("ProcessShanYanLogger", "operatorInfo", jSONObject);
        return jSONObject.toString();
    }

    public static boolean a(String str) {
        return str == null || "".equals(str) || str.trim().length() == 0 || "null".equals(str);
    }

    public static String a(int i, String str, String str2, String str3) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("innerCode", i);
            jSONObject.put("innerDesc", str);
            jSONObject.put("message", str2);
            jSONObject.put("number", "");
            jSONObject.put("telecom", str3);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return jSONObject.toString();
    }

    public static String a(int i, String str, String str2) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("innerCode", i);
            jSONObject.put("innerDesc", str);
            jSONObject.put("message", str2);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return jSONObject.toString();
    }

    public static String a(int i, String str, String str2, Context context) {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("innerCode", i);
            jSONObject.put("innerDesc", str);
            jSONObject.put("message", str2);
            jSONObject.put("number", AbstractC0606l.p);
            jSONObject.put("telecom", AbstractC0606l.m);
            jSONObject.put("protocolName", AbstractC0606l.n);
            jSONObject.put("protocolUrl", AbstractC0606l.o);
            p0.b(context, "cl_jm_f6", AbstractC0606l.m);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return jSONObject.toString();
    }

    public static String a(int i, String str) {
        String strE;
        if (str == null) {
            return str;
        }
        try {
            JSONObject jSONObject = new JSONObject(str);
            EnumC0611q enumC0611q = EnumC0611q.AUTH_TOKEN_SUCCESS_CODE;
            if (enumC0611q.d() != i && EnumC0611q.LOGIN_SUCCESS_CODE.d() != i) {
                strE = jSONObject.optString("message");
                if (a(strE)) {
                    return str;
                }
            } else if (jSONObject.has(Constants.TOKEN)) {
                strE = enumC0611q.e();
            } else {
                strE = EnumC0611q.OPEN_PAGE_SUCCESS_CODE.e();
            }
            return strE;
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", str, "getJsonMessage  Exception", e);
            return str;
        }
    }
}
