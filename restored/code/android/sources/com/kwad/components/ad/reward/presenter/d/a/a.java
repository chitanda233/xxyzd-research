package com.kwad.components.ad.reward.presenter.d.a;

import android.widget.FrameLayout;
import com.kwad.components.ad.reward.e.g;
import com.kwad.components.ad.reward.presenter.f;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.reward.presenter.b implements com.kwad.components.ad.l.a.b {
    private FrameLayout fp;
    private m wG;
    private volatile long zN = 0;
    private volatile boolean zO = false;
    private m wH = new m() { // from class: com.kwad.components.ad.reward.presenter.d.a.a.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            a.this.zN = j2;
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            super.onMediaPlayCompleted();
            a.this.zO = true;
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            super.onMediaPlayStart();
            a.this.zO = false;
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.h
        public final void onLivePlayResume() {
            super.onLivePlayResume();
            a.this.zO = false;
        }
    };
    private m jX = new m() { // from class: com.kwad.components.ad.reward.presenter.d.a.a.2
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            a.this.zN = j2;
            a.this.zO = j - j2 < 800;
        }
    };
    private g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.d.a.a.4
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            if (a.this.ub.sZ || a.this.ub.sv == null) {
                return;
            }
            a.this.ub.sv.aY();
        }
    };
    private com.kwad.sdk.core.webview.d.a.a fg = new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.reward.presenter.d.a.a.5
        @Override // com.kwad.sdk.core.webview.d.a.a
        public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
            a.this.ub.sq.cY();
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.fp = (FrameLayout) findViewById(R.id.ksad_landing_page_container);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.zN = 0L;
        this.zO = false;
        AdTemplate adTemplate = this.ub.mAdTemplate;
        com.kwad.components.ad.l.a aVar = this.ub.sv;
        this.wG = this.ub.sr.lq() ? this.wH : this.jX;
        if (aVar != null) {
            this.ub.sT = true;
            aVar.a(this);
            aVar.a(this.fg);
            aVar.a(this.fp, this.ub.mRootContainer, adTemplate);
            aVar.a(new com.kwad.components.ad.l.a.InterfaceC0381a() { // from class: com.kwad.components.ad.reward.presenter.d.a.a.3
                @Override // com.kwad.components.ad.l.a.InterfaceC0381a
                public final void T(boolean z) {
                    a.this.ub.sT = z;
                }
            });
            aVar.setActivity(this.ub.getActivity());
            aVar.bf();
            this.ub.b(this.mPlayEndPageListener);
            this.ub.sr.a(this.wG);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.c(this.mPlayEndPageListener);
        this.ub.sr.b(this.wG);
    }

    @Override // com.kwad.components.ad.l.a.b
    public final void jQ() {
        f.t(this.ub);
    }
}
