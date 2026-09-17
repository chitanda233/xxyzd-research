package com.byazt.nn;

import androidx.core.view.PointerIconCompat;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, PointerIconCompat.TYPE_GRAB, 91})
public class sp {
    public int c;
    public int tt;
    public String ve;

    public sp(int i) {
        this(i, 0, null);
    }

    public sp(int i, int i2) {
        this(i, i2, null);
    }

    public sp(int i, String str) {
        this(i, 0, str);
    }

    public sp(int i, int i2, String str) {
        this.c = i;
        this.tt = i2;
        this.ve = str;
    }

    public int getType() {
        return this.c;
    }

    public int c() {
        return this.tt;
    }

    public String tt() {
        return this.ve;
    }
}
