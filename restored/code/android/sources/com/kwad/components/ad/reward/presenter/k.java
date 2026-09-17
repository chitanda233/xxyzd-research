package com.kwad.components.ad.reward.presenter;

import com.kwad.components.offline.api.core.adlive.listener.AdLiveCallerContextListener;

/* JADX INFO: loaded from: classes3.dex */
public final class k extends b {
    private final AdLiveCallerContextListener wy = new AdLiveCallerContextListener() { // from class: com.kwad.components.ad.reward.presenter.k.1
        @Override // com.kwad.components.offline.api.core.adlive.listener.AdLiveCallerContextListener
        public final boolean isCloseDialogShowing() {
            return com.kwad.components.ad.reward.g.b(k.this.ub);
        }
    };
    private final com.kwad.components.core.n.a.a wz = new com.kwad.components.core.n.a.b() { // from class: com.kwad.components.ad.reward.presenter.k.2
        @Override // com.kwad.components.core.n.a.b, com.kwad.components.core.n.a.a
        public final void c(com.kwad.components.core.proxy.f fVar) {
            super.c(fVar);
            if (k.this.ub.sr.lq()) {
                k.this.ub.sr.lr().onResume();
                if (com.kwad.components.core.t.a.aN(k.this.ub.mContext).wP()) {
                    k.this.ub.e(false, false);
                }
            }
        }

        @Override // com.kwad.components.core.n.a.b, com.kwad.components.core.n.a.a
        public final void d(com.kwad.components.core.proxy.f fVar) {
            super.d(fVar);
            if (k.this.ub.sr.lq()) {
                k.this.ub.sr.lr().onPause();
            }
        }
    };

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.ub.sr.lq()) {
            this.ub.sr.lr().registerAdLiveCallerContextListener(this.wy);
            this.ub.abs.add(this.wz);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
        if (this.ub.sr.lq()) {
            this.ub.sr.lr().unRegisterAdLiveCallerContextListener(this.wy);
            this.ub.abs.remove(this.wz);
        }
    }
}
