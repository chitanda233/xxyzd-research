package com.byazt.cc;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 448, 13})
public class tt {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public com.byazt.ete.x.uj f728a;
    public com.byazt.vvt.a.c n;
    public int uj;
    public int c = 0;
    public long tt = 0;
    public int ve = -1;

    /* JADX WARN: Code restructure failed: missing block: B:55:0x00b1, code lost:
    
        r3 = true;
     */
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    public int c(com.byazt.dj.tt r11, int r12) {
        /*
            Method dump skipped, instruction units count: 260
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: com.byazt.cc.tt.c(com.byazt.dj.tt, int):int");
    }

    public boolean c() {
        return this.c == 4;
    }

    public boolean tt() {
        com.byazt.ete.x.uj ujVar;
        if (this.tt <= 0 || this.c != 3) {
            return false;
        }
        com.byazt.vvt.a.c cVar = this.n;
        c((cVar == null || (ujVar = this.f728a) == null) ? -1 : cVar.c(ujVar.n(), this.f728a));
        this.ve = 2;
        return true;
    }

    private void c(int i) {
        if (i > 0) {
            this.tt = System.currentTimeMillis() - ((((long) i) * 60) * 1000);
        } else if (i == 0) {
            this.tt = 0L;
        } else {
            this.tt = System.currentTimeMillis();
        }
    }
}
