package com.kwad.components.core.innerEc.a;

import android.app.Activity;
import android.widget.FrameLayout;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class i extends Presenter implements com.kwad.components.core.webview.tachikoma.j, com.kwad.sdk.core.j.c {
    private com.kwad.components.core.widget.a.c PR;
    private a Tb;
    private az ff;
    private com.kwad.components.core.webview.tachikoma.i gg;
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
        return "tk_inner_ec_auth";
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        a aVar = (a) SK();
        this.Tb = aVar;
        this.mAdTemplate = aVar.mAdTemplate;
        this.PR = this.Tb.PR;
        this.gg = new com.kwad.components.core.webview.tachikoma.i(getContext()) { // from class: com.kwad.components.core.innerEc.a.i.1
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
        return com.kwad.sdk.core.response.helper.b.cL(this.mAdTemplate).innerEcAuthInfo.templateId;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final com.kwad.sdk.widget.g getTouchCoordsView() {
        return this.Tb.SZ;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final FrameLayout getTKContainer() {
        return this.Tb.SZ;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        com.kwad.sdk.core.d.c.d("AuthHintPresenter", "onTkLoadFailed");
        am(true);
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.a.i.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                i.this.Tb.Ta.rs();
            }
        });
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        com.kwad.sdk.core.d.c.d("AuthHintPresenter", "onTkLoadSuccess");
        this.Tb.Ta.rr();
        this.Tb.ro();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
        com.kwad.sdk.core.d.c.d("AuthHintPresenter", "onAdClicked");
        am(false);
        com.kwad.components.core.innerEc.f.a(getContext(), this.mAdTemplate, (com.kwad.components.core.e.d.a.C0428a) null, new k() { // from class: com.kwad.components.core.innerEc.a.i.3
            @Override // com.kwad.components.core.innerEc.a.k
            public final void oT() {
            }

            @Override // com.kwad.components.core.innerEc.a.k
            public final void oU() {
                i.this.Tb.Ta.oU();
            }

            @Override // com.kwad.components.core.innerEc.a.k
            public final void k(int i, String str) {
                i.this.Tb.Ta.rn();
            }

            @Override // com.kwad.components.core.innerEc.a.k
            public final void oV() {
                i.this.Tb.Ta.oV();
            }
        });
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
        com.kwad.sdk.core.d.c.d("AuthHintPresenter", "onPageClose");
        am(false);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        this.ff = azVar;
        this.Tb.ff = azVar;
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        com.kwad.sdk.core.d.c.d("AuthHintPresenter", "onPageVisible");
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yN();
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        com.kwad.sdk.core.d.c.d("AuthHintPresenter", "onPageInvisible");
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yO();
        }
    }

    private void am(boolean z) {
        if (!z) {
            this.Tb.rp();
        }
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.a.i.4
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                i.this.Tb.Ta.ps();
            }
        });
    }
}
