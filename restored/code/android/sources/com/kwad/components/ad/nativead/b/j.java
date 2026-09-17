package com.kwad.components.ad.nativead.b;

import android.view.View;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class j extends com.kwad.components.ad.nativead.a.a {
    private View qq;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.qq = findViewById(R.id.ksad_video_error_container);
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.qq.setVisibility(8);
        this.mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.nativead.b.j.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayError(int i, int i2) {
                j.this.fM();
            }
        };
        this.pO.pP.b(this.mVideoPlayStateListener);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fM() {
        if (this.qq.getVisibility() == 0) {
            return;
        }
        this.qq.setVisibility(0);
    }
}
