package com.qq.gdt.action.e;

/* JADX INFO: loaded from: classes3.dex */
public class f {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f3065a;
    private String b;
    private String c;

    public f() {
        this.f3065a = -1;
        this.b = "Unknown message";
        this.c = "";
    }

    public f(int i, String str, String str2) {
        this.f3065a = i;
        this.b = str;
        this.c = str2;
    }

    public int a() {
        return this.f3065a;
    }

    public f a(int i) {
        this.f3065a = i;
        return this;
    }

    public f a(String str) {
        this.b = str;
        return this;
    }

    public f b(String str) {
        this.c = str;
        return this;
    }

    public String b() {
        return this.b;
    }

    public String c() {
        return this.c;
    }
}
