package com.kwad.framework.filedownloader;

import android.content.Context;
import com.kwad.sdk.api.proxy.app.FileDownloadService;

/* JADX INFO: loaded from: classes3.dex */
public final class n implements u {
    private final u aAa;

    /* synthetic */ n(byte b) {
        this();
    }

    static final class a {
        private static final n aAb = new n(0);
    }

    public static n BK() {
        return a.aAb;
    }

    public static com.kwad.framework.filedownloader.services.e.a BL() {
        if (BK().aAa instanceof o) {
            return (com.kwad.framework.filedownloader.services.e.a) BK().aAa;
        }
        return null;
    }

    private n() {
        u pVar;
        if (com.kwad.framework.filedownloader.f.e.DL().aDx) {
            pVar = new o();
        } else {
            pVar = new p(FileDownloadService.SeparateProcessService.class);
        }
        this.aAa = pVar;
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean a(String str, String str2, boolean z, int i, int i2, int i3, boolean z2, com.kwad.framework.filedownloader.d.b bVar, boolean z3) {
        return this.aAa.a(str, str2, z, i, i2, i3, z2, bVar, z3);
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean cl(int i) {
        return this.aAa.cl(i);
    }

    @Override // com.kwad.framework.filedownloader.u
    public final byte cm(int i) {
        return this.aAa.cm(i);
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean isConnected() {
        return this.aAa.isConnected();
    }

    @Override // com.kwad.framework.filedownloader.u
    public final void aV(Context context) {
        this.aAa.aV(context);
    }

    @Override // com.kwad.framework.filedownloader.u
    public final boolean cn(int i) {
        return this.aAa.cn(i);
    }
}
