package com.kwad.components.core.innerEc.live.b.c;

/* JADX INFO: loaded from: classes3.dex */
public final class i extends com.kwad.components.core.innerEc.live.b.a.a {
    private com.kwad.components.core.innerEc.live.config.b UN;
    private com.kwad.components.core.innerEc.live.end.a UO;
    private final com.kwad.components.core.innerEc.live.end.c Wj = new com.kwad.components.core.innerEc.live.end.c() { // from class: com.kwad.components.core.innerEc.live.b.c.i.1
        @Override // com.kwad.components.core.innerEc.live.end.c
        public final void ss() {
        }
    };
    private boolean Xe;

    @Override // com.kwad.components.core.innerEc.live.b.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.components.core.innerEc.live.config.b bVar = this.Uj.UN;
        this.UN = bVar;
        bVar.a(this.Uj);
        com.kwad.components.core.innerEc.live.end.a aVar = this.Uj.UO;
        this.UO = aVar;
        aVar.a(this.Wj);
        sM();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.UO.b(this.Wj);
    }

    private void sM() {
        if (this.Xe) {
            return;
        }
        com.kwad.components.core.innerEc.live.end.a aVar = this.UO;
        if (aVar == null || !aVar.sP()) {
            this.Xe = true;
            rQ();
        }
    }

    private void rQ() {
        this.UN.rQ();
    }
}
