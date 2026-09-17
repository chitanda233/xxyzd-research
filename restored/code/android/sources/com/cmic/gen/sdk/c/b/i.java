package com.cmic.gen.sdk.c.b;

import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: compiled from: ScripAndTokenParameter.java */
/* JADX INFO: loaded from: classes2.dex */
public class i extends a {
    protected String C = "";
    protected String D = "";

    @Override // com.cmic.gen.sdk.c.b.a
    public void a(String str) {
        this.v = t(str);
    }

    public void z(String str) {
        this.C = t(str);
    }

    public void A(String str) {
        this.D = t(str);
    }

    @Override // com.cmic.gen.sdk.c.b.h
    public JSONObject b() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("ver", this.f2076a);
            jSONObject.put("sdkver", this.b);
            jSONObject.put("targetVersion", "0");
            jSONObject.put("appid", this.c);
            jSONObject.put("imsi", this.d);
            jSONObject.put("operatortype", this.e);
            jSONObject.put("networktype", this.f);
            jSONObject.put("mobilebrand", this.g);
            jSONObject.put("mobilemodel", this.h);
            jSONObject.put("mobilesystem", this.i);
            jSONObject.put("clienttype", this.j);
            jSONObject.put("interfacever", this.k);
            jSONObject.put("expandparams", this.l);
            jSONObject.put("msgid", this.m);
            jSONObject.put(com.alipay.sdk.m.x.a.k, this.n);
            jSONObject.put("subimsi", this.o);
            jSONObject.put("sign", this.p);
            jSONObject.put("apppackage", this.q);
            jSONObject.put("appsign", this.r);
            jSONObject.put("ipv4_list", this.s);
            jSONObject.put("ipv6_list", this.t);
            jSONObject.put("sdkType", this.u);
            jSONObject.put("tempPDR", this.v);
            jSONObject.put("scrip", this.C);
            jSONObject.put("userCapaid", this.D);
            jSONObject.put("funcType", this.w);
            jSONObject.put("socketip", this.x);
            jSONObject.put("riskControlInfo", this.A);
            jSONObject.put("simOperator", this.z);
            jSONObject.put("oaid", this.B);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }

    @Override // com.cmic.gen.sdk.c.b.h
    protected String a_(String str) {
        return this.b + this.c + this.d + this.e + this.f + this.g + this.h + this.i + this.j + this.m + this.n + str + this.o + this.q + this.r + this.s + this.t + this.u + this.v + this.C + this.D + this.w + this.x + "0";
    }

    public String toString() {
        return b().toString();
    }
}
