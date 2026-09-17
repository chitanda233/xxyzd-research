package com.byazt.umr;

import com.byazt.eg.h;
import com.byazt.eg.rh;
import com.byazt.eg.yv;
import java.util.Date;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1046, 54})
public final class ve {
    public final yv c;
    public final h tt;

    public ve(yv yvVar, h hVar) {
        this.c = yvVar;
        this.tt = hVar;
    }

    /* JADX WARN: Code restructure failed: missing block: B:31:0x0056, code lost:
    
        if (r3.t().uj() == false) goto L32;
     */
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    public static boolean c(com.byazt.eg.h r3, com.byazt.eg.yv r4) {
        /*
            int r0 = r3.ve()
            r1 = 200(0xc8, float:2.8E-43)
            r2 = 0
            if (r0 == r1) goto L59
            r1 = 410(0x19a, float:5.75E-43)
            if (r0 == r1) goto L59
            r1 = 414(0x19e, float:5.8E-43)
            if (r0 == r1) goto L59
            r1 = 501(0x1f5, float:7.02E-43)
            if (r0 == r1) goto L59
            r1 = 203(0xcb, float:2.84E-43)
            if (r0 == r1) goto L59
            r1 = 204(0xcc, float:2.86E-43)
            if (r0 == r1) goto L59
            r1 = 307(0x133, float:4.3E-43)
            if (r0 == r1) goto L31
            r1 = 308(0x134, float:4.32E-43)
            if (r0 == r1) goto L59
            r1 = 404(0x194, float:5.66E-43)
            if (r0 == r1) goto L59
            r1 = 405(0x195, float:5.68E-43)
            if (r0 == r1) goto L59
            switch(r0) {
                case 300: goto L59;
                case 301: goto L59;
                case 302: goto L31;
                default: goto L30;
            }
        L30:
            goto L58
        L31:
            java.lang.String r0 = "Expires"
            java.lang.String r0 = r3.c(r0)
            if (r0 != 0) goto L59
            com.byazt.eg.uj r0 = r3.t()
            int r0 = r0.ve()
            r1 = -1
            if (r0 != r1) goto L59
            com.byazt.eg.uj r0 = r3.t()
            boolean r0 = r0.n()
            if (r0 != 0) goto L59
            com.byazt.eg.uj r0 = r3.t()
            boolean r0 = r0.uj()
            if (r0 != 0) goto L59
        L58:
            return r2
        L59:
            com.byazt.eg.uj r3 = r3.t()
            boolean r3 = r3.tt()
            if (r3 != 0) goto L6f
            com.byazt.eg.uj r3 = r4.sp()
            boolean r3 = r3.tt()
            if (r3 != 0) goto L6f
            r3 = 1
            return r3
        L6f:
            return r2
        */
        throw new UnsupportedOperationException("Method not decompiled: com.byazt.umr.ve.c(com.byazt.eg.h, com.byazt.eg.yv):boolean");
    }

    @com.byazt.zqa.c(c = {0, 1, 1046, 24})
    public static class c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public Date f1478a;
        public final long c;
        public long da;
        public long i;
        public String n;
        public String sl;
        public String sp;
        public int t;
        public final yv tt;
        public Date uj;
        public final h ve;
        public Date x;

        public c(long j, yv yvVar, h hVar) {
            this.t = -1;
            this.c = j;
            this.tt = yvVar;
            this.ve = hVar;
            if (hVar != null) {
                this.i = hVar.u();
                this.da = hVar.yp();
                rh rhVarSp = hVar.sp();
                int iC = rhVarSp.c();
                for (int i = 0; i < iC; i++) {
                    String strC = rhVarSp.c(i);
                    String strTt = rhVarSp.tt(i);
                    if ("Date".equalsIgnoreCase(strC)) {
                        this.uj = com.byazt.yx.uj.c(strTt);
                        this.n = strTt;
                    } else if ("Expires".equalsIgnoreCase(strC)) {
                        this.x = com.byazt.yx.uj.c(strTt);
                    } else if ("Last-Modified".equalsIgnoreCase(strC)) {
                        this.f1478a = com.byazt.yx.uj.c(strTt);
                        this.sp = strTt;
                    } else if ("ETag".equalsIgnoreCase(strC)) {
                        this.sl = strTt;
                    } else if ("Age".equalsIgnoreCase(strC)) {
                        this.t = com.byazt.yx.n.tt(strTt, -1);
                    }
                }
            }
        }

