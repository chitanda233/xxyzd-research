package com.kwad.components.ad.reward.presenter;

import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.mvp.Presenter;

/* JADX INFO: loaded from: classes3.dex */
public class b extends Presenter {
    public AdTemplate mAdTemplate;
    public com.kwad.components.ad.reward.g ub;

    @Override // com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        com.kwad.components.ad.reward.g gVar = (com.kwad.components.ad.reward.g) SK();
        this.ub = gVar;
        this.mAdTemplate = gVar.mAdTemplate;
    }

    protected final void iK() {
        this.ub.iK();
    }

    protected final boolean iL() {
        return com.kwad.sdk.core.response.helper.a.bj(com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate));
    }
}
