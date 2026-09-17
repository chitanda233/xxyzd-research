package com.kwad.components.ad.reward.presenter.platdetail.actionbar;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.ValueAnimator;
import android.os.SystemClock;
import android.view.animation.DecelerateInterpolator;
import com.kwad.components.ad.reward.e.g;
import com.kwad.components.ad.reward.k.q;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.components.core.t.x;
import com.kwad.components.core.webview.jshandler.ac;
import com.kwad.components.core.webview.jshandler.ae;
import com.kwad.components.core.webview.jshandler.af;
import com.kwad.components.core.webview.jshandler.ai;
import com.kwad.components.core.webview.jshandler.ak;
import com.kwad.components.core.webview.jshandler.al;
import com.kwad.components.core.webview.jshandler.am;
import com.kwad.components.core.webview.jshandler.as;
import com.kwad.components.core.webview.jshandler.az;
import com.kwad.components.core.webview.jshandler.bc;
import com.kwad.components.core.webview.jshandler.n;
import com.kwad.components.core.webview.jshandler.o;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;

/* JADX INFO: loaded from: classes3.dex */
public final class f extends com.kwad.components.ad.reward.presenter.b {
    private KsAdWebView eZ;
    private al.a fa;
    private com.kwad.components.core.webview.a fb;
    private com.kwad.sdk.core.webview.b fc;
    private az ff;
    private ValueAnimator fk;
    private ValueAnimator fl;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;
    private String mUrl;
    private RewardActionBarControl st;
    private KsLogoView wD;
    private boolean zk;
    private long zl;
    private int fe = -1;
    private RewardActionBarControl.d yS = new RewardActionBarControl.d() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.f.1
        @Override // com.kwad.components.ad.reward.presenter.platdetail.actionbar.RewardActionBarControl.d
        public final boolean f(a aVar) {
            f fVar = f.this;
            fVar.zk = fVar.f(aVar);
            return f.this.zk;
        }
    };
    private g mPlayEndPageListener = new com.kwad.components.ad.reward.e.a() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.f.2
        @Override // com.kwad.components.ad.reward.e.g
        public final void cZ() {
            f.this.release();
        }
    };
    private com.kwad.sdk.core.webview.d.a.a fg = new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.f.3
        @Override // com.kwad.sdk.core.webview.d.a.a
        public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
            f.this.ub.sq.cY();
        }
    };
    private al.b fh = new al.b() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.f.5
        @Override // com.kwad.components.core.webview.jshandler.al.b
        public final void a(al.a aVar) {
            f.this.fa = aVar;
            f.this.eZ.setTranslationY(aVar.height + aVar.bottomMargin);
        }
    };
    private ak.b fi = new ak.b() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.f.6
        @Override // com.kwad.components.core.webview.jshandler.ak.b
        public final void a(ak.a aVar) {
            f.this.zk = false;
            f.this.bl();
        }
    };
    private as.b fj = new as.b() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.f.7
        @Override // com.kwad.components.core.webview.jshandler.as.b
        public final void a(as.a aVar) {
            f.this.fe = aVar.status;
            long jElapsedRealtime = SystemClock.elapsedRealtime() - f.this.zl;
            com.kwad.sdk.core.d.c.i("RewardActionBarWeb", "load time:" + jElapsedRealtime + ", pageStatus: " + f.this.fe);
            if (f.this.fe == 1) {
                com.kwad.components.core.p.a.vX().i(f.this.ub.mAdTemplate, jElapsedRealtime);
            } else {
                com.kwad.components.ad.reward.monitor.d.a(f.this.ub.mAdTemplate, f.this.ub.sG, "play_card", com.kwad.sdk.core.response.helper.b.cQ(f.this.ub.mAdTemplate), System.currentTimeMillis() - f.this.eZ.getLoadTime(), 3);
            }
            if (f.this.ub.gW()) {
                return;
            }
            f.this.st.jA();
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.eZ = (KsAdWebView) findViewById(R.id.ksad_play_web_card_webView);
        this.wD = (KsLogoView) findViewById(R.id.ksad_ad_label_play_bar);
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        com.kwad.components.ad.reward.monitor.d.a(this.ub.sG, "play_card");
        RewardActionBarControl rewardActionBarControl = this.ub.st;
        this.st = rewardActionBarControl;
        rewardActionBarControl.a(this.yS);
        dq();
    }

    private void dq() {
        if (this.eZ == null || !com.kwad.sdk.core.response.helper.b.cS(this.ub.mAdTemplate)) {
            return;
        }
        this.mApkDownloadHelper = this.ub.mApkDownloadHelper;
        be();
        bf();
        this.ub.b(this.mPlayEndPageListener);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        RewardActionBarControl rewardActionBarControl = this.st;
        if (rewardActionBarControl != null) {
            rewardActionBarControl.a((RewardActionBarControl.d) null);
        }
        this.ub.c(this.mPlayEndPageListener);
        bn();
        release();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void release() {
        this.fe = -1;
        KsAdWebView ksAdWebView = this.eZ;
        if (ksAdWebView != null) {
            ksAdWebView.setVisibility(8);
        }
        bh();
    }

    private void be() {
        com.kwad.sdk.core.webview.b bVar = new com.kwad.sdk.core.webview.b();
        this.fc = bVar;
        bVar.setAdTemplate(this.ub.mAdTemplate);
        this.fc.mScreenOrientation = this.ub.mScreenOrientation;
        this.fc.bbV = this.ub.mRootContainer;
        this.fc.adZ = this.ub.mRootContainer;
        this.fc.adg = this.eZ;
    }

    private void bf() {
        this.fe = -1;
        bg();
        this.eZ.setBackgroundColor(0);
        this.eZ.getBackground().setAlpha(0);
        this.eZ.setVisibility(4);
        this.eZ.setClientConfig(this.eZ.getClientConfig().fm(this.ub.mAdTemplate).b(jE()));
        this.zl = SystemClock.elapsedRealtime();
        this.mUrl = com.kwad.sdk.core.response.helper.b.cQ(this.ub.mAdTemplate);
        com.kwad.sdk.core.d.c.d("RewardActionBarWeb", "startPreloadWebView url: " + this.mUrl);
        com.kwad.components.ad.reward.monitor.d.a(this.ub.mAdTemplate, this.ub.sG, "play_card", this.mUrl);
        this.eZ.loadUrl(this.mUrl);
    }

    private KsAdWebView.e jE() {
        return new KsAdWebView.e() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.f.4
            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageStart() {
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onReceivedHttpError(int i, String str, String str2) {
                com.kwad.components.ad.reward.monitor.d.a(f.this.ub.mAdTemplate, f.this.ub.sG, "play_card", com.kwad.sdk.core.response.helper.b.cQ(f.this.ub.mAdTemplate), System.currentTimeMillis() - f.this.eZ.getLoadTime(), 2);
            }

            @Override // com.kwad.sdk.core.webview.KsAdWebView.e
            public final void onPageFinished() {
                com.kwad.components.ad.reward.monitor.d.a(f.this.ub.sG, "play_card", f.this.mUrl, System.currentTimeMillis() - f.this.eZ.getLoadTime());
            }
        };
    }

    private void bg() {
        bh();
        com.kwad.components.core.webview.a aVar = new com.kwad.components.core.webview.a(this.eZ);
        this.fb = aVar;
        a(aVar);
        this.eZ.addJavascriptInterface(this.fb, "KwaiAd");
    }

    private void bh() {
        com.kwad.components.core.webview.a aVar = this.fb;
        if (aVar != null) {
            aVar.destroy();
            this.fb = null;
        }
    }

    private void a(com.kwad.components.core.webview.a aVar) {
        aVar.a(new ac(this.fc, this.mApkDownloadHelper, this.fg, (byte) 0));
        aVar.a(new com.kwad.components.core.webview.tachikoma.b.f());
        aVar.a(new q(this.fc, this.mApkDownloadHelper, this.ub, -1L, this.fg, null));
        aVar.a(new af(this.fc));
        aVar.a(new ai(this.fc));
        aVar.a(new ae(this.fc));
        aVar.a(new al(this.fc, this.fh));
        aVar.a(new as(this.fj, com.kwad.sdk.core.response.helper.b.cQ(this.ub.mAdTemplate)));
        az azVar = new az();
        this.ff = azVar;
        aVar.a(azVar);
        aVar.a(new bc(this.fc, this.mApkDownloadHelper));
        aVar.a(new ak(this.fi));
        aVar.a(new am(this.fc));
        aVar.b(new o(this.fc));
        aVar.b(new n(this.fc));
        aVar.a(new com.kwad.components.ad.reward.i.b(getContext(), this.ub.mAdTemplate, PlayableSource.ACTIONBAR_CLICK));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean f(a aVar) {
        KsAdWebView ksAdWebView = this.eZ;
        if (ksAdWebView == null) {
            return false;
        }
        if (ksAdWebView.getVisibility() == 0) {
            return true;
        }
        if (this.fe == 1) {
            g(aVar);
            return true;
        }
        bo();
        return false;
    }

    private void g(final a aVar) {
        if (this.fa == null) {
            bk();
            return;
        }
        X(this.ub.mAdTemplate);
        bn();
        this.eZ.setVisibility(0);
        ValueAnimator valueAnimatorC = x.c(this.eZ, this.fa.height + this.fa.bottomMargin, 0);
        this.fk = valueAnimatorC;
        valueAnimatorC.setInterpolator(new DecelerateInterpolator(2.0f));
        this.fk.setDuration(500L);
        this.fk.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.f.8
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationStart(Animator animator) {
                super.onAnimationStart(animator);
                if (f.this.ff != null) {
                    f.this.ff.yJ();
                }
            }

            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                if (f.this.ff != null) {
                    f.this.ff.yK();
                }
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.a(RewardActionBarControl.ShowActionBarResult.SHOW_H5_SUCCESS, f.this.eZ);
                }
            }
        });
        this.fk.start();
    }

    private void bk() {
        X(this.ub.mAdTemplate);
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yJ();
        }
        this.eZ.setVisibility(0);
        az azVar2 = this.ff;
        if (azVar2 != null) {
            azVar2.yK();
        }
    }

    private void X(AdTemplate adTemplate) {
        KsLogoView ksLogoView;
        if (!com.kwad.sdk.core.response.helper.a.cS(com.kwad.sdk.core.response.helper.e.eM(adTemplate)) || com.kwad.sdk.utils.as.isOrientationPortrait() || (ksLogoView = this.wD) == null) {
            return;
        }
        ksLogoView.setVisibility(0);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bl() {
        if (this.eZ.getVisibility() != 0) {
            return;
        }
        if (this.fa == null) {
            bm();
            return;
        }
        bn();
        ValueAnimator valueAnimatorC = x.c(this.eZ, 0, this.fa.height + this.fa.bottomMargin);
        this.fl = valueAnimatorC;
        valueAnimatorC.setInterpolator(new DecelerateInterpolator(2.0f));
        this.fl.setDuration(300L);
        this.fl.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.reward.presenter.platdetail.actionbar.f.9
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationStart(Animator animator) {
                super.onAnimationStart(animator);
                if (f.this.ff != null) {
                    f.this.ff.yL();
                }
            }

            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                f.this.eZ.setVisibility(4);
                if (f.this.ff != null) {
                    f.this.ff.yM();
                }
            }
        });
        this.fl.start();
    }

    private void bm() {
        if (this.eZ.getVisibility() != 0) {
            return;
        }
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yL();
        }
        this.eZ.setVisibility(4);
        az azVar2 = this.ff;
        if (azVar2 != null) {
            azVar2.yM();
        }
    }

    private void bn() {
        ValueAnimator valueAnimator = this.fk;
        if (valueAnimator != null) {
            valueAnimator.removeAllListeners();
            this.fk.cancel();
        }
        ValueAnimator valueAnimator2 = this.fl;
        if (valueAnimator2 != null) {
            valueAnimator2.removeAllListeners();
            this.fl.cancel();
        }
    }

    private void bo() {
        String str;
        int i = this.fe;
        if (i == -1) {
            str = "timeout";
        } else {
            str = i != 1 ? "h5error" : "others";
        }
        com.kwad.sdk.core.d.c.w("RewardActionBarWeb", "show webCard fail, reason: ".concat(str));
    }
}
