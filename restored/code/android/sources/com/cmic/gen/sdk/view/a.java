package com.cmic.gen.sdk.view;

import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: compiled from: LoginAuthParameter.java */
/* JADX INFO: loaded from: classes2.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f2158a;
    private String b;
    private String c;
    private String d;
    private String e;
    private String f;
    private String g;
    private String h;
    private String i;
    private String j;
    private String k;

    public void a(String str) {
        this.f = str;
    }

    public void b(String str) {
        this.c = str;
    }

    public void c(String str) {
        this.d = str;
    }

    public void d(String str) {
        this.e = str;
    }

    public void e(String str) {
        this.g = str;
    }

    public void f(String str) {
        this.h = str;
    }

    public void g(String str) {
        this.i = str;
    }

    public void h(String str) {
        this.j = str;
    }

    public void i(String str) {
        this.k = str;
    }

    public void j(String str) {
        this.f2158a = str;
    }

    public void k(String str) {
        this.b = str;
    }

    public JSONObject a() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("authPageOut", this.b);
            jSONObject.put("authPageIn", this.f2158a);
            jSONObject.put("authClickSuccess", this.d);
            jSONObject.put("timeOnAuthPage", this.e);
            jSONObject.put("authClickFailed", this.c);
            jSONObject.put("authPrivacyState", this.f);
            jSONObject.put("PrivacyNotSelectedToast", this.g);
            jSONObject.put("PrivacyNotSelectedPopup", this.h);
            jSONObject.put("PrivacyNotSelectedShake", this.i);
            jSONObject.put("PrivacyNotSelectedCustom", this.j);
            jSONObject.put("brandButton", this.k);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }
}
