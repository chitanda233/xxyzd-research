package com.kwad.components.core.video;

import android.content.Context;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.ProgressBar;
import android.widget.RelativeLayout;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.al;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.bw;
import com.kwad.sdk.widget.KSRelativeLayout;

/* JADX INFO: loaded from: classes3.dex */
@Deprecated
public class a extends com.kwad.sdk.core.video.videoview.b implements View.OnClickListener {
    protected ImageView Eu;
    protected TextView Ev;
    protected boolean amd;
    private boolean ame;
    protected boolean amf;
    private int amg;
    private int amh;
    private boolean ami;
    private KSRelativeLayout amj;
    private RelativeLayout amk;
    private boolean aml;
    private boolean amm;
    private LinearLayout amn;
    private LinearLayout amo;
    private ImageView amp;
    public ViewGroup amq;
    protected TextView amr;
    private c ams;
    private InterfaceC0460a amt;
    protected com.kwad.components.core.video.a.a amu;
    protected View amv;
    protected final com.kwad.sdk.core.download.a.a amw;
    protected AdInfo mAdInfo;
    protected AdTemplate mAdTemplate;
    protected com.kwad.components.core.e.d.d mApkDownloadHelper;
    protected Context mContext;
    protected ImageView pX;
    protected TextView pY;
    private boolean qH;
    private ProgressBar qs;

    /* JADX INFO: renamed from: com.kwad.components.core.video.a$a, reason: collision with other inner class name */
    public interface InterfaceC0460a {
        void a(int i, al.a aVar);
    }

    public interface b extends c {
        void onVideoPlayError(int i, int i2);
    }

    public interface c {
        void as();

        void at();

        void d(long j);

        void onVideoPlayStart();
    }

    protected void xp() {
    }

    public void setCanControlPlay(boolean z) {
        this.amf = z;
    }

