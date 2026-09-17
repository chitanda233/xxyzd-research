package com.cmic.gen.sdk.a;

/* JADX INFO: compiled from: UmcConfigBean.java */
/* JADX INFO: loaded from: classes2.dex */
public class a implements Cloneable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f2039a;
    private String b;
    private String c;
    private String d;
    private String e;
    private boolean f;
    private boolean g;
    private boolean h;
    private boolean i;
    private boolean j;
    private boolean k;
    private int l;
    private int m;

    private a() {
        this.f2039a = "rcs.cmpassport.com";
        this.b = "rcs.cmpassport.com";
        this.c = "config2.cmpassport.com";
        this.d = "onekey2.cmpassport.com";
        this.e = "log2.cmpassport.com:9443";
        this.f = false;
        this.g = false;
        this.h = false;
        this.i = false;
        this.j = false;
        this.k = false;
        this.l = 3;
        this.m = 1;
    }

    public String a() {
        return this.f2039a;
    }

    public String b() {
        return this.b;
    }

    public String c() {
        return this.c;
    }

    public String d() {
        return this.d;
    }

    public String e() {
        return this.e;
    }

    public boolean f() {
        return this.f;
    }

    public boolean g() {
        return this.g;
    }

    public boolean h() {
        return this.h;
    }

    public boolean i() {
        return this.i;
    }

    public boolean j() {
        return this.j;
    }

    public boolean k() {
        return this.k;
    }

    public int l() {
        return this.l;
    }

    public int m() {
        return this.m;
    }

    /* JADX INFO: renamed from: com.cmic.gen.sdk.a.a$a, reason: collision with other inner class name */
    /* JADX INFO: compiled from: UmcConfigBean.java */
    public static class C0343a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final a f2040a = new a();

        C0343a a(String str) {
            this.f2040a.f2039a = str;
            return this;
        }

        C0343a b(String str) {
            this.f2040a.b = str;
            return this;
        }

        C0343a c(String str) {
            this.f2040a.c = str;
            return this;
        }

        C0343a d(String str) {
            this.f2040a.e = str;
            return this;
        }

        C0343a a(boolean z) {
            this.f2040a.f = z;
            return this;
        }

        C0343a b(boolean z) {
            this.f2040a.g = z;
            return this;
        }

        C0343a c(boolean z) {
            this.f2040a.h = z;
            return this;
        }

        C0343a d(boolean z) {
            this.f2040a.i = z;
            return this;
        }

        C0343a e(boolean z) {
            this.f2040a.j = z;
            return this;
        }

        C0343a f(boolean z) {
            this.f2040a.k = z;
            return this;
        }

        C0343a a(int i) {
            this.f2040a.l = i;
            return this;
        }

        C0343a b(int i) {
            this.f2040a.m = i;
            return this;
        }

        public a a() {
            return this.f2040a;
        }
    }

    /* JADX INFO: renamed from: n, reason: merged with bridge method [inline-methods] */
    public a clone() throws CloneNotSupportedException {
        return (a) super.clone();
    }
}
