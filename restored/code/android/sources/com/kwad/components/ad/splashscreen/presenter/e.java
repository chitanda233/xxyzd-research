package com.kwad.components.ad.splashscreen.presenter;

import com.kwad.sdk.mvp.Presenter;

/* JADX INFO: loaded from: classes3.dex */
public class e extends Presenter {
    public com.kwad.components.ad.splashscreen.h Hu;

    @Override // com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        Object objSK = SK();
        if (objSK instanceof com.kwad.components.ad.splashscreen.h) {
            this.Hu = (com.kwad.components.ad.splashscreen.h) objSK;
        }
    }
}
