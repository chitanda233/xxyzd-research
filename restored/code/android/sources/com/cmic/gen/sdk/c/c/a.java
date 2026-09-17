package com.cmic.gen.sdk.c.c;

import android.util.Base64;
import cn.com.chinatelecom.account.api.utils.Constants;
import com.cmic.gen.sdk.c.b.e;
import com.cmic.gen.sdk.c.b.f;
import com.cmic.gen.sdk.c.b.g;
import com.cmic.gen.sdk.c.b.i;
import com.cmic.gen.sdk.f.j;
import com.cmic.gen.sdk.f.l;
import com.cmic.gen.sdk.f.n;
import com.cmic.gen.sdk.f.p;
import com.cmic.gen.sdk.f.r;
import java.security.MessageDigest;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: compiled from: BaseRequest.java */
/* JADX INFO: loaded from: classes2.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static a f2086a;

    private a() {
    }

    public static a a() {
        if (f2086a == null) {
            synchronized (a.class) {
                if (f2086a == null) {
                    f2086a = new a();
                }
            }
        }
        return f2086a;
    }

    public void a(boolean z, com.cmic.gen.sdk.a aVar, d dVar) {
        com.cmic.gen.sdk.c.b.b bVar = new com.cmic.gen.sdk.c.b.b();
        bVar.b("1.0");
        bVar.c(Constants.LOG_OS);
        bVar.d(l.b("AID", ""));
        bVar.e(z ? "1" : "0");
        bVar.f(com.cmic.gen.sdk.auth.c.SDK_VERSION);
        bVar.g(aVar.b("appid"));
        bVar.h(bVar.y(""));
        a(new c("https://" + aVar.b().c() + "/client/uniConfig", bVar, "POST", aVar.b("traceId")), dVar, aVar);
    }

    public String a(String str) {
        com.cmic.gen.sdk.f.c.a("BaseRequest", "sha256=" + str);
        try {
            return Base64.encodeToString(MessageDigest.getInstance("SHA-256").digest(str.getBytes("UTF-8")), 0).replace("\n", "");
        } catch (Exception unused) {
            return null;
        }
    }

    public void a(com.cmic.gen.sdk.a aVar, d dVar) {
        f fVar = new f();
        fVar.b(aVar.b("appid"));
        fVar.c(p.a());
        fVar.d(a("1.0" + aVar.b("traceId") + fVar.a() + fVar.c() + aVar.b(com.alipay.sdk.m.w.a.t)));
        a(new c("https://" + aVar.b().d() + "/unisdk/getSdkPageOption", fVar, "POST", aVar.b("traceId")), dVar, aVar);
    }

    public void b(com.cmic.gen.sdk.a aVar, d dVar) {
        c cVar;
        String strA;
        com.cmic.gen.sdk.f.c.b("BaseRequest", "time+" + System.currentTimeMillis());
        com.cmic.gen.sdk.f.c.b("BaseRequest", "methodCostTimePre+" + aVar.b("methodCostTimePre", 0L));
        aVar.a("methodChain", aVar.b("methodChain") + ",100006");
        aVar.a("methodCostTime", aVar.b("methodCostTime") + "," + (System.currentTimeMillis() - aVar.b("methodCostTimePre", 0L)));
        aVar.a("methodCostTimePre", System.currentTimeMillis());
        JSONObject jSONObject = new JSONObject();
        JSONObject jSONObject2 = new JSONObject();
        try {
            jSONObject.put("stackInfo", jSONObject2);
            jSONObject2.put("appid", aVar.b("appid"));
            jSONObject2.put("packageName", aVar.b("apppackage"));
            jSONObject2.put("methodCostTime", aVar.b("methodCostTime"));
            jSONObject2.put("pathOfCallingMethod", aVar.b("pathOfCallingMethod"));
            jSONObject.put("methodChain", aVar.b("methodChain"));
            int iC = aVar.c("networktype");
            i iVar = new i();
            iVar.a(jSONObject);
            iVar.b("1.0");
            iVar.c(com.cmic.gen.sdk.auth.c.SDK_VERSION);
            iVar.v(com.cmic.gen.sdk.auth.c.SDK_VERSION);
            iVar.d(aVar.b("appid"));
            iVar.e(aVar.b("operatortype"));
            iVar.f(iC + "");
            iVar.g(n.a());
            iVar.h(n.b());
            iVar.i(n.c());
            iVar.j("0");
            iVar.k("3.1");
            iVar.l(r.b());
            iVar.m(p.a());
            iVar.o(aVar.b("apppackage"));
            iVar.p(aVar.b("appsign"));
            iVar.w(aVar.b("operator"));
            iVar.x(l.b("oaid", ""));
            iVar.a(l.b("AID", ""));
            if (aVar.c("logintype") == 3 || aVar.b("isRisk", false)) {
                iVar.s("pre");
            } else {
                iVar.A(aVar.b("userCapaid"));
                if (aVar.c("logintype") == 1) {
                    iVar.A("200");
                } else {
                    iVar.A("50");
                }
                iVar.s("authz");
            }
            r.a(aVar, "scripAndTokenForHttps");
            com.cmic.gen.sdk.a.a aVarB = aVar.b();
            if (aVar.b("isCacheScrip", false) || aVar.c("logintype") == 1 || aVar.b("isGotScrip", false)) {
                iVar.z(aVar.b("phonescrip"));
                iVar.n(iVar.y(aVar.b(com.alipay.sdk.m.w.a.t)));
                cVar = new c("https://" + aVarB.a() + "/unisdk/rs/scripAndTokenForHttpsBx", iVar, "POST", aVar.b("traceId"));
            } else {
                e eVar = new e();
                eVar.a(aVar.a(com.cmic.gen.sdk.b.a.f2063a));
                eVar.b(aVar.a(com.cmic.gen.sdk.b.a.b));
                eVar.a(iVar);
                eVar.a(false);
                aVar.a("isCloseIpv4", aVarB.i());
                aVar.a("isCloseIpv6", aVarB.j());
                String str = "https://" + aVarB.b() + "/unisdk/rs/scripAndTokenForHttpsBx";
                if (aVar.b("use2048PublicKey", false)) {
                    com.cmic.gen.sdk.f.c.a("BaseRequest", "使用2对应的编码");
                    eVar.b("2");
                    strA = j.a().b(aVar.a(com.cmic.gen.sdk.b.a.f2063a));
                } else {
                    strA = j.a().a(aVar.a(com.cmic.gen.sdk.b.a.f2063a));
                }
                eVar.c(strA);
                cVar = new b(str, eVar, "POST", aVar.b("traceId"));
                if (iC == 3) {
                    cVar.a(true);
                    aVar.a("doNetworkSwitch", true);
                } else {
                    cVar.a(false);
                    aVar.a("doNetworkSwitch", false);
                }
            }
            cVar.a("dnsParseResult", "1");
            cVar.a("interfaceVersion", "3.1");
            a(cVar, dVar, aVar);
        } catch (JSONException e) {
            throw new RuntimeException(e);
        }
    }

    public void a(JSONObject jSONObject, com.cmic.gen.sdk.a aVar, d dVar) {
        g gVar = new g();
        g.a aVar2 = new g.a();
        g.b bVar = new g.b();
        bVar.e(r.b());
        bVar.f(p.a());
        bVar.b("2.0");
        bVar.c(aVar.b("appid", ""));
        bVar.d(bVar.y(""));
        aVar2.a(jSONObject);
        gVar.a(aVar2);
        gVar.a(bVar);
        a(new c("https://" + aVar.b().e() + "/log/logReport", gVar, "POST", aVar.b("traceId")), dVar, aVar);
    }

    private void a(final c cVar, final d dVar, final com.cmic.gen.sdk.a aVar) {
        com.cmic.gen.sdk.c.a.d dVar2 = new com.cmic.gen.sdk.c.a.d();
        com.cmic.gen.sdk.c.a.c cVar2 = new com.cmic.gen.sdk.c.a.c();
        com.cmic.gen.sdk.c.a.a aVar2 = new com.cmic.gen.sdk.c.a.a();
        dVar2.a(cVar2);
        cVar2.a(aVar2);
        dVar2.a(cVar, new com.cmic.gen.sdk.c.d.c() { // from class: com.cmic.gen.sdk.c.c.a.1
            @Override // com.cmic.gen.sdk.c.d.c
            public void a(com.cmic.gen.sdk.c.d.b bVar) {
                String string;
                if (cVar.g()) {
                    try {
                        JSONObject jSONObject = new JSONObject(bVar.c());
                        if (jSONObject.has("resultcode")) {
                            string = jSONObject.getString("resultcode");
                        } else {
                            string = jSONObject.getString("resultCode");
                        }
                        r.b(aVar, string);
                        dVar.a(string, jSONObject.optString("desc"), jSONObject);
                    } catch (Exception e) {
                        e.printStackTrace();
                        a(com.cmic.gen.sdk.c.d.a.a(102223));
                    }
                }
            }

            @Override // com.cmic.gen.sdk.c.d.c
            public void a(com.cmic.gen.sdk.c.d.a aVar3) {
                if (cVar.g()) {
                    r.b(aVar, String.valueOf(aVar3.a()));
                    dVar.a(String.valueOf(aVar3.a()), aVar3.b(), com.cmic.gen.sdk.auth.d.a(String.valueOf(aVar3.a()), aVar3.b()));
                }
            }
        }, aVar);
    }
}
