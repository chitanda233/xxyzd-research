package com.kwad.components.ad.nativead.b;

import android.view.View;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.aq;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.ad.nativead.a.a {
    private View qc;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.qc = findViewById(R.id.ksad_video_network_unavailable);
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (aq.isNetworkConnected(this.qc.getContext())) {
            this.qc.setVisibility(8);
            return;
        }
        this.qc.setVisibility(0);
        this.mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.nativead.b.d.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                super.onMediaPlayStart();
                d.this.fF();
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlaying() {
                super.onMediaPlaying();
                d.this.fF();
            }
        };
        this.pO.pP.b(this.mVideoPlayStateListener);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fF() {
        if (this.qc.getVisibility() != 0) {
            return;
        }
        this.qc.setVisibility(8);
    }
}
