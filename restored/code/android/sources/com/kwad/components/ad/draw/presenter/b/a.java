package com.kwad.components.ad.draw.presenter.b;

import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private InterfaceC0362a eT;
    private b eU;
    private boolean eV = false;
    private AdTemplate mAdTemplate;

    /* JADX INFO: renamed from: com.kwad.components.ad.draw.presenter.b.a$a, reason: collision with other inner class name */
    public interface InterfaceC0362a {
        void aX();
    }

    public interface b {
        boolean aY();
    }

    public a(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
    }

    public final void aW() {
        InterfaceC0362a interfaceC0362a;
        if (this.eV) {
            return;
        }
        this.eV = true;
        if (e.eM(this.mAdTemplate).status == 1 || e.eM(this.mAdTemplate).status == 2 || e.eM(this.mAdTemplate).status == 3) {
            return;
        }
        b bVar = this.eU;
        if ((bVar == null || !bVar.aY()) && (interfaceC0362a = this.eT) != null) {
            interfaceC0362a.aX();
        }
    }

    public final void a(InterfaceC0362a interfaceC0362a) {
        this.eT = interfaceC0362a;
    }

    public final void a(b bVar) {
        this.eU = bVar;
    }
}
