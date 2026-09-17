package com.kwad.components.core.l;

import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private CopyOnWriteArrayList<b> abk = new CopyOnWriteArrayList<>();
    private volatile boolean abl;

    public interface c {
        void bH();
    }

    /* JADX INFO: renamed from: com.kwad.components.core.l.a$a, reason: collision with other inner class name */
    static final class C0444a {
        private static final a abm = new a();
    }

    public static a ty() {
        return C0444a.abm;
    }

    public static class b {
        private final c abn;
        public boolean abo;

        public b(c cVar) {
            this.abn = cVar;
        }
    }

    public final void a(b bVar) {
        if (this.abk.contains(bVar)) {
            return;
        }
        if (!this.abl) {
            this.abl = true;
            bVar.abo = true;
        }
        this.abk.add(bVar);
    }

    public static boolean b(b bVar) {
        if (bVar == null) {
            return true;
        }
        return bVar.abo;
    }

    public final void c(b bVar) {
        if (bVar == null) {
            return;
        }
        if (bVar.abo) {
            bVar.abo = false;
            this.abl = false;
        }
        this.abk.remove(bVar);
        if (this.abk.size() == 0 || this.abl) {
            return;
        }
        this.abk.get(0).abo = true;
        this.abl = true;
        this.abk.get(0).abn.bH();
    }
}