        public ve c() {
            ve veVarTt = tt();
            return (veVarTt.c == null || !this.tt.sp().i()) ? veVarTt : new ve(null, null);
        }

        private ve tt() {
            String str;
            if (this.ve == null) {
                return new ve(this.tt, null);
            }
            if (this.tt.x() && this.ve.a() == null) {
                return new ve(this.tt, null);
            }
            if (!ve.c(this.ve, this.tt)) {
                return new ve(this.tt, null);
            }
            com.byazt.eg.uj ujVarSp = this.tt.sp();
            if (ujVarSp.c() || c(this.tt)) {
                return new ve(this.tt, null);
            }
            com.byazt.eg.uj ujVarT = this.ve.t();
            if (ujVarT.da()) {
                return new ve(null, this.ve);
            }
            long jUj = uj();
            long jVe = ve();
            if (ujVarSp.ve() != -1) {
                jVe = Math.min(jVe, TimeUnit.SECONDS.toMillis(ujVarSp.ve()));
            }
            long millis = 0;
            long millis2 = ujVarSp.x() != -1 ? TimeUnit.SECONDS.toMillis(ujVarSp.x()) : 0L;
            if (!ujVarT.a() && ujVarSp.sp() != -1) {
                millis = TimeUnit.SECONDS.toMillis(ujVarSp.sp());
            }
            if (!ujVarT.c()) {
                long j = millis2 + jUj;
                if (j < millis + jVe) {
                    h.c cVarI = this.ve.i();
                    if (j >= jVe) {
                        cVarI.c("Warning", "110 HttpURLConnection \"Response is stale\"");
                    }
                    if (jUj > 86400000 && n()) {
                        cVarI.c("Warning", "113 HttpURLConnection \"Heuristic expiration\"");
                    }
                    return new ve(null, cVarI.c());
                }
            }
            String str2 = this.sl;
            if (str2 != null) {
                str = "If-None-Match";
            } else {
                if (this.f1478a != null) {
                    str2 = this.sp;
                } else if (this.uj != null) {
                    str2 = this.n;
                } else {
                    return new ve(this.tt, null);
                }
                str = "If-Modified-Since";
            }
            rh.c cVarTt = this.tt.ve().tt();
            com.byazt.kh.c.c.c(cVarTt, str, str2);
            return new ve(this.tt.a().c(cVarTt.c()).c(), this.ve);
        }

        private long ve() {
            com.byazt.eg.uj ujVarT = this.ve.t();
            if (ujVarT.ve() != -1) {
                return TimeUnit.SECONDS.toMillis(ujVarT.ve());
            }
            if (this.x != null) {
                Date date = this.uj;
                long time = this.x.getTime() - (date != null ? date.getTime() : this.da);
                if (time > 0) {
                    return time;
                }
                return 0L;
            }
            if (this.f1478a != null && this.ve.c().c().query() == null) {
                Date date2 = this.uj;
                long time2 = (date2 != null ? date2.getTime() : this.i) - this.f1478a.getTime();
                if (time2 > 0) {
                    return time2 / 10;
                }
            }
            return 0L;
        }

        private long uj() {
            Date date = this.uj;
            long jMax = date != null ? Math.max(0L, this.da - date.getTime()) : 0L;
            if (this.t != -1) {
                jMax = Math.max(jMax, TimeUnit.SECONDS.toMillis(this.t));
            }
            long j = this.da;
            return jMax + (j - this.i) + (this.c - j);
        }

        private boolean n() {
            return this.ve.t().ve() == -1 && this.x == null;
        }

        private static boolean c(yv yvVar) {
            return (yvVar.c("If-Modified-Since") == null && yvVar.c("If-None-Match") == null) ? false : true;
        }
    }
}
