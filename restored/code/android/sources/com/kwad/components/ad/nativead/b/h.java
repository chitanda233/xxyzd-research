package com.kwad.components.ad.nativead.b;

import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class h extends com.kwad.components.ad.nativead.a.a implements View.OnClickListener, View.OnTouchListener {
    private MotionEvent qh;
    private ViewGroup qm;
    private TextView qn;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.qm = (ViewGroup) findViewById(R.id.ksad_video_complete_h5_container);
        this.qn = (TextView) findViewById(R.id.ksad_h5_open);
        a(this.qm, "NativePlayEndH5Presenter: R.id.ksad_video_complete_h5_container is null");
        a(this.qn, "NativePlayEndH5Presenter: R.id.ksad_h5_open is null");
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.nativead.b.h.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayCompleted() {
                h.this.fG();
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                super.onMediaPlayStart();
                h.this.fH();
            }
        };
        this.pO.pP.b(this.mVideoPlayStateListener);
        ViewGroup viewGroup = this.qm;
        if (viewGroup != null) {
            viewGroup.setVisibility(8);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fG() {
        try {
            this.qn.setText(com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(this.pO.mAdTemplate)));
            this.qm.setOnClickListener(this);
            this.qm.setOnTouchListener(this);
            this.qm.setVisibility(0);
            this.qn.setVisibility(0);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fH() {
        try {
            this.qm.setVisibility(8);
            this.qn.setVisibility(8);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (this.pO.pV) {
            fL();
            notifyAdClick();
        }
    }

    private void fL() {
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.pO.mAdTemplate).aD(2).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.nativead.b.h.2
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                com.kwad.sdk.core.adlog.c.a(h.this.pO.mAdTemplate, 2, h.this.pO.pJ.getTouchCoords());
            }
        }));
    }

    private void notifyAdClick() {
        if (this.qm != null) {
            this.pO.pv.l(this.qm);
        }
    }

    @Override // android.view.View.OnTouchListener
    public final boolean onTouch(View view, MotionEvent motionEvent) {
        MotionEvent motionEvent2;
        int action = motionEvent.getAction();
        boolean z = false;
        if (action == 0) {
            this.qh = MotionEvent.obtain(motionEvent);
        } else if (action == 1 || action == 3) {
            if (com.kwad.sdk.utils.b.a(this.qh, motionEvent)) {
                if (this.pO.pU && (motionEvent2 = this.qh) != null && com.kwad.sdk.utils.b.a(motionEvent2, motionEvent, this.pO.mAdTemplate)) {
                    m(view);
                }
                z = true;
            }
            this.qh = null;
        }
        return z;
    }

    private void m(View view) {
        if (view == this.qm) {
            fI();
            notifyAdClick();
        }
    }

    private void fI() {
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.pO.mAdTemplate).b(this.pO.mApkDownloadHelper).A(this.pO.pP.getPlayDuration()).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.nativead.b.h.3
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                com.kwad.sdk.core.adlog.c.a(h.this.pO.mAdTemplate, MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, h.this.pO.pJ.getTouchCoords());
            }
        }));
    }
}
