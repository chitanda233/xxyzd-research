package com.sigmob.sdk.videoAd;

/* JADX INFO: loaded from: classes4.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3633a;
    private String b;
    private String c;
    private String title;

    public c(String title, String context, String cancel, String close) {
        this.title = title;
        this.f3633a = context;
        this.b = cancel;
        this.c = close;
    }

    public String a() {
        return this.title;
    }

    public void a(String title) {
        this.title = title;
    }

    public String b() {
        return this.f3633a;
    }

    public void b(String context) {
        this.f3633a = context;
    }

    public String c() {
        return this.b;
    }

    public void c(String cancel) {
        this.b = cancel;
    }

    public String d() {
        return this.c;
    }

    public void d(String close) {
        this.c = close;
    }

    public String toString() {
        return "DialogConfig{title='" + this.title + "', context='" + this.f3633a + "', cancelTxt='" + this.b + "', closeTxtl='" + this.c + "'}";
    }
}
