package com.kwad.components.core.s.b;

import android.widget.FrameLayout;
import com.kwad.components.core.proxy.f;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.components.core.webview.tachikoma.b.o;
import com.kwad.components.core.webview.tachikoma.b.p;
import com.kwad.components.core.webview.tachikoma.c.n;
import com.kwad.components.core.webview.tachikoma.c.u;
import com.kwad.components.core.webview.tachikoma.i;
import com.kwad.components.core.webview.tachikoma.j;
import com.kwad.sdk.R;
import com.kwad.sdk.commercial.model.WebCloseStatus;
import com.kwad.sdk.components.t;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.c.g;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.utils.bt;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends Presenter implements j {
    private FrameLayout akZ;
    private az ala;
    protected boolean alb;
    protected com.kwad.components.core.s.a.b alc;
    private com.kwad.components.core.n.a.a ald = new com.kwad.components.core.n.a.a() { // from class: com.kwad.components.core.s.b.a.1
        @Override // com.kwad.components.core.n.a.a
        public final void hi() {
        }

        @Override // com.kwad.components.core.n.a.a
        public final void c(f fVar) {
            a.this.wK();
        }

        @Override // com.kwad.components.core.n.a.a
        public final void d(f fVar) {
            a.this.wL();
        }

        @Override // com.kwad.components.core.n.a.a
        public final void hj() {
            a.this.wM();
        }
    };
    private i gg;

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(com.kwad.components.core.webview.jshandler.a.C0464a c0464a) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
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
    public final String getRegisterViewKey() {
        return null;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_activity";
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.alc = (com.kwad.components.core.s.a.b) SK();
        this.akZ = (FrameLayout) findViewById(R.id.ksad_js_container);
        i iVar = new i(getContext(), 1000, 0);
        this.gg = iVar;
        iVar.a(this.alc.akP);
        if (this.alc.akS != null) {
            this.alc.akS.a(this.gg);
            this.gg.a(new g() { // from class: com.kwad.components.core.s.b.a.2
                @Override // com.kwad.sdk.core.webview.c.g
                public final void callTKBridge(String str) {
                    if (a.this.alc.akS != null) {
                        a.this.alc.akS.callTKBridge(str);
                    }
                }
            });
            this.gg.a("hasTKBridge", Boolean.TRUE);
        }
        this.gg.a(getActivity(), this.alc.mAdResultData, this);
        this.alc.abs.add(this.ald);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        wM();
        this.gg.kT();
        this.alc.abs.remove(this.ald);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return this.alc.akP.templateId;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final com.kwad.sdk.widget.g getTouchCoordsView() {
        return this.alc.mRootContainer;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final FrameLayout getTKContainer() {
        return this.akZ;
    }

    private void wJ() {
        az azVar = this.ala;
        if (azVar == null) {
            return;
        }
        if (!this.alb) {
            azVar.yJ();
            this.ala.yK();
            this.alb = true;
            return;
        }
        azVar.yN();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void wK() {
        wJ();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void wL() {
        az azVar = this.ala;
        if (azVar == null || !this.alb) {
            return;
        }
        azVar.yO();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void wM() {
        az azVar = this.ala;
        if (azVar == null || !this.alb) {
            return;
        }
        azVar.yL();
        this.ala.yM();
        if (this.alc.akS != null) {
            this.alc.akS.callbackDismiss();
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void aB() {
        wJ();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        aVar.width = (int) ((bt.getScreenWidth(getContext()) / fBA) + 0.5f);
        aVar.height = (int) ((bt.getScreenHeight(getContext()) / fBA) + 0.5f);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(WebCloseStatus webCloseStatus) {
        getActivity().finish();
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(az azVar) {
        this.ala = azVar;
    }
}
