package com.kwad.components.ad.draw.presenter;

import android.text.TextUtils;
import android.view.ViewGroup;
import android.widget.ImageView;
import com.kwad.components.core.video.l;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.e;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.draw.b.a {
    private ImageView dV;
    private com.kwad.sdk.core.response.model.b dW;
    private l mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.draw.presenter.b.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlaying() {
            super.onMediaPlaying();
            if (b.this.dV.getVisibility() == 0) {
                b.this.dV.setVisibility(8);
            }
        }
    };
    private Runnable dX = new Runnable() { // from class: com.kwad.components.ad.draw.presenter.b.2
        @Override // java.lang.Runnable
        public final void run() {
            int width = b.this.getRootView().getWidth();
            ViewGroup.LayoutParams layoutParams = b.this.dV.getLayoutParams();
            int width2 = b.this.dW.getWidth();
            int height = b.this.dW.getHeight();
            if (width2 == 0 || height == 0 || height > width2) {
                layoutParams.width = -1;
                layoutParams.height = -1;
                b.this.dV.setLayoutParams(layoutParams);
            } else {
                layoutParams.width = width;
                layoutParams.height = (int) ((height / (width2 * 1.0f)) * width);
                b.this.dV.setLayoutParams(layoutParams);
                b.this.dV.setScaleType(ImageView.ScaleType.FIT_CENTER);
            }
            b.this.dV.setImageDrawable(null);
            KSImageLoader.loadImage(b.this.dV, b.this.dW.getUrl(), b.this.dL.mAdTemplate);
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.dV = (ImageView) findViewById(R.id.ksad_video_first_frame);
    }

    @Override // com.kwad.components.ad.draw.b.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.sdk.core.response.model.b bVarBA = com.kwad.sdk.core.response.helper.a.bA(e.eM(this.dL.mAdTemplate));
        this.dW = bVarBA;
        if (TextUtils.isEmpty(bVarBA.getUrl())) {
            return;
        }
        getRootView().post(this.dX);
        this.dV.setVisibility(0);
        if (this.dL.dN != null) {
            this.dL.dN.b(this.mVideoPlayStateListener);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        getRootView().removeCallbacks(this.dX);
        if (this.dL.dN != null) {
            this.dL.dN.a(this.mVideoPlayStateListener);
        }
    }
}
