package com.kwad.components.ad.draw.presenter;

import android.widget.TextView;
import com.kwad.components.core.video.l;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.aq;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.ad.draw.b.a {
    private TextView ek;
    private l mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.draw.presenter.d.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            d.this.ek.setVisibility(8);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlaying() {
            d.this.ek.setVisibility(8);
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayError(int i, int i2) {
            d.this.ek.setVisibility(0);
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.ek = (TextView) findViewById(R.id.ksad_video_fail_tip);
    }

    @Override // com.kwad.components.ad.draw.b.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (!aq.isNetworkConnected(getContext())) {
            this.ek.setVisibility(0);
        } else {
            this.ek.setVisibility(8);
        }
        this.dL.dN.b(this.mVideoPlayStateListener);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.dL.dN.a(this.mVideoPlayStateListener);
    }
}
