package com.kwad.components.ad.reward.presenter.d.a;

import android.widget.FrameLayout;
import com.kwad.components.ad.reward.e.l;
import com.kwad.components.ad.reward.g;
import com.kwad.components.ad.reward.j;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.ad.reward.presenter.b implements com.kwad.components.ad.l.b.a {
    private com.kwad.components.ad.l.b dR;
    private FrameLayout fp;
    private DetailVideoView mDetailVideoView;
    private int xs = Integer.MIN_VALUE;
    private final l mRewardVerifyListener = new l() { // from class: com.kwad.components.ad.reward.presenter.d.a.c.1
        @Override // com.kwad.components.ad.reward.e.l
        public final void onRewardVerify() {
            if (c.this.dR == null || !g.P(c.this.ub.mAdTemplate)) {
                return;
            }
            c.this.dR.aj(true);
        }
    };
    private com.kwad.sdk.core.webview.d.a.a fg = new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.reward.presenter.d.a.c.2
        @Override // com.kwad.sdk.core.webview.d.a.a
        public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
            c.this.ub.sq.cY();
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.fp = (FrameLayout) findViewById(R.id.ksad_web_card_container);
        this.mDetailVideoView = (DetailVideoView) findViewById(R.id.ksad_video_player);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdTemplate adTemplate = this.ub.mAdTemplate;
        j jVar = this.ub.su;
        this.dR = jVar;
        if (jVar == null) {
            return;
        }
        com.kwad.components.ad.reward.b.gu().a(this.mRewardVerifyListener);
        this.dR.a(this.fg);
        this.dR.a(this.fp, this.ub.mRootContainer, adTemplate, this.ub.mApkDownloadHelper, this.ub.mScreenOrientation);
        this.dR.a((com.kwad.components.ad.l.b.InterfaceC0383b) null);
        com.kwad.components.ad.l.b bVar = this.dR;
        if (bVar != null) {
            bVar.a(this);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        int i;
        super.onUnbind();
        com.kwad.components.ad.l.b bVar = this.dR;
        if (bVar != null) {
            bVar.op();
            this.dR.ob();
        }
        com.kwad.components.ad.reward.b.gu().b(this.mRewardVerifyListener);
        DetailVideoView detailVideoView = this.mDetailVideoView;
        if (detailVideoView == null || (i = this.xs) == Integer.MIN_VALUE) {
            return;
        }
        com.kwad.sdk.c.a.a.q(detailVideoView, i);
    }

    @Override // com.kwad.components.ad.l.b.a
    public final void jV() {
        iK();
    }
}
