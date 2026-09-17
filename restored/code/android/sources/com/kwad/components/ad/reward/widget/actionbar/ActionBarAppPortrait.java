package com.kwad.components.ad.reward.widget.actionbar;

import android.content.Context;
import android.text.TextUtils;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import com.kwad.components.ad.widget.AppScoreView;
import com.kwad.components.core.page.widget.TextProgressBar;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.d;
import com.kwad.sdk.widget.h;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class ActionBarAppPortrait extends LinearLayout implements d {
    private AppScoreView FD;
    private TextProgressBar FE;
    private View FF;
    private a FI;
    private KsAppDownloadListener ei;
    private TextView eq;
    private ImageView gI;
    private TextView gK;
    private TextView hS;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;

    public interface a {
        void P(boolean z);
    }

    public ActionBarAppPortrait(Context context) {
        this(context, null);
    }

    public ActionBarAppPortrait(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public ActionBarAppPortrait(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        initView();
    }

    private void initView() {
        m.inflate(getContext(), R.layout.ksad_video_actionbar_app_portrait, this);
        this.gI = (ImageView) findViewById(R.id.ksad_app_icon);
        this.eq = (TextView) findViewById(R.id.ksad_app_title);
        this.hS = (TextView) findViewById(R.id.ksad_app_desc);
        this.FD = (AppScoreView) findViewById(R.id.ksad_app_score);
        this.gK = (TextView) findViewById(R.id.ksad_app_download_count);
        TextProgressBar textProgressBar = (TextProgressBar) findViewById(R.id.ksad_app_download_btn);
        this.FE = textProgressBar;
        textProgressBar.setTextDimen(com.kwad.sdk.c.a.a.a(getContext(), 16.0f));
        this.FE.setTextColor(-1);
        this.FF = findViewById(R.id.ksad_download_bar_cover);
    }

    public final void a(AdTemplate adTemplate, com.kwad.components.core.e.d.d dVar, a aVar) {
        this.mAdTemplate = adTemplate;
        AdInfo adInfoEM = e.eM(adTemplate);
        this.mAdInfo = adInfoEM;
        this.FI = aVar;
        this.mApkDownloadHelper = dVar;
        KSImageLoader.loadAppIcon(this.gI, com.kwad.sdk.core.response.helper.a.cv(adInfoEM), adTemplate, 12);
        this.eq.setText(com.kwad.sdk.core.response.helper.a.cs(this.mAdInfo));
        lK();
        this.FE.e(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo), 0);
        com.kwad.components.core.e.d.d dVar2 = this.mApkDownloadHelper;
        if (dVar2 != null) {
            dVar2.b(getAppDownloadListener());
        }
        setClickable(true);
        new h(this, this);
        new h(this.FF, this);
    }

    private void lK() {
        String strAF = com.kwad.sdk.core.response.helper.a.aF(this.mAdInfo);
        boolean z = !TextUtils.isEmpty(strAF);
        float fAG = com.kwad.sdk.core.response.helper.a.aG(this.mAdInfo);
        boolean z2 = fAG >= 3.0f;
        if (z && z2) {
            ((LinearLayout.LayoutParams) this.eq.getLayoutParams()).bottomMargin = com.kwad.sdk.c.a.a.a(getContext(), 1.0f);
            ((LinearLayout.LayoutParams) this.FD.getLayoutParams()).bottomMargin = com.kwad.sdk.c.a.a.a(getContext(), 1.0f);
            this.gK.setText(strAF);
            this.gK.setVisibility(0);
            this.FD.setVisibility(0);
            this.FD.setScore(fAG);
            this.hS.setVisibility(8);
            return;
        }
        if (z) {
            this.gK.setText(strAF);
            this.gK.setVisibility(0);
            this.FD.setVisibility(8);
            this.hS.setVisibility(8);
            return;
        }
        if (z2) {
            this.gK.setVisibility(8);
            this.FD.setScore(fAG);
            this.FD.setVisibility(0);
            this.hS.setVisibility(8);
            return;
        }
        this.hS.setText(com.kwad.sdk.core.response.helper.a.aA(this.mAdInfo));
        this.gK.setVisibility(8);
        this.FD.setVisibility(8);
        this.hS.setVisibility(0);
    }

    private KsAppDownloadListener getAppDownloadListener() {
        if (this.ei == null) {
            this.ei = new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.ad.reward.widget.actionbar.ActionBarAppPortrait.1
                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onIdle() {
                    ActionBarAppPortrait.this.FE.e(com.kwad.sdk.core.response.helper.a.aK(ActionBarAppPortrait.this.mAdInfo), 0);
                    ActionBarAppPortrait.this.FF.setVisibility(0);
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onProgressUpdate(int i) {
                    ActionBarAppPortrait.this.FE.e(com.kwad.sdk.core.response.helper.a.ev(i), i);
                    ActionBarAppPortrait.this.FF.setVisibility(8);
                }

                @Override // com.kwad.sdk.core.download.a.a
                public final void onPaused(int i) {
                    ActionBarAppPortrait.this.FE.e(com.kwad.sdk.core.response.helper.a.ew(i), i);
                    ActionBarAppPortrait.this.FF.setVisibility(8);
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onDownloadFinished() {
                    ActionBarAppPortrait.this.FE.e(com.kwad.sdk.core.response.helper.a.cF(ActionBarAppPortrait.this.mAdTemplate), 0);
                    ActionBarAppPortrait.this.FF.setVisibility(0);
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onDownloadFailed() {
                    ActionBarAppPortrait.this.FE.e(com.kwad.sdk.core.response.helper.a.aK(ActionBarAppPortrait.this.mAdInfo), 0);
                    ActionBarAppPortrait.this.FF.setVisibility(0);
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onInstalled() {
                    ActionBarAppPortrait.this.FE.e(com.kwad.sdk.core.response.helper.a.af(ActionBarAppPortrait.this.mAdInfo), 0);
                    ActionBarAppPortrait.this.FF.setVisibility(0);
                }
            };
        }
        return this.ei;
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        d(view, true);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (SlideConvertHelper.a(this.mAdTemplate, f, f2, f3, f4)) {
            d(view, false);
        }
    }

    private void d(View view, final boolean z) {
        int i = view == this.FF ? 1 : 2;
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(view.getContext()).aF(this.mAdTemplate).b(this.mApkDownloadHelper).aB(1).aC(i).as(view == this.FE).aD(i).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.reward.widget.actionbar.ActionBarAppPortrait.2
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                if (ActionBarAppPortrait.this.FI != null) {
                    ActionBarAppPortrait.this.FI.P(z);
                }
            }
        }));
    }
}
