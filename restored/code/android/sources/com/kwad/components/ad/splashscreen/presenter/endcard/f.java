package com.kwad.components.ad.splashscreen.presenter.endcard;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends com.kwad.components.ad.splashscreen.presenter.e {
    com.kwad.components.ad.splashscreen.f JR = new com.kwad.components.ad.splashscreen.f() { // from class: com.kwad.components.ad.splashscreen.presenter.endcard.f.1
        @Override // com.kwad.components.ad.splashscreen.f
        public final void lW() {
            f.this.a(new e(), true);
            f.this.a(new h(), true);
        }
    };

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Hu.a(this.JR);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.Hu.b(this.JR);
    }
}
