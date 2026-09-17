package com.kwad.framework.filedownloader.b;

import android.os.Handler;
import android.os.HandlerThread;
import android.os.Message;
import com.kwad.framework.filedownloader.f.f;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.concurrent.locks.LockSupport;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements a {
    private volatile Thread aAF;
    private Handler handler;
    private volatile List<Integer> aAD = new CopyOnWriteArrayList();
    private AtomicInteger aAE = new AtomicInteger();
    private final b aAA = new b();
    private final d aAB = new d();
    private final long aAC = com.kwad.framework.filedownloader.f.e.DL().aDv;

    static /* synthetic */ Thread a(c cVar, Thread thread) {
        cVar.aAF = null;
        return null;
    }

    public c() {
        HandlerThread handlerThread = new HandlerThread(f.cn("RemitHandoverToDB"), 10);
        handlerThread.start();
        this.handler = new Handler(handlerThread.getLooper(), new Handler.Callback() { // from class: com.kwad.framework.filedownloader.b.c.1
            @Override // android.os.Handler.Callback
            public final boolean handleMessage(Message message) {
                int i = message.what;
                if (i == 0) {
                    if (c.this.aAF != null) {
                        LockSupport.unpark(c.this.aAF);
                        c.a(c.this, (Thread) null);
                    }
                    return false;
                }
                try {
                    c.this.aAE.set(i);
                    c.this.cx(i);
                    c.this.aAD.add(Integer.valueOf(i));
                    return false;
                } finally {
                    c.this.aAE.set(0);
                    if (c.this.aAF != null) {
                        LockSupport.unpark(c.this.aAF);
                        c.a(c.this, (Thread) null);
                    }
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cx(int i) {
        this.aAB.b(this.aAA.cs(i));
        List<com.kwad.framework.filedownloader.d.a> listCt = this.aAA.ct(i);
        this.aAB.cu(i);
        Iterator<com.kwad.framework.filedownloader.d.a> it = listCt.iterator();
        while (it.hasNext()) {
            this.aAB.a(it.next());
        }
    }

    private boolean cy(int i) {
        return !this.aAD.contains(Integer.valueOf(i));
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void cr(int i) {
        this.handler.sendEmptyMessageDelayed(i, this.aAC);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final com.kwad.framework.filedownloader.d.c cs(int i) {
        return this.aAA.cs(i);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final List<com.kwad.framework.filedownloader.d.a> ct(int i) {
        return this.aAA.ct(i);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void cu(int i) {
        this.aAA.cu(i);
        if (cy(i)) {
            return;
        }
        this.aAB.cu(i);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(com.kwad.framework.filedownloader.d.a aVar) {
        this.aAA.a(aVar);
        if (cy(aVar.getId())) {
            return;
        }
        this.aAB.a(aVar);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, int i2, long j) {
        this.aAA.a(i, i2, j);
        if (cy(i)) {
            return;
        }
        this.aAB.a(i, i2, j);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void b(int i, long j) {
        this.aAA.b(i, j);
        if (cy(i)) {
            return;
        }
        this.aAB.b(i, j);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void w(int i, int i2) {
        this.aAA.w(i, i2);
        if (cy(i)) {
            return;
        }
        this.aAB.w(i, i2);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void b(com.kwad.framework.filedownloader.d.c cVar) {
        this.aAA.b(cVar);
        if (cy(cVar.getId())) {
            return;
        }
        this.aAB.b(cVar);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final boolean cv(int i) {
        this.aAB.cv(i);
        return this.aAA.cv(i);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void clear() {
        this.aAA.clear();
        this.aAB.clear();
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, String str, long j, long j2, int i2) {
        this.aAA.a(i, str, j, j2, i2);
        if (cy(i)) {
            return;
        }
        this.aAB.a(i, str, j, j2, i2);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, long j, String str, String str2) {
        this.aAA.a(i, j, str, str2);
        if (cy(i)) {
            return;
        }
        this.aAB.a(i, j, str, str2);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void cw(int i) {
        this.aAA.cw(i);
        if (cy(i)) {
            return;
        }
        this.aAB.cw(i);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, Throwable th) {
        this.aAA.a(i, th);
        if (cy(i)) {
            return;
        }
        this.aAB.a(i, th);
    }

    private void cz(int i) {
        this.handler.removeMessages(i);
        if (this.aAE.get() == i) {
            this.aAF = Thread.currentThread();
            this.handler.sendEmptyMessage(0);
            LockSupport.park();
            return;
        }
        cx(i);
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void a(int i, Throwable th, long j) {
        this.aAA.a(i, th, j);
        if (cy(i)) {
            cz(i);
        }
        this.aAB.a(i, th, j);
        this.aAD.remove(Integer.valueOf(i));
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void c(int i, long j) {
        this.aAA.c(i, j);
        if (cy(i)) {
            this.handler.removeMessages(i);
            if (this.aAE.get() == i) {
                this.aAF = Thread.currentThread();
                this.handler.sendEmptyMessage(0);
                LockSupport.park();
                this.aAB.c(i, j);
            }
        } else {
            this.aAB.c(i, j);
        }
        this.aAD.remove(Integer.valueOf(i));
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final void d(int i, long j) {
        this.aAA.d(i, j);
        if (cy(i)) {
            cz(i);
        }
        this.aAB.d(i, j);
        this.aAD.remove(Integer.valueOf(i));
    }

    @Override // com.kwad.framework.filedownloader.b.a
    public final a.InterfaceC0482a Cd() {
        return this.aAB.a(this.aAA.aAx, this.aAA.aAy);
    }
}
