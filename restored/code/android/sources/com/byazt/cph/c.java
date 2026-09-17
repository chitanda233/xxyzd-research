package com.byazt.cph;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1059, 20})
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f748a;
    public String c;
    public int n;
    public JSONObject sp;
    public String tt;
    public int uj;
    public String ve;

    public String c() {
        return this.c;
    }

    public String tt() {
        return this.tt;
    }

    public String ve() {
        return this.ve;
    }

    public int uj() {
        return this.uj;
    }

    public int n() {
        return this.n;
    }

    public long a() {
        return this.f748a;
    }

    public JSONObject sp() {
        return this.sp;
    }

    /* JADX INFO: renamed from: com.byazt.cph.c$c, reason: collision with other inner class name */
    @com.byazt.zqa.c(c = {0, 1, 1059, 44})
    public static class C0094c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public long f749a;
        public String c;
        public int n;
        public JSONObject sp;
        public String tt;
        public int uj;
        public String ve;

        public C0094c c(String str) {
            this.c = str;
            return this;
        }

        public C0094c tt(String str) {
            this.tt = str;
            return this;
        }

        public C0094c ve(String str) {
            this.ve = str;
            return this;
        }

        public C0094c c(int i) {
            this.uj = i;
            return this;
        }

        public C0094c tt(int i) {
            this.n = i;
            return this;
        }

        public C0094c c(long j) {
            this.f749a = j;
            return this;
        }

        public C0094c c(JSONObject jSONObject) {
            this.sp = jSONObject;
            return this;
        }

        public c c() {
            c cVar = new c();
            cVar.c = this.c;
            cVar.tt = this.tt;
            cVar.ve = this.ve;
            cVar.uj = this.uj;
            cVar.n = this.n;
            cVar.f748a = this.f749a;
            cVar.sp = this.sp;
            return cVar;
        }
    }
}
