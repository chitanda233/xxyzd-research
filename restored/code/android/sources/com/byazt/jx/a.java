package com.byazt.jx;

import java.util.List;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 214, 34})
public class a implements ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final com.byazt.kd.a f1082a;
    public final String c;
    public final float da;
    public final rh.tt i;
    public final com.byazt.kd.a n;
    public final List<com.byazt.kd.tt> sl;
    public final com.byazt.kd.tt sp;
    public final com.byazt.kd.tt t;
    public final sp tt;
    public final boolean u;
    public final com.byazt.kd.uj uj;
    public final com.byazt.kd.ve ve;
    public final rh.c x;

    public a(String str, sp spVar, com.byazt.kd.ve veVar, com.byazt.kd.uj ujVar, com.byazt.kd.a aVar, com.byazt.kd.a aVar2, com.byazt.kd.tt ttVar, rh.c cVar, rh.tt ttVar2, float f, List<com.byazt.kd.tt> list, com.byazt.kd.tt ttVar3, boolean z) {
        this.c = str;
        this.tt = spVar;
        this.ve = veVar;
        this.uj = ujVar;
        this.n = aVar;
        this.f1082a = aVar2;
        this.sp = ttVar;
        this.x = cVar;
        this.i = ttVar2;
        this.da = f;
        this.sl = list;
        this.t = ttVar3;
        this.u = z;
    }

    public String c() {
        return this.c;
    }

    public sp tt() {
        return this.tt;
    }

    public com.byazt.kd.ve ve() {
        return this.ve;
    }

    public com.byazt.kd.uj uj() {
        return this.uj;
    }

    public com.byazt.kd.a n() {
        return this.n;
    }

    public com.byazt.kd.a a() {
        return this.f1082a;
    }

    public com.byazt.kd.tt sp() {
        return this.sp;
    }

    public rh.c x() {
        return this.x;
    }

    public rh.tt i() {
        return this.i;
    }

    public List<com.byazt.kd.tt> da() {
        return this.sl;
    }

    public com.byazt.kd.tt sl() {
        return this.t;
    }

    public float t() {
        return this.da;
    }

    public boolean u() {
        return this.u;
    }

    @Override // com.byazt.jx.ve
    public com.byazt.zy.ve c(com.byazt.ga.x xVar, com.byazt.ga.a aVar, com.byazt.zk.ve veVar) {
        return new com.byazt.zy.i(xVar, veVar, this);
    }
}