    public a(Context context, AdTemplate adTemplate, com.kwad.sdk.core.video.videoview.c cVar) {
        super(context, cVar);
        this.ame = true;
        this.amf = false;
        this.amm = false;
        this.amw = new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.core.video.a.1
            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onIdle() {
                a aVar = a.this;
                aVar.bn(com.kwad.sdk.core.response.helper.a.aK(aVar.mAdInfo));
            }

            @Override // com.kwad.sdk.core.download.a.a
            public final void onPaused(int i) {
                a.this.amr.setText(com.kwad.sdk.core.response.helper.a.NH());
            }

            @Override // com.kwad.sdk.core.download.a.a, com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadStarted() {
                a.this.amr.setText(com.kwad.sdk.core.response.helper.a.ev(0));
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onProgressUpdate(int i) {
                a.this.amr.setText(com.kwad.sdk.core.response.helper.a.ev(i));
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFinished() {
                a.this.amr.setText(com.kwad.sdk.core.response.helper.a.cF(a.this.mAdTemplate));
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
                a.this.amr.setText(com.kwad.sdk.core.response.helper.a.af(a.this.mAdInfo));
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFailed() {
                a.this.amr.setText(com.kwad.sdk.core.response.helper.a.aK(a.this.mAdInfo));
            }
        };
        this.mContext = context;
        this.mAdTemplate = adTemplate;
        this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        init();
    }

    private void init() {
        this.amv = com.kwad.sdk.wrapper.m.inflate(this.mContext, R.layout.ksad_feed_video_palyer_controller, this);
        this.amj = (KSRelativeLayout) findViewById(R.id.ksad_video_root_container);
        this.amk = (RelativeLayout) findViewById(R.id.ksad_data_flow_container);
        this.pY = (TextView) findViewById(R.id.ksad_data_flow_play_tip);
        ImageView imageView = (ImageView) findViewById(R.id.ksad_data_flow_play_btn);
        this.pX = imageView;
        imageView.setOnClickListener(this);
        this.amn = (LinearLayout) findViewById(R.id.ksad_video_network_unavailable);
        this.amo = (LinearLayout) findViewById(R.id.ksad_video_error_container);
        this.qs = (ProgressBar) findViewById(R.id.ksad_video_progress);
        this.amp = (ImageView) findViewById(R.id.ksad_video_thumb_image);
        String url = com.kwad.sdk.core.response.helper.a.bA(this.mAdInfo).getUrl();
        if (!TextUtils.isEmpty(url)) {
            this.amp.setImageDrawable(null);
            KSImageLoader.loadImage(this.amp, url, this.mAdTemplate);
            this.amp.setVisibility(0);
        } else {
            this.amp.setVisibility(8);
        }
        this.pY.setText(bw.at(com.kwad.sdk.core.response.helper.a.N(this.mAdInfo) * 1000));
        this.amu = com.kwad.components.core.video.a.d.a(this.mAdTemplate, this.aZI.getMediaPlayerType(), false);
        xp();
    }

    public void setHideEnd(boolean z) {
        this.ami = z;
    }

    @Override // com.kwad.sdk.core.video.videoview.b
    public final void q(int i, int i2) {
        this.amh = i2;
        this.amg = i;
    }

    @Override // com.kwad.sdk.core.video.videoview.b
    public final void onPlayStateChanged(int i) {
        com.kwad.components.core.video.a.a aVar;
        com.kwad.sdk.core.d.c.d("AdVideoPlayerController", "onPlayStateChanged playState=" + i);
        if (i == -1) {
            xD();
            setTopBottomVisible(false);
            this.amn.setVisibility(8);
            this.amo.setVisibility(0);
            c cVar = this.ams;
            if (cVar instanceof f.a) {
                ((f.a) cVar).onVideoPlayError(this.amg, this.amh);
            }
            c cVar2 = this.ams;
            if (cVar2 instanceof b) {
                ((b) cVar2).onVideoPlayError(this.amg, this.amh);
            }
            com.kwad.components.core.p.a.vX().g(this.mAdTemplate, this.amg, this.amh);
            com.kwad.components.core.video.a.a aVar2 = this.amu;
            if (aVar2 != null) {
                aVar2.onMediaPlayError(this.amg, this.amh);
                return;
            }
            return;
        }
        if (i == 9) {
            xD();
            this.mAdTemplate.setmCurPlayTime(-1L);
            setTopBottomVisible(false);
            if (!this.ami) {
                KSImageLoader.loadImage(this.amp, com.kwad.sdk.core.response.helper.a.aa(this.mAdInfo), this.mAdTemplate);
                this.amp.setVisibility(0);
                fG();
            }
            c cVar3 = this.ams;
            if (cVar3 != null) {
                cVar3.at();
            }
            com.kwad.components.core.video.a.a aVar3 = this.amu;
            if (aVar3 != null) {
                aVar3.onMediaPlayCompleted();
                return;
            }
            return;
        }
        if (i == 1) {
            xt();
            this.amn.setVisibility(8);
            this.amo.setVisibility(8);
            this.qs.setVisibility(8);
            fH();
            return;
        }
        if (i == 2) {
            c cVar4 = this.ams;
            if (cVar4 != null) {
                cVar4.onVideoPlayStart();
            }
            com.kwad.components.core.video.a.a aVar4 = this.amu;
            if (aVar4 != null) {
                aVar4.onMediaPlayStart();
            }
            setTopBottomVisible(true);
            xC();
            return;
        }
        if (i == 4) {
            c cVar5 = this.ams;
            if (cVar5 != null) {
                cVar5.as();
            }
            this.amp.setVisibility(8);
            com.kwad.components.core.video.a.a aVar5 = this.amu;
            if (aVar5 != null) {
                aVar5.qY();
                this.amu.onMediaPlaying();
                return;
            }
            return;
        }
        if (i == 5) {
            com.kwad.components.core.video.a.a aVar6 = this.amu;
            if (aVar6 != null) {
                aVar6.onMediaPlayPaused();
                return;
            }
            return;
        }
        if (i != 6) {
            if (i == 7 && (aVar = this.amu) != null) {
                aVar.onVideoPlayBufferingPaused();
                return;
            }
            return;
        }
        com.kwad.components.core.video.a.a aVar7 = this.amu;
        if (aVar7 != null) {
            aVar7.onVideoPlayBufferingPlaying();
        }
    }

    public AdTemplate getAdTemplate() {
        return this.mAdTemplate;
    }

    private void fH() {
        ViewGroup viewGroup = this.amq;
        if (viewGroup != null) {
            viewGroup.setVisibility(8);
        }
    }

    public final void bn(String str) {
        TextView textView = (TextView) findViewById(R.id.ksad_app_download);
        if (textView == null) {
            return;
        }
        textView.setText(str);
    }

    protected void fG() {
        try {
            if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
                LinearLayout linearLayout = (LinearLayout) findViewById(R.id.ksad_video_complete_app_container);
                this.Eu = (ImageView) findViewById(R.id.ksad_video_complete_app_icon);
                this.Ev = (TextView) findViewById(R.id.ksad_app_name);
                this.amr = (TextView) findViewById(R.id.ksad_app_download);
                KSImageLoader.loadAppIcon(this.Eu, com.kwad.sdk.core.response.helper.e.eR(this.mAdTemplate), this.mAdTemplate, 12);
                this.Ev.setText(com.kwad.sdk.core.response.helper.a.cs(this.mAdInfo));
                this.amr.setText(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo));
                this.amq = linearLayout;
                this.Eu.setOnClickListener(this);
                this.Ev.setOnClickListener(this);
                this.amr.setOnClickListener(this);
                com.kwad.components.core.e.d.d dVar = new com.kwad.components.core.e.d.d(this.mAdTemplate);
                this.mApkDownloadHelper = dVar;
                dVar.b(this.amw);
            } else {
                LinearLayout linearLayout2 = (LinearLayout) findViewById(R.id.ksad_video_complete_h5_container);
                TextView textView = (TextView) findViewById(R.id.ksad_h5_open);
                this.amr = textView;
                textView.setText(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo));
                this.amr.setOnClickListener(this);
                this.amq = linearLayout2;
            }
            this.amq.setOnClickListener(this);
            this.amq.setVisibility(0);
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
    }

    protected final void xq() {
        this.amn.setVisibility(0);
    }

    protected final void xr() {
        this.amn.setVisibility(8);
    }

    @Override // com.kwad.sdk.core.video.videoview.b
    public final void reset() {
        xD();
        this.qs.setProgress(0);
        this.qs.setSecondaryProgress(0);
        xt();
        this.amn.setVisibility(8);
        this.amo.setVisibility(8);
        this.qs.setVisibility(8);
        this.amp.setVisibility(8);
        this.amk.setVisibility(8);
        this.mAdTemplate.mVideoPlayerStatus.setVideoPlayerBehavior(1);
        fH();
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        if (view == this.pX) {
            this.amd = true;
            this.ame = true;
            startPlay();
        } else {
            if (view == this.Eu) {
                bO(1);
                return;
            }
            if (view == this.Ev) {
                bO(2);
            } else if (view == this.amr) {
                bO(3);
            } else {
                bO(4);
            }
        }
    }

    protected final void xs() {
        this.amk.setVisibility(0);
        this.amp.setVisibility(0);
        this.mAdTemplate.mVideoPlayerStatus.setVideoPlayerBehavior(2);
    }

    private void xt() {
        this.amk.setVisibility(8);
    }

    private void setTopBottomVisible(boolean z) {
        if (this.amm) {
            return;
        }
        this.qs.setVisibility(z ? 0 : 8);
        this.aml = z;
    }

    public final void be(boolean z) {
        if (this.amm) {
            return;
        }
        if (z) {
            if (this.aml) {
                this.qs.setVisibility(0);
                return;
            }
            return;
        }
        this.qs.setVisibility(8);
    }

    protected void startPlay() {
        if (this.aZI.isIdle()) {
            com.kwad.components.core.video.a.a aVar = this.amu;
            if (aVar != null) {
                aVar.onStart();
            }
            if (!aq.isNetworkConnected(this.mContext)) {
                xq();
                return;
            }
            xr();
            if (this.amf) {
                xu();
                this.aZI.start();
                return;
            }
            if (this.ame && aq.isWifiConnected(this.mContext)) {
                xu();
                this.aZI.start();
                return;
            } else if (this.ame && (this.qH || this.amd)) {
                xu();
                this.aZI.start();
                return;
            } else {
                xs();
                return;
            }
        }
        if (this.aZI.isPaused() || this.aZI.OX()) {
            xu();
            this.aZI.restart();
        }
    }

    protected final void xu() {
        this.aZI.setKsPlayLogParam(com.kwad.sdk.contentalliance.a.a.a.ci(this.mAdTemplate));
    }

    protected void xv() {
        this.aZI.pause();
    }

    public void release() {
        this.aZI.release();
        com.kwad.components.core.video.a.a aVar = this.amu;
        if (aVar != null) {
            aVar.onRelease();
        }
    }

    @Override // com.kwad.sdk.core.video.videoview.b
    public final void xw() {
        long currentPosition = this.aZI.getCurrentPosition();
        long duration = this.aZI.getDuration();
        this.qs.setSecondaryProgress(this.aZI.getBufferPercentage());
        this.mAdTemplate.setmCurPlayTime(currentPosition);
        this.qs.setProgress((int) ((currentPosition * 100.0f) / duration));
        c cVar = this.ams;
        if (cVar != null) {
            cVar.d(currentPosition);
        }
    }

    public void setVideoPlayCallback(c cVar) {
        this.ams = cVar;
    }

    public void setAdClickListener(InterfaceC0460a interfaceC0460a) {
        this.amt = interfaceC0460a;
    }

    public void setDataFlowAutoStart(boolean z) {
        this.qH = z;
    }

    public void setDataAutoStart(boolean z) {
        this.ame = z;
    }

    public final void xx() {
        this.amm = true;
        this.qs.setVisibility(8);
    }

    private void bO(int i) {
        try {
            InterfaceC0460a interfaceC0460a = this.amt;
            if (interfaceC0460a != null) {
                interfaceC0460a.a(i, this.amj.getTouchCoords());
            }
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }
}
