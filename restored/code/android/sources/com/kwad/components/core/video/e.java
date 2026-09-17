package com.kwad.components.core.video;

import android.content.Context;
import android.graphics.Color;
import android.graphics.drawable.GradientDrawable;
import android.os.Message;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.cb;
import com.kwad.sdk.utils.cc;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class e extends a implements cc.a {
    private View bZ;
    private final cc ca;
    private final AtomicBoolean cb;
    private boolean cc;
    private boolean cd;
    private final KsAdVideoPlayConfig ce;

    public e(Context context, AdTemplate adTemplate, com.kwad.sdk.core.video.videoview.c cVar, KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        super(context, adTemplate, cVar);
        this.ca = new cc(this);
        this.cb = new AtomicBoolean(true);
        this.cd = true;
        this.bZ = this;
        this.ce = ksAdVideoPlayConfig;
    }

    @Override // android.view.View
    protected final void onWindowVisibilityChanged(int i) {
        super.onWindowVisibilityChanged(i);
    }

    @Override // android.view.View
    public final void onWindowFocusChanged(boolean z) {
        super.onWindowFocusChanged(z);
    }

    @Override // android.view.ViewGroup, android.view.View
    protected final void onAttachedToWindow() {
        super.onAttachedToWindow();
        com.kwad.sdk.core.d.c.i("FeedVideoPlayerController", "onAttachedToWindow");
        ae();
    }

    @Override // android.view.View
    public final void onFinishTemporaryDetach() {
        super.onFinishTemporaryDetach();
        com.kwad.sdk.core.d.c.i("FeedVideoPlayerController", "onFinishTemporaryDetach");
        ae();
    }

    @Override // android.view.View
    public final void onStartTemporaryDetach() {
        super.onStartTemporaryDetach();
        com.kwad.sdk.core.d.c.i("FeedVideoPlayerController", "onStartTemporaryDetach");
        af();
    }

    @Override // android.view.ViewGroup, android.view.View
    protected final void onDetachedFromWindow() {
        super.onDetachedFromWindow();
        com.kwad.sdk.core.d.c.i("FeedVideoPlayerController", "onDetachedFromWindow");
        af();
    }

    private void ae() {
        if (this.cb.getAndSet(false)) {
            com.kwad.sdk.core.d.c.i("FeedVideoPlayerController", "onViewAttached");
            this.ca.sendEmptyMessage(1);
        }
    }

    public final void af() {
        if (this.cb.getAndSet(true)) {
            return;
        }
        com.kwad.sdk.core.d.c.i("FeedVideoPlayerController", "onViewDetached");
        this.ca.removeCallbacksAndMessages(null);
        if (this.cd) {
            release();
        } else {
            this.aZI.pause();
        }
    }

    public final void xP() {
        this.ca.removeCallbacksAndMessages(null);
        if (this.cd) {
            release();
        } else {
            this.aZI.pause();
        }
    }

    @Override // com.kwad.sdk.utils.cc.a
    public final void a(Message message) {
        if (!this.amf && message.what == 1) {
            if (cb.r(this.bZ, 30)) {
                if (!this.cc) {
                    startPlay();
                }
            } else {
                xv();
            }
            this.ca.sendEmptyMessageDelayed(1, 500L);
        }
    }

    @Override // com.kwad.components.core.video.a
    protected final void startPlay() {
        if (this.aZI.isIdle()) {
            if (this.amu != null) {
                this.amu.onStart();
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
            } else if (ag()) {
                xu();
                this.aZI.start();
                return;
            } else if (this.amd) {
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

    private boolean ag() {
        KsAdVideoPlayConfig ksAdVideoPlayConfig = this.ce;
        if (ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) {
            KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = (KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig;
            if (kSAdVideoPlayConfigImpl.getVideoAutoPlayType() == 1) {
                return aq.isNetworkConnected(this.mContext);
            }
            if (kSAdVideoPlayConfigImpl.getVideoAutoPlayType() == 2) {
                return aq.isWifiConnected(this.mContext);
            }
            if (kSAdVideoPlayConfigImpl.getVideoAutoPlayType() == 3) {
                return false;
            }
            if (kSAdVideoPlayConfigImpl.getDataFlowAutoStartValue() != 0) {
                if (kSAdVideoPlayConfigImpl.isDataFlowAutoStart()) {
                    return aq.isNetworkConnected(this.mContext);
                }
                return aq.isWifiConnected(this.mContext);
            }
        }
        if (com.kwad.sdk.core.response.helper.a.cj(this.mAdInfo)) {
            return aq.isNetworkConnected(this.mContext);
        }
        if (com.kwad.sdk.core.response.helper.a.ck(this.mAdInfo)) {
            return aq.isWifiConnected(this.mContext);
        }
        return false;
    }

    @Override // com.kwad.components.core.video.a
    protected final void fG() {
        try {
            this.amv = com.kwad.sdk.wrapper.m.inflate(this.mContext, R.layout.ksad_feed_video_palyer_controller, null);
            LinearLayout linearLayout = (LinearLayout) this.amv.findViewById(R.id.ksad_video_complete_app_container);
            this.Eu = (ImageView) this.amv.findViewById(R.id.ksad_video_complete_app_icon);
            this.Ev = (TextView) this.amv.findViewById(R.id.ksad_app_name);
            this.amr = (TextView) this.amv.findViewById(R.id.ksad_app_download);
            KSImageLoader.loadAppIcon(this.Eu, com.kwad.sdk.core.response.helper.e.eR(this.mAdTemplate), this.mAdTemplate, 12);
            this.Ev.setText(com.kwad.sdk.core.response.helper.a.cs(this.mAdInfo));
            this.amr.setText(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo));
            this.amq = linearLayout;
            this.Eu.setOnClickListener(this);
            this.Ev.setOnClickListener(this);
            this.amr.setOnClickListener(this);
            this.mApkDownloadHelper = new com.kwad.components.core.e.d.d(this.mAdTemplate);
            this.mApkDownloadHelper.b(this.amw);
            if (xQ()) {
                LinearLayout.LayoutParams layoutParams = (LinearLayout.LayoutParams) this.Eu.getLayoutParams();
                layoutParams.width = com.kwad.sdk.c.a.a.a(this.mContext, 67.0f);
                layoutParams.height = com.kwad.sdk.c.a.a.a(this.mContext, 67.0f);
                this.Eu.setLayoutParams(layoutParams);
                LinearLayout.LayoutParams layoutParams2 = (LinearLayout.LayoutParams) this.Ev.getLayoutParams();
                layoutParams2.topMargin = com.kwad.sdk.c.a.a.a(this.mContext, 10.0f);
                this.Ev.setLayoutParams(layoutParams2);
                LinearLayout.LayoutParams layoutParams3 = (LinearLayout.LayoutParams) this.amr.getLayoutParams();
                layoutParams3.topMargin = com.kwad.sdk.c.a.a.a(this.mContext, 26.0f);
                layoutParams3.height = com.kwad.sdk.c.a.a.a(this.mContext, 32.0f);
                layoutParams3.width = com.kwad.sdk.c.a.a.a(this.mContext, 72.0f);
                GradientDrawable gradientDrawable = new GradientDrawable();
                gradientDrawable.setColor(Color.parseColor("#FE3666"));
                gradientDrawable.setCornerRadius(com.kwad.sdk.c.a.a.a(this.mContext, 8.0f));
                gradientDrawable.setShape(0);
                this.amr.setTextSize(2, 12.0f);
                this.amr.setLayoutParams(layoutParams3);
                this.amr.setBackground(gradientDrawable);
            }
            this.amq.setOnClickListener(this);
            this.amq.setVisibility(0);
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
    }

    private boolean xQ() {
        if (this.mAdTemplate.type == 21) {
            return this.mAdTemplate.defaultType == 1 || this.mAdTemplate.defaultType == 2;
        }
        return false;
    }

    public final void xR() {
        this.aZI.pause();
        this.cc = true;
    }

    public final void xS() {
        startPlay();
        this.cc = false;
    }

    public final void xT() {
        this.cc = false;
    }

    public final void setAutoRelease(boolean z) {
        this.cd = z;
    }
}
