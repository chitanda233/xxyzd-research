package com.kwad.components.ad.nativead.b;

import android.text.TextUtils;
import android.widget.ImageView;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.nativead.a.a {
    private ImageView dV;
    private com.kwad.sdk.core.response.model.b dW;
    private Runnable dX = new Runnable() { // from class: com.kwad.components.ad.nativead.b.b.2
        @Override // java.lang.Runnable
        public final void run() {
            com.kwad.sdk.c.a.a.d(b.this.dV, b.this.dW.getWidth(), b.this.dW.getHeight());
            b.this.dV.setImageDrawable(null);
            KSImageLoader.loadImage(b.this.dV, b.this.dW.getUrl(), b.this.pO.mAdTemplate);
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.dV = (ImageView) findViewById(R.id.ksad_video_first_frame);
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.sdk.core.response.model.b bVarBA = com.kwad.sdk.core.response.helper.a.bA(com.kwad.sdk.core.response.helper.e.eM(this.pO.mAdTemplate));
        this.dW = bVarBA;
        if (TextUtils.isEmpty(bVarBA.getUrl())) {
            return;
        }
        getRootView().post(this.dX);
        this.dV.setVisibility(0);
        this.mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.nativead.b.b.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlaying() {
                super.onMediaPlaying();
                if (b.this.dV.getVisibility() == 0) {
                    b.this.dV.setVisibility(8);
                }
            }
        };
        this.pO.pP.b(this.mVideoPlayStateListener);
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        getRootView().removeCallbacks(this.dX);
    }
}
