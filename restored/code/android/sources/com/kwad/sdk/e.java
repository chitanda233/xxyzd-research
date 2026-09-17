package com.kwad.sdk;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    public static final e aFP = new e(10000, "其他异常");
    public static final e aFQ = new e(10001, "初始化参数异常");
    public static final e aFR = new e(11001, "SDK未调用init方法");
    public int code;
    public String msg;

    public e(int i, String str) {
        this.code = i;
        this.msg = str;
    }
}
