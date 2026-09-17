package com.byazt.ete;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 8, 46})
public class n {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f882a;
    public String c;
    public int n;
    public String sp;
    public String tt;
    public int uj;
    public String ve;

    public String c() {
        return this.sp;
    }

    public void c(String str) {
        this.sp = str;
    }

    public String tt() {
        return this.c;
    }

    public void tt(String str) {
        this.c = str;
    }

    public String ve() {
        return this.tt;
    }

    public void ve(String str) {
        this.tt = str;
    }

    public String uj() {
        return this.ve;
    }

    public void uj(String str) {
        this.ve = str;
    }

    public int n() {
        return this.uj;
    }

    public void c(int i) {
        this.uj = i;
    }

    public int a() {
        return this.n;
    }

    public void tt(int i) {
        this.n = i;
    }

    public int sp() {
        return this.f882a;
    }

    public void ve(int i) {
        this.f882a = i;
    }

    public JSONObject x() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put("app_name", ve());
            jSONObject.put("app_size", sp());
            jSONObject.put("comment_num", a());
            jSONObject.put("download_url", tt());
            jSONObject.put(com.sigmob.sdk.base.n.p, uj());
            jSONObject.put("score", n());
        } catch (Exception e) {
            com.byazt.nr.m.ve(e.toString());
        }
        return jSONObject;
    }
}
