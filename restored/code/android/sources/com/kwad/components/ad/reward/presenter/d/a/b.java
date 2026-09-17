package com.kwad.components.ad.reward.presenter.d.a;

import android.graphics.drawable.Drawable;
import android.view.ViewGroup;
import android.view.ViewStub;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.reward.e.l;
import com.kwad.components.ad.reward.g;
import com.kwad.components.ad.reward.monitor.d;
import com.kwad.components.ad.reward.n.k;
import com.kwad.components.ad.reward.widget.tailframe.TailFrameView;
import com.kwad.components.core.video.DetailVideoView;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.reward.presenter.b implements as.b {
    private com.kwad.components.ad.l.b dR;
    private AdInfo mAdInfo;
    private DetailVideoView mDetailVideoView;
    private TailFrameView zQ;
    private volatile boolean zR;
    private boolean zS;
    private k zT;
    private Drawable zW;
    private boolean xd = false;
    private int zU = Integer.MIN_VALUE;
    private int zV = Integer.MIN_VALUE;
    private final l mRewardVerifyListener = new l() { // from class: com.kwad.components.ad.reward.presenter.d.a.b.1
        @Override // com.kwad.components.ad.reward.e.l
        public final void onRewardVerify() {
            b.this.jR();
            if (b.this.zQ == null || !g.P(b.this.mAdTemplate)) {
                return;
            }
            b.this.zQ.lu();
        }
    };
    private com.kwad.components.ad.reward.e.g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.d.a.b.2
        @Override // com.kwad.components.ad.reward.e.a, com.kwad.components.ad.reward.e.g
        public final int getPriority() {
            return -1;
        }

        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            if ((!e.eZ(b.this.mAdTemplate) && b.this.xd && !b.this.ub.ha()) || b.this.ub.sT || b.this.ub.sZ) {
                return;
            }
            b.this.zS = true;
            if (b.this.dR != null && b.this.dR.aY()) {
                b.this.zS = false;
            }
            b.this.ub.tk = true ^ b.this.zS;
            if (b.this.zS) {
                if (b.this.ub.su != null) {
                    d.a(b.this.ub.mAdTemplate, b.this.ub.sG, "end_card", com.kwad.sdk.core.response.helper.b.de(b.this.mAdTemplate), System.currentTimeMillis() - b.this.ub.su.getLoadTime(), 1);
                }
                b.this.bp();
            }
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.zQ = (TailFrameView) findViewById(R.id.ksad_video_tail_frame);
        DetailVideoView detailVideoView = (DetailVideoView) findViewById(R.id.ksad_video_player);
        this.mDetailVideoView = detailVideoView;
        if (detailVideoView.getLayoutTransition() != null) {
            this.mDetailVideoView.getLayoutTransition().enableTransitionType(4);
        }
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.ub.ss != null) {
            this.ub.ss.a(this);
        }
        this.mAdInfo = e.eM(this.mAdTemplate);
        this.dR = this.ub.su;
        this.ub.b(this.mPlayEndPageListener);
        com.kwad.components.ad.reward.b.gu().a(this.mRewardVerifyListener);
        this.zQ.setCallerContext(this.ub);
        ViewStub viewStub = (ViewStub) findViewById(R.id.ksad_playend_native_jinniu);
        if (viewStub != null) {
            this.zT = new k(this.ub, viewStub);
        } else {
            this.zT = new k(this.ub, (ViewGroup) findViewById(R.id.ksad_reward_jinniu_end_card_root));
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void jR() {
        if (this.zR) {
            return;
        }
        jS();
    }

    private void jS() {
        com.kwad.sdk.core.d.c.d("RewardPlayEndNativeCardPresenter", "initTailView");
        this.zQ.a(getContext(), this.ub.mScreenOrientation == 0, jU());
        this.zR = true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        if (this.ub.ss != null) {
            this.ub.ss.b(this);
        }
        com.kwad.components.ad.reward.b.gu().b(this.mRewardVerifyListener);
        jT();
        this.ub.c(this.mPlayEndPageListener);
        DetailVideoView detailVideoView = this.mDetailVideoView;
        if (detailVideoView != null) {
            int i = this.zV;
            if (i != Integer.MIN_VALUE) {
                detailVideoView.updateTextureViewGravity(i);
            }
            com.kwad.sdk.core.d.c.d("RewardPlayEndNativeCardPresenter", "onUnbind:  videoOriginalWidth :" + this.zU);
            int i2 = this.zU;
            if (i2 != Integer.MIN_VALUE) {
                ad(i2);
            }
            Drawable drawable = this.zW;
            if (drawable != null) {
                this.mDetailVideoView.setBackground(drawable);
            }
        }
    }

    private void ad(int i) {
        ViewGroup.LayoutParams layoutParams = this.mDetailVideoView.getLayoutParams();
        if (layoutParams != null) {
            layoutParams.width = i;
            this.mDetailVideoView.setLayoutParams(layoutParams);
        }
    }

    private void jT() {
        if (this.zS) {
            jR();
            this.zQ.destroy();
            this.zQ.setVisibility(8);
            this.zT.hide();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bp() {
        jR();
        this.zQ.a(new com.kwad.components.ad.reward.widget.tailframe.b() { // from class: com.kwad.components.ad.reward.presenter.d.a.b.3
            @Override // com.kwad.components.ad.reward.widget.tailframe.b
            public final void P(boolean z) {
                b.this.M(z);
            }
        });
        this.zQ.setVisibility(0);
    }

    private boolean jU() {
        AdInfo.AdMaterialInfo.MaterialFeature materialFeatureBd = com.kwad.sdk.core.response.helper.a.bd(this.mAdInfo);
        return materialFeatureBd.height > materialFeatureBd.width;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void M(boolean z) {
        com.kwad.components.ad.reward.j.b.a(this.mAdTemplate, "native_id", (String) null, new com.kwad.sdk.core.adlog.c.b().f(this.ub.mRootContainer.getTouchCoords()).dS(z ? 2 : MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT), this.ub.mReportExtData);
        this.ub.sq.cY();
    }

    @Override // com.kwad.components.core.webview.jshandler.as.b
    public final void a(as.a aVar) {
        this.xd = aVar.isSuccess();
    }
}
