package com.byazt.nn;

import androidx.core.view.PointerIconCompat;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, PointerIconCompat.TYPE_GRAB, 54})
public class ve {
    public static int c = 0;
    public static int tt = 1;
    public static int ve = 2;
    public int uj = c;
    public long n = 0;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public JSONObject f1219a = null;
    public int sp = 0;
    public String x = "";
    public String i = "";

    public boolean c() {
        return this.uj == tt;
    }

    public int tt() {
        return this.sp;
    }

    public ve c(int i) {
        this.uj = i;
        return this;
    }

    public ve tt(int i) {
        this.sp = i;
        return this;
    }
}
