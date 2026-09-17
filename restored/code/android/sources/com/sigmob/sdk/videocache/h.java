package com.sigmob.sdk.videocache;

import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import com.czhj.sdk.logger.SigmobLog;
import java.io.File;
import java.io.IOException;
import java.net.Socket;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes4.dex */
final class h {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final int f3668a = 1;
    private static final int b = 2;
    private final AtomicInteger c = new AtomicInteger(0);
    private final String d;
    private volatile g e;
    private final List<d> f;
    private final d g;
    private final e h;

    private static final class a extends Handler implements d {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final String f3669a;
        private final List<d> b;

        public a(String url, List<d> listeners) {
            super(Looper.getMainLooper());
            this.f3669a = url;
            this.b = listeners;
        }

        @Override // com.sigmob.sdk.videocache.d
        public void a(File file, String url, int percentsAvailable) {
            Message messageObtainMessage = obtainMessage();
            messageObtainMessage.arg1 = percentsAvailable;
            messageObtainMessage.obj = file;
            messageObtainMessage.what = 1;
            sendMessage(messageObtainMessage);
        }

        @Override // com.sigmob.sdk.videocache.d
        public void a(String url, Throwable throwable) {
            Message messageObtainMessage = obtainMessage();
            messageObtainMessage.obj = throwable;
            messageObtainMessage.what = 2;
            sendMessage(messageObtainMessage);
        }

        @Override // android.os.Handler
        public void handleMessage(Message msg) {
            for (d dVar : this.b) {
                int i = msg.what;
                if (i == 1) {
                    dVar.a((File) msg.obj, this.f3669a, msg.arg1);
                } else if (i == 2) {
                    dVar.a(this.f3669a, (Throwable) msg.obj);
                }
            }
        }
    }

    public h(String url, e config) {
        CopyOnWriteArrayList copyOnWriteArrayList = new CopyOnWriteArrayList();
        this.f = copyOnWriteArrayList;
        this.d = (String) n.a(url);
        this.h = (e) n.a(config);
        this.g = new a(url, copyOnWriteArrayList);
    }

    private synchronized void c() throws p {
        this.e = this.e == null ? e() : this.e;
    }

    private synchronized void d() {
        if (this.c.decrementAndGet() <= 0) {
            this.e.a();
            this.e = null;
        }
    }

    private g e() throws p {
        g gVar = new g(s.a(this.d, this.h.d, this.h.e), new com.sigmob.sdk.videocache.file.b(this.h.a(this.d), this.h.c));
        gVar.a(this.g);
        return gVar;
    }

    public void a() {
        this.f.clear();
        if (this.e != null) {
            this.e.a((d) null);
            this.e.a();
            this.e = null;
        }
        this.c.set(0);
    }

    public void a(d cacheListener) {
        this.f.add(cacheListener);
    }

    public void a(f request, Socket socket) throws p, IOException {
        c();
        try {
            this.c.incrementAndGet();
            this.e.a(request, socket);
        } catch (Throwable th) {
            try {
                SigmobLog.e("processRequest error:", th);
            } finally {
                d();
            }
        }
    }

    public int b() {
        return this.c.get();
    }

    public void b(d cacheListener) {
        this.f.remove(cacheListener);
    }
}
