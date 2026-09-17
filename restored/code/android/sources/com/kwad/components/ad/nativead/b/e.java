package com.kwad.components.ad.nativead.b;

import com.kwad.components.core.video.m;
import com.kwad.sdk.api.KsNativeAd;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends com.kwad.components.ad.nativead.a.a {
    private boolean eP = false;
    private KsNativeAd.VideoPlayListener pn;

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.pn = this.pO.pn;
        this.mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.nativead.b.e.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                if (e.this.pn != null) {
                    e.this.pn.onVideoPlayStart();
                }
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i, int i2) {
                if (e.this.pn != null) {
                    e.this.pn.onVideoPlayError(i, i2);
                }
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                if (e.this.pn != null) {
                    e.this.pn.onVideoPlayComplete();
                }
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPrepared() {
                super.onMediaPrepared();
                if (e.this.pn != null) {
                    try {
                        e.this.pn.onVideoPlayReady();
                    } catch (Throwable th) {
                        com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                    }
                }
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlaying() {
                super.onMediaPlaying();
                if (e.this.eP) {
                    e.this.eP = false;
                    if (e.this.pn != null) {
                        try {
                            e.this.pn.onVideoPlayResume();
                        } catch (Throwable th) {
                            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                        }
                    }
                }
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayPaused() {
                super.onMediaPlayPaused();
                if (e.this.pn != null) {
                    try {
                        e.this.pn.onVideoPlayPause();
                    } catch (Throwable th) {
                        com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                    }
                }
                e.this.eP = true;
            }
        };
        this.pO.pP.b(this.mVideoPlayStateListener);
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
    }
}
