package com.kwad.components.ad.reward.presenter.g;

import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewStub;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.reward.e.l;
import com.kwad.components.ad.reward.g;
import com.kwad.components.ad.reward.n.c;
import com.kwad.components.ad.reward.n.e;
import com.kwad.components.ad.reward.n.f;
import com.kwad.components.ad.reward.n.q;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.utils.ae;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.widget.d;
import com.kwad.sdk.widget.h;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.reward.presenter.b implements c.a, com.kwad.sdk.app.a, com.kwad.sdk.core.webview.d.a.a, d {
    private static float Be = 0.4548105f;
    private ViewGroup AX;
    private q AY;
    private ViewGroup AZ;
    private e Ba;
    private c Bb;
    private c Bc;
    private AdInfo mAdInfo;
    private com.kwad.components.ad.reward.l.b.a ta;
    private int Bf = 15;
    private long Bg = -1;
    private boolean Bh = false;
    private final l mRewardVerifyListener = new l() { // from class: com.kwad.components.ad.reward.presenter.g.b.3
        @Override // com.kwad.components.ad.reward.e.l
        public final void onRewardVerify() {
            if (b.this.Bb != null && g.P(b.this.ub.mAdTemplate)) {
                b.this.Bb.lu();
            }
            if (b.this.Bc != null) {
                b.this.Bc.lu();
            }
        }
    };
    private com.kwad.sdk.core.c.c Bi = new com.kwad.sdk.core.c.d() { // from class: com.kwad.components.ad.reward.presenter.g.b.4
        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
        public final void onBackToForeground() {
            super.onBackToForeground();
            b.this.Y(true);
        }

        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
        public final void onBackToBackground() {
            super.onBackToBackground();
            b.this.Y(false);
        }
    };

    @Override // com.kwad.sdk.app.a
    public final void U(String str) {
    }

    @Override // com.kwad.sdk.core.webview.d.a.a
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.sdk.core.d.c.d("LaunchAppTaskPresenter", "onBind");
        if (g.N(this.ub.mAdTemplate)) {
            this.mAdInfo = com.kwad.sdk.core.response.helper.e.eM(this.ub.mAdTemplate);
            this.Bf = com.kwad.components.ad.reward.a.b.hL();
            com.kwad.sdk.core.c.b.Mh();
            com.kwad.sdk.core.c.b.a(this.Bi);
            com.kwad.components.ad.reward.b.gu().a(this.mRewardVerifyListener);
            this.ta = com.kwad.components.ad.reward.l.d.lc();
            this.ub.ta = this.ta;
            com.kwad.components.ad.reward.l.b.a.a(this.ta, getContext(), this.ub.mAdTemplate);
            AdBaseFrameLayout adBaseFrameLayout = (AdBaseFrameLayout) findViewById(R.id.ksad_root_container);
            ViewGroup viewGroup = (ViewGroup) findViewById(R.id.ksad_activity_apk_info_area_native);
            this.AX = viewGroup;
            if (viewGroup != null) {
                viewGroup.setVisibility(8);
                c cVar = new c(this.AX);
                this.Bc = cVar;
                cVar.a(this.ub.mApkDownloadHelper);
                this.Bc.a(this);
                this.Bc.c(this.ub.mAdTemplate, false);
                ((KSFrameLayout) findViewById(R.id.ksad_right_area_webview_container)).setWidthBasedRatio(false);
                q qVar = new q((KsAdWebView) findViewById(R.id.ksad_right_area_webview), this.AX, this.ub.mApkDownloadHelper, this);
                this.AY = qVar;
                qVar.a(this.ub.mAdTemplate, adBaseFrameLayout);
            }
            com.kwad.sdk.app.b.Ia().a(this);
            a(adBaseFrameLayout);
        }
    }

    private void a(AdBaseFrameLayout adBaseFrameLayout) {
        getContext();
        if (!as.VV()) {
            com.kwad.sdk.core.d.c.d("LaunchAppTaskPresenter", "initBottomActionBar screen is horizontal");
            return;
        }
        ((ViewStub) findViewById(R.id.ksad_reward_apk_info_stub)).inflate();
        ViewGroup viewGroup = (ViewGroup) findViewById(R.id.ksad_reward_apk_info_card_native_container);
        this.AZ = viewGroup;
        viewGroup.setClickable(true);
        new h(this.AZ, this);
        final KSFrameLayout kSFrameLayout = (KSFrameLayout) findViewById(R.id.ksad_reward_apk_info_card_root);
        kSFrameLayout.setRadius(getContext().getResources().getDimension(R.dimen.ksad_reward_apk_info_card_step_icon_radius));
        final float dimension = getContext().getResources().getDimension(R.dimen.ksad_reward_apk_info_card_height);
        kSFrameLayout.post(new bi() { // from class: com.kwad.components.ad.reward.presenter.g.b.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                kSFrameLayout.getHeight();
            }
        });
        this.AZ = (ViewGroup) findViewById(R.id.ksad_reward_apk_info_card_native_container);
        c cVar = new c(this.AZ);
        this.Bb = cVar;
        cVar.a(this.ub.mApkDownloadHelper);
        this.Bb.a(this);
        this.Bb.c(this.ub.mAdTemplate, false);
        e eVar = new e((KsAdWebView) findViewById(R.id.ksad_reward_apk_info_card_h5), this.AZ, this.ub.mApkDownloadHelper, this);
        this.Ba = eVar;
        eVar.a(new f() { // from class: com.kwad.components.ad.reward.presenter.g.b.2
            @Override // com.kwad.components.ad.reward.n.f
            public final void i(String str, int i) {
                com.kwad.sdk.core.d.c.d("LaunchAppTaskPresenter", "onUpdateDownloadProgress downloadStatus: " + com.kwad.sdk.core.response.helper.e.eM(b.this.ub.mAdTemplate).status);
                b.this.Bb.j(str, i);
            }
        });
        this.Ba.a(this.ub.mAdTemplate, adBaseFrameLayout);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.sdk.core.d.c.d("LaunchAppTaskPresenter", "onUnbind");
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.b(this.Bi);
        com.kwad.components.ad.reward.b.gu().b(this.mRewardVerifyListener);
        com.kwad.sdk.app.b.Ia().b(this);
        e eVar = this.Ba;
        if (eVar != null) {
            eVar.lw();
            this.Ba = null;
        }
        c cVar = this.Bc;
        if (cVar != null) {
            cVar.lt();
        }
        this.ub.ta = null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void Y(boolean z) {
        com.kwad.components.ad.reward.l.b.a aVar;
        com.kwad.components.ad.reward.l.b.a.a(this.ta, getContext(), this.ub.mAdTemplate);
        if (!this.ta.lk()) {
            if (z) {
                Z(false);
            }
        } else {
            if (z) {
                boolean zKx = kx();
                if (zKx && (aVar = this.ta) != null) {
                    aVar.lj();
                    com.kwad.components.ad.reward.b.gu().notifyRewardVerify();
                    this.ub.sq.onRewardVerify();
                }
                Z(zKx);
                return;
            }
            this.Bg = System.currentTimeMillis();
        }
    }

    private void Z(boolean z) {
        com.kwad.sdk.core.d.c.d("LaunchAppTaskPresenter", "showTaskToast hasShowCompletedToast: " + this.Bh + " completed: " + z);
        if (this.Bh) {
            return;
        }
        ae.c(getContext(), z ? "恭喜！任务达标啦，成功获取奖励~" : "哎呀，差一点就达标啦，再试一次~", 0);
        if (z) {
            this.Bh = true;
        }
    }

    private boolean kx() {
        com.kwad.sdk.core.d.c.d("LaunchAppTaskPresenter", "checkUseAppTime appBackgroundTimestamp: " + this.Bg);
        return this.Bg >= 0 && System.currentTimeMillis() - this.Bg > ((long) (this.Bf * 1000));
    }

    @Override // com.kwad.components.ad.reward.n.c.a
    public final void d(boolean z, int i) {
        this.ub.b(1, getContext(), z ? 1 : MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, 1);
    }

    @Override // com.kwad.sdk.app.a
    public final void T(String str) {
        if (TextUtils.equals(com.kwad.sdk.core.response.helper.a.aE(this.mAdInfo), str) && this.ub.ta != null && g.N(this.ub.mAdTemplate)) {
            this.ub.ta.lh();
            com.kwad.sdk.core.c.b.Mh();
            if (com.kwad.sdk.core.c.b.isAppOnForeground()) {
                return;
            }
            this.Bg = System.currentTimeMillis();
        }
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        aa(true);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (SlideConvertHelper.a(this.ub.mAdTemplate, f, f2, f3, f4)) {
            aa(false);
        }
    }

    private void aa(boolean z) {
        this.ub.a(1, getContext(), z ? 1 : MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, 1);
    }
}
