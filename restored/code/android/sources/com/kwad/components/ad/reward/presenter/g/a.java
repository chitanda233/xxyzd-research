package com.kwad.components.ad.reward.presenter.g;

import android.view.View;
import android.view.ViewGroup;
import android.view.ViewStub;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.reward.e.l;
import com.kwad.components.ad.reward.g;
import com.kwad.components.ad.reward.n.c;
import com.kwad.components.ad.reward.n.e;
import com.kwad.components.ad.reward.n.q;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import com.kwad.sdk.core.webview.KsAdWebView;
import com.kwad.sdk.utils.as;
import com.kwad.sdk.widget.KSFrameLayout;
import com.kwad.sdk.widget.d;
import com.kwad.sdk.widget.h;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends com.kwad.components.ad.reward.presenter.b implements c.a, com.kwad.sdk.core.webview.d.a.a, d {
    private ViewGroup AX;
    private q AY;
    private ViewGroup AZ;
    private e Ba;
    private c Bb;
    private c Bc;
    private final l mRewardVerifyListener = new l() { // from class: com.kwad.components.ad.reward.presenter.g.a.1
        @Override // com.kwad.components.ad.reward.e.l
        public final void onRewardVerify() {
            if (a.this.Bb != null) {
                a.this.Bb.lu();
            }
            if (a.this.Bc != null) {
                a.this.Bc.lu();
            }
        }
    };
    private com.kwad.components.ad.reward.l.a.a tb;

    @Override // com.kwad.sdk.core.webview.d.a.a
    public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.sdk.core.d.c.d("LandPageOpenTaskPresenter", "onBind");
        if (g.O(this.ub.mAdTemplate)) {
            this.tb = com.kwad.components.ad.reward.l.d.ld();
            this.ub.tb = this.tb;
            com.kwad.components.ad.reward.b.gu().a(this.mRewardVerifyListener);
            AdBaseFrameLayout adBaseFrameLayout = (AdBaseFrameLayout) findViewById(R.id.ksad_root_container);
            ViewGroup viewGroup = (ViewGroup) findViewById(R.id.ksad_activity_apk_info_area_native);
            this.AX = viewGroup;
            if (viewGroup != null) {
                viewGroup.setClickable(true);
                this.AX.setVisibility(8);
                new h(this.AX, this);
                c cVar = new c(this.AX);
                this.Bc = cVar;
                cVar.a(this);
                this.Bc.c(this.ub.mAdTemplate, false);
                ((KSFrameLayout) findViewById(R.id.ksad_right_area_webview_container)).setWidthBasedRatio(false);
                q qVar = new q((KsAdWebView) findViewById(R.id.ksad_right_area_webview), this.AX, null, this);
                this.AY = qVar;
                qVar.a(this.ub.mAdTemplate, adBaseFrameLayout);
            }
            a(adBaseFrameLayout);
        }
    }

    private void a(AdBaseFrameLayout adBaseFrameLayout) {
        getContext();
        if (!as.VV()) {
            com.kwad.sdk.core.d.c.d("LandPageOpenTaskPresenter", "initBottomActionBar screen is horizontal");
            return;
        }
        ((ViewStub) findViewById(R.id.ksad_reward_apk_info_stub)).inflate();
        KSFrameLayout kSFrameLayout = (KSFrameLayout) findViewById(R.id.ksad_reward_apk_info_card_root);
        kSFrameLayout.setRadius(getContext().getResources().getDimension(R.dimen.ksad_reward_apk_info_card_step_icon_radius));
        if (com.kwad.sdk.core.response.helper.d.eD(this.ub.mAdTemplate).size() == 0) {
            kSFrameLayout.setRatio(0.0f);
            com.kwad.sdk.c.a.a.p(kSFrameLayout, com.kwad.sdk.c.a.a.a(getContext(), 136.0f));
        } else {
            kSFrameLayout.setRatio(0.0f);
            com.kwad.sdk.c.a.a.p(kSFrameLayout, com.kwad.sdk.c.a.a.a(getContext(), 155.0f));
        }
        ViewGroup viewGroup = (ViewGroup) findViewById(R.id.ksad_reward_apk_info_card_native_container);
        this.AZ = viewGroup;
        viewGroup.setClickable(true);
        new h(this.AZ, this);
        c cVar = new c(this.AZ);
        this.Bb = cVar;
        cVar.a(this);
        this.Bb.c(this.ub.mAdTemplate, true);
        e eVar = new e((KsAdWebView) findViewById(R.id.ksad_reward_apk_info_card_h5), this.AZ, null, this);
        this.Ba = eVar;
        eVar.a(this.ub.mAdTemplate, adBaseFrameLayout);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        com.kwad.sdk.core.d.c.d("LandPageOpenTaskPresenter", "onUnbind");
        e eVar = this.Ba;
        if (eVar != null) {
            eVar.lw();
            this.Ba = null;
        }
        c cVar = this.Bc;
        if (cVar != null) {
            cVar.lt();
        }
        com.kwad.components.ad.reward.b.gu().b(this.mRewardVerifyListener);
        this.ub.tb = null;
    }

    @Override // com.kwad.components.ad.reward.n.c.a
    public final void d(boolean z, int i) {
        e(z, 1);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        e(view, true);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (SlideConvertHelper.a(this.ub.mAdTemplate, f, f2, f3, f4)) {
            e(view, false);
        }
    }

    private void e(View view, boolean z) {
        int id = view.getId();
        if (id == R.id.ksad_reward_apk_info_card_native_container || id == R.id.ksad_activity_apk_info_area_native) {
            e(z, 2);
        }
    }

    private void e(boolean z, int i) {
        this.ub.a(1, getContext(), z ? 1 : MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT, i);
    }
}
