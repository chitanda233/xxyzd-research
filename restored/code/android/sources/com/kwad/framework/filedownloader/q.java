package com.kwad.framework.filedownloader;

import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.ThreadPoolExecutor;

/* JADX INFO: loaded from: classes3.dex */
final class q {
    private final b aAf = new b();

    q() {
    }

    static class a {
        private static final q aAg = new q();

        static {
            com.kwad.framework.filedownloader.message.e.Dd().a(new aa());
        }
    }

    public static q BQ() {
        return a.aAg;
    }

    final synchronized void a(x.b bVar) {
        this.aAf.c(bVar);
    }

    final synchronized void b(x.b bVar) {
        this.aAf.b(bVar);
    }

    static class b {
        private ThreadPoolExecutor aAh;
        private LinkedBlockingQueue<Runnable> aAi;

        b() {
            init();
        }

        public final void c(x.b bVar) {
            this.aAh.execute(new c(bVar));
        }

        public final void b(x.b bVar) {
            this.aAi.remove(bVar);
        }

        private void init() {
            LinkedBlockingQueue<Runnable> linkedBlockingQueue = new LinkedBlockingQueue<>();
            this.aAi = linkedBlockingQueue;
            this.aAh = com.kwad.framework.filedownloader.f.b.a(3, linkedBlockingQueue, "LauncherTask");
        }
    }

    static class c implements Runnable {
        private final x.b aAj;
        private boolean aAk = false;

        c(x.b bVar) {
            this.aAj = bVar;
        }

        @Override // java.lang.Runnable
        public final void run() {
            if (this.aAk) {
                return;
            }
            this.aAj.start();
        }

        public final boolean equals(Object obj) {
            return super.equals(obj) || obj == this.aAj;
        }
    }
}
