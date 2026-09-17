package com.byazt.xy;

/* JADX INFO: loaded from: classes2.dex */
public enum ve {
    JSON(".json"),
    ZIP(".zip");

    public final String ve;

    ve(String str) {
        this.ve = str;
    }

    public String c() {
        return ".temp" + this.ve;
    }

    @Override // java.lang.Enum
    public String toString() {
        return this.ve;
    }
}
