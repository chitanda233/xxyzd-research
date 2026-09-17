package com.byazt.uy;

/* JADX INFO: loaded from: classes2.dex */
public enum ve {
    LAUNCH("launch"),
    JAVA("java"),
    NATIVE("native"),
    ANR("anr"),
    BLOCK("block"),
    ENSURE("ensure"),
    DART("dart"),
    CUSTOM_JAVA("custom_java"),
    ALL("all");

    public String da;

    ve(String str) {
        this.da = str;
    }

    public String c() {
        return this.da;
    }
}
