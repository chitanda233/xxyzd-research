package com.kwad.components.core.e.e;

import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    private final List<f> RJ;

    /* synthetic */ g(byte b) {
        this();
    }

    public static class a {
        private static final g RK = new g(0);
    }

    private g() {
        this.RJ = new CopyOnWriteArrayList();
    }

    public static g qJ() {
        return a.RK;
    }

    public final void a(f fVar) {
        this.RJ.add(fVar);
    }

    public final void b(f fVar) {
        if (fVar != null) {
            this.RJ.remove(fVar);
        }
    }

    public final void qK() {
        Iterator<f> it = this.RJ.iterator();
        while (it.hasNext()) {
            it.next().show();
        }
    }

    public final void qL() {
        Iterator<f> it = this.RJ.iterator();
        while (it.hasNext()) {
            it.next().dismiss();
        }
    }
}
