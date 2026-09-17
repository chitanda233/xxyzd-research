package com.kwad.components.core.pfmonitor;

import com.kwad.components.core.pfmonitor.model.e;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
final class a implements b.InterfaceC0456b, Runnable {
    private e aij;
    private com.kwad.components.core.pfmonitor.model.c aik;
    private int ail = 0;
    private final int aim;

    public a(e eVar, int i) {
        this.aim = i;
        this.aij = eVar;
    }

    @Override // java.lang.Runnable
    public final void run() {
        this.ail = 1;
        try {
            com.kwad.components.core.pfmonitor.model.c cVarA = b.a(new File(this.aij.vH()), null, this.aim, this);
            this.aik = cVarA;
            cVarA.a(this.aij);
            this.ail = 2;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            this.ail = 3;
        }
        if (this.aik == null) {
            this.ail = 3;
        }
    }

    public final int getStatus() {
        return this.ail;
    }

    public final com.kwad.components.core.pfmonitor.model.c vD() {
        if (this.ail == 2) {
            return this.aik;
        }
        return null;
    }
}
