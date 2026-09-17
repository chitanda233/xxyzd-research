package com.kwad.components.ad.c.c;

import com.kwad.sdk.mvp.Presenter;

/* JADX INFO: loaded from: classes3.dex */
public class a extends Presenter {
    public com.kwad.components.ad.c.b cO;

    @Override // com.kwad.sdk.mvp.Presenter
    public void onCreate() {
        super.onCreate();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        Object objSK = SK();
        if (objSK instanceof com.kwad.components.ad.c.b) {
            this.cO = (com.kwad.components.ad.c.b) objSK;
        }
    }
}
