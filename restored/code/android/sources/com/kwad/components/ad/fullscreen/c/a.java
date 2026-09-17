package com.kwad.components.ad.fullscreen.c;

import com.kwad.components.core.video.m;
import com.kwad.components.core.webview.tachikoma.c.r;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.reward.presenter.b {
    private m jX = new m() { // from class: com.kwad.components.ad.fullscreen.c.a.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            super.onMediaPlayCompleted();
            a.this.ub.gU();
        }
    };
    private final com.kwad.components.ad.reward.e.m jY = new com.kwad.components.ad.reward.e.m() { // from class: com.kwad.components.ad.fullscreen.c.a.2
        @Override // com.kwad.components.ad.reward.e.m
        public final void a(r rVar) {
            if (rVar == null || rVar.type != 1) {
                return;
            }
            a.this.ub.sr.release();
            a.this.ub.gU();
        }
    };

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ub.sr.a(this.jX);
        com.kwad.components.ad.reward.c.gx().a(this.jY);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sr.b(this.jX);
        com.kwad.components.ad.reward.c.gx().b(this.jY);
    }
}
