package com.kwad.components.ad.draw.presenter.b;

import android.view.ViewGroup;
import com.kwad.components.ad.draw.view.playcard.DrawCardApp;
import com.kwad.components.ad.draw.view.playcard.DrawCardH5;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.draw.b.a {
    private ViewGroup dZ;
    private a.InterfaceC0362a eT = new a.InterfaceC0362a() { // from class: com.kwad.components.ad.draw.presenter.b.b.1
        @Override // com.kwad.components.ad.draw.presenter.b.a.InterfaceC0362a
        public final void aX() {
            b.this.aX();
        }
    };
    private DrawCardApp eW;
    private DrawCardH5 eX;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.dZ = (ViewGroup) findViewById(R.id.ksad_ad_normal_container);
        this.eW = (DrawCardApp) findViewById(R.id.ksad_card_app_container);
        this.eX = (DrawCardH5) findViewById(R.id.ksad_card_h5_container);
    }

    @Override // com.kwad.components.ad.draw.b.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdTemplate adTemplate = this.dL.mAdTemplate;
        this.mAdTemplate = adTemplate;
        this.mAdInfo = e.eM(adTemplate);
        this.dL.dQ.a(this.eT);
        this.eW.setVisibility(8);
        this.eX.setVisibility(8);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.eW.release();
        this.eX.release();
        this.dL.dQ.a((a.InterfaceC0362a) null);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aX() {
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            aZ();
        } else {
            ba();
        }
    }

    private void aZ() {
        this.dZ.setVisibility(8);
        this.eW.a(this.mAdTemplate, new DrawCardApp.a() { // from class: com.kwad.components.ad.draw.presenter.b.b.2
            @Override // com.kwad.components.ad.draw.view.playcard.DrawCardApp.a
            public final void bc() {
                b.this.dZ.setVisibility(0);
            }

            @Override // com.kwad.components.ad.draw.view.playcard.DrawCardApp.a
            public final void bd() {
                b.this.bb();
            }
        });
        this.eW.setVisibility(0);
        this.eW.bV();
    }

    private void ba() {
        this.dZ.setVisibility(8);
        this.eX.a(this.mAdTemplate, new DrawCardH5.a() { // from class: com.kwad.components.ad.draw.presenter.b.b.3
            @Override // com.kwad.components.ad.draw.view.playcard.DrawCardH5.a
            public final void bc() {
                b.this.dZ.setVisibility(0);
            }

            @Override // com.kwad.components.ad.draw.view.playcard.DrawCardH5.a
            public final void bd() {
                b.this.bb();
            }
        });
        this.eX.setVisibility(0);
        this.eX.bV();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bb() {
        com.kwad.sdk.core.adlog.c.a(this.mAdTemplate, 29, this.dL.mRootContainer.getTouchCoords());
        if (this.dL.du != null) {
            this.dL.du.onAdClicked();
        }
    }
}
