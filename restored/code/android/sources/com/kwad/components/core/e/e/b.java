package com.kwad.components.core.e.e;

import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.mvp.Presenter;

/* JADX INFO: loaded from: classes3.dex */
public class b extends Presenter {
    protected c RE;
    protected AdInfo mAdInfo;

    @Override // com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        c cVar = (c) SK();
        this.RE = cVar;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(cVar.RD.getAdTemplate());
    }
}
