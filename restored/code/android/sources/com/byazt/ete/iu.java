package com.byazt.ete;

import kotlinx.coroutines.scheduling.WorkQueueKt;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 8, WorkQueueKt.MASK})
public class iu {
    public int c;
    public int tt;
    public int ve;
    public int uj = 1;
    public int n = 0;

    public int c() {
        return this.c;
    }

    public void c(int i) {
        if (i != 1 && i != 2 && i != 3 && i != 4) {
            this.c = 2;
        } else {
            this.c = i;
        }
    }

    public int tt() {
        return this.tt;
    }

    public void tt(int i) {
        if (i <= 0 || i >= sp()) {
            this.tt = 16;
        } else {
            this.tt = i;
        }
    }

    public int ve() {
        return this.ve;
    }

    public void ve(int i) {
        if (i <= 0 || i >= a()) {
            int i2 = this.c;
            if (i2 == 3 || i2 == 4) {
                this.ve = 30;
                return;
            } else {
                this.ve = 16;
                return;
            }
        }
        this.ve = i;
    }

    private int a() {
        return com.byazt.aas.pf.uj(com.byazt.omf.gt.getContext(), com.byazt.aas.pf.n(com.byazt.omf.gt.getContext()));
    }

    private int sp() {
        return com.byazt.aas.pf.uj(com.byazt.omf.gt.getContext(), com.byazt.aas.pf.uj(com.byazt.omf.gt.getContext()));
    }

    public int uj() {
        return this.uj == 2 ? 2 : 1;
    }

    public void uj(int i) {
        this.uj = i;
    }

    public int n() {
        return this.n;
    }

    public void n(int i) {
        this.n = i;
    }

    public static boolean c(ic icVar) {
        return (icVar == null || icVar.cg() == null || icVar.cg().n() != 1) ? false : true;
    }
}
