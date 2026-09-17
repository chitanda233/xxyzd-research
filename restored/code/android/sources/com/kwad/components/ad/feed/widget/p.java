package com.kwad.components.ad.feed.widget;

import android.content.Context;
import android.os.SystemClock;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.widget.DownloadProgressView;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.page.widget.RoundAngleImageView;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.widget.RatioFrameLayout;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class p extends a implements View.OnClickListener, com.kwad.sdk.widget.d {
    private TextView hO;
    private ImageView hQ;
    private DownloadProgressView hV;
    private RoundAngleImageView iI;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private KsLogoView mLogoView;

    public p(Context context) {
        super(context);
    }

    @Override // com.kwad.components.core.widget.b
    public final void by() {
        this.hO = (TextView) findViewById(R.id.ksad_ad_desc);
        ((RatioFrameLayout) findViewById(R.id.ksad_image_container)).setRatio(0.6600000262260437d);
        RoundAngleImageView roundAngleImageView = (RoundAngleImageView) findViewById(R.id.ksad_ad_image);
        this.iI = roundAngleImageView;
        roundAngleImageView.setRadius(com.kwad.sdk.c.a.a.a(getContext(), 3.0f));
        this.hQ = (ImageView) findViewById(R.id.ksad_ad_dislike);
        this.hV = (DownloadProgressView) findViewById(R.id.ksad_app_download_btn);
        this.mLogoView = (KsLogoView) findViewById(R.id.ksad_feed_logo);
    }

    @Override // com.kwad.components.core.widget.b
    public final int getLayoutId() {
        return R.layout.ksad_feed_text_right_image;
    }

    private void cp() {
        this.mLogoView.bh(this.mAdTemplate);
        this.hV.aw(this.mAdTemplate);
        this.hV.setOnClickListener(this);
        new com.kwad.sdk.widget.h(getContext(), this.hV, this);
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            com.kwad.components.core.e.d.d dVar = new com.kwad.components.core.e.d.d(this.mAdTemplate, null, this.hV.getAppDownloadListener());
            this.mApkDownloadHelper = dVar;
            dVar.d(this.hV.getAppDownloadListener());
            this.mApkDownloadHelper.setOnShowListener(this);
            this.mApkDownloadHelper.setOnDismissListener(this);
            cm();
        }
    }

    @Override // com.kwad.components.core.widget.b
    public final void d(AdResultData adResultData) {
        super.d(adResultData);
        this.hO.setText(com.kwad.components.ad.feed.f.l(this.mAdTemplate));
        List<String> listBg = com.kwad.sdk.core.response.helper.a.bg(this.mAdInfo);
        if (listBg.size() > 0) {
            this.hH = SystemClock.elapsedRealtime();
            KSImageLoader.loadFeeImage(this.iI, listBg.get(0), this.mAdTemplate, this.hM);
        } else {
            com.kwad.sdk.core.d.c.e("FeedTextRightImageView", "getImageUrlList size less than one");
        }
        cp();
        com.kwad.sdk.c.a.a.a(this, this.hO, this.iI, this.hV, this.hQ);
        new com.kwad.sdk.widget.h(getContext(), this.hO, this);
        new com.kwad.sdk.widget.h(getContext(), this.iI, this);
        new com.kwad.sdk.widget.h(getContext(), this.hV, this);
        new com.kwad.sdk.widget.h(getContext(), this.hQ, this);
        setOnClickListener(this);
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
            d(view, MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT);
        }
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        int i;
        if (view == this.hO) {
            i = 25;
        } else if (view == this.iI) {
            i = 100;
        } else {
            i = view == this.hV ? 1 : 35;
        }
        d(view, i);
    }

    private void d(View view, final int i) {
        if (view == this.hQ) {
            Aa();
        } else {
            com.kwad.components.core.e.d.a.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.mAdTemplate).aB(5).aC(i).b(this.mApkDownloadHelper).aD(view == this.hV ? 1 : 2).as(view == this.hV).a(new com.kwad.components.core.e.d.a.b() { // from class: com.kwad.components.ad.feed.widget.p.1
                @Override // com.kwad.components.core.e.d.a.b
                public final void onAdClicked() {
                    p.this.bO(i);
                }
            }));
        }
    }
}
