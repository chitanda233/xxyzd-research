package com.byazt.jx;

import android.graphics.PointF;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 214, 158})
public class sl implements ve {
    public final String c;
    public final boolean n;
    public final com.byazt.kd.u<PointF, PointF> tt;
    public final com.byazt.kd.tt uj;
    public final com.byazt.kd.u<PointF, PointF> ve;

    public sl(String str, com.byazt.kd.u<PointF, PointF> uVar, com.byazt.kd.u<PointF, PointF> uVar2, com.byazt.kd.tt ttVar, boolean z) {
        this.c = str;
        this.tt = uVar;
        this.ve = uVar2;
        this.uj = ttVar;
        this.n = z;
    }

    public String c() {
        return this.c;
    }

    public com.byazt.kd.tt tt() {
        return this.uj;
    }

    public com.byazt.kd.u<PointF, PointF> ve() {
        return this.ve;
    }

    public com.byazt.kd.u<PointF, PointF> uj() {
        return this.tt;
    }

    public boolean n() {
        return this.n;
    }

    @Override // com.byazt.jx.ve
    public com.byazt.zy.ve c(com.byazt.ga.x xVar, com.byazt.ga.a aVar, com.byazt.zk.ve veVar) {
        return new com.byazt.zy.z(xVar, veVar, this);
    }

    public String toString() {
        return "RectangleShape{position=" + this.tt + ", size=" + this.ve + '}';
    }
}
