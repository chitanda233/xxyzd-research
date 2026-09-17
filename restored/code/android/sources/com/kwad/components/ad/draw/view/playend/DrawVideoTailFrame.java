package com.kwad.components.ad.draw.view.playend;

import android.content.Context;
import android.text.TextUtils;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.draw.view.DrawDownloadProgressBar;
import com.kwad.components.ad.widget.AppScoreView;
import com.kwad.components.core.e.d.d;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.api.KsDrawAd;
import com.kwad.sdk.core.adlog.c;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.a;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class DrawVideoTailFrame extends FrameLayout implements View.OnClickListener {
    private KsDrawAd.AdInteractionListener du;
    private KsAppDownloadListener ei;
    private TextView eq;
    private AdBaseFrameLayout gF;
    private ImageView gG;
    private ViewGroup gH;
    private ImageView gI;
    private AppScoreView gJ;
    private TextView gK;
    private TextView gL;
    private DrawDownloadProgressBar gM;
    private ViewGroup gN;
    private TextView gO;
    private TextView gP;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private d mApkDownloadHelper;
    private KsLogoView mLogoView;

    public DrawVideoTailFrame(Context context) {
        super(context);
        B(context);
    }

    public DrawVideoTailFrame(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        B(context);
    }

    public DrawVideoTailFrame(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        B(context);
    }

    private void B(Context context) {
        m.inflate(context, R.layout.ksad_draw_video_tailframe, this);
        this.gG = (ImageView) findViewById(R.id.ksad_video_cover);
        this.gH = (ViewGroup) findViewById(R.id.ksad_app_container);
        this.gI = (ImageView) findViewById(R.id.ksad_app_icon);
        this.eq = (TextView) findViewById(R.id.ksad_app_name);
        this.gJ = (AppScoreView) findViewById(R.id.ksad_app_score);
        this.gK = (TextView) findViewById(R.id.ksad_app_download_count);
        this.gL = (TextView) findViewById(R.id.ksad_app_ad_desc);
        DrawDownloadProgressBar drawDownloadProgressBar = (DrawDownloadProgressBar) findViewById(R.id.ksad_app_download_btn);
        this.gM = drawDownloadProgressBar;
        drawDownloadProgressBar.setTextSize(15);
        this.gN = (ViewGroup) findViewById(R.id.ksad_h5_container);
        this.gO = (TextView) findViewById(R.id.ksad_h5_ad_desc);
        this.gP = (TextView) findViewById(R.id.ksad_h5_open_btn);
        this.mLogoView = (KsLogoView) findViewById(R.id.ksad_draw_tailframe_logo);
    }

    public final void j(AdTemplate adTemplate) {
        this.mAdTemplate = adTemplate;
        AdInfo adInfoEM = e.eM(adTemplate);
        this.mAdInfo = adInfoEM;
        AdInfo.AdMaterialInfo.MaterialFeature materialFeatureBb = a.bb(adInfoEM);
        String str = materialFeatureBb.coverUrl;
        this.mLogoView.bh(adTemplate);
        if (!TextUtils.isEmpty(str)) {
            int i = materialFeatureBb.width;
            int i2 = materialFeatureBb.height;
            if (i > 0 && i > i2) {
                int screenWidth = com.kwad.sdk.c.a.a.getScreenWidth(getContext());
                if (getWidth() != 0) {
                    screenWidth = getWidth();
                }
                int i3 = (int) (screenWidth * (i2 / i));
                ViewGroup.LayoutParams layoutParams = this.gG.getLayoutParams();
                layoutParams.width = screenWidth;
                layoutParams.height = i3;
            }
            KSImageLoader.loadImage(this.gG, str, this.mAdTemplate);
        }
        if (a.aL(this.mAdInfo)) {
            KSImageLoader.loadAppIcon(this.gI, a.cv(this.mAdInfo), this.mAdTemplate, 11);
            this.eq.setText(a.aB(this.mAdInfo));
            float fAG = a.aG(this.mAdInfo);
            if (fAG >= 3.0f) {
                this.gJ.setScore(fAG);
                this.gJ.setVisibility(0);
            }
            this.gK.setText(a.aF(this.mAdInfo));
            this.gL.setText(a.aA(this.mAdInfo));
            this.gH.setVisibility(0);
            this.gN.setVisibility(8);
        } else {
            this.gO.setText(a.aA(this.mAdInfo));
            this.gP.setText(a.aK(this.mAdInfo));
            this.gH.setVisibility(8);
            this.gN.setVisibility(0);
        }
        this.gM.setOnClickListener(this);
        setOnClickListener(this);
    }

    public void setApkDownloadHelper(d dVar) {
        this.mApkDownloadHelper = dVar;
    }

    public void setAdBaseFrameLayout(AdBaseFrameLayout adBaseFrameLayout) {
        this.gF = adBaseFrameLayout;
    }

    public final void bY() {
        d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            KsAppDownloadListener ksAppDownloadListener = this.ei;
            if (ksAppDownloadListener != null) {
                dVar.d(ksAppDownloadListener);
                return;
            }
            KsAppDownloadListener appDownloadListener = getAppDownloadListener();
            this.ei = appDownloadListener;
            this.mApkDownloadHelper.b(appDownloadListener);
        }
    }

    public final void release() {
        KsAppDownloadListener ksAppDownloadListener;
        d dVar = this.mApkDownloadHelper;
        if (dVar == null || (ksAppDownloadListener = this.ei) == null) {
            return;
        }
        dVar.c(ksAppDownloadListener);
    }

    private KsAppDownloadListener getAppDownloadListener() {
        return new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.ad.draw.view.playend.DrawVideoTailFrame.1
            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onIdle() {
                DrawVideoTailFrame.this.gM.e(a.aK(DrawVideoTailFrame.this.mAdInfo), DrawVideoTailFrame.this.gM.getMax());
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onProgressUpdate(int i) {
                DrawVideoTailFrame.this.gM.e(i + "%", i);
            }

            @Override // com.kwad.sdk.core.download.a.a
            public final void onPaused(int i) {
                super.onPaused(i);
                DrawVideoTailFrame.this.gM.e(a.NH(), i);
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFinished() {
                DrawVideoTailFrame.this.gM.e(a.cF(DrawVideoTailFrame.this.mAdTemplate), DrawVideoTailFrame.this.gM.getMax());
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onDownloadFailed() {
                DrawVideoTailFrame.this.gM.e(a.aK(DrawVideoTailFrame.this.mAdInfo), DrawVideoTailFrame.this.gM.getMax());
            }

            @Override // com.kwad.sdk.api.KsAppDownloadListener
            public final void onInstalled() {
                DrawVideoTailFrame.this.gM.e(a.af(DrawVideoTailFrame.this.mAdInfo), DrawVideoTailFrame.this.gM.getMax());
            }
        };
    }

    public void setAdInteractionListener(KsDrawAd.AdInteractionListener adInteractionListener) {
        this.du = adInteractionListener;
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.mAdTemplate).b(this.mApkDownloadHelper).aD(view == this.gM ? 1 : 3).as(view == this.gM).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.draw.view.playend.DrawVideoTailFrame.2
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                if (DrawVideoTailFrame.this.du != null) {
                    DrawVideoTailFrame.this.du.onAdClicked();
                }
                c.a(DrawVideoTailFrame.this.mAdTemplate, 2, DrawVideoTailFrame.this.gF.getTouchCoords());
            }
        }));
    }
}
