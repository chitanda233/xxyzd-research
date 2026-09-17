package com.byazt.e;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 443, 20})
public class c {
    public String c;
    public String n;
    public String tt;
    public String uj;
    public String ve;

    public c(C0109c c0109c) {
        this.tt = "";
        this.c = c0109c.c;
        this.tt = c0109c.tt;
        this.ve = c0109c.ve;
        this.uj = c0109c.uj;
        this.n = c0109c.n;
    }

    /* JADX INFO: renamed from: com.byazt.e.c$c, reason: collision with other inner class name */
    @com.byazt.zqa.c(c = {0, 1, 443, 44})
    public static class C0109c {
        public String c;
        public String n;
        public String tt;
        public String uj;
        public String ve;

        public C0109c c(String str) {
            this.c = str;
            return this;
        }

        public C0109c tt(String str) {
            this.tt = str;
            return this;
        }

        public C0109c ve(String str) {
            this.uj = str;
            return this;
        }

        public C0109c uj(String str) {
            this.n = str;
            return this;
        }

        public c c() {
            return new c(this);
        }
    }
}
