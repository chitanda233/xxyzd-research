package com.cmic.gen.sdk.c.b;

import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: compiled from: GetSdkPageOptionParameter.java */
/* JADX INFO: loaded from: classes2.dex */
public class f extends h {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f2081a;
    private String b;
    private String c;

    @Override // com.cmic.gen.sdk.c.b.h
    protected String a_(String str) {
        return "";
    }

    public void b(String str) {
        this.f2081a = str;
    }

    public void c(String str) {
        this.b = str;
    }

    public String c() {
        return this.b;
    }

    @Override // com.cmic.gen.sdk.c.b.h
    public String a() {
        return this.f2081a;
    }

    @Override // com.cmic.gen.sdk.c.b.h
    public JSONObject b() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("sign", this.c);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }

    public void d(String str) {
        this.c = str;
    }
}
