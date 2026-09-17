package com.kwad.sdk.core.video.a;

import android.media.TimedText;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a implements c {
    private c.f aZg;
    private c.g aZh;
    private c.h aZi;
    private c.e amP;
    private c.i amQ;
    private c.b amR;
    private c.InterfaceC0518c amS;
    private c.d amT;
    private c.a amU;

    @Override // com.kwad.sdk.core.video.a.c
    public final void a(c.f fVar) {
        this.aZg = fVar;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void b(c.e eVar) {
        this.amP = eVar;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void a(c.b bVar) {
        this.amR = bVar;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void a(c.a aVar) {
        this.amU = aVar;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void a(c.g gVar) {
        this.aZh = gVar;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void a(c.i iVar) {
        this.amQ = iVar;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void a(c.InterfaceC0518c interfaceC0518c) {
        this.amS = interfaceC0518c;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void c(c.d dVar) {
        this.amT = dVar;
    }

    @Override // com.kwad.sdk.core.video.a.c
    public final void a(c.h hVar) {
        this.aZi = hVar;
    }

    public final void resetListeners() {
        this.aZg = null;
        this.amP = null;
        this.amU = null;
        this.amR = null;
        this.aZh = null;
        this.amQ = null;
        this.amS = null;
        this.amT = null;
        this.aZi = null;
    }

    protected final void OO() {
        c.f fVar = this.aZg;
        if (fVar != null) {
            fVar.xF();
        }
    }

    public final void notifyOnPrepared() {
        c.e eVar = this.amP;
        if (eVar != null) {
            eVar.a(this);
        }
    }

    public final void notifyOnCompletion() {
        c.b bVar = this.amR;
        if (bVar != null) {
            bVar.tW();
        }
    }

    public final void notifyOnBufferingUpdate(int i) {
        c.a aVar = this.amU;
        if (aVar != null) {
            aVar.bh(i);
        }
    }

    public final void notifyOnSeekComplete() {
        c.g gVar = this.aZh;
        if (gVar != null) {
            gVar.tX();
        }
    }

    public final void D(int i, int i2) {
        c.i iVar = this.amQ;
        if (iVar != null) {
            iVar.m(i, i2);
        }
    }

    public final boolean notifyOnError(int i, int i2) {
        com.kwad.sdk.core.video.a.a.a.fq("videoPlayError");
        c.InterfaceC0518c interfaceC0518c = this.amS;
        return interfaceC0518c != null && interfaceC0518c.n(i, i2);
    }

    public final boolean notifyOnInfo(int i, int i2) {
        c.d dVar = this.amT;
        return dVar != null && dVar.o(i, i2);
    }

    protected final void b(TimedText timedText) {
        c.h hVar = this.aZi;
        if (hVar != null) {
            hVar.a(timedText);
        }
    }

    protected static void o(float f) {
        if (f == 0.0f) {
            com.kwad.sdk.core.video.a.a.a.fq("autoMute");
        } else {
            com.kwad.sdk.core.video.a.a.a.fq("autoVoice");
        }
    }
}
