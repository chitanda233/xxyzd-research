package com.kwad.components.ad.splashscreen.presenter.a;

import android.app.Activity;
import com.kwad.components.ad.splashscreen.presenter.e;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.j;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.g;

/* JADX INFO: loaded from: classes3.dex */
public abstract class c extends e implements j {
    private b KE;

    public void a(az azVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(o oVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(p pVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(n nVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(u uVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public void a(WebCloseStatus webCloseStatus) {
    }

    public void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aC() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aD() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public String getRegisterViewKey() {
        return null;
    }

    protected int nI() {
        return 1000;
    }

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        int iNI = nI();
        b bVar = new b(getContext(), iNI, iNI);
        this.KE = bVar;
        bVar.a((Activity) null, this.Hu.mAdResultData, this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public void onUnbind() {
        super.onUnbind();
        this.KE.kT();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public g getTouchCoordsView() {
        return this.Hu.mRootContainer;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
        String str = c0464a.apu;
        str.hashCode();
        switch (str) {
            case "adShowCallback":
                this.Hu.md();
                break;
            case "adDownloadConfirmTipCancel":
                this.Hu.mi();
                break;
            case "adCloseCallback":
                this.Hu.mf();
                break;
            case "adDownloadConfirmTipShow":
                this.Hu.mh();
                break;
            case "adDownloadConfirmTipDismiss":
                this.Hu.mj();
                break;
            case "adAutoCloseCallback":
                this.Hu.me();
                break;
            case "adShowErrorCallback":
                this.Hu.mc();
                break;
            case "adClickCallback":
                this.Hu.mg();
                break;
        }
    }
}
