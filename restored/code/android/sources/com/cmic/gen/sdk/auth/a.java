package com.cmic.gen.sdk.auth;

import android.content.Context;
import android.text.TextUtils;
import com.cmic.gen.sdk.f.i;
import com.cmic.gen.sdk.f.l;
import com.cmic.gen.sdk.f.m;
import com.cmic.gen.sdk.f.o;
import com.czhj.sdk.common.Constants;
import java.util.UUID;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: compiled from: AuthnBusiness.java */
/* JADX INFO: loaded from: classes2.dex */
public class a {
    private static a c;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final com.cmic.gen.sdk.c.c.a f2049a = com.cmic.gen.sdk.c.c.a.a();
    private final Context b;

    private a(Context context) {
        this.b = context.getApplicationContext();
    }

    public static a a(Context context) {
        if (c == null) {
            synchronized (a.class) {
                if (c == null) {
                    c = new a(context);
                }
            }
        }
        return c;
    }

    public void a(com.cmic.gen.sdk.a aVar, b bVar) {
        com.cmic.gen.sdk.f.c.b("AuthnBusiness", "LoginCheck method start");
        int iC = aVar.c("logintype");
        aVar.a("methodChain", aVar.b("methodChain") + ",100004");
        aVar.a("methodCostTime", aVar.b("methodCostTime") + "," + (System.currentTimeMillis() - aVar.b("methodCostTimePre", 0L)));
        aVar.a("methodCostTimePre", System.currentTimeMillis());
        if (aVar.b("isCacheScrip", false)) {
            String strB = aVar.b("securityphone", "");
            if (iC == 3) {
                bVar.a("103000", "true", aVar, d.a(strB));
                return;
            } else {
                b(aVar, bVar);
                return;
            }
        }
        b(aVar, bVar);
    }

    private void a(final com.cmic.gen.sdk.a aVar) {
        o.a(new o.a(this.b, aVar) { // from class: com.cmic.gen.sdk.auth.a.1
            @Override // com.cmic.gen.sdk.f.o.a
            protected void a() {
                a.this.f2049a.a(aVar, new com.cmic.gen.sdk.c.c.d() { // from class: com.cmic.gen.sdk.auth.a.1.1
                    @Override // com.cmic.gen.sdk.c.c.d
                    public void a(String str, String str2, JSONObject jSONObject) {
                        if ("103000".equals(str)) {
                            com.cmic.gen.sdk.f.c.a("AuthnBusiness", "jsonobj=" + jSONObject.toString());
                            try {
                                String strOptString = jSONObject.optString("authPrivacyLink", "");
                                com.cmic.gen.sdk.f.c.a("AuthnBusiness", "authPrivacyLinkStr=" + strOptString);
                                JSONObject jSONObject2 = new JSONObject(strOptString.replace("\t", ""));
                                com.cmic.gen.sdk.f.c.a("AuthnBusiness", "authPrivacyLink=" + jSONObject2.toString());
                                JSONObject jSONObjectOptJSONObject = jSONObject2.optJSONObject("1");
                                com.cmic.gen.sdk.f.c.a("AuthnBusiness", "cmcc=" + jSONObjectOptJSONObject.toString());
                                JSONObject jSONObjectOptJSONObject2 = jSONObject2.optJSONObject("2");
                                JSONObject jSONObjectOptJSONObject3 = jSONObject2.optJSONObject("3");
                                JSONObject jSONObjectOptJSONObject4 = jSONObject2.optJSONObject("4");
                                l.a("operator1", jSONObjectOptJSONObject.toString());
                                l.a("operator2", jSONObjectOptJSONObject2.toString());
                                l.a("operator3", jSONObjectOptJSONObject3.toString());
                                l.a("operator4", jSONObjectOptJSONObject4.toString());
                            } catch (Exception e) {
                                e.printStackTrace();
                            }
                        }
                    }
                });
            }
        });
    }

