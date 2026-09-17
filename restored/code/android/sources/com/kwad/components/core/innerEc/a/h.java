package com.kwad.components.core.innerEc.a;

import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class h {
    private final List<g> Tl;

    /* synthetic */ h(byte b) {
        this();
    }

    public static class a {
        private static final h Tm = new h(0);
    }

    private h() {
        this.Tl = new CopyOnWriteArrayList();
    }

    public static h rw() {
        return a.Tm;
    }

    public final void a(g gVar) {
        this.Tl.add(gVar);
    }

    public final void b(g gVar) {
        if (gVar != null) {
            this.Tl.remove(gVar);
        }
    }

    public final void rx() {
        Iterator<g> it = this.Tl.iterator();
        while (it.hasNext()) {
            it.next().dl();
        }
    }

    public final void ry() {
        Iterator<g> it = this.Tl.iterator();
        while (it.hasNext()) {
            it.next().dm();
        }
    }
}
