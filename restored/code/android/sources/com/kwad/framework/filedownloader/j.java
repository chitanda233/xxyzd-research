package com.kwad.framework.filedownloader;

import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.concurrent.Executor;
import java.util.concurrent.LinkedBlockingQueue;

/* JADX INFO: loaded from: classes3.dex */
public final class j {
    static int azQ = 10;
    static int azR = 5;
    private final Executor azM;
    private final LinkedBlockingQueue<t> azN;
    private final Object azO;
    private final ArrayList<t> azP;
    private final Handler handler;

    /* synthetic */ j(byte b2) {
        this();
    }

    static final class a {
        private static final j azU = new j(0);
    }

    public static j BB() {
        return a.azU;
    }

    private j() {
        this.azM = com.kwad.framework.filedownloader.f.b.v(5, "BlockCompleted");
        this.azO = new Object();
        this.azP = new ArrayList<>();
        this.handler = new Handler(Looper.getMainLooper(), new b((byte) 0));
        this.azN = new LinkedBlockingQueue<>();
    }

    final void a(t tVar) {
        a(tVar, false);
    }

    private void a(final t tVar, boolean z) {
        if (tVar.BG()) {
            tVar.BF();
            return;
        }
        if (tVar.BH()) {
            this.azM.execute(new Runnable() { // from class: com.kwad.framework.filedownloader.j.1
                @Override // java.lang.Runnable
                public final void run() {
                    tVar.BF();
                }
            });
            return;
        }
        if (!BC() && !this.azN.isEmpty()) {
            synchronized (this.azO) {
                if (!this.azN.isEmpty()) {
                    Iterator<t> it = this.azN.iterator();
                    while (it.hasNext()) {
                        b(it.next());
                    }
                }
                this.azN.clear();
            }
        }
        if (!BC()) {
            b(tVar);
        } else {
            c(tVar);
        }
    }

    private void b(t tVar) {
        Handler handler = this.handler;
        handler.sendMessage(handler.obtainMessage(1, tVar));
    }

    private void c(t tVar) {
        synchronized (this.azO) {
            this.azN.offer(tVar);
        }
        push();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void push() {
        synchronized (this.azO) {
            if (this.azP.isEmpty()) {
                if (this.azN.isEmpty()) {
                    return;
                }
                int i = 0;
                if (!BC()) {
                    this.azN.drainTo(this.azP);
                } else {
                    int i2 = azQ;
                    int iMin = Math.min(this.azN.size(), azR);
                    while (i < iMin) {
                        this.azP.add(this.azN.remove());
                        i++;
                    }
                    i = i2;
                }
                Handler handler = this.handler;
                handler.sendMessageDelayed(handler.obtainMessage(2, this.azP), i);
            }
        }
    }

    static class b implements Handler.Callback {
        private b() {
        }

        /* synthetic */ b(byte b) {
            this();
        }

        @Override // android.os.Handler.Callback
        public final boolean handleMessage(Message message) {
            if (message.what == 1) {
                ((t) message.obj).BF();
            } else if (message.what == 2) {
                a((ArrayList) message.obj);
                j.BB().push();
            }
            return true;
        }

        private static void a(ArrayList<t> arrayList) {
            for (t tVar : arrayList) {
                if (tVar != null) {
                    tVar.BF();
                }
            }
            arrayList.clear();
        }
    }

    private static boolean BC() {
        return azQ > 0;
    }
}
