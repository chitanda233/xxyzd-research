package com.sigmob.sdk.downloader.core.file;

import android.net.Uri;
import android.os.StatFs;
import android.os.SystemClock;
import android.util.SparseArray;
import com.sigmob.sdk.downloader.core.breakpoint.j;
import com.sigmob.sdk.downloader.f;
import com.sigmob.sdk.downloader.g;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.concurrent.ExecutionException;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Future;
import java.util.concurrent.SynchronousQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicLong;
import java.util.concurrent.locks.LockSupport;

/* JADX INFO: loaded from: classes3.dex */
public class d {
    private static final String n = "MultiPointOutputStream";
    private static final ExecutorService o = new ThreadPoolExecutor(0, Integer.MAX_VALUE, 60, TimeUnit.SECONDS, new SynchronousQueue(), com.sigmob.sdk.downloader.core.c.a("FileDownload file io", false));

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final SparseArray<com.sigmob.sdk.downloader.core.file.a> f3436a;
    final SparseArray<AtomicLong> b;
    final AtomicLong c;
    final AtomicLong d;
    boolean e;
    volatile Future f;
    volatile Thread g;
    final SparseArray<Thread> h;
    IOException i;
    ArrayList<Integer> j;
    List<Integer> k;
    final a l;
    a m;
    private final int p;
    private final int q;
    private final int r;
    private final com.sigmob.sdk.downloader.core.breakpoint.c s;
    private final f t;
    private final j u;
    private final boolean v;
    private final boolean w;
    private final Runnable x;
    private String y;
    private volatile boolean z;

    static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        boolean f3439a;
        List<Integer> b = new ArrayList();
        List<Integer> c = new ArrayList();

        a() {
        }

