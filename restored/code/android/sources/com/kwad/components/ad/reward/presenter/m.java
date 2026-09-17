package com.kwad.components.ad.reward.presenter;

import com.kwad.sdk.core.response.model.AdInfo;

/* JADX INFO: loaded from: classes3.dex */
public final class m extends b {
    private long kq;
    private com.kwad.components.ad.reward.e.b sq;
    private com.kwad.components.core.video.m wG;
    private com.kwad.components.core.video.m wH = new com.kwad.components.core.video.m() { // from class: com.kwad.components.ad.reward.presenter.m.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            super.onMediaPlayStart();
            m.this.sq.onVideoPlayStart();
            m.this.ub.tg = false;
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            super.onMediaPlayCompleted();
            if (m.this.ub.sG && m.this.ub.sL) {
                m.this.sq.onVideoSkipToEnd(m.this.kq);
            } else {
                m.this.ub.tg = true;
                m.this.sq.onVideoPlayEnd();
            }
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(m.this.ub.mAdTemplate);
            if (com.kwad.sdk.core.response.helper.a.aU(adInfoEM) && com.kwad.sdk.core.response.helper.a.aT(adInfoEM) == 1) {
                return;
            }
            f.u(m.this.ub);
            if (m.this.ub.tg) {
                com.kwad.components.ad.reward.l.j(m.this.ub);
            }
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            m.this.ub.tf = j2;
            if (m.this.ub.sL) {
                return;
            }
            m.this.kq = j2;
        }
    };
    private final com.kwad.components.core.video.m jX = new com.kwad.components.core.video.m() { // from class: com.kwad.components.ad.reward.presenter.m.2
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            m.this.sq.onVideoPlayStart();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            m.this.ub.tf = j2;
            m.this.ub.tg = j - j2 < 800;
            if (m.this.ub.sL) {
                return;
            }
            m.this.kq = j2;
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayError(int i, int i2) {
            m.this.sq.onVideoPlayError(i, i2);
            m.this.iK();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            if (m.this.ub.sL) {
                m.this.sq.onVideoSkipToEnd(m.this.kq);
            } else {
                m.this.sq.onVideoPlayEnd();
            }
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(m.this.ub.mAdTemplate);
            if (com.kwad.sdk.core.response.helper.a.aU(adInfoEM) && com.kwad.sdk.core.response.helper.a.aT(adInfoEM) == 1) {
                return;
            }
            f.u(m.this.ub);
            if (m.this.ub.tg) {
                com.kwad.components.ad.reward.l.j(m.this.ub);
            }
        }
    };

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.ub.tf = 0L;
        this.ub.tg = false;
        this.sq = this.ub.sq;
        if (this.ub.sr.lq()) {
            this.wG = this.wH;
        } else {
            this.wG = this.jX;
        }
        this.ub.sr.a(this.wG);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.sr.b(this.wG);
    }
}
