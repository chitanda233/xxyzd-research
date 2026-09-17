package com.kwad.components.ad.reward.m;

import com.kwad.components.ad.reward.g;
import com.kwad.components.core.video.m;
import com.kwad.sdk.utils.j;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    private com.kwad.components.ad.reward.f.a CC;
    private d CD;
    private b CE;
    private com.kwad.components.ad.k.a CF;
    private g ub;
    private int CB = 0;
    private int CG = 0;
    private List<m> CH = new CopyOnWriteArrayList();

    public e(g gVar) {
        this.ub = gVar;
        this.CF = new a(gVar.mAdTemplate);
    }

    public final void a(int i, com.kwad.components.ad.k.a aVar) {
        this.CB = i;
        if (i == 1) {
            this.CD = (d) aVar;
        } else if (i == 2) {
            this.CC = (com.kwad.components.ad.reward.f.a) aVar;
        } else if (i == 3) {
            this.CE = (b) aVar;
        }
        this.CF = aVar;
        Iterator<m> it = this.CH.iterator();
        while (it.hasNext()) {
            this.CF.b(it.next());
        }
        this.CH.clear();
    }

    private com.kwad.components.ad.k.a lp() {
        return this.CF;
    }

    public final boolean lq() {
        return this.CC != null;
    }

    public final void a(m mVar) {
        if (lp().ll()) {
            this.CH.add(mVar);
        } else {
            lp().b(mVar);
        }
    }

    public final void b(m mVar) {
        lp().a(mVar);
        if (mVar != null) {
            this.CH.remove(mVar);
        }
    }

    public final void ln() {
        d dVar = this.CD;
        if (dVar != null) {
            dVar.ln();
        }
    }

    public final void a(j.a aVar) {
        d dVar = this.CD;
        if (dVar != null) {
            dVar.a(aVar);
        }
    }

    public final void b(j.a aVar) {
        d dVar = this.CD;
        if (dVar != null) {
            dVar.b(aVar);
        }
    }

    public final com.kwad.components.ad.reward.f.a lr() {
        return this.CC;
    }

    public final b ls() {
        return this.CE;
    }

    public final void lm() {
        d dVar = this.CD;
        if (dVar != null) {
            dVar.lm();
        } else {
            b bVar = this.CE;
            if (bVar != null) {
                bVar.lm();
            }
        }
        this.ub.gR();
    }

    public final long getPlayDuration() {
        return lp().getPlayDuration();
    }

    public final void skipToEnd() {
        lp().skipToEnd();
    }

    public final void setAudioEnabled(boolean z, boolean z2) {
        this.CG = z ? 2 : 1;
        lp().setAudioEnabled(z, z2);
    }

    public final void resume() {
        int i;
        lp().resume();
        com.kwad.components.ad.reward.f.a aVar = this.CC;
        if (aVar == null || (i = this.CG) <= 0) {
            return;
        }
        aVar.setAudioEnabled(i == 2, false);
    }

    public final void pause() {
        lp().pause();
    }

    public final void release() {
        lp().release();
    }
}