        boolean a() {
            return this.f3439a || this.c.size() > 0;
        }
    }

    public d(f task, com.sigmob.sdk.downloader.core.breakpoint.c info, j store) {
        this(task, info, store, null);
    }

    d(final f task, com.sigmob.sdk.downloader.core.breakpoint.c info, j store, Runnable syncRunnable) {
        this.f3436a = new SparseArray<>();
        this.b = new SparseArray<>();
        this.c = new AtomicLong();
        this.d = new AtomicLong();
        this.e = false;
        this.h = new SparseArray<>();
        this.l = new a();
        this.m = new a();
        this.z = true;
        this.t = task;
        this.p = task.p();
        this.q = task.q();
        this.r = task.r();
        this.s = info;
        this.u = store;
        this.v = g.j().e().a();
        this.w = g.j().f().b(task);
        this.j = new ArrayList<>();
        if (syncRunnable == null) {
            this.x = new Runnable() { // from class: com.sigmob.sdk.downloader.core.file.d.1
                @Override // java.lang.Runnable
                public void run() {
                    d.this.g();
                }
            };
        } else {
            this.x = syncRunnable;
        }
        File fileM = task.m();
        if (fileM != null) {
            this.y = fileM.getAbsolutePath();
        }
    }

    private void m() {
        if (this.y != null || this.t.m() == null) {
            return;
        }
        this.y = this.t.m().getAbsolutePath();
    }

    public void a() {
        o.execute(new Runnable() { // from class: com.sigmob.sdk.downloader.core.file.d.2
            @Override // java.lang.Runnable
            public void run() {
                d.this.b();
            }
        });
    }

    public synchronized void a(int blockIndex) throws IOException {
        this.j.add(Integer.valueOf(blockIndex));
        try {
            IOException iOException = this.i;
            if (iOException != null) {
                throw iOException;
            }
            if (this.f != null && !this.f.isDone()) {
                AtomicLong atomicLong = this.b.get(blockIndex);
                if (atomicLong != null && atomicLong.get() > 0) {
                    a(this.l);
                    a(this.l.f3439a, blockIndex);
                }
            } else if (this.f == null) {
                com.sigmob.sdk.downloader.core.c.b(n, "OutputStream done but no need to ensure sync, because the sync job not run yet. task[" + this.t.c() + "] block[" + blockIndex + "]");
            } else {
                com.sigmob.sdk.downloader.core.c.b(n, "OutputStream done but no need to ensure sync, because the syncFuture.isDone[" + this.f.isDone() + "] task[" + this.t.c() + "] block[" + blockIndex + "]");
            }
            c(blockIndex);
        } catch (Throwable th) {
            c(blockIndex);
            throw th;
        }
    }

    public synchronized void a(int blockIndex, byte[] bytes, int length) throws IOException {
        if (this.e) {
            return;
        }
        e(blockIndex).a(bytes, 0, length);
        long j = length;
        this.c.addAndGet(j);
        this.b.get(blockIndex).addAndGet(j);
        d();
    }

    void a(long milliseconds) {
        LockSupport.parkNanos(TimeUnit.MILLISECONDS.toNanos(milliseconds));
    }

    void a(StatFs statFs, long requireSpace) throws com.sigmob.sdk.downloader.core.exception.e {
        long jA = com.sigmob.sdk.downloader.core.c.a(statFs);
        if (jA < requireSpace) {
            throw new com.sigmob.sdk.downloader.core.exception.e(requireSpace, jA);
        }
    }

    void a(a state) {
        state.c.clear();
        int size = new HashSet((List) this.j.clone()).size();
        if (size != this.k.size()) {
            com.sigmob.sdk.downloader.core.c.b(n, "task[" + this.t.c() + "] current need fetching block count " + this.k.size() + " is not equal to no more stream block count " + size);
            state.f3439a = false;
        } else {
            com.sigmob.sdk.downloader.core.c.b(n, "task[" + this.t.c() + "] current need fetching block count " + this.k.size() + " is equal to no more stream block count " + size);
            state.f3439a = true;
        }
        SparseArray<com.sigmob.sdk.downloader.core.file.a> sparseArrayClone = this.f3436a.clone();
        int size2 = sparseArrayClone.size();
        for (int i = 0; i < size2; i++) {
            int iKeyAt = sparseArrayClone.keyAt(i);
            if (this.j.contains(Integer.valueOf(iKeyAt)) && !state.b.contains(Integer.valueOf(iKeyAt))) {
                state.b.add(Integer.valueOf(iKeyAt));
                state.c.add(Integer.valueOf(iKeyAt));
            }
        }
    }

    void a(Thread thread) {
        LockSupport.unpark(thread);
    }

    public void a(List<Integer> requireStreamBlocks) {
        this.k = requireStreamBlocks;
    }

    void a(boolean isNoMoreStream, int blockIndex) {
        if (this.f == null || this.f.isDone()) {
            return;
        }
        if (!isNoMoreStream) {
            this.h.put(blockIndex, Thread.currentThread());
        }
        if (this.g == null) {
            while (!c()) {
                a(25L);
            }
        }
        a(this.g);
        if (!isNoMoreStream) {
            e();
            return;
        }
        a(this.g);
        try {
            this.f.get();
        } catch (InterruptedException | ExecutionException unused) {
        }
    }

    /* JADX WARN: Code duplicated, block: B:42:0x00d4 A[Catch: all -> 0x0182, TRY_LEAVE, TryCatch #0 {, blocks: (B:3:0x0001, B:7:0x0007, B:12:0x000e, B:17:0x0022, B:18:0x0028, B:20:0x002e, B:21:0x0034, B:24:0x003d, B:25:0x0070, B:39:0x00c8, B:40:0x00ce, B:42:0x00d4, B:43:0x00da, B:46:0x00e3, B:47:0x0116, B:51:0x0126, B:52:0x012c, B:54:0x0132, B:55:0x0138, B:58:0x0141, B:59:0x0174, B:60:0x0181, B:14:0x0016, B:28:0x007f, B:30:0x0083, B:32:0x008b, B:35:0x00a3, B:37:0x00b6, B:38:0x00c7), top: B:64:0x0001, inners: #2, #3, #4, #5 }] */
    public synchronized void b() {
        List<Integer> list = this.k;
        if (list == null) {
            return;
        }
        if (this.e) {
            return;
        }
        this.e = true;
        this.j.addAll(list);
        try {
            if (this.c.get() <= 0) {
                for (Integer num : this.k) {
                    try {
                        c(num.intValue());
                    } catch (IOException e) {
                        com.sigmob.sdk.downloader.core.c.b(n, "OutputStream close failed task[" + this.t.c() + "] block[" + num + "]" + e);
                    }
                }
                this.u.a(this.t.c(), com.sigmob.sdk.downloader.core.cause.a.CANCELED, (Exception) null);
                return;
            }
            if (this.f == null || this.f.isDone()) {
                for (Integer num2 : this.k) {
                    try {
                        c(num2.intValue());
                    } catch (IOException e2) {
                        com.sigmob.sdk.downloader.core.c.b(n, "OutputStream close failed task[" + this.t.c() + "] block[" + num2 + "]" + e2);
                    }
                }
                this.u.a(this.t.c(), com.sigmob.sdk.downloader.core.cause.a.CANCELED, (Exception) null);
                return;
            }
            m();
            g.j().f().a().a(this.y);
            try {
                a(true, -1);
                g.j().f().a().b(this.y);
                while (r1.hasNext()) {
                    c(num2.intValue());
                }
                this.u.a(this.t.c(), com.sigmob.sdk.downloader.core.cause.a.CANCELED, (Exception) null);
                return;
            } catch (Throwable th) {
                g.j().f().a().b(this.y);
                throw th;
            }
        } catch (Throwable th2) {
            for (Integer num3 : this.k) {
                try {
                    c(num3.intValue());
                } catch (IOException e3) {
                    com.sigmob.sdk.downloader.core.c.b(n, "OutputStream close failed task[" + this.t.c() + "] block[" + num3 + "]" + e3);
                }
            }
            this.u.a(this.t.c(), com.sigmob.sdk.downloader.core.cause.a.CANCELED, (Exception) null);
            throw th2;
        }
        throw th;
    }

    public void b(int blockIndex) throws IOException {
        com.sigmob.sdk.downloader.core.breakpoint.a aVarB = this.s.b(blockIndex);
        if (aVarB.d() != -1 && !com.sigmob.sdk.downloader.core.c.a(aVarB.a(), aVarB.d())) {
            throw new IOException("The current offset on block-info isn't update correct, " + aVarB.a() + " != " + aVarB.d() + " on " + blockIndex);
        }
    }

    synchronized void c(int blockIndex) throws IOException {
        com.sigmob.sdk.downloader.core.file.a aVar = this.f3436a.get(blockIndex);
        if (aVar != null) {
            aVar.a();
            synchronized (this.b) {
                this.f3436a.remove(blockIndex);
                this.b.remove(blockIndex);
            }
            com.sigmob.sdk.downloader.core.c.b(n, "OutputStream close task[" + this.t.c() + "] block[" + blockIndex + "]");
        }
    }

    boolean c() {
        return this.g != null;
    }

    void d() throws IOException {
        IOException iOException = this.i;
        if (iOException != null) {
            throw iOException;
        }
        if (this.f == null) {
            synchronized (this.x) {
                if (this.f == null) {
                    this.f = f();
                }
            }
        }
    }

    public void d(int blockIndex) {
        this.j.add(Integer.valueOf(blockIndex));
    }

    synchronized com.sigmob.sdk.downloader.core.file.a e(int blockIndex) throws IOException {
        com.sigmob.sdk.downloader.core.file.a aVar;
        Uri uriH;
        aVar = this.f3436a.get(blockIndex);
        if (aVar == null) {
            boolean zB = com.sigmob.sdk.downloader.core.c.b(this.t.h());
            if (zB) {
                File fileM = this.t.m();
                if (fileM == null) {
                    throw new FileNotFoundException("Filename is not ready!");
                }
                File fileL = this.t.l();
                if (!fileL.exists() && !fileL.mkdirs()) {
                    throw new IOException("Create parent folder failed!");
                }
                if (fileM.createNewFile()) {
                    com.sigmob.sdk.downloader.core.c.b(n, "Create new file: " + fileM.getName());
                }
                uriH = Uri.fromFile(fileM);
            } else {
                uriH = this.t.h();
            }
            com.sigmob.sdk.downloader.core.file.a aVarA = g.j().e().a(g.j().h(), uriH, this.p);
            if (this.v) {
                long jC = this.s.b(blockIndex).c();
                if (jC > 0) {
                    aVarA.a(jC);
                    com.sigmob.sdk.downloader.core.c.b(n, "Create output stream write from (" + this.t.c() + ") block(" + blockIndex + ") " + jC);
                }
            }
            if (this.z) {
                this.u.f(this.t.c());
            }
            if (!this.s.b() && this.z && this.w) {
                long j = this.s.j();
                if (zB) {
                    File fileM2 = this.t.m();
                    long length = j - fileM2.length();
                    if (length > 0) {
                        a(new StatFs(fileM2.getAbsolutePath()), length);
                        aVarA.b(j);
                    }
                    throw th;
                }
                aVarA.b(j);
            }
            synchronized (this.b) {
                this.f3436a.put(blockIndex, aVarA);
                this.b.put(blockIndex, new AtomicLong());
            }
            this.z = false;
            aVar = aVarA;
        }
        return aVar;
    }

    void e() {
        LockSupport.park();
    }

    Future f() {
        return o.submit(this.x);
    }

    void g() {
        try {
            h();
        } catch (IOException e) {
            this.i = e;
            com.sigmob.sdk.downloader.core.c.a(n, "Sync to breakpoint-store for task[" + this.t.c() + "] failed with cause: " + e);
        }
    }

    void h() throws IOException {
        com.sigmob.sdk.downloader.core.c.b(n, "OutputStream start flush looper task[" + this.t.c() + "] with syncBufferIntervalMills[" + this.r + "] syncBufferSize[" + this.q + "]");
        this.g = Thread.currentThread();
        long j = this.r;
        l();
        while (true) {
            a(j);
            a(this.m);
            if (this.m.a()) {
                com.sigmob.sdk.downloader.core.c.b(n, "runSync state change isNoMoreStream[" + this.m.f3439a + "] newNoMoreStreamBlockList[" + this.m.c + "]");
                if (this.c.get() > 0) {
                    l();
                }
                for (Integer num : this.m.c) {
                    Thread thread = this.h.get(num.intValue());
                    this.h.remove(num.intValue());
                    if (thread != null) {
                        a(thread);
                    }
                }
                if (this.m.f3439a) {
                    break;
                }
            } else {
                if (!i()) {
                    j = j();
                    if (j <= 0) {
                        l();
                    }
                }
                j = this.r;
            }
        }
        int size = this.h.size();
        for (int i = 0; i < size; i++) {
            Thread threadValueAt = this.h.valueAt(i);
            if (threadValueAt != null) {
                a(threadValueAt);
            }
        }
        this.h.clear();
        com.sigmob.sdk.downloader.core.c.b(n, "OutputStream stop flush looper task[" + this.t.c() + "]");
    }

    boolean i() {
        return this.c.get() < ((long) this.q);
    }

    long j() {
        return ((long) this.r) - (k() - this.d.get());
    }

    long k() {
        return SystemClock.uptimeMillis();
    }

    /* JADX WARN: Code duplicated, block: B:16:0x005d A[Catch: all -> 0x00e5, TryCatch #0 {, blocks: (B:4:0x0003, B:8:0x0014, B:10:0x002a, B:16:0x005d, B:18:0x0063, B:19:0x00d4, B:20:0x00e3, B:13:0x0040), top: B:25:0x0003, inners: #1 }] */
    /* JADX WARN: Code duplicated, block: B:18:0x0063 A[Catch: all -> 0x00e5, LOOP:1: B:17:0x0061->B:18:0x0063, LOOP_END, TryCatch #0 {, blocks: (B:4:0x0003, B:8:0x0014, B:10:0x002a, B:16:0x005d, B:18:0x0063, B:19:0x00d4, B:20:0x00e3, B:13:0x0040), top: B:25:0x0003, inners: #1 }] */
    void l() throws IOException {
        long j;
        boolean z;
        int size;
        synchronized (this.b) {
            int size2 = this.b.size();
            SparseArray sparseArray = new SparseArray(size2);
            int i = 0;
            while (true) {
                j = 0;
                if (i >= size2) {
                    break;
                }
                try {
                    int iKeyAt = this.b.keyAt(i);
                    long j2 = this.b.get(iKeyAt).get();
                    if (j2 > 0) {
                        sparseArray.put(iKeyAt, Long.valueOf(j2));
                        this.f3436a.get(iKeyAt).b();
                    }
                    i++;
                } catch (IOException e) {
                    com.sigmob.sdk.downloader.core.c.a(n, "OutputStream flush and sync data to filesystem failed " + e);
                    z = false;
                    if (z) {
                        size = sparseArray.size();
                        for (int i2 = 0; i2 < size; i2++) {
                            int iKeyAt2 = sparseArray.keyAt(i2);
                            long jLongValue = ((Long) sparseArray.valueAt(i2)).longValue();
                            this.u.a(this.s, iKeyAt2, jLongValue);
                            j += jLongValue;
                            this.b.get(iKeyAt2).addAndGet(-jLongValue);
                            com.sigmob.sdk.downloader.core.c.b(n, "OutputStream sync success (" + this.t.c() + ") block(" + iKeyAt2 + ")  syncLength(" + jLongValue + ") currentOffset(" + this.s.b(iKeyAt2).a() + ")");
                        }
                        this.c.addAndGet(-j);
                        this.d.set(SystemClock.uptimeMillis());
                    }
                }
                if (z) {
                    size = sparseArray.size();
                    while (i2 < size) {
                        int iKeyAt3 = sparseArray.keyAt(i2);
                        long jLongValue2 = ((Long) sparseArray.valueAt(i2)).longValue();
                        this.u.a(this.s, iKeyAt3, jLongValue2);
                        j += jLongValue2;
                        this.b.get(iKeyAt3).addAndGet(-jLongValue2);
                        com.sigmob.sdk.downloader.core.c.b(n, "OutputStream sync success (" + this.t.c() + ") block(" + iKeyAt3 + ")  syncLength(" + jLongValue2 + ") currentOffset(" + this.s.b(iKeyAt3).a() + ")");
                    }
                    this.c.addAndGet(-j);
                    this.d.set(SystemClock.uptimeMillis());
                }
            }
            z = true;
            if (z) {
                size = sparseArray.size();
                while (i2 < size) {
                    int iKeyAt4 = sparseArray.keyAt(i2);
                    long jLongValue3 = ((Long) sparseArray.valueAt(i2)).longValue();
                    this.u.a(this.s, iKeyAt4, jLongValue3);
                    j += jLongValue3;
                    this.b.get(iKeyAt4).addAndGet(-jLongValue3);
                    com.sigmob.sdk.downloader.core.c.b(n, "OutputStream sync success (" + this.t.c() + ") block(" + iKeyAt4 + ")  syncLength(" + jLongValue3 + ") currentOffset(" + this.s.b(iKeyAt4).a() + ")");
                }
                this.c.addAndGet(-j);
                this.d.set(SystemClock.uptimeMillis());
            }
        }
    }
}
