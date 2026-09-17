package com.byazt.zz;

import android.os.SystemClock;
import android.support.v4.media.session.PlaybackStateCompat;
import com.byazt.m.BaseException;
import com.byazt.t.DownloadInfo;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.io.Closeable;
import java.io.IOException;
import java.io.InputStream;
import java.util.concurrent.ExecutorService;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SHARP, 46})
public class n {
    public static String tt = "ResponseHandler";

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final com.byazt.hs.i f1647a;
    public long d;
    public com.byazt.t.n da;
    public final long gr;
    public final com.byazt.k.c gt;
    public final long gu;
    public long h;
    public gt i;
    public long m;
    public long md;
    public final boolean my;
    public final com.byazt.t.tt n;
    public volatile long nu;
    public long p;
    public final boolean qy;
    public volatile long rh;
    public final com.byazt.g.c rl;
    public BaseException sl;
    public da sp;
    public volatile boolean t;
    public volatile boolean u;
    public final String uj;
    public final DownloadInfo ve;
    public com.byazt.b.sl x;
    public final com.byazt.u.a yp;
    public boolean yv;
    public long z;
    public final boolean zm;
    public boolean c = false;
    public volatile long eo = 0;
    public volatile long zb = 0;

    private boolean tt(long j, long j2) {
        return j > PlaybackStateCompat.ACTION_PREPARE_FROM_SEARCH && j2 > 500;
    }

    public n(DownloadInfo downloadInfo, String str, com.byazt.hs.i iVar, com.byazt.t.tt ttVar, com.byazt.u.a aVar) {
        this.ve = downloadInfo;
        this.uj = str;
        da daVarZm = ve.zm();
        this.sp = daVarZm;
        if (daVarZm instanceof com.byazt.b.uj) {
            com.byazt.b.uj ujVar = (com.byazt.b.uj) daVarZm;
            this.x = ujVar.c();
            this.i = ujVar.a();
        }
        this.f1647a = iVar;
        this.n = ttVar;
        this.yp = aVar;
        long jYp = ttVar.yp();
        this.z = jYp;
        this.m = jYp;
        if (ttVar.uj()) {
            this.rh = ttVar.nu();
        } else {
            this.rh = ttVar.ve(false);
        }
        this.nu = ttVar.m();
        this.rl = com.byazt.g.c.c();
        com.byazt.k.c cVarC = com.byazt.k.c.c(downloadInfo.getId());
        this.gt = cVarC;
        boolean z = cVarC.c("sync_strategy", 0) == 1;
        this.qy = z;
        if (z) {
            long jC = cVarC.c("sync_interval_ms_fg", 5000);
            long jC2 = cVarC.c("sync_interval_ms_bg", 1000);
            this.gu = Math.max(jC, 500L);
            this.gr = Math.max(jC2, 500L);
        } else {
            this.gu = 0L;
            this.gr = 0L;
        }
        this.zm = cVarC.tt("monitor_rw") == 1;
        this.my = com.byazt.w.c.c(65536);
    }

    public long c() {
        return this.z;
    }

    private boolean a() {
        return this.t || this.u;
    }

    public void tt() {
        if (this.t) {
            return;
        }
        this.t = true;
        sp();
    }

    public void ve() {
        if (this.u) {
            return;
        }
        synchronized (this.yp) {
            this.u = true;
        }
        sp();
    }

    private void sp() {
        ExecutorService executorServiceT;
        if (this.f1647a == null || (executorServiceT = ve.t()) == null) {
            return;
        }
        executorServiceT.execute(new Runnable() { // from class: com.byazt.zz.n.1
            @Override // java.lang.Runnable
            public void run() {
                try {
                    n.this.f1647a.uj();
                } catch (Throwable unused) {
                }
            }
        });
    }

    public void c(long j, long j2, long j3) {
        this.z = j;
        this.m = j;
        this.nu = j2;
        this.rh = j3;
    }

    public void c(long j, long j2) {
        this.nu = j;
        this.rh = j2;
    }

