package com.kwad.components.core.t;

import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private Set<b> als;

    public interface b {
        void onPageClose();
    }

    /* synthetic */ c(byte b2) {
        this();
    }

    private c() {
        this.als = new HashSet();
    }

    static class a {
        private static c alt = new c(0);
    }

    public static c wS() {
        return a.alt;
    }

    public final void a(b bVar) {
        this.als.add(bVar);
    }

    public final void b(b bVar) {
        this.als.remove(bVar);
    }

    public final void wT() {
        if (this.als.size() == 0) {
            return;
        }
        Iterator<b> it = this.als.iterator();
        while (it.hasNext()) {
            it.next().onPageClose();
        }
    }
}
