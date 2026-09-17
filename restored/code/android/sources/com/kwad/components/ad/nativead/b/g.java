package com.kwad.components.ad.nativead.b;

import android.widget.ImageView;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;

/* JADX INFO: loaded from: classes3.dex */
public final class g extends com.kwad.components.ad.nativead.a.a {
    private ImageView qk;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        ImageView imageView = (ImageView) findViewById(R.id.ksad_video_cover_image);
        this.qk = imageView;
        a(imageView, "NativePlayEndCoverPresenter R.id.ksad_video_cover_image is null");
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.nativead.b.g.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                g.this.fJ();
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                super.onMediaPlayStart();
                g.this.fK();
            }
        };
        this.pO.pP.b(this.mVideoPlayStateListener);
        this.qk.setVisibility(8);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fJ() {
        KSImageLoader.loadImage(this.qk, com.kwad.sdk.core.response.helper.a.aa(com.kwad.sdk.core.response.helper.e.eM(this.pO.mAdTemplate)), this.pO.mAdTemplate);
        this.qk.setVisibility(0);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fK() {
        if (this.qk.getVisibility() == 0) {
            this.qk.setVisibility(8);
        }
    }
}
