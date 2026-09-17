package com.kwad.components.ad.draw.view.playcard;

import android.animation.ValueAnimator;
import android.content.Context;
import android.text.TextUtils;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.DecelerateInterpolator;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.draw.view.DrawDownloadProgressBar;
import com.kwad.components.ad.widget.AppScoreView;
import com.kwad.components.core.e.d.d;
import com.kwad.components.core.t.x;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.wrapper.m;

/* JADX INFO: loaded from: classes3.dex */
public class DrawCardApp extends FrameLayout implements View.OnClickListener {
    private KsAppDownloadListener ei;
    private a go;
    private ImageView gp;
    private ImageView gq;
    private TextView gr;
    private ViewGroup gs;
    private AppScoreView gt;
    private TextView gu;
    private TextView gv;
    private KsLogoView gw;
    private DrawDownloadProgressBar gx;
    private ValueAnimator gy;
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;
    private d mApkDownloadHelper;
    private int mHeight;

    public interface a {
        void bc();

        void bd();
    }

    public DrawCardApp(Context context) {
        super(context);
        B(context);
    }

    public DrawCardApp(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        B(context);
    }

    public DrawCardApp(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        B(context);
    }

    private void B(Context context) {
        m.inflate(context, R.layout.ksad_draw_card_app, this);
        this.gp = (ImageView) findViewById(R.id.ksad_card_app_close);
        this.gq = (ImageView) findViewById(R.id.ksad_card_app_icon);
        this.gr = (TextView) findViewById(R.id.ksad_card_app_name);
        this.gs = (ViewGroup) findViewById(R.id.ksad_card_app_score_container);
        this.gt = (AppScoreView) findViewById(R.id.ksad_card_app_score);
        this.gu = (TextView) findViewById(R.id.ksad_card_app_download_count);
        this.gv = (TextView) findViewById(R.id.ksad_card_app_desc);
        this.gw = (KsLogoView) findViewById(R.id.ksad_card_logo);
        DrawDownloadProgressBar drawDownloadProgressBar = (DrawDownloadProgressBar) findViewById(R.id.ksad_card_app_download_btn);
        this.gx = drawDownloadProgressBar;
        drawDownloadProgressBar.setTextSize(16);
        this.mHeight = com.kwad.sdk.c.a.a.a(context, 156.0f);
    }

    public final void a(AdTemplate adTemplate, a aVar) {
        this.mAdTemplate = adTemplate;
        this.mAdInfo = e.eM(adTemplate);
        this.go = aVar;
        this.mApkDownloadHelper = new d(this.mAdTemplate, getAppDownloadListener());
        KSImageLoader.loadAppIcon(this.gq, com.kwad.sdk.core.response.helper.a.cv(this.mAdInfo), adTemplate, 11);
        this.gr.setText(com.kwad.sdk.core.response.helper.a.aB(this.mAdInfo));
        String strAF = com.kwad.sdk.core.response.helper.a.aF(this.mAdInfo);
        float fAG = com.kwad.sdk.core.response.helper.a.aG(this.mAdInfo);
        boolean z = fAG >= 3.0f;
        if (z) {
            this.gt.setScore(fAG);
            this.gt.setVisibility(0);
        }
        boolean z2 = !TextUtils.isEmpty(strAF);
        if (z2) {
            this.gu.setText(strAF);
            this.gu.setVisibility(0);
        }
        if (z || z2) {
            this.gs.setVisibility(0);
        } else {
            this.gs.setVisibility(8);
        }
        this.gw.bh(this.mAdTemplate);
        this.gv.setText(com.kwad.sdk.core.response.helper.a.aA(this.mAdInfo));
        this.gp.setOnClickListener(this);
        this.gx.setOnClickListener(this);
        setOnClickListener(this);
    }

    private KsAppDownloadListener getAppDownloadListener() {
        if (this.ei == null) {
            this.ei = new com.kwad.sdk.core.download.a.a() { // from class: com.kwad.components.ad.draw.view.playcard.DrawCardApp.1
                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onIdle() {
                    DrawCardApp.this.gx.e(com.kwad.sdk.core.response.helper.a.aK(DrawCardApp.this.mAdInfo), DrawCardApp.this.gx.getMax());
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onProgressUpdate(int i) {
                    DrawCardApp.this.gx.e(i + "%", i);
                }

                @Override // com.kwad.sdk.core.download.a.a
                public final void onPaused(int i) {
                    super.onPaused(i);
                    DrawCardApp.this.gx.e(com.kwad.sdk.core.response.helper.a.NH(), i);
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onDownloadFinished() {
                    DrawCardApp.this.gx.e(com.kwad.sdk.core.response.helper.a.cF(DrawCardApp.this.mAdTemplate), DrawCardApp.this.gx.getMax());
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onDownloadFailed() {
                    DrawCardApp.this.gx.e(com.kwad.sdk.core.response.helper.a.aK(DrawCardApp.this.mAdInfo), DrawCardApp.this.gx.getMax());
                }

                @Override // com.kwad.sdk.api.KsAppDownloadListener
                public final void onInstalled() {
                    DrawCardApp.this.gx.e(com.kwad.sdk.core.response.helper.a.af(DrawCardApp.this.mAdInfo), DrawCardApp.this.gx.getMax());
                }
            };
        }
        return this.ei;
    }

    public final void release() {
        bn();
        this.mApkDownloadHelper = null;
    }

    public final void bV() {
        d(0, this.mHeight);
    }

    private void bW() {
        d(this.mHeight, 0);
    }

    private void d(int i, int i2) {
        bn();
        ValueAnimator valueAnimatorB = x.b(this, i, i2);
        this.gy = valueAnimatorB;
        valueAnimatorB.setInterpolator(new DecelerateInterpolator(2.0f));
        this.gy.setDuration(300L);
        this.gy.start();
    }

    private void bn() {
        ValueAnimator valueAnimator = this.gy;
        if (valueAnimator != null) {
            valueAnimator.removeAllListeners();
            this.gy.cancel();
        }
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        if (view == this.gp) {
            bW();
            a aVar = this.go;
            if (aVar != null) {
                aVar.bc();
                return;
            }
            return;
        }
        com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.mAdTemplate).b(this.mApkDownloadHelper).as(view == this.gx).aD(view == this.gx ? 1 : 2).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.draw.view.playcard.DrawCardApp.2
            @Override // com.kwad.components.core.e.d.a.b
            public final void onAdClicked() {
                if (DrawCardApp.this.go != null) {
                    DrawCardApp.this.go.bd();
                }
            }
        }));
    }
}
