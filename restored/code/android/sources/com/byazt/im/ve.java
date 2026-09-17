package com.byazt.im;

import android.content.Context;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1352, 54})
public class ve extends c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public Context f1038a;
    public com.byazt.dj.tt da;
    public int i;
    public a n;
    public boolean sl;
    public String sp;
    public boolean t;
    public x uj;
    public int x = 1;

    public ve(Context context, String str, a aVar, x xVar, com.byazt.dj.tt ttVar, boolean z) {
        this.f1038a = context;
        this.sp = str;
        this.n = aVar;
        this.sl = aVar.n();
        this.tt = aVar.tt();
        this.uj = xVar;
        this.da = ttVar;
        this.t = z;
    }

    public a uj() {
        return this.n;
    }

    public x n() {
        return this.uj;
    }

    public Context getContext() {
        return this.f1038a;
    }

    public String a() {
        return this.sp;
    }

    public com.byazt.dj.tt sp() {
        return this.da;
    }

    public int x() {
        return this.i;
    }

    public boolean i() {
        return this.sl;
    }

    public boolean da() {
        return this.t;
    }
}
