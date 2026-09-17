package com.kwad.components.ad.interstitial.f.a;

import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.i;
import com.kwad.components.core.webview.tachikoma.j;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.g;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a extends com.kwad.components.ad.interstitial.f.b implements j {
    private i gg;

    @Override // com.kwad.components.core.webview.tachikoma.j
    public void a(az azVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(p pVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(n nVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public void a(u uVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public void a(WebCloseStatus webCloseStatus) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public void onCreate() {
        super.onCreate();
        this.gg = new i(-1L, getContext());
    }

    @Override // com.kwad.components.ad.interstitial.f.b, com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        this.gg.a(getActivity(), this.mF.mAdResultData, this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public void onUnbind() {
        super.onUnbind();
        i iVar = this.gg;
        if (iVar != null) {
            iVar.kT();
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public g getTouchCoordsView() {
        return this.mF.gh;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
        tVar.c(new com.kwad.components.core.webview.tachikoma.b.i(new com.kwad.components.core.webview.tachikoma.b.i.a() { // from class: com.kwad.components.ad.interstitial.f.a.a.1
            @Override // com.kwad.components.core.webview.tachikoma.b.i.a
            public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
                com.kwad.components.ad.interstitial.report.a.eT().a(a.this.mF.mAdTemplate, 1L, 177L);
                a.this.a(aVar);
            }
        }));
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
        if (this.mF == null || this.mF.lk == null) {
            return;
        }
        String str = c0464a.apu;
        str.hashCode();
        switch (str) {
            case "adSkipCallback":
                this.mF.lk.onSkippedAd();
                break;
            case "adShowCallback":
                this.mF.lk.onAdShow();
                break;
            case "adCloseCallback":
                this.mF.lk.onAdClosed();
                break;
            case "adAutoCloseCallback":
                this.mF.lk.onPageDismiss();
                break;
            case "adClickCallback":
                this.mF.lk.onAdClicked();
                break;
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
        this.mF.mH = true;
        this.mF.c(aVar.bdh, aVar.ne);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(o oVar) {
        n nVar = new n();
        nVar.auv = !this.mF.ce.isVideoSoundEnable();
        oVar.c(nVar);
    }
}
