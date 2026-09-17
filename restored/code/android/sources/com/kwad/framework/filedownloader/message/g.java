package com.kwad.framework.filedownloader.message;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.Executor;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    private final e.b aCB;
    private final List<a> aCD = new ArrayList();

    g(int i, e.b bVar) {
        this.aCB = bVar;
        for (int i2 = 0; i2 < 5; i2++) {
            this.aCD.add(new a(i2));
        }
    }

    public final void u(MessageSnapshot messageSnapshot) {
        a aVar = null;
        try {
            synchronized (this.aCD) {
                int id = messageSnapshot.getId();
                for (a aVar2 : this.aCD) {
                    if (aVar2.aCE.contains(Integer.valueOf(id))) {
                        aVar = aVar2;
                        break;
                    }
                }
                if (aVar == null) {
                    int size = 0;
                    for (a aVar3 : this.aCD) {
                        if (aVar3.aCE.size() <= 0) {
                            aVar = aVar3;
                            break;
                        } else if (size == 0 || aVar3.aCE.size() < size) {
                            size = aVar3.aCE.size();
                            aVar = aVar3;
                        }
                    }
                }
                if (aVar != null) {
                    aVar.cJ(id);
                }
            }
            if (aVar != null) {
                aVar.u(messageSnapshot);
            }
        } catch (Throwable th) {
            if (aVar != null) {
                aVar.u(messageSnapshot);
            }
            throw th;
        }
    }

    public class a {
        private final List<Integer> aCE = new ArrayList();
        private final Executor aCF;

        public a(int i) {
            this.aCF = com.kwad.framework.filedownloader.f.b.v(1, "Flow-" + i);
        }

        public final void cJ(int i) {
            this.aCE.add(Integer.valueOf(i));
        }

        public final void u(final MessageSnapshot messageSnapshot) {
            this.aCF.execute(new Runnable() { // from class: com.kwad.framework.filedownloader.message.g.a.1
                @Override // java.lang.Runnable
                public final void run() {
                    g.this.aCB.r(messageSnapshot);
                    try {
                        a.this.aCE.remove(Integer.valueOf(messageSnapshot.getId()));
                    } catch (Exception unused) {
                    }
                }
            });
        }
    }
}
