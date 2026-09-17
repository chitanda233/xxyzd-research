package com.kwad.components.ad.nativead.b;

import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.components.core.video.m;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAdVideoPlayConfig;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.bw;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.nativead.a.a implements View.OnClickListener {
    private KsAdVideoPlayConfig ce;
    private AdInfo mAdInfo;
    private ViewGroup pW;
    private ImageView pX;
    private TextView pY;

    public a(KsAdVideoPlayConfig ksAdVideoPlayConfig) {
        this.ce = ksAdVideoPlayConfig;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.pW = (ViewGroup) findViewById(R.id.ksad_data_flow_container);
        this.pX = (ImageView) findViewById(R.id.ksad_data_flow_play_btn);
        this.pY = (TextView) findViewById(R.id.ksad_data_flow_play_tip);
    }

    @Override // com.kwad.components.ad.nativead.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.pO.mAdTemplate);
        this.mAdInfo = adInfoEM;
        if (!e(adInfoEM)) {
            this.pY.setText(bw.at(com.kwad.sdk.core.response.helper.a.N(this.mAdInfo) * 1000));
            this.pX.setOnClickListener(this);
            this.pO.mAdTemplate.mVideoPlayerStatus.mVideoPlayerBehavior = 2;
            this.pW.setVisibility(0);
        } else {
            this.pW.setVisibility(8);
        }
        this.mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.nativead.b.a.1
            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlayStart() {
                super.onMediaPlayStart();
                a.this.fE();
            }

            @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
            public final void onMediaPlaying() {
                super.onMediaPlaying();
                a.this.fE();
            }
        };
        this.pO.pP.b(this.mVideoPlayStateListener);
    }

    private boolean e(AdInfo adInfo) {
        if (adInfo.isAllowVideoAutoPlay) {
            return true;
        }
        if (!aq.isNetworkConnected(getContext())) {
            return false;
        }
        KsAdVideoPlayConfig ksAdVideoPlayConfig = this.ce;
        if (ksAdVideoPlayConfig instanceof KSAdVideoPlayConfigImpl) {
            KSAdVideoPlayConfigImpl kSAdVideoPlayConfigImpl = (KSAdVideoPlayConfigImpl) ksAdVideoPlayConfig;
            if (kSAdVideoPlayConfigImpl.getVideoAutoPlayType() == 1) {
                return true;
            }
            if (kSAdVideoPlayConfigImpl.getVideoAutoPlayType() == 2) {
                return aq.isWifiConnected(getContext());
            }
            if (kSAdVideoPlayConfigImpl.getVideoAutoPlayType() == 3) {
                return false;
            }
            if (kSAdVideoPlayConfigImpl.getDataFlowAutoStartValue() != 0) {
                return aq.isWifiConnected(getContext()) || (kSAdVideoPlayConfigImpl.isDataFlowAutoStart() && aq.isMobileConnected(getContext()));
            }
        }
        if (com.kwad.sdk.core.response.helper.a.cj(adInfo)) {
            return true;
        }
        return com.kwad.sdk.core.response.helper.a.ck(adInfo) && aq.isWifiConnected(getContext());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void fE() {
        if (this.pW.getVisibility() != 0) {
            return;
        }
        this.pW.setVisibility(8);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view == this.pX) {
            this.pO.pP.fV();
            this.mAdInfo.isAllowVideoAutoPlay = true;
        }
    }
}
