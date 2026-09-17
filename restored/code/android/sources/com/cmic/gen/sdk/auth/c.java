package com.cmic.gen.sdk.auth;

import android.content.Context;
import android.os.Handler;
import android.os.SystemClock;
import android.text.TextUtils;
import com.cmic.gen.sdk.e.i;
import com.cmic.gen.sdk.f.f;
import com.cmic.gen.sdk.f.k;
import com.cmic.gen.sdk.f.l;
import com.cmic.gen.sdk.f.n;
import com.cmic.gen.sdk.f.o;
import com.cmic.gen.sdk.f.p;
import com.cmic.gen.sdk.f.r;
import com.cmic.gen.sdk.f.s;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: compiled from: AuthnHelperCore.java */
/* JADX INFO: loaded from: classes2.dex */
public class c {
    public static final String SDK_VERSION = "quick_login_android_5.9.13";
    private static c f;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    protected final com.cmic.gen.sdk.auth.a f2053a;
    protected final Context b;
    protected long c;
    protected final Handler d;
    protected String e;
    private final Object g;

    c(Context context) {
        this.c = 8000L;
        this.g = new Object();
        Context applicationContext = context.getApplicationContext();
        this.b = applicationContext;
        this.d = new Handler(applicationContext.getMainLooper());
        this.f2053a = com.cmic.gen.sdk.auth.a.a(applicationContext);
        s.a(applicationContext);
        l.a(applicationContext);
        k.a(applicationContext);
        o.a(new o.a() { // from class: com.cmic.gen.sdk.auth.c.1
            @Override // com.cmic.gen.sdk.f.o.a
            protected void a() {
                String strB = l.b("AID", "");
                com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "aid = " + strB);
                if (TextUtils.isEmpty(strB)) {
                    c.this.a();
                }
                String strA = new i(c.this.b).a();
                com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "oaid = " + strA);
                if (!TextUtils.isEmpty(strA)) {
                    l.a("oaid", strA);
                }
                if (com.cmic.gen.sdk.f.b.a(c.this.b, true)) {
                    com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "生成androidkeystore成功");
                } else {
                    com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "生成androidkeystore失败");
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a() {
        String str = "%" + r.b();
        com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "generate aid = " + str);
        l.a("AID", str);
    }

    private c(Context context, String str) {
        this(context);
        this.e = str;
    }

    public static c getInstance(Context context) {
        if (f == null) {
            synchronized (c.class) {
                if (f == null) {
                    f = new c(context);
                }
            }
        }
        return f;
    }

    public static c getInstance(Context context, String str) {
        if (f == null) {
            synchronized (c.class) {
                if (f == null) {
                    f = new c(context, str);
                }
            }
        }
        return f;
    }

    public void loginAuth(final String str, final String str2, final GenTokenListener genTokenListener) {
        final com.cmic.gen.sdk.a aVarA = a(genTokenListener);
        o.a(new o.a(this.b, aVarA) { // from class: com.cmic.gen.sdk.auth.c.2
            @Override // com.cmic.gen.sdk.f.o.a
            protected void a() {
                if (c.this.a(aVarA, str, str2, "loginAuth", 1, genTokenListener)) {
                    c.this.a(aVarA);
                }
            }
        });
    }

    public void mobileAuth(final String str, final String str2, final GenTokenListener genTokenListener) {
        final com.cmic.gen.sdk.a aVarA = a(genTokenListener);
        o.a(new o.a(this.b, aVarA) { // from class: com.cmic.gen.sdk.auth.c.3
            @Override // com.cmic.gen.sdk.f.o.a
            protected void a() {
                if (c.this.a(aVarA, str, str2, "mobileAuth", 0, genTokenListener)) {
                    c.this.a(aVarA);
                }
            }
        });
    }

    public void getPhoneInfo(final String str, final String str2, final GenTokenListener genTokenListener) {
        final com.cmic.gen.sdk.a aVarA = a(genTokenListener);
        o.a(new o.a(this.b, aVarA) { // from class: com.cmic.gen.sdk.auth.c.4
            @Override // com.cmic.gen.sdk.f.o.a
            protected void a() {
                if (c.this.a(aVarA, str, str2, "preGetMobile", 3, genTokenListener)) {
                    c.this.a(aVarA);
                }
            }
        });
    }

    protected com.cmic.gen.sdk.a a(GenTokenListener genTokenListener) {
        com.cmic.gen.sdk.a aVar = new com.cmic.gen.sdk.a(64);
        String strC = r.c();
        aVar.a(new com.cmic.gen.sdk.d.b());
        aVar.a("traceId", strC);
        com.cmic.gen.sdk.f.c.a("traceId", strC);
        if (genTokenListener != null) {
            f.a(strC, genTokenListener);
        }
        return aVar;
    }

