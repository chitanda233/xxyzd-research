package com.byazt.jx;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 214, 66})
public class t implements ve {
    public final String c;
    public final boolean n;
    public final com.byazt.kd.tt tt;
    public final com.byazt.kd.t uj;
    public final com.byazt.kd.tt ve;

    public t(String str, com.byazt.kd.tt ttVar, com.byazt.kd.tt ttVar2, com.byazt.kd.t tVar, boolean z) {
        this.c = str;
        this.tt = ttVar;
        this.ve = ttVar2;
        this.uj = tVar;
        this.n = z;
    }

    public String c() {
        return this.c;
    }

    public com.byazt.kd.tt tt() {
        return this.tt;
    }

    public com.byazt.kd.tt ve() {
        return this.ve;
    }

    public com.byazt.kd.t uj() {
        return this.uj;
    }

    public boolean n() {
        return this.n;
    }

    @Override // com.byazt.jx.ve
    public com.byazt.zy.ve c(com.byazt.ga.x xVar, com.byazt.ga.a aVar, com.byazt.zk.ve veVar) {
        return new com.byazt.zy.m(xVar, veVar, this);
    }
}
