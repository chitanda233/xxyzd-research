package com.byazt.is;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 984, 54})
public class ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f1044a;
    public int c;
    public long i;
    public int n;
    public int sp;
    public String x;
    public long tt = 0;
    public long ve = 0;
    public long uj = 0;
    public final long da = 30;

    public long n() {
        return 28L;
    }

    public int c() {
        return this.c;
    }

    public void c(int i) {
        this.c = i;
    }

    public long tt() {
        long j = this.ve;
        return j > 0 ? j : this.uj;
    }

    public long ve() {
        return uj() + tt();
    }

    public long uj() {
        return ((long) this.n) + 30 + ((long) this.sp);
    }

    public void tt(int i) {
        this.sp = i;
    }

    public int a() {
        return this.sp;
    }

    public long sp() {
        return this.tt;
    }

    public void c(long j) {
        this.tt = j;
    }

    public long x() {
        return this.ve;
    }

    public void tt(long j) {
        this.ve = j;
    }

    public long i() {
        return this.uj;
    }

    public void ve(long j) {
        this.uj = j;
    }

    public int da() {
        return this.n;
    }

    public void ve(int i) {
        this.n = i;
    }

    public int sl() {
        return this.f1044a;
    }

    public void uj(int i) {
        this.f1044a = i;
    }

    public String t() {
        return this.x;
    }

    public void c(String str) {
        this.x = str;
    }

    public long u() {
        return this.i;
    }

    public void uj(long j) {
        this.i = j;
    }
}
