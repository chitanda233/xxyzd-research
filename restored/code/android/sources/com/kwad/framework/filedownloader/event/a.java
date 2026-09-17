package com.kwad.framework.filedownloader.event;

import com.kwad.framework.filedownloader.f.d;
import java.util.HashMap;
import java.util.LinkedList;
import java.util.concurrent.Executor;

/* JADX INFO: loaded from: classes3.dex */
public class a {
    private final Executor aCl = com.kwad.framework.filedownloader.f.b.v(10, "EventPool");
    private final HashMap<String, LinkedList<c>> aCm = new HashMap<>();

    public final boolean a(String str, c cVar) {
        boolean zAdd;
        if (d.aDt) {
            d.e(this, "setListener %s", str);
        }
        if (cVar == null) {
            throw new IllegalArgumentException("listener must not be null!");
        }
        LinkedList<c> linkedList = this.aCm.get(str);
        if (linkedList == null) {
            synchronized (str.intern()) {
                linkedList = this.aCm.get(str);
                if (linkedList == null) {
                    HashMap<String, LinkedList<c>> map = this.aCm;
                    LinkedList<c> linkedList2 = new LinkedList<>();
                    map.put(str, linkedList2);
                    linkedList = linkedList2;
                }
            }
        }
        synchronized (str.intern()) {
            zAdd = linkedList.add(cVar);
        }
        return zAdd;
    }

    public final boolean b(b bVar) {
        if (d.aDt) {
            d.e(this, "publish %s", bVar.getId());
        }
        if (bVar == null) {
            throw new IllegalArgumentException("event must not be null!");
        }
        String id = bVar.getId();
        LinkedList<c> linkedList = this.aCm.get(id);
        if (linkedList == null) {
            synchronized (id.intern()) {
                linkedList = this.aCm.get(id);
                if (linkedList == null) {
                    if (d.aDt) {
                        d.c(this, "No listener for this event %s", id);
                    }
                    return false;
                }
            }
        }
        a(linkedList, bVar);
        return true;
    }

    public final void c(final b bVar) {
        if (d.aDt) {
            d.e(this, "asyncPublishInNewThread %s", bVar.getId());
        }
        this.aCl.execute(new Runnable() { // from class: com.kwad.framework.filedownloader.event.a.1
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    a.this.b(bVar);
                } catch (Exception unused) {
                }
            }
        });
    }

    private static void a(LinkedList<c> linkedList, b bVar) {
        for (Object obj : linkedList.toArray()) {
            if (obj != null) {
                ((c) obj).a(bVar);
            }
        }
        if (bVar.aCr != null) {
            bVar.aCr.run();
        }
    }
}