    public void b(final com.cmic.gen.sdk.a aVar, final b bVar) {
        a(aVar);
        com.cmic.gen.sdk.f.c.b("AuthnBusiness", "getScripAndToken start");
        aVar.a("methodChain", aVar.b("methodChain") + ",100005");
        aVar.a("methodCostTime", aVar.b("methodCostTime") + "," + (System.currentTimeMillis() - aVar.b("methodCostTimePre", 0L)));
        aVar.a("methodCostTimePre", System.currentTimeMillis());
        boolean zB = aVar.b("isGotScrip", false);
        com.cmic.gen.sdk.f.c.b("AuthnBusiness", "isGotScrip = " + zB);
        if (!zB) {
            b(aVar);
            if (!aVar.b("isCacheScrip", false)) {
                c(aVar);
                if (aVar.c("networktype") == 3 && !"loginAuth".equals(aVar.b("loginMethod")) && aVar.c("logintype") != 3) {
                    aVar.a("isRisk", true);
                }
            }
            if (aVar.c("logintype") == 1) {
                aVar.a("userCapaid", "200");
            } else if (aVar.c("logintype") == 0) {
                aVar.a("userCapaid", "50");
            }
        }
        this.f2049a.b(aVar, new com.cmic.gen.sdk.c.c.d() { // from class: com.cmic.gen.sdk.auth.a.2
            @Override // com.cmic.gen.sdk.c.c.d
            public void a(String str, String str2, JSONObject jSONObject) {
                a.this.a(aVar, bVar, str, str2, jSONObject);
            }
        });
    }

    private void b(com.cmic.gen.sdk.a aVar) {
        String packageName = this.b.getPackageName();
        String strA = com.cmic.gen.sdk.f.d.a(m.a(this.b, packageName));
        aVar.a("apppackage", packageName);
        aVar.a("appsign", strA);
    }

