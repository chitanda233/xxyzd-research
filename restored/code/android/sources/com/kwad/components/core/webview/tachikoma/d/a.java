package com.kwad.components.core.webview.tachikoma.d;

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
import com.kwad.sdk.widget.g;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a extends Presenter implements j {
    protected b auE;
    protected i gg;

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(o oVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public void a(p pVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void a(n nVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public void a(u uVar) {
    }

    protected void a(b bVar) {
    }

    public void a(t tVar, com.kwad.sdk.core.webview.b bVar) {
    }

    public void a(com.kwad.sdk.core.webview.d.b.a aVar) {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public void aC() {
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final void f(AdTemplate adTemplate) {
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        b bVar = (b) SK();
        this.auE = bVar;
        a(bVar);
        if (this.gg == null) {
            this.gg = ji();
        }
        if (this.auE.akP != null) {
            this.gg.a(this.auE.akP);
        }
        this.gg.a(this.auE.mActivity, this.auE.mAdResultData, this);
    }

    protected i ji() {
        return new i(this.auE.Cb, getContext());
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.gg.kT();
        this.gg = null;
    }

    public void a(WebCloseStatus webCloseStatus) {
        if (this.auE.asz != null) {
            this.auE.asz.dismiss();
        }
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public g getTouchCoordsView() {
        return this.auE.auF;
    }
}
