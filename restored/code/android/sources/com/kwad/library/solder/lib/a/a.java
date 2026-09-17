package com.kwad.library.solder.lib.a;

import android.content.Context;
import com.kwad.library.solder.lib.i;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a {
    protected File aEG;
    protected String aEH;
    protected String aEI;
    private final String aEL;
    protected com.kwad.library.solder.lib.c.b aEM;
    protected String mVersion;
    private final byte[] aEK = new byte[0];
    private boolean aEJ = false;
    protected com.kwad.library.solder.lib.ext.c aEl = i.Ec().DW();

    protected abstract void l(Context context, String str);

    public a(String str) {
        this.aEL = str;
        this.aEH = str;
    }

    public String toString() {
        return "Plugin{, ApkPath = '" + this.aEL + "'}";
    }

    public final a a(com.kwad.library.solder.lib.c.b bVar) {
        this.aEM = bVar;
        return this;
    }

    public final String getVersion() {
        return this.mVersion;
    }

    public final void cz(String str) {
        this.mVersion = str;
    }

    public final boolean isLoaded() {
        boolean z;
        if (this.aEJ) {
            return true;
        }
        synchronized (this.aEK) {
            z = this.aEJ;
        }
        return z;
    }

    public final String getId() {
        return this.aEI;
    }

    public final void cA(String str) {
        this.aEI = str;
    }

    private void Eg() {
        if (this.aEJ) {
            return;
        }
        synchronized (this.aEK) {
            this.aEJ = true;
        }
    }

    public final String Eh() {
        return this.aEL;
    }

    public final void cB(String str) {
        this.aEH = str;
    }

    public final String Ei() {
        com.kwad.library.solder.lib.c.b bVar = this.aEM;
        if (bVar != null) {
            return bVar.aFw;
        }
        return null;
    }

    public final void q(Context context, String str) {
        l(context, str);
        Eg();
    }
}
