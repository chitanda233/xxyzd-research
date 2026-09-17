package com.sigmob.sdk.downloader;

import android.net.Uri;
import android.os.Handler;
import android.os.Looper;
import android.os.SystemClock;
import java.io.File;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.Map;
import java.util.concurrent.Executor;
import java.util.concurrent.SynchronousQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
public class a {
    private static final String c = "DownloadContext";
    private static final Executor d = new ThreadPoolExecutor(0, Integer.MAX_VALUE, 30, TimeUnit.SECONDS, new SynchronousQueue(), com.sigmob.sdk.downloader.core.c.a("FileDownload Serial", false));

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    volatile boolean f3371a;
    final com.sigmob.sdk.downloader.b b;
    private final f[] e;
    private final d f;
    private Handler g;

    /* JADX INFO: renamed from: com.sigmob.sdk.downloader.a$a, reason: collision with other inner class name */
    public static class C0559a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final a f3374a;

        C0559a(a context) {
            this.f3374a = context;
        }

        public C0559a a(f oldTask, f newTask) {
            f[] fVarArr = this.f3374a.e;
            for (int i = 0; i < fVarArr.length; i++) {
                if (fVarArr[i] == oldTask) {
                    fVarArr[i] = newTask;
                }
            }
            return this;
        }
    }

    public static class b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final ArrayList<f> f3375a;
        private final d b;
        private com.sigmob.sdk.downloader.b c;

        public b() {
            this(new d());
        }

        public b(d set) {
            this(set, new ArrayList());
        }

        public b(d set, ArrayList<f> taskArrayList) {
            this.b = set;
            this.f3375a = taskArrayList;
        }

        public b a(com.sigmob.sdk.downloader.b listener) {
            this.c = listener;
            return this;
        }

        public b a(f task) {
            int iIndexOf = this.f3375a.indexOf(task);
            if (iIndexOf >= 0) {
                this.f3375a.set(iIndexOf, task);
            } else {
                this.f3375a.add(task);
            }
            return this;
        }

        public a a() {
            return new a((f[]) this.f3375a.toArray(new f[this.f3375a.size()]), this.c, this.b);
        }

        public f a(f.a taskBuilder) {
            if (this.b.f3377a != null) {
                taskBuilder.a(this.b.f3377a);
            }
            if (this.b.c != null) {
                taskBuilder.d(this.b.c.intValue());
            }
            if (this.b.d != null) {
                taskBuilder.e(this.b.d.intValue());
            }
            if (this.b.e != null) {
                taskBuilder.f(this.b.e.intValue());
            }
            if (this.b.j != null) {
                taskBuilder.d(this.b.j.booleanValue());
            }
            if (this.b.f != null) {
                taskBuilder.g(this.b.f.intValue());
            }
            if (this.b.g != null) {
                taskBuilder.b(this.b.g.booleanValue());
            }
            if (this.b.h != null) {
                taskBuilder.b(this.b.h.intValue());
            }
            if (this.b.i != null) {
                taskBuilder.c(this.b.i.booleanValue());
            }
            f fVarA = taskBuilder.a();
            if (this.b.k != null) {
                fVarA.a(this.b.k);
            }
            this.f3375a.add(fVarA);
            return fVarA;
        }

        public f a(String url) {
            if (this.b.b != null) {
                return a(new f.a(url, this.b.b).a((Boolean) true));
            }
            throw new IllegalArgumentException("If you want to bind only with url, you have to provide parentPath on QueueSet!");
        }

        public void a(int id) {
            for (f fVar : (List) this.f3375a.clone()) {
                if (fVar.c() == id) {
                    this.f3375a.remove(fVar);
                }
            }
        }

        public void b(f task) {
            this.f3375a.remove(task);
        }
    }

    static class c extends com.sigmob.sdk.downloader.core.listener.b {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final AtomicInteger f3376a;
        private final com.sigmob.sdk.downloader.b b;
        private final a c;

        c(a context, com.sigmob.sdk.downloader.b contextListener, int taskCount) {
            this.f3376a = new AtomicInteger(taskCount);
            this.b = contextListener;
            this.c = context;
        }

        @Override // com.sigmob.sdk.downloader.c
        public void a(f task, com.sigmob.sdk.downloader.core.cause.a cause, Exception realCause) {
            int iDecrementAndGet = this.f3376a.decrementAndGet();
            this.b.a(this.c, task, cause, realCause, iDecrementAndGet);
            if (iDecrementAndGet <= 0) {
                this.b.a(this.c);
                com.sigmob.sdk.downloader.core.c.b(a.c, "taskEnd and remainCount " + iDecrementAndGet);
            }
        }

        @Override // com.sigmob.sdk.downloader.c
        public void a_(f task) {
        }
    }

    public static class d {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private Map<String, List<String>> f3377a;
        private Uri b;
        private Integer c;
        private Integer d;
        private Integer e;
        private Integer f;
        private Boolean g;
        private Integer h;
        private Boolean i;
        private Boolean j;
        private Object k;

        public d a(int readBufferSize) {
            this.c = Integer.valueOf(readBufferSize);
            return this;
        }

        public d a(Uri uri) {
            this.b = uri;
            return this;
        }

        public d a(File parentPathFile) {
            if (parentPathFile.isFile()) {
                throw new IllegalArgumentException("parent path only accept directory path");
            }
            this.b = Uri.fromFile(parentPathFile);
            return this;
        }

        public d a(Boolean wifiRequired) {
            this.j = wifiRequired;
            return this;
        }

        public d a(Integer minIntervalMillisCallbackProcess) {
            this.h = minIntervalMillisCallbackProcess;
            return this;
        }

        public d a(Object tag) {
            this.k = tag;
            return this;
        }

        public d a(String parentPath) {
            return a(new File(parentPath));
        }

        public d a(boolean passIfAlreadyCompleted) {
            this.i = Boolean.valueOf(passIfAlreadyCompleted);
            return this;
        }

        public Map<String, List<String>> a() {
            return this.f3377a;
        }

        public void a(Map<String, List<String>> headerMapFields) {
            this.f3377a = headerMapFields;
        }

        public Uri b() {
            return this.b;
        }

        public d b(int flushBufferSize) {
            this.d = Integer.valueOf(flushBufferSize);
            return this;
        }

        public d b(Boolean autoCallbackToUIThread) {
            this.g = autoCallbackToUIThread;
            return this;
        }

        public int c() {
            Integer num = this.c;
            if (num == null) {
                return 4096;
            }
            return num.intValue();
        }

        public d c(int syncBufferSize) {
            this.e = Integer.valueOf(syncBufferSize);
            return this;
        }

        public d d(int syncBufferIntervalMillis) {
            this.f = Integer.valueOf(syncBufferIntervalMillis);
            return this;
        }

        public boolean d() {
            Boolean bool = this.j;
            if (bool == null) {
                return false;
            }
            return bool.booleanValue();
        }

        public int e() {
            Integer num = this.d;
            if (num == null) {
                return 16384;
            }
            return num.intValue();
        }

        public int f() {
            Integer num = this.e;
            if (num == null) {
                return 65536;
            }
            return num.intValue();
        }

        public int g() {
            Integer num = this.f;
            if (num == null) {
                return 2000;
            }
            return num.intValue();
        }

        public boolean h() {
            Boolean bool = this.g;
            if (bool == null) {
                return true;
            }
            return bool.booleanValue();
        }

        public int i() {
            Integer num = this.h;
            if (num == null) {
                return 1000;
            }
            return num.intValue();
        }

        public Object j() {
            return this.k;
        }

        public boolean k() {
            Boolean bool = this.i;
            if (bool == null) {
                return true;
            }
            return bool.booleanValue();
        }

        public b l() {
            return new b(this);
        }
    }

    a(f[] tasks, com.sigmob.sdk.downloader.b contextListener, d set) {
        this.f3371a = false;
        this.e = tasks;
        this.b = contextListener;
        this.f = set;
    }

    a(f[] tasks, com.sigmob.sdk.downloader.b contextListener, d set, Handler uiHandler) {
        this(tasks, contextListener, set);
        this.g = uiHandler;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(boolean isAutoCallbackToUIThread) {
        com.sigmob.sdk.downloader.b bVar = this.b;
        if (bVar == null) {
            return;
        }
        if (!isAutoCallbackToUIThread) {
            bVar.a(this);
            return;
        }
        if (this.g == null) {
            this.g = new Handler(Looper.getMainLooper());
        }
        this.g.post(new Runnable() { // from class: com.sigmob.sdk.downloader.a.2
            @Override // java.lang.Runnable
            public void run() {
                a.this.b.a(a.this);
            }
        });
    }

    public void a(com.sigmob.sdk.downloader.c listener) {
        a(listener, true);
    }

    public void a(final com.sigmob.sdk.downloader.c listener, boolean isSerial) {
        long jUptimeMillis = SystemClock.uptimeMillis();
        com.sigmob.sdk.downloader.core.c.b(c, "start " + isSerial);
        this.f3371a = true;
        if (this.b != null) {
            listener = new com.sigmob.sdk.downloader.core.listener.f.a().a(listener).a(new c(this, this.b, this.e.length)).a();
        }
        if (isSerial) {
            final ArrayList arrayList = new ArrayList();
            Collections.addAll(arrayList, this.e);
            Collections.sort(arrayList);
            a(new Runnable() { // from class: com.sigmob.sdk.downloader.a.1
                @Override // java.lang.Runnable
                public void run() {
                    for (f fVar : arrayList) {
                        if (!a.this.a()) {
                            a.this.a(fVar.s());
                            return;
                        }
                        fVar.c(listener);
                    }
                }
            });
        } else {
            f.a(this.e, listener);
        }
        com.sigmob.sdk.downloader.core.c.b(c, "start finish " + isSerial + " " + (SystemClock.uptimeMillis() - jUptimeMillis) + "ms");
    }

    void a(Runnable runnable) {
        d.execute(runnable);
    }

    public boolean a() {
        return this.f3371a;
    }

    public void b(com.sigmob.sdk.downloader.c listener) {
        a(listener, false);
    }

    public f[] b() {
        return this.e;
    }

    public C0559a c() {
        return new C0559a(this);
    }

    public void d() {
        if (this.f3371a) {
            g.j().a().a((com.sigmob.sdk.downloader.core.a[]) this.e);
        }
        this.f3371a = false;
    }

    public b e() {
        return new b(this.f, new ArrayList(Arrays.asList(this.e))).a(this.b);
    }
}
