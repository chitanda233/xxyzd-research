package com.kwad.components.ad.draw.presenter.c;

import com.kwad.components.ad.draw.view.playend.DrawVideoTailFrame;
import com.kwad.components.core.video.l;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.draw.b.a {
    private com.kwad.components.ad.l.b dR;
    private DrawVideoTailFrame fn;
    private l mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.draw.presenter.c.a.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            super.onMediaPlayCompleted();
            if (a.this.dR == null || !a.this.dR.aY()) {
                a.this.bp();
            } else {
                a.this.fn.setVisibility(8);
            }
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.fn = (DrawVideoTailFrame) findViewById(R.id.ksad_video_tail_frame);
    }

    @Override // com.kwad.components.ad.draw.b.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.dR = this.dL.dR;
        this.fn.j(this.dL.mAdTemplate);
        this.fn.setAdBaseFrameLayout(this.dL.mRootContainer);
        this.fn.setApkDownloadHelper(this.dL.mApkDownloadHelper);
        this.fn.setVisibility(8);
        this.fn.setAdInteractionListener(this.dL.du);
        this.dL.dN.b(this.mVideoPlayStateListener);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.dL.dN.a(this.mVideoPlayStateListener);
        this.fn.release();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bp() {
        this.fn.bY();
        this.fn.setVisibility(0);
    }
}
