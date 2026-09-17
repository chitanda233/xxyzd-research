package com.qq.gdt.action.c;

/* JADX INFO: loaded from: classes3.dex */
public class a extends Exception {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3025a;

    public a(String str, Throwable th) {
        super(str, th);
        this.f3025a = str;
    }

    @Override // java.lang.Throwable
    public String getMessage() {
        return this.f3025a;
    }
}
