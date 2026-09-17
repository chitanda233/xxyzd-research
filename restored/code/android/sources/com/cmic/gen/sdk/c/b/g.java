package com.cmic.gen.sdk.c.b;

import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: compiled from: LogReportParameter.java */
/* JADX INFO: loaded from: classes2.dex */
public class g extends h {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private b f2082a;
    private a b;

    @Override // com.cmic.gen.sdk.c.b.h
    protected String a_(String str) {
        return null;
    }

    public void a(b bVar) {
        this.f2082a = bVar;
    }

    public void a(a aVar) {
        this.b = aVar;
    }

    /* JADX INFO: compiled from: LogReportParameter.java */
    public static class b extends h {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private String f2084a;
        private String b;
        private String c;
        private String d;
        private String e;

        @Override // com.cmic.gen.sdk.c.b.h
        public JSONObject b() {
            return null;
        }

        public String c() {
            return this.e;
        }

        public void b(String str) {
            this.e = str;
        }

        @Override // com.cmic.gen.sdk.c.b.h
        public String a() {
            return this.d;
        }

        @Override // com.cmic.gen.sdk.c.b.h
        protected String a_(String str) {
            return this.e + this.d + this.c + this.b + "@Fdiwmxy7CBDDQNUI";
        }

        public void c(String str) {
            this.d = str;
        }

        public String d() {
            return this.f2084a;
        }

        public void d(String str) {
            this.f2084a = str;
        }

        public String e() {
            return this.b;
        }

        public void e(String str) {
            this.b = str;
        }

        public String f() {
            return this.c;
        }

        public void f(String str) {
            this.c = str;
        }
    }

    /* JADX INFO: compiled from: LogReportParameter.java */
    public static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private JSONObject f2083a;

        public JSONObject a() {
            return this.f2083a;
        }

        public void a(JSONObject jSONObject) {
            this.f2083a = jSONObject;
        }
    }

    @Override // com.cmic.gen.sdk.c.b.h
    public String a() {
        return this.f2082a.d;
    }

    @Override // com.cmic.gen.sdk.c.b.h
    public JSONObject b() {
        JSONObject jSONObject = new JSONObject();
        JSONObject jSONObject2 = new JSONObject();
        JSONObject jSONObject3 = new JSONObject();
        try {
            jSONObject2.put("sign", this.f2082a.d());
            jSONObject2.put("msgid", this.f2082a.e());
            jSONObject2.put("systemtime", this.f2082a.f());
            jSONObject2.put("appid", this.f2082a.a());
            jSONObject2.put("version", this.f2082a.c());
            jSONObject.put("header", jSONObject2);
            jSONObject3.put("log", this.b.a());
            jSONObject.put("body", jSONObject3);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject;
    }
}
