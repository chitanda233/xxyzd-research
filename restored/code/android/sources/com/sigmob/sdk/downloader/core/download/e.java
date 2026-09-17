package com.sigmob.sdk.downloader.core.download;

import android.os.SystemClock;
import com.sigmob.sdk.downloader.core.breakpoint.j;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CancellationException;
import java.util.concurrent.ExecutionException;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Future;
import java.util.concurrent.SynchronousQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes3.dex */
public class e extends com.sigmob.sdk.downloader.core.b implements Comparable<e> {
    static final int b = 3;
    private static final ExecutorService j = new ThreadPoolExecutor(0, Integer.MAX_VALUE, 60, TimeUnit.SECONDS, new SynchronousQueue(), com.sigmob.sdk.downloader.core.c.a("FileDownload Block", false));
    private static final String k = "DownloadCall";
    public final com.sigmob.sdk.downloader.f c;
    public final boolean d;
    final ArrayList<f> e;
    volatile d f;
    volatile boolean g;
    volatile boolean h;
    volatile Thread i;
    private final j l;

    private e(com.sigmob.sdk.downloader.f task, boolean asyncExecuted, j store) {
        this(task, asyncExecuted, new ArrayList(), store);
    }

    e(com.sigmob.sdk.downloader.f task, boolean asyncExecuted, ArrayList<f> runningBlockList, j store) {
        super("download call: " + task.c());
        this.c = task;
        this.d = asyncExecuted;
        this.e = runningBlockList;
        this.l = store;
    }

    public static e a(com.sigmob.sdk.downloader.f task, boolean asyncExecuted, j store) {
        return new e(task, asyncExecuted, store);
    }

    private void a(d cache, com.sigmob.sdk.downloader.core.cause.a cause, Exception realCause) {
        if (cause == com.sigmob.sdk.downloader.core.cause.a.CANCELED) {
            throw new IllegalAccessError("can't recognize cancelled on here");
        }
        synchronized (this) {
            if (this.g) {
                return;
            }
            this.h = true;
            this.l.a(this.c.c(), cause, realCause);
            if (cause == com.sigmob.sdk.downloader.core.cause.a.COMPLETED) {
                this.l.g(this.c.c());
                com.sigmob.sdk.downloader.g.j().f().a(cache.a(), this.c);
            }
            com.sigmob.sdk.downloader.g.j().b().a().a(this.c, cause, realCause);
        }
    }

    private void h() {
        this.l.d(this.c.c());
        com.sigmob.sdk.downloader.g.j().b().a().a_(this.c);
    }

    @Override // java.lang.Comparable
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public int compareTo(e o) {
        return o.f() - f();
    }

    a a(com.sigmob.sdk.downloader.core.breakpoint.c info, long responseInstanceLength) {
        return new a(this.c, info, responseInstanceLength);
    }

    d a(com.sigmob.sdk.downloader.core.breakpoint.c info) {
        return new d(com.sigmob.sdk.downloader.g.j().f().a(this.c, info, this.l));
    }

    Future<?> a(f chain) {
        return j.submit(chain);
    }

