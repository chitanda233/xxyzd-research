package com.cmic.gen.sdk.c.b;

import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: compiled from: GetPhoneNubmerNotify.java */
/* JADX INFO: loaded from: classes2.dex */
public class d extends h {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final String f2079a;
    private final String b;
    private final String c;
    private String d = "authz";
    private String e;
    private String f;

    @Override // com.cmic.gen.sdk.c.b.h
    protected String a_(String str) {
        return null;
    }

    public d(String str, String str2, String str3) {
        this.f2079a = str;
        this.b = str2;
        this.c = str3;
    }

    public void b(String str) {
        this.d = str;
    }

    public void c(String str) {
        this.e = str;
    }

    public void d(String str) {
        this.f = str;
    }

    @Override // com.cmic.gen.sdk.c.b.h
    public String a() {
        return this.f2079a;
    }

    @Override // com.cmic.gen.sdk.c.b.h
    public JSONObject b() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("ver", this.b);
            jSONObject.put("data", this.c);
            jSONObject.put("operatortype", this.f);
            jSONObject.put("userCapaid", this.e);
            jSONObject.put("funcType", this.d);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }
}
