package com.kwad.components.ad.reward.presenter;

import com.kwad.components.core.page.DownloadLandPageActivity;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.webview.KsAdWebView;

/* JADX INFO: loaded from: classes3.dex */
public final class p extends b {
    private com.kwad.components.core.playable.a ss;
    private PlayableSource wU;
    private final com.kwad.components.ad.reward.e.j wV = new com.kwad.components.ad.reward.e.k() { // from class: com.kwad.components.ad.reward.presenter.p.1
        @Override // com.kwad.components.ad.reward.e.k, com.kwad.components.ad.reward.e.j
        public final void a(PlayableSource playableSource, com.kwad.components.ad.reward.e.n nVar) {
            p.this.wU = playableSource;
            if (p.this.ss != null && p.this.ss.vL()) {
                p.this.ss.e(playableSource);
                if (p.this.ub != null) {
                    p.this.ub.d(playableSource);
                    p.this.ub.C(true);
                    if (p.this.ub.sr.lq()) {
                        p.this.ub.sr.lr().pause();
                    }
                }
                com.kwad.components.ad.reward.a.gq().b(playableSource);
                return;
            }
            if (p.this.ss != null) {
                p.this.ss.iU();
            }
            if (nVar != null) {
                nVar.in();
                com.kwad.sdk.core.d.c.d("RewardPlayablePresenter", "onEnterPlayable outer handled");
            } else if (com.kwad.sdk.core.response.helper.a.aL(com.kwad.sdk.core.response.helper.e.eM(p.this.ub.mAdTemplate))) {
                DownloadLandPageActivity.launch(p.this.getActivity(), p.this.ub.mAdTemplate, true);
            }
        }

        @Override // com.kwad.components.ad.reward.e.k, com.kwad.components.ad.reward.e.j
        /* JADX INFO: renamed from: do */
        public final void mo174do() {
            p.this.ss.iU();
            if (p.this.ub != null) {
                p.this.ub.d((PlayableSource) null);
                if (p.this.ub.sr.lq()) {
                    p.this.ub.sr.lr().resume();
                }
            }
        }
    };

    public final void e(PlayableSource playableSource) {
        com.kwad.components.core.playable.a aVar = this.ss;
        if (aVar != null) {
            if (playableSource != null) {
                aVar.e(playableSource);
            } else {
                aVar.e(this.wU);
            }
        }
    }

    public final void iU() {
        com.kwad.components.core.playable.a aVar = this.ss;
        if (aVar != null) {
            aVar.iU();
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        ((KsAdWebView) findViewById(R.id.ksad_playable_webview)).setVisibility(4);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.components.core.playable.a aVar = this.ub.ss;
        this.ss = aVar;
        if (aVar == null) {
            return;
        }
        aVar.a(this.ub.mAdTemplate, this.ub.mRootContainer, this.ub.mApkDownloadHelper);
        com.kwad.components.ad.reward.monitor.d.a(this.ub.sG, "playable");
        com.kwad.components.ad.reward.monitor.d.a(this.ub.mAdTemplate, this.ub.sG, "playable", com.kwad.sdk.core.response.helper.a.bX(com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate)));
        this.ss.vK();
        this.ss.a(new as.b() { // from class: com.kwad.components.ad.reward.presenter.p.2
            @Override // com.kwad.components.core.webview.jshandler.as.b
            public final void a(as.a aVar2) {
                if (aVar2.isSuccess()) {
                    return;
                }
                AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(p.this.ub.mAdTemplate);
                long loadTime = p.this.ub.ss.getLoadTime();
                if (loadTime == -1) {
                    return;
                }
                com.kwad.components.ad.reward.monitor.d.a(p.this.ub.mAdTemplate, p.this.ub.sG, "playable", com.kwad.sdk.core.response.helper.a.bX(adInfoEM), System.currentTimeMillis() - loadTime, 3);
            }
        });
        this.ss.a(new KsAdWebView.e() { // from class: com.kwad.components.ad.reward.presenter.p.3
            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageStart() {
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onReceivedHttpError(int i, String str, String str2) {
                com.kwad.components.ad.reward.monitor.d.a(p.this.ub.mAdTemplate, p.this.ub.sG, "playable", com.kwad.sdk.core.response.helper.a.bX(com.kwad.sdk.core.response.helper.e.eM(p.this.ub.mAdTemplate)), System.currentTimeMillis() - p.this.ub.ss.getLoadTime(), 2);
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageFinished() {
                AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(p.this.ub.mAdTemplate);
                long loadTime = p.this.ub.ss.getLoadTime();
                if (loadTime == -1) {
                    return;
                }
                com.kwad.components.ad.reward.monitor.d.a(p.this.ub.sG, "playable", com.kwad.sdk.core.response.helper.a.bX(adInfoEM), System.currentTimeMillis() - loadTime);
            }
        });
        com.kwad.components.ad.reward.a.gq().a(this.wV);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.components.core.playable.a aVar = this.ss;
        if (aVar == null) {
            return;
        }
        aVar.vJ();
        this.ss.iU();
        com.kwad.components.ad.reward.a.gq().b(this.wV);
    }
}