    /* JADX WARN: Code duplicated, block: B:34:0x0117  */
    /* JADX WARN: Code duplicated, block: B:36:0x011d  */
    /* JADX WARN: Code duplicated, block: B:38:0x0122  */
    /* JADX WARN: Code duplicated, block: B:39:0x0130  */
    /* JADX WARN: Code duplicated, block: B:40:0x0131 A[PHI: r3
  0x0131: PHI (r3v5 int) = (r3v1 int), (r3v7 int) binds: [B:35:0x011b, B:39:0x0130] A[DONT_GENERATE, DONT_INLINE]] */
    /* JADX WARN: Code duplicated, block: B:82:0x0169 A[EDGE_INSN: B:82:0x0169->B:50:0x0169 BREAK  A[LOOP:0: B:3:0x0013->B:86:?], SYNTHETIC] */
    @Override // com.sigmob.sdk.downloader.core.b
    public void a() throws InterruptedException {
        com.sigmob.sdk.downloader.core.cause.a aVar;
        IOException iOExceptionI;
        com.sigmob.sdk.downloader.core.cause.b bVarB;
        boolean z;
        int i;
        this.i = Thread.currentThread();
        com.sigmob.sdk.downloader.g gVarJ = com.sigmob.sdk.downloader.g.j();
        com.sigmob.sdk.downloader.core.file.e eVarF = gVarJ.f();
        h();
        int i2 = 0;
        do {
            if (this.c.i() == null || this.c.i().length() <= 0) {
                this.f = new d.a(new IOException("unexpected url: " + this.c.i()));
                break;
            }
            if (this.g) {
                break;
            }
            try {
                com.sigmob.sdk.downloader.core.breakpoint.c cVarA = this.l.a(this.c.c());
                if (cVarA == null) {
                    cVarA = this.l.a(this.c);
                }
                c(cVarA);
                if (this.g) {
                    break;
                }
                d dVarA = a(cVarA);
                this.f = dVarA;
                b bVarB2 = b(cVarA);
                try {
                    bVarB2.f();
                    dVarA.a(this.c.j());
                    eVarF.a().c(this.c.m().getAbsolutePath());
                    com.sigmob.sdk.downloader.g.j().g().a(this.c, cVarA, bVarB2.e());
                    try {
                        if (bVarB2.c()) {
                            a aVarA = a(cVarA, bVarB2.e());
                            aVarA.f();
                            if (aVarA.a()) {
                                com.sigmob.sdk.downloader.core.c.b(k, "breakpoint invalid: download from beginning because of local check is dirty " + this.c.c() + " " + aVarA);
                                eVarF.a(this.c);
                                bVarB = aVarA.b();
                            } else {
                                gVarJ.b().a().a(this.c, cVarA);
                            }
                            a(dVarA, cVarA);
                            if (!this.g) {
                                break;
                            }
                            if (dVarA.c()) {
                                i = i2 + 1;
                                if (i2 < 3) {
                                    this.l.b(this.c.c());
                                    i2 = i;
                                    z = true;
                                } else {
                                    i2 = i;
                                    z = false;
                                }
                            } else {
                                z = false;
                            }
                        } else {
                            com.sigmob.sdk.downloader.core.c.b(k, "breakpoint invalid: download from beginning because of remote check not resumable " + this.c.c() + " " + bVarB2);
                            eVarF.a(this.c);
                            bVarB = bVarB2.b();
                        }
                        a(cVarA, bVarB2, bVarB);
                        a(dVarA, cVarA);
                        if (!this.g) {
                            break;
                            break;
                        }
                        if (dVarA.c()) {
                            i = i2 + 1;
                            if (i2 < 3) {
                                this.l.b(this.c.c());
                                i2 = i;
                                z = true;
                            } else {
                                i2 = i;
                                z = false;
                            }
                        } else {
                            z = false;
                        }
                    } catch (IOException e) {
                        dVarA.c(e);
                    }
                } catch (IOException e2) {
                    dVarA.e(e2);
                }
            } catch (IOException e3) {
                this.f = new d.a(e3);
            }
        } while (z);
        this.h = true;
        this.e.clear();
        d dVar = this.f;
        if (this.g || dVar == null) {
            return;
        }
        if (!dVar.e() && !dVar.f() && !dVar.c()) {
            iOExceptionI = null;
            if (dVar.g()) {
                aVar = com.sigmob.sdk.downloader.core.cause.a.FILE_BUSY;
            } else if (dVar.h()) {
                aVar = com.sigmob.sdk.downloader.core.cause.a.PRE_ALLOCATE_FAILED;
            } else {
                aVar = com.sigmob.sdk.downloader.core.cause.a.COMPLETED;
            }
            a(dVar, aVar, iOExceptionI);
        }
        aVar = com.sigmob.sdk.downloader.core.cause.a.ERROR;
        iOExceptionI = dVar.i();
        a(dVar, aVar, iOExceptionI);
    }