    /* JADX WARN: Code duplicated, block: B:103:0x01c0 A[Catch: all -> 0x0221, BaseException -> 0x0223, TryCatch #36 {BaseException -> 0x0223, all -> 0x0221, blocks: (B:93:0x0193, B:94:0x01a0, B:101:0x01b8, B:103:0x01c0, B:105:0x01c8, B:107:0x01d0, B:109:0x01d8, B:111:0x01e3, B:115:0x01eb, B:119:0x01f7, B:123:0x01fd, B:124:0x0200, B:126:0x0212, B:127:0x0217, B:128:0x0218, B:129:0x021d, B:132:0x0220, B:95:0x01a1, B:97:0x01a5, B:100:0x01b7, B:99:0x01a9), top: B:362:0x0193, inners: #34, #36 }] */
    /* JADX WARN: Code duplicated, block: B:105:0x01c8 A[Catch: all -> 0x0221, BaseException -> 0x0223, TryCatch #36 {BaseException -> 0x0223, all -> 0x0221, blocks: (B:93:0x0193, B:94:0x01a0, B:101:0x01b8, B:103:0x01c0, B:105:0x01c8, B:107:0x01d0, B:109:0x01d8, B:111:0x01e3, B:115:0x01eb, B:119:0x01f7, B:123:0x01fd, B:124:0x0200, B:126:0x0212, B:127:0x0217, B:128:0x0218, B:129:0x021d, B:132:0x0220, B:95:0x01a1, B:97:0x01a5, B:100:0x01b7, B:99:0x01a9), top: B:362:0x0193, inners: #34, #36 }] */
    /* JADX WARN: Code duplicated, block: B:193:0x0301  */
    /* JADX WARN: Code duplicated, block: B:195:0x0305  */
    /* JADX WARN: Code duplicated, block: B:197:0x030a  */
    /* JADX WARN: Code duplicated, block: B:200:0x0311 A[Catch: all -> 0x0356, TryCatch #30 {all -> 0x0356, blocks: (B:198:0x030d, B:200:0x0311, B:201:0x0313, B:211:0x0328, B:212:0x0329, B:214:0x0332, B:202:0x0314, B:204:0x0318, B:206:0x0321, B:207:0x0324), top: B:355:0x030d, inners: #9 }] */
    /* JADX WARN: Code duplicated, block: B:204:0x0318 A[Catch: all -> 0x0326, TryCatch #9 {, blocks: (B:202:0x0314, B:204:0x0318, B:206:0x0321, B:207:0x0324), top: B:338:0x0314, outer: #30 }] */
    /* JADX WARN: Code duplicated, block: B:206:0x0321 A[Catch: all -> 0x0326, TryCatch #9 {, blocks: (B:202:0x0314, B:204:0x0318, B:206:0x0321, B:207:0x0324), top: B:338:0x0314, outer: #30 }] */
    /* JADX WARN: Code duplicated, block: B:212:0x0329 A[Catch: all -> 0x0356, TryCatch #30 {all -> 0x0356, blocks: (B:198:0x030d, B:200:0x0311, B:201:0x0313, B:211:0x0328, B:212:0x0329, B:214:0x0332, B:202:0x0314, B:204:0x0318, B:206:0x0321, B:207:0x0324), top: B:355:0x030d, inners: #9 }] */
    /* JADX WARN: Code duplicated, block: B:214:0x0332 A[Catch: all -> 0x0356, TRY_LEAVE, TryCatch #30 {all -> 0x0356, blocks: (B:198:0x030d, B:200:0x0311, B:201:0x0313, B:211:0x0328, B:212:0x0329, B:214:0x0332, B:202:0x0314, B:204:0x0318, B:206:0x0321, B:207:0x0324), top: B:355:0x030d, inners: #9 }] */
    /* JADX WARN: Code duplicated, block: B:220:0x0363 A[Catch: all -> 0x04e0, TRY_ENTER, TryCatch #1 {all -> 0x04e0, blocks: (B:191:0x02ec, B:220:0x0363, B:222:0x0369, B:223:0x036c, B:264:0x045f, B:265:0x0461, B:269:0x0467, B:271:0x0480, B:299:0x04d4, B:301:0x04da, B:302:0x04dd, B:303:0x04df), top: B:335:0x0028, inners: #20 }] */
    /* JADX WARN: Code duplicated, block: B:222:0x0369 A[Catch: all -> 0x04e0, TRY_LEAVE, TryCatch #1 {all -> 0x04e0, blocks: (B:191:0x02ec, B:220:0x0363, B:222:0x0369, B:223:0x036c, B:264:0x045f, B:265:0x0461, B:269:0x0467, B:271:0x0480, B:299:0x04d4, B:301:0x04da, B:302:0x04dd, B:303:0x04df), top: B:335:0x0028, inners: #20 }] */
    /* JADX WARN: Code duplicated, block: B:226:0x0375  */
    /* JADX WARN: Code duplicated, block: B:228:0x037a  */
    /* JADX WARN: Code duplicated, block: B:231:0x0381 A[Catch: all -> 0x0451, TryCatch #26 {all -> 0x0451, blocks: (B:229:0x037d, B:231:0x0381, B:232:0x0383, B:242:0x0398, B:243:0x0399, B:245:0x03a2, B:233:0x0384, B:235:0x0388, B:237:0x0391, B:238:0x0394), top: B:350:0x037d, inners: #29 }] */
    /* JADX WARN: Code duplicated, block: B:235:0x0388 A[Catch: all -> 0x0396, TryCatch #29 {, blocks: (B:233:0x0384, B:235:0x0388, B:237:0x0391, B:238:0x0394), top: B:353:0x0384, outer: #26 }] */
    /* JADX WARN: Code duplicated, block: B:237:0x0391 A[Catch: all -> 0x0396, TryCatch #29 {, blocks: (B:233:0x0384, B:235:0x0388, B:237:0x0391, B:238:0x0394), top: B:353:0x0384, outer: #26 }] */
    /* JADX WARN: Code duplicated, block: B:243:0x0399 A[Catch: all -> 0x0451, TryCatch #26 {all -> 0x0451, blocks: (B:229:0x037d, B:231:0x0381, B:232:0x0383, B:242:0x0398, B:243:0x0399, B:245:0x03a2, B:233:0x0384, B:235:0x0388, B:237:0x0391, B:238:0x0394), top: B:350:0x037d, inners: #29 }] */
    /* JADX WARN: Code duplicated, block: B:245:0x03a2 A[Catch: all -> 0x0451, TRY_LEAVE, TryCatch #26 {all -> 0x0451, blocks: (B:229:0x037d, B:231:0x0381, B:232:0x0383, B:242:0x0398, B:243:0x0399, B:245:0x03a2, B:233:0x0384, B:235:0x0388, B:237:0x0391, B:238:0x0394), top: B:350:0x037d, inners: #29 }] */
    /* JADX WARN: Code duplicated, block: B:249:0x03ed A[RETURN] */
    /* JADX WARN: Code duplicated, block: B:250:0x03ee  */
    /* JADX WARN: Code duplicated, block: B:252:0x03f9  */
    /* JADX WARN: Code duplicated, block: B:259:0x0450 A[ADDED_TO_REGION, ORIG_RETURN, RETURN] */
    /* JADX WARN: Code duplicated, block: B:301:0x04da A[Catch: all -> 0x04e0, TryCatch #1 {all -> 0x04e0, blocks: (B:191:0x02ec, B:220:0x0363, B:222:0x0369, B:223:0x036c, B:264:0x045f, B:265:0x0461, B:269:0x0467, B:271:0x0480, B:299:0x04d4, B:301:0x04da, B:302:0x04dd, B:303:0x04df), top: B:335:0x0028, inners: #20 }] */
    /* JADX WARN: Code duplicated, block: B:338:0x0314 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:353:0x0384 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:360:0x01a1 A[EXC_TOP_SPLITTER, SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:379:0x022f A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:380:0x0218 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:381:0x0212 A[SYNTHETIC] */
    /* JADX WARN: Code duplicated, block: B:56:0x0119 A[Catch: all -> 0x0107, BaseException -> 0x010e, TRY_ENTER, TRY_LEAVE, TryCatch #29 {BaseException -> 0x010e, all -> 0x0107, blocks: (B:48:0x0102, B:56:0x0119), top: B:374:0x0102 }] */
    /* JADX WARN: Code duplicated, block: B:59:0x0129 A[Catch: all -> 0x02a2, BaseException -> 0x02a9, TRY_LEAVE, TryCatch #34 {BaseException -> 0x02a9, all -> 0x02a2, blocks: (B:54:0x0113, B:57:0x0125, B:59:0x0129), top: B:365:0x0113 }] */
    /* JADX WARN: Code duplicated, block: B:61:0x0131  */
    /* JADX WARN: Code duplicated, block: B:81:0x0168  */
    /* JADX WARN: Code duplicated, block: B:83:0x016f A[Catch: all -> 0x0176, BaseException -> 0x017a, TRY_LEAVE, TryCatch #33 {BaseException -> 0x017a, all -> 0x0176, blocks: (B:66:0x013a, B:68:0x0141, B:70:0x014e, B:83:0x016f, B:91:0x0187), top: B:367:0x013a }] */
    /* JADX WARN: Code duplicated, block: B:91:0x0187 A[Catch: all -> 0x0176, BaseException -> 0x017a, TRY_ENTER, TRY_LEAVE, TryCatch #33 {BaseException -> 0x017a, all -> 0x0176, blocks: (B:66:0x013a, B:68:0x0141, B:70:0x014e, B:83:0x016f, B:91:0x0187), top: B:367:0x013a }] */
    /* JADX WARN: Code duplicated, block: B:99:0x01a9 A[Catch: all -> 0x021e, TryCatch #36 {, blocks: (B:95:0x01a1, B:97:0x01a5, B:100:0x01b7, B:99:0x01a9), top: B:360:0x01a1, outer: #36 }] */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r21v0, types: [boolean] */
    /* JADX WARN: Type inference failed for: r21v1, types: [boolean] */
    /* JADX WARN: Type inference failed for: r21v2, types: [boolean] */
    /* JADX WARN: Type inference failed for: r4v0 */
    /* JADX WARN: Type inference failed for: r4v10 */
    /* JADX WARN: Type inference failed for: r4v11 */
    /* JADX WARN: Type inference failed for: r4v12 */
    /* JADX WARN: Type inference failed for: r4v14 */
    /* JADX WARN: Type inference failed for: r4v23 */
    /* JADX WARN: Type inference failed for: r4v24 */
    /* JADX WARN: Type inference failed for: r4v26 */
    /* JADX WARN: Type inference failed for: r4v28 */
    /* JADX WARN: Type inference failed for: r4v29 */
    /* JADX WARN: Type inference failed for: r4v3 */
    /* JADX WARN: Type inference failed for: r4v30 */
    /* JADX WARN: Type inference failed for: r4v31 */
    /* JADX WARN: Type inference failed for: r4v32 */
    /* JADX WARN: Type inference failed for: r4v33 */
    /* JADX WARN: Type inference failed for: r4v34 */
    /* JADX WARN: Type inference failed for: r4v35 */
    /* JADX WARN: Type inference failed for: r4v36 */
    /* JADX WARN: Type inference failed for: r4v37 */
    /* JADX WARN: Type inference failed for: r4v38 */
    /* JADX WARN: Type inference failed for: r4v39 */
    /* JADX WARN: Type inference failed for: r4v40 */
    /* JADX WARN: Type inference failed for: r4v41 */
    /* JADX WARN: Type inference failed for: r4v42 */
    /* JADX WARN: Type inference failed for: r4v43 */
    /* JADX WARN: Type inference failed for: r4v44 */
    /* JADX WARN: Type inference failed for: r4v7 */
    public void uj() throws BaseException {
        long j;
        long j2;
        int iC;
        com.byazt.ty.tt ttVarC;
        com.byazt.hs.i iVar;
        com.byazt.k.c cVar;
        DownloadInfo downloadInfo;
        String str;
        com.byazt.hs.i iVar2;
        boolean z;
        boolean z2;
        BaseException baseException;
        long j3;
        com.byazt.hs.i iVar3;
        boolean z3;
        boolean z4;
        com.byazt.hs.i iVar4;
        String str2;
        DownloadInfo downloadInfo2;
        com.byazt.k.c cVar2;
        ?? r4;
        ?? r5;
        ?? r6;
        ?? r7;
        long j4;
        boolean z5;
        com.byazt.h.c cVarC;
        int i;
        com.byazt.ty.tt ttVar;
        com.byazt.ty.tt ttVar2;
        long j5;
        if (a() || this.n == null) {
            return;
        }
        long jC = com.byazt.w.a.c(this.f1647a);
        ?? r8 = 0;
        if (jC == 0) {
            throw new com.byazt.m.a(1004, "the content-length is 0");
        }
        long jT = this.n.t();
        long jNanoTime = System.nanoTime();
        boolean z6 = this.zm;
        int i2 = 1;
        try {
            try {
                DownloadInfo downloadInfo3 = this.ve;
                String tempPath = downloadInfo3.getTempPath();
                String tempName = this.ve.getTempName();
                int i3 = -1;
                iC = this.gt.c("flush_buffer_size_byte", -1);
                com.byazt.t.n nVarC = com.byazt.w.a.c(downloadInfo3, tempPath, tempName, iC);
                this.da = nVarC;
                try {
                    try {
                        nVarC.c(this.z);
                        InputStream inputStreamC = this.f1647a.c();
                        if (inputStreamC == null) {
                            throw new BaseException(1042, new IOException("inputStream is null"));
                        }
                        this.ve.updateRealStartDownloadTime();
                        ttVarC = c(inputStreamC);
                        try {
                            this.ve.setIsRwConcurrent(this.yv);
                            this.c = this.ve.getOpenLimitSpeed();
                            long j6 = com.byazt.ev.n.uj;
                            long j7 = com.byazt.ev.n.n;
                            long j8 = j6 / (1000 / j7);
                            long jCurrentTimeMillis = System.currentTimeMillis();
                            long jNanoTime2 = 0;
                            long j9 = 0;
                            z6 = z6;
                            while (true) {
                                if (a()) {
                                    com.byazt.hs.i iVar5 = this.f1647a;
                                    if (iVar5 != null) {
                                        iVar5.uj();
                                    }
                                    if (ttVarC != null) {
                                        ttVarC.tt();
                                    }
                                    try {
                                        if (this.my) {
                                            synchronized (this.yp) {
                                                if (!this.u) {
                                                    c(this.x);
                                                    if (this.da != null) {
                                                        x();
                                                    }
                                                }
                                            }
                                        } else {
                                            c(this.x);
                                            if (this.da != null) {
                                                x();
                                            }
                                        }
                                        Closeable[] closeableArr = new Closeable[i2];
                                        closeableArr[0] = this.da;
                                        com.byazt.w.a.c(closeableArr);
                                        this.d = System.nanoTime() - jNanoTime;
                                        cVar2 = this.gt;
                                        downloadInfo2 = this.ve;
                                        str2 = this.uj;
                                        iVar4 = this.f1647a;
                                        z4 = this.t;
                                        boolean z7 = this.u;
                                        r4 = z6 ? 1 : 0;
                                        z3 = z7;
                                        com.byazt.zl.c.c(cVar2, downloadInfo2, str2, iVar4, z4, z3, this.sl, this.z - this.m, this.d, r4, this.p, this.md, this.h, null);
                                    } catch (Throwable th) {
                                        Closeable[] closeableArr2 = new Closeable[i2];
                                        closeableArr2[0] = this.da;
                                        com.byazt.w.a.c(closeableArr2);
                                        throw th;
                                    }
                                }
                                z5 = z6 ? 1 : 0;
                                if (!z5) {
                                    cVarC = ttVarC.c();
                                    if (z5) {
                                        this.p += System.nanoTime() - jNanoTime2;
                                    }
                                    i = cVarC.ve;
                                    if (i != i3) {
                                        j = jT;
                                        j2 = jNanoTime;
                                        ttVar = ttVarC;
                                        break;
                                    }
                                    if (this.ve.isIgnoreDataVerify()) {
                                        j = jT;
                                        j2 = jNanoTime;
                                        ttVar2 = ttVarC;
                                    } else {
                                        j = jT;
                                        j2 = jNanoTime;
                                        ttVar2 = ttVarC;
                                        if (this.rh > this.z - this.m) {
                                            i = (int) (this.rh - (this.z - this.m));
                                        }
                                    }
                                    if (z5) {
                                        jNanoTime2 = System.nanoTime();
                                    }
                                    this.da.c(cVarC.c, 0, i);
                                    if (z5) {
                                        this.md += System.nanoTime() - jNanoTime2;
                                    }
                                    ttVar = ttVar2;
                                    ttVar.c(cVarC);
                                    j5 = i;
                                    this.z += j5;
                                    j9 += j5;
                                    synchronized (this.yp) {
                                        if (this.my) {
                                            boolean zTt = this.yp.tt(j5);
                                            c(this.x);
                                            c(zTt);
                                        } else {
                                            boolean zTt2 = this.yp.tt(j5);
                                            c(this.x);
                                            c(zTt2);
                                        }
                                        if (this.ve.isDownloadWithWifiValid()) {
                                            throw new com.byazt.m.ve();
                                        }
                                        if (this.ve.isPauseReserveWithWifiValid()) {
                                            throw new com.byazt.m.n();
                                        }
                                        if (this.ve.isIgnoreDataVerify()) {
                                        }
                                        if (!this.c) {
                                        }
                                        z6 = z5;
                                        ttVarC = ttVar;
                                        jNanoTime = j2;
                                        jT = j;
                                        i3 = -1;
                                        i2 = 1;
                                    }
                                } else {
                                    try {
                                        jNanoTime2 = System.nanoTime();
                                        try {
                                            cVarC = ttVarC.c();
                                            if (z5) {
                                                this.p += System.nanoTime() - jNanoTime2;
                                            }
                                            i = cVarC.ve;
                                            if (i != i3) {
                                                j = jT;
                                                j2 = jNanoTime;
                                                ttVar = ttVarC;
                                                break;
                                            }
                                            if (this.ve.isIgnoreDataVerify()) {
                                                j = jT;
                                                try {
                                                    j2 = jNanoTime;
                                                    try {
                                                        ttVar2 = ttVarC;
                                                        try {
                                                            if (this.rh > this.z - this.m && this.rh < (this.z - this.m) + ((long) i)) {
                                                                i = (int) (this.rh - (this.z - this.m));
                                                            }
                                                        } catch (BaseException e) {
                                                            e = e;
                                                            ttVarC = ttVar2;
                                                            r6 = z5;
                                                        } catch (Throwable th2) {
                                                            th = th2;
                                                            ttVarC = ttVar2;
                                                            r8 = z5;
                                                            com.byazt.x.c.uj(tt, "handleResponse: e = ".concat(String.valueOf(th)));
                                                            if (a()) {
                                                                iVar3 = this.f1647a;
                                                                if (iVar3 != null) {
                                                                    iVar3.uj();
                                                                }
                                                                if (ttVarC != null) {
                                                                    ttVarC.tt();
                                                                }
                                                                try {
                                                                    if (this.my) {
                                                                        synchronized (this.yp) {
                                                                            if (!this.u) {
                                                                                c(this.x);
                                                                                if (this.da != null) {
                                                                                    x();
                                                                                }
                                                                            }
                                                                        }
                                                                    } else {
                                                                        c(this.x);
                                                                        if (this.da != null) {
                                                                            x();
                                                                        }
                                                                    }
                                                                    com.byazt.w.a.c(this.da);
                                                                    r5 = r8;
                                                                    this.d = System.nanoTime() - j2;
                                                                    cVar2 = this.gt;
                                                                    downloadInfo2 = this.ve;
                                                                    str2 = this.uj;
                                                                    iVar4 = this.f1647a;
                                                                    z4 = this.t;
                                                                    z3 = this.u;
                                                                    r4 = r5;
                                                                    com.byazt.zl.c.c(cVar2, downloadInfo2, str2, iVar4, z4, z3, this.sl, this.z - this.m, this.d, r4, this.p, this.md, this.h, null);
                                                                } catch (Throwable th3) {
                                                                    com.byazt.w.a.c(this.da);
                                                                    throw th3;
                                                                }
                                                            }
                                                            if (com.byazt.x.c.c()) {
                                                                com.byazt.nr.m.c(th);
                                                            }
                                                            try {
                                                                com.byazt.w.a.c(th, "ResponseHandler");
                                                                iVar = this.f1647a;
                                                                if (iVar != null) {
                                                                    iVar.uj();
                                                                }
                                                                if (ttVarC != null) {
                                                                    ttVarC.tt();
                                                                }
                                                                try {
                                                                    if (this.my) {
                                                                        synchronized (this.yp) {
                                                                            if (!this.u) {
                                                                                c(this.x);
                                                                                if (this.da != null) {
                                                                                    x();
                                                                                }
                                                                            }
                                                                        }
                                                                    } else {
                                                                        c(this.x);
                                                                        if (this.da != null) {
                                                                            x();
                                                                        }
                                                                    }
                                                                    com.byazt.w.a.c(this.da);
                                                                    this.d = System.nanoTime() - j2;
                                                                    cVar = this.gt;
                                                                    downloadInfo = this.ve;
                                                                    str = this.uj;
                                                                    iVar2 = this.f1647a;
                                                                    z = this.t;
                                                                    z2 = this.u;
                                                                    baseException = this.sl;
                                                                    j3 = this.z - this.m;
                                                                    r7 = r8;
                                                                    com.byazt.zl.c.c(cVar, downloadInfo, str, iVar2, z, z2, baseException, j3, this.d, r7, this.p, this.md, this.h, null);
                                                                    if (this.ve.isIgnoreDataVerify()) {
                                                                        return;
                                                                    }
                                                                    j4 = this.z - this.m;
                                                                    if (j4 < 0) {
                                                                        return;
                                                                    } else {
                                                                        return;
                                                                    }
                                                                } catch (Throwable th4) {
                                                                    com.byazt.w.a.c(this.da);
                                                                    throw th4;
                                                                }
                                                            } catch (BaseException e2) {
                                                                this.sl = e2;
                                                                throw e2;
                                                            }
                                                        }
                                                    } catch (BaseException e3) {
                                                        e = e3;
                                                        r6 = z5;
                                                    } catch (Throwable th5) {
                                                        th = th5;
                                                        r8 = z5;
                                                        com.byazt.x.c.uj(tt, "handleResponse: e = ".concat(String.valueOf(th)));
                                                        if (a()) {
                                                            iVar3 = this.f1647a;
                                                            if (iVar3 != null) {
                                                                iVar3.uj();
                                                            }
                                                            if (ttVarC != null) {
                                                                ttVarC.tt();
                                                            }
                                                            if (this.my) {
                                                                synchronized (this.yp) {
                                                                    if (!this.u) {
                                                                        c(this.x);
                                                                        if (this.da != null) {
                                                                            x();
                                                                        }
                                                                    }
                                                                }
                                                            } else {
                                                                c(this.x);
                                                                if (this.da != null) {
                                                                    x();
                                                                }
                                                            }
                                                            com.byazt.w.a.c(this.da);
                                                            r5 = r8;
                                                            this.d = System.nanoTime() - j2;
                                                            cVar2 = this.gt;
                                                            downloadInfo2 = this.ve;
                                                            str2 = this.uj;
                                                            iVar4 = this.f1647a;
                                                            z4 = this.t;
                                                            z3 = this.u;
                                                            r4 = r5;
                                                            com.byazt.zl.c.c(cVar2, downloadInfo2, str2, iVar4, z4, z3, this.sl, this.z - this.m, this.d, r4, this.p, this.md, this.h, null);
                                                        }
                                                        if (com.byazt.x.c.c()) {
                                                            com.byazt.nr.m.c(th);
                                                        }
                                                        com.byazt.w.a.c(th, "ResponseHandler");
                                                        iVar = this.f1647a;
                                                        if (iVar != null) {
                                                            iVar.uj();
                                                        }
                                                        if (ttVarC != null) {
                                                            ttVarC.tt();
                                                        }
                                                        if (this.my) {
                                                            synchronized (this.yp) {
                                                                if (!this.u) {
                                                                    c(this.x);
                                                                    if (this.da != null) {
                                                                        x();
                                                                    }
                                                                }
                                                            }
                                                        } else {
                                                            c(this.x);
                                                            if (this.da != null) {
                                                                x();
                                                            }
                                                        }
                                                        com.byazt.w.a.c(this.da);
                                                        this.d = System.nanoTime() - j2;
                                                        cVar = this.gt;
                                                        downloadInfo = this.ve;
                                                        str = this.uj;
                                                        iVar2 = this.f1647a;
                                                        z = this.t;
                                                        z2 = this.u;
                                                        baseException = this.sl;
                                                        j3 = this.z - this.m;
                                                        r7 = r8;
                                                        com.byazt.zl.c.c(cVar, downloadInfo, str, iVar2, z, z2, baseException, j3, this.d, r7, this.p, this.md, this.h, null);
                                                        if (this.ve.isIgnoreDataVerify()) {
                                                            return;
                                                        }
                                                        j4 = this.z - this.m;
                                                        if (j4 < 0) {
                                                            return;
                                                        } else {
                                                            return;
                                                        }
                                                    }
                                                } catch (BaseException e4) {
                                                    e = e4;
                                                    j2 = jNanoTime;
                                                } catch (Throwable th6) {
                                                    th = th6;
                                                    j2 = jNanoTime;
                                                }
                                            } else {
                                                j = jT;
                                                j2 = jNanoTime;
                                                ttVar2 = ttVarC;
                                            }
                                            if (z5) {
                                                jNanoTime2 = System.nanoTime();
                                            }
                                            try {
                                                this.da.c(cVarC.c, 0, i);
                                                if (z5) {
                                                    this.md += System.nanoTime() - jNanoTime2;
                                                }
                                                ttVar = ttVar2;
                                                try {
                                                    ttVar.c(cVarC);
                                                    j5 = i;
                                                    this.z += j5;
                                                    j9 += j5;
                                                    synchronized (this.yp) {
                                                        if (this.my || !this.u) {
                                                            boolean zTt3 = this.yp.tt(j5);
                                                            c(this.x);
                                                            c(zTt3);
                                                        }
                                                    }
                                                    if (this.ve.isDownloadWithWifiValid()) {
                                                        throw new com.byazt.m.ve();
                                                    }
                                                    if (this.ve.isPauseReserveWithWifiValid()) {
                                                        throw new com.byazt.m.n();
                                                    }
                                                    if (this.ve.isIgnoreDataVerify() && this.rh >= 0 && this.rh <= this.z - this.m) {
                                                        break;
                                                    }
                                                    if (!this.c && j9 > j8) {
                                                        long jCurrentTimeMillis2 = System.currentTimeMillis() - jCurrentTimeMillis;
                                                        if (jCurrentTimeMillis2 < j7) {
                                                            try {
                                                                Thread.sleep(j7 - jCurrentTimeMillis2);
                                                            } catch (InterruptedException e5) {
                                                                com.byazt.nr.m.c(e5);
                                                            }
                                                        }
                                                        jCurrentTimeMillis = System.currentTimeMillis();
                                                        j9 = 0;
                                                    }
                                                    z6 = z5;
                                                    ttVarC = ttVar;
                                                    jNanoTime = j2;
                                                    jT = j;
                                                    i3 = -1;
                                                    i2 = 1;
                                                } catch (BaseException e6) {
                                                    e = e6;
                                                    ttVarC = ttVar;
                                                    r6 = z5;
                                                    com.byazt.x.c.uj(tt, "handleResponse: BaseException e = ".concat(String.valueOf(e)));
                                                    if (this.gt.c("ignore_base_ex_on_stop_status")) {
                                                    }
                                                    if (com.byazt.x.c.c()) {
                                                        com.byazt.nr.m.c(e);
                                                    }
                                                    this.sl = e;
                                                    throw e;
                                                } catch (Throwable th7) {
                                                    th = th7;
                                                    ttVarC = ttVar;
                                                    r8 = z5;
                                                    com.byazt.x.c.uj(tt, "handleResponse: e = ".concat(String.valueOf(th)));
                                                    if (a()) {
                                                        iVar3 = this.f1647a;
                                                        if (iVar3 != null) {
                                                            iVar3.uj();
                                                        }
                                                        if (ttVarC != null) {
                                                            ttVarC.tt();
                                                        }
                                                        if (this.my) {
                                                            synchronized (this.yp) {
                                                                if (!this.u) {
                                                                    c(this.x);
                                                                    if (this.da != null) {
                                                                        x();
                                                                    }
                                                                }
                                                            }
                                                        } else {
                                                            c(this.x);
                                                            if (this.da != null) {
                                                                x();
                                                            }
                                                        }
                                                        com.byazt.w.a.c(this.da);
                                                        r5 = r8;
                                                        this.d = System.nanoTime() - j2;
                                                        cVar2 = this.gt;
                                                        downloadInfo2 = this.ve;
                                                        str2 = this.uj;
                                                        iVar4 = this.f1647a;
                                                        z4 = this.t;
                                                        z3 = this.u;
                                                        r4 = r5;
                                                        com.byazt.zl.c.c(cVar2, downloadInfo2, str2, iVar4, z4, z3, this.sl, this.z - this.m, this.d, r4, this.p, this.md, this.h, null);
                                                    }
                                                    if (com.byazt.x.c.c()) {
                                                        com.byazt.nr.m.c(th);
                                                    }
                                                    com.byazt.w.a.c(th, "ResponseHandler");
                                                    iVar = this.f1647a;
                                                    if (iVar != null) {
                                                        iVar.uj();
                                                    }
                                                    if (ttVarC != null) {
                                                        ttVarC.tt();
                                                    }
                                                    if (this.my) {
                                                        synchronized (this.yp) {
                                                            if (!this.u) {
                                                                c(this.x);
                                                                if (this.da != null) {
                                                                    x();
                                                                }
                                                            }
                                                        }
                                                    } else {
                                                        c(this.x);
                                                        if (this.da != null) {
                                                            x();
                                                        }
                                                    }
                                                    com.byazt.w.a.c(this.da);
                                                    this.d = System.nanoTime() - j2;
                                                    cVar = this.gt;
                                                    downloadInfo = this.ve;
                                                    str = this.uj;
                                                    iVar2 = this.f1647a;
                                                    z = this.t;
                                                    z2 = this.u;
                                                    baseException = this.sl;
                                                    j3 = this.z - this.m;
                                                    r7 = r8;
                                                    com.byazt.zl.c.c(cVar, downloadInfo, str, iVar2, z, z2, baseException, j3, this.d, r7, this.p, this.md, this.h, null);
                                                    if (this.ve.isIgnoreDataVerify()) {
                                                        return;
                                                    }
                                                    j4 = this.z - this.m;
                                                    if (j4 < 0) {
                                                        return;
                                                    } else {
                                                        return;
                                                    }
                                                }
                                            } catch (BaseException e7) {
                                                e = e7;
                                                ttVar = ttVar2;
                                            } catch (Throwable th8) {
                                                th = th8;
                                                ttVar = ttVar2;
                                            }
                                        } catch (BaseException e8) {
                                            e = e8;
                                            j2 = jNanoTime;
                                            r6 = z5;
                                        } catch (Throwable th9) {
                                            th = th9;
                                            j = jT;
                                            j2 = jNanoTime;
                                            r8 = z5;
                                        }
                                    } catch (BaseException e9) {
                                        e = e9;
                                        j2 = jNanoTime;
                                        r6 = z5;
                                    } catch (Throwable th10) {
                                        th = th10;
                                        j = jT;
                                        j2 = jNanoTime;
                                        r8 = z5;
                                        com.byazt.x.c.uj(tt, "handleResponse: e = ".concat(String.valueOf(th)));
                                        if (a()) {
                                            iVar3 = this.f1647a;
                                            if (iVar3 != null) {
                                                iVar3.uj();
                                            }
                                            if (ttVarC != null) {
                                                ttVarC.tt();
                                            }
                                            if (this.my) {
                                                synchronized (this.yp) {
                                                    if (!this.u) {
                                                        c(this.x);
                                                        if (this.da != null) {
                                                            x();
                                                        }
                                                    }
                                                }
                                            } else {
                                                c(this.x);
                                                if (this.da != null) {
                                                    x();
                                                }
                                            }
                                            com.byazt.w.a.c(this.da);
                                            r5 = r8;
                                            this.d = System.nanoTime() - j2;
                                            cVar2 = this.gt;
                                            downloadInfo2 = this.ve;
                                            str2 = this.uj;
                                            iVar4 = this.f1647a;
                                            z4 = this.t;
                                            z3 = this.u;
                                            r4 = r5;
                                            com.byazt.zl.c.c(cVar2, downloadInfo2, str2, iVar4, z4, z3, this.sl, this.z - this.m, this.d, r4, this.p, this.md, this.h, null);
                                        }
                                        if (com.byazt.x.c.c()) {
                                            com.byazt.nr.m.c(th);
                                        }
                                        com.byazt.w.a.c(th, "ResponseHandler");
                                        iVar = this.f1647a;
                                        if (iVar != null) {
                                            iVar.uj();
                                        }
                                        if (ttVarC != null) {
                                            ttVarC.tt();
                                        }
                                        if (this.my) {
                                            synchronized (this.yp) {
                                                if (!this.u) {
                                                    c(this.x);
                                                    if (this.da != null) {
                                                        x();
                                                    }
                                                }
                                            }
                                        } else {
                                            c(this.x);
                                            if (this.da != null) {
                                                x();
                                            }
                                        }
                                        com.byazt.w.a.c(this.da);
                                        this.d = System.nanoTime() - j2;
                                        cVar = this.gt;
                                        downloadInfo = this.ve;
                                        str = this.uj;
                                        iVar2 = this.f1647a;
                                        z = this.t;
                                        z2 = this.u;
                                        baseException = this.sl;
                                        j3 = this.z - this.m;
                                        r7 = r8;
                                        com.byazt.zl.c.c(cVar, downloadInfo, str, iVar2, z, z2, baseException, j3, this.d, r7, this.p, this.md, this.h, null);
                                        if (this.ve.isIgnoreDataVerify()) {
                                            return;
                                        }
                                        j4 = this.z - this.m;
                                        if (j4 < 0) {
                                            return;
                                        } else {
                                            return;
                                        }
                                    }
                                }
                                com.byazt.zl.c.c(cVar2, downloadInfo2, str2, iVar4, z4, z3, this.sl, this.z - this.m, this.d, r4, this.p, this.md, this.h, null);
                            }
                            com.byazt.hs.i iVar6 = this.f1647a;
                            if (iVar6 != null) {
                                iVar6.uj();
                            }
                            if (ttVar != null) {
                                ttVar.tt();
                            }
                            try {
                                if (this.my) {
                                    synchronized (this.yp) {
                                        if (!this.u) {
                                            c(this.x);
                                            if (this.da != null) {
                                                x();
                                            }
                                        }
                                    }
                                } else {
                                    c(this.x);
                                    if (this.da != null) {
                                        x();
                                    }
                                }
                                com.byazt.w.a.c(this.da);
                                this.d = System.nanoTime() - j2;
                                cVar = this.gt;
                                downloadInfo = this.ve;
                                str = this.uj;
                                iVar2 = this.f1647a;
                                z = this.t;
                                z2 = this.u;
                                baseException = this.sl;
                                j3 = this.z - this.m;
                                r7 = z5;
                            } catch (Throwable th11) {
                                com.byazt.w.a.c(this.da);
                                throw th11;
                            }
                        } catch (BaseException e10) {
                            e = e10;
                            j2 = jNanoTime;
                            r6 = z6;
                        } catch (Throwable th12) {
                            th = th12;
                            j = jT;
                            j2 = jNanoTime;
                            r8 = z6;
                        }
                        com.byazt.zl.c.c(cVar, downloadInfo, str, iVar2, z, z2, baseException, j3, this.d, r7, this.p, this.md, this.h, null);
                        if (this.ve.isIgnoreDataVerify()) {
                            return;
                        }
                        j4 = this.z - this.m;
                        if (j4 < 0 && this.rh >= 0 && this.rh != j4) {
                            throw new BaseException(1051, String.format("handle data length[%d] != content length[%d] downloadChunkContentLen[%d], range[%d, %d) , current offset[%d] , handle start from %d", Long.valueOf(j4), Long.valueOf(jC), Long.valueOf(this.rh), Long.valueOf(j), Long.valueOf(this.nu), Long.valueOf(this.z), Long.valueOf(this.m)));
                        }
                        return;
                    } catch (IOException e11) {
                        throw new BaseException(1054, e11);
                    }
                } catch (BaseException e12) {
                    e = e12;
                    ttVarC = null;
                    r6 = iC;
                } catch (Throwable th13) {
                    th = th13;
                    ttVarC = null;
                    r8 = iC;
                    com.byazt.x.c.uj(tt, "handleResponse: e = ".concat(String.valueOf(th)));
                    if (a()) {
                        iVar3 = this.f1647a;
                        if (iVar3 != null) {
                            iVar3.uj();
                        }
                        if (ttVarC != null) {
                            ttVarC.tt();
                        }
                        if (this.my) {
                            synchronized (this.yp) {
                                if (!this.u) {
                                    c(this.x);
                                    if (this.da != null) {
                                        x();
                                    }
                                }
                            }
                        } else {
                            c(this.x);
                            if (this.da != null) {
                                x();
                            }
                        }
                        com.byazt.w.a.c(this.da);
                        r5 = r8;
                        this.d = System.nanoTime() - j2;
                        cVar2 = this.gt;
                        downloadInfo2 = this.ve;
                        str2 = this.uj;
                        iVar4 = this.f1647a;
                        z4 = this.t;
                        z3 = this.u;
                        r4 = r5;
                        com.byazt.zl.c.c(cVar2, downloadInfo2, str2, iVar4, z4, z3, this.sl, this.z - this.m, this.d, r4, this.p, this.md, this.h, null);
                    }
                    if (com.byazt.x.c.c()) {
                        com.byazt.nr.m.c(th);
                    }
                    com.byazt.w.a.c(th, "ResponseHandler");
                    iVar = this.f1647a;
                    if (iVar != null) {
                        iVar.uj();
                    }
                    if (ttVarC != null) {
                        ttVarC.tt();
                    }
                    if (this.my) {
                        synchronized (this.yp) {
                            if (!this.u) {
                                c(this.x);
                                if (this.da != null) {
                                    x();
                                }
                            }
                        }
                    } else {
                        c(this.x);
                        if (this.da != null) {
                            x();
                        }
                    }
                    com.byazt.w.a.c(this.da);
                    this.d = System.nanoTime() - j2;
                    cVar = this.gt;
                    downloadInfo = this.ve;
                    str = this.uj;
                    iVar2 = this.f1647a;
                    z = this.t;
                    z2 = this.u;
                    baseException = this.sl;
                    j3 = this.z - this.m;
                    r7 = r8;
                    com.byazt.zl.c.c(cVar, downloadInfo, str, iVar2, z, z2, baseException, j3, this.d, r7, this.p, this.md, this.h, null);
                    if (this.ve.isIgnoreDataVerify()) {
                        return;
                    }
                    j4 = this.z - this.m;
                    if (j4 < 0) {
                        return;
                    } else {
                        return;
                    }
                }
            } catch (Throwable th14) {
                com.byazt.hs.i iVar7 = this.f1647a;
                if (iVar7 != null) {
                    iVar7.uj();
                }
                if (ttVarC != null) {
                    ttVarC.tt();
                }
                try {
                    if (this.my) {
                        synchronized (this.yp) {
                            if (!this.u) {
                                c(this.x);
                                if (this.da != null) {
                                    x();
                                }
                            }
                        }
                    } else {
                        c(this.x);
                        if (this.da != null) {
                            x();
                        }
                    }
                    com.byazt.w.a.c(this.da);
                    this.d = System.nanoTime() - j2;
                    com.byazt.zl.c.c(this.gt, this.ve, this.uj, this.f1647a, this.t, this.u, this.sl, this.z - this.m, this.d, r8, this.p, this.md, this.h, null);
                    throw th14;
                } catch (Throwable th15) {
                    com.byazt.w.a.c(this.da);
                    throw th15;
                }
            }
        } catch (BaseException e13) {
            e = e13;
            j2 = jNanoTime;
            iC = z6 ? 1 : 0;
        } catch (Throwable th16) {
            th = th16;
            j = jT;
            j2 = jNanoTime;
            iC = z6 ? 1 : 0;
        }
        ttVarC = null;
        r6 = iC;
        com.byazt.x.c.uj(tt, "handleResponse: BaseException e = ".concat(String.valueOf(e)));
        if (this.gt.c("ignore_base_ex_on_stop_status") || !a()) {
            if (com.byazt.x.c.c()) {
                com.byazt.nr.m.c(e);
            }
            this.sl = e;
            throw e;
        }
        com.byazt.hs.i iVar8 = this.f1647a;
        if (iVar8 != null) {
            iVar8.uj();
        }
        if (ttVarC != null) {
            ttVarC.tt();
        }
        try {
            if (this.my) {
                synchronized (this.yp) {
                    if (!this.u) {
                        c(this.x);
                        if (this.da != null) {
                            x();
                        }
                    }
                }
            } else {
                c(this.x);
                if (this.da != null) {
                    x();
                }
            }
            com.byazt.w.a.c(this.da);
            r5 = r6;
            this.d = System.nanoTime() - j2;
            cVar2 = this.gt;
            downloadInfo2 = this.ve;
            str2 = this.uj;
            iVar4 = this.f1647a;
            z4 = this.t;
            z3 = this.u;
            r4 = r5;
            com.byazt.zl.c.c(cVar2, downloadInfo2, str2, iVar4, z4, z3, this.sl, this.z - this.m, this.d, r4, this.p, this.md, this.h, null);
        } catch (Throwable th17) {
            com.byazt.w.a.c(this.da);
            throw th17;
        }
    }

