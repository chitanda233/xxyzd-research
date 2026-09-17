package com.kwad.components.ad.draw.presenter.b;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;
import android.animation.ValueAnimator;
import android.view.ViewGroup;
import android.view.animation.DecelerateInterpolator;
import com.kwad.components.core.e.d.d;
import com.kwad.components.core.t.x;
import com.kwad.components.core.video.l;
import com.kwad.components.core.video.m;
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
import com.kwad.components.core.webview.jshandler.z;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.webview.KsAdWebView;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.ad.draw.b.a {
    private ViewGroup dZ;
    private KsAdWebView eZ;
    private al.a fa;
    private com.kwad.components.core.webview.a fb;
    private com.kwad.sdk.core.webview.b fc;
    private az ff;
    private ValueAnimator fk;
    private ValueAnimator fl;
    private AdTemplate mAdTemplate;
    private d mApkDownloadHelper;
    private int fe = -1;
    private l mVideoPlayStateListener = new m() { // from class: com.kwad.components.ad.draw.presenter.b.c.1
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayCompleted() {
            super.onMediaPlayCompleted();
            c.this.release();
        }
    };
    private a.b eU = new a.b() { // from class: com.kwad.components.ad.draw.presenter.b.c.2
        @Override // com.kwad.components.ad.draw.presenter.b.a.b
        public final boolean aY() {
            return c.this.bi();
        }
    };
    private com.kwad.sdk.core.webview.d.a.a fg = new com.kwad.sdk.core.webview.d.a.a() { // from class: com.kwad.components.ad.draw.presenter.b.c.3
        @Override // com.kwad.sdk.core.webview.d.a.a
        public final void a(com.kwad.sdk.core.webview.d.b.a aVar) {
            if (c.this.dL.du != null) {
                c.this.dL.du.onAdClicked();
            }
        }
    };
    private al.b fh = new al.b() { // from class: com.kwad.components.ad.draw.presenter.b.c.4
        @Override // com.kwad.components.core.webview.jshandler.al.b
        public final void a(al.a aVar) {
            c.this.fa = aVar;
            c.this.eZ.setTranslationY(aVar.height + aVar.bottomMargin);
        }
    };
    private ak.b fi = new ak.b() { // from class: com.kwad.components.ad.draw.presenter.b.c.5
        @Override // com.kwad.components.core.webview.jshandler.ak.b
        public final void a(ak.a aVar) {
            c.this.bl();
        }
    };
    private as.b fj = new as.b() { // from class: com.kwad.components.ad.draw.presenter.b.c.6
        @Override // com.kwad.components.core.webview.jshandler.as.b
        public final void a(as.a aVar) {
            c.this.fe = aVar.status;
            com.kwad.sdk.core.d.c.i("DrawPlayWebCard", "updatePageStatus mPageState: " + aVar);
        }
    };

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.dZ = (ViewGroup) findViewById(R.id.ksad_ad_normal_container);
        this.eZ = (KsAdWebView) findViewById(R.id.ksad_play_web_card_webView);
    }

    @Override // com.kwad.components.ad.draw.b.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.mAdTemplate = this.dL.mAdTemplate;
        this.dL.dQ.a(this.eU);
        this.mApkDownloadHelper = this.dL.mApkDownloadHelper;
        this.dL.dN.b(this.mVideoPlayStateListener);
        be();
        bf();
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.dL.dQ.a((a.b) null);
        this.dL.dN.a(this.mVideoPlayStateListener);
        bn();
        release();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void release() {
        this.fe = -1;
        this.eZ.setVisibility(8);
        bh();
    }

    private void be() {
        com.kwad.sdk.core.webview.b bVar = new com.kwad.sdk.core.webview.b();
        this.fc = bVar;
        bVar.setAdTemplate(this.dL.mAdTemplate);
        this.fc.mScreenOrientation = 0;
        this.fc.bbV = this.dL.mRootContainer;
        this.fc.adZ = this.dL.mRootContainer;
        this.fc.adg = this.eZ;
    }

    private void bf() {
        this.fe = -1;
        bg();
        this.eZ.setBackgroundColor(0);
        this.eZ.getBackground().setAlpha(0);
        this.eZ.setVisibility(4);
        this.eZ.loadUrl(com.kwad.sdk.core.response.helper.b.cQ(this.mAdTemplate));
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
        aVar.a(new z(this.fc, this.mApkDownloadHelper, this.fg));
        aVar.a(new af(this.fc));
        aVar.a(new ai(this.fc));
        aVar.a(new ae(this.fc));
        aVar.a(new al(this.fc, this.fh));
        aVar.a(new as(this.fj, com.kwad.sdk.core.response.helper.b.cQ(this.mAdTemplate)));
        az azVar = new az();
        this.ff = azVar;
        aVar.a(azVar);
        aVar.a(new bc(this.fc, this.mApkDownloadHelper));
        aVar.a(new ak(this.fi));
        aVar.a(new am(this.fc));
        aVar.b(new o(this.fc));
        aVar.b(new n(this.fc));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean bi() {
        if (this.fe == 1) {
            bj();
            return true;
        }
        bo();
        return false;
    }

    private void bj() {
        if (this.fa == null) {
            bk();
            return;
        }
        bn();
        this.dZ.setVisibility(8);
        this.eZ.setVisibility(0);
        ValueAnimator valueAnimatorC = x.c(this.eZ, this.fa.height + this.fa.bottomMargin, 0);
        this.fk = valueAnimatorC;
        valueAnimatorC.setInterpolator(new DecelerateInterpolator(2.0f));
        this.fk.setDuration(300L);
        this.fk.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.draw.presenter.b.c.7
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationStart(Animator animator) {
                super.onAnimationStart(animator);
                if (c.this.ff != null) {
                    c.this.ff.yJ();
                }
            }

            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                if (c.this.ff != null) {
                    c.this.ff.yK();
                }
            }
        });
        this.fk.start();
    }

    private void bk() {
        az azVar = this.ff;
        if (azVar != null) {
            azVar.yJ();
        }
        this.dZ.setVisibility(8);
        this.eZ.setVisibility(0);
        az azVar2 = this.ff;
        if (azVar2 != null) {
            azVar2.yK();
        }
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
        this.fl.addListener(new AnimatorListenerAdapter() { // from class: com.kwad.components.ad.draw.presenter.b.c.8
            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationStart(Animator animator) {
                super.onAnimationStart(animator);
                if (c.this.ff != null) {
                    c.this.ff.yL();
                }
            }

            @Override // android.animation.AnimatorListenerAdapter, android.animation.Animator.AnimatorListener
            public final void onAnimationEnd(Animator animator) {
                super.onAnimationEnd(animator);
                c.this.eZ.setVisibility(4);
                c.this.dZ.setVisibility(0);
                if (c.this.ff != null) {
                    c.this.ff.yM();
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
        this.dZ.setVisibility(0);
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
        com.kwad.sdk.core.d.c.w("DrawPlayWebCard", "show webCard fail, reason: ".concat(str));
    }
}
