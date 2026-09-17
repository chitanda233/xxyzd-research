package com.kwad.components.ad.reward.presenter;

import android.view.ViewGroup;
import android.widget.FrameLayout;
import android.widget.ImageView;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.utils.as;

/* JADX INFO: loaded from: classes3.dex */
public final class v extends b {
    private DetailVideoView xL;
    private ViewGroup xM;
    private FrameLayout xN;
    private ImageView xO;
    private ViewGroup.LayoutParams xP = null;
    private com.kwad.components.core.video.m jX = new com.kwad.components.core.video.m() { // from class: com.kwad.components.ad.reward.presenter.v.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            super.onMediaPlayStart();
            v.this.xL.postDelayed(new Runnable() { // from class: com.kwad.components.ad.reward.presenter.v.1.1
                @Override // java.lang.Runnable
                public final void run() {
                    v.this.xL.setVisibility(0);
                }
            }, 200L);
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.xL = (DetailVideoView) findViewById(R.id.ksad_video_player);
        this.xM = (ViewGroup) findViewById(R.id.ksad_play_right_area);
        this.xO = (ImageView) findViewById(R.id.ksad_play_right_area_bg_img);
        this.xN = (FrameLayout) findViewById(R.id.ksad_play_right_area_container);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        jf();
        ViewGroup.LayoutParams layoutParams = this.xL.getLayoutParams();
        if (layoutParams != null) {
            this.xP = new ViewGroup.LayoutParams(layoutParams);
        }
        this.ub.sr.a(this.jX);
        jg();
    }

    private void jf() {
    }

    private void jg() {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate);
        getContext();
        boolean z = !as.VV();
        boolean zBQ = com.kwad.sdk.core.response.helper.a.bQ(adInfoEM);
        boolean z2 = com.kwad.sdk.core.response.helper.a.cQ(adInfoEM) && com.kwad.components.ad.reward.a.b.hW();
        boolean z3 = com.kwad.components.ad.reward.g.N(this.ub.mAdTemplate) || com.kwad.components.ad.reward.g.O(this.ub.mAdTemplate) || zBQ || z2;
        if (z && z3) {
            this.xM.setVisibility(z2 ? 4 : 0);
            if (zBQ) {
                this.xO.setVisibility(8);
                ac(R.layout.ksad_playable_end_info);
            } else {
                ac(R.layout.ksad_activity_apk_info_landscape);
            }
            if (!com.kwad.sdk.core.response.helper.a.be(adInfoEM)) {
                this.xL.updateTextureViewGravity(17);
                return;
            } else {
                this.xL.updateTextureViewGravity(21);
                return;
            }
        }
        this.xM.setVisibility(8);
    }

    private void ac(int i) {
        this.xN.addView(com.kwad.sdk.wrapper.m.a(getContext(), i, this.xN, false), -1, -1);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        DetailVideoView detailVideoView;
        super.onUnbind();
        this.ub.sr.b(this.jX);
        if (this.xP == null || (detailVideoView = this.xL) == null) {
            return;
        }
        ViewGroup.LayoutParams layoutParams = detailVideoView.getLayoutParams();
        if (layoutParams != null) {
            layoutParams.width = this.xP.width;
            layoutParams.height = this.xP.height;
            this.xL.setLayoutParams(layoutParams);
        }
        DetailVideoView detailVideoView2 = this.xL;
        if (detailVideoView2 != null) {
            detailVideoView2.setVisibility(4);
        }
        this.xP = null;
    }
}