    /* JADX INFO: compiled from: AuthnHelperCore.java */
    protected class a implements Runnable {
        private final com.cmic.gen.sdk.a b;

        a(com.cmic.gen.sdk.a aVar) {
            this.b = aVar;
        }

        @Override // java.lang.Runnable
        public void run() {
            JSONObject jSONObjectA = d.a("200023", "登录超时");
            c.this.callBackResult(jSONObjectA.optString("resultCode", "200023"), jSONObjectA.optString("desc", "登录超时"), this.b, jSONObjectA);
        }
    }

    /* JADX INFO: Access modifiers changed from: protected */
    public void a(com.cmic.gen.sdk.a aVar) {
        final a aVar2 = new a(aVar);
        this.d.postDelayed(aVar2, this.c);
        aVar.a("methodChain", aVar.b("methodChain") + ",100003");
        aVar.a("methodCostTime", aVar.b("methodCostTime") + "," + (System.currentTimeMillis() - aVar.b("methodCostTimePre", 0L)));
        aVar.a("methodCostTimePre", System.currentTimeMillis());
        this.f2053a.a(aVar, new b() { // from class: com.cmic.gen.sdk.auth.c.5
            @Override // com.cmic.gen.sdk.auth.b
            public void a(String str, String str2, com.cmic.gen.sdk.a aVar3, JSONObject jSONObject) {
                c.this.d.removeCallbacks(aVar2);
                c.this.callBackResult(str, str2, aVar3, jSONObject);
            }
        });
    }

