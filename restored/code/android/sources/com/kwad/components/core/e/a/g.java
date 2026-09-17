package com.kwad.components.core.e.a;

import android.content.Context;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.widget.KSFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends KSFrameLayout {
    private final d PS;
    private a Qb;
    private final d Qd;
    private final com.kwad.components.core.widget.a.c fs;
    private final AdTemplate mAdTemplate;
    private Presenter mPresenter;
    private boolean rF;

    public g(Context context, AdTemplate adTemplate, d dVar) {
        super(context);
        this.Qd = new d() { // from class: com.kwad.components.core.e.a.g.1
            @Override // com.kwad.components.core.e.a.d
            public final void ps() {
                g.this.eQ();
            }
        };
        this.mAdTemplate = adTemplate;
        this.PS = dVar;
        this.fs = new com.kwad.components.core.widget.a.c(this, 70);
        initMVP();
    }

    private void initMVP() {
        this.Qb = pz();
        Presenter presenterOnCreatePresenter = onCreatePresenter();
        this.mPresenter = presenterOnCreatePresenter;
        presenterOnCreatePresenter.N(this);
        this.mPresenter.q(this.Qb);
    }

    private a pz() {
        a aVar = new a();
        aVar.PQ = this;
        aVar.mAdTemplate = this.mAdTemplate;
        aVar.PR = this.fs;
        aVar.PS = this.Qd;
        return aVar;
    }

    private static Presenter onCreatePresenter() {
        Presenter presenter = new Presenter();
        presenter.a(new f());
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
        this.Qb.release();
        eQ();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void eQ() {
        if (this.rF) {
            return;
        }
        this.rF = true;
        this.PS.ps();
    }
}
