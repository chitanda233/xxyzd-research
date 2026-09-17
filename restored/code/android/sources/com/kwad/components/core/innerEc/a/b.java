package com.kwad.components.core.innerEc.a;

import android.content.Context;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.widget.KSFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends KSFrameLayout {
    private final e Ta;
    private a Tb;
    private final e Tc;
    private final com.kwad.components.core.widget.a.c fs;
    private final AdTemplate mAdTemplate;
    private Presenter mPresenter;
    private boolean rF;

    public b(Context context, AdTemplate adTemplate, e eVar) {
        super(context);
        this.Tc = new e() { // from class: com.kwad.components.core.innerEc.a.b.1
            @Override // com.kwad.components.core.innerEc.a.e
            public final void ps() {
                b.this.eQ();
            }

            @Override // com.kwad.components.core.innerEc.a.e
            public final void rr() {
                if (b.this.Ta != null) {
                    b.this.Ta.rr();
                }
            }

            @Override // com.kwad.components.core.innerEc.a.e
            public final void rs() {
                if (b.this.Ta != null) {
                    b.this.Ta.rs();
                }
            }

            @Override // com.kwad.components.core.innerEc.a.e
            public final void oU() {
                if (b.this.Ta != null) {
                    b.this.Ta.oU();
                }
            }

            @Override // com.kwad.components.core.innerEc.a.e
            public final void rn() {
                if (b.this.Ta != null) {
                    b.this.Ta.rn();
                }
            }

            @Override // com.kwad.components.core.innerEc.a.e
            public final void oV() {
                if (b.this.Ta != null) {
                    b.this.Ta.oV();
                }
            }
        };
        this.mAdTemplate = adTemplate;
        this.Ta = eVar;
        this.fs = new com.kwad.components.core.widget.a.c(this, 70);
        initMVP();
    }

    private void initMVP() {
        this.Tb = rq();
        Presenter presenterOnCreatePresenter = onCreatePresenter();
        this.mPresenter = presenterOnCreatePresenter;
        presenterOnCreatePresenter.N(this);
        this.mPresenter.q(this.Tb);
    }

    private a rq() {
        a aVar = new a();
        aVar.SZ = this;
        aVar.mAdTemplate = this.mAdTemplate;
        aVar.PR = this.fs;
        aVar.Ta = this.Tc;
        return aVar;
    }

    private static Presenter onCreatePresenter() {
        Presenter presenter = new Presenter();
        presenter.a(new i());
        return presenter;
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        super.ae();
        com.kwad.sdk.core.d.c.d("InstalledActivateView", "onViewAttached");
        this.fs.Am();
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void af() {
        super.af();
        com.kwad.sdk.core.d.c.d("InstalledActivateView", "onViewDetached");
        this.fs.release();
        this.mPresenter.destroy();
        this.Tb.release();
        eQ();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void eQ() {
        if (this.rF) {
            return;
        }
        this.rF = true;
        this.Ta.ps();
    }
}