    void a(com.sigmob.sdk.downloader.core.breakpoint.c info, b remoteCheck, com.sigmob.sdk.downloader.core.cause.b failedCause) {
        com.sigmob.sdk.downloader.core.c.a(this.c, info, remoteCheck.e(), remoteCheck.d());
        com.sigmob.sdk.downloader.g.j().b().a().a(this.c, info, failedCause);
    }

    void a(final d cache, com.sigmob.sdk.downloader.core.breakpoint.c info) throws InterruptedException {
        int iG = info.g();
        ArrayList arrayList = new ArrayList(info.g());
        ArrayList arrayList2 = new ArrayList();
        for (int i = 0; i < iG; i++) {
            com.sigmob.sdk.downloader.core.breakpoint.a aVarB = info.b(i);
            if (!com.sigmob.sdk.downloader.core.c.a(aVarB.a(), aVarB.d())) {
                com.sigmob.sdk.downloader.core.c.a(aVarB);
                f fVarA = f.a(i, this.c, info, cache, this.l);
                arrayList.add(fVarA);
                arrayList2.add(Integer.valueOf(fVarA.e()));
            }
        }
        if (this.g) {
            return;
        }
        cache.a().a(arrayList2);
        a(arrayList);
    }

    @Override // com.sigmob.sdk.downloader.core.b
    protected void a(InterruptedException e) {
    }

    void a(List<f> tasks) throws InterruptedException {
        ArrayList<Future> arrayList = new ArrayList(tasks.size());
        try {
            Iterator<f> it = tasks.iterator();
            while (it.hasNext()) {
                arrayList.add(a(it.next()));
            }
            this.e.addAll(tasks);
            for (Future future : arrayList) {
                if (!future.isDone()) {
                    try {
                        future.get();
                    } catch (CancellationException | ExecutionException unused) {
                    }
                }
            }
            this.e.removeAll(tasks);
        } catch (Throwable th) {
            try {
                Iterator it2 = arrayList.iterator();
                while (it2.hasNext()) {
                    ((Future) it2.next()).cancel(true);
                }
                throw th;
            } catch (Throwable th2) {
                this.e.removeAll(tasks);
                throw th2;
            }
        }
    }

    public boolean a(com.sigmob.sdk.downloader.f task) {
        return this.c.equals(task);
    }

    b b(com.sigmob.sdk.downloader.core.breakpoint.c info) {
        return new b(this.c, info);
    }

    @Override // com.sigmob.sdk.downloader.core.b
    protected void b() {
        com.sigmob.sdk.downloader.g.j().a().c(this);
        com.sigmob.sdk.downloader.core.c.b(k, "call is finished " + this.c.c());
    }

    void c(com.sigmob.sdk.downloader.core.breakpoint.c info) {
        com.sigmob.sdk.downloader.f.c.a(this.c, info);
    }

    public boolean c() {
        synchronized (this) {
            if (this.g) {
                return true;
            }
            if (this.h) {
                return false;
            }
            this.g = true;
            long jUptimeMillis = SystemClock.uptimeMillis();
            com.sigmob.sdk.downloader.g.j().a().b(this);
            d dVar = this.f;
            if (dVar != null) {
                dVar.l();
            }
            Object[] array = this.e.toArray();
            if (array != null && array.length != 0) {
                for (Object obj : array) {
                    if (obj instanceof f) {
                        ((f) obj).b();
                    }
                }
            } else if (this.i != null) {
                com.sigmob.sdk.downloader.core.c.b(k, "interrupt thread with cancel operation because of chains are not running " + this.c.c());
                this.i.interrupt();
            }
            if (dVar != null) {
                dVar.a().a();
            }
            com.sigmob.sdk.downloader.core.c.b(k, "cancel task " + this.c.c() + " consume: " + (SystemClock.uptimeMillis() - jUptimeMillis) + "ms");
            return true;
        }
    }

    public boolean d() {
        return this.g;
    }

    public boolean e() {
        return this.h;
    }

    int f() {
        return this.c.G();
    }

    public File g() {
        return this.c.m();
    }
}
