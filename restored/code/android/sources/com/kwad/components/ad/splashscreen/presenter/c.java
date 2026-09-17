package com.kwad.components.ad.splashscreen.presenter;

import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.kwad.components.ad.splashscreen.local.SplashSkipViewModel;
import com.kwad.components.ad.splashscreen.widget.SkipView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.br;
import com.kwad.sdk.utils.by;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends e implements com.kwad.sdk.core.j.c {
    private TextView Hm;
    private com.kwad.components.ad.splashscreen.widget.b Hn;
    private AdInfo.AdPreloadInfo Ho;
    private boolean Hp = false;
    private View Hq;
    private AdInfo wp;

    @Override // com.kwad.components.ad.splashscreen.presenter.e, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.sdk.core.d.c.d("SkipAdPresenter", "onBind");
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.Hu.mAdTemplate);
        this.wp = adInfoEM;
        u(adInfoEM);
        w(this.wp);
        if (v(this.wp)) {
            this.Hn = (com.kwad.components.ad.splashscreen.widget.b) findViewById(com.kwad.components.ad.splashscreen.e.c.A(this.wp) ? R.id.ksad_splash_skip_right_view : R.id.ksad_splash_skip_left_view);
        } else {
            this.Hn = (com.kwad.components.ad.splashscreen.widget.b) findViewById(com.kwad.components.ad.splashscreen.e.c.A(this.wp) ? R.id.ksad_splash_circle_skip_right_view : R.id.ksad_splash_circle_skip_left_view);
        }
        this.Hn.a(mu(), this.wp);
        this.Hn.setOnViewListener(new SkipView.a() { // from class: com.kwad.components.ad.splashscreen.presenter.c.1
            @Override // com.kwad.components.ad.splashscreen.widget.SkipView.a
            public final void my() {
                c.this.mv();
            }

            @Override // com.kwad.components.ad.splashscreen.widget.SkipView.a
            public final void mz() {
                c.this.mw();
            }

            @Override // com.kwad.components.ad.splashscreen.widget.SkipView.a
            public final void ao(int i) {
                c.this.Hu.an(i);
            }
        });
        x(this.wp);
        this.Hu.GH.a(this);
    }

    private void u(AdInfo adInfo) {
        findViewById(com.kwad.components.ad.splashscreen.e.c.A(adInfo) ? R.id.ksad_splash_right_top_root : R.id.ksad_splash_left_top_root).setVisibility(0);
    }

    private SplashSkipViewModel mu() {
        SplashSkipViewModel splashSkipViewModel = new SplashSkipViewModel();
        int i = this.wp.adSplashInfo.imageDisplaySecond <= 0 ? 5 : this.wp.adSplashInfo.imageDisplaySecond;
        int iMin = Math.min(this.wp.adSplashInfo.videoDisplaySecond, com.kwad.sdk.core.response.helper.a.N(this.wp));
        if (com.kwad.sdk.core.response.helper.a.bi(this.wp)) {
            i = iMin;
        }
        splashSkipViewModel.skipSecond = i;
        return splashSkipViewModel;
    }

    private static boolean v(AdInfo adInfo) {
        return !com.kwad.sdk.core.response.helper.a.cI(adInfo);
    }

    private void w(AdInfo adInfo) {
        int i;
        if (com.kwad.components.ad.splashscreen.e.c.A(adInfo)) {
            i = R.id.ksad_splash_preload_right_tips;
        } else {
            i = R.id.ksad_splash_preload_left_tips;
        }
        this.Hm = (TextView) findViewById(i);
        AdInfo.AdPreloadInfo adPreloadInfo = adInfo.adPreloadInfo;
        this.Ho = adPreloadInfo;
        if (adPreloadInfo != null && !br.isNullString(adPreloadInfo.preloadTips)) {
            this.Hm.setVisibility(0);
            this.Hm.setText(this.Ho.preloadTips);
        } else {
            this.Hm.setVisibility(8);
        }
    }

    private void x(AdInfo adInfo) {
        this.Hq = findViewById(R.id.ksad_skip_view_area);
        if (com.kwad.sdk.core.response.helper.a.cJ(adInfo) && adInfo.adSplashInfo.skipButtonPosition == 0) {
            this.Hq.setVisibility(0);
            this.Hq.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.splashscreen.presenter.c.2
                @Override // android.view.View.OnClickListener
                public final void onClick(View view) {
                    c.this.mv();
                }
            });
            this.Hq.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.c.3
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    ((View) c.this.Hn).post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.c.3.1
                        @Override // com.kwad.sdk.utils.bi
                        public final void doTask() {
                            int iAq = c.this.Hn.aq(35);
                            ViewGroup.LayoutParams layoutParams = c.this.Hq.getLayoutParams();
                            layoutParams.width = iAq + com.kwad.sdk.c.a.a.a(c.this.Hu.mRootContainer.getContext(), 66.0f);
                            c.this.Hq.setLayoutParams(layoutParams);
                        }
                    });
                }
            });
            return;
        }
        this.Hq.setVisibility(8);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void mv() {
        com.kwad.components.ad.splashscreen.monitor.a.mr().ak(this.Hu.mAdTemplate);
        this.Hu.mm();
        JSONObject jSONObject = new JSONObject();
        if (this.Hu.GF != null) {
            try {
                jSONObject.put(MediationConstant.EXTRA_DURATION, this.Hu.GF.getCurrentPosition());
            } catch (JSONException e) {
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        }
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        if (this.Hu.mTimerHelper != null) {
            c0502a.duration = this.Hu.mTimerHelper.getTime();
        }
        com.kwad.sdk.core.adlog.c.b(this.Hu.mAdTemplate, new com.kwad.sdk.core.adlog.c.b().dT(1).eb(22).b(c0502a), jSONObject);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.Hu.GH.b(this);
        by.postOnUiThread(new Runnable() { // from class: com.kwad.components.ad.splashscreen.presenter.c.4
            @Override // java.lang.Runnable
            public final void run() {
                if (c.this.Hn != null) {
                    c.this.Hn.cs();
                }
            }
        });
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bv() {
        com.kwad.sdk.core.d.c.d("SkipAdPresenter", "onPageVisible");
        this.Hn.C(this.wp);
        mx();
    }

    public final void mw() {
        this.Hu.mRootContainer.post(new bi() { // from class: com.kwad.components.ad.splashscreen.presenter.c.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                if (com.kwad.components.core.e.c.b.pF()) {
                    c.this.Hu.mRootContainer.postDelayed(this, 1000L);
                } else {
                    c.this.Hu.mk();
                }
            }
        });
    }

    private synchronized void mx() {
        if (!this.Hp && this.Hn != null) {
            if (com.kwad.sdk.core.response.helper.a.cK(this.wp) && com.kwad.sdk.core.response.helper.a.cL(this.wp)) {
                com.kwad.sdk.core.adlog.c.b(this.Hu.mAdTemplate, 124, (JSONObject) null);
                this.Hp = true;
            }
        }
    }

    @Override // com.kwad.sdk.core.j.c
    public final void bw() {
        com.kwad.sdk.core.d.c.d("SkipAdPresenter", "onPageInvisible");
        this.Hn.B(this.wp);
    }
}
