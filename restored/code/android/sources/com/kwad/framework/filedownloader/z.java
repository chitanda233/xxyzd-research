package com.kwad.framework.filedownloader;

import com.kwad.framework.filedownloader.event.DownloadServiceConnectChangedEvent;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class z extends e implements v {
    private final ArrayList<a.InterfaceC0481a> aAq = new ArrayList<>();

    @Override // com.kwad.framework.filedownloader.e
    public final void Bu() {
        w wVarBV = r.BS().BV();
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "The downloader service is connected.", new Object[0]);
        }
        synchronized (this.aAq) {
            List<a.InterfaceC0481a> list = (List) this.aAq.clone();
            this.aAq.clear();
            ArrayList arrayList = new ArrayList(wVarBV.BZ());
            for (a.InterfaceC0481a interfaceC0481a : list) {
                int iBd = interfaceC0481a.Bd();
                if (wVarBV.cp(iBd)) {
                    interfaceC0481a.Bb().AI().Bj();
                    if (!arrayList.contains(Integer.valueOf(iBd))) {
                        arrayList.add(Integer.valueOf(iBd));
                    }
                } else {
                    interfaceC0481a.Bh();
                }
            }
            wVarBV.w(arrayList);
        }
    }

    @Override // com.kwad.framework.filedownloader.e
    public final void Bv() {
        if (Bw() == DownloadServiceConnectChangedEvent.ConnectStatus.lost) {
            w wVarBV = r.BS().BV();
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "lost the connection to the file download service, and current active task size is %d", Integer.valueOf(h.Bz().size()));
            }
            if (h.Bz().size() > 0) {
                synchronized (this.aAq) {
                    h.Bz().v(this.aAq);
                    Iterator<a.InterfaceC0481a> it = this.aAq.iterator();
                    while (it.hasNext()) {
                        it.next().free();
                    }
                    wVarBV.BY();
                }
                r.BS().BT();
                return;
            }
            return;
        }
        if (h.Bz().size() > 0) {
            com.kwad.framework.filedownloader.f.d.d(this, "file download service has be unbound but the size of active tasks are not empty %d ", Integer.valueOf(h.Bz().size()));
        }
    }

    @Override // com.kwad.framework.filedownloader.v
    public final boolean d(a.InterfaceC0481a interfaceC0481a) {
        return !this.aAq.isEmpty() && this.aAq.contains(interfaceC0481a);
    }

    @Override // com.kwad.framework.filedownloader.v
    public final void e(a.InterfaceC0481a interfaceC0481a) {
        if (this.aAq.isEmpty()) {
            return;
        }
        synchronized (this.aAq) {
            this.aAq.remove(interfaceC0481a);
        }
    }

    @Override // com.kwad.framework.filedownloader.v
    public final boolean f(a.InterfaceC0481a interfaceC0481a) {
        r.BS();
        if (!r.BU()) {
            synchronized (this.aAq) {
                r.BS();
                if (!r.BU()) {
                    if (com.kwad.framework.filedownloader.f.d.aDt) {
                        com.kwad.framework.filedownloader.f.d.c(this, "Waiting for connecting with the downloader service... %d", Integer.valueOf(interfaceC0481a.Bb().getId()));
                    }
                    n.BK().aV(com.kwad.framework.filedownloader.f.c.DJ());
                    if (!this.aAq.contains(interfaceC0481a)) {
                        interfaceC0481a.free();
                        this.aAq.add(interfaceC0481a);
                    }
                    return true;
                }
            }
        }
        e(interfaceC0481a);
        return false;
    }
}
