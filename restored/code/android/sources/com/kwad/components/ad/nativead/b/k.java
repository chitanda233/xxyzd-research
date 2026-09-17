package com.kwad.components.ad.nativead.b;

import android.widget.ProgressBar;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class k extends com.kwad.components.ad.nativead.a.a {
    private ProgressBar qs;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.qs = (ProgressBar) findViewById(R.id.ksad_video_progress);
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.qs.setProgress(0);
        this.qs.setVisibility(8);
        this.mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.nativead.b.k.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayProgress(long j, long j2) {
                k.this.U(j != 0 ? (int) ((j2 * 100.0f) / j) : 0);
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                k.this.fN();
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i, int i2) {
                k.this.fN();
            }
        };
        this.pO.pP.b(this.mVideoPlayStateListener);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void U(int i) {
        this.qs.setProgress(i);
        if (this.qs.getVisibility() == 0) {
            return;
        }
        this.qs.setVisibility(0);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fN() {
        if (this.qs.getVisibility() != 0) {
            return;
        }
        this.qs.setVisibility(8);
    }
}
