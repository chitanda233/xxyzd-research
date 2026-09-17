package com.qq.e.comm.util;

/* JADX INFO: loaded from: classes3.dex */
public class AdError {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f3005a;
    private String b;

    public AdError() {
    }

    public int getErrorCode() {
        return this.f3005a;
    }

    public String getErrorMsg() {
        return this.b;
    }

    public AdError(int i, String str) {
        this.f3005a = i;
        this.b = str;
    }
}
