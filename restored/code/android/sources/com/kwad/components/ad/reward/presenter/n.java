package com.kwad.components.ad.reward.presenter;

import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.by;

/* JADX INFO: loaded from: classes3.dex */
public final class n extends b {
    private com.kwad.components.core.video.m jX = new com.kwad.components.core.video.m() { // from class: com.kwad.components.ad.reward.presenter.n.2
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            try {
                super.onMediaPlayCompleted();
                n.this.iR();
            } catch (Throwable th) {
                ServiceProvider.reportSdkCaughtException(th);
            }
        }
    };
    private final com.kwad.components.ad.reward.e.m jY = new com.kwad.components.ad.reward.e.m() { // from class: com.kwad.components.ad.reward.presenter.n.3
        @Override // com.kwad.components.ad.reward.e.m
        public final void a(com.kwad.components.core.webview.tachikoma.c.r rVar) {
            if (rVar == null || rVar.type != 1) {
                return;
            }
            n.this.ub.sr.release();
            n.this.ub.gU();
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

    /* JADX INFO: Access modifiers changed from: private */
    public void iR() {
        if (com.kwad.components.core.t.n.e(this.ub.mAdTemplate, this.ub.sL)) {
            com.kwad.components.core.t.n.i(this.ub.mContext, this.ub.mAdTemplate);
        }
        if (i.z(this.ub) || com.kwad.components.core.t.n.e(this.ub.mAdTemplate, this.ub.sL)) {
            by.runOnUiThreadDelay(new Runnable() { // from class: com.kwad.components.ad.reward.presenter.n.1
                @Override // java.lang.Runnable
                public final void run() {
                    n.this.ub.gU();
                }
            }, 200L);
        } else {
            this.ub.gU();
        }
    }
}
