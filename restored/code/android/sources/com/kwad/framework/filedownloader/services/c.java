package com.kwad.framework.filedownloader.services;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private final b aCX;

    public interface a {
        com.kwad.framework.filedownloader.f.c.b Cs();
    }

    public c() {
        this.aCX = null;
    }

    public c(b bVar) {
        this.aCX = bVar;
    }

    public final int Cp() {
        b bVar = this.aCX;
        if (bVar == null) {
            return Dv();
        }
        Integer num = bVar.aCZ;
        if (num != null) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "initial FileDownloader manager with the customize maxNetworkThreadCount: %d", num);
            }
            return com.kwad.framework.filedownloader.f.e.cT(num.intValue());
        }
        return Dv();
    }

    public final com.kwad.framework.filedownloader.b.a Dp() {
        b bVar = this.aCX;
        if (bVar == null || bVar.aCY == null) {
            return new com.kwad.framework.filedownloader.b.c();
        }
        com.kwad.framework.filedownloader.b.a aVarDK = this.aCX.aCY.DK();
        return aVarDK != null ? aVarDK : new com.kwad.framework.filedownloader.b.c();
    }

    public final com.kwad.framework.filedownloader.f.c.e Dq() {
        b bVar = this.aCX;
        if (bVar == null) {
            return Dw();
        }
        com.kwad.framework.filedownloader.f.c.e eVar = bVar.aDa;
        if (eVar != null) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "initial FileDownloader manager with the customize output stream: %s", eVar);
            }
            return eVar;
        }
        return Dw();
    }

    public final com.kwad.framework.filedownloader.f.c.b Dr() {
        com.kwad.framework.filedownloader.f.c.b bVarCs;
        b bVar = this.aCX;
        if (bVar == null) {
            return Dx();
        }
        a aVar = bVar.aDc;
        return (aVar == null || (bVarCs = aVar.Cs()) == null) ? Dx() : bVarCs;
    }

    public final com.kwad.framework.filedownloader.f.c.a Ds() {
        b bVar = this.aCX;
        if (bVar == null) {
            return Dy();
        }
        com.kwad.framework.filedownloader.f.c.a aVar = bVar.aDd;
        if (aVar != null) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "initial FileDownloader manager with the customize connection count adapter: %s", aVar);
            }
            return aVar;
        }
        return Dy();
    }

    public final com.kwad.framework.filedownloader.f.c.d Dt() {
        b bVar = this.aCX;
        if (bVar == null) {
            return Du();
        }
        com.kwad.framework.filedownloader.f.c.d dVar = bVar.aDe;
        if (dVar != null) {
            if (com.kwad.framework.filedownloader.f.d.aDt) {
                com.kwad.framework.filedownloader.f.d.c(this, "initial FileDownloader manager with the customize id generator: %s", dVar);
            }
            return dVar;
        }
        return Du();
    }

    private static com.kwad.framework.filedownloader.f.c.d Du() {
        return new com.kwad.framework.filedownloader.services.b();
    }

    private static int Dv() {
        return com.kwad.framework.filedownloader.f.e.DL().aDy;
    }

    private static com.kwad.framework.filedownloader.f.c.e Dw() {
        return new com.kwad.framework.filedownloader.e.b.a();
    }

    private static com.kwad.framework.filedownloader.f.c.b Dx() {
        return new com.kwad.framework.filedownloader.a.c.b();
    }

    private static com.kwad.framework.filedownloader.f.c.a Dy() {
        return new com.kwad.framework.filedownloader.a.a();
    }

    public static class b {
        com.kwad.framework.filedownloader.f.c.InterfaceC0487c aCY;
        Integer aCZ;
        com.kwad.framework.filedownloader.f.c.e aDa;
        com.kwad.framework.filedownloader.f.c.b aDb;
        a aDc;
        com.kwad.framework.filedownloader.f.c.a aDd;
        com.kwad.framework.filedownloader.f.c.d aDe;

        public final b cP(int i) {
            this.aCZ = Integer.MAX_VALUE;
            return this;
        }

        public final b a(com.kwad.framework.filedownloader.f.c.b bVar) {
            this.aDb = bVar;
            return this;
        }

        public final b a(a aVar) {
            this.aDc = aVar;
            return this;
        }

        public final String toString() {
            return com.kwad.framework.filedownloader.f.f.c("component: database[%s], maxNetworkCount[%s], outputStream[%s], connection[%s], connectionCountAdapter[%s]", this.aCY, this.aCZ, this.aDa, this.aDb, this.aDd);
        }
    }
}
