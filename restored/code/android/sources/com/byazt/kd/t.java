package com.byazt.kd;

import android.graphics.PointF;
import com.byazt.dg.m;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1714, 66})
public class t implements com.byazt.jx.ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final tt f1103a;
    public final n c;
    public final tt i;
    public final uj n;
    public final tt sp;
    public final u<PointF, PointF> tt;
    public final tt uj;
    public final sp ve;
    public final tt x;

    @Override // com.byazt.jx.ve
    public com.byazt.zy.ve c(com.byazt.ga.x xVar, com.byazt.ga.a aVar, com.byazt.zk.ve veVar) {
        return null;
    }

    public t() {
        this(null, null, null, null, null, null, null, null, null);
    }

    public t(n nVar, u<PointF, PointF> uVar, sp spVar, tt ttVar, uj ujVar, tt ttVar2, tt ttVar3, tt ttVar4, tt ttVar5) {
        this.c = nVar;
        this.tt = uVar;
        this.ve = spVar;
        this.uj = ttVar;
        this.n = ujVar;
        this.x = ttVar2;
        this.i = ttVar3;
        this.f1103a = ttVar4;
        this.sp = ttVar5;
    }

    public n c() {
        return this.c;
    }

    public u<PointF, PointF> tt() {
        return this.tt;
    }

    public sp ve() {
        return this.ve;
    }

    public tt uj() {
        return this.uj;
    }

    public uj n() {
        return this.n;
    }

    public tt a() {
        return this.x;
    }

    public tt sp() {
        return this.i;
    }

    public tt x() {
        return this.f1103a;
    }

    public tt i() {
        return this.sp;
    }

    public m da() {
        return new m(this);
    }
}
