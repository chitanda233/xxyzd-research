package com.kwad.components.ad.i;

import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private final AtomicBoolean rJ;
    private final List<com.kwad.components.ad.b.a.b> rK;

    /* synthetic */ e(byte b) {
        this();
    }

    private e() {
        this.rJ = new AtomicBoolean();
        this.rK = new CopyOnWriteArrayList();
    }

    public final boolean X() {
        return this.rJ.get();
    }

    public final void a(com.kwad.components.ad.b.a.b bVar) {
        if (bVar != null) {
            this.rK.add(bVar);
        }
    }

    public final void b(com.kwad.components.ad.b.a.b bVar) {
        if (bVar != null) {
            this.rK.remove(bVar);
        }
    }

    public final void gk() {
        this.rJ.set(true);
        Iterator<com.kwad.components.ad.b.a.b> it = this.rK.iterator();
        while (it.hasNext()) {
            it.next().Y();
        }
    }

    public final void gm() {
        this.rJ.set(false);
        Iterator<com.kwad.components.ad.b.a.b> it = this.rK.iterator();
        while (it.hasNext()) {
            it.next().Z();
        }
    }

    static class a {
        private static final e rL = new e(0);
    }

    public static e go() {
        return a.rL;
    }
}
