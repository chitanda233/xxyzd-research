package com.byazt.im;

import android.text.TextUtils;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1352, 91})
public class sp extends c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public boolean f1035a;
    public long da;
    public com.byazt.nc.tt i;
    public String n;
    public int sl;
    public int sp;
    public int uj;
    public boolean x;

    public sp() {
        this.uj = -1;
        this.n = "unknown";
        this.f1035a = false;
        this.x = false;
        this.sl = -1;
    }

    public sp(int i, String str, boolean z) {
        this.f1035a = false;
        this.sl = -1;
        this.uj = i;
        this.n = str;
        this.x = z;
    }

    public int uj() {
        return this.uj;
    }

    public void tt(int i) {
        this.uj = i;
    }

    public void ve(int i) {
        this.sl = i;
    }

    public String n() {
        return TextUtils.isEmpty(this.n) ? "unknown" : this.n;
    }

    public void c(String str) {
        this.n = str;
    }

    public boolean a() {
        return this.f1035a;
    }

    public void c(boolean z) {
        this.f1035a = z;
    }

    public int sp() {
        return this.sp;
    }

    public void uj(int i) {
        this.sp = i;
    }

    public boolean x() {
        return this.x;
    }

    public void tt(boolean z) {
        this.x = z;
    }

    public com.byazt.nc.tt i() {
        return this.i;
    }

    public void c(com.byazt.nc.tt ttVar) {
        this.i = ttVar;
    }

    @Override // com.byazt.im.c
    public long ve() {
        return this.da;
    }

    @Override // com.byazt.im.c
    public void c(long j) {
        this.da = j;
    }
}
