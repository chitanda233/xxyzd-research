package com.kwad.components.core.e.a;

import android.app.Activity;
import android.widget.FrameLayout;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.i;
import com.kwad.components.core.webview.tachikoma.j;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends Presenter implements j, com.kwad.sdk.core.j.c {
    private com.kwad.components.core.widget.a.c PR;
    private a Qb;
    private az ff;
    private i gg;
    private AdTemplate mAdTemplate;

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
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
    public final void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
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
    public final String getRegisterViewKey() {
        return null;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_installed_activate";
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        a aVar = (a) SK();
        this.Qb = aVar;
        this.mAdTemplate = aVar.mAdTemplate;
        this.PR = this.Qb.PR;
        this.gg = new i(getContext()) { // from class: com.kwad.components.core.e.a.f.1
            @Override // com.kwad.components.core.webview.tachikoma.i
            public final boolean py() {
                return true;
            }
        };
        this.gg.a((Activity) null, com.kwad.sdk.core.response.helper.c.ex(this.mAdTemplate), this);
        this.PR.a(this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.gg.kT();
        this.PR.b(this);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.cL(this.mAdTemplate).installedActivateInfo.templateId;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final com.kwad.sdk.widget.g getTouchCoordsView() {
        return this.Qb.PQ;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final FrameLayout getTKContainer() {
        return this.Qb.PQ;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        com.kwad.sdk.core.d.c.d("InstalledActivatePresenter", "onTkLoadFailed");
        am(true);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        com.kwad.sdk.core.d.c.d("InstalledActivatePresenter", "onTkLoadSuccess");
        this.Qb.aa();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
        com.kwad.sdk.core.d.c.d("InstalledActivatePresenter", "onAdClicked");
        am(false);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        float screenHeight = com.kwad.sdk.c.a.a.getScreenHeight(getContext());
        aVar.width = (int) ((com.kwad.sdk.c.a.a.getScreenWidth(getContext()) / fBA) + 0.5f);
        aVar.height = (int) ((screenHeight / fBA) + 0.5f);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(WebCloseStatus webCloseStatus) {
        am(false);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        this.ff = azVar;
        this.Qb.ff = azVar;
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        com.kwad.sdk.core.d.c.d("InstalledActivatePresenter", "onPageVisible");
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yN();
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        com.kwad.sdk.core.d.c.d("InstalledActivatePresenter", "onPageInvisible");
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yO();
        }
    }

    private void am(boolean z) {
        if (!z) {
            this.Qb.ac();
        }
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.e.a.f.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                f.this.Qb.PS.ps();
            }
        });
    }
}
