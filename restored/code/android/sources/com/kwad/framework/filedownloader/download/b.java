package com.kwad.framework.filedownloader.download;

import java.io.File;
import java.util.Iterator;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private com.kwad.framework.filedownloader.services.c aBb;
    private com.kwad.framework.filedownloader.f.c.a aBc;
    private com.kwad.framework.filedownloader.f.c.b aBd;
    private com.kwad.framework.filedownloader.f.c.e aBe;
    private volatile com.kwad.framework.filedownloader.b.a aBf;
    private com.kwad.framework.filedownloader.f.c.d aBg;

    static final class a {
        private static final b aBh = new b();
    }

    public static b Cm() {
        return a.aBh;
    }

    public final void a(com.kwad.framework.filedownloader.services.c.b bVar) {
        synchronized (this) {
            this.aBb = new com.kwad.framework.filedownloader.services.c(bVar);
            this.aBd = null;
            this.aBe = null;
            this.aBf = null;
            this.aBg = null;
        }
    }

    public final void b(com.kwad.framework.filedownloader.services.c.b bVar) {
        synchronized (this) {
            this.aBb = new com.kwad.framework.filedownloader.services.c(bVar);
        }
    }

    public final com.kwad.framework.filedownloader.a.b bY(String str) {
        try {
            return Cs().bV(str);
        } catch (Throwable unused) {
            com.kwad.framework.filedownloader.a.c.b bVar = new com.kwad.framework.filedownloader.a.c.b();
            this.aBd = bVar;
            return bVar.bV(str);
        }
    }

    public final com.kwad.framework.filedownloader.e.a b(File file) {
        return Ct().c(file);
    }

    public final com.kwad.framework.filedownloader.f.c.d Cn() {
        com.kwad.framework.filedownloader.f.c.d dVar = this.aBg;
        if (dVar != null) {
            return dVar;
        }
        synchronized (this) {
            if (this.aBg == null) {
                this.aBg = Cu().Dt();
            }
        }
        return this.aBg;
    }

    public final synchronized com.kwad.framework.filedownloader.b.a Co() {
        if (this.aBf != null) {
            return this.aBf;
        }
        this.aBf = Cu().Dp();
        a(this.aBf.Cd());
        return this.aBf;
    }

    public final int Cp() {
        return Cu().Cp();
    }

    public final boolean Cq() {
        Ct();
        return true;
    }

    public final int a(int i, String str, String str2, long j) {
        return Cr().Y(j);
    }

    private com.kwad.framework.filedownloader.f.c.a Cr() {
        com.kwad.framework.filedownloader.f.c.a aVar = this.aBc;
        if (aVar != null) {
            return aVar;
        }
        synchronized (this) {
            if (this.aBc == null) {
                this.aBc = Cu().Ds();
            }
        }
        return this.aBc;
    }

    private com.kwad.framework.filedownloader.f.c.b Cs() {
        com.kwad.framework.filedownloader.f.c.b bVar = this.aBd;
        if (bVar != null) {
            return bVar;
        }
        synchronized (this) {
            if (this.aBd == null) {
                this.aBd = Cu().Dr();
            }
        }
        return this.aBd;
    }

    private com.kwad.framework.filedownloader.f.c.e Ct() {
        com.kwad.framework.filedownloader.f.c.e eVar = this.aBe;
        if (eVar != null) {
            return eVar;
        }
        synchronized (this) {
            if (this.aBe == null) {
                this.aBe = Cu().Dq();
            }
        }
        return this.aBe;
    }

    private com.kwad.framework.filedownloader.services.c Cu() {
        com.kwad.framework.filedownloader.services.c cVar = this.aBb;
        if (cVar != null) {
            return cVar;
        }
        synchronized (this) {
            if (this.aBb == null) {
                this.aBb = new com.kwad.framework.filedownloader.services.c();
            }
        }
        return this.aBb;
    }

    /* JADX WARN: Code duplicated, block: B:78:0x01a2  */
    /* JADX WARN: Unreachable blocks removed: 2, instructions: 2 */
    private static void a(com.kwad.framework.filedownloader.b.a.InterfaceC0482a interfaceC0482a) throws Throwable {
        boolean z;
        String str = "refreshed data count: %d , delete data count: %d, reset id count: %d. consume %d";
        Iterator<com.kwad.framework.filedownloader.d.c> it = interfaceC0482a.iterator();
        com.kwad.framework.filedownloader.f.c.d dVarCn = Cm().Cn();
        long jCurrentTimeMillis = System.currentTimeMillis();
        long j = 0;
        long j2 = 0;
        long j3 = 0;
        while (it.hasNext()) {
            try {
                com.kwad.framework.filedownloader.d.c next = it.next();
                if (next.AT() == 3 || next.AT() == 2 || next.AT() == -1 || (next.AT() == 1 && next.Dj() > 0)) {
                    next.d((byte) -2);
                }
                String targetFilePath = next.getTargetFilePath();
                if (targetFilePath == null) {
                    str = str;
                    jCurrentTimeMillis = jCurrentTimeMillis;
                    j = j;
                    z = true;
                } else {
                    File file = new File(targetFilePath);
                    if (next.AT() == -2) {
                        str = str;
                        try {
                            if (com.kwad.framework.filedownloader.f.f.a(next.getId(), next, next.getPath(), null)) {
                                File file2 = new File(next.CB());
                                if (!file2.exists() && file.exists()) {
                                    boolean zRenameTo = file.renameTo(file2);
                                    if (com.kwad.framework.filedownloader.f.d.aDt) {
                                        com.kwad.framework.filedownloader.f.d.c(com.kwad.framework.filedownloader.b.a.class, "resume from the old no-temp-file architecture [%B], [%s]->[%s]", Boolean.valueOf(zRenameTo), file.getPath(), file2.getPath());
                                    }
                                }
                            }
                            if (next.AT() == 1 || next.Dj() > 0) {
                                z = com.kwad.framework.filedownloader.f.f.b(next.getId(), next) || file.exists();
                            }
                        } catch (Throwable th) {
                            th = th;
                            jCurrentTimeMillis = jCurrentTimeMillis;
                            j = j;
                            str = str;
                            com.kwad.framework.filedownloader.f.f.aZ(com.kwad.framework.filedownloader.f.c.DJ());
                            interfaceC0482a.Ce();
                            if (com.kwad.framework.filedownloader.f.d.aDt) {
                                com.kwad.framework.filedownloader.f.d.c(com.kwad.framework.filedownloader.b.a.class, str, Long.valueOf(j), Long.valueOf(j2), Long.valueOf(j3), Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis));
                            }
                            throw th;
                        }
                    } else {
                        str = str;
                    }
                    if (next.AT() == 1) {
                    }
                    if (com.kwad.framework.filedownloader.f.f.b(next.getId(), next)) {
                    }
                }
                if (z) {
                    try {
                        it.remove();
                        j2++;
                        j = j;
                    } catch (Throwable th2) {
                        th = th2;
                        str = str;
                        com.kwad.framework.filedownloader.f.f.aZ(com.kwad.framework.filedownloader.f.c.DJ());
                        interfaceC0482a.Ce();
                        if (com.kwad.framework.filedownloader.f.d.aDt) {
                            com.kwad.framework.filedownloader.f.d.c(com.kwad.framework.filedownloader.b.a.class, str, Long.valueOf(j), Long.valueOf(j2), Long.valueOf(j3), Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis));
                        }
                        throw th;
                    }
                } else {
                    int id = next.getId();
                    int iF = dVarCn.f(next.getUrl(), next.getPath(), next.AN());
                    if (iF != id) {
                        if (com.kwad.framework.filedownloader.f.d.aDt) {
                            com.kwad.framework.filedownloader.f.d.c(com.kwad.framework.filedownloader.b.a.class, "the id is changed on restoring from db: old[%d] -> new[%d]", Integer.valueOf(id), Integer.valueOf(iF));
                        }
                        next.setId(iF);
                        interfaceC0482a.a(id, next);
                        j3++;
                    }
                    interfaceC0482a.c(next);
                    j++;
                }
            } catch (Throwable th3) {
                th = th3;
                jCurrentTimeMillis = jCurrentTimeMillis;
                j = j;
            }
        }
        String str2 = str;
        long j4 = jCurrentTimeMillis;
        long j5 = j;
        com.kwad.framework.filedownloader.f.f.aZ(com.kwad.framework.filedownloader.f.c.DJ());
        interfaceC0482a.Ce();
        if (com.kwad.framework.filedownloader.f.d.aDt) {
            com.kwad.framework.filedownloader.f.d.c(com.kwad.framework.filedownloader.b.a.class, str2, Long.valueOf(j5), Long.valueOf(j2), Long.valueOf(j3), Long.valueOf(System.currentTimeMillis() - j4));
        }
    }
}
