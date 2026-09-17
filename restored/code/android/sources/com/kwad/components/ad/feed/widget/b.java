package com.kwad.components.ad.feed.widget;

import android.content.Context;
import android.os.SystemClock;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.widget.DownloadProgressView;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.components.model.FeedType;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.widget.RatioFrameLayout;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public abstract class b extends a implements View.OnClickListener, com.kwad.sdk.widget.d {
    protected TextView eq;
    protected ImageView gI;
    protected TextView gP;
    protected TextView hO;
    protected ImageView hP;
    protected ImageView hQ;
    protected RatioFrameLayout hR;
    protected TextView hS;
    protected TextView hT;
    protected View hU;
    protected DownloadProgressView hV;
    protected boolean hW;
    protected int hX;
    protected com.kwad.components.core.e.d.d mApkDownloadHelper;
    protected KsLogoView mLogoView;

    protected int getDefaultClickArea() {
        return 2;
    }

    public b(Context context) {
        super(context);
        this.hW = true;
        this.hX = 8;
    }

    @Override // com.kwad.components.core.widget.b
    public void by() {
        this.hO = (TextView) findViewById(R.id.ksad_ad_desc);
        RatioFrameLayout ratioFrameLayout = (RatioFrameLayout) findViewById(R.id.ksad_image_container);
        this.hR = ratioFrameLayout;
        ratioFrameLayout.setRatio(0.5600000023841858d);
        this.hP = (ImageView) findViewById(R.id.ksad_ad_image);
        this.hQ = (ImageView) findViewById(R.id.ksad_ad_dislike);
        this.mLogoView = (KsLogoView) findViewById(R.id.ksad_ad_dislike_logo);
        this.hV = (DownloadProgressView) findViewById(R.id.ksad_app_download_btn);
    }

    @Override // com.kwad.components.core.widget.b
    public final void d(AdResultData adResultData) {
        super.d(adResultData);
        this.hO.setText(com.kwad.components.ad.feed.f.l(this.mAdTemplate));
        this.mLogoView.bh(this.mAdTemplate);
        cn();
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            findViewById(R.id.ksad_ad_download_container).setVisibility(0);
            findViewById(R.id.ksad_ad_h5_container).setVisibility(8);
            cp();
            cr();
        } else {
            findViewById(R.id.ksad_ad_h5_container).setVisibility(0);
            findViewById(R.id.ksad_ad_download_container).setVisibility(8);
            if (cq()) {
                cp();
            }
            co();
        }
        com.kwad.sdk.c.a.a.a(this, this.hO, this.hP, this.hQ);
        new com.kwad.sdk.widget.h(getContext(), this.hO, this);
        new com.kwad.sdk.widget.h(getContext(), this.hP, this);
        new com.kwad.sdk.widget.h(getContext(), this.hQ, this);
        setOnClickListener(this);
    }

    public void cn() {
        this.hP.post(new bi() { // from class: com.kwad.components.ad.feed.widget.b.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(b.this.mAdTemplate);
                if (com.kwad.sdk.core.response.helper.a.ba(adInfoEM).height > com.kwad.sdk.core.response.helper.a.ba(adInfoEM).width) {
                    ViewGroup.LayoutParams layoutParams = b.this.hR.getLayoutParams();
                    layoutParams.width = b.this.getWidth() / 2;
                    b.this.hR.setRatio(1.7857142686843872d);
                    b.this.hR.setLayoutParams(layoutParams);
                }
                List<String> listBg = com.kwad.sdk.core.response.helper.a.bg(b.this.mAdInfo);
                if (listBg.size() > 0) {
                    b.this.hH = SystemClock.elapsedRealtime();
                    KSImageLoader.loadFeeImage(b.this.hP, listBg.get(0), b.this.mAdTemplate, b.this.hM);
                    return;
                }
                com.kwad.sdk.core.d.c.e("BaseFeedTextImageView", "getImageUrlList size less than one");
            }
        });
    }

    private void co() {
        this.hT = (TextView) findViewById(R.id.ksad_h5_desc);
        this.gP = (TextView) findViewById(R.id.ksad_h5_open_btn);
        this.hU = findViewById(R.id.ksad_h5_open_cover);
        this.hT.setText(com.kwad.components.ad.feed.f.l(this.mAdTemplate));
        this.gP.setText(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo));
        this.hU.setOnClickListener(this);
        this.hT.setOnClickListener(this);
        this.gP.setOnClickListener(this);
        new com.kwad.sdk.widget.h(getContext(), this.hU, this);
        new com.kwad.sdk.widget.h(getContext(), this.hT, this);
        new com.kwad.sdk.widget.h(getContext(), this.gP, this);
    }

    private void cp() {
        this.gI = (ImageView) findViewById(R.id.ksad_app_icon);
        this.eq = (TextView) findViewById(R.id.ksad_app_title);
        TextView textView = (TextView) findViewById(R.id.ksad_app_desc);
        this.hS = textView;
        com.kwad.sdk.c.a.a.a(this, this.gI, this.eq, textView);
        new com.kwad.sdk.widget.h(getContext(), this.gI, this);
        new com.kwad.sdk.widget.h(getContext(), this.eq, this);
        new com.kwad.sdk.widget.h(getContext(), this.hS, this);
        if (cq()) {
            this.eq.setText(com.kwad.sdk.core.response.helper.a.cs(this.mAdInfo));
        } else {
            this.eq.setText(com.kwad.sdk.core.response.helper.a.aB(this.mAdInfo));
        }
        this.gI.setImageResource(R.drawable.ksad_default_app_icon);
        KSImageLoader.loadAppIcon(this.gI, com.kwad.sdk.core.response.helper.a.cv(this.mAdInfo), this.mAdTemplate, this.hX);
        this.hS.setText(com.kwad.components.ad.feed.f.l(this.mAdTemplate));
        if (this.hW) {
            cm();
        }
    }

    private boolean cq() {
        if (FeedType.isNewVerticalType(com.kwad.sdk.core.response.helper.e.fh(this.mAdTemplate))) {
            return com.kwad.sdk.core.response.helper.e.fi(this.mAdTemplate) == FeedType.FeedDefaultType.FEED_VERTICAL_NOVEL_DEFAULT.getDefaultType() || com.kwad.sdk.core.response.helper.e.fi(this.mAdTemplate) == FeedType.FeedDefaultType.FEED_VERTICAL_BISERIAL_DEFAULT.getDefaultType();
        }
        return false;
    }

    private void cr() {
        this.hV.aw(this.mAdTemplate);
        this.hV.setOnClickListener(this);
        com.kwad.components.core.e.d.d dVar = new com.kwad.components.core.e.d.d(this.mAdTemplate, null, this.hV.getAppDownloadListener());
        this.mApkDownloadHelper = dVar;
        dVar.d(this.hV.getAppDownloadListener());
        this.mApkDownloadHelper.setOnShowListener(this);
        this.mApkDownloadHelper.setOnDismissListener(this);
        new com.kwad.sdk.widget.h(getContext(), this.hV, this);
    }

    @Override // com.kwad.components.core.widget.b
    public final void cs() {
        super.cs();
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar != null) {
            dVar.c(this.hV.getAppDownloadListener());
        }
    }

    @Override // com.kwad.components.core.widget.b, com.kwad.sdk.widget.KSFrameLayout
    public final void ae() {
        DownloadProgressView downloadProgressView;
        super.ae();
        com.kwad.components.core.e.d.d dVar = this.mApkDownloadHelper;
        if (dVar == null || (downloadProgressView = this.hV) == null) {
            return;
        }
        dVar.b(downloadProgressView.getAppDownloadListener());
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        onClick(view);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (com.kwad.sdk.core.response.helper.d.eB(this.mAdTemplate)) {
            b(view, MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT);
        }
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        int i;
        if (view == this.hO) {
            i = 25;
        } else if (view == this.hP) {
            i = 100;
        } else if (view == this.hV || view == this.gP || view == this.hU) {
            i = 1;
        } else if (view == this.gI) {
            i = 13;
        } else if (view == this.eq) {
            i = 14;
        } else {
            i = (view == this.hS || view == this.hT) ? 101 : 35;
        }
        b(view, i);
    }

    private void b(View view, final int i) {
        if (view == this.hQ) {
            Aa();
        } else {
            cl();
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.mAdTemplate).aB(5).aC(i).b(this.mApkDownloadHelper).aD((view == this.hV || view == this.gP || view == this.hU) ? 1 : getDefaultClickArea()).as(view == this.hV).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.b.2
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    b.this.bO(i);
                }
            }));
        }
    }

    public void setmIsShowComplianceView(boolean z) {
        this.hW = z;
    }

    public void setRadiusDp(int i) {
        this.hX = i;
    }
}