    private void c(com.cmic.gen.sdk.a aVar) {
        byte[] bytes = new byte[0];
        if (aVar.b("use2048PublicKey", false)) {
            com.cmic.gen.sdk.f.c.a("AuthnBusiness", "使用2048公钥对应的对称秘钥生成方式");
            bytes = com.cmic.gen.sdk.f.a.a();
        } else {
            com.cmic.gen.sdk.f.c.a("AuthnBusiness", "使用1024公钥对应的对称秘钥生成方式");
            try {
                bytes = UUID.randomUUID().toString().substring(0, 16).getBytes("utf-8");
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        byte[] bArrA = com.cmic.gen.sdk.f.a.a();
        aVar.a(com.cmic.gen.sdk.b.a.f2063a, bytes);
        aVar.a(com.cmic.gen.sdk.b.a.b, bArrA);
        aVar.a("authType", "3");
    }

    /* JADX INFO: Access modifiers changed from: private */
    /* JADX WARN: Code duplicated, block: B:45:0x00f9  */
    /* JADX WARN: Code duplicated, block: B:47:0x00fe  */
    /* JADX WARN: Code duplicated, block: B:49:0x0107  */
    /* JADX WARN: Code duplicated, block: B:52:0x0133  */
    /* JADX WARN: Code duplicated, block: B:53:0x013d  */
    /* JADX WARN: Code duplicated, block: B:55:0x0145  */
    /* JADX WARN: Code duplicated, block: B:56:0x0152  */
    /* JADX WARN: Code duplicated, block: B:57:0x0158  */
    public void a(com.cmic.gen.sdk.a aVar, b bVar, String str, String str2, JSONObject jSONObject) {
        String strB;
        JSONException jSONException;
        String str3;
        JSONObject jSONObject2;
        String strOptString;
        String strOptString2;
        String strOptString3;
        String str4;
        String strOptString4;
        if ("103000".equals(str)) {
            String strOptString5 = jSONObject.optString("resultdata");
            if (TextUtils.isEmpty(strOptString5)) {
                strB = jSONObject.toString();
            } else {
                strB = com.cmic.gen.sdk.f.a.b(aVar.a(com.cmic.gen.sdk.b.a.f2063a), strOptString5, aVar.a(com.cmic.gen.sdk.b.a.b));
            }
            try {
                jSONObject2 = new JSONObject(strB);
                try {
                    strOptString2 = jSONObject2.optString("phonescrip");
                    try {
                        strOptString4 = jSONObject2.optString("securityphone");
                        try {
                            strOptString = jSONObject2.optString("operatortype");
                            try {
                                strOptString3 = jSONObject2.optString("openId");
                                try {
                                    if (!jSONObject2.has(Constants.TOKEN)) {
                                        if (jSONObject2.has("imageUrl") && jSONObject2.has("displayLogo")) {
                                            l.a aVarA = l.a();
                                            aVarA.a("imageUrl", jSONObject2.optString("imageUrl"));
                                            aVarA.a("displayLogo", jSONObject2.optString("displayLogo"));
                                            aVarA.b();
                                        } else {
                                            l.a aVarA2 = l.a();
                                            aVarA2.a("imageUrl");
                                            aVarA2.a("displayLogo");
                                            aVarA2.b();
                                        }
                                    }
                                    if (TextUtils.isEmpty(strOptString3)) {
                                        strOptString3 = jSONObject2.optString("pcid");
                                    }
                                    com.cmic.gen.sdk.f.b.a();
                                    i.a(this.b, strOptString4, strOptString);
                                    str4 = strOptString2;
                                } catch (JSONException e) {
                                    jSONException = e;
                                    str3 = strOptString4;
                                    jSONObject2 = jSONObject2;
                                    jSONException.printStackTrace();
                                    jSONObject2 = jSONObject2;
                                    str4 = strOptString2;
                                    strOptString4 = str3;
                                }
                            } catch (JSONException e2) {
                                jSONException = e2;
                                str3 = strOptString4;
                                jSONObject2 = jSONObject2;
                                strOptString3 = null;
                                jSONException.printStackTrace();
                                jSONObject2 = jSONObject2;
                                str4 = strOptString2;
                                strOptString4 = str3;
                                com.cmic.gen.sdk.f.c.b("AuthnBusiness", "securityPhone  = " + strOptString4);
                                aVar.a("openId", strOptString3);
                                aVar.a("phonescrip", str4);
                                aVar.a("securityphone", strOptString4);
                                if (!TextUtils.isEmpty(strOptString)) {
                                    aVar.a("operatortype", strOptString);
                                }
                                if (jSONObject2 != null) {
                                    if (!aVar.b("isRisk", false)) {
                                        i.a(this.b, str4, strOptString4, Long.parseLong(jSONObject2.optString("scripExpiresIn", "0")), aVar.b("scripKey", ""), aVar.b("scripType", ""));
                                    }
                                    if (aVar.c("logintype") == 3) {
                                        bVar.a(str, "true", aVar, d.a(strOptString4));
                                        return;
                                    } else {
                                        if (aVar.b("isRisk", false)) {
                                            aVar.a("isRisk", false);
                                            aVar.a("isGotScrip", true);
                                            b(aVar, bVar);
                                            return;
                                        }
                                        bVar.a(str, str2, aVar, jSONObject2);
                                        return;
                                    }
                                }
                                com.cmic.gen.sdk.f.c.a("AuthnBusiness", "返回103000，但是数据解析出错");
                                bVar.a(String.valueOf(102223), "数据解析异常", aVar, d.a(String.valueOf(102223), "数据解析异常"));
                                return;
                            }
                        } catch (JSONException e3) {
                            jSONException = e3;
                            str3 = strOptString4;
                            strOptString = null;
                            strOptString3 = null;
                            jSONException.printStackTrace();
                            jSONObject2 = jSONObject2;
                            str4 = strOptString2;
                            strOptString4 = str3;
                            com.cmic.gen.sdk.f.c.b("AuthnBusiness", "securityPhone  = " + strOptString4);
                            aVar.a("openId", strOptString3);
                            aVar.a("phonescrip", str4);
                            aVar.a("securityphone", strOptString4);
                            if (!TextUtils.isEmpty(strOptString)) {
                                aVar.a("operatortype", strOptString);
                            }
                            if (jSONObject2 != null) {
                                if (!aVar.b("isRisk", false)) {
                                    i.a(this.b, str4, strOptString4, Long.parseLong(jSONObject2.optString("scripExpiresIn", "0")), aVar.b("scripKey", ""), aVar.b("scripType", ""));
                                }
                                if (aVar.c("logintype") == 3) {
                                    bVar.a(str, "true", aVar, d.a(strOptString4));
                                    return;
                                } else {
                                    if (aVar.b("isRisk", false)) {
                                        aVar.a("isRisk", false);
                                        aVar.a("isGotScrip", true);
                                        b(aVar, bVar);
                                        return;
                                    }
                                    bVar.a(str, str2, aVar, jSONObject2);
                                    return;
                                }
                            }
                            com.cmic.gen.sdk.f.c.a("AuthnBusiness", "返回103000，但是数据解析出错");
                            bVar.a(String.valueOf(102223), "数据解析异常", aVar, d.a(String.valueOf(102223), "数据解析异常"));
                            return;
                        }
                    } catch (JSONException e4) {
                        jSONException = e4;
                        str3 = null;
                    }
                } catch (JSONException e5) {
                    jSONException = e5;
                    jSONObject2 = jSONObject2;
                    str3 = null;
                    strOptString = null;
                    strOptString2 = null;
                    strOptString3 = null;
                    jSONException.printStackTrace();
                    jSONObject2 = jSONObject2;
                    str4 = strOptString2;
                    strOptString4 = str3;
                    com.cmic.gen.sdk.f.c.b("AuthnBusiness", "securityPhone  = " + strOptString4);
                    aVar.a("openId", strOptString3);
                    aVar.a("phonescrip", str4);
                    aVar.a("securityphone", strOptString4);
                    if (!TextUtils.isEmpty(strOptString)) {
                        aVar.a("operatortype", strOptString);
                    }
                    if (jSONObject2 != null) {
                        if (!aVar.b("isRisk", false)) {
                            i.a(this.b, str4, strOptString4, Long.parseLong(jSONObject2.optString("scripExpiresIn", "0")), aVar.b("scripKey", ""), aVar.b("scripType", ""));
                        }
                        if (aVar.c("logintype") == 3) {
                            bVar.a(str, "true", aVar, d.a(strOptString4));
                            return;
                        } else {
                            if (aVar.b("isRisk", false)) {
                                aVar.a("isRisk", false);
                                aVar.a("isGotScrip", true);
                                b(aVar, bVar);
                                return;
                            }
                            bVar.a(str, str2, aVar, jSONObject2);
                            return;
                        }
                    }
                    com.cmic.gen.sdk.f.c.a("AuthnBusiness", "返回103000，但是数据解析出错");
                    bVar.a(String.valueOf(102223), "数据解析异常", aVar, d.a(String.valueOf(102223), "数据解析异常"));
                    return;
                }
            } catch (JSONException e6) {
                jSONException = e6;
                str3 = null;
                jSONObject2 = null;
            }
            com.cmic.gen.sdk.f.c.b("AuthnBusiness", "securityPhone  = " + strOptString4);
            aVar.a("openId", strOptString3);
            aVar.a("phonescrip", str4);
            aVar.a("securityphone", strOptString4);
            if (!TextUtils.isEmpty(strOptString)) {
                aVar.a("operatortype", strOptString);
            }
            if (jSONObject2 != null) {
                if (!aVar.b("isRisk", false)) {
                    i.a(this.b, str4, strOptString4, Long.parseLong(jSONObject2.optString("scripExpiresIn", "0")), aVar.b("scripKey", ""), aVar.b("scripType", ""));
                }
                if (aVar.c("logintype") == 3) {
                    bVar.a(str, "true", aVar, d.a(strOptString4));
                    return;
                } else {
                    if (aVar.b("isRisk", false)) {
                        aVar.a("isRisk", false);
                        aVar.a("isGotScrip", true);
                        b(aVar, bVar);
                        return;
                    }
                    bVar.a(str, str2, aVar, jSONObject2);
                    return;
                }
            }
            com.cmic.gen.sdk.f.c.a("AuthnBusiness", "返回103000，但是数据解析出错");
            bVar.a(String.valueOf(102223), "数据解析异常", aVar, d.a(String.valueOf(102223), "数据解析异常"));
            return;
        }
        if (aVar.c("logintype") == 3) {
            bVar.a(str, "true", aVar, d.b(str, str2));
        } else {
            bVar.a(str, str2, aVar, jSONObject);
        }
    }
}
