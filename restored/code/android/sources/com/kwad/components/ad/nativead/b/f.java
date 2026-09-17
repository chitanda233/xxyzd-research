package com.kwad.components.ad.nativead.b;

import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends com.kwad.components.ad.nativead.a.a implements View.OnClickListener, View.OnTouchListener {
    private TextView eq;
    private ImageView gI;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private ViewGroup qf;
    private TextView qg;
    private MotionEvent qh;
    private KsAppDownloadListener qi = new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.ad.nativead.b.f.2
        @Override // com.kwad.sdk.api.KsAppDownloadListener
        public final void onProgressUpdate(int i) {
        }

        @Override // com.kwad.sdk.api.KsAppDownloadListener
        public final void onIdle() {
            f.this.qg.setText(com.kwad.sdk.core.response.helper.a.aK(f.this.mAdInfo));
        }

        @Override // com.kwad.sdk.api.KsAppDownloadListener
        public final void onDownloadFinished() {
            f.this.qg.setText(com.kwad.sdk.core.response.helper.a.cF(f.this.mAdTemplate));
        }

        @Override // com.kwad.sdk.api.KsAppDownloadListener
        public final void onDownloadFailed() {
            f.this.qg.setText(com.kwad.sdk.core.response.helper.a.aK(f.this.mAdInfo));
        }

        @Override // com.kwad.sdk.api.KsAppDownloadListener
        public final void onInstalled() {
            f.this.qg.setText(com.kwad.sdk.core.response.helper.a.af(f.this.mAdInfo));
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.qf = (ViewGroup) findViewById(R.id.ksad_video_complete_app_container);
        this.gI = (ImageView) findViewById(R.id.ksad_app_icon);
        this.eq = (TextView) findViewById(R.id.ksad_app_name);
        this.qg = (TextView) findViewById(R.id.ksad_app_download);
        a(this.qf, "NativePlayEndAppPresenter: R.id.ksad_video_complete_app_container is null");
        a(this.gI, "NativePlayEndAppPresenter: R.id.ksad_app_icon is null");
        a(this.eq, "NativePlayEndAppPresenter: R.id.ksad_app_name is null");
        a(this.qg, "NativePlayEndAppPresenter: R.id.ksad_app_download is null");
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdTemplate adTemplate = this.pO.mAdTemplate;
        this.mAdTemplate = adTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        this.mApkDownloadHelper = this.pO.mApkDownloadHelper;
        this.mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.nativead.b.f.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                try {
                    f.this.fG();
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                    com.kwad.components.core.d.a.reportSdkCaughtException(th);
                }
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                super.onMediaPlayStart();
                f.this.fH();
            }
        };
        this.pO.pP.b(this.mVideoPlayStateListener);
        ViewGroup viewGroup = this.qf;
        if (viewGroup != null) {
            viewGroup.setVisibility(8);
        }
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.c(this.qi);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fG() {
        KSImageLoader.loadAppIcon(this.gI, com.kwad.sdk.core.response.helper.a.cv(this.mAdInfo), this.mAdTemplate, 12);
        this.eq.setText(com.kwad.sdk.core.response.helper.a.aB(this.mAdInfo));
        this.qg.setText(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo));
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.b(this.qi);
        }
        this.qf.setOnClickListener(this);
        this.qf.setOnTouchListener(this);
        this.qf.setVisibility(0);
        this.eq.setVisibility(0);
        this.qg.setVisibility(0);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fH() {
        try {
            this.eq.setVisibility(8);
            this.qg.setVisibility(8);
            this.qf.setVisibility(8);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (this.pO.pV) {
            if (view == this.qf) {
                T(2);
                notifyAdClick();
            } else if (view == this.qg) {
                T(1);
                notifyAdClick();
            }
        }
    }

    private void T(int i) {
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.mAdTemplate).aD(i).b(this.mApkDownloadHelper).A((this.pO == null || this.pO.pP == null) ? 0L : this.pO.pP.getPlayDuration()).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.nativead.b.f.3
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                com.kwad.sdk.core.adlog.c.a(f.this.mAdTemplate, 2, f.this.pO.pJ.getTouchCoords());
            }
        }));
    }

    private void notifyAdClick() {
        if (this.qf != null) {
            this.pO.pv.l(this.qf);
        }
    }

    @Override // android.view.View.OnTouchListener
    public final boolean onTouch(View view, MotionEvent motionEvent) {
        int action = motionEvent.getAction();
        boolean z = false;
        if (action == 0) {
            this.qh = MotionEvent.obtain(motionEvent);
        } else if (action == 1 || action == 3) {
            if (com.kwad.sdk.utils.b.a(this.qh, motionEvent)) {
                if (this.pO.pU && com.kwad.sdk.utils.b.a(this.qh, motionEvent, this.mAdTemplate)) {
                    m(view);
                }
                z = true;
            }
            this.qh = null;
        }
        return z;
    }

    private void m(View view) {
        if (view == this.qf) {
            fI();
            notifyAdClick();
        }
    }

    private void fI() {
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.pO.mAdTemplate).b(this.pO.mApkDownloadHelper).A(this.pO.pP.getPlayDuration()).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.nativead.b.f.4
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                com.kwad.sdk.core.adlog.c.a(f.this.pO.mAdTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, f.this.pO.pJ.getTouchCoords());
            }
        }));
    }
}
