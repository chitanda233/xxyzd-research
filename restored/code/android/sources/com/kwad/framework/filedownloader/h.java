package com.kwad.framework.filedownloader;

import com.kwad.framework.filedownloader.message.MessageSnapshot;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class h {
    private final ArrayList<com.kwad.framework.filedownloader.a.InterfaceC0481a> azK;

    /* synthetic */ h(byte b) {
        this();
    }

    static final class a {
        private static final h azL = new h(0);
    }

    public static h Bz() {
        return a.azL;
    }

    private h() {
        this.azK = new ArrayList<>();
    }

    final int size() {
        return this.azK.size();
    }

    final int ch(int i) {
        int i2;
        synchronized (this.azK) {
            Iterator<com.kwad.framework.filedownloader.a.InterfaceC0481a> it = this.azK.iterator();
            i2 = 0;
            while (it.hasNext()) {
                if (it.next().cg(i)) {
                    i2++;
                }
            }
        }
        return i2;
    }

    final List<com.kwad.framework.filedownloader.a.InterfaceC0481a> ci(int i) {
        byte bAT;
        ArrayList arrayList = new ArrayList();
        synchronized (this.azK) {
            for (com.kwad.framework.filedownloader.a.InterfaceC0481a interfaceC0481a : this.azK) {
                if (interfaceC0481a.cg(i) && !interfaceC0481a.isOver() && (bAT = interfaceC0481a.Bb().AT()) != 0 && bAT != 10) {
                    arrayList.add(interfaceC0481a);
                }
            }
        }
        return arrayList;
    }

    final List<com.kwad.framework.filedownloader.a.InterfaceC0481a> cj(int i) {
        ArrayList arrayList = new ArrayList();
        synchronized (this.azK) {
            for (com.kwad.framework.filedownloader.a.InterfaceC0481a interfaceC0481a : this.azK) {
                if (interfaceC0481a.cg(i) && !interfaceC0481a.isOver()) {
                    arrayList.add(interfaceC0481a);
                }
            }
        }
        return arrayList;
    }

    final boolean a(com.kwad.framework.filedownloader.a.InterfaceC0481a interfaceC0481a) {
        return this.azK.isEmpty() || !this.azK.contains(interfaceC0481a);
    }

    final void v(List<com.kwad.framework.filedownloader.a.InterfaceC0481a> list) {
        synchronized (this.azK) {
            for (com.kwad.framework.filedownloader.a.InterfaceC0481a interfaceC0481a : this.azK) {
                if (!list.contains(interfaceC0481a)) {
                    list.add(interfaceC0481a);
                }
            }
            this.azK.clear();
        }
    }

    public final boolean a(com.kwad.framework.filedownloader.a.InterfaceC0481a interfaceC0481a, MessageSnapshot messageSnapshot) {
        boolean zRemove;
        byte bAT = messageSnapshot.AT();
        synchronized (this.azK) {
            zRemove = this.azK.remove(interfaceC0481a);
        }
        if (com.kwad.framework.filedownloader.f.d.aDt && this.azK.size() == 0) {
            com.kwad.framework.filedownloader.f.d.e(this, "remove %s left %d %d", interfaceC0481a, Byte.valueOf(bAT), Integer.valueOf(this.azK.size()));
        }
        if (zRemove) {
            t tVarBr = interfaceC0481a.Bc().Br();
            if (bAT == -4) {
                tVarBr.l(messageSnapshot);
            } else if (bAT == -3) {
                tVarBr.j(com.kwad.framework.filedownloader.message.f.t(messageSnapshot));
            } else if (bAT == -2) {
                tVarBr.n(messageSnapshot);
            } else if (bAT == -1) {
                tVarBr.m(messageSnapshot);
            }
        } else {
            com.kwad.framework.filedownloader.f.d.a(this, "remove error, not exist: %s %d", interfaceC0481a, Byte.valueOf(bAT));
        }
        return zRemove;
    }

    final void b(com.kwad.framework.filedownloader.a.InterfaceC0481a interfaceC0481a) {
        if (!interfaceC0481a.Bb().AK()) {
            interfaceC0481a.Be();
        }
        if (interfaceC0481a.Bc().Br().BE()) {
            c(interfaceC0481a);
        }
    }

    final void c(com.kwad.framework.filedownloader.a.InterfaceC0481a interfaceC0481a) {
        if (interfaceC0481a.Bf()) {
            return;
        }
        synchronized (this.azK) {
            if (this.azK.contains(interfaceC0481a)) {
                com.kwad.framework.filedownloader.f.d.d(this, "already has %s", interfaceC0481a);
            } else {
                interfaceC0481a.Bg();
                this.azK.add(interfaceC0481a);
                if (com.kwad.framework.filedownloader.f.d.aDt) {
                    com.kwad.framework.filedownloader.f.d.e(this, "add list in all %s %d %d", interfaceC0481a, Byte.valueOf(interfaceC0481a.Bb().AT()), Integer.valueOf(this.azK.size()));
                }
            }
        }
    }
}
