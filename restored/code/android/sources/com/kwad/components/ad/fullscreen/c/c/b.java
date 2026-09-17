package com.kwad.components.ad.fullscreen.c.c;

import android.widget.FrameLayout;
import com.kwad.components.ad.reward.e.j;
import com.kwad.components.ad.reward.e.n;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.tachikoma.TKRenderFailReason;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.reward.presenter.f.a {
    private FrameLayout dz;
    private j kY = new j() { // from class: com.kwad.components.ad.fullscreen.c.c.b.1
        @Override // com.kwad.components.ad.reward.e.j
        public final void a(PlayableSource playableSource, n nVar) {
        }

        @Override // com.kwad.components.ad.reward.e.j
        /* JADX INFO: renamed from: do */
        public final void mo174do() {
            b.this.dz.setVisibility(0);
        }

        @Override // com.kwad.components.ad.reward.e.j
        public final void dp() {
            b.this.dz.setVisibility(4);
        }
    };

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTKReaderScene() {
        return "tk_fullscreen";
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.dz = (FrameLayout) findViewById(R.id.ksad_js_full_card);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ub.sH = true;
        com.kwad.components.ad.reward.a.gq().a(this.kY);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.components.ad.reward.a.gq().b(this.kY);
    }

    @Override // com.kwad.components.ad.reward.presenter.f.d, com.kwad.components.core.webview.tachikoma.j
    public final void a(TKRenderFailReason tKRenderFailReason) {
        super.a(tKRenderFailReason);
        com.kwad.components.ad.reward.monitor.c.a(this.mAdTemplate, tKRenderFailReason);
        this.dz.setVisibility(8);
        this.ub.sH = false;
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final String getTkTemplateId() {
        return com.kwad.sdk.core.response.helper.b.ef(this.ub.mAdTemplate);
    }

    @Override // com.kwad.components.core.webview.tachikoma.j
    public final FrameLayout getTKContainer() {
        return this.dz;
    }

    @Override // com.kwad.components.ad.reward.presenter.f.a, com.kwad.components.core.webview.tachikoma.j
    public final void a(ae.a aVar) {
        float height;
        float width;
        float fBA = com.kwad.sdk.c.a.a.bA(getContext());
        FrameLayout frameLayout = this.dz;
        if (frameLayout != null) {
            height = frameLayout.getHeight();
            width = this.dz.getWidth();
        } else {
            height = 0.0f;
            width = 0.0f;
        }
        if (height == 0.0f || width == 0.0f) {
            super.a(aVar);
        } else {
            aVar.width = (int) ((width / fBA) + 0.5f);
            aVar.height = (int) ((height / fBA) + 0.5f);
        }
    }
}
