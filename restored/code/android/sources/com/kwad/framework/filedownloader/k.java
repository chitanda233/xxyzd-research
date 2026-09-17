package com.kwad.framework.filedownloader;

import com.kwad.framework.filedownloader.message.MessageSnapshot;
import java.util.Queue;
import java.util.concurrent.LinkedBlockingQueue;

/* JADX INFO: loaded from: classes3.dex */
final class k implements t {
    private a.InterfaceC0481a azV;
    private a.c azW;
    private Queue<MessageSnapshot> azX;
    private boolean azY = false;

    k(a.InterfaceC0481a interfaceC0481a, a.c cVar) {
        a(interfaceC0481a, cVar);
    }

    private void a(a.InterfaceC0481a interfaceC0481a, a.c cVar) {
        this.azV = interfaceC0481a;
        this.azW = cVar;
        this.azX = new LinkedBlockingQueue();
    }

    @Override // com.kwad.framework.filedownloader.t
    public final boolean BE() {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "notify begin %s", this.azV);
        }
        if (this.azV == null) {
            com.kwad.framework.filedownloader.f.d.d(this, "can't begin the task, the holder fo the messenger is nil, %d", Integer.valueOf(this.azX.size()));
            return false;
        }
        this.azW.onBegin();
        return true;
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void f(MessageSnapshot messageSnapshot) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "notify pending %s", this.azV);
        }
        p(messageSnapshot);
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void g(MessageSnapshot messageSnapshot) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "notify started %s", this.azV);
        }
        p(messageSnapshot);
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void h(MessageSnapshot messageSnapshot) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "notify connected %s", this.azV);
        }
        p(messageSnapshot);
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void i(MessageSnapshot messageSnapshot) {
        a aVarBb = this.azV.Bb();
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "notify progress %s %d %d", aVarBb, Long.valueOf(aVarBb.AQ()), Long.valueOf(aVarBb.AS()));
        }
        if (aVarBb.AL() <= 0) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "notify progress but client not request notify %s", this.azV);
                return;
            }
            return;
        }
        p(messageSnapshot);
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void j(MessageSnapshot messageSnapshot) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "notify block completed %s %s", this.azV, Thread.currentThread().getName());
        }
        p(messageSnapshot);
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void k(MessageSnapshot messageSnapshot) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            a aVarBb = this.azV.Bb();
            com.kwad.framework.filedownloader.f.d.c(this, "notify retry %s %d %d %s", this.azV, Integer.valueOf(aVarBb.AW()), Integer.valueOf(aVarBb.AX()), aVarBb.AV());
        }
        p(messageSnapshot);
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void l(MessageSnapshot messageSnapshot) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "notify warn %s", this.azV);
        }
        this.azW.Bk();
        p(messageSnapshot);
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void m(MessageSnapshot messageSnapshot) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            a.InterfaceC0481a interfaceC0481a = this.azV;
            com.kwad.framework.filedownloader.f.d.c(this, "notify error %s %s", interfaceC0481a, interfaceC0481a.Bb().AV());
        }
        this.azW.Bk();
        p(messageSnapshot);
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void n(MessageSnapshot messageSnapshot) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "notify paused %s", this.azV);
        }
        this.azW.Bk();
        p(messageSnapshot);
    }

    private void o(MessageSnapshot messageSnapshot) {
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(this, "notify completed %s", this.azV);
        }
        this.azW.Bk();
        p(messageSnapshot);
    }

    private void p(MessageSnapshot messageSnapshot) {
        a.InterfaceC0481a interfaceC0481a = this.azV;
        if (interfaceC0481a == null) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "occur this case, it would be the host task of this messenger has been over(paused/warn/completed/error) on the other thread before receiving the snapshot(id[%d], status[%d])", Integer.valueOf(messageSnapshot.getId()), Byte.valueOf(messageSnapshot.AT()));
            }
        } else {
            if (this.azY || interfaceC0481a.Bb().AO() == null) {
                if ((l.isValid() || this.azV.Bi()) && messageSnapshot.AT() == 4) {
                    this.azW.Bk();
                }
                ck(messageSnapshot.AT());
                return;
            }
            this.azX.offer(messageSnapshot);
            j.BB().a(this);
        }
    }

    private void ck(int i) {
        if (com.kwad.framework.filedownloader.d.d.cN(i)) {
            if (!this.azX.isEmpty()) {
                MessageSnapshot messageSnapshotPeek = this.azX.peek();
                com.kwad.framework.filedownloader.f.d.d(this, "the messenger[%s](with id[%d]) has already accomplished all his job, but there still are some messages in parcel queue[%d] queue-top-status[%d]", this, Integer.valueOf(messageSnapshotPeek.getId()), Integer.valueOf(this.azX.size()), Byte.valueOf(messageSnapshotPeek.AT()));
            }
            this.azV = null;
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    @Override // com.kwad.framework.filedownloader.t
    public final void BF() {
        if (this.azY) {
            return;
        }
        MessageSnapshot messageSnapshotPoll = this.azX.poll();
        byte bAT = messageSnapshotPoll.AT();
        a.InterfaceC0481a interfaceC0481a = this.azV;
        if (interfaceC0481a == null) {
            return;
        }
        a aVarBb = interfaceC0481a.Bb();
        i iVarAO = aVarBb.AO();
        x.a aVarBc = interfaceC0481a.Bc();
        ck(bAT);
        if (iVarAO == null) {
            return;
        }
        if (bAT == 4) {
            try {
                iVarAO.d(aVarBb);
                o(((com.kwad.framework.filedownloader.message.a) messageSnapshotPoll).CV());
                return;
            } catch (Throwable th) {
                m(aVarBc.n(th));
                return;
            }
        }
        g gVar = iVarAO instanceof g ? (g) iVarAO : null;
        if (bAT == -4) {
            iVarAO.c(aVarBb);
            return;
        }
        if (bAT == -3) {
            iVarAO.b(aVarBb);
            return;
        }
        if (bAT == -2) {
            if (gVar != null) {
                messageSnapshotPoll.Da();
                messageSnapshotPoll.CY();
                return;
            } else {
                iVarAO.c(aVarBb, messageSnapshotPoll.CW(), messageSnapshotPoll.CX());
                return;
            }
        }
        if (bAT == -1) {
            iVarAO.a(aVarBb, messageSnapshotPoll.Db());
            return;
        }
        if (bAT == 1) {
            if (gVar != null) {
                messageSnapshotPoll.Da();
                messageSnapshotPoll.CY();
                return;
            } else {
                iVarAO.a(aVarBb, messageSnapshotPoll.CW(), messageSnapshotPoll.CX());
                return;
            }
        }
        if (bAT == 2) {
            if (gVar != null) {
                messageSnapshotPoll.getEtag();
                messageSnapshotPoll.CO();
                messageSnapshotPoll.CY();
                return;
            }
            iVarAO.a(aVarBb, messageSnapshotPoll.getEtag(), messageSnapshotPoll.CO(), aVarBb.getSmallFileSoFarBytes(), messageSnapshotPoll.CX());
            return;
        }
        if (bAT == 3) {
            if (gVar != null) {
                messageSnapshotPoll.Da();
                return;
            } else {
                iVarAO.b(aVarBb, messageSnapshotPoll.CW(), aVarBb.getSmallFileTotalBytes());
                return;
            }
        }
        if (bAT != 5) {
            if (bAT != 6) {
                return;
            }
            iVarAO.a(aVarBb);
        } else if (gVar != null) {
            messageSnapshotPoll.Db();
            messageSnapshotPoll.AX();
            messageSnapshotPoll.Da();
        } else {
            messageSnapshotPoll.Db();
            messageSnapshotPoll.AX();
            messageSnapshotPoll.CW();
        }
    }

    @Override // com.kwad.framework.filedownloader.t
    public final boolean BG() {
        return this.azV.Bb().AY();
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void b(a.InterfaceC0481a interfaceC0481a, a.c cVar) {
        if (this.azV != null) {
            throw new IllegalStateException(com.kwad.framework.filedownloader.f.f.c("the messenger is working, can't re-appointment for %s", interfaceC0481a));
        }
        a(interfaceC0481a, cVar);
    }

    @Override // com.kwad.framework.filedownloader.t
    public final boolean BH() {
        return this.azX.peek().AT() == 4;
    }

    @Override // com.kwad.framework.filedownloader.t
    public final void BI() {
        this.azY = true;
    }

    public final String toString() {
        Object[] objArr = new Object[2];
        a.InterfaceC0481a interfaceC0481a = this.azV;
        objArr[0] = Integer.valueOf(interfaceC0481a == null ? -1 : interfaceC0481a.Bb().getId());
        objArr[1] = super.toString();
        return com.kwad.framework.filedownloader.f.f.c("%d:%s", objArr);
    }
}