    private com.byazt.ty.tt c(InputStream inputStream) {
        int iQp = ve.qp();
        if (this.gt.c("rw_concurrent", 0) == 1 && this.ve.getChunkCount() == 1 && this.ve.getTotalBytes() > 20971520) {
            try {
                com.byazt.ty.c cVar = new com.byazt.ty.c(inputStream, iQp, this.gt.c("rw_concurrent_max_buffer_count", 4));
                this.yv = true;
                return cVar;
            } catch (Throwable th) {
                com.byazt.nr.m.c(th);
            }
        }
        com.byazt.ty.ve veVar = new com.byazt.ty.ve(inputStream, iQp);
        this.yv = false;
        return veVar;
    }

    private void c(boolean z) {
        long jUptimeMillis = SystemClock.uptimeMillis();
        long j = jUptimeMillis - this.zb;
        if (this.qy) {
            if (j <= (this.rl.tt() ? this.gu : this.gr)) {
                return;
            }
        } else {
            long j2 = this.z - this.eo;
            if (!z && !tt(j2, j)) {
                return;
            }
        }
        x();
        this.zb = jUptimeMillis;
    }

    public long n() {
        return this.eo;
    }

    private void x() {
        boolean z;
        long jNanoTime = this.zm ? System.nanoTime() : 0L;
        try {
            this.da.c();
            z = true;
        } catch (Exception unused) {
            z = false;
        }
        if (z) {
            this.ve.updateRealDownloadTime(true);
            boolean z2 = this.ve.getChunkCount() > 1;
            u uVarC = com.byazt.b.t.c(com.byazt.w.a.tt());
            if (z2) {
                c(this.i);
                if (uVarC != null) {
                    uVarC.ve(this.ve);
                } else {
                    this.i.c(this.ve.getId(), this.ve.getCurBytes());
                }
            } else if (uVarC != null) {
                uVarC.ve(this.ve);
            } else {
                this.i.c(this.n.sl(), this.z);
            }
            this.eo = this.z;
        }
        if (this.zm) {
            this.h += System.nanoTime() - jNanoTime;
        }
    }

