package com.kwad.components.ad.draw.presenter.c;

import android.widget.FrameLayout;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.draw.b.a {
    private com.kwad.components.ad.l.b dR;
    private com.kwad.sdk.core.webview.d.a.a fg = new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.draw.presenter.c.b.1
        @Override // com.kwad.sdk.core.webview.d.a.a
        public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
            if (b.this.dL.du != null) {
                b.this.dL.du.onAdClicked();
            }
        }
    };
    private FrameLayout fp;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.fp = (FrameLayout) findViewById(R.id.ksad_play_end_web_card_container);
    }

    @Override // com.kwad.components.ad.draw.b.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.components.ad.l.b bVar = this.dL.dR;
        this.dR = bVar;
        if (bVar == null) {
            return;
        }
        bVar.a(this.fg);
        this.dR.a(this.fp, this.dL.mRootContainer, this.dL.mAdTemplate, this.dL.mApkDownloadHelper);
        this.dR.a((com.kwad.components.ad.l.b.InterfaceC0383b) null);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.components.ad.l.b bVar = this.dR;
        if (bVar != null) {
            bVar.ob();
        }
    }
}
