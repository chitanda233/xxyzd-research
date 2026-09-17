package com.kwad.components.ad.interstitial.f;

import com.kwad.sdk.mvp.Presenter;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class b extends Presenter {
    public c mF;

    @Override // com.kwad.sdk.mvp.Presenter
    public void av() {
        super.av();
        this.mF = (c) SK();
    }

    public void dW() {
        List<Presenter> listSJ = SJ();
        if (listSJ == null) {
            return;
        }
        for (Presenter presenter : listSJ) {
            if (presenter instanceof b) {
                ((b) presenter).dW();
            }
        }
    }

    public void dX() {
        List<Presenter> listSJ = SJ();
        if (listSJ == null) {
            return;
        }
        for (Presenter presenter : listSJ) {
            if (presenter instanceof b) {
                ((b) presenter).dX();
            }
        }
    }
}
