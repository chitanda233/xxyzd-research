package com.kwad.components.ad.feed.widget;

import android.content.Context;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.feed.FeedDownloadActivityProxy;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.widget.RatioFrameLayout;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class n extends a implements View.OnClickListener, com.kwad.sdk.widget.d {
    private TextView hO;
    private ImageView hP;
    private ImageView hQ;
    private KsLogoView mLogoView;

    public n(Context context) {
        super(context);
    }

    @Override // com.kwad.components.core.widget.b
    public final void by() {
        ((RatioFrameLayout) findViewById(R.id.ksad_container)).setRatio(0.5600000023841858d);
        this.hO = (TextView) findViewById(R.id.ksad_ad_desc);
        this.hP = (ImageView) findViewById(R.id.ksad_ad_image);
        this.hQ = (ImageView) findViewById(R.id.ksad_ad_dislike);
        this.mLogoView = (KsLogoView) findViewById(R.id.ksad_feed_logo);
    }

    @Override // com.kwad.components.core.widget.b
    public final int getLayoutId() {
        return R.layout.ksad_feed_text_immerse_image;
    }

    @Override // com.kwad.components.core.widget.b
    public final void d(AdResultData adResultData) {
        super.d(adResultData);
        this.hO.setText(com.kwad.components.ad.feed.f.l(this.mAdTemplate));
        List<String> listBg = com.kwad.sdk.core.response.helper.a.bg(this.mAdInfo);
        this.mLogoView.bh(this.mAdTemplate);
        if (listBg.size() > 0) {
            KSImageLoader.loadFeeImage(this.hP, listBg.get(0), this.mAdTemplate);
        } else {
            com.kwad.sdk.core.d.c.e("FeedTextImmerseImageView", "getImageUrlList size less than one");
        }
        com.kwad.sdk.c.a.a.a(this, this.hO, this.hP, this.hQ);
        new com.kwad.sdk.widget.h(getContext(), this.hO, this);
        new com.kwad.sdk.widget.h(getContext(), this.hP, this);
        new com.kwad.sdk.widget.h(getContext(), this.hQ, this);
        setOnClickListener(this);
        if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            cm();
        }
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
        } else {
            i = view == this.hP ? 100 : 35;
        }
        d(view, i);
    }

    private void d(View view, int i) {
        if (view == this.hQ) {
            Aa();
            return;
        }
        if (com.kwad.components.core.e.d.e.a(new com.kwad.components.core.e.d.a.C0428a(getContext()).aF(this.mAdTemplate), 1) == 1) {
            bO(i);
        } else if (com.kwad.sdk.core.response.helper.a.aL(this.mAdInfo)) {
            bO(i);
            FeedDownloadActivityProxy.launch(this.mContext, this.mAdTemplate, this.avu);
        } else {
            bO(i);
            AdWebViewActivityProxy.launch(getContext(), this.mAdTemplate);
        }
    }
}
