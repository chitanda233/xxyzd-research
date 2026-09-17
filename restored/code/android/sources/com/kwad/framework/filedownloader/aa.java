package com.kwad.framework.filedownloader;

import com.kwad.framework.filedownloader.message.MessageSnapshot;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class aa implements com.kwad.framework.filedownloader.message.e.b {
    private static boolean a(List<a.InterfaceC0481a> list, MessageSnapshot messageSnapshot) {
        if (list.size() > 1 && messageSnapshot.AT() == -3) {
            Iterator<a.InterfaceC0481a> it = list.iterator();
            while (it.hasNext()) {
                if (it.next().Bc().c(messageSnapshot)) {
                    return true;
                }
            }
        }
        Iterator<a.InterfaceC0481a> it2 = list.iterator();
        while (it2.hasNext()) {
            if (it2.next().Bc().b(messageSnapshot)) {
                return true;
            }
        }
        if (-4 == messageSnapshot.AT()) {
            Iterator<a.InterfaceC0481a> it3 = list.iterator();
            while (it3.hasNext()) {
                if (it3.next().Bc().d(messageSnapshot)) {
                    return true;
                }
            }
        }
        if (list.size() == 1) {
            return list.get(0).Bc().a(messageSnapshot);
        }
        return false;
    }

    @Override // com.kwad.framework.filedownloader.message.e.b
    public final void r(MessageSnapshot messageSnapshot) {
        synchronized (Integer.toString(messageSnapshot.getId()).intern()) {
            List<a.InterfaceC0481a> listCi = h.Bz().ci(messageSnapshot.getId());
            if (listCi.size() > 0) {
                a aVarBb = listCi.get(0).Bb();
                if (com.kwad.framework.filedownloader.f.d.aDt) {
                    com.kwad.framework.filedownloader.f.d.c(this, "~~~callback %s old[%s] new[%s] %d", Integer.valueOf(messageSnapshot.getId()), Byte.valueOf(aVarBb.AT()), Byte.valueOf(messageSnapshot.AT()), Integer.valueOf(listCi.size()));
                }
                if (!a(listCi, messageSnapshot)) {
                    StringBuilder sb = new StringBuilder("The event isn't consumed, id:" + messageSnapshot.getId() + " status:" + ((int) messageSnapshot.AT()) + " task-count:" + listCi.size());
                    Iterator<a.InterfaceC0481a> it = listCi.iterator();
                    while (it.hasNext()) {
                        sb.append(" | ").append((int) it.next().Bb().AT());
                    }
                    com.kwad.framework.filedownloader.f.d.b(this, sb.toString(), new Object[0]);
                }
            } else {
                com.kwad.framework.filedownloader.f.d.b(this, "Receive the event %d, but there isn't any running task in the upper layer", Byte.valueOf(messageSnapshot.AT()));
            }
        }
    }
}
