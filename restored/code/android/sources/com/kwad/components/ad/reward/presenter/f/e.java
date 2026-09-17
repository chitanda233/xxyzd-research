package com.kwad.components.ad.reward.presenter.f;

import com.kwad.components.core.webview.jshandler.az;

/* JADX INFO: loaded from: classes3.dex */
public final class e implements com.kwad.components.ad.reward.g.a {
    private boolean AP;
    private boolean AQ;
    private az di;

    private void ks() {
        az azVar = this.di;
        if (azVar == null || !this.AQ) {
            return;
        }
        if (!this.AP) {
            azVar.yJ();
            this.di.yK();
            this.AP = true;
            return;
        }
        azVar.yN();
    }

    public final void b(az azVar) {
        this.di = azVar;
    }

    public final void A(com.kwad.components.ad.reward.g gVar) {
        gVar.a(this);
    }

    public final void B(com.kwad.components.ad.reward.g gVar) {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
        gVar.b(this);
    }

    public final void aB() {
        ks();
    }

    public final void kt() {
        az azVar = this.di;
        if (azVar != null) {
            azVar.yL();
            this.di.yM();
        }
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void hn() {
        this.AQ = true;
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void ho() {
        this.AQ = true;
        ks();
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void hp() {
        this.AQ = false;
        az azVar = this.di;
        if (azVar != null) {
            azVar.yO();
        }
    }

    @Override // com.kwad.components.ad.reward.g.a
    public final void hq() {
        this.AQ = false;
    }
}
