package com.byazt.tq;

import android.content.Context;
import androidx.core.app.NotificationCompat;
import com.byazt.dna.z;
import com.byazt.gqp.yp;
import com.byazt.jzl.a;
import com.byazt.nr.m;
import com.byazt.ut.uj;
import com.kuaishou.weapon.p0.t;
import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.net.SocketTimeoutException;
import java.nio.channels.FileLock;
import java.util.HashMap;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1134, 13})
public class tt implements ve {
    public static final HashMap<String, tt> c = new HashMap<>();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f1448a;
    public RandomAccessFile da;
    public File n;
    public final a sl;
    public tt t;
    public volatile long tt;
    public com.byazt.jzl.tt u;
    public File uj;
    public final Object ve = new Object();
    public volatile long sp = -1;
    public volatile boolean x = false;
    public volatile boolean i = false;
    public AtomicBoolean yp = new AtomicBoolean(false);

    public tt(Context context, com.byazt.jzl.tt ttVar, a aVar) {
        this.tt = -2147483648L;
        this.f1448a = 0L;
        this.da = null;
        this.sl = aVar;
        this.u = ttVar;
        try {
            this.uj = com.byazt.vv.ve.tt(aVar.getCacheParentDir(), aVar.getFileNameKey());
            this.n = com.byazt.vv.ve.ve(aVar.getCacheParentDir(), aVar.getFileNameKey());
            if (sp()) {
                this.da = new RandomAccessFile(this.n, t.k);
            } else {
                this.da = new RandomAccessFile(this.uj, "rw");
            }
            if (sp()) {
                return;
            }
            long length = this.uj.length();
            this.f1448a = length;
            if (length == aVar.getVideoSize() && this.f1448a != 0) {
                boolean zC = com.byazt.lt.c.c(com.byazt.lt.c.c(this.uj), aVar.getFileNameKey());
                aVar.getFileNameKey();
                if (zC) {
                    c(this.f1448a);
                    this.tt = this.f1448a;
                    return;
                }
            }
            if (!uj()) {
                com.byazt.lt.tt.tt("CSJ_MediaDLPlay", "no process lock, no download " + n());
                return;
            }
            synchronized (tt.class) {
                if (a()) {
                    x();
                } else {
                    tt ttVar2 = this.t;
                    if (ttVar2 != null) {
                        this.tt = ttVar2.c();
                    }
                }
            }
        } catch (Throwable unused) {
            com.byazt.lt.tt.tt("CSJ_MediaDLPlay", "Error using file ", aVar.getUrl(), " as disc cache");
        }
    }

    private boolean uj() {
        RandomAccessFile randomAccessFile = this.da;
        if (randomAccessFile == null) {
            return false;
        }
        try {
            FileLock fileLockTryLock = randomAccessFile.getChannel().tryLock();
            if (fileLockTryLock == null) {
                if (fileLockTryLock != null) {
                    try {
                        fileLockTryLock.close();
                    } catch (IOException unused) {
                    }
                }
                return false;
            }
            if (fileLockTryLock == null) {
                return true;
            }
            try {
                fileLockTryLock.close();
                return true;
            } catch (IOException unused2) {
                return true;
            }
        } catch (IOException unused3) {
            return false;
        }
    }

    private String n() {
        a aVar = this.sl;
        return aVar == null ? "" : aVar.getFileNameKey();
    }

