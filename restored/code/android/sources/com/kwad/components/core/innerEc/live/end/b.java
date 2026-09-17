package com.kwad.components.core.innerEc.live.end;

import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements a {
    private final List<c> Xh = new CopyOnWriteArrayList();
    private boolean Xi;

    @Override // com.kwad.components.core.innerEc.live.end.a
    public final boolean sP() {
        return this.Xi;
    }

    @Override // com.kwad.components.core.innerEc.live.end.a
    public final void a(c cVar) {
        this.Xh.add(cVar);
    }

    @Override // com.kwad.components.core.innerEc.live.end.a
    public final void b(c cVar) {
        this.Xh.remove(cVar);
    }

    @Override // com.kwad.components.core.innerEc.live.end.a
    public final void a(LiveAudienceEndReason liveAudienceEndReason) {
        this.Xi = true;
        Iterator<c> it = this.Xh.iterator();
        while (it.hasNext()) {
            it.next().ss();
        }
    }
}
