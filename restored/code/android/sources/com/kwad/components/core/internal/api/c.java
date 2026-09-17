package com.kwad.components.core.internal.api;

import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private List<b> abh = new CopyOnWriteArrayList();
    private boolean abi = false;
    private boolean abj = false;

    public final void a(b bVar) {
        if (bVar == null) {
            return;
        }
        this.abh.add(bVar);
    }

    public final void b(b bVar) {
        if (bVar == null) {
            return;
        }
        this.abh.remove(bVar);
    }

    public final void h(a aVar) {
        com.kwad.sdk.core.d.c.d("KsAdListenerHolder", "notifyAdEnter: " + aVar + ", hadNotifiedEnter: " + this.abj);
        if (this.abj) {
            return;
        }
        Iterator<b> it = this.abh.iterator();
        while (it.hasNext()) {
            it.next().c(aVar);
        }
        this.abj = true;
    }

    public final void i(a aVar) {
        com.kwad.sdk.core.d.c.d("KsAdListenerHolder", "notifyAdExit: " + aVar + ", hadNotifiedExit: " + this.abi);
        if (this.abi) {
            return;
        }
        Iterator<b> it = this.abh.iterator();
        while (it.hasNext()) {
            it.next().d(aVar);
        }
        this.abi = true;
    }
}
