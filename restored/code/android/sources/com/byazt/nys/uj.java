package com.byazt.nys;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 430, 15})
public class uj extends Exception {
    public final int c;

    public uj(int i, String str) {
        super(str);
        this.c = i;
    }

    public uj(int i, String str, Throwable th) {
        super(str, th);
        this.c = i;
    }

    public int c() {
        return this.c;
    }
}
