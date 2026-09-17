package com.kwad.components.core.page;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import com.kwad.sdk.R;
import com.kwad.sdk.mvp.Presenter;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends d {
    private com.kwad.components.core.page.a.a adD;

    public static c a(Context context, AdWebViewActivityProxy.a aVar) {
        c cVar = new c(context);
        cVar.c(context, aVar);
        return cVar;
    }

    @Override // com.kwad.components.core.page.d, com.kwad.components.core.n.d
    public final void a(ViewGroup viewGroup) {
        super.a(viewGroup);
        View viewFindViewById = findViewById(R.id.ksad_web_tip_bar);
        if (viewFindViewById != null) {
            viewFindViewById.setVisibility(8);
        }
    }

    public final void setH5AuthListener(com.kwad.components.core.page.a.a aVar) {
        if (this.abu == 0) {
            this.adD = aVar;
        } else {
            ((com.kwad.components.core.page.d.a.b) this.abu).setH5AuthListener(aVar);
        }
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // com.kwad.components.core.page.d, com.kwad.components.core.n.d
    /* JADX INFO: renamed from: un, reason: merged with bridge method [inline-methods] */
    public final com.kwad.components.core.page.d.a.b an() {
        com.kwad.components.core.page.d.a.b bVarAn = super.an();
        com.kwad.components.core.page.a.a aVar = this.adD;
        if (aVar != null) {
            bVarAn.setH5AuthListener(aVar);
            this.adD = null;
        }
        return bVarAn;
    }

    private c(Context context) {
        super(context);
        this.adD = null;
    }

    @Override // com.kwad.components.core.page.d, com.kwad.components.core.n.d
    public final Presenter onCreatePresenter() {
        Presenter presenter = new Presenter();
        presenter.a(new com.kwad.components.core.page.d.a());
        return presenter;
    }
}
