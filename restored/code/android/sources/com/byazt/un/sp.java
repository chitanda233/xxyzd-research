package com.byazt.un;

import com.byazt.nr.m;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 96, 91})
public class sp {
    public a c;

    public sp(a aVar) {
        this.c = aVar;
    }

    public boolean c() {
        boolean zC = this.c.p != null ? this.c.p.c() : false;
        m.c("ClickCreativeListener", "isVisible=" + zC + ",mPlayBtn.getVisibility() == VISIBLE->" + (this.c.ve.getVisibility() == 0));
        return zC || this.c.ve.getVisibility() == 0;
    }

    public boolean tt() {
        if (com.byazt.ex.c.c(this.c.zm)) {
            return true;
        }
        return (this.c.x != null && this.c.x.getVisibility() == 0) || (this.c.da != null && this.c.da.getVisibility() == 0) || ((this.c.sl != null && this.c.sl.getVisibility() == 0) || (this.c.t != null && this.c.t.getVisibility() == 0));
    }
}
