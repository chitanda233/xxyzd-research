package com.kwad.components.ad.draw.presenter;

import android.animation.ValueAnimator;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.DecelerateInterpolator;
import android.widget.TextView;
import com.kwad.components.ad.draw.view.DrawDownloadProgressBar;
import com.kwad.components.core.t.x;
import com.kwad.components.core.video.l;
import com.kwad.components.core.video.m;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.ad.draw.b.a implements View.OnClickListener {
    private ViewGroup dZ;
    private TextView ea;
    private TextView eb;
    private TextView ec;
    private DrawDownloadProgressBar ed;
    private ValueAnimator ee;
    private int ef;
    private int eg;
    private int eh;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private KsLogoView mLogoView;
    private l mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.draw.presenter.c.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            if (j2 >= c.this.eh * 1000) {
                c.this.dL.dQ.aW();
            } else if (j2 >= c.this.eg * 1000) {
                c.this.aT();
            } else if (j2 >= c.this.ef * 1000) {
                c.this.aR();
            }
        }
    };
    private KsAppDownloadListener ei = new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.ad.draw.presenter.c.2
        @Override // com.kwad.sdk.api.KsAppDownloadListener
        public final void onIdle() {
            c.this.ec.setText(com.kwad.sdk.core.response.helper.a.aK(c.this.mAdInfo));
            c.this.ed.e(com.kwad.sdk.core.response.helper.a.aK(c.this.mAdInfo), c.this.ed.getMax());
        }

        @Override // com.kwad.sdk.api.KsAppDownloadListener
        public final void onProgressUpdate(int i) {
            c.this.ec.setText(i + "%");
            c.this.ed.e(i + "%", i);
        }

        @Override // com.kwad.sdk.core.download.a.a
        public final void onPaused(int i) {
            super.onPaused(i);
            c.this.ec.setText(com.kwad.sdk.core.response.helper.a.NH());
            c.this.ed.e(com.kwad.sdk.core.response.helper.a.NH(), i);
        }

        @Override // com.kwad.sdk.api.KsAppDownloadListener
        public final void onDownloadFinished() {
            c.this.ec.setText(com.kwad.sdk.core.response.helper.a.cF(c.this.mAdTemplate));
            c.this.ed.e(com.kwad.sdk.core.response.helper.a.cF(c.this.mAdTemplate), c.this.ed.getMax());
        }

        @Override // com.kwad.sdk.api.KsAppDownloadListener
        public final void onDownloadFailed() {
            c.this.ec.setText(com.kwad.sdk.core.response.helper.a.aK(c.this.mAdInfo));
            c.this.ed.e(com.kwad.sdk.core.response.helper.a.aK(c.this.mAdInfo), c.this.ed.getMax());
        }

        @Override // com.kwad.sdk.api.KsAppDownloadListener
        public final void onInstalled() {
            c.this.ec.setText(com.kwad.sdk.core.response.helper.a.af(c.this.mAdInfo));
            c.this.ed.e(com.kwad.sdk.core.response.helper.a.af(c.this.mAdInfo), c.this.ed.getMax());
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.dZ = (ViewGroup) findViewById(R.id.ksad_ad_normal_container);
        this.ea = (TextView) findViewById(R.id.ksad_ad_normal_title);
        this.eb = (TextView) findViewById(R.id.ksad_ad_normal_des);
        this.mLogoView = (KsLogoView) findViewById(R.id.ksad_ad_normal_logo);
        this.ec = (TextView) findViewById(R.id.ksad_ad_normal_convert_btn);
        DrawDownloadProgressBar drawDownloadProgressBar = (DrawDownloadProgressBar) findViewById(R.id.ksad_ad_light_convert_btn);
        this.ed = drawDownloadProgressBar;
        drawDownloadProgressBar.setTextSize(16);
    }

    @Override // com.kwad.components.ad.draw.b.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdTemplate adTemplate = this.dL.mAdTemplate;
        this.mAdTemplate = adTemplate;
        this.mAdInfo = e.eM(adTemplate);
        this.mApkDownloadHelper = this.dL.mApkDownloadHelper;
        aQ();
        this.mLogoView.bh(this.mAdTemplate);
        this.ec.setText(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo));
        this.ec.setVisibility(8);
        this.ed.e(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo), this.ed.getMax());
        this.ed.setVisibility(8);
        this.dZ.setVisibility(0);
        this.dZ.setOnClickListener(this);
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            this.ea.setText(com.kwad.sdk.core.response.helper.a.aB(this.mAdInfo));
            this.ea.setVisibility(0);
            com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
            if (dVar != null) {
                dVar.b(this.ei);
            }
        } else {
            this.ea.setVisibility(8);
        }
        this.eb.setText(com.kwad.sdk.core.response.helper.a.aA(this.mAdInfo));
        this.dL.dN.b(this.mVideoPlayStateListener);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        KsAppDownloadListener ksAppDownloadListener;
        super.onUnbind();
        aS();
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null && (ksAppDownloadListener = this.ei) != null) {
            dVar.c(ksAppDownloadListener);
        }
        this.dL.dN.a(this.mVideoPlayStateListener);
    }

    private void aQ() {
        this.ef = com.kwad.sdk.core.response.helper.a.bx(this.mAdInfo);
        this.eg = com.kwad.sdk.core.response.helper.a.by(this.mAdInfo);
        this.eh = com.kwad.sdk.core.response.helper.a.bz(this.mAdInfo);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.dZ) {
            aT();
            a(false, 2);
        } else if (view == this.ec) {
            aT();
            a(true, 1);
        } else if (view == this.ed) {
            a(true, 1);
        }
    }

    private void a(boolean z, int i) {
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(this.dZ.getContext()).aF(this.mAdTemplate).b(this.mApkDownloadHelper).aD(i).as(z).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.draw.presenter.c.3
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                com.kwad.sdk.core.adlog.c.a(c.this.mAdTemplate, 1, c.this.dL.mRootContainer.getTouchCoords());
                if (c.this.dL.du != null) {
                    c.this.dL.du.onAdClicked();
                }
            }
        }));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aR() {
        if (this.ec.getVisibility() == 0 || this.ed.getVisibility() == 0) {
            return;
        }
        this.ec.setOnClickListener(this);
        this.ec.setVisibility(0);
        TextView textView = this.ec;
        ValueAnimator valueAnimatorB = x.b(textView, 0, com.kwad.sdk.c.a.a.a(textView.getContext(), 44.0f));
        this.ee = valueAnimatorB;
        valueAnimatorB.setInterpolator(new DecelerateInterpolator(2.0f));
        this.ee.setDuration(300L);
        this.ee.start();
    }

    private void aS() {
        ValueAnimator valueAnimator = this.ee;
        if (valueAnimator != null) {
            valueAnimator.removeAllListeners();
            this.ee.cancel();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void aT() {
        if (this.ed.getVisibility() == 0) {
            return;
        }
        this.ed.setOnClickListener(this);
        this.ed.setVisibility(0);
        this.ec.setVisibility(8);
    }
}
