package com.kwad.sdk.core.webview;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private long bch;
    private long bci;
    private boolean bcj;
    private boolean bck;

    public final void a(com.kwad.sdk.core.webview.a.c.a aVar) {
        if (aVar != null) {
            com.kwad.sdk.core.adlog.c.a aVarPZ = aVar.pZ();
            com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
            c0502a.a(aVar.getAdTemplate(), null, null, null);
            if (c0502a.aLF != null) {
                c0502a.aLF.setKsUaPattern(aVar.PO());
                c0502a.aLF.setUnionMark(aVar.PP());
            }
            aVarPZ.a(c0502a);
            com.kwad.sdk.core.adlog.c.a(aVar.getAdTemplate(), aVarPZ);
        }
        if (aVar != null) {
            this.bch = System.currentTimeMillis();
            this.bci = System.currentTimeMillis();
        }
    }

    public final void b(com.kwad.sdk.core.webview.a.c.a aVar) {
        if (aVar != null) {
            com.kwad.sdk.core.adlog.c.l(aVar.getAdTemplate(), System.currentTimeMillis() - this.bch);
        }
    }

    public final void c(com.kwad.sdk.core.webview.a.c.a aVar) {
        if (aVar == null || this.bcj) {
            return;
        }
        this.bcj = true;
        long jCurrentTimeMillis = 0;
        if (this.bch > 0) {
            jCurrentTimeMillis = System.currentTimeMillis() - this.bch;
            this.bch = -1L;
        }
        com.kwad.sdk.core.adlog.c.a(aVar.getAdTemplate(), aVar.pZ(), jCurrentTimeMillis);
    }

    public static void d(com.kwad.sdk.core.webview.a.c.a aVar) {
        if (aVar != null) {
            com.kwad.sdk.core.adlog.c.b(aVar.getAdTemplate(), aVar.pZ());
        }
    }

    public final void e(com.kwad.sdk.core.webview.a.c.a aVar) {
        if (aVar == null || this.bck) {
            return;
        }
        this.bck = true;
        long jCurrentTimeMillis = 0;
        if (this.bci > 0) {
            jCurrentTimeMillis = System.currentTimeMillis() - this.bci;
            this.bci = -1L;
        }
        com.kwad.sdk.core.adlog.c.b(aVar.getAdTemplate(), aVar.pZ(), jCurrentTimeMillis);
    }
}