    protected boolean a(com.cmic.gen.sdk.a aVar, String str, String str2, String str3, int i, GenTokenListener genTokenListener) {
        boolean zA;
        com.cmic.gen.sdk.a.a aVarA = com.cmic.gen.sdk.a.c.a(this.b).a();
        aVar.a("methodChain", aVar.b("methodChain") + ",100002");
        aVar.a("methodCostTime", String.valueOf(System.currentTimeMillis() - aVar.b("methodCostTimePre", 0L)));
        aVar.a("methodCostTimePre", System.currentTimeMillis());
        aVar.a(aVarA);
        aVar.a("use2048PublicKey", "rsa2048".equals(this.e));
        aVar.a("systemStartTime", SystemClock.elapsedRealtime());
        aVar.a("starttime", p.a());
        aVar.a("loginMethod", str3);
        aVar.a(com.alipay.sdk.m.w.a.t, str2);
        aVar.a("appid", str);
        aVar.a("timeOut", String.valueOf(this.c));
        boolean zA2 = n.a(this.b);
        com.cmic.gen.sdk.b.a.a().a(this.b, zA2);
        String strB = k.a().b();
        String strA = k.a().a(zA2);
        String strA2 = k.a().a(strA, zA2);
        aVar.a("operator", strA);
        aVar.a("operatortype", strA2);
        aVar.a("logintype", i);
        com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "subId = " + strB);
        if (!TextUtils.isEmpty(strB)) {
            com.cmic.gen.sdk.f.c.a("AuthnHelperCore", "使用subId作为缓存key = " + strB);
            aVar.a("scripType", "subid");
            aVar.a("scripKey", strB);
        } else if (!TextUtils.isEmpty(strA)) {
            com.cmic.gen.sdk.f.c.a("AuthnHelperCore", "使用operator作为缓存key = " + strA);
            aVar.a("scripType", "operator");
            aVar.a("scripKey", strA);
        }
        int iA = n.a(this.b, zA2, aVar);
        aVar.a("networktype", iA);
        if (!zA2) {
            aVar.a("authType", String.valueOf(0));
            callBackResult("200010", "无法识别sim卡或没有sim卡", aVar, null);
            return false;
        }
        if (genTokenListener == null) {
            callBackResult("102203", "listener不能为空", aVar, null);
            return false;
        }
        if (aVarA.h()) {
            callBackResult("200082", "服务器繁忙，请稍后重试", aVar, null);
            return false;
        }
        if (TextUtils.isEmpty(str == null ? "" : str.trim())) {
            callBackResult("102203", "appId 不能为空", aVar, null);
            return false;
        }
        if (TextUtils.isEmpty(str2 == null ? "" : str2.trim())) {
            callBackResult("102203", "appkey不能为空", aVar, null);
            return false;
        }
        if (iA == 0) {
            callBackResult("102101", "未检测到网络", aVar, null);
            return false;
        }
        if ("2".equals(strA2) && aVarA.g()) {
            callBackResult("200082", "服务器繁忙，请稍后重试", aVar, null);
            return false;
        }
        if ("3".equals(strA2) && aVarA.f()) {
            callBackResult("200082", "服务器繁忙，请稍后重试", aVar, null);
            return false;
        }
        synchronized (this.g) {
            zA = com.cmic.gen.sdk.f.i.a(aVar);
            if (zA) {
                aVar.a("securityphone", com.cmic.gen.sdk.f.i.b(this.b));
                if (3 != i) {
                    String strA3 = com.cmic.gen.sdk.f.i.a(this.b);
                    com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "解密phoneScript " + (!TextUtils.isEmpty(strA3)));
                    if (TextUtils.isEmpty(strA3)) {
                        zA = false;
                    } else {
                        aVar.a("phonescrip", strA3);
                    }
                    com.cmic.gen.sdk.f.i.a(true, false);
                }
            }
            aVar.a("isCacheScrip", zA);
            com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "isCachePhoneScrip = " + zA);
        }
        if (iA != 2 || zA) {
            return true;
        }
        callBackResult("102103", "无数据网络", aVar, null);
        return false;
    }

    public static void setDebugMode(boolean z) {
        com.cmic.gen.sdk.f.c.a(z);
    }

    public void callBackResult(String str, String str2, com.cmic.gen.sdk.a aVar, JSONObject jSONObject) {
        final JSONObject jSONObjectA;
        try {
            String strB = aVar.b("traceId");
            final int iB = aVar.b("SDKRequestCode", -1);
            if (f.a(strB)) {
                return;
            }
            synchronized (this) {
                final GenTokenListener genTokenListenerC = f.c(strB);
                if (jSONObject == null || !jSONObject.optBoolean("keepListener", false)) {
                    f.b(strB);
                }
                if (genTokenListenerC == null) {
                    return;
                }
                aVar.a("systemEndTime", SystemClock.elapsedRealtime());
                aVar.a("endtime", p.a());
                int iC = aVar.c("logintype");
                if (jSONObject == null) {
                    jSONObject = d.a(str, str2);
                }
                if (iC == 3) {
                    jSONObjectA = d.a(str, aVar, jSONObject);
                } else {
                    jSONObjectA = d.a(str, str2, aVar, jSONObject);
                }
                jSONObjectA.put("traceId", strB);
                jSONObjectA.put("scripExpiresIn", String.valueOf(com.cmic.gen.sdk.f.i.a()));
                this.d.post(new Runnable() { // from class: com.cmic.gen.sdk.auth.c.6
                    @Override // java.lang.Runnable
                    public void run() {
                        genTokenListenerC.onGetTokenComplete(iB, jSONObjectA);
                    }
                });
                com.cmic.gen.sdk.a.c.a(this.b).a(aVar);
                if (aVar.b().k() || r.a(aVar.b())) {
                    return;
                }
                a(this.b, str, aVar);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void a(final Context context, final String str, final com.cmic.gen.sdk.a aVar) {
        o.a(new o.a() { // from class: com.cmic.gen.sdk.auth.c.7
            @Override // com.cmic.gen.sdk.f.o.a
            protected void a() {
                if ("200023".equals(str)) {
                    SystemClock.sleep(8000L);
                }
                new com.cmic.gen.sdk.d.d().a(context, str, aVar);
            }
        });
    }

    public void setOverTime(long j) {
        this.c = j;
    }

    public JSONObject getNetworkType(Context context) {
        JSONObject jSONObject = new JSONObject();
        try {
            try {
                boolean zA = n.a(this.b);
                com.cmic.gen.sdk.b.a.a().a(context, zA);
                String strA = k.a().a(null, zA);
                int iA = n.a(context, zA, new com.cmic.gen.sdk.a(1));
                jSONObject.put("operatortype", strA);
                jSONObject.put("networktype", iA + "");
                com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "网络类型: " + iA);
                com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "运营商类型: " + strA);
                return jSONObject;
            } catch (JSONException e) {
                e.printStackTrace();
                return jSONObject;
            }
        } catch (Exception unused) {
            jSONObject.put("errorDes", "发生未知错误");
            return jSONObject;
        }
    }

    public void delScrip() {
        try {
            com.cmic.gen.sdk.f.i.a(true, true);
            com.cmic.gen.sdk.f.c.b("AuthnHelperCore", "删除scrip");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