    private boolean a() {
        String strN = n();
        synchronized (tt.class) {
            HashMap<String, tt> map = c;
            tt ttVar = map.get(strN);
            this.t = ttVar;
            if (ttVar != null) {
                return false;
            }
            map.put(strN, this);
            return true;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(boolean z) {
        String strN = n();
        synchronized (tt.class) {
            try {
                if (z) {
                    c.remove(strN);
                } else {
                    HashMap<String, tt> map = c;
                    if (map.get(strN) == this) {
                        map.remove(strN);
                    }
                }
            } catch (Throwable th) {
                throw th;
            }
        }
    }

    public long c() {
        return this.tt;
    }

    private boolean sp() {
        return this.n.exists() && this.n.length() > 0;
    }

    private void x() {
        com.byazt.gqp.t.c cVar;
        if (com.byazt.oy.tt.ve() != null) {
            cVar = com.byazt.oy.tt.ve().tt();
        } else {
            cVar = new com.byazt.gqp.t.c("v_cache");
        }
        cVar.c(this.sl.getConnectTimeOutMills(), TimeUnit.MILLISECONDS).tt(this.sl.getReadTimeOutMills(), TimeUnit.MILLISECONDS).ve(this.sl.getWriteTimeOutMills(), TimeUnit.MILLISECONDS);
        com.byazt.gqp.t tVarC = cVar.c();
        Object[] objArr = new Object[4];
        Long.valueOf(this.f1448a);
        this.sl.getFileNameKey();
        tVarC.c(new yp.c().c("RANGE", "bytes=" + this.f1448a + "-").c(this.sl.getUrl()).c().tt()).c(new com.byazt.gqp.ve() { // from class: com.byazt.tq.tt.1
            @Override // com.byazt.gqp.ve
            public void onFailure(com.byazt.gqp.tt ttVar, IOException iOException) {
                tt.this.i = false;
                tt.this.tt = -1L;
                tt.this.c(true);
            }

            /* JADX WARN: Code restructure failed: missing block: B:120:0x025d, code lost:
            
                if (r16 == null) goto L124;
             */
            /* JADX WARN: Code restructure failed: missing block: B:121:0x025f, code lost:
            
                r16.close();
             */
            /* JADX WARN: Code restructure failed: missing block: B:122:0x0263, code lost:
            
                r0 = move-exception;
             */
            /* JADX WARN: Code restructure failed: missing block: B:124:0x0265, code lost:
            
                if (r7 == null) goto L126;
             */
            /* JADX WARN: Code restructure failed: missing block: B:125:0x0267, code lost:
            
                r7.close();
             */
            /* JADX WARN: Code restructure failed: missing block: B:126:0x026a, code lost:
            
                if (r21 == null) goto L128;
             */
            /* JADX WARN: Code restructure failed: missing block: B:127:0x026c, code lost:
            
                r21.close();
             */
            /* JADX WARN: Code restructure failed: missing block: B:128:0x026f, code lost:
            
                r2 = r19.c.uj.length();
             */
            /* JADX WARN: Code restructure failed: missing block: B:129:0x027f, code lost:
            
                if (r19.c.i == false) goto L249;
             */
            /* JADX WARN: Code restructure failed: missing block: B:131:0x0289, code lost:
            
                if (r2 != r19.c.tt) goto L250;
             */
            /* JADX WARN: Code restructure failed: missing block: B:133:0x028f, code lost:
            
                if (r2 <= 0) goto L251;
             */
            /* JADX WARN: Code restructure failed: missing block: B:134:0x0291, code lost:
            
                r0 = r19.c;
                r0.c(r0.tt);
             */
            /* JADX WARN: Code restructure failed: missing block: B:135:0x029a, code lost:
            
                return;
             */
            /* JADX WARN: Code restructure failed: missing block: B:136:0x029b, code lost:
            
                com.byazt.lt.tt.tt("CSJ_MediaDLPlay", "close stream error", r0);
             */
            /* JADX WARN: Code restructure failed: missing block: B:137:0x02a2, code lost:
            
                return;
             */
            /* JADX WARN: Code restructure failed: missing block: B:249:?, code lost:
            
                return;
             */
            /* JADX WARN: Code restructure failed: missing block: B:250:?, code lost:
            
                return;
             */
            /* JADX WARN: Code restructure failed: missing block: B:251:?, code lost:
            
                return;
             */
            @Override // com.byazt.gqp.ve
            /*
                Code decompiled incorrectly, please refer to instructions dump.
                To view partially-correct add '--show-bad-code' argument
            */
            public void onResponse(com.byazt.gqp.tt r20, com.byazt.gqp.m r21) throws java.io.IOException {
                /*
                    Method dump skipped, instruction units count: 1018
                    To view this dump add '--comments-level debug' option
                */
                throw new UnsupportedOperationException("Method not decompiled: com.byazt.tq.tt.AnonymousClass1.onResponse(com.byazt.gqp.tt, com.byazt.gqp.m):void");
            }
        });
    }

    private void c(long j, long j2, long j3, long j4, boolean z, long j5) {
        z zVar;
        if ((z || this.yp.compareAndSet(false, true)) && (zVar = (z) uj.getService(NotificationCompat.CATEGORY_EVENT)) != null) {
            JSONObject jSONObject = new JSONObject();
            com.byazt.jzl.tt ttVar = this.u;
            if (ttVar != null) {
                jSONObject = ttVar.c();
            }
            try {
                jSONObject.put("totalLength", j);
                jSONObject.put("position", j2);
                jSONObject.put("cacheLength", j3);
                jSONObject.put("waitTime", j4);
                a aVar = this.sl;
                if (aVar != null) {
                    jSONObject.put("videoUrl", aVar.getUrl());
                }
                jSONObject.put("startSaveLength", j5);
            } catch (Exception unused) {
            }
            zVar.onExceptionEvent("video_wait", jSONObject, null);
        }
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:49:? -> B:36:0x009b). Please report as a decompilation issue!!! */
    @Override // com.byazt.tq.ve
    public int c(long j, byte[] bArr, int i, int i2) throws IOException {
        long j2;
        try {
            if (j == this.tt) {
                return -1;
            }
            int i3 = 0;
            int i4 = 0;
            long j3 = -1;
            while (!this.x) {
                Object obj = this.ve;
                synchronized (obj) {
                    try {
                        long jI = i();
                        j2 = j3 == -1 ? jI : j3;
                        try {
                            if (j < jI) {
                                this.da.seek(j);
                                i4 = this.da.read(bArr, i, i2);
                            } else {
                                Object[] objArr = new Object[4];
                                Long.valueOf(j);
                                Long.valueOf(jI);
                                i3 += 33;
                                this.ve.wait(33L);
                                if (i3 >= 4000) {
                                    c(this.tt, j, jI, i3, false, j2);
                                }
                            }
                        } catch (Throwable th) {
                            th = th;
                            throw th;
                        }
                    } catch (Throwable th2) {
                        th = th2;
                        obj = obj;
                        throw th;
                    }
                }
                if (i4 > 0) {
                    return i4;
                }
                if (i3 >= 10000) {
                    c(this.tt, j, i(), i3, true, j2);
                    throw new SocketTimeoutException();
                }
                j3 = j2;
            }
            return -1;
        } catch (Throwable th3) {
            if (th3 instanceof IOException) {
                throw th3;
            }
            throw new IOException();
        }
    }

    @Override // com.byazt.tq.ve
    public void tt() {
        try {
            if (!this.x) {
                this.da.close();
            }
            File file = this.uj;
            if (file != null) {
                file.setLastModified(System.currentTimeMillis());
            }
            File file2 = this.n;
            if (file2 != null) {
                file2.setLastModified(System.currentTimeMillis());
            }
        } catch (Throwable th) {
            try {
                com.byazt.lt.tt.tt("CSJ_MediaDLPlay", "close error", th);
            } catch (Throwable th2) {
                c(false);
                throw th2;
            }
        }
        c(false);
        synchronized (this.ve) {
            this.x = true;
        }
    }

    private long i() {
        if (sp()) {
            return this.n.length();
        }
        return this.uj.length();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void c(long j) throws IOException {
        synchronized (this.ve) {
            if (this.n.exists() && this.n.length() >= j) {
                Object[] objArr = new Object[3];
                this.sl.getUrl();
                this.sl.getFileNameKey();
                return;
            }
            try {
                if (!this.uj.renameTo(this.n)) {
                    throw new IOException("Error renaming file " + this.uj + " to " + this.n + " for completion!");
                }
                RandomAccessFile randomAccessFile = this.da;
                if (randomAccessFile != null) {
                    randomAccessFile.close();
                }
                if (!this.x) {
                    this.da = new RandomAccessFile(this.n, "rw");
                }
                Object[] objArr2 = new Object[3];
                this.sl.getFileNameKey();
                this.sl.getUrl();
            } catch (Throwable th) {
                com.byazt.lt.tt.tt("CSJ_MediaDLPlay", "complete error", th);
            }
        }
    }

    @Override // com.byazt.tq.ve
    public long ve() throws IOException {
        if (sp()) {
            this.tt = this.n.length();
        } else {
            synchronized (this.ve) {
                int i = 0;
                do {
                    if (this.tt == -2147483648L) {
                        try {
                            tt ttVar = this.t;
                            if (ttVar != null) {
                                this.tt = ttVar.c();
                            }
                            i += 15;
                            this.ve.wait(5L);
                        } catch (InterruptedException e) {
                            m.c(e);
                            throw new IOException("total length InterruptException");
                        }
                    }
                } while (i <= 10000);
                return -1L;
            }
        }
        com.byazt.lt.tt.c("CSJ_MediaDLPlay", "totalLength= ", Long.valueOf(this.tt));
        return this.tt;
    }
}