    /* JADX WARN: Code duplicated, block: B:33:0x0091  */
    private void c(da daVar) {
        u uVarC;
        com.byazt.t.tt ttVarN;
        boolean z;
        if (daVar == null) {
            return;
        }
        boolean z2 = daVar instanceof com.byazt.wh.n;
        if (z2) {
            uVarC = com.byazt.b.t.c(com.byazt.w.a.tt());
            if (uVarC == null) {
                return;
            }
        } else {
            uVarC = null;
        }
        u uVar = uVarC;
        if (this.n.uj()) {
            ttVarN = this.n.n();
        } else {
            ttVarN = this.n;
        }
        com.byazt.t.tt ttVar = ttVarN;
        if (ttVar != null) {
            ttVar.tt(this.z);
            if (z2 && uVar != null) {
                uVar.c(ttVar.sl(), ttVar.my(), ttVar.tt(), this.z);
            } else {
                daVar.c(ttVar.sl(), ttVar.my(), ttVar.tt(), this.z);
            }
            if (ttVar.x()) {
                if (ttVar.i()) {
                    long jDa = ttVar.da();
                    if (jDa > this.z) {
                        if (z2 && uVar != null) {
                            uVar.c(ttVar.sl(), ttVar.tt(), jDa);
                        } else {
                            daVar.c(ttVar.sl(), ttVar.tt(), jDa);
                        }
                        z = true;
                    } else {
                        z = false;
                    }
                } else {
                    z = false;
                }
                if (z) {
                    return;
                }
                if (z2 && uVar != null) {
                    uVar.c(ttVar.sl(), ttVar.tt(), this.z);
                    return;
                } else {
                    daVar.c(ttVar.sl(), ttVar.tt(), this.z);
                    return;
                }
            }
            return;
        }
        if (this.n.uj()) {
            if (z2 && uVar != null) {
                uVar.c(this.n.sl(), this.n.my(), this.z);
            } else {
                daVar.c(this.n.sl(), this.n.my(), this.z);
            }
        }
    }
}
